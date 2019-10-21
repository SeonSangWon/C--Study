namespace ProcessView
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
            this.lvView = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMemory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnKill = new System.Windows.Forms.Button();
            this.ssBar = new System.Windows.Forms.StatusStrip();
            this.tsslProcess = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCpu = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslMem = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvView
            // 
            this.lvView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chPid,
            this.chTime,
            this.chMemory});
            this.lvView.FullRowSelect = true;
            this.lvView.GridLines = true;
            this.lvView.HideSelection = false;
            this.lvView.Location = new System.Drawing.Point(0, 1);
            this.lvView.Name = "lvView";
            this.lvView.Size = new System.Drawing.Size(492, 257);
            this.lvView.TabIndex = 0;
            this.lvView.UseCompatibleStateImageBehavior = false;
            this.lvView.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "프로세스 이름";
            this.chName.Width = 160;
            // 
            // chPid
            // 
            this.chPid.Text = "PID";
            this.chPid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chPid.Width = 100;
            // 
            // chTime
            // 
            this.chTime.Text = "Time";
            this.chTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chTime.Width = 100;
            // 
            // chMemory
            // 
            this.chMemory.Text = "메모리 사용";
            this.chMemory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chMemory.Width = 130;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(491, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnKill
            // 
            this.btnKill.Location = new System.Drawing.Point(336, 302);
            this.btnKill.Name = "btnKill";
            this.btnKill.Size = new System.Drawing.Size(143, 47);
            this.btnKill.TabIndex = 2;
            this.btnKill.Text = "프로세스 끝내기";
            this.btnKill.UseVisualStyleBackColor = true;
            // 
            // ssBar
            // 
            this.ssBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslProcess,
            this.tsslCpu,
            this.tsslMem});
            this.ssBar.Location = new System.Drawing.Point(0, 350);
            this.ssBar.Name = "ssBar";
            this.ssBar.Size = new System.Drawing.Size(491, 22);
            this.ssBar.TabIndex = 3;
            this.ssBar.Text = "statusStrip1";
            // 
            // tsslProcess
            // 
            this.tsslProcess.Name = "tsslProcess";
            this.tsslProcess.Size = new System.Drawing.Size(85, 17);
            this.tsslProcess.Text = "프로세스 : 0개";
            // 
            // tsslCpu
            // 
            this.tsslCpu.Name = "tsslCpu";
            this.tsslCpu.Size = new System.Drawing.Size(86, 17);
            this.tsslCpu.Text = "CPU 사용 : 0%";
            // 
            // tsslMem
            // 
            this.tsslMem.Name = "tsslMem";
            this.tsslMem.Size = new System.Drawing.Size(99, 17);
            this.tsslMem.Text = "실제 메모리 : 0%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 372);
            this.Controls.Add(this.ssBar);
            this.Controls.Add(this.btnKill);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lvView);
            this.Font = new System.Drawing.Font("문체부 제목 돋음체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "프로세스 보기 ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ssBar.ResumeLayout(false);
            this.ssBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvView;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chPid;
        private System.Windows.Forms.ColumnHeader chTime;
        private System.Windows.Forms.ColumnHeader chMemory;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Button btnKill;
        private System.Windows.Forms.StatusStrip ssBar;
        private System.Windows.Forms.ToolStripStatusLabel tsslProcess;
        private System.Windows.Forms.ToolStripStatusLabel tsslCpu;
        private System.Windows.Forms.ToolStripStatusLabel tsslMem;
    }
}

