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
    /// >> Program
    /// </summary>
    public enum Program
    {
        
        /// <summary>
        /// >> Active
        /// </summary>
        Active = 0,
        
        /// <summary>
        /// >> Exited
        /// </summary>
        Exited = 1,
        
        /// <summary>
        /// >> Terminated
        /// </summary>
        Terminated = 2,
    }
    
    /// <summary>
    /// >> 570 - Variant[gear_core.program.Program]
    /// </summary>
    public sealed class EnumProgram : BaseEnumRust<Program>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumProgram()
        {
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.gear_core.program.ActiveProgram>(Program.Active);
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.gprimitives.ActorId>(Program.Exited);
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.gprimitives.ActorId>(Program.Terminated);
        }
    }
}
