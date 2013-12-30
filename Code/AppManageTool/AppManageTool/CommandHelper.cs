using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace AppManageTool
{
    public class CommandHelper
    {
        public static string startcmd(string command)
        {
            string output = "";
            try
            {
                Process p = new Process();
                //设置命令
                p.StartInfo.FileName = command;
                //关闭 Shell 的使用！
                p.StartInfo.UseShellExecute = false;
                //重定向标准输入
                p.StartInfo.RedirectStandardInput = true;
                //重定向标准输出
                p.StartInfo.RedirectStandardOutput = true;
                //重定向错误输出
                p.StartInfo.RedirectStandardError = true;
                //设置不显示窗口！
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                //执行dos命令
                p.Start();
                //不过要记得加上Exit要不然下一行程式执行的时候会当机
                p.StandardInput.WriteLine("exit");          
                output = p.StandardOutput.ReadToEnd();
                p.WaitForExit();
                p.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return output;
        }

        public static string startcmd(string command, string argument)
        {
            string output = "";
            try
            {
                Process p = new Process();

                p.StartInfo.FileName = command;
                p.StartInfo.Arguments = "/C " + argument;

                p.StartInfo.UseShellExecute = false;

                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.RedirectStandardOutput = true;

                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

                p.Start();
                p.StandardInput.WriteLine("exit");   
                output = p.StandardOutput.ReadToEnd();
                p.WaitForExit();
                p.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return output;
        }
    }
}
