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


namespace Substrate.Gear.Api.Generated.Model.gear_core.program
{
    
    
    /// <summary>
    /// >> ProgramState
    /// </summary>
    public enum ProgramState
    {
        
        /// <summary>
        /// >> Uninitialized
        /// </summary>
        Uninitialized = 0,
        
        /// <summary>
        /// >> Initialized
        /// </summary>
        Initialized = 1,
    }
    
    /// <summary>
    /// >> 577 - Variant[gear_core.program.ProgramState]
    /// </summary>
    public sealed class EnumProgramState : BaseEnumRust<ProgramState>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumProgramState()
        {
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.gprimitives.MessageId>(ProgramState.Uninitialized);
				AddTypeDecoder<BaseVoid>(ProgramState.Initialized);
        }
    }
}