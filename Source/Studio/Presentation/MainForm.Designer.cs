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
			this.components = new System.ComponentModel.Container();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.ModificationTabPage = new System.Windows.Forms.TabPage();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.EntitySource = new Studio.Framework.Sources.EntityDataSource(this.components);
			this.DatabaseTabPage = new System.Windows.Forms.TabPage();
			this.EntityBinding = new System.Windows.Forms.BindingSource(this.components);
			this.c_DatabaseControl = new Studio.Presentation.DatabaseControl();
			this.tabControl1.SuspendLayout();
			this.ModificationTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.DatabaseTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.EntityBinding)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.ModificationTabPage);
			this.tabControl1.Controls.Add(this.DatabaseTabPage);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(823, 553);
			this.tabControl1.TabIndex = 1;
			// 
			// ModificationTabPage
			// 
			this.ModificationTabPage.Controls.Add(this.dataGridView1);
			this.ModificationTabPage.Location = new System.Drawing.Point(4, 22);
			this.ModificationTabPage.Name = "ModificationTabPage";
			this.ModificationTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.ModificationTabPage.Size = new System.Drawing.Size(815, 527);
			this.ModificationTabPage.TabIndex = 1;
			this.ModificationTabPage.Text = "Modifications";
			this.ModificationTabPage.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.EntitySource.SetAutoLookup(this.dataGridView1, true);
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.DataSource = this.EntitySource;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(3, 3);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(809, 521);
			this.dataGridView1.TabIndex = 0;
			// 
			// EntitySource
			// 
			this.EntitySource.ContextType = typeof(Studio.Framework.EntityContext);
			// 
			// DatabaseTabPage
			// 
			this.DatabaseTabPage.Controls.Add(this.c_DatabaseControl);
			this.DatabaseTabPage.Location = new System.Drawing.Point(4, 22);
			this.DatabaseTabPage.Name = "DatabaseTabPage";
			this.DatabaseTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.DatabaseTabPage.Size = new System.Drawing.Size(815, 527);
			this.DatabaseTabPage.TabIndex = 0;
			this.DatabaseTabPage.Text = "Databases";
			this.DatabaseTabPage.UseVisualStyleBackColor = true;
			// 
			// EntityBinding
			// 
			this.EntityBinding.DataSource = this.EntitySource;
			this.EntityBinding.Position = 0;
			// 
			// c_DatabaseControl
			// 
			this.c_DatabaseControl.BindingSource = this.EntityBinding;
			this.c_DatabaseControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c_DatabaseControl.Location = new System.Drawing.Point(3, 3);
			this.c_DatabaseControl.Name = "c_DatabaseControl";
			this.c_DatabaseControl.Size = new System.Drawing.Size(809, 521);
			this.c_DatabaseControl.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(823, 553);
			this.Controls.Add(this.tabControl1);
			this.Name = "MainForm";
			this.Text = "Studio";
			this.Load += new System.EventHandler(this.OnLoad);
			this.tabControl1.ResumeLayout(false);
			this.ModificationTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.DatabaseTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.EntityBinding)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DatabaseControl c_DatabaseControl;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage DatabaseTabPage;
		private System.Windows.Forms.TabPage ModificationTabPage;
		private Framework.Sources.EntityDataSource EntitySource;
		private System.Windows.Forms.BindingSource EntityBinding;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}

