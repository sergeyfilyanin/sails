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


namespace Substrate.Gear.Api.Generated.Model.gear_core.message.context
{
    
    
    /// <summary>
    /// >> 592 - Composite[gear_core.message.context.ContextStore]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class ContextStore : BaseType
    {
        
        /// <summary>
        /// >> outgoing
        /// </summary>
        public Substrate.Gear.Api.Generated.Types.Base.BTreeMapT7 Outgoing { get; set; }
        /// <summary>
        /// >> reply
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Gear.Api.Generated.Model.gear_core.buffer.LimitedVecT1> Reply { get; set; }
        /// <summary>
        /// >> initialized
        /// </summary>
        public Substrate.Gear.Api.Generated.Types.Base.BTreeSetT1 Initialized { get; set; }
        /// <summary>
        /// >> reservation_nonce
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.gear_core.reservation.ReservationNonce ReservationNonce { get; set; }
        /// <summary>
        /// >> system_reservation
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U64> SystemReservation { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "ContextStore";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Outgoing.Encode());
            result.AddRange(Reply.Encode());
            result.AddRange(Initialized.Encode());
            result.AddRange(ReservationNonce.Encode());
            result.AddRange(SystemReservation.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Outgoing = new Substrate.Gear.Api.Generated.Types.Base.BTreeMapT7();
            Outgoing.Decode(byteArray, ref p);
            Reply = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Gear.Api.Generated.Model.gear_core.buffer.LimitedVecT1>();
            Reply.Decode(byteArray, ref p);
            Initialized = new Substrate.Gear.Api.Generated.Types.Base.BTreeSetT1();
            Initialized.Decode(byteArray, ref p);
            ReservationNonce = new Substrate.Gear.Api.Generated.Model.gear_core.reservation.ReservationNonce();
            ReservationNonce.Decode(byteArray, ref p);
            SystemReservation = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U64>();
            SystemReservation.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
