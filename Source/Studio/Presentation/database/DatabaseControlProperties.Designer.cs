namespace Studio.Presentation
{
	partial class DatabaseControlProperties
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
			this.c_PropertyGrid = new System.Windows.Forms.PropertyGrid();
			this.SuspendLayout();
			// 
			// c_PropertyGrid
			// 
			this.c_PropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c_PropertyGrid.Location = new System.Drawing.Point(0, 0);
			this.c_PropertyGrid.Name = "c_PropertyGrid";
			this.c_PropertyGrid.Size = new System.Drawing.Size(150, 150);
			this.c_PropertyGrid.TabIndex = 0;
			// 
			// PropertyControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.c_PropertyGrid);
			this.Name = "PropertyControl";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PropertyGrid c_PropertyGrid;
	}
}
