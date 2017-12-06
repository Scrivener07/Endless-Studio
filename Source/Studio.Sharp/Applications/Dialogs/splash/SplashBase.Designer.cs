namespace Sharp.Applications.Dialogs
{
	partial class SplashBase
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
			this.components = new System.ComponentModel.Container();
			this.Ticker = new System.Windows.Forms.Timer(this.components);
			this.SplashProgress = new System.Windows.Forms.ProgressBar();
			this.TitleStrip = new System.Windows.Forms.ToolStrip();
			this.TitleLabel = new System.Windows.Forms.ToolStripLabel();
			this.MessageStrip = new System.Windows.Forms.ToolStrip();
			this.MessageLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.MessageLabel2 = new System.Windows.Forms.ToolStripLabel();
			this.TitleStrip.SuspendLayout();
			this.MessageStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// Ticker
			// 
			this.Ticker.Interval = 50;
			this.Ticker.Tick += new System.EventHandler(this.OnTick);
			// 
			// SplashProgress
			// 
			this.SplashProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.SplashProgress.Location = new System.Drawing.Point(1, 179);
			this.SplashProgress.MarqueeAnimationSpeed = 15;
			this.SplashProgress.Name = "SplashProgress";
			this.SplashProgress.Size = new System.Drawing.Size(361, 10);
			this.SplashProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
			this.SplashProgress.TabIndex = 6;
			// 
			// TitleStrip
			// 
			this.TitleStrip.BackColor = System.Drawing.Color.Transparent;
			this.TitleStrip.Font = new System.Drawing.Font("Segoe UI", 14F);
			this.TitleStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.TitleStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.TitleLabel});
			this.TitleStrip.Location = new System.Drawing.Point(1, 1);
			this.TitleStrip.Name = "TitleStrip";
			this.TitleStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.TitleStrip.Size = new System.Drawing.Size(361, 28);
			this.TitleStrip.TabIndex = 9;
			this.TitleStrip.Text = "ToolStrip";
			// 
			// TitleLabel
			// 
			this.TitleLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new System.Drawing.Size(48, 25);
			this.TitleLabel.Text = "Title";
			// 
			// MessageStrip
			// 
			this.MessageStrip.BackColor = System.Drawing.Color.Transparent;
			this.MessageStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.MessageStrip.Font = new System.Drawing.Font("Segoe UI", 14F);
			this.MessageStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.MessageStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.MessageLabel1,
			this.MessageLabel2});
			this.MessageStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
			this.MessageStrip.Location = new System.Drawing.Point(1, 189);
			this.MessageStrip.Name = "MessageStrip";
			this.MessageStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.MessageStrip.Size = new System.Drawing.Size(361, 34);
			this.MessageStrip.TabIndex = 10;
			this.MessageStrip.Text = "ToolStrip";
			// 
			// MessageLabel1
			// 
			this.MessageLabel1.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.MessageLabel1.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.MessageLabel1.Name = "MessageLabel1";
			this.MessageLabel1.Size = new System.Drawing.Size(359, 13);
			this.MessageLabel1.Text = "Message 1";
			this.MessageLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// MessageLabel2
			// 
			this.MessageLabel2.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.MessageLabel2.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.MessageLabel2.Name = "MessageLabel2";
			this.MessageLabel2.Size = new System.Drawing.Size(359, 13);
			this.MessageLabel2.Text = "Message 2";
			this.MessageLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// SplashBase
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(363, 224);
			this.Controls.Add(this.TitleStrip);
			this.Controls.Add(this.SplashProgress);
			this.Controls.Add(this.MessageStrip);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "SplashBase";
			this.Padding = new System.Windows.Forms.Padding(1);
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SplashBase";
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			this.Load += new System.EventHandler(this.OnLoad);
			this.TitleStrip.ResumeLayout(false);
			this.TitleStrip.PerformLayout();
			this.MessageStrip.ResumeLayout(false);
			this.MessageStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		protected System.Windows.Forms.Timer Ticker;
		protected System.Windows.Forms.ProgressBar SplashProgress;
		protected System.Windows.Forms.ToolStrip MessageStrip;
		protected System.Windows.Forms.ToolStrip TitleStrip;
		protected System.Windows.Forms.ToolStripLabel TitleLabel;
		protected System.Windows.Forms.ToolStripLabel MessageLabel1;
		protected System.Windows.Forms.ToolStripLabel MessageLabel2;
	}
}