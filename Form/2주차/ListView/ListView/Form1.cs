using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //문자열 저장
        string strName, strAge, strWork;

        private void lvView_Click(object sender, EventArgs e)
        {
            if (this.lvView.SelectedItems.Count == 0)
                MessageBox.Show("아이템을 선택하세요.!", "알림", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MessageBox.Show("이름 : " + this.lvView.SelectedItems[0].SubItems[0].Text +
                    "\n나이 : " + this.lvView.SelectedItems[0].SubItems[1].Text +
                    "\n직업 : " + this.lvView.SelectedItems[0].SubItems[2].Text, "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (TextCheck() == true)
            {
                strName = this.txtName.Text;
                strAge = this.txtAge.Text;
                strWork = this.txtWork.Text;

                this.txtName.Text = "";
                this.txtAge.Text = "";
                this.txtWork.Text = "";
            }
            else
            {
                MessageBox.Show("아이템을 입력하세요.!", "알림",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
                

            ListViewItem lvi = new ListViewItem(new string[] { strName, strAge, strWork });
            this.lvView.Items.Add(lvi);
        }

        private bool TextCheck()
        {
            if (this.txtName.Text != "" && this.txtAge.Text != "" && txtWork.Text != "")
            {
                return true;
            }
            else
                return false;
        }

        private void txtWork_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (this.txtName.Text != "" && this.txtAge.Text != "" && this.txtWork.Text != "")
                {
                    strName = this.txtName.Text;
                    strAge = this.txtAge.Text;
                    strWork = this.txtWork.Text;

                    this.txtName.Text = "";
                    this.txtAge.Text = "";
                    this.txtWork.Text = "";

                    ListViewItem lvi = new ListViewItem(new string[] { strName, strAge, strWork });
                    this.lvView.Items.Add(lvi);
                }
                else
                {
                    MessageBox.Show("아이템을 입력하세요.!", "알림",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
