﻿namespace AppManageTool
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.dgvInfos = new System.Windows.Forms.DataGridView();
            this.cb = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppParam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConfig = new System.Windows.Forms.Button();
            this.pnHide = new System.Windows.Forms.Panel();
            this.btnDencrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.txtEncryptStr = new System.Windows.Forms.TextBox();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.cbAll = new System.Windows.Forms.CheckBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnAdd = new System.Windows.Forms.Panel();
            this.picBrowser = new System.Windows.Forms.PictureBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.rdbFile = new System.Windows.Forms.RadioButton();
            this.rdbCommand = new System.Windows.Forms.RadioButton();
            this.txtParam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.ContextMSTable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolMenuStart = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuModify = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.NIMin = new System.Windows.Forms.NotifyIcon(this.components);
            this.ContextMSNI = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolMenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.TimerCheckStatus = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnHide.SuspendLayout();
            this.pnAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBrowser)).BeginInit();
            this.ContextMSTable.SuspendLayout();
            this.ContextMSNI.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInfos
            // 
            this.dgvInfos.AllowDrop = true;
            this.dgvInfos.AllowUserToAddRows = false;
            this.dgvInfos.AllowUserToDeleteRows = false;
            this.dgvInfos.AllowUserToResizeRows = false;
            this.dgvInfos.BackgroundColor = System.Drawing.Color.White;
            this.dgvInfos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInfos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInfos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cb,
            this.id,
            this.AppNum,
            this.AppName,
            this.AppPath,
            this.AppParam,
            this.Status,
            this.Type,
            this.AppType});
            this.dgvInfos.Location = new System.Drawing.Point(3, 17);
            this.dgvInfos.MultiSelect = false;
            this.dgvInfos.Name = "dgvInfos";
            this.dgvInfos.RowHeadersVisible = false;
            this.dgvInfos.RowTemplate.Height = 23;
            this.dgvInfos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInfos.Size = new System.Drawing.Size(689, 465);
            this.dgvInfos.TabIndex = 1;
            this.dgvInfos.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvInfos_CellMouseDown);
            this.dgvInfos.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvInfos_DataBindingComplete);
            this.dgvInfos.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvInfos_DragDrop);
            this.dgvInfos.DragEnter += new System.Windows.Forms.DragEventHandler(this.dgvInfos_DragEnter);
            this.dgvInfos.DoubleClick += new System.EventHandler(this.btnModify_Click);
            // 
            // cb
            // 
            this.cb.DataPropertyName = "IsChecked";
            this.cb.FalseValue = "0";
            this.cb.HeaderText = "";
            this.cb.Name = "cb";
            this.cb.TrueValue = "1";
            this.cb.Width = 30;
            // 
            // id
            // 
            this.id.DataPropertyName = "ID";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 50;
            // 
            // AppNum
            // 
            this.AppNum.DataPropertyName = "AppNum";
            this.AppNum.HeaderText = "序号";
            this.AppNum.Name = "AppNum";
            this.AppNum.Width = 40;
            // 
            // AppName
            // 
            this.AppName.DataPropertyName = "AppName";
            this.AppName.HeaderText = "应用名称";
            this.AppName.Name = "AppName";
            this.AppName.ReadOnly = true;
            this.AppName.Width = 150;
            // 
            // AppPath
            // 
            this.AppPath.DataPropertyName = "AppPath";
            this.AppPath.HeaderText = "执行程序";
            this.AppPath.Name = "AppPath";
            this.AppPath.ReadOnly = true;
            this.AppPath.Width = 180;
            // 
            // AppParam
            // 
            this.AppParam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AppParam.DataPropertyName = "AppParam";
            this.AppParam.HeaderText = "参数";
            this.AppParam.Name = "AppParam";
            this.AppParam.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "状态";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 80;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "执行类型";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // AppType
            // 
            this.AppType.DataPropertyName = "AppType";
            this.AppType.HeaderText = "AppType";
            this.AppType.Name = "AppType";
            this.AppType.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btnConfig);
            this.groupBox1.Controls.Add(this.pnHide);
            this.groupBox1.Controls.Add(this.btnMoveDown);
            this.groupBox1.Controls.Add(this.btnMoveUp);
            this.groupBox1.Controls.Add(this.cbAll);
            this.groupBox1.Controls.Add(this.btnModify);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.pnAdd);
            this.groupBox1.Controls.Add(this.btnRun);
            this.groupBox1.Controls.Add(this.dgvInfos);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(802, 485);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnConfig
            // 
            this.btnConfig.Location = new System.Drawing.Point(713, 402);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(75, 23);
            this.btnConfig.TabIndex = 14;
            this.btnConfig.Text = "设置";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // pnHide
            // 
            this.pnHide.Controls.Add(this.btnDencrypt);
            this.pnHide.Controls.Add(this.btnEncrypt);
            this.pnHide.Controls.Add(this.txtEncryptStr);
            this.pnHide.Location = new System.Drawing.Point(3, 343);
            this.pnHide.Name = "pnHide";
            this.pnHide.Size = new System.Drawing.Size(209, 139);
            this.pnHide.TabIndex = 13;
            this.pnHide.Visible = false;
            // 
            // btnDencrypt
            // 
            this.btnDencrypt.Location = new System.Drawing.Point(69, 56);
            this.btnDencrypt.Name = "btnDencrypt";
            this.btnDencrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDencrypt.TabIndex = 12;
            this.btnDencrypt.Text = "解密";
            this.btnDencrypt.UseVisualStyleBackColor = true;
            this.btnDencrypt.Click += new System.EventHandler(this.btnDencrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(69, 17);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 10;
            this.btnEncrypt.Text = "加密";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // txtEncryptStr
            // 
            this.txtEncryptStr.Location = new System.Drawing.Point(19, 94);
            this.txtEncryptStr.Name = "txtEncryptStr";
            this.txtEncryptStr.Size = new System.Drawing.Size(172, 21);
            this.txtEncryptStr.TabIndex = 11;
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Location = new System.Drawing.Point(713, 207);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(75, 23);
            this.btnMoveDown.TabIndex = 9;
            this.btnMoveDown.Text = "下移";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Location = new System.Drawing.Point(713, 160);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(75, 23);
            this.btnMoveUp.TabIndex = 8;
            this.btnMoveUp.Text = "上移";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // cbAll
            // 
            this.cbAll.AutoSize = true;
            this.cbAll.Location = new System.Drawing.Point(12, 28);
            this.cbAll.Name = "cbAll";
            this.cbAll.Size = new System.Drawing.Size(15, 14);
            this.cbAll.TabIndex = 7;
            this.cbAll.UseVisualStyleBackColor = true;
            this.cbAll.CheckedChanged += new System.EventHandler(this.cbAll_CheckedChanged);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(713, 66);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 6;
            this.btnModify.Text = "修改";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(713, 113);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pnAdd
            // 
            this.pnAdd.BackColor = System.Drawing.Color.Azure;
            this.pnAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnAdd.Controls.Add(this.picBrowser);
            this.pnAdd.Controls.Add(this.txtID);
            this.pnAdd.Controls.Add(this.rdbFile);
            this.pnAdd.Controls.Add(this.rdbCommand);
            this.pnAdd.Controls.Add(this.txtParam);
            this.pnAdd.Controls.Add(this.label3);
            this.pnAdd.Controls.Add(this.txtPath);
            this.pnAdd.Controls.Add(this.label2);
            this.pnAdd.Controls.Add(this.btnCancel);
            this.pnAdd.Controls.Add(this.btnConfirm);
            this.pnAdd.Controls.Add(this.txtName);
            this.pnAdd.Controls.Add(this.label1);
            this.pnAdd.Location = new System.Drawing.Point(224, 131);
            this.pnAdd.Name = "pnAdd";
            this.pnAdd.Size = new System.Drawing.Size(354, 222);
            this.pnAdd.TabIndex = 3;
            this.pnAdd.Visible = false;
            this.pnAdd.VisibleChanged += new System.EventHandler(this.pnAdd_VisibleChanged);
            // 
            // picBrowser
            // 
            this.picBrowser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBrowser.Image = global::AppManageTool.Properties.Resources.png_0087;
            this.picBrowser.Location = new System.Drawing.Point(318, 62);
            this.picBrowser.Name = "picBrowser";
            this.picBrowser.Size = new System.Drawing.Size(20, 20);
            this.picBrowser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBrowser.TabIndex = 13;
            this.picBrowser.TabStop = false;
            this.picBrowser.Click += new System.EventHandler(this.picBrowser_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(162, 176);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(29, 21);
            this.txtID.TabIndex = 12;
            this.txtID.Visible = false;
            // 
            // rdbFile
            // 
            this.rdbFile.AutoSize = true;
            this.rdbFile.Location = new System.Drawing.Point(191, 142);
            this.rdbFile.Name = "rdbFile";
            this.rdbFile.Size = new System.Drawing.Size(71, 16);
            this.rdbFile.TabIndex = 11;
            this.rdbFile.Text = "执行文件";
            this.rdbFile.UseVisualStyleBackColor = true;
            // 
            // rdbCommand
            // 
            this.rdbCommand.AutoSize = true;
            this.rdbCommand.Checked = true;
            this.rdbCommand.Location = new System.Drawing.Point(90, 142);
            this.rdbCommand.Name = "rdbCommand";
            this.rdbCommand.Size = new System.Drawing.Size(71, 16);
            this.rdbCommand.TabIndex = 10;
            this.rdbCommand.TabStop = true;
            this.rdbCommand.Text = "执行脚本";
            this.rdbCommand.UseVisualStyleBackColor = true;
            // 
            // txtParam
            // 
            this.txtParam.Location = new System.Drawing.Point(121, 101);
            this.txtParam.Name = "txtParam";
            this.txtParam.Size = new System.Drawing.Size(191, 21);
            this.txtParam.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "命令参数：";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(121, 62);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(191, 21);
            this.txtPath.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "执行命令：";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(208, 174);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(70, 174);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(121, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(191, 21);
            this.txtName.TabIndex = 1;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "应用名称：";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(713, 450);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "运行应用";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(713, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ContextMSTable
            // 
            this.ContextMSTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenuStart,
            this.toolMenuModify,
            this.toolMenuDelete});
            this.ContextMSTable.Name = "ContextMSTable";
            this.ContextMSTable.Size = new System.Drawing.Size(101, 70);
            // 
            // toolMenuStart
            // 
            this.toolMenuStart.Name = "toolMenuStart";
            this.toolMenuStart.Size = new System.Drawing.Size(100, 22);
            this.toolMenuStart.Text = "启动";
            this.toolMenuStart.Click += new System.EventHandler(this.toolMenuStart_Click);
            // 
            // toolMenuModify
            // 
            this.toolMenuModify.Name = "toolMenuModify";
            this.toolMenuModify.Size = new System.Drawing.Size(100, 22);
            this.toolMenuModify.Text = "修改";
            this.toolMenuModify.Click += new System.EventHandler(this.toolMenuModify_Click);
            // 
            // toolMenuDelete
            // 
            this.toolMenuDelete.Name = "toolMenuDelete";
            this.toolMenuDelete.Size = new System.Drawing.Size(100, 22);
            this.toolMenuDelete.Text = "删除";
            this.toolMenuDelete.Click += new System.EventHandler(this.toolMenuDelete_Click);
            // 
            // NIMin
            // 
            this.NIMin.ContextMenuStrip = this.ContextMSNI;
            this.NIMin.Icon = ((System.Drawing.Icon)(resources.GetObject("NIMin.Icon")));
            this.NIMin.Text = "应用程序管理";
            this.NIMin.Visible = true;
            this.NIMin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NIMin_MouseClick);
            // 
            // ContextMSNI
            // 
            this.ContextMSNI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenuOpen,
            this.toolMenuExit});
            this.ContextMSNI.Name = "ContextMSNI";
            this.ContextMSNI.Size = new System.Drawing.Size(101, 48);
            // 
            // toolMenuOpen
            // 
            this.toolMenuOpen.Name = "toolMenuOpen";
            this.toolMenuOpen.Size = new System.Drawing.Size(100, 22);
            this.toolMenuOpen.Text = "打开";
            this.toolMenuOpen.Click += new System.EventHandler(this.toolMenuOpen_Click);
            // 
            // toolMenuExit
            // 
            this.toolMenuExit.Name = "toolMenuExit";
            this.toolMenuExit.Size = new System.Drawing.Size(100, 22);
            this.toolMenuExit.Text = "退出";
            this.toolMenuExit.Click += new System.EventHandler(this.toolMenuExit_Click);
            // 
            // TimerCheckStatus
            // 
            this.TimerCheckStatus.Enabled = true;
            this.TimerCheckStatus.Interval = 1000;
            this.TimerCheckStatus.Tick += new System.EventHandler(this.TimerCheckStatus_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 485);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "程序启动管理工具";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            this.SizeChanged += new System.EventHandler(this.FrmMain_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnHide.ResumeLayout(false);
            this.pnHide.PerformLayout();
            this.pnAdd.ResumeLayout(false);
            this.pnAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBrowser)).EndInit();
            this.ContextMSTable.ResumeLayout(false);
            this.ContextMSNI.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInfos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnAdd;
        private System.Windows.Forms.RadioButton rdbFile;
        private System.Windows.Forms.RadioButton rdbCommand;
        private System.Windows.Forms.TextBox txtParam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.CheckBox cbAll;
        private System.Windows.Forms.PictureBox picBrowser;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox txtEncryptStr;
        private System.Windows.Forms.Button btnDencrypt;
        private System.Windows.Forms.Panel pnHide;
        private System.Windows.Forms.ContextMenuStrip ContextMSTable;
        private System.Windows.Forms.ToolStripMenuItem toolMenuStart;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.ToolStripMenuItem toolMenuDelete;
        private System.Windows.Forms.ToolStripMenuItem toolMenuModify;
        private System.Windows.Forms.NotifyIcon NIMin;
        private System.Windows.Forms.ContextMenuStrip ContextMSNI;
        private System.Windows.Forms.ToolStripMenuItem toolMenuOpen;
        private System.Windows.Forms.ToolStripMenuItem toolMenuExit;
        private System.Windows.Forms.Timer TimerCheckStatus;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cb;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppParam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppType;
    }
}

