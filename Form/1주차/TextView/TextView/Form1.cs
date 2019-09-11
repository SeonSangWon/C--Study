using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string OrgStr = "";

        private void textEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            //엔터키 누를 때
            if(e.KeyChar == (char)13)
            {
                e.Handled = true; //소리 없앰

                if(TextClick() == true)
                {
                    this.lblResult.Text = OrgStr + " : " + this.textEdit.Text;
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(TextClick() == true)
            {
                this.lblResult.Text = OrgStr + " : " + this.textEdit.Text;
            }
        }

        private bool TextClick()
        {
            if (this.textEdit.Text != "") return true;
            else
            {
                //메시지박스(내용,상단내용,버튼,아이콘)
                MessageBox.Show("텍스트를 입력하세요!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textEdit.Focus();

                return false;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OrgStr = this.lblResult.Text;
        }
    }
}
