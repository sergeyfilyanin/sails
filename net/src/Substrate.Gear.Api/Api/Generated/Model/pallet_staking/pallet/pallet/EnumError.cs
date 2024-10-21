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


namespace Substrate.Gear.Api.Generated.Model.pallet_staking.pallet.pallet
{
    
    
    /// <summary>
    /// >> Error
    /// The `Error` enum of this pallet.
    /// </summary>
    public enum Error
    {
        
        /// <summary>
        /// >> NotController
        /// Not a controller account.
        /// </summary>
        NotController = 0,
        
        /// <summary>
        /// >> NotStash
        /// Not a stash account.
        /// </summary>
        NotStash = 1,
        
        /// <summary>
        /// >> AlreadyBonded
        /// Stash is already bonded.
        /// </summary>
        AlreadyBonded = 2,
        
        /// <summary>
        /// >> AlreadyPaired
        /// Controller is already paired.
        /// </summary>
        AlreadyPaired = 3,
        
        /// <summary>
        /// >> EmptyTargets
        /// Targets cannot be empty.
        /// </summary>
        EmptyTargets = 4,
        
        /// <summary>
        /// >> DuplicateIndex
        /// Duplicate index.
        /// </summary>
        DuplicateIndex = 5,
        
        /// <summary>
        /// >> InvalidSlashIndex
        /// Slash record index out of bounds.
        /// </summary>
        InvalidSlashIndex = 6,
        
        /// <summary>
        /// >> InsufficientBond
        /// Cannot have a validator or nominator role, with value less than the minimum defined by
        /// governance (see `MinValidatorBond` and `MinNominatorBond`). If unbonding is the
        /// intention, `chill` first to remove one's role as validator/nominator.
        /// </summary>
        InsufficientBond = 7,
        
        /// <summary>
        /// >> NoMoreChunks
        /// Can not schedule more unlock chunks.
        /// </summary>
        NoMoreChunks = 8,
        
        /// <summary>
        /// >> NoUnlockChunk
        /// Can not rebond without unlocking chunks.
        /// </summary>
        NoUnlockChunk = 9,
        
        /// <summary>
        /// >> FundedTarget
        /// Attempting to target a stash that still has funds.
        /// </summary>
        FundedTarget = 10,
        
        /// <summary>
        /// >> InvalidEraToReward
        /// Invalid era to reward.
        /// </summary>
        InvalidEraToReward = 11,
        
        /// <summary>
        /// >> InvalidNumberOfNominations
        /// Invalid number of nominations.
        /// </summary>
        InvalidNumberOfNominations = 12,
        
        /// <summary>
        /// >> NotSortedAndUnique
        /// Items are not sorted and unique.
        /// </summary>
        NotSortedAndUnique = 13,
        
        /// <summary>
        /// >> AlreadyClaimed
        /// Rewards for this era have already been claimed for this validator.
        /// </summary>
        AlreadyClaimed = 14,
        
        /// <summary>
        /// >> InvalidPage
        /// No nominators exist on this page.
        /// </summary>
        InvalidPage = 15,
        
        /// <summary>
        /// >> IncorrectHistoryDepth
        /// Incorrect previous history depth input provided.
        /// </summary>
        IncorrectHistoryDepth = 16,
        
        /// <summary>
        /// >> IncorrectSlashingSpans
        /// Incorrect number of slashing spans provided.
        /// </summary>
        IncorrectSlashingSpans = 17,
        
        /// <summary>
        /// >> BadState
        /// Internal state has become somehow corrupted and the operation cannot continue.
        /// </summary>
        BadState = 18,
        
        /// <summary>
        /// >> TooManyTargets
        /// Too many nomination targets supplied.
        /// </summary>
        TooManyTargets = 19,
        
        /// <summary>
        /// >> BadTarget
        /// A nomination target was supplied that was blocked or otherwise not a validator.
        /// </summary>
        BadTarget = 20,
        
        /// <summary>
        /// >> CannotChillOther
        /// The user has enough bond and thus cannot be chilled forcefully by an external person.
        /// </summary>
        CannotChillOther = 21,
        
        /// <summary>
        /// >> TooManyNominators
        /// There are too many nominators in the system. Governance needs to adjust the staking
        /// settings to keep things safe for the runtime.
        /// </summary>
        TooManyNominators = 22,
        
        /// <summary>
        /// >> TooManyValidators
        /// There are too many validator candidates in the system. Governance needs to adjust the
        /// staking settings to keep things safe for the runtime.
        /// </summary>
        TooManyValidators = 23,
        
        /// <summary>
        /// >> CommissionTooLow
        /// Commission is too low. Must be at least `MinCommission`.
        /// </summary>
        CommissionTooLow = 24,
        
        /// <summary>
        /// >> BoundNotMet
        /// Some bound is not met.
        /// </summary>
        BoundNotMet = 25,
    }
    
    /// <summary>
    /// >> 427 - Variant[pallet_staking.pallet.pallet.Error]
    /// The `Error` enum of this pallet.
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
