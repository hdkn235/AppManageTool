using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace AppManageTool
{
    static class Program
    {
        #region 使用的Win32函数的声明
        /// <summary>
        /// 找到某个窗口与给出的类别名和窗口名相同窗口
        /// 非托管定义为：http://msdn.microsoft.com/en-us/library/windows/desktop/ms633499(v=vs.85).aspx
        /// </summary>
        /// <param name="lpClassName">类别名</param>
        /// <param name="lpWindowName">窗口名</param>
        /// <returns>成功找到返回窗口句柄,否则返回null</returns>
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        /// <summary>
        /// 切换到窗口并把窗口设入前台,类似 SetForegroundWindow方法的功能
        /// </summary>
        /// <param name="hWnd">窗口句柄</param>
        /// <param name="fAltTab">True代表窗口正在通过Alt/Ctrl +Tab被切换</param>
        [DllImport("user32.dll", SetLastError = true)]
        static extern void SwitchToThisWindow(IntPtr hWnd, bool fAltTab);

        /// <summary>
        ///  设置窗口的显示状态
        ///  Win32 函数定义为：http://msdn.microsoft.com/en-us/library/windows/desktop/ms633548(v=vs.85).aspx
        /// </summary>
        /// <param name="hWnd">窗口句柄</param>
        /// <param name="nCmdShow">指示窗口如何被显示</param>
        /// <returns>如果窗体之前是可见，返回值为非零；如果窗体之前被隐藏，返回值为零</returns>
        [DllImport("user32.dll", EntryPoint = "ShowWindow", CharSet = CharSet.Auto)]
        public static extern int ShowWindow(IntPtr hWnd, int nCmdShow);

        public const int SW_RESTORE = 9;
        public static IntPtr formhwnd;
        #endregion

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Process currentProc = Process.GetCurrentProcess();
            Process[] processList = Process.GetProcessesByName(currentProc.ProcessName.Replace(".vshost", string.Empty));
            //该程序已经运行
            if (processList.Length > 1)
            {
                foreach (Process proc in processList)
                {
                    if (proc.Id != currentProc.Id)
                    {
                        // 如果进程的句柄为0，即代表没有找到该窗体，即该窗体隐藏的情况时
                        if (proc.MainWindowHandle == IntPtr.Zero)
                        {
                            // 获得窗体句柄
                            formhwnd = FindWindow(null, "程序启动管理工具");
                            // 重新显示该窗体并切换到带入到前台
                            ShowWindow(formhwnd, SW_RESTORE);
                            SwitchToThisWindow(formhwnd, true);
                        }
                        else
                        {
                            // 如果窗体没有隐藏，就直接切换到该窗体并带入到前台
                            // 因为窗体除了隐藏到托盘，还可以最小化
                            SwitchToThisWindow(proc.MainWindowHandle, true);
                        }
                    }
                }
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FrmMain());
            }
        }
    }
}
