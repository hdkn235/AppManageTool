using System;
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
using System.IO;
using AppManageTool.DBUtility;
using AppManageTool.Common;

namespace AppManageTool
{
    public partial class FrmMain : Form
    {
        #region 全局变量

        private AppInfoService service = new AppInfoService();

        private OpaqueCommand cmd = new OpaqueCommand();

        private static bool startFlag = false;

        #endregion

        #region 初始化

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
            InitData();
        }

        /// <summary>
        /// 初始化列表
        /// </summary>
        private void InitData()
        {
            List<AppInfo> list = service.GetList("");
            dgvInfos.AutoGenerateColumns = false;
            dgvInfos.DataSource = list;
        }

        #endregion

        #region 事件

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
                InitData();
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
        /// 运行按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRun_Click(object sender, EventArgs e)
        {
            RunThread(() => RunSelectedApp());
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
                startFlag = true;
            }
            else
            {
                cmd.HideOpaqueLayer();
                startFlag = false;
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
            ShowModify(model);
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
                if (dgvInfos.Rows[i].Cells["cb"].Value != null &&
                    dgvInfos.Rows[i].Cells["cb"].Value.ToString() == "1")
                {
                    idList += dgvInfos.Rows[i].Cells["id"].Value + ",";
                }
            }

            if (!string.IsNullOrEmpty(idList))
            {
                if (MessageBox.Show(
                    "确定要删除选择的应用程序吗？",
                    "提示",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) == DialogResult.Cancel)
                {
                    return;
                }
                if (service.DeleteList(idList.Substring(0, idList.Length - 1)))
                {
                    InitData();
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

        /// <summary>
        /// 选择文件按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "所有文件|*.*";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtName.Text = Path.GetFileNameWithoutExtension(ofd.SafeFileName);
                txtPath.Text = ofd.FileName;
                rdbFile.Checked = true;
            }
        }

        /// <summary>
        /// 上移按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            Sort(false);
        }

        /// <summary>
        /// 鼠标拖拽到列表上时发生的事件 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvInfos_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        /// <summary>
        /// 鼠标拖拽到列表上完成时发生的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvInfos_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileInfo = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            for (int i = 0; i < fileInfo.Length; i++)
            {
                AppInfo model = new AppInfo();
                model.AppName = Path.GetFileNameWithoutExtension(fileInfo[i]);
                model.AppPath = fileInfo[i];
                model.AppType = (int)ExcuteType.ExcuteFile;
                model.AppParam = "";
                if (!service.Add(model))
                {
                    MessageBox.Show("保存失败！");
                    return;
                }
            }
            InitData();
        }

        /// <summary>
        /// 列表右键点击弹出菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvInfos_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    dgvInfos.ClearSelection();
                    dgvInfos.Rows[e.RowIndex].Selected = true;
                    dgvInfos.CurrentCell = dgvInfos.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    this.ContextMSTable.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }

        /// <summary>
        /// 最小化到托盘
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.NIMin.Visible = true;
            }
        }

        /// <summary>
        /// 托盘鼠标点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NIMin_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                toolMenuOpen_Click(sender, e);
            }
        }

        /// <summary>
        /// 定时器事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerCheckStatus_Tick(object sender, EventArgs e)
        {
            if (startFlag)
            {
                return;
            }
            List<AppInfo> list = this.dgvInfos.DataSource as List<AppInfo>;
            if (list != null && list.Count > 0)
            {
                bool isStart = false;
                string name = string.Empty;
                foreach (AppInfo info in list)
                {
                    if (info.AppType == (int)ExcuteType.ExcuteCommand)
                    {
                        name = info.AppPath.Substring(info.AppPath.LastIndexOf(' ') + 1);
                        isStart = SystemHelper.CheckServiceStatus(name);
                        if (isStart)
                        {
                            info.Status = "正在运行";
                        }
                        else
                        {
                            info.Status = string.Empty;
                        }
                    }
                    else if (info.AppType == (int)ExcuteType.ExcuteFile)
                    {
                        name = Path.GetFileNameWithoutExtension(info.AppPath);
                        isStart = SystemHelper.CheckAppStatus(name);
                        if (isStart)
                        {
                            info.Status = "正在运行";
                        }
                        else
                        {
                            info.Status = string.Empty;
                        }
                    }
                }
            }
            this.dgvInfos.Refresh();
        }

        #endregion

        #region 右键菜单事件

        /// <summary>
        /// 右键修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolMenuModify_Click(object sender, EventArgs e)
        {
            AppInfo model = dgvInfos.Rows[dgvInfos.CurrentCell.RowIndex]
                .DataBoundItem as AppInfo;
            ShowModify(model);
        }

        /// <summary>
        /// 列表右键启动点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolMenuStart_Click(object sender, EventArgs e)
        {
            AppInfo model = dgvInfos.Rows[dgvInfos.CurrentCell.RowIndex]
                .DataBoundItem as AppInfo;

            RunThread(() => RunSingleApp(model));
        }

        /// <summary>
        /// 右键删除按钮功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolMenuDelete_Click(object sender, EventArgs e)
        {
            AppInfo model = dgvInfos.Rows[dgvInfos.CurrentCell.RowIndex]
                .DataBoundItem as AppInfo;

            if (MessageBox.Show(
                "确定要删除 " + model.AppName + " 应用程序吗？",
                "提示",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            }
            if (service.Delete(model))
            {
                InitData();
            }
        }

        /// <summary>
        /// 托盘右键打开
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolMenuOpen_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            NIMin.Visible = false;
        }

        /// <summary>
        /// 托盘右键退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolMenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region 私有方法

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
        /// 开启线程  并加载运行方法
        /// </summary>
        /// <param name="threadStart"></param>
        private void RunThread(ThreadStart threadStart)
        {
            cmd.ShowOpaqueLayer(groupBox1, 150, true);

            //创建线程对象传入要线程执行的方法
            Thread th = new Thread(threadStart);
            //将线程设置为后台线程（当所有的前台线程结束后，后台线程会自动退出）
            th.IsBackground = true;
            //启动线程 执行方法
            th.Start();
        }

        /// <summary>
        /// 运行选中的程序
        /// </summary>
        private void RunSelectedApp()
        {
            AppInfo model;
            for (int i = 0; i < dgvInfos.Rows.Count; i++)
            {
                //将行数据转换成实体对象
                model = dgvInfos.Rows[i].DataBoundItem as AppInfo;
                if (dgvInfos.Rows[i].Cells["cb"].Value != null && dgvInfos.Rows[i].Cells["cb"].Value.ToString() == "1")
                {
                    LaunchApp(model);
                }
                service.UpdateChecked(model);
            }
            cmd.HideOpaqueLayer();
            startFlag = false;
        }

        /// <summary>
        /// 运行单个的程序
        /// </summary>
        private void RunSingleApp(AppInfo model)
        {
            LaunchApp(model);
            cmd.HideOpaqueLayer();
            startFlag = false;
        }

        /// <summary>
        /// 启动应用
        /// </summary>
        /// <param name="model">应用的数据模型</param>
        private static void LaunchApp(AppInfo model)
        {
            startFlag = true;
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

        /// <summary>
        /// 排序
        /// </summary>
        /// <param name="sortType">上移为false 下移为true</param>
        private void Sort(bool sortType)
        {
            int index = dgvInfos.CurrentCell.RowIndex;
            if ((!sortType && index == 0) || (sortType && index == dgvInfos.Rows.Count - 1)) return;
            if (sortType)
            {
                index++;
            }
            else
            {
                index--;
            }
            AppInfo modelNow = dgvInfos.SelectedRows[0].DataBoundItem as AppInfo;
            AppInfo modelMove = dgvInfos.Rows[index].DataBoundItem as AppInfo;

            int tempOrder = modelNow.AppOrder;
            modelNow.AppOrder = modelMove.AppOrder;
            modelMove.AppOrder = tempOrder;

            if (service.UpdateOrder(modelNow) && service.UpdateOrder(modelMove))
            {
                InitData();
                dgvInfos.CurrentCell = dgvInfos.Rows[index].Cells[0];
            }
        }

        /// <summary>
        /// 加载修改的页面
        /// </summary>
        /// <param name="model"></param>
        private void ShowModify(AppInfo model)
        {
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

        #endregion

        #region 后门程序

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            Sort(true);
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DESEncrypt.Encrypt(txtEncryptStr.Text));
        }

        private void btnDencrypt_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DESEncrypt.Decrypt(txtEncryptStr.Text));
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtName.Text == "whoisyourdaddy")
            {
                pnHide.Show();
                pnHide.BringToFront();
            }
        }

        #endregion

    }
}
