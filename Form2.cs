using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Test1
{
    public partial class Form_hello : Form
    {
        public Form_hello()
        {
            InitializeComponent();
            //Form_log fl = new Form_log();
            this.lbl_stime.Text = "以为您连接到" + Form_log.get_operator + "网络，连接时长：";
            
            
        }

        

        private void btn_dis_Click(object sender, EventArgs e)
        {
            //this.Form_hello_FormClosing(sender, e);
            tmr_clz.Start();
            
            //Application.Exit();
        }

        private void Form_hello_FormClosing(object sender, FormClosingEventArgs e)
        {
            btn_dis_Click(sender, e);
        }


        DateTime thetime = DateTime.Now;
        TimeSpan interval = new TimeSpan();
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            interval = DateTime.Now - thetime;

            this.lbl_time.Text = String.Format("{0:00}:{1:00}:{2:00}", interval.Hours,interval.Minutes, interval.Seconds);  
        }

        private void Form_hello_Load(object sender, EventArgs e)
        {
            tmr_time.Enabled = true;
            //timer1_Tick(sender, e);
        }

        private void tmr_clz_Tick(object sender, EventArgs e)
        {
            if (this.Opacity>=0.025)
            {
                this.Opacity -= 0.025;
            }
            else
            {
                Application.Exit();
                tmr_clz.Stop();
            }
        }
    }
}
