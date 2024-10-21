#![doc = include_str!("../README.md")]
#![no_std]

#[cfg(feature = "mockall")]
#[cfg(not(target_arch = "wasm32"))]
extern crate std;

#[cfg(feature = "wasm-builder")]
pub use gwasm_builder::build as build_wasm;
pub use hex::{self};
pub use prelude::*;
#[cfg(feature = "idl-gen")]
#[cfg(not(target_arch = "wasm32"))]
pub use sails_idl_gen::{generate_idl, generate_idl_to_file};
pub use sails_idl_meta::{self as meta};
pub use spin::{self};

pub mod calls;
pub mod errors;
#[cfg(not(target_arch = "wasm32"))]
pub mod events;
#[cfg(feature = "gclient")]
#[cfg(not(target_arch = "wasm32"))]
pub mod gclient;
#[cfg(feature = "gstd")]
pub mod gstd;
#[cfg(feature = "gtest")]
#[cfg(not(target_arch = "wasm32"))]
pub mod gtest;
#[cfg(feature = "mockall")]
#[cfg(not(target_arch = "wasm32"))]
pub mod mockall;
pub mod prelude;
mod types;
