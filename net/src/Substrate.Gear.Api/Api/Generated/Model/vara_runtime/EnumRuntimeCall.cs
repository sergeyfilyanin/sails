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
    /// >> RuntimeCall
    /// </summary>
    public enum RuntimeCall
    {
        
        /// <summary>
        /// >> System
        /// </summary>
        System = 0,
        
        /// <summary>
        /// >> Timestamp
        /// </summary>
        Timestamp = 1,
        
        /// <summary>
        /// >> Babe
        /// </summary>
        Babe = 3,
        
        /// <summary>
        /// >> Grandpa
        /// </summary>
        Grandpa = 4,
        
        /// <summary>
        /// >> Balances
        /// </summary>
        Balances = 5,
        
        /// <summary>
        /// >> Vesting
        /// </summary>
        Vesting = 10,
        
        /// <summary>
        /// >> BagsList
        /// </summary>
        BagsList = 11,
        
        /// <summary>
        /// >> ImOnline
        /// </summary>
        ImOnline = 12,
        
        /// <summary>
        /// >> Staking
        /// </summary>
        Staking = 13,
        
        /// <summary>
        /// >> Session
        /// </summary>
        Session = 7,
        
        /// <summary>
        /// >> Treasury
        /// </summary>
        Treasury = 14,
        
        /// <summary>
        /// >> Utility
        /// </summary>
        Utility = 8,
        
        /// <summary>
        /// >> ConvictionVoting
        /// </summary>
        ConvictionVoting = 16,
        
        /// <summary>
        /// >> Referenda
        /// </summary>
        Referenda = 17,
        
        /// <summary>
        /// >> FellowshipCollective
        /// </summary>
        FellowshipCollective = 18,
        
        /// <summary>
        /// >> FellowshipReferenda
        /// </summary>
        FellowshipReferenda = 19,
        
        /// <summary>
        /// >> Whitelist
        /// </summary>
        Whitelist = 21,
        
        /// <summary>
        /// >> Scheduler
        /// </summary>
        Scheduler = 22,
        
        /// <summary>
        /// >> Preimage
        /// </summary>
        Preimage = 23,
        
        /// <summary>
        /// >> Identity
        /// </summary>
        Identity = 24,
        
        /// <summary>
        /// >> Proxy
        /// </summary>
        Proxy = 25,
        
        /// <summary>
        /// >> Multisig
        /// </summary>
        Multisig = 26,
        
        /// <summary>
        /// >> ElectionProviderMultiPhase
        /// </summary>
        ElectionProviderMultiPhase = 27,
        
        /// <summary>
        /// >> Bounties
        /// </summary>
        Bounties = 29,
        
        /// <summary>
        /// >> ChildBounties
        /// </summary>
        ChildBounties = 30,
        
        /// <summary>
        /// >> NominationPools
        /// </summary>
        NominationPools = 31,
        
        /// <summary>
        /// >> Gear
        /// </summary>
        Gear = 104,
        
        /// <summary>
        /// >> StakingRewards
        /// </summary>
        StakingRewards = 106,
        
        /// <summary>
        /// >> GearVoucher
        /// </summary>
        GearVoucher = 107,
    }
    
    /// <summary>
    /// >> 65 - Variant[vara_runtime.RuntimeCall]
    /// </summary>
    public sealed class EnumRuntimeCall : BaseEnumRust<RuntimeCall>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumRuntimeCall()
        {
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.frame_system.pallet.EnumCall>(RuntimeCall.System);
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.pallet_timestamp.pallet.EnumCall>(RuntimeCall.Timestamp);
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.pallet_babe.pallet.EnumCall>(RuntimeCall.Babe);
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.pallet_grandpa.pallet.EnumCall>(RuntimeCall.Grandpa);
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.pallet_balances.pallet.EnumCall>(RuntimeCall.Balances);
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.pallet_vesting.pallet.EnumCall>(RuntimeCall.Vesting);
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.pallet_bags_list.pallet.EnumCall>(RuntimeCall.BagsList);
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.pallet_im_online.pallet.EnumCall>(RuntimeCall.ImOnline);
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.pallet_staking.pallet.pallet.EnumCall>(RuntimeCall.Staking);
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.pallet_session.pallet.EnumCall>(RuntimeCall.Session);
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.pallet_treasury.pallet.EnumCall>(RuntimeCall.Treasury);
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.pallet_utility.pallet.EnumCall>(RuntimeCall.Utility);
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.pallet_conviction_voting.pallet.EnumCall>(RuntimeCall.ConvictionVoting);
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.pallet_referenda.pallet.EnumCall>(RuntimeCall.Referenda);
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.pallet_ranked_collective.pallet.EnumCall>(RuntimeCall.FellowshipCollective);
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.pallet_referenda.pallet.EnumCall>(RuntimeCall.FellowshipReferenda);
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.pallet_whitelist.pallet.EnumCall>(RuntimeCall.Whitelist);
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.pallet_scheduler.pallet.EnumCall>(RuntimeCall.Scheduler);
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.pallet_preimage.pallet.EnumCall>(RuntimeCall.Preimage);
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.pallet_identity.pallet.EnumCall>(RuntimeCall.Identity);
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.pallet_proxy.pallet.EnumCall>(RuntimeCall.Proxy);
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.pallet_multisig.pallet.EnumCall>(RuntimeCall.Multisig);
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.pallet_election_provider_multi_phase.pallet.EnumCall>(RuntimeCall.ElectionProviderMultiPhase);
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.pallet_bounties.pallet.EnumCall>(RuntimeCall.Bounties);
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.pallet_child_bounties.pallet.EnumCall>(RuntimeCall.ChildBounties);
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.pallet_nomination_pools.pallet.EnumCall>(RuntimeCall.NominationPools);
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.pallet_gear.pallet.EnumCall>(RuntimeCall.Gear);
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.pallet_gear_staking_rewards.pallet.EnumCall>(RuntimeCall.StakingRewards);
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.pallet_gear_voucher.pallet.EnumCall>(RuntimeCall.GearVoucher);
        }
    }
}
