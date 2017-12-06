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
			this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.versionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.homepageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.previewImageFileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.releaseNotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tagsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.metaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RuntimeBinding = new System.Windows.Forms.BindingSource(this.components);
			this.EntitySource = new Studio.Framework.Sources.EntityDataSource(this.components);
			this.DatabaseTabPage = new System.Windows.Forms.TabPage();
			this.databaseControl1 = new Studio.Presentation.DatabaseControl();
			this.tabControl1.SuspendLayout();
			this.ModificationTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RuntimeBinding)).BeginInit();
			this.DatabaseTabPage.SuspendLayout();
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
			this.tabControl1.Size = new System.Drawing.Size(453, 409);
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
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeDataGridViewTextBoxColumn,
            this.versionDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.homepageDataGridViewTextBoxColumn,
            this.previewImageFileDataGridViewTextBoxColumn,
            this.releaseNotesDataGridViewTextBoxColumn,
            this.tagsDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.metaDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.RuntimeBinding;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(3, 3);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(809, 521);
			this.dataGridView1.TabIndex = 0;
			// 
			// typeDataGridViewTextBoxColumn
			// 
			this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
			this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
			this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
			// 
			// versionDataGridViewTextBoxColumn
			// 
			this.versionDataGridViewTextBoxColumn.DataPropertyName = "Version";
			this.versionDataGridViewTextBoxColumn.HeaderText = "Version";
			this.versionDataGridViewTextBoxColumn.Name = "versionDataGridViewTextBoxColumn";
			// 
			// titleDataGridViewTextBoxColumn
			// 
			this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
			this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
			this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
			// 
			// descriptionDataGridViewTextBoxColumn
			// 
			this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
			this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
			this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
			// 
			// homepageDataGridViewTextBoxColumn
			// 
			this.homepageDataGridViewTextBoxColumn.DataPropertyName = "Homepage";
			this.homepageDataGridViewTextBoxColumn.HeaderText = "Homepage";
			this.homepageDataGridViewTextBoxColumn.Name = "homepageDataGridViewTextBoxColumn";
			// 
			// previewImageFileDataGridViewTextBoxColumn
			// 
			this.previewImageFileDataGridViewTextBoxColumn.DataPropertyName = "PreviewImageFile";
			this.previewImageFileDataGridViewTextBoxColumn.HeaderText = "PreviewImageFile";
			this.previewImageFileDataGridViewTextBoxColumn.Name = "previewImageFileDataGridViewTextBoxColumn";
			// 
			// releaseNotesDataGridViewTextBoxColumn
			// 
			this.releaseNotesDataGridViewTextBoxColumn.DataPropertyName = "ReleaseNotes";
			this.releaseNotesDataGridViewTextBoxColumn.HeaderText = "ReleaseNotes";
			this.releaseNotesDataGridViewTextBoxColumn.Name = "releaseNotesDataGridViewTextBoxColumn";
			// 
			// tagsDataGridViewTextBoxColumn
			// 
			this.tagsDataGridViewTextBoxColumn.DataPropertyName = "Tags";
			this.tagsDataGridViewTextBoxColumn.HeaderText = "Tags";
			this.tagsDataGridViewTextBoxColumn.Name = "tagsDataGridViewTextBoxColumn";
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			// 
			// metaDataGridViewTextBoxColumn
			// 
			this.metaDataGridViewTextBoxColumn.DataPropertyName = "Meta";
			this.metaDataGridViewTextBoxColumn.HeaderText = "Meta";
			this.metaDataGridViewTextBoxColumn.Name = "metaDataGridViewTextBoxColumn";
			// 
			// RuntimeBinding
			// 
			this.RuntimeBinding.AllowNew = true;
			this.RuntimeBinding.DataMember = "RuntimeModules";
			this.RuntimeBinding.DataSource = this.EntitySource;
			this.RuntimeBinding.Position = 0;
			// 
			// EntitySource
			// 
			this.EntitySource.ContextType = typeof(Studio.Framework.EntityContext);
			// 
			// DatabaseTabPage
			// 
			this.DatabaseTabPage.Controls.Add(this.databaseControl1);
			this.DatabaseTabPage.Location = new System.Drawing.Point(4, 22);
			this.DatabaseTabPage.Name = "DatabaseTabPage";
			this.DatabaseTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.DatabaseTabPage.Size = new System.Drawing.Size(445, 383);
			this.DatabaseTabPage.TabIndex = 0;
			this.DatabaseTabPage.Text = "Databases";
			this.DatabaseTabPage.UseVisualStyleBackColor = true;
			// 
			// databaseControl1
			// 
			this.databaseControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.databaseControl1.Location = new System.Drawing.Point(3, 3);
			this.databaseControl1.Name = "databaseControl1";
			this.databaseControl1.Size = new System.Drawing.Size(439, 377);
			this.databaseControl1.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(453, 409);
			this.Controls.Add(this.tabControl1);
			this.Name = "MainForm";
			this.Text = "Studio";
			this.tabControl1.ResumeLayout(false);
			this.ModificationTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RuntimeBinding)).EndInit();
			this.DatabaseTabPage.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion


		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage DatabaseTabPage;
		private System.Windows.Forms.TabPage ModificationTabPage;
		private Framework.Sources.EntityDataSource EntitySource;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource RuntimeBinding;
		private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn versionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn homepageDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn previewImageFileDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn releaseNotesDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tagsDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn metaDataGridViewTextBoxColumn;
		private DatabaseControl databaseControl1;
	}
}

