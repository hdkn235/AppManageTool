namespace AppManageTool
{
    partial class FrmConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabConfig = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbAfterRunAppAutoMin = new System.Windows.Forms.CheckBox();
            this.cbAfterStartRunApp = new System.Windows.Forms.CheckBox();
            this.cbAfterStartAutoMin = new System.Windows.Forms.CheckBox();
            this.cbAutoStart = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.tabConfig.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabConfig
            // 
            this.tabConfig.Controls.Add(this.tabPage1);
            this.tabConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabConfig.Location = new System.Drawing.Point(0, 0);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.SelectedIndex = 0;
            this.tabConfig.Size = new System.Drawing.Size(291, 225);
            this.tabConfig.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Azure;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.cbAfterRunAppAutoMin);
            this.tabPage1.Controls.Add(this.cbAfterStartRunApp);
            this.tabPage1.Controls.Add(this.cbAfterStartAutoMin);
            this.tabPage1.Controls.Add(this.cbAutoStart);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(283, 199);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "启动";
            // 
            // cbAfterRunAppAutoMin
            // 
            this.cbAfterRunAppAutoMin.AutoSize = true;
            this.cbAfterRunAppAutoMin.Location = new System.Drawing.Point(27, 101);
            this.cbAfterRunAppAutoMin.Name = "cbAfterRunAppAutoMin";
            this.cbAfterRunAppAutoMin.Size = new System.Drawing.Size(144, 16);
            this.cbAfterRunAppAutoMin.TabIndex = 3;
            this.cbAfterRunAppAutoMin.Tag = "AfterRunAppAutoMin";
            this.cbAfterRunAppAutoMin.Text = "运行应用后自动最小化";
            this.cbAfterRunAppAutoMin.UseVisualStyleBackColor = true;
            // 
            // cbAfterStartRunApp
            // 
            this.cbAfterStartRunApp.AutoSize = true;
            this.cbAfterStartRunApp.Location = new System.Drawing.Point(27, 140);
            this.cbAfterStartRunApp.Name = "cbAfterStartRunApp";
            this.cbAfterStartRunApp.Size = new System.Drawing.Size(168, 16);
            this.cbAfterStartRunApp.TabIndex = 2;
            this.cbAfterStartRunApp.Tag = "AfterStartRunApp";
            this.cbAfterStartRunApp.Text = "启动后自动运行勾选的应用";
            this.cbAfterStartRunApp.UseVisualStyleBackColor = true;
            // 
            // cbAfterStartAutoMin
            // 
            this.cbAfterStartAutoMin.AutoSize = true;
            this.cbAfterStartAutoMin.Location = new System.Drawing.Point(27, 62);
            this.cbAfterStartAutoMin.Name = "cbAfterStartAutoMin";
            this.cbAfterStartAutoMin.Size = new System.Drawing.Size(120, 16);
            this.cbAfterStartAutoMin.TabIndex = 1;
            this.cbAfterStartAutoMin.Tag = "AfterStartAutoMin";
            this.cbAfterStartAutoMin.Text = "启动后自动最小化";
            this.cbAfterStartAutoMin.UseVisualStyleBackColor = true;
            // 
            // cbAutoStart
            // 
            this.cbAutoStart.AutoSize = true;
            this.cbAutoStart.Location = new System.Drawing.Point(27, 23);
            this.cbAutoStart.Name = "cbAutoStart";
            this.cbAutoStart.Size = new System.Drawing.Size(144, 16);
            this.cbAutoStart.TabIndex = 0;
            this.cbAutoStart.Tag = "AutoStart";
            this.cbAutoStart.Text = "开机时自动启动该程序";
            this.cbAutoStart.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnCancel);
            this.panel1.Controls.Add(this.BtnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 225);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 35);
            this.panel1.TabIndex = 1;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(171, 6);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(45, 6);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 0;
            this.BtnSave.Text = "保存";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // FrmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 260);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabConfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "设置";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmConfig_Load);
            this.tabConfig.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabConfig;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.CheckBox cbAfterStartAutoMin;
        private System.Windows.Forms.CheckBox cbAutoStart;
        private System.Windows.Forms.CheckBox cbAfterStartRunApp;
        private System.Windows.Forms.CheckBox cbAfterRunAppAutoMin;
    }
}