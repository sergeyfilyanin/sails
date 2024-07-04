use sails_rtl::{cell::RefCell, gstd::gservice, prelude::*};

pub struct CounterData {
    counter: u32,
}

impl CounterData {
    pub const fn new(counter: u32) -> Self {
        Self { counter }
    }
}

#[derive(Encode, TypeInfo)]
#[codec(crate = sails_rtl::scale_codec)]
#[scale_info(crate = sails_rtl::scale_info)]
enum CounterEvents {
    Added(u32),
    Subtracted(u32),
}

pub struct CounterService<'a> {
    data: &'a RefCell<CounterData>,
}

impl<'a> CounterService<'a> {
    pub fn new(data: &'a RefCell<CounterData>) -> Self {
        Self { data }
    }
}

#[gservice(events = CounterEvents)]
impl<'a> CounterService<'a> {
    pub fn add(&mut self, value: u32) -> u32 {
        let mut data_mut = self.data.borrow_mut();
        data_mut.counter += value;
        self.notify_on(CounterEvents::Added(value)).unwrap();
        data_mut.counter
    }

    pub fn sub(&mut self, value: u32) -> u32 {
        let mut data_mut = self.data.borrow_mut();
        data_mut.counter -= value;
        self.notify_on(CounterEvents::Subtracted(value)).unwrap();
        data_mut.counter
    }

    pub fn value(&self) -> u32 {
        self.data.borrow().counter
    }
}
