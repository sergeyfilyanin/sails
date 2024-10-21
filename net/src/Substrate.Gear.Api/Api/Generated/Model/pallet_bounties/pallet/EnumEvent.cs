//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Substrate.Gear.Api.Generated.Model.pallet_bounties.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> BountyProposed
        /// New bounty proposal.
        /// </summary>
        BountyProposed = 0,
        
        /// <summary>
        /// >> BountyRejected
        /// A bounty proposal was rejected; funds were slashed.
        /// </summary>
        BountyRejected = 1,
        
        /// <summary>
        /// >> BountyBecameActive
        /// A bounty proposal is funded and became active.
        /// </summary>
        BountyBecameActive = 2,
        
        /// <summary>
        /// >> BountyAwarded
        /// A bounty is awarded to a beneficiary.
        /// </summary>
        BountyAwarded = 3,
        
        /// <summary>
        /// >> BountyClaimed
        /// A bounty is claimed by beneficiary.
        /// </summary>
        BountyClaimed = 4,
        
        /// <summary>
        /// >> BountyCanceled
        /// A bounty is cancelled.
        /// </summary>
        BountyCanceled = 5,
        
        /// <summary>
        /// >> BountyExtended
        /// A bounty expiry is extended.
        /// </summary>
        BountyExtended = 6,
        
        /// <summary>
        /// >> BountyApproved
        /// A bounty is approved.
        /// </summary>
        BountyApproved = 7,
        
        /// <summary>
        /// >> CuratorProposed
        /// A bounty curator is proposed.
        /// </summary>
        CuratorProposed = 8,
        
        /// <summary>
        /// >> CuratorUnassigned
        /// A bounty curator is unassigned.
        /// </summary>
        CuratorUnassigned = 9,
        
        /// <summary>
        /// >> CuratorAccepted
        /// A bounty curator is accepted.
        /// </summary>
        CuratorAccepted = 10,
    }
    
    /// <summary>
    /// >> 300 - Variant[pallet_bounties.pallet.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumRust<Event>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumEvent()
        {
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(Event.BountyProposed);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128>>(Event.BountyRejected);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(Event.BountyBecameActive);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Gear.Api.Generated.Model.sp_core.crypto.AccountId32>>(Event.BountyAwarded);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.Gear.Api.Generated.Model.sp_core.crypto.AccountId32>>(Event.BountyClaimed);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(Event.BountyCanceled);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(Event.BountyExtended);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(Event.BountyApproved);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Gear.Api.Generated.Model.sp_core.crypto.AccountId32>>(Event.CuratorProposed);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.U32>(Event.CuratorUnassigned);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Gear.Api.Generated.Model.sp_core.crypto.AccountId32>>(Event.CuratorAccepted);
        }
    }
}
