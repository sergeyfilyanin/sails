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


namespace Substrate.Gear.Api.Generated.Model.sp_staking
{
    
    
    /// <summary>
    /// >> 415 - Composite[sp_staking.ExposurePage]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class ExposurePage : BaseType
    {
        
        /// <summary>
        /// >> page_total
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> PageTotal { get; set; }
        /// <summary>
        /// >> others
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Gear.Api.Generated.Model.sp_staking.IndividualExposure> Others { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "ExposurePage";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(PageTotal.Encode());
            result.AddRange(Others.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            PageTotal = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>();
            PageTotal.Decode(byteArray, ref p);
            Others = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Gear.Api.Generated.Model.sp_staking.IndividualExposure>();
            Others.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
