use sails_macros::service;

struct MyService;

#[service]
impl MyService {
    pub fn this(&self, p1: bool) -> CommandReply<bool> {
        !p1.into()
    }
}

#[tokio::main]
async fn main() {}
