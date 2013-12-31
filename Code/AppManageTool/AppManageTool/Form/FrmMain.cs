using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppManageTool
{
    public partial class FrmMain : Form
    {
        #region 全局变量

        private static AppInfoService service = new AppInfoService();

        #endregion

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            List<AppInfo> list = service.GetList("");
            if (list.Count > 0)
            {
                dgvInfos.DataSource = list;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnAdd.Show();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            AppInfo model = new AppInfo();
            model.AppName = txtName.Text;
            model.AppParam = txtParam.Text;
            model.AppPath = txtPath.Text;
            model.AppType = (int)(rdbCommand.Checked ? ExcuteType.ExcuteCommand : ExcuteType.ExcuteFile);
            if (service.Add(model))
            {
                ResetInput();
                pnAdd.Hide();
                Init();
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetInput();
            pnAdd.Hide();
        }

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

        private void btnRun_Click(object sender, EventArgs e)
        {
            AppInfo model;
            for (int i = 0; i < dgvInfos.Rows.Count; i++)
            {
                if (dgvInfos.Rows[i].Cells["cb"].Value != null && dgvInfos.Rows[i].Cells["cb"].Value.ToString() == "1")
                {
                    //将行数据转换成实体对象
                    model = dgvInfos.Rows[i].DataBoundItem as AppInfo;
                    if (model.AppType == (int)ExcuteType.ExcuteCommand)
                    {
                        if (!string.IsNullOrEmpty(model.AppPath))
                        {
                            CommandHelper.ExecuteCmd(model.AppPath, 0);
                        }
                    }
                }
            }
        }
    }
}
