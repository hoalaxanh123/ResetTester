using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ResetTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int count = 5;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_TimeDisplay.Text = count.ToString();
            count--;
            if(count == 0)
            {
                Process.Start("shutdown", "/s /t 0");
                timer1.Stop();
                this.Close();
            }
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            if(this.btn_Stop.Text == "Start")
            {
                timer1.Start();
                this.btn_Stop.Text = "Stop";
            }
                else
            {
                timer1.Stop();
                this.btn_Stop.Text = "Start";
            }
        
        }
    }
}
