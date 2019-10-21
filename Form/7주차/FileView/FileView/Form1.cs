using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
    

namespace FileView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //스레드 개체 생성
        Thread threadFileView = null;

        //델리게이트 생성
        private delegate void OnDelegateFile(string fp, string fn, string fl, string fc); private OnDelegateFile OnFile = null;

        //일반 / 히든 파일 구분
        bool Flag = true; 
  
        int DirCount = 0;
        int FileCount = 0;

        //파일 경로
        private void btnPath_Click(object sender, EventArgs e)
        {
            if(this.fbdFolder.ShowDialog() == DialogResult.OK)
            {
                ItemsClear();

                this.txtPath.Text = this.fbdFolder.SelectedPath;
                threadFileView = new Thread(
                    new ParameterizedThreadStart(FileView)
                    );
                threadFileView.Start(this.fbdFolder.SelectedPath);
            }
        }

        private void ItemsClear()
        {
            DirCount = 0;
            FileCount = 0;
            this.lvFile.Items.Clear();
        }

        //경로 안에 파일 불러오기
        private void FileView(object path)
        {
            DirCount++;
            DirectoryInfo di = new DirectoryInfo(
                (string)path); DirectoryInfo[] dti = di.GetDirectories();
            foreach (var f in di.GetFiles())
            {
                if (Flag == true)
                {
                    FileCount++;
                    Invoke(OnFile, f.DirectoryName, f.Name, f.Length.ToString(), f.CreationTime.ToString());
                }
                else
                {
                    if (f.Attributes.ToString().Contains(FileAttributes.Hidden.ToString()))
                    {
                        FileCount++;

                        Invoke(OnFile, f.DirectoryName, f.Name, f.Length.ToString(), f.CreationTime.ToString());
                    }
                }
            }

            for (int i = 0; i < di.GetDirectories().Length; i++)
            {
                try
                {
                    FileView(dti[i].FullName);
                }
                catch { continue; }
            }
        }

        //전체파일 불러오기
        private void rbtnAll_CheckedChanged(object sender, EventArgs e)
        {
            ItemsClear();

            Flag = true;
            if(threadFileView != null)
                threadFileView.Abort();

            if (this.txtPath.Text != "")
            {
                this.lvFile.Items.Clear();
                threadFileView = new Thread(
                    new ParameterizedThreadStart(FileView)
                    );
                threadFileView.Start(this.fbdFolder.SelectedPath);
            }
        }

        //숨김파일 불러오기
        private void rbtnHidden_CheckedChanged(object sender, EventArgs e)
        {
            ItemsClear();

            Flag = false;
            if(threadFileView != null)
                threadFileView.Abort();

            if (this.txtPath.Text != "")
            {
                this.lvFile.Items.Clear();
                threadFileView = new Thread(
                    new ParameterizedThreadStart(FileView)
                    );
                threadFileView.Start(this.fbdFolder.SelectedPath);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OnFile = new OnDelegateFile(FileResult);
        }

        //총 갯수 나타내기
        private void FileResult(string fp, string fn, string fl, string fc)
        {
            string fSize = GetFileSize(Convert.ToDouble(fl));
            this.lvFile.Items.Add(new ListViewItem(new string[] { fp, fn, fc, fSize }));
            this.tsslblResult.Text = String.Format("폴더 : {0} 개, 파일 : {1} 개", DirCount, FileCount);
        }

        //불러오는 파일 크기 알아내기
        private string GetFileSize(double byteCount)
        {
            string size = "0 Bytes";

            if(byteCount >= 1073741824.0) 
                size = String.Format("{0:##.##}", byteCount / 1073741824.0) + " GB";
            else if(byteCount >= 1048576.0)
                size = String.Format("{0:##.##}", byteCount / 1048576.0) + " MB";
            else if (byteCount >= 1024.0)
                size = String.Format("{0:##.##}", byteCount / 1024.0) + " KB";
            else if (byteCount > 0 && byteCount < 1024.0)
                size = byteCount.ToString() + " Bytes";
            return size;
        }

        //Form이 종료될 때
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(threadFileView != null)
                threadFileView.Abort();
        }
    }
}
