namespace Studio.Presentation
{
	partial class DatabaseControlSelected
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
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.c_SelectedLabel = new System.Windows.Forms.ToolStripLabel();
			this.c_ToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.c_TabelLabel = new System.Windows.Forms.ToolStripLabel();
			this.c_RecordLabel = new System.Windows.Forms.ToolStripLabel();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.c_SelectedLabel,
            this.c_ToolStripSeparator,
            this.c_TabelLabel,
            this.c_RecordLabel});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(200, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "c_ToolStrip";
			// 
			// c_SelectedLabel
			// 
			this.c_SelectedLabel.Name = "c_SelectedLabel";
			this.c_SelectedLabel.Size = new System.Drawing.Size(51, 22);
			this.c_SelectedLabel.Text = "Selected";
			// 
			// c_ToolStripSeparator
			// 
			this.c_ToolStripSeparator.Name = "c_ToolStripSeparator";
			this.c_ToolStripSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// c_TabelLabel
			// 
			this.c_TabelLabel.Enabled = false;
			this.c_TabelLabel.Name = "c_TabelLabel";
			this.c_TabelLabel.Size = new System.Drawing.Size(33, 22);
			this.c_TabelLabel.Text = "table";
			// 
			// c_RecordLabel
			// 
			this.c_RecordLabel.Enabled = false;
			this.c_RecordLabel.Name = "c_RecordLabel";
			this.c_RecordLabel.Size = new System.Drawing.Size(41, 22);
			this.c_RecordLabel.Text = "record";
			// 
			// DatabaseControlSelected
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Controls.Add(this.toolStrip1);
			this.MinimumSize = new System.Drawing.Size(200, 25);
			this.Name = "DatabaseControlSelected";
			this.Size = new System.Drawing.Size(200, 25);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripLabel c_SelectedLabel;
		private System.Windows.Forms.ToolStripSeparator c_ToolStripSeparator;
		private System.Windows.Forms.ToolStripLabel c_TabelLabel;
		private System.Windows.Forms.ToolStripLabel c_RecordLabel;
	}
}
