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

        }

        

        private void btn_dis_Click(object sender, EventArgs e)
        {
            //this.Form_hello_FormClosing(sender, e);
            Application.Exit();
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
    }
}
