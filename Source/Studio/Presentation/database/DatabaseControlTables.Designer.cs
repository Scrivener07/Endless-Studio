namespace Studio.Presentation
{
	partial class DatabaseControlTables
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
			this.c_TreeView = new System.Windows.Forms.TreeView();
			this.SuspendLayout();
			// 
			// c_TreeView
			// 
			this.c_TreeView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c_TreeView.Location = new System.Drawing.Point(0, 0);
			this.c_TreeView.Name = "c_TreeView";
			this.c_TreeView.Size = new System.Drawing.Size(150, 150);
			this.c_TreeView.TabIndex = 0;
			this.c_TreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.c_TreeView_NodeMouseClick);
			// 
			// DatabaseControlTables
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.c_TreeView);
			this.Name = "DatabaseControlTables";
			this.Load += new System.EventHandler(this.OnLoad);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TreeView c_TreeView;
	}
}
