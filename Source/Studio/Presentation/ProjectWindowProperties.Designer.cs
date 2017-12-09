namespace Studio.Presentation
{
	partial class ProjectWindowProperties
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
			this.components = new System.ComponentModel.Container();
			this.c_PropertyGrid = new System.Windows.Forms.PropertyGrid();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// c_PropertyGrid
			// 
			this.c_PropertyGrid.CategoryForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.c_PropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c_PropertyGrid.Location = new System.Drawing.Point(3, 3);
			this.c_PropertyGrid.Name = "c_PropertyGrid";
			this.c_PropertyGrid.PropertySort = System.Windows.Forms.PropertySort.Categorized;
			this.c_PropertyGrid.Size = new System.Drawing.Size(442, 522);
			this.c_PropertyGrid.TabIndex = 1;
			this.c_PropertyGrid.UseCompatibleTextRendering = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.c_PropertyGrid, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(448, 528);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// bindingSource1
			// 
			this.bindingSource1.DataSource = typeof(ES2.Amplitude.Unity.Runtime.RuntimeModule);
			this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
			// 
			// PropertiesWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(448, 528);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "PropertiesWindow";
			this.Text = "Properties";
			this.Activated += new System.EventHandler(this.DataWindow_Activated);
			this.Load += new System.EventHandler(this.OnLoad);
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PropertyGrid c_PropertyGrid;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.BindingSource bindingSource1;

	}
}