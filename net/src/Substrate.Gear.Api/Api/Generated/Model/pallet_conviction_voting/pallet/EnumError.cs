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


namespace Substrate.Gear.Api.Generated.Model.pallet_conviction_voting.pallet
{
    
    
    /// <summary>
    /// >> Error
    /// The `Error` enum of this pallet.
    /// </summary>
    public enum Error
    {
        
        /// <summary>
        /// >> NotOngoing
        /// Poll is not ongoing.
        /// </summary>
        NotOngoing = 0,
        
        /// <summary>
        /// >> NotVoter
        /// The given account did not vote on the poll.
        /// </summary>
        NotVoter = 1,
        
        /// <summary>
        /// >> NoPermission
        /// The actor has no permission to conduct the action.
        /// </summary>
        NoPermission = 2,
        
        /// <summary>
        /// >> NoPermissionYet
        /// The actor has no permission to conduct the action right now but will do in the future.
        /// </summary>
        NoPermissionYet = 3,
        
        /// <summary>
        /// >> AlreadyDelegating
        /// The account is already delegating.
        /// </summary>
        AlreadyDelegating = 4,
        
        /// <summary>
        /// >> AlreadyVoting
        /// The account currently has votes attached to it and the operation cannot succeed until
        /// these are removed, either through `unvote` or `reap_vote`.
        /// </summary>
        AlreadyVoting = 5,
        
        /// <summary>
        /// >> InsufficientFunds
        /// Too high a balance was provided that the account cannot afford.
        /// </summary>
        InsufficientFunds = 6,
        
        /// <summary>
        /// >> NotDelegating
        /// The account is not currently delegating.
        /// </summary>
        NotDelegating = 7,
        
        /// <summary>
        /// >> Nonsense
        /// Delegation to oneself makes no sense.
        /// </summary>
        Nonsense = 8,
        
        /// <summary>
        /// >> MaxVotesReached
        /// Maximum number of votes reached.
        /// </summary>
        MaxVotesReached = 9,
        
        /// <summary>
        /// >> ClassNeeded
        /// The class must be supplied since it is not easily determinable from the state.
        /// </summary>
        ClassNeeded = 10,
        
        /// <summary>
        /// >> BadClass
        /// The class ID supplied is invalid.
        /// </summary>
        BadClass = 11,
    }
    
    /// <summary>
    /// >> 454 - Variant[pallet_conviction_voting.pallet.Error]
    /// The `Error` enum of this pallet.
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
