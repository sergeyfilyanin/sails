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


namespace Substrate.Gear.Api.Generated.Model.pallet_multisig.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> as_multi_threshold_1
        /// See [`Pallet::as_multi_threshold_1`].
        /// </summary>
        as_multi_threshold_1 = 0,
        
        /// <summary>
        /// >> as_multi
        /// See [`Pallet::as_multi`].
        /// </summary>
        as_multi = 1,
        
        /// <summary>
        /// >> approve_as_multi
        /// See [`Pallet::approve_as_multi`].
        /// </summary>
        approve_as_multi = 2,
        
        /// <summary>
        /// >> cancel_as_multi
        /// See [`Pallet::cancel_as_multi`].
        /// </summary>
        cancel_as_multi = 3,
    }
    
    /// <summary>
    /// >> 183 - Variant[pallet_multisig.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumRust<Call>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumCall()
        {
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Gear.Api.Generated.Model.sp_core.crypto.AccountId32>, Substrate.Gear.Api.Generated.Model.vara_runtime.EnumRuntimeCall>>(Call.as_multi_threshold_1);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U16, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Gear.Api.Generated.Model.sp_core.crypto.AccountId32>, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Gear.Api.Generated.Model.pallet_multisig.Timepoint>, Substrate.Gear.Api.Generated.Model.vara_runtime.EnumRuntimeCall, Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight>>(Call.as_multi);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U16, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Gear.Api.Generated.Model.sp_core.crypto.AccountId32>, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Gear.Api.Generated.Model.pallet_multisig.Timepoint>, Substrate.Gear.Api.Generated.Types.Base.Arr32U8, Substrate.Gear.Api.Generated.Model.sp_weights.weight_v2.Weight>>(Call.approve_as_multi);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U16, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Gear.Api.Generated.Model.sp_core.crypto.AccountId32>, Substrate.Gear.Api.Generated.Model.pallet_multisig.Timepoint, Substrate.Gear.Api.Generated.Types.Base.Arr32U8>>(Call.cancel_as_multi);
        }
    }
}
