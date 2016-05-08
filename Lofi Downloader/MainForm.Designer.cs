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
			this.pictureBox1.Location = new System.Drawing.Point(17, 18);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(379, 356);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(404, 18);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(543, 28);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "http://lofi.e-hentai.org/g/930457/b6c426b0f9/";
			// 
			// findButton
			// 
			this.findButton.Location = new System.Drawing.Point(725, 339);
			this.findButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.findButton.Name = "findButton";
			this.findButton.Size = new System.Drawing.Size(107, 34);
			this.findButton.TabIndex = 2;
			this.findButton.Text = "Find";
			this.findButton.UseVisualStyleBackColor = true;
			this.findButton.Click += new System.EventHandler(this.findButton_Click);
			// 
			// downloadButton
			// 
			this.downloadButton.Location = new System.Drawing.Point(840, 339);
			this.downloadButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.downloadButton.Name = "downloadButton";
			this.downloadButton.Size = new System.Drawing.Size(107, 34);
			this.downloadButton.TabIndex = 3;
			this.downloadButton.Text = "Download";
			this.downloadButton.UseVisualStyleBackColor = true;
			this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
			// 
			// allProgressBar
			// 
			this.allProgressBar.Location = new System.Drawing.Point(404, 174);
			this.allProgressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.allProgressBar.Name = "allProgressBar";
			this.allProgressBar.Size = new System.Drawing.Size(544, 34);
			this.allProgressBar.TabIndex = 4;
			// 
			// thisProgressBar
			// 
			this.thisProgressBar.Location = new System.Drawing.Point(404, 260);
			this.thisProgressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.thisProgressBar.Name = "thisProgressBar";
			this.thisProgressBar.Size = new System.Drawing.Size(544, 34);
			this.thisProgressBar.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(404, 152);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(106, 18);
			this.label1.TabIndex = 6;
			this.label1.Text = "All Progress";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(401, 237);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(121, 18);
			this.label2.TabIndex = 7;
			this.label2.Text = "This Progress";
			// 
			// allProgressLabel
			// 
			this.allProgressLabel.Location = new System.Drawing.Point(844, 213);
			this.allProgressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.allProgressLabel.Name = "allProgressLabel";
			this.allProgressLabel.Size = new System.Drawing.Size(104, 18);
			this.allProgressLabel.TabIndex = 8;
			this.allProgressLabel.Text = "( 0 / 100 )";
			this.allProgressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.allProgressLabel.Visible = false;
			// 
			// thisProgressLabel
			// 
			this.thisProgressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.thisProgressLabel.Location = new System.Drawing.Point(869, 298);
			this.thisProgressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.thisProgressLabel.Name = "thisProgressLabel";
			this.thisProgressLabel.Size = new System.Drawing.Size(80, 18);
			this.thisProgressLabel.TabIndex = 9;
			this.thisProgressLabel.Text = "( 0 % )";
			this.thisProgressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.thisProgressLabel.Visible = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(404, 66);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(117, 18);
			this.label5.TabIndex = 10;
			this.label5.Text = "Getting Image";
			// 
			// gettingImageProgressBar
			// 
			this.gettingImageProgressBar.Location = new System.Drawing.Point(404, 88);
			this.gettingImageProgressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.gettingImageProgressBar.Name = "gettingImageProgressBar";
			this.gettingImageProgressBar.Size = new System.Drawing.Size(544, 34);
			this.gettingImageProgressBar.TabIndex = 11;
			// 
			// gettingImageLabel
			// 
			this.gettingImageLabel.Location = new System.Drawing.Point(844, 128);
			this.gettingImageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.gettingImageLabel.Name = "gettingImageLabel";
			this.gettingImageLabel.Size = new System.Drawing.Size(104, 18);
			this.gettingImageLabel.TabIndex = 12;
			this.gettingImageLabel.Text = "( 0 / 100 )";
			this.gettingImageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.gettingImageLabel.Visible = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(966, 392);
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
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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

