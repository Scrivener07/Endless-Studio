namespace Studio.Presentation
{
	partial class DatabaseControl
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
			this.components = new System.ComponentModel.Container();
			this.c_TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.c_SplitContainerA = new System.Windows.Forms.SplitContainer();
			this.c_SplitContainerB = new System.Windows.Forms.SplitContainer();
			this.c_TreeView = new System.Windows.Forms.TreeView();
			this.c_DataGridView = new System.Windows.Forms.DataGridView();
			this.EntityBinding = new System.Windows.Forms.BindingSource(this.components);
			this.c_PropertyGrid = new System.Windows.Forms.PropertyGrid();
			this.SelectedToolStrip = new System.Windows.Forms.ToolStrip();
			this.c_SelectedLabel = new System.Windows.Forms.ToolStripLabel();
			this.c_ToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.c_TabelLabel = new System.Windows.Forms.ToolStripLabel();
			this.c_RecordLabel = new System.Windows.Forms.ToolStripLabel();
			this.EntityNavigator = new ES2.Editor.Framework.Binding.EntityBindingNavigator();
			this.EntitySource = new ES2.Editor.Framework.Binding.EntityDataSource(this.components);
			this.c_TableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c_SplitContainerA)).BeginInit();
			this.c_SplitContainerA.Panel1.SuspendLayout();
			this.c_SplitContainerA.Panel2.SuspendLayout();
			this.c_SplitContainerA.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c_SplitContainerB)).BeginInit();
			this.c_SplitContainerB.Panel1.SuspendLayout();
			this.c_SplitContainerB.Panel2.SuspendLayout();
			this.c_SplitContainerB.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c_DataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EntityBinding)).BeginInit();
			this.SelectedToolStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// c_TableLayoutPanel
			// 
			this.c_TableLayoutPanel.ColumnCount = 1;
			this.c_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.c_TableLayoutPanel.Controls.Add(this.c_SplitContainerA, 0, 2);
			this.c_TableLayoutPanel.Controls.Add(this.SelectedToolStrip, 0, 1);
			this.c_TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c_TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.c_TableLayoutPanel.Name = "c_TableLayoutPanel";
			this.c_TableLayoutPanel.RowCount = 3;
			this.c_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.c_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.c_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.c_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.c_TableLayoutPanel.Size = new System.Drawing.Size(589, 563);
			this.c_TableLayoutPanel.TabIndex = 0;
			// 
			// c_SplitContainerA
			// 
			this.c_SplitContainerA.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c_SplitContainerA.Location = new System.Drawing.Point(3, 28);
			this.c_SplitContainerA.Name = "c_SplitContainerA";
			this.c_SplitContainerA.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// c_SplitContainerA.Panel1
			// 
			this.c_SplitContainerA.Panel1.Controls.Add(this.c_SplitContainerB);
			// 
			// c_SplitContainerA.Panel2
			// 
			this.c_SplitContainerA.Panel2.Controls.Add(this.EntityNavigator);
			this.c_SplitContainerA.Panel2.Controls.Add(this.c_PropertyGrid);
			this.c_SplitContainerA.Size = new System.Drawing.Size(583, 532);
			this.c_SplitContainerA.SplitterDistance = 252;
			this.c_SplitContainerA.SplitterWidth = 12;
			this.c_SplitContainerA.TabIndex = 0;
			// 
			// c_SplitContainerB
			// 
			this.c_SplitContainerB.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c_SplitContainerB.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.c_SplitContainerB.Location = new System.Drawing.Point(0, 0);
			this.c_SplitContainerB.Name = "c_SplitContainerB";
			// 
			// c_SplitContainerB.Panel1
			// 
			this.c_SplitContainerB.Panel1.Controls.Add(this.c_TreeView);
			// 
			// c_SplitContainerB.Panel2
			// 
			this.c_SplitContainerB.Panel2.Controls.Add(this.c_DataGridView);
			this.c_SplitContainerB.Size = new System.Drawing.Size(583, 252);
			this.c_SplitContainerB.SplitterDistance = 196;
			this.c_SplitContainerB.SplitterWidth = 12;
			this.c_SplitContainerB.TabIndex = 1;
			// 
			// c_TreeView
			// 
			this.c_TreeView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c_TreeView.Location = new System.Drawing.Point(0, 0);
			this.c_TreeView.Name = "c_TreeView";
			this.c_TreeView.Size = new System.Drawing.Size(196, 252);
			this.c_TreeView.TabIndex = 1;
			this.c_TreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.c_TreeView_NodeMouseClick);
			// 
			// c_DataGridView
			// 
			this.c_DataGridView.AutoGenerateColumns = false;
			this.c_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.c_DataGridView.DataSource = this.EntityBinding;
			this.c_DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c_DataGridView.Location = new System.Drawing.Point(0, 0);
			this.c_DataGridView.Name = "c_DataGridView";
			this.c_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.c_DataGridView.Size = new System.Drawing.Size(375, 252);
			this.c_DataGridView.TabIndex = 1;
			this.c_DataGridView.SelectionChanged += new System.EventHandler(this.c_DataGridView_SelectionChanged);
			// 
			// EntityBinding
			// 
			this.EntityBinding.AllowNew = true;
			this.EntityBinding.DataSource = this.EntitySource;
			this.EntityBinding.Position = 0;
			// 
			// c_PropertyGrid
			// 
			this.c_PropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c_PropertyGrid.Location = new System.Drawing.Point(0, 0);
			this.c_PropertyGrid.Name = "c_PropertyGrid";
			this.c_PropertyGrid.Size = new System.Drawing.Size(583, 268);
			this.c_PropertyGrid.TabIndex = 1;
			// 
			// SelectedToolStrip
			// 
			this.SelectedToolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SelectedToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.c_SelectedLabel,
            this.c_ToolStripSeparator,
            this.c_TabelLabel,
            this.c_RecordLabel});
			this.SelectedToolStrip.Location = new System.Drawing.Point(0, 0);
			this.SelectedToolStrip.Name = "SelectedToolStrip";
			this.SelectedToolStrip.Size = new System.Drawing.Size(589, 25);
			this.SelectedToolStrip.TabIndex = 2;
			this.SelectedToolStrip.Text = "c_ToolStrip";
			// 
			// c_SelectedLabel
			// 
			this.c_SelectedLabel.Name = "c_SelectedLabel";
			this.c_SelectedLabel.Size = new System.Drawing.Size(51, 22);
			this.c_SelectedLabel.Text = "Selected";
			// 
			// c_ToolStripSeparator
			// 
			this.c_ToolStripSeparator.Name = "c_ToolStripSeparator";
			this.c_ToolStripSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// c_TabelLabel
			// 
			this.c_TabelLabel.Enabled = false;
			this.c_TabelLabel.Name = "c_TabelLabel";
			this.c_TabelLabel.Size = new System.Drawing.Size(33, 22);
			this.c_TabelLabel.Text = "table";
			// 
			// c_RecordLabel
			// 
			this.c_RecordLabel.Enabled = false;
			this.c_RecordLabel.Name = "c_RecordLabel";
			this.c_RecordLabel.Size = new System.Drawing.Size(41, 22);
			this.c_RecordLabel.Text = "record";
			// 
			// EntityNavigator
			// 
			this.EntityNavigator.DataSource = this.EntitySource;
			this.EntityNavigator.Location = new System.Drawing.Point(0, 0);
			this.EntityNavigator.Name = "EntityNavigator";
			this.EntityNavigator.Size = new System.Drawing.Size(583, 25);
			this.EntityNavigator.TabIndex = 2;
			this.EntityNavigator.Text = "entityBindingNavigator1";
			// 
			// EntitySource
			// 
			this.EntitySource.ContextType = null;
			// 
			// DatabaseControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.c_TableLayoutPanel);
			this.Name = "DatabaseControl";
			this.Size = new System.Drawing.Size(589, 563);
			this.Load += new System.EventHandler(this.OnLoad);
			this.c_TableLayoutPanel.ResumeLayout(false);
			this.c_TableLayoutPanel.PerformLayout();
			this.c_SplitContainerA.Panel1.ResumeLayout(false);
			this.c_SplitContainerA.Panel2.ResumeLayout(false);
			this.c_SplitContainerA.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.c_SplitContainerA)).EndInit();
			this.c_SplitContainerA.ResumeLayout(false);
			this.c_SplitContainerB.Panel1.ResumeLayout(false);
			this.c_SplitContainerB.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.c_SplitContainerB)).EndInit();
			this.c_SplitContainerB.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.c_DataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EntityBinding)).EndInit();
			this.SelectedToolStrip.ResumeLayout(false);
			this.SelectedToolStrip.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel c_TableLayoutPanel;
		private System.Windows.Forms.SplitContainer c_SplitContainerA;
		private System.Windows.Forms.SplitContainer c_SplitContainerB;
		private System.Windows.Forms.BindingSource EntityBinding;
		private System.Windows.Forms.PropertyGrid c_PropertyGrid;
		private System.Windows.Forms.ToolStrip SelectedToolStrip;
		private System.Windows.Forms.ToolStripLabel c_SelectedLabel;
		private System.Windows.Forms.ToolStripSeparator c_ToolStripSeparator;
		private System.Windows.Forms.ToolStripLabel c_TabelLabel;
		private System.Windows.Forms.ToolStripLabel c_RecordLabel;
		private System.Windows.Forms.TreeView c_TreeView;
		private System.Windows.Forms.DataGridView c_DataGridView;
		private ES2.Editor.Framework.Binding.EntityBindingNavigator EntityNavigator;
		private ES2.Editor.Framework.Binding.EntityDataSource EntitySource;
	}
}
