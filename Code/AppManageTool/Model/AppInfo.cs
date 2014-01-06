using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace AppManageTool
{
    public class AppInfo
    {
        public int ID { get; set; }

        public string AppName { get; set; }

        public string AppPath { get; set; }

        public string AppParam { get; set; }

        public int AppType { get; set; }

        public int AppOrder { get; set; }

        public int AppNum { get; set; }

        public string Type { get; set; }

        public int IsChecked { get; set; }
    }

    public enum ExcuteType
    {
        ExcuteCommand = 1, ExcuteFile = 2
    }
}
