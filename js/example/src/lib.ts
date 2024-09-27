import { NonZeroU32, ActorId, H256, TransactionBuilder, getServiceNamePrefix, getFnNamePrefix, ZERO_ADDRESS, H160, NonZeroU8 } from 'sails-js';
import { GearApi, decodeAddress } from '@gear-js/api';
import { TypeRegistry } from '@polkadot/types';

export type ReferenceCount = [number];

export interface DoThatParam {
  p1: NonZeroU32;
  p2: ActorId;
  p3: ManyVariants;
}

export type ManyVariants = 
  | { one: null }
  | { two: number }
  | { three: number | string | bigint | null }
  | { four: { a: number; b: number | null } }
  | { five: [string, H256] }
  | { six: [number] };

export type TupleStruct = [boolean];

export class Program {
  public readonly registry: TypeRegistry;
  public readonly counter: Counter;
  public readonly dog: Dog;
  public readonly pingPong: PingPong;
  public readonly references: References;
  public readonly thisThat: ThisThat;

  constructor(public api: GearApi, public programId?: `0x${string}`) {
    const types: Record<string, any> = {
      ReferenceCount: "(u32)",
      DoThatParam: {"p1":"u32","p2":"[u8;32]","p3":"ManyVariants"},
      ManyVariants: {"_enum":{"One":"Null","Two":"u32","Three":"Option<U256>","Four":{"a":"u32","b":"Option<u16>"},"Five":"(String, H256)","Six":"(u32)"}},
      TupleStruct: "(bool)",
    }

    this.registry = new TypeRegistry();
    this.registry.setKnownTypes({ types });
    this.registry.register(types);

    this.counter = new Counter(this);
    this.dog = new Dog(this);
    this.pingPong = new PingPong(this);
    this.references = new References(this);
    this.thisThat = new ThisThat(this);
  }

  defaultCtorFromCode(code: Uint8Array | Buffer): TransactionBuilder<null> {
    const builder = new TransactionBuilder<null>(
      this.api,
      this.registry,
      'upload_program',
      'Default',
      'String',
      'String',
      code,
    );

    this.programId = builder.programId;
    return builder;
  }

  defaultCtorFromCodeId(codeId: `0x${string}`) {
    const builder = new TransactionBuilder<null>(
      this.api,
      this.registry,
      'create_program',
      'Default',
      'String',
      'String',
      codeId,
    );

    this.programId = builder.programId;
    return builder;
  }
  newCtorFromCode(code: Uint8Array | Buffer, counter: number | null, dog_position: [number, number] | null): TransactionBuilder<null> {
    const builder = new TransactionBuilder<null>(
      this.api,
      this.registry,
      'upload_program',
      ['New', counter, dog_position],
      '(String, Option<u32>, Option<(i32, i32)>)',
      'String',
      code,
    );

    this.programId = builder.programId;
    return builder;
  }

  newCtorFromCodeId(codeId: `0x${string}`, counter: number | null, dog_position: [number, number] | null) {
    const builder = new TransactionBuilder<null>(
      this.api,
      this.registry,
      'create_program',
      ['New', counter, dog_position],
      '(String, Option<u32>, Option<(i32, i32)>)',
      'String',
      codeId,
    );

    this.programId = builder.programId;
    return builder;
  }
}

export class Counter {
  constructor(private _program: Program) {}

  public add(value: number): TransactionBuilder<number> {
    if (!this._program.programId) throw new Error('Program ID is not set');
    return new TransactionBuilder<number>(
      this._program.api,
      this._program.registry,
      'send_message',
      ['Counter', 'Add', value],
      '(String, String, u32)',
      'u32',
      this._program.programId
    );
  }

  public sub(value: number): TransactionBuilder<number> {
    if (!this._program.programId) throw new Error('Program ID is not set');
    return new TransactionBuilder<number>(
      this._program.api,
      this._program.registry,
      'send_message',
      ['Counter', 'Sub', value],
      '(String, String, u32)',
      'u32',
      this._program.programId
    );
  }

  public async value(originAddress?: string, value?: number | string | bigint, atBlock?: `0x${string}`): Promise<number> {
    const payload = this._program.registry.createType('(String, String)', ['Counter', 'Value']).toHex();
    const reply = await this._program.api.message.calculateReply({
      destination: this._program.programId,
      origin: originAddress ? decodeAddress(originAddress) : ZERO_ADDRESS,
      payload,
      value: value || 0,
      gasLimit: this._program.api.blockGasLimit.toBigInt(),
      at: atBlock || null,
    });
    if (!reply.code.isSuccess) throw new Error(this._program.registry.createType('String', reply.payload).toString());
    const result = this._program.registry.createType('(String, String, u32)', reply.payload);
    return result[2].toNumber() as unknown as number;
  }

  public subscribeToAddedEvent(callback: (data: number) => void | Promise<void>): Promise<() => void> {
    return this._program.api.gearEvents.subscribeToGearEvent('UserMessageSent', ({ data: { message } }) => {;
      if (!message.source.eq(this._program.programId) || !message.destination.eq(ZERO_ADDRESS)) {
        return;
      }

      const payload = message.payload.toHex();
      if (getServiceNamePrefix(payload) === 'Counter' && getFnNamePrefix(payload) === 'Added') {
        callback(this._program.registry.createType('(String, String, u32)', message.payload)[2].toNumber() as unknown as number);
      }
    });
  }

  public subscribeToSubtractedEvent(callback: (data: number) => void | Promise<void>): Promise<() => void> {
    return this._program.api.gearEvents.subscribeToGearEvent('UserMessageSent', ({ data: { message } }) => {;
      if (!message.source.eq(this._program.programId) || !message.destination.eq(ZERO_ADDRESS)) {
        return;
      }

      const payload = message.payload.toHex();
      if (getServiceNamePrefix(payload) === 'Counter' && getFnNamePrefix(payload) === 'Subtracted') {
        callback(this._program.registry.createType('(String, String, u32)', message.payload)[2].toNumber() as unknown as number);
      }
    });
  }
}

export class Dog {
  constructor(private _program: Program) {}

  public makeSound(): TransactionBuilder<string> {
    if (!this._program.programId) throw new Error('Program ID is not set');
    return new TransactionBuilder<string>(
      this._program.api,
      this._program.registry,
      'send_message',
      ['Dog', 'MakeSound'],
      '(String, String)',
      'String',
      this._program.programId
    );
  }

  public walk(dx: number, dy: number): TransactionBuilder<null> {
    if (!this._program.programId) throw new Error('Program ID is not set');
    return new TransactionBuilder<null>(
      this._program.api,
      this._program.registry,
      'send_message',
      ['Dog', 'Walk', dx, dy],
      '(String, String, i32, i32)',
      'Null',
      this._program.programId
    );
  }

  public async avgWeight(originAddress?: string, value?: number | string | bigint, atBlock?: `0x${string}`): Promise<number> {
    const payload = this._program.registry.createType('(String, String)', ['Dog', 'AvgWeight']).toHex();
    const reply = await this._program.api.message.calculateReply({
      destination: this._program.programId,
      origin: originAddress ? decodeAddress(originAddress) : ZERO_ADDRESS,
      payload,
      value: value || 0,
      gasLimit: this._program.api.blockGasLimit.toBigInt(),
      at: atBlock || null,
    });
    if (!reply.code.isSuccess) throw new Error(this._program.registry.createType('String', reply.payload).toString());
    const result = this._program.registry.createType('(String, String, u32)', reply.payload);
    return result[2].toNumber() as unknown as number;
  }

  public async position(originAddress?: string, value?: number | string | bigint, atBlock?: `0x${string}`): Promise<[number, number]> {
    const payload = this._program.registry.createType('(String, String)', ['Dog', 'Position']).toHex();
    const reply = await this._program.api.message.calculateReply({
      destination: this._program.programId,
      origin: originAddress ? decodeAddress(originAddress) : ZERO_ADDRESS,
      payload,
      value: value || 0,
      gasLimit: this._program.api.blockGasLimit.toBigInt(),
      at: atBlock || null,
    });
    if (!reply.code.isSuccess) throw new Error(this._program.registry.createType('String', reply.payload).toString());
    const result = this._program.registry.createType('(String, String, (i32, i32))', reply.payload);
    return result[2].toJSON() as unknown as [number, number];
  }

  public subscribeToBarkedEvent(callback: (data: null) => void | Promise<void>): Promise<() => void> {
    return this._program.api.gearEvents.subscribeToGearEvent('UserMessageSent', ({ data: { message } }) => {;
      if (!message.source.eq(this._program.programId) || !message.destination.eq(ZERO_ADDRESS)) {
        return;
      }

      const payload = message.payload.toHex();
      if (getServiceNamePrefix(payload) === 'Dog' && getFnNamePrefix(payload) === 'Barked') {
        callback(null);
      }
    });
  }

  public subscribeToWalkedEvent(callback: (data: { from: [number, number]; to: [number, number] }) => void | Promise<void>): Promise<() => void> {
    return this._program.api.gearEvents.subscribeToGearEvent('UserMessageSent', ({ data: { message } }) => {;
      if (!message.source.eq(this._program.programId) || !message.destination.eq(ZERO_ADDRESS)) {
        return;
      }

      const payload = message.payload.toHex();
      if (getServiceNamePrefix(payload) === 'Dog' && getFnNamePrefix(payload) === 'Walked') {
        callback(this._program.registry.createType('(String, String, {"from":"(i32, i32)","to":"(i32, i32)"})', message.payload)[2].toJSON() as unknown as { from: [number, number]; to: [number, number] });
      }
    });
  }
}

export class PingPong {
  constructor(private _program: Program) {}

  public ping(input: string): TransactionBuilder<{ ok: string } | { err: string }> {
    if (!this._program.programId) throw new Error('Program ID is not set');
    return new TransactionBuilder<{ ok: string } | { err: string }>(
      this._program.api,
      this._program.registry,
      'send_message',
      ['PingPong', 'Ping', input],
      '(String, String, String)',
      'Result<String, String>',
      this._program.programId
    );
  }
}

export class References {
  constructor(private _program: Program) {}

  public add(v: number): TransactionBuilder<number> {
    if (!this._program.programId) throw new Error('Program ID is not set');
    return new TransactionBuilder<number>(
      this._program.api,
      this._program.registry,
      'send_message',
      ['References', 'Add', v],
      '(String, String, u32)',
      'u32',
      this._program.programId
    );
  }

  public addByte(byte: number): TransactionBuilder<`0x${string}`> {
    if (!this._program.programId) throw new Error('Program ID is not set');
    return new TransactionBuilder<`0x${string}`>(
      this._program.api,
      this._program.registry,
      'send_message',
      ['References', 'AddByte', byte],
      '(String, String, u8)',
      'Vec<u8>',
      this._program.programId
    );
  }

  public guessNum(number: number): TransactionBuilder<{ ok: string } | { err: string }> {
    if (!this._program.programId) throw new Error('Program ID is not set');
    return new TransactionBuilder<{ ok: string } | { err: string }>(
      this._program.api,
      this._program.registry,
      'send_message',
      ['References', 'GuessNum', number],
      '(String, String, u8)',
      'Result<String, String>',
      this._program.programId
    );
  }

  public incr(): TransactionBuilder<ReferenceCount> {
    if (!this._program.programId) throw new Error('Program ID is not set');
    return new TransactionBuilder<ReferenceCount>(
      this._program.api,
      this._program.registry,
      'send_message',
      ['References', 'Incr'],
      '(String, String)',
      'ReferenceCount',
      this._program.programId
    );
  }

  public setNum(number: number): TransactionBuilder<{ ok: null } | { err: string }> {
    if (!this._program.programId) throw new Error('Program ID is not set');
    return new TransactionBuilder<{ ok: null } | { err: string }>(
      this._program.api,
      this._program.registry,
      'send_message',
      ['References', 'SetNum', number],
      '(String, String, u8)',
      'Result<Null, String>',
      this._program.programId
    );
  }

  public async baked(originAddress?: string, value?: number | string | bigint, atBlock?: `0x${string}`): Promise<string> {
    const payload = this._program.registry.createType('(String, String)', ['References', 'Baked']).toHex();
    const reply = await this._program.api.message.calculateReply({
      destination: this._program.programId,
      origin: originAddress ? decodeAddress(originAddress) : ZERO_ADDRESS,
      payload,
      value: value || 0,
      gasLimit: this._program.api.blockGasLimit.toBigInt(),
      at: atBlock || null,
    });
    if (!reply.code.isSuccess) throw new Error(this._program.registry.createType('String', reply.payload).toString());
    const result = this._program.registry.createType('(String, String, String)', reply.payload);
    return result[2].toString() as unknown as string;
  }

  public async lastByte(originAddress?: string, value?: number | string | bigint, atBlock?: `0x${string}`): Promise<number | null> {
    const payload = this._program.registry.createType('(String, String)', ['References', 'LastByte']).toHex();
    const reply = await this._program.api.message.calculateReply({
      destination: this._program.programId,
      origin: originAddress ? decodeAddress(originAddress) : ZERO_ADDRESS,
      payload,
      value: value || 0,
      gasLimit: this._program.api.blockGasLimit.toBigInt(),
      at: atBlock || null,
    });
    if (!reply.code.isSuccess) throw new Error(this._program.registry.createType('String', reply.payload).toString());
    const result = this._program.registry.createType('(String, String, Option<u8>)', reply.payload);
    return result[2].toJSON() as unknown as number | null;
  }

  public async message(originAddress?: string, value?: number | string | bigint, atBlock?: `0x${string}`): Promise<string | null> {
    const payload = this._program.registry.createType('(String, String)', ['References', 'Message']).toHex();
    const reply = await this._program.api.message.calculateReply({
      destination: this._program.programId,
      origin: originAddress ? decodeAddress(originAddress) : ZERO_ADDRESS,
      payload,
      value: value || 0,
      gasLimit: this._program.api.blockGasLimit.toBigInt(),
      at: atBlock || null,
    });
    if (!reply.code.isSuccess) throw new Error(this._program.registry.createType('String', reply.payload).toString());
    const result = this._program.registry.createType('(String, String, Option<String>)', reply.payload);
    return result[2].toJSON() as unknown as string | null;
  }
}

export class ThisThat {
  constructor(private _program: Program) {}

  public doThat(param: DoThatParam): TransactionBuilder<{ ok: [ActorId, NonZeroU32] } | { err: [string] }> {
    if (!this._program.programId) throw new Error('Program ID is not set');
    return new TransactionBuilder<{ ok: [ActorId, NonZeroU32] } | { err: [string] }>(
      this._program.api,
      this._program.registry,
      'send_message',
      ['ThisThat', 'DoThat', param],
      '(String, String, DoThatParam)',
      'Result<([u8;32], u32), (String)>',
      this._program.programId
    );
  }

  public doThis(p1: number, p2: string, p3: [H160 | null, NonZeroU8], p4: TupleStruct): TransactionBuilder<[string, number]> {
    if (!this._program.programId) throw new Error('Program ID is not set');
    return new TransactionBuilder<[string, number]>(
      this._program.api,
      this._program.registry,
      'send_message',
      ['ThisThat', 'DoThis', p1, p2, p3, p4],
      '(String, String, u32, String, (Option<H160>, u8), TupleStruct)',
      '(String, u32)',
      this._program.programId
    );
  }

  public noop(): TransactionBuilder<null> {
    if (!this._program.programId) throw new Error('Program ID is not set');
    return new TransactionBuilder<null>(
      this._program.api,
      this._program.registry,
      'send_message',
      ['ThisThat', 'Noop'],
      '(String, String)',
      'Null',
      this._program.programId
    );
  }

  public async that(originAddress?: string, value?: number | string | bigint, atBlock?: `0x${string}`): Promise<{ ok: string } | { err: string }> {
    const payload = this._program.registry.createType('(String, String)', ['ThisThat', 'That']).toHex();
    const reply = await this._program.api.message.calculateReply({
      destination: this._program.programId,
      origin: originAddress ? decodeAddress(originAddress) : ZERO_ADDRESS,
      payload,
      value: value || 0,
      gasLimit: this._program.api.blockGasLimit.toBigInt(),
      at: atBlock || null,
    });
    if (!reply.code.isSuccess) throw new Error(this._program.registry.createType('String', reply.payload).toString());
    const result = this._program.registry.createType('(String, String, Result<String, String>)', reply.payload);
    return result[2].toJSON() as unknown as { ok: string } | { err: string };
  }

  public async this(originAddress?: string, value?: number | string | bigint, atBlock?: `0x${string}`): Promise<number> {
    const payload = this._program.registry.createType('(String, String)', ['ThisThat', 'This']).toHex();
    const reply = await this._program.api.message.calculateReply({
      destination: this._program.programId,
      origin: originAddress ? decodeAddress(originAddress) : ZERO_ADDRESS,
      payload,
      value: value || 0,
      gasLimit: this._program.api.blockGasLimit.toBigInt(),
      at: atBlock || null,
    });
    if (!reply.code.isSuccess) throw new Error(this._program.registry.createType('String', reply.payload).toString());
    const result = this._program.registry.createType('(String, String, u32)', reply.payload);
    return result[2].toNumber() as unknown as number;
  }
}