// Prevents unused usings being highlighted.
#pragma warning disable IDE0079
#pragma warning disable IDE0005
// ReSharper disable RedundantUsingDirective

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Agilent.Ace.Testables.Process.Abstractions;
using Microsoft.Win32.SafeHandles;

// Active for remainder of file if not restored
#pragma warning disable CS0618 // Type or member is obsolete

namespace Agilent.Ace.Testables.Process.Wrappers
{
    /// <inheritdoc cref="IProcess" />
    [ExcludeFromCodeCoverage]
    public sealed class ProcessWrapper : IProcess
    {
        private readonly System.Diagnostics.Process _process;

        /// <summary>
        ///     Initializes a new instance of the <see cref="ProcessWrapper" /> class.
        /// </summary>
        /// <param name="process"></param>
        public ProcessWrapper(System.Diagnostics.Process process)
        {
            _process = process;
        }

        /// <inheritdoc />
        public bool EnableRaisingEvents
        {
            get => _process.EnableRaisingEvents;
            set => _process.EnableRaisingEvents = value;
        }

        /// <inheritdoc />
        public bool HasExited => _process.HasExited;

        /// <inheritdoc />
        public bool PriorityBoostEnabled
        {
            get => _process.PriorityBoostEnabled;
            set => _process.PriorityBoostEnabled = value;
        }

        /// <inheritdoc />
        public bool Responding => _process.Responding;

        /// <inheritdoc />
        public int BasePriority => _process.BasePriority;

        /// <inheritdoc />
        public int ExitCode => _process.ExitCode;

        /// <inheritdoc />
        public int HandleCount => _process.HandleCount;

        /// <inheritdoc />
        public int Id => _process.Id;

        /// <inheritdoc />
        public int NonpagedSystemMemorySize => _process.NonpagedSystemMemorySize;

        /// <inheritdoc />
        public int PagedMemorySize => _process.PagedMemorySize;

        /// <inheritdoc />
        public int PagedSystemMemorySize => _process.PagedSystemMemorySize;

        /// <inheritdoc />
        public int PeakPagedMemorySize => _process.PeakPagedMemorySize;

        /// <inheritdoc />
        public int PeakVirtualMemorySize => _process.PeakVirtualMemorySize;

        /// <inheritdoc />
        public int PeakWorkingSet => _process.PeakWorkingSet;

        /// <inheritdoc />
        public int PrivateMemorySize => _process.PrivateMemorySize;

        /// <inheritdoc />
        public int SessionId => _process.SessionId;

        /// <inheritdoc />
        public int VirtualMemorySize => _process.VirtualMemorySize;

        /// <inheritdoc />
        public int WorkingSet => _process.WorkingSet;

        /// <inheritdoc />
        public long NonpagedSystemMemorySize64 => _process.NonpagedSystemMemorySize64;

        /// <inheritdoc />
        public long PagedMemorySize64 => _process.PagedMemorySize64;

        /// <inheritdoc />
        public long PagedSystemMemorySize64 => _process.PagedSystemMemorySize64;

        /// <inheritdoc />
        public long PeakPagedMemorySize64 => _process.PeakPagedMemorySize64;

        /// <inheritdoc />
        public long PeakVirtualMemorySize64 => _process.PeakVirtualMemorySize64;

        /// <inheritdoc />
        public long PeakWorkingSet64 => _process.PeakWorkingSet64;

        /// <inheritdoc />
        public long PrivateMemorySize64 => _process.PrivateMemorySize64;

        /// <inheritdoc />
        public long VirtualMemorySize64 => _process.VirtualMemorySize64;

        /// <inheritdoc />
        public long WorkingSet64 => _process.WorkingSet64;

        /// <inheritdoc />
        public IntPtr Handle => _process.Handle;

        /// <inheritdoc />
        public IntPtr MainWindowHandle => _process.MainWindowHandle;


        /// <inheritdoc />
        public IntPtr MaxWorkingSet
        {
            get => _process.MaxWorkingSet;
            set => _process.MaxWorkingSet = value;
        }

        /// <inheritdoc />
        public IntPtr MinWorkingSet
        {
            get => _process.MinWorkingSet;
            set => _process.MinWorkingSet = value;
        }

        /// <inheritdoc />
        public IntPtr ProcessorAffinity
        {
            get => _process.ProcessorAffinity;
            set => _process.ProcessorAffinity = value;
        }

        /// <inheritdoc />
        public SafeProcessHandle SafeHandle => _process.SafeHandle;

        /// <inheritdoc />
        public IContainer Container => _process.Container;

        /// <inheritdoc />
        public ISite Site
        {
            get => _process.Site;
            set => _process.Site = value;
        }

        /// <inheritdoc />
        public ISynchronizeInvoke SynchronizingObject
        {
            get => _process.SynchronizingObject;
            set => _process.SynchronizingObject = value;
        }

        /// <inheritdoc />
        public DateTime ExitTime => _process.ExitTime;

        /// <inheritdoc />
        public DateTime StartTime => _process.StartTime;

        /// <inheritdoc />
        public event DataReceivedEventHandler ErrorDataReceived
        {
            add => _process.ErrorDataReceived += value;
            remove => _process.ErrorDataReceived -= value;
        }

        /// <inheritdoc />
        public event DataReceivedEventHandler OutputDataReceived
        {
            add => _process.OutputDataReceived += value;
            remove => _process.OutputDataReceived -= value;
        }

        /// <inheritdoc />
        public ProcessModule MainModule => _process.MainModule;

        /// <inheritdoc />
        public ProcessModuleCollection Modules => _process.Modules;

        /// <inheritdoc />
        public ProcessPriorityClass PriorityClass
        {
            get => _process.PriorityClass;
            set => _process.PriorityClass = value;
        }

        /// <inheritdoc />
        public ProcessStartInfo StartInfo
        {
            get => _process.StartInfo;
            set => _process.StartInfo = value;
        }

        /// <inheritdoc />
        public ProcessThreadCollection Threads => _process.Threads;

        /// <inheritdoc />
        public event EventHandler Disposed
        {
            add => _process.Disposed += value;
            remove => _process.Disposed -= value;
        }

        /// <inheritdoc />
        public event EventHandler Exited
        {
            add => _process.Exited += value;
            remove => _process.Exited -= value;
        }

        /// <inheritdoc />
        public StreamReader StandardError => _process.StandardError;

        /// <inheritdoc />
        public StreamReader StandardOutput => _process.StandardOutput;

        /// <inheritdoc />
        public StreamWriter StandardInput => _process.StandardInput;

        /// <inheritdoc />
        public string MachineName => _process.MachineName;

        /// <inheritdoc />
        public string MainWindowTitle => _process.MainWindowTitle;

        /// <inheritdoc />
        public string ProcessName => _process.ProcessName;

        /// <inheritdoc />
        public TimeSpan PrivilegedProcessorTime => _process.PrivilegedProcessorTime;

        /// <inheritdoc />
        public TimeSpan TotalProcessorTime => _process.TotalProcessorTime;

        /// <inheritdoc />
        public TimeSpan UserProcessorTime => _process.UserProcessorTime;

        /// <inheritdoc />
        public bool CloseMainWindow()
        {
            return _process.CloseMainWindow();
        }

        /// <inheritdoc />
        public bool Start()
        {
            return _process.Start();
        }

        /// <inheritdoc />
        public bool WaitForExit(int milliseconds)
        {
            return _process.WaitForExit(milliseconds);
        }

        /// <inheritdoc />
        public void WaitForExit()
        {
            _process.WaitForExit();
        }

#if NET8_0_OR_GREATER
        /// <inheritdoc />
        public bool WaitForExit(TimeSpan timeout)
        {
            return _process.WaitForExit(timeout);
        }
#endif

        /// <inheritdoc />
        public bool WaitForInputIdle()
        {
            return _process.WaitForInputIdle();
        }

        /// <inheritdoc />
        public bool WaitForInputIdle(int milliseconds)
        {
            return _process.WaitForInputIdle();
        }

#if NET8_0_OR_GREATER
        /// <inheritdoc />
        public bool WaitForInputIdle(TimeSpan timeout)
        {
            return _process.WaitForInputIdle(timeout);
        }
#endif

        /// <inheritdoc />
        public void BeginErrorReadLine()
        {
            _process.BeginErrorReadLine();
        }

        /// <inheritdoc />
        public void BeginOutputReadLine()
        {
            _process.BeginOutputReadLine();
        }

        /// <inheritdoc />
        public void CancelErrorRead()
        {
            _process.CancelErrorRead();
        }

        /// <inheritdoc />
        public void CancelOutputRead()
        {
            _process.CancelOutputRead();
        }

        /// <inheritdoc />
        public void Close()
        {
            _process.Close();
        }

        private void On_ProcessDisposed(object sender, EventArgs e)
        {
            Dispose();
        }

        /// <inheritdoc />
        public void Dispose()
        {
            _process.Dispose();
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <inheritdoc />
        public void EnterDebugMode()
        {
            System.Diagnostics.Process.EnterDebugMode();
        }

        /// <inheritdoc />
        public void Kill()
        {
            _process.Kill();
        }

#if NET8_0_OR_GREATER
        /// <inheritdoc />
        public void Kill(bool entireProcessTree)
        {
            _process.Kill(entireProcessTree);
        }
#endif

        /// <inheritdoc />
        public void LeaveDebugMode()
        {
            System.Diagnostics.Process.LeaveDebugMode();
        }

        /// <inheritdoc />
        public void Refresh()
        {
            _process.Refresh();
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                _process?.Dispose();
            }
        }

#if NET8_0_OR_GREATER
        /// <inheritdoc />
        public async Task WaitForExitAsync(CancellationToken cancellationToken = default)
        {
            await _process.WaitForExitAsync(cancellationToken);
        }
#endif
    }
}
