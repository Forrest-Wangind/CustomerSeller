using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;
namespace SystemSet
{
    public class ShutDown
    {
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        internal struct TokPriv1Luid
        {
            public int Count;
            public long Luid;
            public int Attr;
        }

        [DllImport("kernel32.dll", ExactSpelling = true)]
        internal static extern IntPtr GetCurrentProcess();

        [DllImport("advapi32.dll", ExactSpelling = true, SetLastError = true)]
        internal static extern bool OpenProcessToken(IntPtr h, int acc, ref IntPtr phtok);

        [DllImport("advapi32.dll", SetLastError = true)]
        internal static extern bool LookupPrivilegeValue(string host, string name, ref long pluid);

        [DllImport("advapi32.dll", ExactSpelling = true, SetLastError = true)]
        internal static extern bool AdjustTokenPrivileges(IntPtr htok, bool disall, ref TokPriv1Luid newst, int len, IntPtr prev, IntPtr relen);

        [DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
        internal static extern bool ExitWindowsEx(int flg, int rea);

        internal const int SE_PRIVILEGE_ENABLED = 0x00000002;
        internal const int TOKEN_QUERY = 0x00000008;
        internal const int TOKEN_ADJUST_PRIVILEGES = 0x00000020;
        internal const string SE_SHUTDOWN_NAME = "SeShutdownPrivilege";
        internal const int EWX_LOGOFF = 0x00000000;
        internal const int EWX_SHUTDOWN = 0x00000001;
        internal const int EWX_REBOOT = 0x00000002;
        internal const int EWX_FORCE = 0x00000004;
        internal const int EWX_POWEROFF = 0x00000008;
        internal const int EWX_FORCEIFHUNG = 0x00000010;
        /// <summary>
        /// 关机
        /// </summary>
        /// <param name="flg"></param>
        public static void DoExitWin(int flg)
        {
            bool ok;
            TokPriv1Luid tp;
            IntPtr hproc = GetCurrentProcess();
            IntPtr htok = IntPtr.Zero;
            ok = OpenProcessToken(hproc, TOKEN_ADJUST_PRIVILEGES | TOKEN_QUERY, ref htok);
            tp.Count = 1;
            tp.Luid = 0;
            tp.Attr = SE_PRIVILEGE_ENABLED;
            ok = LookupPrivilegeValue(null, SE_SHUTDOWN_NAME, ref tp.Luid);
            ok = AdjustTokenPrivileges(htok, false, ref tp, 0, IntPtr.Zero, IntPtr.Zero);
            ok = ExitWindowsEx(flg, 0);
        }
        /// <summary>
        /// 关闭应用程序
        /// </summary>
        public static void App_Exit()
        {
            System.Environment.Exit(0);
        }
        /// <summary>
        /// 将子控件加到父控件中
        /// </summary>
        /// <param name="Parent"></param>
        /// <param name="Son"></param>
        public static void Set_Panel_Message(Control Parent,Control Son)
       {
           Parent.Controls.Clear();
           Son.Dock = DockStyle.Fill;
           Parent.Controls.Add(Son);
       }
        /// <summary>
        /// 根据年月日计算星期几(Label2.Text=CaculateWeekDay(2004,12,9);)
        /// </summary>
        /// <param name="y">年</param>
        /// <param name="m">月</param>
        /// <param name="d">日</param>
        /// <returns></returns>
        public static string CaculateWeekDay(int y, int m, int d)
        {
            if (m == 1) m = 13;
            if (m == 2) m = 14;
            int week = (d + 2 * m + 3 * (m + 1) / 5 + y + y / 4 - y / 100 + y / 400) % 7 + 1;
            string weekstr = "";
            switch (week)
            {
                case 1: weekstr = "星期一"; break;
                case 2: weekstr = "星期二"; break;
                case 3: weekstr = "星期三"; break;
                case 4: weekstr = "星期四"; break;
                case 5: weekstr = "星期五"; break;
                case 6: weekstr = "星期六"; break;
                case 7: weekstr = "星期日"; break;
            }

            return weekstr;
        }
    }


}