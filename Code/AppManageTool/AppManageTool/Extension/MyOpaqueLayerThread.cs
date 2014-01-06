using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppManageTool.Extension
{
    public class MyOpaqueLayerThread
    {
        private OpaqueCommand cmd = new OpaqueCommand();

        public Control MyControl { get; set; }

        public int Alpha { get; set; }

        public bool IsShowLoadingImage { get; set; }

        private delegate void MyFunc();

        public void ShowOpaqueLayer()
        {
            if (MyControl.InvokeRequired)
            {
                MyFunc f = ShowOpaqueLayer;
                MyControl.Invoke(f, null);
            }
            else
            {
                cmd.ShowOpaqueLayer(MyControl, Alpha, IsShowLoadingImage);
            }
        }

        public void HideOpaqueLayer()
        {
            cmd.HideOpaqueLayer();
        }
    }
}
