using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //진행 숫자
        int Num = 0;
        //결과 : 저장
        string OrgStr = "";
        private void btnRun_Click(object sender, EventArgs e)
        {
            this.Timer.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.Timer.Enabled = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Num++;
            if(Num > 100)
            {
                this.Timer.Enabled = false;
                return;
            }
            this.pbStatus.Value = Num;
            this.lblStatus.Text = OrgStr + " : " + Num.ToString() + "%";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OrgStr = this.lblStatus.Text;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.Timer.Enabled = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Timer.Enabled = false;

            Num = 0;
            pbStatus.Value = 0;

            OrgStr = "상태";
            this.lblStatus.Text = OrgStr;
        }
    }
}
