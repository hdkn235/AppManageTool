﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using AppManageTool.Extension;

namespace AppManageTool
{
    public partial class FrmMain : Form
    {
        #region 全局变量

        private AppInfoService service = new AppInfoService();

        private OpaqueCommand cmd = new OpaqueCommand();

        #endregion

        /// <summary>
        /// 窗体初始化
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();

            //不去检查跨线程操作的合法性，可以实现跨线程调用
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            Init();
        }

        /// <summary>
        /// 初始化列表
        /// </summary>
        private void Init()
        {
            List<AppInfo> list = service.GetList("");
            dgvInfos.AutoGenerateColumns = false;
            dgvInfos.DataSource = list;
        }

        /// <summary>
        /// 增加按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnAdd.Show();
        }

        /// <summary>
        /// 确定按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bool result = false;
            AppInfo model = new AppInfo();
            model.AppName = txtName.Text;
            model.AppParam = txtParam.Text;
            model.AppPath = txtPath.Text;
            model.AppType = (int)(rdbCommand.Checked ? ExcuteType.ExcuteCommand : ExcuteType.ExcuteFile);
            if (string.IsNullOrEmpty(txtID.Text))
            {
                result = service.Add(model);
            }
            else
            {
                model.ID = int.Parse(txtID.Text);
                result = service.Update(model);
            }
            if (result)
            {
                ResetInput();
                pnAdd.Hide();
                Init();
            }
            else
            {
                MessageBox.Show("保存失败！");
            }
        }

        /// <summary>
        /// 取消按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetInput();
            pnAdd.Hide();
        }

        /// <summary>
        /// 重置输入框
        /// </summary>
        private void ResetInput()
        {
            foreach (var item in pnAdd.Controls)
            {
                TextBox tb = item as TextBox;
                if (tb != null)
                {
                    tb.Text = "";
                }
            }

            rdbCommand.Checked = true;
        }

        /// <summary>
        /// 运行按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRun_Click(object sender, EventArgs e)
        {
            cmd.ShowOpaqueLayer(groupBox1, 150, true);

            //创建线程对象传入要线程执行的方法
            Thread th = new Thread(RunApp);
            //将线程设置为后台线程（当所有的前台线程结束后，后台线程会自动退出）
            th.IsBackground = true;
            //启动线程 执行方法
            th.Start();

        }

        /// <summary>
        /// 运行选中的程序
        /// </summary>
        private void RunApp()
        {
            AppInfo model;
            for (int i = 0; i < dgvInfos.Rows.Count; i++)
            {
                if (dgvInfos.Rows[i].Cells["cb"].Value != null && dgvInfos.Rows[i].Cells["cb"].Value.ToString() == "1")
                {
                    //将行数据转换成实体对象
                    model = dgvInfos.Rows[i].DataBoundItem as AppInfo;
                    if (!string.IsNullOrEmpty(model.AppPath))
                    {
                        switch (model.AppType)
                        {
                            case 1:
                                CommandHelper.StartCmd(model.AppPath);
                                break;
                            case 2:
                                Process.Start(model.AppPath);
                                break;
                        }
                    }
                }
            }
            GlobalInfo.FrmM.cmd.HideOpaqueLayer();
        }

        /// <summary>
        /// 增加修改页面显示触发的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnAdd_VisibleChanged(object sender, EventArgs e)
        {
            Panel p = sender as Panel;
            if (p.Visible == true)
            {
                cmd.ShowOpaqueLayer(groupBox1, 150, false);
                pnAdd.BringToFront();
            }
            else
            {
                cmd.HideOpaqueLayer();
            }
        }

        /// <summary>
        /// 列表隔行变色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvInfos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (this.dgvInfos.Rows.Count != 0)
            {
                for (int i = 0; i < this.dgvInfos.Rows.Count; )
                {
                    this.dgvInfos.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
                    i += 2;
                }
            }
        }

        /// <summary>
        /// 修改按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModify_Click(object sender, EventArgs e)
        {
            AppInfo model = dgvInfos.SelectedRows[0].DataBoundItem as AppInfo;
            txtName.Text = model.AppName;
            txtParam.Text = model.AppParam;
            txtPath.Text = model.AppPath;
            txtID.Text = model.ID.ToString();
            switch (model.AppType)
            {
                case 1:
                    rdbCommand.Checked = true;
                    break;
                case 2:
                    rdbFile.Checked = true;
                    break;
            }
            pnAdd.Show();
        }

        /// <summary>
        /// 删除按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string idList = string.Empty;
            for (int i = 0; i < dgvInfos.Rows.Count; i++)
            {
                if (dgvInfos.Rows[i].Cells["cb"].Value != null && dgvInfos.Rows[i].Cells["cb"].Value.ToString() == "1")
                {
                    idList += dgvInfos.Rows[i].Cells["id"].Value + ",";
                }
            }

            if (!string.IsNullOrEmpty(idList))
            {
                if (MessageBox.Show("确定要删除选择的应用程序吗？", "提示", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {
                    return;
                }
                if (service.DeleteList(idList.Substring(0, idList.Length - 1)))
                {
                    Init();
                }
            }
        }

        /// <summary>
        /// 全选checkbox事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbAll_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvInfos.Rows.Count; i++)
            {
                dgvInfos.Rows[i].Cells["cb"].Value = cbAll.Checked ? "1" : "0";
            }
        }
    }
}