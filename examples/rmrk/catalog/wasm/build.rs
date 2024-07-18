use rmrk_catalog_app::Program;
use std::{env, path::PathBuf};

fn main() {
    gwasm_builder::build();

    sails_idl_gen::generate_idl_to_file::<Program>(
        PathBuf::from(env::var("CARGO_MANIFEST_DIR").unwrap()).join("rmrk-catalog.idl"),
    )
    .unwrap();
}
