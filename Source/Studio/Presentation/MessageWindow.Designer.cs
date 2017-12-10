namespace Studio.Presentation
{
	partial class MessageWindow
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.messageWidget1 = new Sharp.Applications.Messages.MessageWidget();
			this.messageStatusStrip1 = new Studio.Presentation.MessageStatusStrip();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.messageWidget1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.messageStatusStrip1, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(406, 176);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// messageWidget1
			// 
			this.messageWidget1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.messageWidget1.Location = new System.Drawing.Point(3, 3);
			this.messageWidget1.Name = "messageWidget1";
			this.messageWidget1.Size = new System.Drawing.Size(400, 139);
			this.messageWidget1.TabIndex = 0;
			// 
			// messageStatusStrip1
			// 
			this.messageStatusStrip1.AutoSize = true;
			this.messageStatusStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.messageStatusStrip1.Location = new System.Drawing.Point(3, 148);
			this.messageStatusStrip1.MinimumSize = new System.Drawing.Size(50, 25);
			this.messageStatusStrip1.Name = "messageStatusStrip1";
			this.messageStatusStrip1.Size = new System.Drawing.Size(400, 25);
			this.messageStatusStrip1.TabIndex = 1;
			// 
			// MessageWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(406, 176);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "MessageWindow";
			this.Text = "Messages";
			this.Load += new System.EventHandler(this.MessageWindow_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Sharp.Applications.Messages.MessageWidget messageWidget1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private MessageStatusStrip messageStatusStrip1;
	}
}