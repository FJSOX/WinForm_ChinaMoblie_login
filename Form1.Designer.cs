namespace WindowsForms_Test1
{
    partial class Form_log
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_pw = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_pw = new System.Windows.Forms.TextBox();
            this.btn_log = new System.Windows.Forms.Button();
            this.btn_can = new System.Windows.Forms.Button();
            this.Cbox_linesl = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(52, 55);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(41, 12);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "用户名";
            // 
            // lbl_pw
            // 
            this.lbl_pw.AutoSize = true;
            this.lbl_pw.Location = new System.Drawing.Point(52, 113);
            this.lbl_pw.Name = "lbl_pw";
            this.lbl_pw.Size = new System.Drawing.Size(29, 12);
            this.lbl_pw.TabIndex = 2;
            this.lbl_pw.Text = "密码";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(144, 52);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(100, 21);
            this.tb_name.TabIndex = 3;
            // 
            // tb_pw
            // 
            this.tb_pw.Location = new System.Drawing.Point(144, 110);
            this.tb_pw.Name = "tb_pw";
            this.tb_pw.PasswordChar = '*';
            this.tb_pw.Size = new System.Drawing.Size(100, 21);
            this.tb_pw.TabIndex = 4;
            // 
            // btn_log
            // 
            this.btn_log.Location = new System.Drawing.Point(69, 189);
            this.btn_log.Name = "btn_log";
            this.btn_log.Size = new System.Drawing.Size(75, 23);
            this.btn_log.TabIndex = 5;
            this.btn_log.Text = "登录";
            this.btn_log.UseVisualStyleBackColor = true;
            this.btn_log.Click += new System.EventHandler(this.btn_log_Click);
            // 
            // btn_can
            // 
            this.btn_can.Location = new System.Drawing.Point(227, 189);
            this.btn_can.Name = "btn_can";
            this.btn_can.Size = new System.Drawing.Size(75, 23);
            this.btn_can.TabIndex = 6;
            this.btn_can.Text = "取消";
            this.btn_can.UseVisualStyleBackColor = true;
            this.btn_can.Click += new System.EventHandler(this.btn_can_Click);
            // 
            // Cbox_linesl
            // 
            this.Cbox_linesl.FormattingEnabled = true;
            this.Cbox_linesl.Items.AddRange(new object[] {
            "校园",
            "移动",
            "联通",
            "电信"});
            this.Cbox_linesl.Location = new System.Drawing.Point(250, 53);
            this.Cbox_linesl.Name = "Cbox_linesl";
            this.Cbox_linesl.Size = new System.Drawing.Size(70, 20);
            this.Cbox_linesl.TabIndex = 7;
            this.Cbox_linesl.Text = "线路选择";
            // 
            // Form_log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(388, 260);
            this.Controls.Add(this.Cbox_linesl);
            this.Controls.Add(this.btn_can);
            this.Controls.Add(this.btn_log);
            this.Controls.Add(this.tb_pw);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.lbl_pw);
            this.Controls.Add(this.lbl_name);
            this.Name = "Form_log";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "连接到网络";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_pw;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_pw;
        private System.Windows.Forms.Button btn_log;
        private System.Windows.Forms.Button btn_can;
        private System.Windows.Forms.ComboBox Cbox_linesl;
    }
}

