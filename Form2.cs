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

        DateTime thetime = new DateTime();
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lbl_time.Text = (DateTime.Now - thetime).ToString();
            
        }
    }
}
