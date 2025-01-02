// (c) Copyright 2024 Agilent Technologies, Inc. All Rights Reserved.

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Agilent.Ace.Testables.Process.Wrappers;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Agilent.Ace.Testables.Process.Tests.Wrappers
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class ProcessWrapperTests
    {
        private static System.Diagnostics.Process GetProcess()
        {
            var process = new System.Diagnostics.Process();
            var startInfo = new ProcessStartInfo
            {
                FileName = "CMD.exe",
                UseShellExecute = false,
                CreateNoWindow = true,
            };

            process.StartInfo = startInfo;
            return process;
        }

        [TestMethod]
        public void ExitedEventHandler_Should_Fire()
        {
            // Arrange
            var process = GetProcess();
            var sut = new ProcessWrapper(process)
            {
                EnableRaisingEvents = true
            };
            sut.Start();
            using var monitoredProcess = sut.Monitor();

            // Act
            process.Kill();

            // Assert
            sut.WaitForExit();
            monitoredProcess.Should().Raise(nameof(ProcessWrapper.Exited));
        }

#if (!NET8_0_OR_GREATER)
        /// <summary>
        /// See <see cref="Agilent.Ace.Testables.Process.Abstractions.IProcess.Disposed"/> for more information on
        /// framework compatibility
        /// </summary>
        [TestMethod]
        public void DisposedEventHandler_Should_Fire()
        {
            // Arrange
            var process = GetProcess();
            var sut = new ProcessWrapper(process)
            {
                EnableRaisingEvents = true
            };
            sut.Start();
            using var monitoredProcess = process.Monitor();
            process.Kill();

            // Act
            process.Dispose();

            // Assert
            monitoredProcess.Should().Raise(nameof(System.Diagnostics.Process.Disposed));
        }
#endif
    }
}
