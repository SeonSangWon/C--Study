﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CBChoice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> list = new List<string> { "스테이크", "카레라이스", "라면", "만두국", "김밥"};

        //초기 콤보 박스 데이터
        string[] SList = new string[] { "스테이크", "카레라이스", "라면", "만두국", "김밥" };
        
        //선택 결과 저장
        string orgStr = "";

        //Form을 실행함과 동시에 초기화작업을 진행
        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < SList.Length; i++)
            {
                this.cbList.Items.Add(SList[i]);
            }
            orgStr = this.lblResult.Text;
        }

        private void cbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbList.Text != "")
                this.lblResult.Text = orgStr + " : " + this.cbList.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.txtList.Text != "")
            {
                this.cbList.Items.Add(this.txtList.Text);
                MessageBox.Show("아이템을 추가하였습니다", "알림", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                this.txtList.Focus();
            this.txtList.Text = "";
        }
    }
}
