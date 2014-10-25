using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace AppManageTool
{
    public class AppInfo
    {
        /// <summary>
        /// 唯一标识
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        public string AppName { get; set; }

        /// <summary>
        /// 应用程序路径或服务命令
        /// </summary>
        public string AppPath { get; set; }

        /// <summary>
        /// 应用参数
        /// </summary>
        public string AppParam { get; set; }

        /// <summary>
        /// 执行类型
        /// </summary>
        public int AppType { get; set; }

        /// <summary>
        /// 排序号
        /// </summary>
        public int AppOrder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int AppNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 是否选中
        /// </summary>
        public int IsChecked { get; set; }

        /// <summary>
        /// 运行状态
        /// </summary>
        public string Status { get; set; }
    }

    /// <summary>
    /// 执行类型枚举
    /// <remarks>
    /// ExcuteCommand:执行命令
    /// ExcuteFile：执行文件
    /// </remarks>
    /// </summary>
    public enum ExcuteType
    {
        ExcuteCommand = 1, ExcuteFile = 2
    }
}
