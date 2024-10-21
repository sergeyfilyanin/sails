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


namespace Substrate.Gear.Api.Generated.Model.pallet_grandpa.pallet
{
    
    
    /// <summary>
    /// >> Error
    /// The `Error` enum of this pallet.
    /// </summary>
    public enum Error
    {
        
        /// <summary>
        /// >> PauseFailed
        /// Attempt to signal GRANDPA pause when the authority set isn't live
        /// (either paused or already pending pause).
        /// </summary>
        PauseFailed = 0,
        
        /// <summary>
        /// >> ResumeFailed
        /// Attempt to signal GRANDPA resume when the authority set isn't paused
        /// (either live or already pending resume).
        /// </summary>
        ResumeFailed = 1,
        
        /// <summary>
        /// >> ChangePending
        /// Attempt to signal GRANDPA change with one already pending.
        /// </summary>
        ChangePending = 2,
        
        /// <summary>
        /// >> TooSoon
        /// Cannot signal forced change so soon after last.
        /// </summary>
        TooSoon = 3,
        
        /// <summary>
        /// >> InvalidKeyOwnershipProof
        /// A key ownership proof provided as part of an equivocation report is invalid.
        /// </summary>
        InvalidKeyOwnershipProof = 4,
        
        /// <summary>
        /// >> InvalidEquivocationProof
        /// An equivocation proof provided as part of an equivocation report is invalid.
        /// </summary>
        InvalidEquivocationProof = 5,
        
        /// <summary>
        /// >> DuplicateOffenceReport
        /// A given equivocation report is valid but already previously reported.
        /// </summary>
        DuplicateOffenceReport = 6,
    }
    
    /// <summary>
    /// >> 371 - Variant[pallet_grandpa.pallet.Error]
    /// The `Error` enum of this pallet.
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
