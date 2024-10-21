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


namespace Substrate.Gear.Api.Generated.Model.gear_core_errors.simple
{
    
    
    /// <summary>
    /// >> ReplyCode
    /// </summary>
    public enum ReplyCode
    {
        
        /// <summary>
        /// >> Success
        /// </summary>
        Success = 0,
        
        /// <summary>
        /// >> Error
        /// </summary>
        Error = 1,
        
        /// <summary>
        /// >> Unsupported
        /// </summary>
        Unsupported = 255,
    }
    
    /// <summary>
    /// >> 310 - Variant[gear_core_errors.simple.ReplyCode]
    /// </summary>
    public sealed class EnumReplyCode : BaseEnumRust<ReplyCode>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumReplyCode()
        {
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.gear_core_errors.simple.EnumSuccessReplyReason>(ReplyCode.Success);
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.gear_core_errors.simple.EnumErrorReplyReason>(ReplyCode.Error);
				AddTypeDecoder<BaseVoid>(ReplyCode.Unsupported);
        }
    }
}
