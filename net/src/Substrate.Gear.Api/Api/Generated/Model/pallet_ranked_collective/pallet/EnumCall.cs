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


namespace Substrate.Gear.Api.Generated.Model.pallet_ranked_collective.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> add_member
        /// See [`Pallet::add_member`].
        /// </summary>
        add_member = 0,
        
        /// <summary>
        /// >> promote_member
        /// See [`Pallet::promote_member`].
        /// </summary>
        promote_member = 1,
        
        /// <summary>
        /// >> demote_member
        /// See [`Pallet::demote_member`].
        /// </summary>
        demote_member = 2,
        
        /// <summary>
        /// >> remove_member
        /// See [`Pallet::remove_member`].
        /// </summary>
        remove_member = 3,
        
        /// <summary>
        /// >> vote
        /// See [`Pallet::vote`].
        /// </summary>
        vote = 4,
        
        /// <summary>
        /// >> cleanup_poll
        /// See [`Pallet::cleanup_poll`].
        /// </summary>
        cleanup_poll = 5,
    }
    
    /// <summary>
    /// >> 132 - Variant[pallet_ranked_collective.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumRust<Call>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumCall()
        {
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>(Call.add_member);
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>(Call.promote_member);
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>(Call.demote_member);
				AddTypeDecoder<BaseTuple<Substrate.Gear.Api.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.NetApi.Model.Types.Primitive.U16>>(Call.remove_member);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.Bool>>(Call.vote);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>>(Call.cleanup_poll);
        }
    }
}
