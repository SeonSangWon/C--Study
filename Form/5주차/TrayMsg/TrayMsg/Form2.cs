﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace TrayMsg
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            //스크린의 가로 위치
            int x = Screen.PrimaryScreen.WorkingArea.Width - this.Width - 20;
            //스크린의 세로 위치
            int y = Screen.PrimaryScreen.WorkingArea.Height - this.Height;

            //폼의 위치 설정
            DesktopLocation = new Point(x, y);
            this.Size = new Size(170, 0);
           
            InitializeComponent();
        }

        private static System.Timers.Timer TimerEvent;

        public string MsgText
        {
            set
            {
                this.lblResult.Text = value;
            }
        }

        //delegate 선언
        private delegate void OnDelegateHeight(int Flag);
        private OnDelegateHeight OnHeight = null;

        private void lblResult_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            TimerEvent.Stop();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            OnHeight = new OnDelegateHeight(MsgView);
            this.Size = new System.Drawing.Size(170, 0);
            this.Location =
                new System.Drawing.Point(Screen.PrimaryScreen.WorkingArea.Width -
                this.Width - 20, Screen.PrimaryScreen.WorkingArea.Height - this.Height);

            TimerEvent = new System.Timers.Timer(2);
            TimerEvent.Elapsed += new ElapsedEventHandler(OnPopUp);
            TimerEvent.Start();
        }

        private void MsgView(int Flag)
        {
            if(Flag == 0)
            {
                Height++;
                Top--;
            }
            else if(Flag == 1)
            {
                Height--;
                Top++;
            }
            else if(Flag == 2)
            {
                this.Close();
            }
        }

        private void OnPopUp(object sender, ElapsedEventArgs e)
        {
            if(Height < 120)
            {
                Invoke(OnHeight, 0);
            }
            else
            {
                TimerEvent.Stop();
                TimerEvent.Elapsed -= new ElapsedEventHandler(OnPopUp);

                TimerEvent.Elapsed += new ElapsedEventHandler(OnPopOut);
                TimerEvent.Interval = 3000;
                TimerEvent.Start();
            }
            Application.DoEvents();
        }

        private void OnPopOut(object sender, ElapsedEventArgs e)
        {
            while(Height > 2)
            {
                Invoke(OnHeight, 1);
            }
            TimerEvent.Stop();
            Application.DoEvents();
            Invoke(OnHeight, 2);
        }
    }
}
