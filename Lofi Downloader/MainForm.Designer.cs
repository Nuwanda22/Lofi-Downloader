namespace Lofi_Downloader
{
	partial class MainForm
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.findButton = new System.Windows.Forms.Button();
			this.downloadButton = new System.Windows.Forms.Button();
			this.allProgressBar = new System.Windows.Forms.ProgressBar();
			this.thisProgressBar = new System.Windows.Forms.ProgressBar();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.allProgressLabel = new System.Windows.Forms.Label();
			this.thisProgressLabel = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.gettingImageProgressBar = new System.Windows.Forms.ProgressBar();
			this.gettingImageLabel = new System.Windows.Forms.Label();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.ImageLocation = "http://img.naver.net/static/www/u/2013/0731/nmms_224940510.gif";
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(265, 237);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(283, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(381, 21);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "http://lofi.e-hentai.org/g/930457/b6c426b0f9/";
			// 
			// findButton
			// 
			this.findButton.Location = new System.Drawing.Point(502, 226);
			this.findButton.Name = "findButton";
			this.findButton.Size = new System.Drawing.Size(75, 23);
			this.findButton.TabIndex = 2;
			this.findButton.Text = "Find";
			this.findButton.UseVisualStyleBackColor = true;
			this.findButton.Click += new System.EventHandler(this.findButton_Click);
			// 
			// downloadButton
			// 
			this.downloadButton.Location = new System.Drawing.Point(589, 226);
			this.downloadButton.Name = "downloadButton";
			this.downloadButton.Size = new System.Drawing.Size(75, 23);
			this.downloadButton.TabIndex = 3;
			this.downloadButton.Text = "Download";
			this.downloadButton.UseVisualStyleBackColor = true;
			this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
			// 
			// allProgressBar
			// 
			this.allProgressBar.Location = new System.Drawing.Point(283, 116);
			this.allProgressBar.Name = "allProgressBar";
			this.allProgressBar.Size = new System.Drawing.Size(381, 23);
			this.allProgressBar.TabIndex = 4;
			// 
			// thisProgressBar
			// 
			this.thisProgressBar.Location = new System.Drawing.Point(283, 173);
			this.thisProgressBar.Name = "thisProgressBar";
			this.thisProgressBar.Size = new System.Drawing.Size(381, 23);
			this.thisProgressBar.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(283, 101);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 12);
			this.label1.TabIndex = 6;
			this.label1.Text = "All Progress";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(281, 158);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 12);
			this.label2.TabIndex = 7;
			this.label2.Text = "This Progress";
			// 
			// allProgressLabel
			// 
			this.allProgressLabel.Location = new System.Drawing.Point(591, 142);
			this.allProgressLabel.Name = "allProgressLabel";
			this.allProgressLabel.Size = new System.Drawing.Size(73, 12);
			this.allProgressLabel.TabIndex = 8;
			this.allProgressLabel.Text = "( 0 / 100 )";
			this.allProgressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// thisProgressLabel
			// 
			this.thisProgressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.thisProgressLabel.Location = new System.Drawing.Point(608, 199);
			this.thisProgressLabel.Name = "thisProgressLabel";
			this.thisProgressLabel.Size = new System.Drawing.Size(56, 12);
			this.thisProgressLabel.TabIndex = 9;
			this.thisProgressLabel.Text = "( 0 % )";
			this.thisProgressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(283, 44);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(83, 12);
			this.label5.TabIndex = 10;
			this.label5.Text = "Getting Image";
			// 
			// gettingImageProgressBar
			// 
			this.gettingImageProgressBar.Location = new System.Drawing.Point(283, 59);
			this.gettingImageProgressBar.Name = "gettingImageProgressBar";
			this.gettingImageProgressBar.Size = new System.Drawing.Size(381, 23);
			this.gettingImageProgressBar.TabIndex = 11;
			// 
			// gettingImageLabel
			// 
			this.gettingImageLabel.Location = new System.Drawing.Point(591, 85);
			this.gettingImageLabel.Name = "gettingImageLabel";
			this.gettingImageLabel.Size = new System.Drawing.Size(73, 12);
			this.gettingImageLabel.TabIndex = 12;
			this.gettingImageLabel.Text = "( 0 / 100 )";
			this.gettingImageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(676, 261);
			this.Controls.Add(this.gettingImageLabel);
			this.Controls.Add(this.gettingImageProgressBar);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.thisProgressLabel);
			this.Controls.Add(this.allProgressLabel);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.thisProgressBar);
			this.Controls.Add(this.allProgressBar);
			this.Controls.Add(this.downloadButton);
			this.Controls.Add(this.findButton);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "MainForm";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button findButton;
		private System.Windows.Forms.Button downloadButton;
		private System.Windows.Forms.ProgressBar allProgressBar;
		private System.Windows.Forms.ProgressBar thisProgressBar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label allProgressLabel;
		private System.Windows.Forms.Label thisProgressLabel;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ProgressBar gettingImageProgressBar;
		private System.Windows.Forms.Label gettingImageLabel;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
	}
}

