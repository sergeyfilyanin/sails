﻿using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using EnsureThat;
using Nito.AsyncEx;
using Sails.TestUtils.Containers;
using Sails.TestUtils.Git;
using Xunit;

namespace Sails.TestUtils.XUnit.Fixtures;

public abstract partial class SailsFixture : IAsyncLifetime
{
    protected SailsFixture(string sailsRsVersion)
    {
        EnsureArg.IsNotNullOrWhiteSpace(sailsRsVersion, nameof(sailsRsVersion));

        this.sailsRsReleaseTag = $"rs/v{sailsRsVersion}";
        this.demoContractIdl = new AsyncLazy<string>(
            () => this.DownloadStringAsset("demo.idl"),
            AsyncLazyFlags.RetryOnFailure);
        this.demoContractWasm = new AsyncLazy<MemoryStream>(
            () => this.DownloadOctetAsset("demo.wasm"),
            AsyncLazyFlags.RetryOnFailure);
        this.noSvcsProgContractIdl = new AsyncLazy<string>(
            () => this.DownloadStringAsset("no-svcs-prog.idl"),
            AsyncLazyFlags.RetryOnFailure);
        this.noSvcsProgContractWasm = new AsyncLazy<MemoryStream>(
            () => this.DownloadOctetAsset("no_svcs_prog.wasm"),
            AsyncLazyFlags.RetryOnFailure);
        this.gearNodeContainer = null;
    }

    private static readonly GithubDownloader GithubDownloader = new("gear-tech", "sails");

    private readonly string sailsRsReleaseTag;
    private readonly AsyncLazy<string> demoContractIdl;
    private readonly AsyncLazy<MemoryStream> demoContractWasm;
    private readonly AsyncLazy<string> noSvcsProgContractIdl;
    private readonly AsyncLazy<MemoryStream> noSvcsProgContractWasm;
    private GearNodeContainer? gearNodeContainer;

    public Uri GearNodeWsUrl => this.gearNodeContainer?.WsUrl
        ?? throw new InvalidOperationException("Gear node container is not initialized.");

    public async Task DisposeAsync()
    {
        if (this.gearNodeContainer is not null)
        {
            await this.gearNodeContainer.DisposeAsync();
            this.gearNodeContainer = null;
        }
        if (this.demoContractWasm.IsStarted)
        {
            await (await this.demoContractWasm).DisposeAsync();
        }
        if (this.noSvcsProgContractWasm.IsStarted)
        {
            await (await this.noSvcsProgContractWasm).DisposeAsync();
        }
    }

    public async Task InitializeAsync()
    {
        var sailsRsCargoToml = await this.DownloadSailsRsCargoTomlAsync();

        var matchResult = GStdDependencyRegex().Match(sailsRsCargoToml);
        if (!matchResult.Success)
        {
            throw new InvalidOperationException(
                $"Failed to find gstd dependency in Cargo.toml by the '{this.sailsRsReleaseTag}' tag.");
        }
        var gearNodeVersion = matchResult.Groups[1].Value;

        // The `reuse` parameter can be made configurable if needed
        this.gearNodeContainer = new GearNodeContainer(gearNodeVersion, reuse: true);
        await this.gearNodeContainer.StartAsync();
    }

    public Task<string> GetDemoContractIdlAsync()
        => this.demoContractIdl.Task;

    public async Task<ReadOnlyMemory<byte>> GetDemoContractWasmAsync()
    {
        var byteStream = await this.demoContractWasm;
        Ensure.Comparable.IsLte(byteStream.Length, int.MaxValue);
        return new ReadOnlyMemory<byte>(byteStream.GetBuffer(), start: 0, length: (int)byteStream.Length);
    }

    public Task<string> GetNoSvcsProgContractIdlAsync()
        => this.noSvcsProgContractIdl.Task;

    public async Task<ReadOnlyMemory<byte>> GetNoSvcsProgContractWasmAsync()
    {
        var byteStream = await this.noSvcsProgContractWasm;
        Ensure.Comparable.IsLte(byteStream.Length, int.MaxValue);
        return new ReadOnlyMemory<byte>(byteStream.GetBuffer(), start: 0, length: (int)byteStream.Length);
    }

    private async Task<string> DownloadStringAsset(string assetName)
    {
        var downloadStream = await GithubDownloader.DownloadReleaseAssetAsync(
            this.sailsRsReleaseTag,
            assetName,
            CancellationToken.None);
        using (var reader = new StreamReader(downloadStream, leaveOpen: false))
        {
            return await reader.ReadToEndAsync(CancellationToken.None);
        }
    }

    private async Task<MemoryStream> DownloadOctetAsset(string assetName)
    {
        var downloadStream = await GithubDownloader.DownloadReleaseAssetAsync(
            this.sailsRsReleaseTag,
            assetName,
            CancellationToken.None);
        var memoryStream = new MemoryStream();
        await downloadStream.CopyToAsync(memoryStream);
        return memoryStream;
    }

    private async Task<string> DownloadSailsRsCargoTomlAsync()
    {
        var downloadStream = await GithubDownloader.DownloadFileFromTagAsync(
            this.sailsRsReleaseTag,
            "Cargo.toml",
            CancellationToken.None);
        using (var reader = new StreamReader(downloadStream, leaveOpen: false))
        {
            return await reader.ReadToEndAsync(CancellationToken.None);
        }
    }

    [GeneratedRegex(@"gstd\s*=\s*""=?(\d+\.\d+\.\d+)""")]
    private static partial Regex GStdDependencyRegex();
}