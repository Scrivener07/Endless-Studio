using Studio.Presentation;

namespace Studio.Presentation
{
	partial class MainForm
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
			this.c_DatabaseControl = new Studio.Presentation.DatabaseControl();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.ModificationTabPage = new System.Windows.Forms.TabPage();
			this.DatabaseTabPage = new System.Windows.Forms.TabPage();
			this.tabControl1.SuspendLayout();
			this.DatabaseTabPage.SuspendLayout();
			this.SuspendLayout();
			// 
			// c_DatabaseControl
			// 
			this.c_DatabaseControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c_DatabaseControl.Location = new System.Drawing.Point(3, 3);
			this.c_DatabaseControl.Name = "c_DatabaseControl";
			this.c_DatabaseControl.Size = new System.Drawing.Size(895, 738);
			this.c_DatabaseControl.TabIndex = 0;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.ModificationTabPage);
			this.tabControl1.Controls.Add(this.DatabaseTabPage);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(909, 770);
			this.tabControl1.TabIndex = 1;
			// 
			// ModificationTabPage
			// 
			this.ModificationTabPage.Location = new System.Drawing.Point(4, 22);
			this.ModificationTabPage.Name = "ModificationTabPage";
			this.ModificationTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.ModificationTabPage.Size = new System.Drawing.Size(901, 744);
			this.ModificationTabPage.TabIndex = 1;
			this.ModificationTabPage.Text = "Modifications";
			this.ModificationTabPage.UseVisualStyleBackColor = true;
			// 
			// DatabaseTabPage
			// 
			this.DatabaseTabPage.Controls.Add(this.c_DatabaseControl);
			this.DatabaseTabPage.Location = new System.Drawing.Point(4, 22);
			this.DatabaseTabPage.Name = "DatabaseTabPage";
			this.DatabaseTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.DatabaseTabPage.Size = new System.Drawing.Size(901, 744);
			this.DatabaseTabPage.TabIndex = 0;
			this.DatabaseTabPage.Text = "Databases";
			this.DatabaseTabPage.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(909, 770);
			this.Controls.Add(this.tabControl1);
			this.Name = "MainForm";
			this.Text = "Studio";
			this.Load += new System.EventHandler(this.OnLoad);
			this.tabControl1.ResumeLayout(false);
			this.DatabaseTabPage.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private DatabaseControl c_DatabaseControl;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage DatabaseTabPage;
		private System.Windows.Forms.TabPage ModificationTabPage;
	}
}

