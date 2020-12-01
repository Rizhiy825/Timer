using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Timer
{
    class ActiveWindow
    {
        [DllImport("user32.dll")]
        private static extern IntPtr SetWinEventHook(
              uint eventMin, uint eventMax, IntPtr hmodWinEventProc, WinEventDelegate lpfnWinEventProc,
              uint idProcess, uint idThread, uint dwFlags);

        [DllImport("user32.dll")]
        private static extern bool UnhookWinEvent(IntPtr hWinEventHook);

        /*[DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern int GetWindowTextLength(IntPtr hWnd);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder title, int size);*/
        
        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out uint ProcessId);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        public delegate void WinEventDelegate(
                IntPtr hWinEventHook, uint eventType,
                IntPtr hWnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime);
        public delegate void OnForegroundChanedHandler(string name);

        public event OnForegroundChanedHandler OnForegroundChanged;

        public const uint EVENT_SYSTEM_FOREGROUND = 3;
        public const uint WINEVENT_OUTOFCONTEXT = 0;
        public const uint Event = EVENT_SYSTEM_FOREGROUND;

        readonly IntPtr _hWinEventHook;
        private readonly WinEventDelegate _handler;
        
        public ActiveWindow(OnForegroundChanedHandler handler)
        {
            OnForegroundChanged += handler;
            _handler = Handler;
            _hWinEventHook = SetWinEventHook(Event, Event, IntPtr.Zero, _handler, 0, 0, WINEVENT_OUTOFCONTEXT);
        }

        public void Stop()
        {
            UnhookWinEvent(_hWinEventHook);
        }

        private void Handler(
            IntPtr hWinEventHook,
            uint eventType,
            IntPtr hWnd,
            int idObject,
            int idChild,
            uint dwEventThread,
            uint dwmsEventTime)
        {
            IntPtr hwnd = GetForegroundWindow();
            uint pid;
            GetWindowThreadProcessId(hwnd, out pid);
            Process p = Process.GetProcessById((int)pid);
            string processName = p.ProcessName;
            OnForegroundChanged(processName);
            /*var length = GetWindowTextLength(hWnd);

            var sb = new StringBuilder();
            sb.Length = length + 1;
            GetWindowText(hWnd, sb, length + 1);

            OnForegroundChanged(sb.ToString());
            */

        }

        // Usage Example for EVENT_OBJECT_CREATE (http://msdn.microsoft.com/en-us/library/windows/desktop/dd318066%28v=vs.85%29.aspx)
        // var _objectCreateHook = new EventHook(OnObjectCreate, EventHook.EVENT_OBJECT_CREATE);
        // ...
        // static void OnObjectCreate(IntPtr hWinEventHook, uint eventType, IntPtr hWnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime) {
        //    if (!Win32.GetClassName(hWnd).StartsWith("ClassICareAbout"))
        //        return;
        // Note - in Console program, doesn't fire if you have a Console.ReadLine active, so use a Form
    }

}
