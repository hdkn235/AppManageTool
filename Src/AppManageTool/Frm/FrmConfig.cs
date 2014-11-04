using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AppManageTool.Model;
using AppManageTool.DAL;
using System.Diagnostics;
using AppManageTool.Helper;
using AppManageTool.BLL;

namespace AppManageTool
{
    public partial class FrmConfig : Form
    {
        #region 属性
        /// <summary>
        /// 控件字典
        /// </summary>
        private Dictionary<string, Control> dicControl;

        private Dictionary<string, Control> DicControl
        {
            get
            {
                if (dicControl == null)
                {
                    dicControl = new Dictionary<string, Control>();
                    foreach (Control control in this.ControlList)
                    {
                        if (control.Tag != null)
                        {
                            string name = control.Tag.ToString();
                            dicControl.Add(name, control);
                        }
                    }
                }
                return dicControl;
            }
        }

        private ConfigDAL dal = new ConfigDAL();

        /// <summary>
        /// 窗体所有控件集合
        /// </summary>
        private List<Control> ControlList
        {
            get
            {
                List<Control> controlList = new List<Control>();
                this.GetControls(this.Controls, controlList);
                return controlList;
            }
        }

        /// <summary>
        /// 递归获取所有控件
        /// </summary>
        private void GetControls(Control.ControlCollection controls, List<Control> controlList)
        {
            foreach (Control control in controls)
            {
                controlList.Add(control);
                if (control.HasChildren)
                {
                    GetControls(control.Controls, controlList);
                }
            }
        }
        #endregion

        #region 构造函数
        public FrmConfig()
        {
            InitializeComponent();
        }
        #endregion

        #region 窗体启动
        /// <summary>
        /// 加载配置信息
        /// </summary>
        private void LoadData()
        {
            List<Config> configs = dal.GetList("");
            foreach (Config config in configs)
            {
                if (DicControl.ContainsKey(config.ConName))
                {
                    Control c = DicControl[config.ConName];
                    if (c.GetType() == typeof(CheckBox))
                    {
                        CheckBox cb = c as CheckBox;
                        cb.Checked = Convert.ToBoolean(config.ConValue);
                        cb.Tag = config;
                    }
                }
            }
        }

        /// <summary>
        /// 窗体load事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmConfig_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        #endregion

        #region 按钮事件
        /// <summary>
        /// 取消按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        /// <summary>
        /// 保存按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveConfig();
            this.SetAutoStart();
            this.Close();
            this.Dispose();
        }

        /// <summary>
        /// 保存配置信息
        /// </summary>
        private void SaveConfig()
        {
            List<Config> list = new List<Config>();
            Config config;
            foreach (Control control in this.ControlList)
            {
                if (control.Tag != null)
                {
                    if (control.Tag is Config)
                    {
                        config = control.Tag as Config;
                    }
                    else
                    {
                        config = new Config();
                        config.ConName = control.Tag.ToString();
                        config.ConType = control.GetType().Name;
                    }
                    config.ConValue = GetConValue(control);
                    list.Add(config);
                }
            }
            dal.BatchUpdate(list);
        }

        private string GetConValue(Control control)
        {
            string conValue = string.Empty;
            if (control.GetType() == typeof(CheckBox))
            {
                CheckBox cb = control as CheckBox;
                conValue = cb.Checked.ToString();
            }
            return conValue;
        }
        #endregion

        #region 设置开机启动

        /// <summary>
        /// 设置开机启动
        /// </summary>
        private void SetAutoStart()
        {
            ConfigBLL helper = ConfigBLL.GetInstance();
            helper.AutoStart();
        }

        #endregion

    }
}
