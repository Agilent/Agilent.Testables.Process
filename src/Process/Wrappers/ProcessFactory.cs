// (c) Copyright 2024 Agilent Technologies, Inc. All Rights Reserved.

// Prevents unused usings being highlighted.
#pragma warning disable IDE0079
#pragma warning disable IDE0005

using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Versioning;
using System.Security;
using Agilent.Ace.Testables.Process.Abstractions;

#if NET8_0_OR_GREATER
[assembly: SupportedOSPlatform("windows")]
#endif
namespace Agilent.Ace.Testables.Process.Wrappers
{
    public class ProcessFactory : IProcessFactory
    {
        /// <inheritdoc />
        public IProcess New()
        {
            var realProcess = new System.Diagnostics.Process();
            return new ProcessWrapper(realProcess);
        }

        /// <inheritdoc />
        public IProcess GetCurrentProcess()
        {
            var realProcess = System.Diagnostics.Process.GetCurrentProcess();
            return new ProcessWrapper(realProcess);
        }

        /// <inheritdoc />
        public IProcess GetProcessById(int processId)
        {
            var realProcess = System.Diagnostics.Process.GetProcessById(processId);
            return new ProcessWrapper(realProcess);
        }

        /// <inheritdoc />
        public IProcess GetProcessById(int processId, string machineName)
        {
            var realProcess = System.Diagnostics.Process.GetProcessById(processId, machineName);
            return new ProcessWrapper(realProcess);
        }

        /// <inheritdoc />
        public IProcess Start(ProcessStartInfo startInfo)
        {
            var realProcess = System.Diagnostics.Process.Start(startInfo);
            return new ProcessWrapper(realProcess);
        }

        /// <inheritdoc />
        public IProcess Start(string fileName)
        {
            var realProcess = System.Diagnostics.Process.Start(fileName);
            return new ProcessWrapper(realProcess);
        }

        /// <inheritdoc />
        public IProcess Start(string fileName, string arguments)
        {
            var realProcess = System.Diagnostics.Process.Start(fileName, arguments);
            return new ProcessWrapper(realProcess);
        }

        /// <inheritdoc />
        public IProcess Start(string fileName, string arguments, SecureString password, string domain)
        {
            var realProcess = System.Diagnostics.Process.Start(fileName, arguments, password, domain);
            return new ProcessWrapper(realProcess);
        }

#if NET8_0_OR_GREATER
        /// <inheritdoc />
        public IProcess Start(string fileName, IEnumerable<string> arguments)
        {
            var realProcess = System.Diagnostics.Process.Start(fileName, arguments);
            return new ProcessWrapper(realProcess);
        }
#endif

        /// <inheritdoc />
        public IProcess Start(string fileName, string arguments, string userName, SecureString password, string domain)
        {
            var realProcess = System.Diagnostics.Process.Start(fileName, arguments, userName, password, domain);
            return new ProcessWrapper(realProcess);
        }

        /// <inheritdoc />
        public IProcess[] GetProcesses()
        {
            var realProcesses = System.Diagnostics.Process.GetProcesses();
            return realProcesses.Select(process => new ProcessWrapper(process)).Cast<IProcess>().ToArray();
        }

        /// <inheritdoc />
        public IProcess[] GetProcesses(string machineName)
        {
            var realProcesses = System.Diagnostics.Process.GetProcesses(machineName);
            return realProcesses.Select(process => new ProcessWrapper(process)).Cast<IProcess>().ToArray();
        }

        /// <inheritdoc />
        public IProcess[] GetProcessesByName(string processName)
        {
            var realProcesses = System.Diagnostics.Process.GetProcessesByName(processName);
            return realProcesses.Select(process => new ProcessWrapper(process)).Cast<IProcess>().ToArray();
        }

        /// <inheritdoc />
        public IProcess[] GetProcessesByName(string processName, string machineName)
        {
            var realProcesses = System.Diagnostics.Process.GetProcessesByName(processName, machineName);
            return realProcesses.Select(process => new ProcessWrapper(process)).Cast<IProcess>().ToArray();
        }
    }
}
