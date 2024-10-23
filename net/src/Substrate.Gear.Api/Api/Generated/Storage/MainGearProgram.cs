//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi;
using Substrate.NetApi.Model.Extrinsics;
using Substrate.NetApi.Model.Meta;
using Substrate.NetApi.Model.Types;
using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace Substrate.Gear.Api.Generated.Storage
{
    
    
    /// <summary>
    /// >> GearProgramStorage
    /// </summary>
    public sealed class GearProgramStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        /// <summary>
        /// >> GearProgramStorage Constructor
        /// </summary>
        public GearProgramStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("GearProgram", "CodeStorage"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, typeof(Substrate.Gear.Api.Generated.Model.gprimitives.CodeId), typeof(Substrate.Gear.Api.Generated.Model.gear_core.code.instrumented.InstrumentedCode)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("GearProgram", "CodeLenStorage"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, typeof(Substrate.Gear.Api.Generated.Model.gprimitives.CodeId), typeof(Substrate.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("GearProgram", "OriginalCodeStorage"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, typeof(Substrate.Gear.Api.Generated.Model.gprimitives.CodeId), typeof(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("GearProgram", "MetadataStorage"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, typeof(Substrate.Gear.Api.Generated.Model.gprimitives.CodeId), typeof(Substrate.Gear.Api.Generated.Model.gear_common.CodeMetadata)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("GearProgram", "AllocationsStorage"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, typeof(Substrate.Gear.Api.Generated.Model.gprimitives.ActorId), typeof(Substrate.Gear.Api.Generated.Model.numerated.tree.IntervalsTree)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("GearProgram", "ProgramStorage"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, typeof(Substrate.Gear.Api.Generated.Model.gprimitives.ActorId), typeof(Substrate.Gear.Api.Generated.Model.gear_core.program.EnumProgram)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("GearProgram", "MemoryPages"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Identity,
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Identity,
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Gear.Api.Generated.Model.gprimitives.ActorId, Substrate.Gear.Api.Generated.Model.gear_core.program.MemoryInfix, Substrate.Gear.Api.Generated.Model.gear_core.pages.PageT2>), typeof(Substrate.Gear.Api.Generated.Model.gear_core.memory.PageBuf)));
        }
        
        /// <summary>
        /// >> CodeStorageParams
        /// </summary>
        public static string CodeStorageParams(Substrate.Gear.Api.Generated.Model.gprimitives.CodeId key)
        {
            return RequestGenerator.GetStorage("GearProgram", "CodeStorage", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> CodeStorageDefault
        /// Default value as hex string
        /// </summary>
        public static string CodeStorageDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> CodeStorage
        /// </summary>
        public async Task<Substrate.Gear.Api.Generated.Model.gear_core.code.instrumented.InstrumentedCode> CodeStorage(Substrate.Gear.Api.Generated.Model.gprimitives.CodeId key, string blockhash, CancellationToken token)
        {
            string parameters = GearProgramStorage.CodeStorageParams(key);
            var result = await _client.GetStorageAsync<Substrate.Gear.Api.Generated.Model.gear_core.code.instrumented.InstrumentedCode>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> CodeLenStorageParams
        /// </summary>
        public static string CodeLenStorageParams(Substrate.Gear.Api.Generated.Model.gprimitives.CodeId key)
        {
            return RequestGenerator.GetStorage("GearProgram", "CodeLenStorage", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> CodeLenStorageDefault
        /// Default value as hex string
        /// </summary>
        public static string CodeLenStorageDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> CodeLenStorage
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U32> CodeLenStorage(Substrate.Gear.Api.Generated.Model.gprimitives.CodeId key, string blockhash, CancellationToken token)
        {
            string parameters = GearProgramStorage.CodeLenStorageParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U32>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> OriginalCodeStorageParams
        /// </summary>
        public static string OriginalCodeStorageParams(Substrate.Gear.Api.Generated.Model.gprimitives.CodeId key)
        {
            return RequestGenerator.GetStorage("GearProgram", "OriginalCodeStorage", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> OriginalCodeStorageDefault
        /// Default value as hex string
        /// </summary>
        public static string OriginalCodeStorageDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> OriginalCodeStorage
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>> OriginalCodeStorage(Substrate.Gear.Api.Generated.Model.gprimitives.CodeId key, string blockhash, CancellationToken token)
        {
            string parameters = GearProgramStorage.OriginalCodeStorageParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> MetadataStorageParams
        /// </summary>
        public static string MetadataStorageParams(Substrate.Gear.Api.Generated.Model.gprimitives.CodeId key)
        {
            return RequestGenerator.GetStorage("GearProgram", "MetadataStorage", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> MetadataStorageDefault
        /// Default value as hex string
        /// </summary>
        public static string MetadataStorageDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> MetadataStorage
        /// </summary>
        public async Task<Substrate.Gear.Api.Generated.Model.gear_common.CodeMetadata> MetadataStorage(Substrate.Gear.Api.Generated.Model.gprimitives.CodeId key, string blockhash, CancellationToken token)
        {
            string parameters = GearProgramStorage.MetadataStorageParams(key);
            var result = await _client.GetStorageAsync<Substrate.Gear.Api.Generated.Model.gear_common.CodeMetadata>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> AllocationsStorageParams
        /// </summary>
        public static string AllocationsStorageParams(Substrate.Gear.Api.Generated.Model.gprimitives.ActorId key)
        {
            return RequestGenerator.GetStorage("GearProgram", "AllocationsStorage", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> AllocationsStorageDefault
        /// Default value as hex string
        /// </summary>
        public static string AllocationsStorageDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> AllocationsStorage
        /// </summary>
        public async Task<Substrate.Gear.Api.Generated.Model.numerated.tree.IntervalsTree> AllocationsStorage(Substrate.Gear.Api.Generated.Model.gprimitives.ActorId key, string blockhash, CancellationToken token)
        {
            string parameters = GearProgramStorage.AllocationsStorageParams(key);
            var result = await _client.GetStorageAsync<Substrate.Gear.Api.Generated.Model.numerated.tree.IntervalsTree>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> ProgramStorageParams
        /// </summary>
        public static string ProgramStorageParams(Substrate.Gear.Api.Generated.Model.gprimitives.ActorId key)
        {
            return RequestGenerator.GetStorage("GearProgram", "ProgramStorage", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> ProgramStorageDefault
        /// Default value as hex string
        /// </summary>
        public static string ProgramStorageDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> ProgramStorage
        /// </summary>
        public async Task<Substrate.Gear.Api.Generated.Model.gear_core.program.EnumProgram> ProgramStorage(Substrate.Gear.Api.Generated.Model.gprimitives.ActorId key, string blockhash, CancellationToken token)
        {
            string parameters = GearProgramStorage.ProgramStorageParams(key);
            var result = await _client.GetStorageAsync<Substrate.Gear.Api.Generated.Model.gear_core.program.EnumProgram>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> MemoryPagesParams
        /// </summary>
        public static string MemoryPagesParams(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Gear.Api.Generated.Model.gprimitives.ActorId, Substrate.Gear.Api.Generated.Model.gear_core.program.MemoryInfix, Substrate.Gear.Api.Generated.Model.gear_core.pages.PageT2> key)
        {
            return RequestGenerator.GetStorage("GearProgram", "MemoryPages", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Identity,
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Identity,
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, key.Value);
        }
        
        /// <summary>
        /// >> MemoryPagesDefault
        /// Default value as hex string
        /// </summary>
        public static string MemoryPagesDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> MemoryPages
        /// </summary>
        public async Task<Substrate.Gear.Api.Generated.Model.gear_core.memory.PageBuf> MemoryPages(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Gear.Api.Generated.Model.gprimitives.ActorId, Substrate.Gear.Api.Generated.Model.gear_core.program.MemoryInfix, Substrate.Gear.Api.Generated.Model.gear_core.pages.PageT2> key, string blockhash, CancellationToken token)
        {
            string parameters = GearProgramStorage.MemoryPagesParams(key);
            var result = await _client.GetStorageAsync<Substrate.Gear.Api.Generated.Model.gear_core.memory.PageBuf>(parameters, blockhash, token);
            return result;
        }
    }
    
    /// <summary>
    /// >> GearProgramCalls
    /// </summary>
    public sealed class GearProgramCalls
    {
    }
    
    /// <summary>
    /// >> GearProgramConstants
    /// </summary>
    public sealed class GearProgramConstants
    {
    }
    
    /// <summary>
    /// >> GearProgramErrors
    /// </summary>
    public enum GearProgramErrors
    {
        
        /// <summary>
        /// >> DuplicateItem
        /// </summary>
        DuplicateItem,
        
        /// <summary>
        /// >> ProgramNotFound
        /// </summary>
        ProgramNotFound,
        
        /// <summary>
        /// >> NotActiveProgram
        /// </summary>
        NotActiveProgram,
        
        /// <summary>
        /// >> CannotFindDataForPage
        /// </summary>
        CannotFindDataForPage,
        
        /// <summary>
        /// >> ProgramCodeNotFound
        /// </summary>
        ProgramCodeNotFound,
    }
}