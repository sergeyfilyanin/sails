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


namespace Substrate.Gear.Api.Generated.Model.vara_runtime
{
    
    
    /// <summary>
    /// >> RuntimeFreezeReason
    /// </summary>
    public enum RuntimeFreezeReason
    {
        
        /// <summary>
        /// >> NominationPools
        /// </summary>
        NominationPools = 31,
    }
    
    /// <summary>
    /// >> 386 - Variant[vara_runtime.RuntimeFreezeReason]
    /// </summary>
    public sealed class EnumRuntimeFreezeReason : BaseEnumRust<RuntimeFreezeReason>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumRuntimeFreezeReason()
        {
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.pallet_nomination_pools.pallet.EnumFreezeReason>(RuntimeFreezeReason.NominationPools);
        }
    }
}
