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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_log));
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_pw = new System.Windows.Forms.TextBox();
            this.btn_log = new System.Windows.Forms.Button();
            this.btn_can = new System.Windows.Forms.Button();
            this.Cbox_linesl = new System.Windows.Forms.ComboBox();
            this.pnl_progress = new System.Windows.Forms.Panel();
            this.tmr_progress = new System.Windows.Forms.Timer(this.components);
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_pw = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_name.Location = new System.Drawing.Point(176, 154);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(279, 26);
            this.tb_name.TabIndex = 3;
            this.tb_name.TextChanged += new System.EventHandler(this.tb_name_TextChanged);
            // 
            // tb_pw
            // 
            this.tb_pw.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_pw.Location = new System.Drawing.Point(176, 212);
            this.tb_pw.Name = "tb_pw";
            this.tb_pw.PasswordChar = '*';
            this.tb_pw.Size = new System.Drawing.Size(279, 26);
            this.tb_pw.TabIndex = 4;
            this.tb_pw.TextChanged += new System.EventHandler(this.tb_pw_TextChanged);
            // 
            // btn_log
            // 
            this.btn_log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btn_log.FlatAppearance.BorderSize = 0;
            this.btn_log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_log.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_log.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_log.Location = new System.Drawing.Point(176, 256);
            this.btn_log.Name = "btn_log";
            this.btn_log.Size = new System.Drawing.Size(155, 31);
            this.btn_log.TabIndex = 5;
            this.btn_log.Text = "登录";
            this.btn_log.UseVisualStyleBackColor = false;
            this.btn_log.Click += new System.EventHandler(this.btn_log_Click);
            // 
            // btn_can
            // 
            this.btn_can.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btn_can.FlatAppearance.BorderSize = 0;
            this.btn_can.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_can.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_can.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_can.Location = new System.Drawing.Point(410, 256);
            this.btn_can.Name = "btn_can";
            this.btn_can.Size = new System.Drawing.Size(155, 31);
            this.btn_can.TabIndex = 6;
            this.btn_can.Text = "取消";
            this.btn_can.UseVisualStyleBackColor = false;
            this.btn_can.Click += new System.EventHandler(this.btn_can_Click);
            // 
            // Cbox_linesl
            // 
            this.Cbox_linesl.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cbox_linesl.FormattingEnabled = true;
            this.Cbox_linesl.Items.AddRange(new object[] {
            "校园",
            "移动",
            "联通",
            "电信"});
            this.Cbox_linesl.Location = new System.Drawing.Point(484, 154);
            this.Cbox_linesl.Name = "Cbox_linesl";
            this.Cbox_linesl.Size = new System.Drawing.Size(81, 28);
            this.Cbox_linesl.TabIndex = 7;
            this.Cbox_linesl.Text = "线路选择";
            // 
            // pnl_progress
            // 
            this.pnl_progress.BackColor = System.Drawing.Color.Lime;
            this.pnl_progress.Location = new System.Drawing.Point(0, 428);
            this.pnl_progress.Name = "pnl_progress";
            this.pnl_progress.Size = new System.Drawing.Size(0, 22);
            this.pnl_progress.TabIndex = 8;
            this.pnl_progress.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_progress_Paint);
            // 
            // tmr_progress
            // 
            this.tmr_progress.Interval = 1;
            this.tmr_progress.Tick += new System.EventHandler(this.tmr_progress_Tick);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.White;
            this.lbl_name.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_name.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_name.Location = new System.Drawing.Point(184, 157);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(93, 20);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "请输入用户名";
            this.lbl_name.Click += new System.EventHandler(this.lbl_name_Click);
            // 
            // lbl_pw
            // 
            this.lbl_pw.AutoSize = true;
            this.lbl_pw.BackColor = System.Drawing.Color.White;
            this.lbl_pw.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_pw.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_pw.Location = new System.Drawing.Point(184, 215);
            this.lbl_pw.Name = "lbl_pw";
            this.lbl_pw.Size = new System.Drawing.Size(79, 20);
            this.lbl_pw.TabIndex = 2;
            this.lbl_pw.Text = "请输入密码";
            this.lbl_pw.Click += new System.EventHandler(this.lbl_pw_Click);
            // 
            // Form_log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(739, 450);
            this.Controls.Add(this.lbl_pw);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.pnl_progress);
            this.Controls.Add(this.Cbox_linesl);
            this.Controls.Add(this.btn_can);
            this.Controls.Add(this.btn_log);
            this.Controls.Add(this.tb_pw);
            this.Controls.Add(this.tb_name);
            this.Name = "Form_log";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "连接到网络";
            this.Load += new System.EventHandler(this.Form_log_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_pw;
        private System.Windows.Forms.Button btn_log;
        private System.Windows.Forms.Button btn_can;
        private System.Windows.Forms.ComboBox Cbox_linesl;
        private System.Windows.Forms.Panel pnl_progress;
        private System.Windows.Forms.Timer tmr_progress;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_pw;
    }
}

