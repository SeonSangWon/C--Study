﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //폼 Opacity값 설정
        private double o = 0.0;

        public string SetText
        {
            //Form1에서 접근하여 [Text]속성 변경
            set { this.Text = value; }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Timer.Enabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if(o < 100.0)
            {
                o = o + 3.6;
                float c = Convert.ToSingle(o);
                float f = c / 100;
                this.Opacity = f;
            }
            else
            {
                this.Opacity = Convert.ToSingle(100 / 100);
                o = 0.0;
                this.Timer.Enabled = false;
            }
        }
    }
}
