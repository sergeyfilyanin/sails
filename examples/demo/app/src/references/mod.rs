use core::ptr;
use sails_rtl::{gstd::gservice, prelude::*};

// This example makes use of fully incapsulated static state.
// It is safe to use this approach in WASM envrionment due to its single-threaded nature.
// But there might be issues in multi-threaded environment like testing.
// Tags: #state
static mut COUNTER: ReferenceCount = ReferenceCount(0);
static mut BYTES: Vec<u8> = Vec::new();

#[derive(Default)]
pub struct ReferenceService(());

#[gservice]
impl ReferenceService {
    pub fn baked(&self) -> &'static str {
        "Static str!"
    }

    pub fn incr(&mut self) -> &'static ReferenceCount {
        unsafe {
            COUNTER.0 += 1;
            &*ptr::addr_of!(COUNTER)
        }
    }

    pub fn add_byte(&mut self, byte: u8) -> &'static [u8] {
        unsafe {
            BYTES.push(byte);
            &*ptr::addr_of!(BYTES)
        }
    }
}

#[derive(Debug, Encode, Decode, TypeInfo)]
#[codec(crate = sails_rtl::scale_codec)]
#[scale_info(crate = sails_rtl::scale_info)]
pub struct ReferenceCount(u32);