namespace Studio.Presentation
{
	partial class MessageStatusStrip
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageStatusStrip));
			this.c_MessageToolStrip = new System.Windows.Forms.ToolStrip();
			this.c_MessageHistoryDropDown = new System.Windows.Forms.ToolStripDropDownButton();
			this.c_MessageHistoryClearButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.c_MessageLabel = new System.Windows.Forms.ToolStripLabel();
			this.c_MessageToolStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// c_MessageToolStrip
			// 
			this.c_MessageToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.c_MessageToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.c_MessageHistoryDropDown,
            this.c_MessageHistoryClearButton,
            this.toolStripSeparator1,
            this.c_MessageLabel});
			this.c_MessageToolStrip.Location = new System.Drawing.Point(0, 0);
			this.c_MessageToolStrip.Name = "c_MessageToolStrip";
			this.c_MessageToolStrip.Size = new System.Drawing.Size(175, 25);
			this.c_MessageToolStrip.Stretch = true;
			this.c_MessageToolStrip.TabIndex = 6;
			this.c_MessageToolStrip.Text = "ToolStrip";
			this.c_MessageToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolStrip_OnItemClicked);
			// 
			// c_MessageHistoryDropDown
			// 
			this.c_MessageHistoryDropDown.Image = ((System.Drawing.Image)(resources.GetObject("c_MessageHistoryDropDown.Image")));
			this.c_MessageHistoryDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.c_MessageHistoryDropDown.Name = "c_MessageHistoryDropDown";
			this.c_MessageHistoryDropDown.Size = new System.Drawing.Size(29, 22);
			// 
			// c_MessageHistoryClearButton
			// 
			this.c_MessageHistoryClearButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.c_MessageHistoryClearButton.Enabled = false;
			this.c_MessageHistoryClearButton.Image = ((System.Drawing.Image)(resources.GetObject("c_MessageHistoryClearButton.Image")));
			this.c_MessageHistoryClearButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.c_MessageHistoryClearButton.Name = "c_MessageHistoryClearButton";
			this.c_MessageHistoryClearButton.Size = new System.Drawing.Size(23, 22);
			this.c_MessageHistoryClearButton.Text = "Text";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// c_MessageLabel
			// 
			this.c_MessageLabel.ForeColor = System.Drawing.SystemColors.GrayText;
			this.c_MessageLabel.Name = "c_MessageLabel";
			this.c_MessageLabel.Size = new System.Drawing.Size(58, 22);
			this.c_MessageLabel.Text = "MESSAGE";
			// 
			// MessageStatusStrip
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.c_MessageToolStrip);
			this.MinimumSize = new System.Drawing.Size(50, 25);
			this.Name = "MessageStatusStrip";
			this.Size = new System.Drawing.Size(175, 36);
			this.Load += new System.EventHandler(this.OnLoad);
			this.c_MessageToolStrip.ResumeLayout(false);
			this.c_MessageToolStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip c_MessageToolStrip;
		private System.Windows.Forms.ToolStripDropDownButton c_MessageHistoryDropDown;
		private System.Windows.Forms.ToolStripButton c_MessageHistoryClearButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripLabel c_MessageLabel;
	}
}
