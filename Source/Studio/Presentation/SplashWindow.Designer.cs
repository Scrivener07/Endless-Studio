namespace Studio.Presentation
{
	partial class SplashWindow
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashWindow));
			this.Picture = new System.Windows.Forms.PictureBox();
			this.c_ProgressBar = new System.Windows.Forms.ProgressBar();
			((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
			this.SuspendLayout();
			// 
			// Ticker
			// 
			this.Ticker.Enabled = true;
			// 
			// SplashProgress
			// 
			this.SplashProgress.Location = new System.Drawing.Point(1, 262);
			this.SplashProgress.Size = new System.Drawing.Size(365, 10);
			// 
			// Picture
			// 
			this.Picture.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Picture.Image = ((System.Drawing.Image)(resources.GetObject("Picture.Image")));
			this.Picture.Location = new System.Drawing.Point(1, 29);
			this.Picture.Name = "Picture";
			this.Picture.Size = new System.Drawing.Size(365, 233);
			this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.Picture.TabIndex = 2;
			this.Picture.TabStop = false;
			// 
			// c_ProgressBar
			// 
			this.c_ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.c_ProgressBar.Location = new System.Drawing.Point(3, 256);
			this.c_ProgressBar.MarqueeAnimationSpeed = 15;
			this.c_ProgressBar.Name = "c_ProgressBar";
			this.c_ProgressBar.Size = new System.Drawing.Size(294, 10);
			this.c_ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
			this.c_ProgressBar.TabIndex = 5;
			// 
			// SplashWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(367, 307);
			this.Controls.Add(this.Picture);
			this.Name = "SplashWindow";
			this.Text = "SplashWindow";
			this.Controls.SetChildIndex(this.SplashProgress, 0);
			this.Controls.SetChildIndex(this.Picture, 0);
			((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox Picture;
		private System.Windows.Forms.ProgressBar c_ProgressBar;
	}
}