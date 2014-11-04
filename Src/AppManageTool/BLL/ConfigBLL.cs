using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppManageTool.DAL;
using AppManageTool.Model;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Threading;
using AppManageTool.Helper;

namespace AppManageTool.BLL
{
    public class ConfigBLL
    {
        private static ConfigBLL instance = null;
        private static readonly object syncRoot = new object();
        private static ConfigDAL dal = new ConfigDAL();

        private ConfigBLL()
        {

        }

        public static ConfigBLL GetInstance()
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new ConfigBLL();
                    }
                }
            }
            return instance;
        }

        #region 设置开机自启动
        /// <summary>
        /// 设置开机自启动
        /// </summary>
        public void AutoStart()
        {
            RegisterHelper register = new RegisterHelper("SOFTWARE");
            string key = @"Microsoft\Windows\CurrentVersion\Run";
            string name = "AppManageTool";
            if (IsEnableConfig("AutoStart"))
            {
                //取得程序路径
                string startup = Application.ExecutablePath;
                register.SetValue(
                    RegisterHelper.KeyType.HKEY_LOCAL_MACHINE, key, name, startup);
            }
            else
            {
                register.DeleteValue(
                    RegisterHelper.KeyType.HKEY_LOCAL_MACHINE, key, name);
            }
        } 
        #endregion

        #region 窗体最小化
        /// <summary>
        /// 设置窗体启动后最小化
        /// </summary>
        public void AutoMinAfterStart(Form form)
        {
            SetFormMin(form, "AfterStartAutoMin");
        }

        /// <summary>
        /// 设置运行应用后最小化
        /// </summary>
        public void AutoMinAfterRunApp(Form form)
        {
            SetFormMin(form, "AfterRunAppAutoMin");
        }

        private void SetFormMin(Form form, string name)
        {
            if (IsEnableConfig(name))
            {
                form.WindowState = FormWindowState.Minimized;
            }
        } 
        #endregion

        #region 程序启动后运行APP
        /// <summary>
        /// 程序启动后运行APP
        /// </summary>
        /// <param name="action">方法</param>
        /// <param name="thread">参数</param>
        public void RunAppAfterStart(Action<ThreadStart> action, ThreadStart thread)
        {
            if (IsEnableConfig("AfterStartRunApp"))
            {
                action(thread);
            }
        } 
        #endregion

        #region 公有方法
        private bool IsEnableConfig(string name)
        {
            bool result = false;
            Config config = dal.GetByConName(name);
            if (config != null && Convert.ToBoolean(config.ConValue))
            {
                result = true;
            }
            return result;
        } 
        #endregion
    }
}
