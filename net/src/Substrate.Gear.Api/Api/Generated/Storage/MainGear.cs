//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi;
using Substrate.NetApi.Model.Extrinsics;
using Substrate.NetApi.Model.Meta;
using Substrate.NetApi.Model.Types;
using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace Substrate.Gear.Api.Generated.Storage
{
    
    
    /// <summary>
    /// >> GearStorage
    /// </summary>
    public sealed class GearStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        /// <summary>
        /// >> GearStorage Constructor
        /// </summary>
        public GearStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Gear", "ExecuteInherent"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Primitive.Bool)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Gear", "BlockNumber"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Gear", "GearRunInBlock"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Base.BaseTuple)));
        }
        
        /// <summary>
        /// >> ExecuteInherentParams
        ///  A flag indicating whether the message queue should be processed at the end of a block
        /// 
        ///  If not set, the inherent extrinsic that processes the queue will keep throwing an error
        ///  thereby making the block builder exclude it from the block.
        /// </summary>
        public static string ExecuteInherentParams()
        {
            return RequestGenerator.GetStorage("Gear", "ExecuteInherent", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> ExecuteInherentDefault
        /// Default value as hex string
        /// </summary>
        public static string ExecuteInherentDefault()
        {
            return "0x01";
        }
        
        /// <summary>
        /// >> ExecuteInherent
        ///  A flag indicating whether the message queue should be processed at the end of a block
        /// 
        ///  If not set, the inherent extrinsic that processes the queue will keep throwing an error
        ///  thereby making the block builder exclude it from the block.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.Bool> ExecuteInherent(string blockhash, CancellationToken token)
        {
            string parameters = GearStorage.ExecuteInherentParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.Bool>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> BlockNumberParams
        ///  The current block number being processed.
        /// 
        ///  It shows block number in which queue is processed.
        ///  May be less than system pallet block number if panic occurred previously.
        /// </summary>
        public static string BlockNumberParams()
        {
            return RequestGenerator.GetStorage("Gear", "BlockNumber", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> BlockNumberDefault
        /// Default value as hex string
        /// </summary>
        public static string BlockNumberDefault()
        {
            return "0x00000000";
        }
        
        /// <summary>
        /// >> BlockNumber
        ///  The current block number being processed.
        /// 
        ///  It shows block number in which queue is processed.
        ///  May be less than system pallet block number if panic occurred previously.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U32> BlockNumber(string blockhash, CancellationToken token)
        {
            string parameters = GearStorage.BlockNumberParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U32>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> GearRunInBlockParams
        ///  A guard to prohibit all but the first execution of `pallet_gear::run()` call in a block.
        /// 
        ///  Set to `Some(())` if the extrinsic is executed for the first time in a block.
        ///  All subsequent attempts would fail with `Error::<T>::GearRunAlreadyInBlock` error.
        ///  Set back to `None` in the `on_finalize()` hook at the end of the block.
        /// </summary>
        public static string GearRunInBlockParams()
        {
            return RequestGenerator.GetStorage("Gear", "GearRunInBlock", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> GearRunInBlockDefault
        /// Default value as hex string
        /// </summary>
        public static string GearRunInBlockDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> GearRunInBlock
        ///  A guard to prohibit all but the first execution of `pallet_gear::run()` call in a block.
        /// 
        ///  Set to `Some(())` if the extrinsic is executed for the first time in a block.
        ///  All subsequent attempts would fail with `Error::<T>::GearRunAlreadyInBlock` error.
        ///  Set back to `None` in the `on_finalize()` hook at the end of the block.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Base.BaseTuple> GearRunInBlock(string blockhash, CancellationToken token)
        {
            string parameters = GearStorage.GearRunInBlockParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Base.BaseTuple>(parameters, blockhash, token);
            return result;
        }
    }
    
    /// <summary>
    /// >> GearCalls
    /// </summary>
    public sealed class GearCalls
    {
        
        /// <summary>
        /// >> upload_code
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method UploadCode(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> code)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(code.Encode());
            return new Method(104, "Gear", 0, "upload_code", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> upload_program
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method UploadProgram(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> code, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> salt, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> init_payload, Substrate.NetApi.Model.Types.Primitive.U64 gas_limit, Substrate.NetApi.Model.Types.Primitive.U128 value, Substrate.NetApi.Model.Types.Primitive.Bool keep_alive)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(code.Encode());
            byteArray.AddRange(salt.Encode());
            byteArray.AddRange(init_payload.Encode());
            byteArray.AddRange(gas_limit.Encode());
            byteArray.AddRange(value.Encode());
            byteArray.AddRange(keep_alive.Encode());
            return new Method(104, "Gear", 1, "upload_program", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> create_program
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method CreateProgram(Substrate.Gear.Api.Generated.Model.gprimitives.CodeId code_id, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> salt, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> init_payload, Substrate.NetApi.Model.Types.Primitive.U64 gas_limit, Substrate.NetApi.Model.Types.Primitive.U128 value, Substrate.NetApi.Model.Types.Primitive.Bool keep_alive)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(code_id.Encode());
            byteArray.AddRange(salt.Encode());
            byteArray.AddRange(init_payload.Encode());
            byteArray.AddRange(gas_limit.Encode());
            byteArray.AddRange(value.Encode());
            byteArray.AddRange(keep_alive.Encode());
            return new Method(104, "Gear", 2, "create_program", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> send_message
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SendMessage(Substrate.Gear.Api.Generated.Model.gprimitives.ActorId destination, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> payload, Substrate.NetApi.Model.Types.Primitive.U64 gas_limit, Substrate.NetApi.Model.Types.Primitive.U128 value, Substrate.NetApi.Model.Types.Primitive.Bool keep_alive)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(destination.Encode());
            byteArray.AddRange(payload.Encode());
            byteArray.AddRange(gas_limit.Encode());
            byteArray.AddRange(value.Encode());
            byteArray.AddRange(keep_alive.Encode());
            return new Method(104, "Gear", 3, "send_message", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> send_reply
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SendReply(Substrate.Gear.Api.Generated.Model.gprimitives.MessageId reply_to_id, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> payload, Substrate.NetApi.Model.Types.Primitive.U64 gas_limit, Substrate.NetApi.Model.Types.Primitive.U128 value, Substrate.NetApi.Model.Types.Primitive.Bool keep_alive)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(reply_to_id.Encode());
            byteArray.AddRange(payload.Encode());
            byteArray.AddRange(gas_limit.Encode());
            byteArray.AddRange(value.Encode());
            byteArray.AddRange(keep_alive.Encode());
            return new Method(104, "Gear", 4, "send_reply", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> claim_value
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method ClaimValue(Substrate.Gear.Api.Generated.Model.gprimitives.MessageId message_id)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(message_id.Encode());
            return new Method(104, "Gear", 5, "claim_value", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> run
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method Run(Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U64> max_gas)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(max_gas.Encode());
            return new Method(104, "Gear", 6, "run", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_execute_inherent
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method SetExecuteInherent(Substrate.NetApi.Model.Types.Primitive.Bool value)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(value.Encode());
            return new Method(104, "Gear", 7, "set_execute_inherent", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> claim_value_to_inheritor
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method ClaimValueToInheritor(Substrate.Gear.Api.Generated.Model.gprimitives.ActorId program_id, Substrate.Gear.Api.Generated.Types.Base.NonZeroU32 depth)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(program_id.Encode());
            byteArray.AddRange(depth.Encode());
            return new Method(104, "Gear", 8, "claim_value_to_inheritor", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> GearConstants
    /// </summary>
    public sealed class GearConstants
    {
        
        /// <summary>
        /// >> Schedule
        ///  Cost schedule and limits.
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.pallet_gear.schedule.Schedule Schedule()
        {
            var result = new Substrate.Gear.Api.Generated.Model.pallet_gear.schedule.Schedule();
            result.Create("0x01878F0000000100000004000080000000008000100000640000000001000020000000200000000" +
                    "00080000000080000040000540600009F000000CB1A0000461A0000DA260000C82A0000EC1700003" +
                    "6120000EB0C0000CC1400000C280000880000006312000068550000EB040000000000007D0200001" +
                    "A050000060500005402000048040000C23000007E010000FA000000A6010000DB00000079010000F" +
                    "1000000C306000008040000C4000000D2000000580100006A01000053010000A2000000B5000000B" +
                    "700000052060000EC030000590600007B0300005006000095030000DF0600006503000035060000C" +
                    "5030000A4070000DA0300008D070000BA040000E5060000C4030000CC060000CD030000210600008" +
                    "303000094030000BF01000058030000B301000096050000270300004E0D0000B3090000000E0000B" +
                    "4090000294A0000AA3C0000FA0E000000090000BA0300001302000053030000BF0100006A030000E" +
                    "E0100000A030000D700000093020000DA000000C502000018010000DF020000DE000000CF020000F" +
                    "8000000E6195C00001ED736000036053A0000824D0200002EED8D00003A639200006E1F4B00003E7" +
                    "C40000082EB4000003A14420000D29A410000DED7420000F28F410000B2BB4100003AE87400001D0" +
                    "300BAF9490000A257410000C6714100008A3A7D0000AE2F420100A63CB700003908007E50BA00002" +
                    "D0800060F4800009A8C8500002D08004A29980000969C9D00003A94D800002D08006672BB00006A7" +
                    "FA60200F256BC02006AB40802001E312A0000BAEBC901005E917000002257F30200A10A00EAF1E30" +
                    "200A50A00A50A005E70420000128D4100009E724200009A10F7040032DB24070036124F0000B5010" +
                    "0829FB100000EBBB400004AFD610000410200E25D500000C107000E45410000AAB53B040092653C0" +
                    "30052200F03000A878103002A4E6E03006281C90000DEAEE200000D020045160002CBE5000005020" +
                    "069160016BAC50600B2105C080082BF630200FE731A07001679E50800A260F202007E22250200C22" +
                    "2A21800520D33000000000000910100910100910100910100E12E0002E1F505001D0A000284D7170" +
                    "0290300E21400D8D160E23F99A58D430310CD8754D160624C29C0FD4062ACE3C8C94462273507653" +
                    "70310EF0F6EE57603409EBF6BA9723D2100310700BD1C00110A00992700B1FD00CA205248453BC6C" +
                    "A2500009A3F010000");
            return result;
        }
        
        /// <summary>
        /// >> OutgoingLimit
        ///  The maximum amount of messages that can be produced in during all message executions.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 OutgoingLimit()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x00040000");
            return result;
        }
        
        /// <summary>
        /// >> OutgoingBytesLimit
        ///  The maximum amount of bytes in outgoing messages during message execution.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 OutgoingBytesLimit()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x00000004");
            return result;
        }
        
        /// <summary>
        /// >> PerformanceMultiplier
        ///  Performance multiplier.
        /// </summary>
        public Substrate.Gear.Api.Generated.Model.gear_core.percent.Percent PerformanceMultiplier()
        {
            var result = new Substrate.Gear.Api.Generated.Model.gear_core.percent.Percent();
            result.Create("0x64000000");
            return result;
        }
        
        /// <summary>
        /// >> MailboxThreshold
        ///  The minimal gas amount for message to be inserted in mailbox.
        /// 
        ///  This gas will be consuming as rent for storing and message will be available
        ///  for reply or claim, once gas ends, message removes.
        /// 
        ///  Messages with gas limit less than that minimum will not be added in mailbox,
        ///  but will be seen in events.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U64 MailboxThreshold()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U64();
            result.Create("0xB80B000000000000");
            return result;
        }
        
        /// <summary>
        /// >> ReservationsLimit
        ///  Amount of reservations can exist for 1 program.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U64 ReservationsLimit()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U64();
            result.Create("0x0001000000000000");
            return result;
        }
        
        /// <summary>
        /// >> ProgramRentFreePeriod
        ///  The free of charge period of rent.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 ProgramRentFreePeriod()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x00D44900");
            return result;
        }
        
        /// <summary>
        /// >> ProgramResumeMinimalRentPeriod
        ///  The minimal amount of blocks to resume.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 ProgramResumeMinimalRentPeriod()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x004E0C00");
            return result;
        }
        
        /// <summary>
        /// >> ProgramRentCostPerBlock
        ///  The program rent cost per block.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 ProgramRentCostPerBlock()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U128();
            result.Create("0x40597307000000000000000000000000");
            return result;
        }
        
        /// <summary>
        /// >> ProgramResumeSessionDuration
        ///  The amount of blocks for processing resume session.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 ProgramResumeSessionDuration()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0xB0040000");
            return result;
        }
        
        /// <summary>
        /// >> ProgramRentEnabled
        ///  The flag determines if program rent mechanism enabled.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.Bool ProgramRentEnabled()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.Bool();
            result.Create("0x00");
            return result;
        }
        
        /// <summary>
        /// >> ProgramRentDisabledDelta
        ///  The constant defines value that is added if the program
        ///  rent is disabled.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 ProgramRentDisabledDelta()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x80130300");
            return result;
        }
        
        /// <summary>
        /// >> RentPoolId
        ///  The account id of the rent pool if any.
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Gear.Api.Generated.Model.sp_core.crypto.AccountId32> RentPoolId()
        {
            var result = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Gear.Api.Generated.Model.sp_core.crypto.AccountId32>();
            result.Create("0x01E68325A26F5E8EA5C6C93BBDCFA596AC3EC8B69301C0CC54029DC7BC891BC515");
            return result;
        }
    }
    
    /// <summary>
    /// >> GearErrors
    /// </summary>
    public enum GearErrors
    {
        
        /// <summary>
        /// >> MessageNotFound
        /// Message wasn't found in the mailbox.
        /// </summary>
        MessageNotFound,
        
        /// <summary>
        /// >> InsufficientBalance
        /// Not enough balance to execute an action.
        /// 
        /// Usually occurs when the gas_limit specified is such that the origin account can't afford the message.
        /// </summary>
        InsufficientBalance,
        
        /// <summary>
        /// >> GasLimitTooHigh
        /// Gas limit too high.
        /// 
        /// Occurs when an extrinsic's declared `gas_limit` is greater than a block's maximum gas limit.
        /// </summary>
        GasLimitTooHigh,
        
        /// <summary>
        /// >> ProgramAlreadyExists
        /// Program already exists.
        /// 
        /// Occurs if a program with some specific program id already exists in program storage.
        /// </summary>
        ProgramAlreadyExists,
        
        /// <summary>
        /// >> InactiveProgram
        /// Program is terminated.
        /// 
        /// Program init failed, so such message destination is no longer unavailable.
        /// </summary>
        InactiveProgram,
        
        /// <summary>
        /// >> NoMessageTree
        /// Message gas tree is not found.
        /// 
        /// When a message claimed from the mailbox has a corrupted or non-extant gas tree associated.
        /// </summary>
        NoMessageTree,
        
        /// <summary>
        /// >> CodeAlreadyExists
        /// Code already exists.
        /// 
        /// Occurs when trying to save to storage a program code that has been saved there.
        /// </summary>
        CodeAlreadyExists,
        
        /// <summary>
        /// >> CodeDoesntExist
        /// Code does not exist.
        /// 
        /// Occurs when trying to get a program code from storage, that doesn't exist.
        /// </summary>
        CodeDoesntExist,
        
        /// <summary>
        /// >> CodeTooLarge
        /// The code supplied to `upload_code` or `upload_program` exceeds the limit specified in the
        /// current schedule.
        /// </summary>
        CodeTooLarge,
        
        /// <summary>
        /// >> ProgramConstructionFailed
        /// Failed to create a program.
        /// </summary>
        ProgramConstructionFailed,
        
        /// <summary>
        /// >> MessageQueueProcessingDisabled
        /// Message queue processing is disabled.
        /// </summary>
        MessageQueueProcessingDisabled,
        
        /// <summary>
        /// >> ResumePeriodLessThanMinimal
        /// Block count doesn't cover MinimalResumePeriod.
        /// </summary>
        ResumePeriodLessThanMinimal,
        
        /// <summary>
        /// >> ProgramNotFound
        /// Program with the specified id is not found.
        /// </summary>
        ProgramNotFound,
        
        /// <summary>
        /// >> GearRunAlreadyInBlock
        /// Gear::run() already included in current block.
        /// </summary>
        GearRunAlreadyInBlock,
        
        /// <summary>
        /// >> ProgramRentDisabled
        /// The program rent logic is disabled.
        /// </summary>
        ProgramRentDisabled,
        
        /// <summary>
        /// >> ActiveProgram
        /// Program is active.
        /// </summary>
        ActiveProgram,
    }
}
