using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceProcess;
using System.Diagnostics;

namespace AppManageTool.Helper
{
    /// <summary>
    /// 系统帮助类
    /// </summary>
    public class SystemHelper
    {
        /// <summary>
        /// 检查服务启动状态
        /// </summary>
        /// <param name="serviceName">服务名称</param>
        /// <returns>启动为true</returns>
        public static bool CheckServiceStatus(string serviceName)
        {
            ServiceController[] service = ServiceController.GetServices();
            bool isStart = false;
            for (int i = 0; i < service.Length; i++)
            {
                if (service[i].ServiceName.Equals(
                    serviceName,
                    StringComparison.CurrentCultureIgnoreCase))
                {
                    if (service[i].Status == ServiceControllerStatus.Running)
                    {
                        isStart = true;
                        break;
                    }
                }
            }
            return isStart;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="appName"></param>
        /// <returns></returns>
        public static bool CheckAppStatus(string appName)
        {
            bool isStart = false;
            foreach (Process p in Process.GetProcesses())
            {
                if (p.ProcessName.IndexOf(
                    appName,
                    StringComparison.CurrentCultureIgnoreCase) > -1)
                {
                    isStart = true;
                    break;
                }
            }
            return isStart;
        }
    }
}
