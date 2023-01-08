using Api;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests;

public class ReflectionHelperXunitTests
{
    [Fact]
    public void Test1()
    {
        var assemblies = ReflectionHelper.GetAllAssemblies();
        var existsMediatRAssembly = assemblies.Any(x => x.GetName().Name.Contains("MediatR"));
        existsMediatRAssembly.Should().BeFalse(); // in rider test runner is `false` but in dotnet cmd test runner it is `true`
    }
}

[TestClass]
public class MicrosoftReflectionHelperTests
{
    [TestMethod]
    public void Test1()
    {
        var assemblies = ReflectionHelper.GetAllAssemblies();
        var existsMediatRAssembly = assemblies.Any(x => x.GetName().Name.Contains("MediatR"));
        existsMediatRAssembly.Should().BeFalse(); // in rider test runner and dotnet cmd test runner is `false`
    }
}