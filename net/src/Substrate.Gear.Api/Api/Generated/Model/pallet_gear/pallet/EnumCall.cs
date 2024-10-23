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


namespace Substrate.Gear.Api.Generated.Model.pallet_gear.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> upload_code
        /// See [`Pallet::upload_code`].
        /// </summary>
        upload_code = 0,
        
        /// <summary>
        /// >> upload_program
        /// See [`Pallet::upload_program`].
        /// </summary>
        upload_program = 1,
        
        /// <summary>
        /// >> create_program
        /// See [`Pallet::create_program`].
        /// </summary>
        create_program = 2,
        
        /// <summary>
        /// >> send_message
        /// See [`Pallet::send_message`].
        /// </summary>
        send_message = 3,
        
        /// <summary>
        /// >> send_reply
        /// See [`Pallet::send_reply`].
        /// </summary>
        send_reply = 4,
        
        /// <summary>
        /// >> claim_value
        /// See [`Pallet::claim_value`].
        /// </summary>
        claim_value = 5,
        
        /// <summary>
        /// >> run
        /// See [`Pallet::run`].
        /// </summary>
        run = 6,
        
        /// <summary>
        /// >> set_execute_inherent
        /// See [`Pallet::set_execute_inherent`].
        /// </summary>
        set_execute_inherent = 7,
        
        /// <summary>
        /// >> claim_value_to_inheritor
        /// See [`Pallet::claim_value_to_inheritor`].
        /// </summary>
        claim_value_to_inheritor = 8,
    }
    
    /// <summary>
    /// >> 260 - Variant[pallet_gear.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumRust<Call>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumCall()
        {
				AddTypeDecoder<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>(Call.upload_code);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>, Substrate.NetApi.Model.Types.Primitive.U64, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.Bool>>(Call.upload_program);
				AddTypeDecoder<BaseTuple<Substrate.Gear.Api.Generated.Model.gprimitives.CodeId, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>, Substrate.NetApi.Model.Types.Primitive.U64, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.Bool>>(Call.create_program);
				AddTypeDecoder<BaseTuple<Substrate.Gear.Api.Generated.Model.gprimitives.ActorId, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>, Substrate.NetApi.Model.Types.Primitive.U64, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.Bool>>(Call.send_message);
				AddTypeDecoder<BaseTuple<Substrate.Gear.Api.Generated.Model.gprimitives.MessageId, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>, Substrate.NetApi.Model.Types.Primitive.U64, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.Bool>>(Call.send_reply);
				AddTypeDecoder<Substrate.Gear.Api.Generated.Model.gprimitives.MessageId>(Call.claim_value);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U64>>(Call.run);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Primitive.Bool>(Call.set_execute_inherent);
				AddTypeDecoder<BaseTuple<Substrate.Gear.Api.Generated.Model.gprimitives.ActorId, Substrate.Gear.Api.Generated.Types.Base.NonZeroU32>>(Call.claim_value_to_inheritor);
        }
    }
}