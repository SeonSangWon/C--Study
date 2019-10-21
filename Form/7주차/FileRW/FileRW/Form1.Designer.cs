namespace FileRW
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
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tpRead = new System.Windows.Forms.TabPage();
            this.txtRView = new System.Windows.Forms.TextBox();
            this.txtRPath = new System.Windows.Forms.TextBox();
            this.btnRLRead = new System.Windows.Forms.Button();
            this.btnRARead = new System.Windows.Forms.Button();
            this.btnRPath = new System.Windows.Forms.Button();
            this.tpWrite = new System.Windows.Forms.TabPage();
            this.btnWLSave = new System.Windows.Forms.Button();
            this.btnWASave = new System.Windows.Forms.Button();
            this.btnWPath = new System.Windows.Forms.Button();
            this.txtWView = new System.Windows.Forms.TextBox();
            this.txtWPath = new System.Windows.Forms.TextBox();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.sfdFile = new System.Windows.Forms.SaveFileDialog();
            this.tabMenu.SuspendLayout();
            this.tpRead.SuspendLayout();
            this.tpWrite.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tpRead);
            this.tabMenu.Controls.Add(this.tpWrite);
            this.tabMenu.Location = new System.Drawing.Point(0, 0);
            this.tabMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(902, 522);
            this.tabMenu.TabIndex = 0;
            // 
            // tpRead
            // 
            this.tpRead.Controls.Add(this.txtRView);
            this.tpRead.Controls.Add(this.txtRPath);
            this.tpRead.Controls.Add(this.btnRLRead);
            this.tpRead.Controls.Add(this.btnRARead);
            this.tpRead.Controls.Add(this.btnRPath);
            this.tpRead.Location = new System.Drawing.Point(4, 29);
            this.tpRead.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpRead.Name = "tpRead";
            this.tpRead.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpRead.Size = new System.Drawing.Size(894, 489);
            this.tpRead.TabIndex = 0;
            this.tpRead.Text = "파일 읽기";
            this.tpRead.UseVisualStyleBackColor = true;
            // 
            // txtRView
            // 
            this.txtRView.Location = new System.Drawing.Point(22, 70);
            this.txtRView.Multiline = true;
            this.txtRView.Name = "txtRView";
            this.txtRView.ReadOnly = true;
            this.txtRView.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRView.Size = new System.Drawing.Size(838, 352);
            this.txtRView.TabIndex = 4;
            // 
            // txtRPath
            // 
            this.txtRPath.Location = new System.Drawing.Point(22, 19);
            this.txtRPath.Name = "txtRPath";
            this.txtRPath.ReadOnly = true;
            this.txtRPath.Size = new System.Drawing.Size(838, 26);
            this.txtRPath.TabIndex = 1;
            // 
            // btnRLRead
            // 
            this.btnRLRead.Location = new System.Drawing.Point(281, 440);
            this.btnRLRead.Name = "btnRLRead";
            this.btnRLRead.Size = new System.Drawing.Size(124, 38);
            this.btnRLRead.TabIndex = 3;
            this.btnRLRead.Text = "라인읽기";
            this.btnRLRead.UseVisualStyleBackColor = true;
            this.btnRLRead.Click += new System.EventHandler(this.btnRLRead_Click);
            // 
            // btnRARead
            // 
            this.btnRARead.Location = new System.Drawing.Point(151, 440);
            this.btnRARead.Name = "btnRARead";
            this.btnRARead.Size = new System.Drawing.Size(124, 38);
            this.btnRARead.TabIndex = 2;
            this.btnRARead.Text = "전체읽기";
            this.btnRARead.UseVisualStyleBackColor = true;
            this.btnRARead.Click += new System.EventHandler(this.btnRARead_Click);
            // 
            // btnRPath
            // 
            this.btnRPath.Location = new System.Drawing.Point(21, 440);
            this.btnRPath.Name = "btnRPath";
            this.btnRPath.Size = new System.Drawing.Size(124, 38);
            this.btnRPath.TabIndex = 1;
            this.btnRPath.Text = "파일";
            this.btnRPath.UseVisualStyleBackColor = true;
            this.btnRPath.Click += new System.EventHandler(this.btnRPath_Click);
            // 
            // tpWrite
            // 
            this.tpWrite.Controls.Add(this.btnWLSave);
            this.tpWrite.Controls.Add(this.btnWASave);
            this.tpWrite.Controls.Add(this.btnWPath);
            this.tpWrite.Controls.Add(this.txtWView);
            this.tpWrite.Controls.Add(this.txtWPath);
            this.tpWrite.Location = new System.Drawing.Point(4, 29);
            this.tpWrite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpWrite.Name = "tpWrite";
            this.tpWrite.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpWrite.Size = new System.Drawing.Size(894, 489);
            this.tpWrite.TabIndex = 1;
            this.tpWrite.Text = "파일 쓰기";
            this.tpWrite.UseVisualStyleBackColor = true;
            // 
            // btnWLSave
            // 
            this.btnWLSave.Location = new System.Drawing.Point(283, 438);
            this.btnWLSave.Name = "btnWLSave";
            this.btnWLSave.Size = new System.Drawing.Size(124, 38);
            this.btnWLSave.TabIndex = 12;
            this.btnWLSave.Text = "라인저장";
            this.btnWLSave.UseVisualStyleBackColor = true;
            this.btnWLSave.Click += new System.EventHandler(this.btnWLSave_Click);
            // 
            // btnWASave
            // 
            this.btnWASave.Location = new System.Drawing.Point(153, 438);
            this.btnWASave.Name = "btnWASave";
            this.btnWASave.Size = new System.Drawing.Size(124, 38);
            this.btnWASave.TabIndex = 11;
            this.btnWASave.Text = "전체저장";
            this.btnWASave.UseVisualStyleBackColor = true;
            this.btnWASave.Click += new System.EventHandler(this.btnWASave_Click);
            // 
            // btnWPath
            // 
            this.btnWPath.Location = new System.Drawing.Point(23, 438);
            this.btnWPath.Name = "btnWPath";
            this.btnWPath.Size = new System.Drawing.Size(124, 38);
            this.btnWPath.TabIndex = 10;
            this.btnWPath.Text = "파일";
            this.btnWPath.UseVisualStyleBackColor = true;
            this.btnWPath.Click += new System.EventHandler(this.btnWPath_Click);
            // 
            // txtWView
            // 
            this.txtWView.Location = new System.Drawing.Point(23, 68);
            this.txtWView.Multiline = true;
            this.txtWView.Name = "txtWView";
            this.txtWView.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtWView.Size = new System.Drawing.Size(838, 352);
            this.txtWView.TabIndex = 9;
            // 
            // txtWPath
            // 
            this.txtWPath.Location = new System.Drawing.Point(23, 21);
            this.txtWPath.Name = "txtWPath";
            this.txtWPath.ReadOnly = true;
            this.txtWPath.Size = new System.Drawing.Size(838, 26);
            this.txtWPath.TabIndex = 5;
            // 
            // ofdFile
            // 
            this.ofdFile.FileName = "openFileDialog1";
            this.ofdFile.Filter = "텍스트 파일(*.txt)|*.txt|모든 파일(*.*)|*.*";
            // 
            // sfdFile
            // 
            this.sfdFile.Filter = "텍스트 파일(*.txt)|*.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 536);
            this.Controls.Add(this.tabMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "문자 입출력";
            this.tabMenu.ResumeLayout(false);
            this.tpRead.ResumeLayout(false);
            this.tpRead.PerformLayout();
            this.tpWrite.ResumeLayout(false);
            this.tpWrite.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage tpRead;
        private System.Windows.Forms.TabPage tpWrite;
        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.Windows.Forms.SaveFileDialog sfdFile;
        private System.Windows.Forms.Button btnRLRead;
        private System.Windows.Forms.Button btnRARead;
        private System.Windows.Forms.Button btnRPath;
        private System.Windows.Forms.TextBox txtRView;
        private System.Windows.Forms.TextBox txtRPath;
        private System.Windows.Forms.TextBox txtWView;
        private System.Windows.Forms.TextBox txtWPath;
        private System.Windows.Forms.Button btnWLSave;
        private System.Windows.Forms.Button btnWASave;
        private System.Windows.Forms.Button btnWPath;
    }
}

