﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using EnsureThat;
using Sails.Remoting.Abstractions;
using Sails.Remoting.Abstractions.Core;
using Substrate.Gear.Api.Generated.Model.gprimitives;
using Substrate.NetApi.Model.Types;
using GasUnit = Substrate.NetApi.Model.Types.Primitive.U64;
using ValueUnit = Substrate.NetApi.Model.Types.Primitive.U128;

namespace Sails.Remoting;

public sealed class RemotingAction<T>(IRemoting remoting, byte[] route, IType args) : IActivation, IQuery<T>, ICall<T>
    where T : IType, new()
{
    private GasUnit? gasLimit;
    private ValueUnit value = new();

    /// <inheritdoc />
    public async Task<IReply<ActorId>> ActivateAsync(
        CodeId codeId,
        IReadOnlyCollection<byte> salt,
        CancellationToken cancellationToken)
    {
        EnsureArg.IsNotNull(codeId, nameof(codeId));
        EnsureArg.IsNotNull(salt, nameof(salt));

        var encodedPayload = this.EncodePayload();

        var remotingReply = await remoting.ActivateAsync(
            codeId,
            salt,
            encodedPayload,
            gasLimit: this.gasLimit,
            value: this.value,
            cancellationToken).ConfigureAwait(false);

        return new DelegatingReply<(ActorId ProgramId, byte[] EncodedReply), ActorId>(remotingReply, res =>
        {
            EnsureRoute(res.EncodedReply, route);
            return res.ProgramId;
        });
    }

    /// <inheritdoc />
    public async Task<IReply<T>> MessageAsync(ActorId programId, CancellationToken cancellationToken)
    {
        EnsureArg.IsNotNull(programId, nameof(programId));

        var encodedPayload = this.EncodePayload();

        var remotingReply = await remoting.MessageAsync(
            programId,
            encodedPayload,
            gasLimit: this.gasLimit,
            value: this.value,
            cancellationToken).ConfigureAwait(false);

        return new DelegatingReply<byte[], T>(remotingReply, this.DecodePayload);
    }

    /// <inheritdoc />
    public async Task<T> QueryAsync(ActorId programId, CancellationToken cancellationToken)
    {
        EnsureArg.IsNotNull(programId, nameof(programId));

        var encodedPayload = this.EncodePayload();

        var replyBytes = await remoting.QueryAsync(
            programId,
            encodedPayload,
            gasLimit: this.gasLimit,
            value: this.value,
            cancellationToken).ConfigureAwait(false);

        return this.DecodePayload(replyBytes);
    }

    /// <inheritdoc />
    public RemotingAction<T> WithGasLimit(GasUnit gasLimit)
    {
        EnsureArg.IsNotNull(gasLimit, nameof(gasLimit));

        this.gasLimit = gasLimit;
        return this;
    }

    /// <inheritdoc />
    public RemotingAction<T> WithValue(ValueUnit value)
    {
        EnsureArg.IsNotNull(value, nameof(value));

        this.value = value;
        return this;
    }

    private byte[] EncodePayload()
    {
        var encodedArgs = args.Encode();
        var payload = new byte[route.Length + encodedArgs.Length];
        Buffer.BlockCopy(route.ToArray(), 0, payload, 0, route.Length);
        Buffer.BlockCopy(encodedArgs, 0, payload, route.Length, encodedArgs.Length);
        return payload;
    }

    private T DecodePayload(byte[] bytes)
    {
        EnsureRoute(bytes, route);
        var p = route.Length;
        T value = new();
        value.Decode(bytes, ref p);
        return value;
    }

    private static void EnsureRoute(byte[] bytes, byte[] route)
    {
        if (bytes.Length < route.Length || !route.AsSpan().SequenceEqual(bytes.AsSpan()[..route.Length]))
        {
            // TODO: custom invalid route exception
            throw new ArgumentException();
        }
    }

    IActivation IActionBuilder<IActivation>.WithGasLimit(GasUnit gasLimit) => this.WithGasLimit(gasLimit);
    IQuery<T> IActionBuilder<IQuery<T>>.WithGasLimit(GasUnit gasLimit) => this.WithGasLimit(gasLimit);
    ICall<T> IActionBuilder<ICall<T>>.WithGasLimit(GasUnit gasLimit) => this.WithGasLimit(gasLimit);

    IActivation IActionBuilder<IActivation>.WithValue(ValueUnit value) => this.WithValue(value);
    IQuery<T> IActionBuilder<IQuery<T>>.WithValue(ValueUnit value) => this.WithValue(value);
    ICall<T> IActionBuilder<ICall<T>>.WithValue(ValueUnit value) => this.WithValue(value);
}
