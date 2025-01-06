using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32.SafeHandles;

// Active for remainder of file if not restored
#pragma warning disable CA1041 // Provide ObsoleteAttribute message
#pragma warning disable S1133 // Deprecated code should be removed
#pragma warning disable S1123 // Obsolete attributes should include explanations

namespace Agilent.Testables.Process.Abstractions
{
    /// <summary>
    ///     Abstractions for <see cref="System.Diagnostics.Process" />
    /// </summary>
    public interface IProcess : IDisposable
    {
        /// <inheritdoc cref="System.Diagnostics.Process.EnableRaisingEvents" />
        bool EnableRaisingEvents { get; set; }

        /// <inheritdoc cref="System.Diagnostics.Process.HasExited" />
        bool HasExited { get; }

        /// <inheritdoc cref="System.Diagnostics.Process.PriorityBoostEnabled" />
        bool PriorityBoostEnabled { get; set; }

        /// <inheritdoc cref="System.Diagnostics.Process.Responding" />
        bool Responding { get; }

        /// <inheritdoc cref="System.Diagnostics.Process.BasePriority" />
        int BasePriority { get; }

        /// <inheritdoc cref="System.Diagnostics.Process.ExitCode" />
        int ExitCode { get; }

        /// <inheritdoc cref="System.Diagnostics.Process.HandleCount" />
        int HandleCount { get; }

        /// <inheritdoc cref="System.Diagnostics.Process.Id" />
        int Id { get; }

        /// <inheritdoc cref="System.Diagnostics.Process.NonpagedSystemMemorySize" />
        [Obsolete]
        int NonpagedSystemMemorySize { get; }

        /// <inheritdoc cref="System.Diagnostics.Process.PagedMemorySize" />
        [Obsolete]
        int PagedMemorySize { get; }

        /// <inheritdoc cref="System.Diagnostics.Process.PagedSystemMemorySize" />
        [Obsolete]
        int PagedSystemMemorySize { get; }

        /// <inheritdoc cref="System.Diagnostics.Process.PeakPagedMemorySize" />
        [Obsolete]
        int PeakPagedMemorySize { get; }

        /// <inheritdoc cref="System.Diagnostics.Process.PeakVirtualMemorySize" />
        [Obsolete]
        int PeakVirtualMemorySize { get; }

        /// <inheritdoc cref="System.Diagnostics.Process.PeakWorkingSet" />
        [Obsolete]
        int PeakWorkingSet { get; }

        /// <inheritdoc cref="System.Diagnostics.Process.PrivateMemorySize" />
        [Obsolete]
        int PrivateMemorySize { get; }

        /// <inheritdoc cref="System.Diagnostics.Process.SessionId" />
        int SessionId { get; }

        /// <inheritdoc cref="System.Diagnostics.Process.VirtualMemorySize" />
        [Obsolete]
        int VirtualMemorySize { get; }

        /// <inheritdoc cref="System.Diagnostics.Process.WorkingSet" />
        [Obsolete]
        int WorkingSet { get; }

        /// <inheritdoc cref="System.Diagnostics.Process.NonpagedSystemMemorySize64" />
        long NonpagedSystemMemorySize64 { get; }

        /// <inheritdoc cref="System.Diagnostics.Process.PagedMemorySize64" />
        long PagedMemorySize64 { get; }

        /// <inheritdoc cref="System.Diagnostics.Process.PagedSystemMemorySize64" />
        long PagedSystemMemorySize64 { get; }

        /// <inheritdoc cref="System.Diagnostics.Process.PeakPagedMemorySize64" />
        long PeakPagedMemorySize64 { get; }

        /// <inheritdoc cref="System.Diagnostics.Process.PeakVirtualMemorySize64" />
        long PeakVirtualMemorySize64 { get; }

        /// <inheritdoc cref="System.Diagnostics.Process.PeakWorkingSet64" />
        long PeakWorkingSet64 { get; }

        /// <inheritdoc cref="System.Diagnostics.Process.PrivateMemorySize64" />
        long PrivateMemorySize64 { get; }

        /// <inheritdoc cref="System.Diagnostics.Process.VirtualMemorySize64" />
        long VirtualMemorySize64 { get; }

        /// <inheritdoc cref="System.Diagnostics.Process.WorkingSet64" />
        long WorkingSet64 { get; }

        /// <inheritdoc cref="System.Diagnostics.Process.Handle" />
        IntPtr Handle { get; }

        /// <inheritdoc cref="System.Diagnostics.Process.MainWindowHandle" />
        IntPtr MainWindowHandle { get; }

        /// <inheritdoc cref="System.Diagnostics.Process.MaxWorkingSet" />
        IntPtr MaxWorkingSet { get; set; }

        /// <inheritdoc cref="System.Diagnostics.Process.MinWorkingSet" />
        IntPtr MinWorkingSet { get; set; }

        /// <inheritdoc cref="System.Diagnostics.Process.ProcessorAffinity" />
        IntPtr ProcessorAffinity { get; set; }

        /// <inheritdoc cref="System.Diagnostics.Process.SafeHandle" />
        SafeProcessHandle SafeHandle { get; }

        /// <inheritdoc cref="Component.Container" />
        IContainer? Container { get; }

        /// <inheritdoc cref="Component.Site" />
        ISite? Site { get; set; }

        /// <inheritdoc cref="System.Diagnostics.Process.SynchronizingObject" />
        ISynchronizeInvoke? SynchronizingObject { get; set; }

        /// <inheritdoc cref="System.Diagnostics.Process.ExitTime" />
        DateTime ExitTime { get; }

        /// <inheritdoc cref="System.Diagnostics.Process.StartTime" />
        DateTime StartTime { get; }

        /// <inheritdoc cref="System.Diagnostics.Process.ErrorDataReceived" />
        event DataReceivedEventHandler ErrorDataReceived;

        /// <inheritdoc cref="System.Diagnostics.Process.OutputDataReceived" />
        event DataReceivedEventHandler OutputDataReceived;

        /// <inheritdoc cref="System.Diagnostics.Process.MainModule" />
        ProcessModule? MainModule { get; }

        /// <inheritdoc cref="System.Diagnostics.Process.Modules" />
        ProcessModuleCollection Modules { get; }

        /// <inheritdoc cref="System.Diagnostics.Process.PriorityClass" />
        ProcessPriorityClass PriorityClass { get; set; }

        /// <inheritdoc cref="System.Diagnostics.Process.StartInfo" />
        ProcessStartInfo StartInfo { get; set; }

        /// <inheritdoc cref="System.Diagnostics.Process.Threads" />
        ProcessThreadCollection Threads { get; }

#if (NET48 || NET481)
        /// <inheritdoc cref="Component.Disposed" />
        event EventHandler Disposed;
#endif

#if NET8_0_OR_GREATER
        /// <summary>
        /// Disposed event should not be used in NET 8.0 as although IDisposable is
        /// implemented, <code>base.Dispose()</code> is never called which in turn
        /// never fires this event.
        /// <br/><br/><inheritdoc cref="Component.Disposed" />
        /// </summary>
        [Obsolete]
        event EventHandler Disposed;
#endif

        /// <inheritdoc cref="System.Diagnostics.Process.Exited" />
        event EventHandler Exited;

        /// <inheritdoc cref="System.Diagnostics.Process.StandardError" />
        StreamReader StandardError { get; }

        /// <inheritdoc cref="System.Diagnostics.Process.StandardOutput" />
        StreamReader StandardOutput { get; }

        /// <inheritdoc cref="System.Diagnostics.Process.StandardInput" />
        StreamWriter StandardInput { get; }

        /// <inheritdoc cref="System.Diagnostics.Process.MachineName" />
        string MachineName { get; }

        /// <inheritdoc cref="System.Diagnostics.Process.MainWindowTitle" />
        string MainWindowTitle { get; }

        /// <inheritdoc cref="System.Diagnostics.Process.ProcessName" />
        string ProcessName { get; }

        /// <inheritdoc cref="System.Diagnostics.Process.PrivilegedProcessorTime" />
        TimeSpan PrivilegedProcessorTime { get; }

        /// <inheritdoc cref="System.Diagnostics.Process.TotalProcessorTime" />
        TimeSpan TotalProcessorTime { get; }

        /// <inheritdoc cref="System.Diagnostics.Process.UserProcessorTime" />
        TimeSpan UserProcessorTime { get; }

        /// <inheritdoc cref="System.Diagnostics.Process.CloseMainWindow()" />
        bool CloseMainWindow();

        /// <inheritdoc cref="System.Diagnostics.Process.Start()" />
        bool Start();

        /// <inheritdoc cref="System.Diagnostics.Process.WaitForInputIdle()" />
        bool WaitForInputIdle();

        /// <inheritdoc cref="System.Diagnostics.Process.WaitForInputIdle(int)" />
        bool WaitForInputIdle(int milliseconds);

#if NET8_0_OR_GREATER
        /// <inheritdoc cref="System.Diagnostics.Process.WaitForInputIdle(TimeSpan)" />
        bool WaitForInputIdle(TimeSpan timeout);
#endif

        /// <inheritdoc cref="System.Diagnostics.Process.BeginErrorReadLine()" />
        void BeginErrorReadLine();

        /// <inheritdoc cref="System.Diagnostics.Process.BeginOutputReadLine()" />
        void BeginOutputReadLine();

        /// <inheritdoc cref="System.Diagnostics.Process.CancelErrorRead()" />
        void CancelErrorRead();

        /// <inheritdoc cref="System.Diagnostics.Process.CancelOutputRead()" />
        void CancelOutputRead();

        /// <inheritdoc cref="System.Diagnostics.Process.Close()" />
        void Close();

        /// <inheritdoc cref="System.Diagnostics.Process.EnterDebugMode()" />
        void EnterDebugMode();

        /// <inheritdoc cref="System.Diagnostics.Process.Kill()" />
        void Kill();

#if NET8_0_OR_GREATER
        /// <inheritdoc cref="System.Diagnostics.Process.Kill(bool)" />
        void Kill(bool entireProcessTree);
#endif

        /// <inheritdoc cref="System.Diagnostics.Process.LeaveDebugMode()" />
        void LeaveDebugMode();

        /// <inheritdoc cref="System.Diagnostics.Process.Refresh()" />
        void Refresh();

        /// <inheritdoc cref="System.Diagnostics.Process.WaitForExit()" />
        void WaitForExit();

        /// <inheritdoc cref="System.Diagnostics.Process.WaitForExit(int)" />
        bool WaitForExit(int milliseconds);

#if NET8_0_OR_GREATER
        /// <inheritdoc cref="System.Diagnostics.Process.WaitForExit(TimeSpan)" />
        bool WaitForExit(TimeSpan timeout);

        /// <inheritdoc cref="System.Diagnostics.Process.WaitForExitAsync(System.Threading.CancellationToken)" />
        System.Threading.Tasks.Task WaitForExitAsync(System.Threading.CancellationToken cancellationToken = default);
#endif
    }
}
