using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Versioning;
using System.Security;

#if NET8_0_OR_GREATER
[assembly: SupportedOSPlatform("windows")]
#endif
namespace Agilent.Ace.Testables.Process.Abstractions
{
    /// <summary>
    /// A factory for the creation of wrappers for <see cref="System.Diagnostics.Process"/>
    /// </summary>
    public interface IProcessFactory
    {

#pragma warning disable CA1716
        /// <summary>
        /// Initializes a new instance of a wrapper for <see cref="System.Diagnostics.Process"/>
        /// </summary>
        /// <returns></returns>
        IProcess New();
#pragma warning restore CA1716
        /// <inheritdoc cref="System.Diagnostics.Process.GetCurrentProcess()"/>
        IProcess GetCurrentProcess();

        /// <inheritdoc cref="System.Diagnostics.Process.GetProcessById(int)"/>
        IProcess GetProcessById(int processId);

        /// <inheritdoc cref="System.Diagnostics.Process.GetProcessById(int, string)"/>
        IProcess GetProcessById(int processId, string machineName);

        /// <inheritdoc cref="System.Diagnostics.Process.Start(ProcessStartInfo)"/>
        IProcess Start(ProcessStartInfo startInfo);

        /// <inheritdoc cref="System.Diagnostics.Process.Start(string)"/>
        IProcess Start(string fileName);

        /// <inheritdoc cref="System.Diagnostics.Process.Start(string, string)"/>
        IProcess Start(string fileName, string arguments);

        /// <inheritdoc cref="System.Diagnostics.Process.Start(string, string, SecureString, string)"/>
        IProcess Start(string fileName, string arguments, SecureString password, string domain);

#if NET8_0_OR_GREATER
        /// <inheritdoc cref="System.Diagnostics.Process.Start(string, IEnumerable{string})"/>
        IProcess Start(string fileName, IEnumerable<string> arguments);
#endif

        /// <inheritdoc cref="System.Diagnostics.Process.Start(string, string, string, SecureString, string)"/>
        IProcess Start(string fileName, string arguments, string userName, SecureString password, string domain);

        /// <inheritdoc cref="System.Diagnostics.Process.GetProcesses()"/>
        IProcess[] GetProcesses();

        /// <inheritdoc cref="System.Diagnostics.Process.GetProcesses(string)"/>
        IProcess[] GetProcesses(string machineName);

        /// <inheritdoc cref="System.Diagnostics.Process.GetProcessesByName(string)"/>
        IProcess[] GetProcessesByName(string processName);

        /// <inheritdoc cref="System.Diagnostics.Process.GetProcessesByName(string, string)"/>
        IProcess[] GetProcessesByName(string processName, string machineName);
    }
}
