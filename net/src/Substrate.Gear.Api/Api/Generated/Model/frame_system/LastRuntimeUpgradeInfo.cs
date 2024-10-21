//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Attributes;
using Substrate.NetApi.Model.Types.Base;
using Substrate.NetApi.Model.Types.Metadata.Base;
using System.Collections.Generic;


namespace Substrate.Gear.Api.Generated.Model.frame_system
{
    
    
    /// <summary>
    /// >> 337 - Composite[frame_system.LastRuntimeUpgradeInfo]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class LastRuntimeUpgradeInfo : BaseType
    {
        
        /// <summary>
        /// >> spec_version
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32> SpecVersion { get; set; }
        /// <summary>
        /// >> spec_name
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.Str SpecName { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "LastRuntimeUpgradeInfo";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(SpecVersion.Encode());
            result.AddRange(SpecName.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            SpecVersion = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>();
            SpecVersion.Decode(byteArray, ref p);
            SpecName = new Substrate.NetApi.Model.Types.Primitive.Str();
            SpecName.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
