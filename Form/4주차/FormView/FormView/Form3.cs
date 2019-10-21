using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormView
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public string SetText
        {
            //Form1에서 접근하여 [Text]속성 변경
            set { this.Text = value; }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (this.Size.Width > 300 && this.Size.Height > 300)
            {
                this.Timer.Enabled = false;
            }
            else
            {
                //폼 사이즈 변경
                this.Size += new Size(10, 10);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Timer.Enabled = true;

            //폼 Opacity값 100%설정
            this.Opacity = Convert.ToSingle(100 / 100);
        }

        
    }
}
