using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int ImgCount = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.picImg.Image = this.imgList.Images[0];
            ImgCount = this.imgList.Images.Count;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ImgCount--;

            if (ImgCount < 0)
                ImgCount = this.imgList.Images.Count - 1;

            this.picImg.Image = this.imgList.Images[ImgCount];
        }
    }
}
