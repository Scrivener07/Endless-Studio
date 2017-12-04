namespace Studio.Presentation
{
	partial class DatabaseControlRecords
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
			this.c_DataGridView = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.c_DataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// c_DataGridView
			// 
			this.c_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.c_DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c_DataGridView.Location = new System.Drawing.Point(0, 0);
			this.c_DataGridView.Name = "c_DataGridView";
			this.c_DataGridView.Size = new System.Drawing.Size(150, 150);
			this.c_DataGridView.TabIndex = 0;
			this.c_DataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.OnCellFormatting);
			this.c_DataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.OnDataError);
			// 
			// GridControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.c_DataGridView);
			this.Name = "GridControl";
			this.Load += new System.EventHandler(this.OnLoad);
			((System.ComponentModel.ISupportInitialize)(this.c_DataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView c_DataGridView;
	}
}
