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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.Main_TabControl = new System.Windows.Forms.TabControl();
			this.MainProject_TabPage = new System.Windows.Forms.TabPage();
			this.MainDatabases_TabPage = new System.Windows.Forms.TabPage();
			this.Main_OpenButton = new System.Windows.Forms.Button();
			this.Main_SaveButton = new System.Windows.Forms.Button();
			this.Main_MenuStrip = new System.Windows.Forms.MenuStrip();
			this.File_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.FileNew_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.FileOpen_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.FileExit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.View_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ViewMessages_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.databaseControl1 = new Studio.Presentation.DatabaseControl();
			this.Main_TabControl.SuspendLayout();
			this.MainDatabases_TabPage.SuspendLayout();
			this.Main_MenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// Main_TabControl
			// 
			this.Main_TabControl.Controls.Add(this.MainProject_TabPage);
			this.Main_TabControl.Controls.Add(this.MainDatabases_TabPage);
			this.Main_TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Main_TabControl.Location = new System.Drawing.Point(0, 24);
			this.Main_TabControl.Name = "Main_TabControl";
			this.Main_TabControl.SelectedIndex = 0;
			this.Main_TabControl.Size = new System.Drawing.Size(634, 588);
			this.Main_TabControl.TabIndex = 1;
			// 
			// MainProject_TabPage
			// 
			this.MainProject_TabPage.Location = new System.Drawing.Point(4, 22);
			this.MainProject_TabPage.Name = "MainProject_TabPage";
			this.MainProject_TabPage.Padding = new System.Windows.Forms.Padding(3);
			this.MainProject_TabPage.Size = new System.Drawing.Size(626, 562);
			this.MainProject_TabPage.TabIndex = 0;
			this.MainProject_TabPage.Text = "Project";
			this.MainProject_TabPage.UseVisualStyleBackColor = true;
			// 
			// MainDatabases_TabPage
			// 
			this.MainDatabases_TabPage.Controls.Add(this.databaseControl1);
			this.MainDatabases_TabPage.Location = new System.Drawing.Point(4, 22);
			this.MainDatabases_TabPage.Name = "MainDatabases_TabPage";
			this.MainDatabases_TabPage.Padding = new System.Windows.Forms.Padding(3);
			this.MainDatabases_TabPage.Size = new System.Drawing.Size(626, 562);
			this.MainDatabases_TabPage.TabIndex = 1;
			this.MainDatabases_TabPage.Text = "Databases";
			this.MainDatabases_TabPage.UseVisualStyleBackColor = true;
			// 
			// Main_OpenButton
			// 
			this.Main_OpenButton.Location = new System.Drawing.Point(93, 0);
			this.Main_OpenButton.Name = "Main_OpenButton";
			this.Main_OpenButton.Size = new System.Drawing.Size(75, 23);
			this.Main_OpenButton.TabIndex = 2;
			this.Main_OpenButton.Text = "Open";
			this.Main_OpenButton.UseVisualStyleBackColor = true;
			this.Main_OpenButton.Click += new System.EventHandler(this.Main_OpenButton_Click);
			// 
			// Main_SaveButton
			// 
			this.Main_SaveButton.Location = new System.Drawing.Point(174, 0);
			this.Main_SaveButton.Name = "Main_SaveButton";
			this.Main_SaveButton.Size = new System.Drawing.Size(75, 23);
			this.Main_SaveButton.TabIndex = 0;
			this.Main_SaveButton.Text = "Save";
			this.Main_SaveButton.UseVisualStyleBackColor = true;
			this.Main_SaveButton.Click += new System.EventHandler(this.Main_SaveButton_Click);
			// 
			// Main_MenuStrip
			// 
			this.Main_MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_ToolStripMenuItem,
            this.View_ToolStripMenuItem});
			this.Main_MenuStrip.Location = new System.Drawing.Point(0, 0);
			this.Main_MenuStrip.Name = "Main_MenuStrip";
			this.Main_MenuStrip.Size = new System.Drawing.Size(634, 24);
			this.Main_MenuStrip.TabIndex = 2;
			this.Main_MenuStrip.Text = "menuStrip1";
			// 
			// File_ToolStripMenuItem
			// 
			this.File_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileNew_ToolStripMenuItem,
            this.FileOpen_ToolStripMenuItem,
            this.toolStripSeparator1,
            this.FileExit_ToolStripMenuItem});
			this.File_ToolStripMenuItem.Name = "File_ToolStripMenuItem";
			this.File_ToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.File_ToolStripMenuItem.Text = "&File";
			// 
			// FileNew_ToolStripMenuItem
			// 
			this.FileNew_ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("FileNew_ToolStripMenuItem.Image")));
			this.FileNew_ToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.FileNew_ToolStripMenuItem.Name = "FileNew_ToolStripMenuItem";
			this.FileNew_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.FileNew_ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.FileNew_ToolStripMenuItem.Text = "&New";
			this.FileNew_ToolStripMenuItem.Click += new System.EventHandler(this.FileNew_ToolStripMenuItem_OnClick);
			// 
			// FileOpen_ToolStripMenuItem
			// 
			this.FileOpen_ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("FileOpen_ToolStripMenuItem.Image")));
			this.FileOpen_ToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.FileOpen_ToolStripMenuItem.Name = "FileOpen_ToolStripMenuItem";
			this.FileOpen_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.FileOpen_ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.FileOpen_ToolStripMenuItem.Text = "&Open";
			this.FileOpen_ToolStripMenuItem.Click += new System.EventHandler(this.FileOpen_ToolStripMenuItem_OnClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
			// 
			// FileExit_ToolStripMenuItem
			// 
			this.FileExit_ToolStripMenuItem.Name = "FileExit_ToolStripMenuItem";
			this.FileExit_ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.FileExit_ToolStripMenuItem.Text = "E&xit";
			this.FileExit_ToolStripMenuItem.Click += new System.EventHandler(this.FileExit_ToolStripMenuItem_OnClick);
			// 
			// View_ToolStripMenuItem
			// 
			this.View_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewMessages_ToolStripMenuItem});
			this.View_ToolStripMenuItem.Name = "View_ToolStripMenuItem";
			this.View_ToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.View_ToolStripMenuItem.Text = "View";
			// 
			// ViewMessages_ToolStripMenuItem
			// 
			this.ViewMessages_ToolStripMenuItem.Name = "ViewMessages_ToolStripMenuItem";
			this.ViewMessages_ToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.ViewMessages_ToolStripMenuItem.Text = "Messages";
			this.ViewMessages_ToolStripMenuItem.Click += new System.EventHandler(this.ViewMessages_ToolStripMenuItem_OnClick);
			// 
			// databaseControl1
			// 
			this.databaseControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.databaseControl1.Location = new System.Drawing.Point(3, 3);
			this.databaseControl1.Name = "databaseControl1";
			this.databaseControl1.Size = new System.Drawing.Size(620, 556);
			this.databaseControl1.TabIndex = 3;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(634, 612);
			this.Controls.Add(this.Main_TabControl);
			this.Controls.Add(this.Main_SaveButton);
			this.Controls.Add(this.Main_OpenButton);
			this.Controls.Add(this.Main_MenuStrip);
			this.MainMenuStrip = this.Main_MenuStrip;
			this.Name = "MainForm";
			this.Text = "Studio";
			this.Load += new System.EventHandler(this.OnLoad);
			this.Main_TabControl.ResumeLayout(false);
			this.MainDatabases_TabPage.ResumeLayout(false);
			this.Main_MenuStrip.ResumeLayout(false);
			this.Main_MenuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion


		private System.Windows.Forms.TabControl Main_TabControl;
		private System.Windows.Forms.TabPage MainProject_TabPage;
		private System.Windows.Forms.MenuStrip Main_MenuStrip;
		private System.Windows.Forms.ToolStripMenuItem File_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem FileNew_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem FileOpen_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem FileExit_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem View_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ViewMessages_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.TabPage MainDatabases_TabPage;
		private System.Windows.Forms.Button Main_SaveButton;
		private System.Windows.Forms.Button Main_OpenButton;
		private DatabaseControl databaseControl1;
	}
}

