#![no_std]

use sails_macros::gprogram;
use sails_rtl_gstd::GStdExecContext;
use services::Catalog;

// Exposed publicly because of service metadata for IDL
// Will be superseded by program metadata, thus pub won't be needed
pub mod services;

#[derive(Default)]
pub struct Program;

#[gprogram]
impl Program {
    // Initialize program and seed hosted services
    pub fn new() -> Self {
        let exec_context = GStdExecContext::default();
        Catalog::seed(exec_context);
        Self
    }

    // Expose hosted service
    pub fn catalog(&self) -> Catalog<GStdExecContext> {
        let exec_context = GStdExecContext::default();
        Catalog::new(exec_context)
    }

    // Will be generated by the `ginject_defaults` macro from the `new` method
    fn __new(exec_context: GStdExecContext) -> Self {
        Catalog::seed(exec_context);
        Self
    }

    // Will be generated by the `ginject_defaults` macro from the `catalog` method
    fn __catalog(&self, exec_context: GStdExecContext) -> Catalog<GStdExecContext> {
        Catalog::new(exec_context)
    }
}

// The below code will be generated by the `gprogram` macro
#[cfg(target_arch = "wasm32")]
pub mod wasm_main {
    use super::wasm::PROGRAM;
    use super::*;
    use sails_rtl_gstd::{gstd, gstd::msg};
    use services::requests;

    #[gstd::async_main] // Make async optional
    async fn main() {
        let input_bytes = msg::load_bytes().expect("Failed to read input");
        let mut catalog = unsafe { PROGRAM.as_ref().unwrap() }.catalog();
        let output_bytes = requests::process(&mut catalog, &input_bytes).await;
        msg::reply_bytes(output_bytes, 0).expect("Failed to send output");
    }
}
