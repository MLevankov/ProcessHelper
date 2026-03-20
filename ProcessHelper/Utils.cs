// TODO: add function for check critical process

using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;

namespace ProcessHelper
{
    public class Utils
    {
        #region Imports
        [Flags]
        public enum ThreadAccess : int
        {
            TERMINATE = (0x0001),
            SUSPEND_RESUME = (0x0002),
            GET_CONTEXT = (0x0008),
            SET_CONTEXT = (0x0010),
            SET_INFORMATION = (0x0020),
            QUERY_INFORMATION = (0x0040),
            SET_THREAD_TOKEN = (0x0080),
            IMPERSONATE = (0x0100),
            DIRECT_IMPERSONATION = (0x0200)
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr OpenThread(ThreadAccess dwDesiredAccess, bool bInheritHandle, uint dwThreadId);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern uint SuspendThread(IntPtr hThread);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern int ResumeThread(IntPtr hThread);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool CloseHandle(IntPtr handle);

        [DllImport("ntdll.dll", SetLastError = true)]
        private static extern int NtSetInformationProcess(IntPtr handle, int processInformationClass, ref int info, int length);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out UIntPtr lpNumberOfBytesWritten);
        #endregion

        public static List<string> GetProcesses()
        {
            List<string> processes = new List<string>();

            foreach (Process process in Process.GetProcesses())
                processes.Add(process.ProcessName);

            return processes;
        }

        public static void KillProcess(string processName)
        {
            foreach (Process process in Process.GetProcessesByName(processName))
                process.Kill();
        }

        public static void SuspendProcess(string processName)
        {
            foreach (Process process in Process.GetProcessesByName(processName))
            {
                Process process_ = Process.GetProcessById(process.Id);

                foreach (ProcessThread thread in process_.Threads)
                {
                    IntPtr processThread = OpenThread(ThreadAccess.SUSPEND_RESUME, false, (uint)thread.Id);

                    SuspendThread(processThread);

                    CloseHandle(processThread);
                }
            }
        }

        public static void ResumeProcess(string processName)
        {
            foreach (Process process in Process.GetProcessesByName(processName))
            {
                Process process_ = Process.GetProcessById(process.Id);

                foreach (ProcessThread thread in process_.Threads)
                {
                    IntPtr processThread = OpenThread(ThreadAccess.SUSPEND_RESUME, false, (uint)thread.Id);

                    ResumeThread(processThread);

                    CloseHandle(processThread);
                }
            }
        }

        public static int GetPID(string processName)
        {
            int pid = 0;

            foreach (Process process in Process.GetProcessesByName(processName))
            {
                pid = process.Id;
            }

            return pid;
        }

        public static List<string> GetProcessPath(string processName)
        {
            List<string> path = new List<string>();

            try
            {
                foreach (Process process in Process.GetProcessesByName(processName))
                {
                    string pathString = process.MainModule.FileName;
                    if (pathString != null)
                    {
                        path.Add(pathString);
                    }
                }
            }
            catch { }

            return path;
        }

        public static bool IsAdministrator()
        {
            bool status = false;

            using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
            {
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                status = principal.IsInRole(WindowsBuiltInRole.Administrator);
            }

            return status;
        }

        public static void SetCritical(string name, bool isCritical)
        {
            Process.EnterDebugMode();

            foreach (Process process in Process.GetProcessesByName(name))
            {
                IntPtr handle = process.Handle;

                if (isCritical)
                {
                    int critical = 1;
                    NtSetInformationProcess(handle, 0x1D, ref critical, sizeof(int));
                }
                else
                {
                    int critical = 0;
                    NtSetInformationProcess(handle, 0x1D, ref critical, sizeof(int));
                }
            }

            Process.LeaveDebugMode();
        }

        public static void InjectDLL(string processName, string dll)
        {
            foreach (Process process in Process.GetProcessesByName(processName))
            {
                UIntPtr lpNumberOfBytesWritten;
                IntPtr handle = process.Handle;
                IntPtr address = VirtualAllocEx(handle, IntPtr.Zero, (uint)(dll.Length * 2), 0x3000, 0x04);

                WriteProcessMemory(handle, address, Encoding.Unicode.GetBytes(dll), (uint)(dll.Length * 2), out lpNumberOfBytesWritten);
                CreateRemoteThread(handle, IntPtr.Zero, 0, GetProcAddress(GetModuleHandle("kernel32.dll"), "LoadLibraryW"), address, 0, IntPtr.Zero);
            }
        }
    }
}
