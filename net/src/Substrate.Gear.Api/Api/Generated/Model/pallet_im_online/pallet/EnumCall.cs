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


namespace Substrate.Gear.Api.Generated.Model.pallet_im_online.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> heartbeat
        /// See [`Pallet::heartbeat`].
        /// </summary>
        heartbeat = 0,
    }
    
    /// <summary>
    /// >> 101 - Variant[pallet_im_online.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumRust<Call>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumCall()
        {
				AddTypeDecoder<BaseTuple<Substrate.Gear.Api.Generated.Model.pallet_im_online.Heartbeat, Substrate.Gear.Api.Generated.Model.pallet_im_online.sr25519.app_sr25519.Signature>>(Call.heartbeat);
        }
    }
}