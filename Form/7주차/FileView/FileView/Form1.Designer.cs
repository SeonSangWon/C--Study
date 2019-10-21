namespace FileView
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
            this.lblPath = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnPath = new System.Windows.Forms.Button();
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            this.rbtnHidden = new System.Windows.Forms.RadioButton();
            this.lvFile = new System.Windows.Forms.ListView();
            this.fbdFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.ssBar = new System.Windows.Forms.StatusStrip();
            this.chFilePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFileTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFileSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tsslblResult = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(49, 29);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(42, 21);
            this.lblPath.TabIndex = 0;
            this.lblPath.Text = "경로";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(93, 27);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(490, 29);
            this.txtPath.TabIndex = 1;
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(601, 27);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(100, 29);
            this.btnPath.TabIndex = 2;
            this.btnPath.Text = "경로";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // rbtnAll
            // 
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.Checked = true;
            this.rbtnAll.Location = new System.Drawing.Point(92, 76);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Size = new System.Drawing.Size(92, 25);
            this.rbtnAll.TabIndex = 3;
            this.rbtnAll.TabStop = true;
            this.rbtnAll.Text = "전체파일";
            this.rbtnAll.UseVisualStyleBackColor = true;
            this.rbtnAll.CheckedChanged += new System.EventHandler(this.rbtnAll_CheckedChanged);
            // 
            // rbtnHidden
            // 
            this.rbtnHidden.AutoSize = true;
            this.rbtnHidden.Location = new System.Drawing.Point(204, 76);
            this.rbtnHidden.Name = "rbtnHidden";
            this.rbtnHidden.Size = new System.Drawing.Size(92, 25);
            this.rbtnHidden.TabIndex = 4;
            this.rbtnHidden.Text = "숨김파일";
            this.rbtnHidden.UseVisualStyleBackColor = true;
            this.rbtnHidden.CheckedChanged += new System.EventHandler(this.rbtnHidden_CheckedChanged);
            // 
            // lvFile
            // 
            this.lvFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFilePath,
            this.chFileName,
            this.chFileTime,
            this.chFileSize});
            this.lvFile.GridLines = true;
            this.lvFile.HideSelection = false;
            this.lvFile.Location = new System.Drawing.Point(13, 109);
            this.lvFile.Name = "lvFile";
            this.lvFile.Size = new System.Drawing.Size(761, 324);
            this.lvFile.TabIndex = 5;
            this.lvFile.UseCompatibleStateImageBehavior = false;
            this.lvFile.View = System.Windows.Forms.View.Details;
            // 
            // ssBar
            // 
            this.ssBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblResult});
            this.ssBar.Location = new System.Drawing.Point(0, 437);
            this.ssBar.Name = "ssBar";
            this.ssBar.Size = new System.Drawing.Size(785, 22);
            this.ssBar.TabIndex = 6;
            this.ssBar.Text = "statusStrip1";
            // 
            // chFilePath
            // 
            this.chFilePath.Text = "경로";
            this.chFilePath.Width = 355;
            // 
            // chFileName
            // 
            this.chFileName.Text = "이름";
            this.chFileName.Width = 150;
            // 
            // chFileTime
            // 
            this.chFileTime.Text = "수정한 날짜";
            this.chFileTime.Width = 150;
            // 
            // chFileSize
            // 
            this.chFileSize.Text = "크기";
            this.chFileSize.Width = 100;
            // 
            // tsslblResult
            // 
            this.tsslblResult.Name = "tsslblResult";
            this.tsslblResult.Size = new System.Drawing.Size(122, 17);
            this.tsslblResult.Text = "폴더 : 0개, 파일 : 0개";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 459);
            this.Controls.Add(this.ssBar);
            this.Controls.Add(this.lvFile);
            this.Controls.Add(this.rbtnHidden);
            this.Controls.Add(this.rbtnAll);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lblPath);
            this.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "파일 보기";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ssBar.ResumeLayout(false);
            this.ssBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.RadioButton rbtnAll;
        private System.Windows.Forms.RadioButton rbtnHidden;
        private System.Windows.Forms.ListView lvFile;
        private System.Windows.Forms.FolderBrowserDialog fbdFolder;
        private System.Windows.Forms.StatusStrip ssBar;
        private System.Windows.Forms.ColumnHeader chFilePath;
        private System.Windows.Forms.ColumnHeader chFileName;
        private System.Windows.Forms.ColumnHeader chFileTime;
        private System.Windows.Forms.ColumnHeader chFileSize;
        private System.Windows.Forms.ToolStripStatusLabel tsslblResult;
    }
}

