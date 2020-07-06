namespace WindowsForms_Test1
{
    partial class Form_hello
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
            this.components = new System.ComponentModel.Container();
            this.btn_dis = new System.Windows.Forms.Button();
            this.lbl_stime = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.tmr_time = new System.Windows.Forms.Timer(this.components);
            this.tmr_clz = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_dis
            // 
            this.btn_dis.Location = new System.Drawing.Point(363, 317);
            this.btn_dis.Name = "btn_dis";
            this.btn_dis.Size = new System.Drawing.Size(75, 23);
            this.btn_dis.TabIndex = 0;
            this.btn_dis.Text = "注销";
            this.btn_dis.UseVisualStyleBackColor = true;
            this.btn_dis.Click += new System.EventHandler(this.btn_dis_Click);
            // 
            // lbl_stime
            // 
            this.lbl_stime.AutoSize = true;
            this.lbl_stime.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_stime.Location = new System.Drawing.Point(81, 124);
            this.lbl_stime.Name = "lbl_stime";
            this.lbl_stime.Size = new System.Drawing.Size(138, 28);
            this.lbl_stime.TabIndex = 1;
            this.lbl_stime.Text = "已连接时长：";
            // 
            // lbl_time
            // 
            this.lbl_time.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_time.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_time.Location = new System.Drawing.Point(305, 183);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(182, 57);
            this.lbl_time.TabIndex = 2;
            this.lbl_time.Text = "00:00:00";
            this.lbl_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmr_time
            // 
            this.tmr_time.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tmr_clz
            // 
            this.tmr_clz.Interval = 10;
            this.tmr_clz.Tick += new System.EventHandler(this.tmr_clz_Tick);
            // 
            // Form_hello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.lbl_stime);
            this.Controls.Add(this.btn_dis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_hello";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "欢迎使用";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_hello_FormClosing);
            this.Load += new System.EventHandler(this.Form_hello_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_dis;
        private System.Windows.Forms.Label lbl_stime;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Timer tmr_time;
        private System.Windows.Forms.Timer tmr_clz;
    }
}