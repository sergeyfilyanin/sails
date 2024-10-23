//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Attributes;
using Substrate.NetApi.Model.Types.Base;
using Substrate.NetApi.Model.Types.Metadata.Base;
using System.Collections.Generic;


namespace Substrate.Gear.Api.Generated.Model.pallet_gear.schedule
{
    
    
    /// <summary>
    /// >> 617 - Composite[pallet_gear.schedule.Schedule]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class Schedule : BaseType
    {
        
        /// <summary>
        /// >> limits
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.pallet_gear.schedule.Limits Limits { get; set; }
        /// <summary>
        /// >> instruction_weights
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.pallet_gear.schedule.InstructionWeights InstructionWeights { get; set; }
        /// <summary>
        /// >> syscall_weights
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.pallet_gear.schedule.SyscallWeights SyscallWeights { get; set; }
        /// <summary>
        /// >> memory_weights
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.pallet_gear.schedule.MemoryWeights MemoryWeights { get; set; }
        /// <summary>
        /// >> rent_weights
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.pallet_gear.schedule.RentWeights RentWeights { get; set; }
        /// <summary>
        /// >> db_weights
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.pallet_gear.schedule.DbWeights DbWeights { get; set; }
        /// <summary>
        /// >> task_weights
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.pallet_gear.schedule.TaskWeights TaskWeights { get; set; }
        /// <summary>
        /// >> instantiation_weights
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.pallet_gear.schedule.InstantiationWeights InstantiationWeights { get; set; }
        /// <summary>
        /// >> code_instrumentation_cost
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight CodeInstrumentationCost { get; set; }
        /// <summary>
        /// >> code_instrumentation_byte_cost
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight CodeInstrumentationByteCost { get; set; }
        /// <summary>
        /// >> load_allocations_weight
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight LoadAllocationsWeight { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "Schedule";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Limits.Encode());
            result.AddRange(InstructionWeights.Encode());
            result.AddRange(SyscallWeights.Encode());
            result.AddRange(MemoryWeights.Encode());
            result.AddRange(RentWeights.Encode());
            result.AddRange(DbWeights.Encode());
            result.AddRange(TaskWeights.Encode());
            result.AddRange(InstantiationWeights.Encode());
            result.AddRange(CodeInstrumentationCost.Encode());
            result.AddRange(CodeInstrumentationByteCost.Encode());
            result.AddRange(LoadAllocationsWeight.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Limits = new Substrate.Gear.Api.Generated.Model.pallet_gear.schedule.Limits();
            Limits.Decode(byteArray, ref p);
            InstructionWeights = new Substrate.Gear.Api.Generated.Model.pallet_gear.schedule.InstructionWeights();
            InstructionWeights.Decode(byteArray, ref p);
            SyscallWeights = new Substrate.Gear.Api.Generated.Model.pallet_gear.schedule.SyscallWeights();
            SyscallWeights.Decode(byteArray, ref p);
            MemoryWeights = new Substrate.Gear.Api.Generated.Model.pallet_gear.schedule.MemoryWeights();
            MemoryWeights.Decode(byteArray, ref p);
            RentWeights = new Substrate.Gear.Api.Generated.Model.pallet_gear.schedule.RentWeights();
            RentWeights.Decode(byteArray, ref p);
            DbWeights = new Substrate.Gear.Api.Generated.Model.pallet_gear.schedule.DbWeights();
            DbWeights.Decode(byteArray, ref p);
            TaskWeights = new Substrate.Gear.Api.Generated.Model.pallet_gear.schedule.TaskWeights();
            TaskWeights.Decode(byteArray, ref p);
            InstantiationWeights = new Substrate.Gear.Api.Generated.Model.pallet_gear.schedule.InstantiationWeights();
            InstantiationWeights.Decode(byteArray, ref p);
            CodeInstrumentationCost = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            CodeInstrumentationCost.Decode(byteArray, ref p);
            CodeInstrumentationByteCost = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            CodeInstrumentationByteCost.Decode(byteArray, ref p);
            LoadAllocationsWeight = new Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight();
            LoadAllocationsWeight.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}