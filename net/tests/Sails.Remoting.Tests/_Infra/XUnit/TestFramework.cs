﻿using Xunit.Abstractions;

[assembly: Xunit.TestFramework(
    "Sails.Remoting.Tests._Infra.XUnit.TestFramework",
    "Sails.Remoting.Tests")]

namespace Sails.Remoting.Tests._Infra.XUnit;

internal sealed class TestFramework : TestUtils.XUnit.TestFramework
{
    public TestFramework(IMessageSink messageSink)
        : base(messageSink)
    {
    }
}