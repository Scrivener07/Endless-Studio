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
			this.messageWidget1 = new Sharp.Applications.Messages.MessageWidget();
			this.SuspendLayout();
			// 
			// messageWidget1
			// 
			this.messageWidget1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.messageWidget1.Location = new System.Drawing.Point(0, 0);
			this.messageWidget1.Name = "messageWidget1";
			this.messageWidget1.Size = new System.Drawing.Size(459, 362);
			this.messageWidget1.TabIndex = 0;
			// 
			// MessageWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(459, 362);
			this.Controls.Add(this.messageWidget1);
			this.Name = "MessageWindow";
			this.Text = "Messages";
			this.ResumeLayout(false);

		}

		#endregion

		private Sharp.Applications.Messages.MessageWidget messageWidget1;
	}
}