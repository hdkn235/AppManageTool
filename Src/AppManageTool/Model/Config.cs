using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppManageTool.Model
{
    /// <summary>
    /// 配置类
    /// </summary>
    public class Config
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public Config() {
            this.ID = 0;
        }

        /// <summary>
        /// 唯一标识
        /// </summary>
        public int ID { get; set;   }

        /// <summary>
        /// 配置名称
        /// </summary>
        public string ConName { get; set; }

        /// <summary>
        /// 配置值
        /// </summary>
        public string ConValue { get; set; }

        /// <summary>
        /// 配置项的类型
        /// </summary>
        public string ConType { get; set; }
    }
}
