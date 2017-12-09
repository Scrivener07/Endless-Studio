namespace Sharp.Applications.Controls
{
	partial class ProgressWidget
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.c_ProgressBar = new System.Windows.Forms.ProgressBar();
			this.c_ProgressLabel = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// c_ProgressBar
			// 
			this.c_ProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c_ProgressBar.Location = new System.Drawing.Point(3, 3);
			this.c_ProgressBar.MaximumSize = new System.Drawing.Size(0, 20);
			this.c_ProgressBar.MinimumSize = new System.Drawing.Size(200, 20);
			this.c_ProgressBar.Name = "c_ProgressBar";
			this.c_ProgressBar.Size = new System.Drawing.Size(200, 20);
			this.c_ProgressBar.Step = 1;
			this.c_ProgressBar.TabIndex = 0;
			// 
			// c_ProgressLabel
			// 
			this.c_ProgressLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.c_ProgressLabel.AutoSize = true;
			this.c_ProgressLabel.Location = new System.Drawing.Point(73, 32);
			this.c_ProgressLabel.Margin = new System.Windows.Forms.Padding(6);
			this.c_ProgressLabel.MinimumSize = new System.Drawing.Size(0, 13);
			this.c_ProgressLabel.Name = "c_ProgressLabel";
			this.c_ProgressLabel.Size = new System.Drawing.Size(59, 13);
			this.c_ProgressLabel.TabIndex = 1;
			this.c_ProgressLabel.Text = "Progress %";
			this.c_ProgressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.c_ProgressLabel.TextChanged += new System.EventHandler(this.ProgressLabel_OnTextChanged);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.c_ProgressLabel, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.c_ProgressBar, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(206, 51);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// ProgressWidget
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Controls.Add(this.tableLayoutPanel1);
			this.MinimumSize = new System.Drawing.Size(100, 20);
			this.Name = "ProgressWidget";
			this.Size = new System.Drawing.Size(206, 51);
			this.Load += new System.EventHandler(this.OnLoad);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ProgressBar c_ProgressBar;
		private System.Windows.Forms.Label c_ProgressLabel;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}
