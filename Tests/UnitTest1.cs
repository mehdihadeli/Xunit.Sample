using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests;

public class XunitTests
{
    [Fact]
    public void Test1()
    {
        var assemblies = AppDomain.CurrentDomain.GetAssemblies();
        var count = assemblies.Length;
        // count.Should().Be(56); // in rider test runner
        count.Should().Be(345); // in dotnet cmd test runner
    }
}

[TestClass]
public class MicrosoftTests
{
    [TestMethod]
    public void Test1()
    {
        var assemblies = AppDomain.CurrentDomain.GetAssemblies();
        var count = assemblies.Length;
        //count.Should().Be(67); // in rider test runner
        count.Should().Be(76); // in dotnet cmd test runner
    }
}