namespace AppManageTool
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
            this.dgvInfos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnAdd = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtParam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbCommand = new System.Windows.Forms.RadioButton();
            this.rdbFile = new System.Windows.Forms.RadioButton();
            this.btnRun = new System.Windows.Forms.Button();
            this.cb = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppParam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInfos
            // 
            this.dgvInfos.AllowUserToAddRows = false;
            this.dgvInfos.AllowUserToDeleteRows = false;
            this.dgvInfos.AllowUserToResizeRows = false;
            this.dgvInfos.BackgroundColor = System.Drawing.Color.White;
            this.dgvInfos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvInfos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cb,
            this.id,
            this.AppOrder,
            this.AppName,
            this.AppPath,
            this.AppParam,
            this.AppType});
            this.dgvInfos.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvInfos.Location = new System.Drawing.Point(3, 17);
            this.dgvInfos.MultiSelect = false;
            this.dgvInfos.Name = "dgvInfos";
            this.dgvInfos.RowHeadersVisible = false;
            this.dgvInfos.RowTemplate.Height = 23;
            this.dgvInfos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInfos.Size = new System.Drawing.Size(689, 465);
            this.dgvInfos.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRun);
            this.groupBox1.Controls.Add(this.pnAdd);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.dgvInfos);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(802, 485);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "应用管理";
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
            // pnAdd
            // 
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
            this.pnAdd.Location = new System.Drawing.Point(205, 142);
            this.pnAdd.Name = "pnAdd";
            this.pnAdd.Size = new System.Drawing.Size(354, 222);
            this.pnAdd.TabIndex = 3;
            this.pnAdd.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "应用名称：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(126, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(191, 21);
            this.txtName.TabIndex = 1;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(65, 178);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(203, 178);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(126, 66);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(191, 21);
            this.txtPath.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "执行命令：";
            // 
            // txtParam
            // 
            this.txtParam.Location = new System.Drawing.Point(126, 105);
            this.txtParam.Name = "txtParam";
            this.txtParam.Size = new System.Drawing.Size(191, 21);
            this.txtParam.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "命令参数：";
            // 
            // rdbCommand
            // 
            this.rdbCommand.AutoSize = true;
            this.rdbCommand.Checked = true;
            this.rdbCommand.Location = new System.Drawing.Point(65, 146);
            this.rdbCommand.Name = "rdbCommand";
            this.rdbCommand.Size = new System.Drawing.Size(71, 16);
            this.rdbCommand.TabIndex = 10;
            this.rdbCommand.TabStop = true;
            this.rdbCommand.Text = "执行脚本";
            this.rdbCommand.UseVisualStyleBackColor = true;
            // 
            // rdbFile
            // 
            this.rdbFile.AutoSize = true;
            this.rdbFile.Location = new System.Drawing.Point(166, 146);
            this.rdbFile.Name = "rdbFile";
            this.rdbFile.Size = new System.Drawing.Size(71, 16);
            this.rdbFile.TabIndex = 11;
            this.rdbFile.Text = "执行文件";
            this.rdbFile.UseVisualStyleBackColor = true;
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
            // cb
            // 
            this.cb.FalseValue = "0";
            this.cb.HeaderText = "";
            this.cb.Name = "cb";
            this.cb.TrueValue = "1";
            this.cb.Width = 30;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 50;
            // 
            // AppOrder
            // 
            this.AppOrder.DataPropertyName = "AppOrder";
            this.AppOrder.HeaderText = "序号";
            this.AppOrder.Name = "AppOrder";
            this.AppOrder.Width = 40;
            // 
            // AppName
            // 
            this.AppName.DataPropertyName = "AppName";
            this.AppName.HeaderText = "应用名称";
            this.AppName.Name = "AppName";
            this.AppName.Width = 200;
            // 
            // AppPath
            // 
            this.AppPath.DataPropertyName = "AppPath";
            this.AppPath.HeaderText = "执行程序";
            this.AppPath.Name = "AppPath";
            this.AppPath.Width = 200;
            // 
            // AppParam
            // 
            this.AppParam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AppParam.DataPropertyName = "AppParam";
            this.AppParam.HeaderText = "参数";
            this.AppParam.Name = "AppParam";
            // 
            // AppType
            // 
            this.AppType.DataPropertyName = "AppType";
            this.AppType.HeaderText = "执行类型";
            this.AppType.Name = "AppType";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 485);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMain";
            this.Text = "应用程序管理";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.pnAdd.ResumeLayout(false);
            this.pnAdd.PerformLayout();
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
        private System.Windows.Forms.DataGridViewCheckBoxColumn cb;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppParam;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppType;
    }
}

