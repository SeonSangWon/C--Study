using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;   //process 클래스 사용

namespace WebDownLoader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Form실행 후 사용할 URL
        //https://taegon.kim/wp-content/uploads/2018/05/image-5.png

        //progressbar 상태표시
        bool isBusy = false;
        //파일 경로
        private string filePath = null;

        private void btnDown_Click(object sender, EventArgs e)
        {
            if(isBusy)
            {
                webClient.CancelAsync();
                isBusy = false;
            }
            else
            {
                try
                {
                    var strFileName = this.txtUrl.Text.Split(new Char[] { '/' });
                    System.Array.Reverse(strFileName);

                    Uri uri = new Uri(this.txtUrl.Text);
                    //파일의 유효성 검사를 위한 코드
                    var str = webClient.DownloadString(uri);
                    webClient.DownloadFileAsync(uri, filePath + @"\" + strFileName[0]);
                    isBusy = true;

                }
                catch {
                    this.btnDown.Enabled = false;
                    MessageBox.Show("다운로드가 실패하였습니다.", "에러", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void webClient_DownloadProgressChanged(object sender, System.Net.DownloadProgressChangedEventArgs e)
        {
            this.pgbDownload.Value = e.ProgressPercentage;
        }

        private void webClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            isBusy = false;
            this.btnDown.Enabled = false;

            if (e.Error == null)
            {
                if (this.cbOpen.Checked == false)
                    MessageBox.Show("다운로드가 완료되었습니다.", "알림",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    Process myProcess = new Process();
                    myProcess.StartInfo.FileName = filePath;
                    myProcess.Start();
                }
            }
            else
                MessageBox.Show("다운로드가 실패하였습니다." + e.Error.Message.ToString());
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            if(this.fbdFile.ShowDialog() == DialogResult.OK)
            {
                this.btnDown.Enabled = true;
                filePath = this.fbdFile.SelectedPath;
            }
        }
    }
}
