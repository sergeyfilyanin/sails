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


namespace Substrate.Gear.Api.Generated.Model.gear_common.@event
{
    
    
    /// <summary>
    /// >> MessageEntry
    /// </summary>
    public enum MessageEntry
    {
        
        /// <summary>
        /// >> Init
        /// </summary>
        Init = 0,
        
        /// <summary>
        /// >> Handle
        /// </summary>
        Handle = 1,
        
        /// <summary>
        /// >> Reply
        /// </summary>
        Reply = 2,
        
        /// <summary>
        /// >> Signal
        /// </summary>
        Signal = 3,
    }
    
    /// <summary>
    /// >> 304 - Variant[gear_common.@event.MessageEntry]
    /// </summary>
    public sealed class EnumMessageEntry : BaseEnumRust<MessageEntry>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumMessageEntry()
        {
				AddTypeDecoder<BaseVoid>(MessageEntry.Init);
				AddTypeDecoder<BaseVoid>(MessageEntry.Handle);
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.gprimitives.MessageId>(MessageEntry.Reply);
				AddTypeDecoder<BaseVoid>(MessageEntry.Signal);
        }
    }
}