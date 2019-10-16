namespace Timer
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtCountDown = new System.Windows.Forms.TextBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(68, 67);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(133, 23);
            this.txtNum.TabIndex = 0;
            // 
            // txtCountDown
            // 
            this.txtCountDown.Location = new System.Drawing.Point(68, 120);
            this.txtCountDown.Name = "txtCountDown";
            this.txtCountDown.ReadOnly = true;
            this.txtCountDown.Size = new System.Drawing.Size(133, 23);
            this.txtCountDown.TabIndex = 1;
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(244, 66);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(93, 77);
            this.btnCount.TabIndex = 2;
            this.btnCount.Text = "CountDown";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 213);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.txtCountDown);
            this.Controls.Add(this.txtNum);
            this.Font = new System.Drawing.Font("문체부 훈민정음체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "타이머";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtCountDown;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Timer Timer;
    }
}

