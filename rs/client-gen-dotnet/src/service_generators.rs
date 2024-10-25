use crate::{helpers::*, type_generators::TypeDeclGenerator};
use convert_case::{Case, Casing};
use csharp::{block_comment, Tokens};
use genco::prelude::*;
use sails_idl_parser::{ast::visitor, ast::visitor::Visitor, ast::*};

const BASE_TUPLE_RUST: &str = "global::Substrate.NetApi.Model.Types.Base.BaseTupleRust";
const IQUERY: &str = "global::Sails.Remoting.Abstractions.IQuery";
const ICALL: &str = "global::Sails.Remoting.Abstractions.ICall";

/// Generates a client that implements service trait
pub(crate) struct ServiceClientGenerator<'a> {
    service_name: String,
    type_generator: TypeDeclGenerator<'a>,
    interface_tokens: Tokens,
    class_tokens: Tokens,
}

impl<'a> ServiceClientGenerator<'a> {
    pub(crate) fn new(service_name: String, type_generator: TypeDeclGenerator<'a>) -> Self {
        Self {
            service_name,
            type_generator,
            interface_tokens: Tokens::new(),
            class_tokens: Tokens::new(),
        }
    }

    pub(crate) fn finalize(self) -> Tokens {
        let name = &self.service_name.to_case(Case::Pascal);

        quote! {
            public interface I$name
            {
                $(self.interface_tokens)
            }

            public partial class $name : I$name
            {
                private readonly IRemoting remoting;

                public $name(IRemoting remoting)
                {
                    this.remoting = remoting;
                }

                $(self.class_tokens)
            }
        }
    }
}

// using quote_in instead of tokens.append
impl<'a> Visitor<'a> for ServiceClientGenerator<'a> {
    fn visit_service(&mut self, service: &'a Service) {
        visitor::accept_service(service, self);
    }

    fn visit_service_func(&mut self, func: &'a ServiceFunc) {
        let func_name_pascal = &func.name().to_case(Case::Pascal);
        let return_type = if func.is_query() { IQUERY } else { ICALL };

        let service_route_bytes = path_bytes(self.service_name.as_str()).0;
        let func_route_bytes = path_bytes(func.name()).0;
        let route_bytes = vec![service_route_bytes, func_route_bytes].join(", ");

        let args = encoded_fn_args(func.params());
        let args_with_type = func
            .params()
            .iter()
            .map(|p| {
                format!(
                    "{} {}",
                    self.type_generator.generate_type_decl(p.type_decl()),
                    p.name().to_case(Case::Camel)
                )
            })
            .collect::<Vec<_>>()
            .join(",\r");

        // let type_decls = func
        //     .params()
        //     .iter()
        //     .map(|p| p.type_decl())
        //     .collect::<Vec<_>>();
        // let tuple_arg_type = self.type_generator.generate_types_as_tuple(type_decls);
        let func_return_type = &self.type_generator.generate_type_decl(func.output());

        quote_in! { self.interface_tokens =>
            $return_type<$func_return_type> $func_name_pascal($['\r']
                $(&args_with_type));$['\r']
        };

        quote_in! { self.class_tokens =>
            $(block_comment(vec!["<inheritdoc/>"]))
            public $return_type<$func_return_type> $func_name_pascal($['\r']
                $(&args_with_type))
            {
                return new RemotingAction<$func_return_type>(
                    this.remoting,
                    new byte[] { $(&route_bytes) },
                    new $(BASE_TUPLE_RUST)($(&args))
                );
            }
        };
    }
}
