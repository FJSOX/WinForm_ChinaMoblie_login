using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Test1
{
    public partial class Form_log : Form
    {
        public Form_log()
        {
            InitializeComponent();
        }

        private void lst_user_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            if (this.Cbox_linesl.Text!="线路选择")
            {
                //MessageBox.Show("以为您连接"+ this.Cbox_linesl.Text+"网络");
                get_operator = this.Cbox_linesl.Text;
                if (this.tb_name.Text == "" || this.tb_pw.Text == "")
                {
                    MessageBox.Show("用户名和密码不能为空");

                }
                else
                {
                    if (this.tb_name.Text == "fjs" && this.tb_pw.Text == "123456")
                    {
                        //MessageBox.Show("登陆成功");//最好加一个时间属性
                        //Form_hello fh = new Form_hello();
                        //pnl_progress.BackColor=System.Drawing.Color.DarkRed;
                        tmr_progress.Start();
                        //fh.Show();
                        //this.WindowState=FormWindowState.Minimized;
                        //this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码错误");
                    }
                }
            }
            else
            {
                MessageBox.Show("线路未选择！");
            }
            
        }

        private void btn_can_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static string get_operator = "线路选择";

        private void pnl_progress_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tmr_progress_Tick(object sender, EventArgs e)
        {
            pnl_progress.Width += 5;
            if (pnl_progress.Width>=755)
            {
                tmr_progress.Stop();
                Form_hello fh = new Form_hello();
                fh.Show();
                //this.WindowState=FormWindowState.Minimized;
                this.Hide();
            }
        }

        private void tb_pw_TextChanged(object sender, EventArgs e)
        {
            lbl_pw.SendToBack();
        }

        private void tb_name_TextChanged(object sender, EventArgs e)
        {
            lbl_name.SendToBack();
        }

        private void lbl_pw_Click(object sender, EventArgs e)
        {
            lbl_pw.SendToBack();
        }

        private void lbl_name_Click(object sender, EventArgs e)
        {
            lbl_name.SendToBack();
        }

        private void Form_log_Load(object sender, EventArgs e)
        {

        }
    }
}
