using System.Diagnostics.CodeAnalysis;
using Agilent.Ace.Testables.Process.Wrappers;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Agilent.Ace.Testables.Process.Tests.Wrappers
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
