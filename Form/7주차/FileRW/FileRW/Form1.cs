using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;    //입,출력 필수

namespace FileRW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //읽을 파일 불러오기
        private void btnRPath_Click(object sender, EventArgs e)
        {
            if (this.ofdFile.ShowDialog() == DialogResult.OK)
            {
                this.txtRPath.Text = this.ofdFile.FileName;
            }
        }

        //유효성 검사
        private bool txtCheck()
        {
            if (this.txtRPath.Text == "")
                return false;
            else
                return true;
        }

        //파일 전체읽어오기
        private void btnRARead_Click(object sender, EventArgs e)
        {
            if (txtCheck() == false)
                return;
            if (File.Exists(this.txtRPath.Text))
            {
                using (StreamReader sr = new StreamReader(this.txtRPath.Text, Encoding.Default))
                {
                    this.txtRView.Text = sr.ReadToEnd();
                }
            }
            else
            {
                MessageBox.Show("읽을 파일이 없습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //파일 라인읽어오기
        private void btnRLRead_Click(object sender, EventArgs e)
        {
            if(txtCheck() == false)
                return;

            this.txtRView.Clear();
            if(File.Exists(this.txtRPath.Text))
            {
                using (StreamReader sr = new StreamReader(this.txtRPath.Text, Encoding.Default)) {
                    string line = null;
                    while((line = sr.ReadLine()) != null)
                    {
                        this.txtRView.AppendText(line + "\r\n");
                    }
                }
            }
            else
            {
                MessageBox.Show("읽을 파일이 없습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //작성할 파일 불러오기
        private void btnWPath_Click(object sender, EventArgs e)
        {
            if(this.sfdFile.ShowDialog() == DialogResult.OK)
            {
                this.txtWPath.Text = this.sfdFile.FileName;
            }
        }

        //작성한 파일 전체저장
        private void btnWASave_Click(object sender, EventArgs e)
        {
            try {
                using (StreamWriter sw = new StreamWriter(this.txtWPath.Text))
                {
                    sw.WriteLine(this.txtWView.Text);
                }
            }catch{ return; }
            MessageBox.Show("파일이 정상적으로 저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //작성한 파일 라인저장
        private void btnWLSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(this.txtWPath.Text))
                {
                    foreach(var str in this.txtWView.Lines)
                    {
                        sw.WriteLine(str);
                    }
                }
            }
            catch { return; }
            MessageBox.Show("파일이 정상적으로 저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
