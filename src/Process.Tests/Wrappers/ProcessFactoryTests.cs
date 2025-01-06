using System.Diagnostics.CodeAnalysis;
using System.Runtime.Versioning;
using Agilent.Testables.Process.Wrappers;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

#if NET8_0_OR_GREATER
[assembly: SupportedOSPlatform("windows")]
#endif
namespace Agilent.Testables.Process.Tests.Wrappers
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class ProcessFactoryTests
    {
        [TestMethod]
        public void New_Should_ProvideNewInstance()
        {
            // Arrange
            var sut = new ProcessFactory();

            // Act
            var result = sut.New();

            // Assert
            result.Should().NotBeNull();
        }
    }
}
