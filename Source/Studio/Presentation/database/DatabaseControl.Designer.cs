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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseControl));
			this.c_TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.c_SplitContainerA = new System.Windows.Forms.SplitContainer();
			this.c_SplitContainerB = new System.Windows.Forms.SplitContainer();
			this.databaseTables1 = new Studio.Presentation.DatabaseControlTables();
			this.databaseRecords1 = new Studio.Presentation.DatabaseControlRecords();
			this.databaseProperties1 = new Studio.Presentation.DatabaseControlProperties();
			this.databaseSelected1 = new Studio.Presentation.DatabaseControlSelected();
			this.entityContextBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.entityContextBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.entityContextBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.c_TableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c_SplitContainerA)).BeginInit();
			this.c_SplitContainerA.Panel1.SuspendLayout();
			this.c_SplitContainerA.Panel2.SuspendLayout();
			this.c_SplitContainerA.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c_SplitContainerB)).BeginInit();
			this.c_SplitContainerB.Panel1.SuspendLayout();
			this.c_SplitContainerB.Panel2.SuspendLayout();
			this.c_SplitContainerB.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.entityContextBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.entityContextBindingNavigator)).BeginInit();
			this.entityContextBindingNavigator.SuspendLayout();
			this.SuspendLayout();
			// 
			// c_TableLayoutPanel
			// 
			this.c_TableLayoutPanel.ColumnCount = 1;
			this.c_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.c_TableLayoutPanel.Controls.Add(this.c_SplitContainerA, 0, 1);
			this.c_TableLayoutPanel.Controls.Add(this.databaseSelected1, 0, 2);
			this.c_TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c_TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.c_TableLayoutPanel.Name = "c_TableLayoutPanel";
			this.c_TableLayoutPanel.RowCount = 3;
			this.c_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.c_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.c_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
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
			this.c_SplitContainerA.Panel2.Controls.Add(this.databaseProperties1);
			this.c_SplitContainerA.Size = new System.Drawing.Size(583, 501);
			this.c_SplitContainerA.SplitterDistance = 239;
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
			this.c_SplitContainerB.Panel1.Controls.Add(this.databaseTables1);
			// 
			// c_SplitContainerB.Panel2
			// 
			this.c_SplitContainerB.Panel2.Controls.Add(this.databaseRecords1);
			this.c_SplitContainerB.Size = new System.Drawing.Size(583, 239);
			this.c_SplitContainerB.SplitterDistance = 196;
			this.c_SplitContainerB.SplitterWidth = 12;
			this.c_SplitContainerB.TabIndex = 1;
			// 
			// databaseTables1
			// 
			this.databaseTables1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.databaseTables1.Location = new System.Drawing.Point(0, 0);
			this.databaseTables1.Name = "databaseTables1";
			this.databaseTables1.Size = new System.Drawing.Size(196, 239);
			this.databaseTables1.TabIndex = 0;
			// 
			// databaseRecords1
			// 
			this.databaseRecords1.DataSource = this.entityContextBindingSource;
			this.databaseRecords1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.databaseRecords1.Location = new System.Drawing.Point(0, 0);
			this.databaseRecords1.Name = "databaseRecords1";
			this.databaseRecords1.Size = new System.Drawing.Size(375, 239);
			this.databaseRecords1.TabIndex = 0;
			// 
			// databaseProperties1
			// 
			this.databaseProperties1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.databaseProperties1.Location = new System.Drawing.Point(0, 0);
			this.databaseProperties1.Name = "databaseProperties1";
			this.databaseProperties1.SelectedObject = null;
			this.databaseProperties1.Size = new System.Drawing.Size(583, 250);
			this.databaseProperties1.TabIndex = 0;
			// 
			// databaseSelected1
			// 
			this.databaseSelected1.AutoSize = true;
			this.databaseSelected1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.databaseSelected1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.databaseSelected1.Location = new System.Drawing.Point(3, 535);
			this.databaseSelected1.MinimumSize = new System.Drawing.Size(200, 25);
			this.databaseSelected1.Name = "databaseSelected1";
			this.databaseSelected1.Record = "record";
			this.databaseSelected1.Size = new System.Drawing.Size(583, 25);
			this.databaseSelected1.TabIndex = 1;
			this.databaseSelected1.Table = "table";
			// 
			// entityContextBindingSource
			// 
			this.entityContextBindingSource.DataSource = typeof(Studio.Framework.EntityContext);
			// 
			// entityContextBindingNavigator
			// 
			this.entityContextBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.entityContextBindingNavigator.BindingSource = this.entityContextBindingSource;
			this.entityContextBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.entityContextBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.entityContextBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.entityContextBindingNavigatorSaveItem});
			this.entityContextBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.entityContextBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.entityContextBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.entityContextBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.entityContextBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.entityContextBindingNavigator.Name = "entityContextBindingNavigator";
			this.entityContextBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.entityContextBindingNavigator.Size = new System.Drawing.Size(589, 25);
			this.entityContextBindingNavigator.TabIndex = 1;
			this.entityContextBindingNavigator.Text = "bindingNavigator1";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveFirstItem.Text = "Move first";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMovePreviousItem.Text = "Move previous";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Position";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Current position";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveNextItem.Text = "Move next";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveLastItem.Text = "Move last";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem.Text = "Add new";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Delete";
			// 
			// entityContextBindingNavigatorSaveItem
			// 
			this.entityContextBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.entityContextBindingNavigatorSaveItem.Enabled = false;
			this.entityContextBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("entityContextBindingNavigatorSaveItem.Image")));
			this.entityContextBindingNavigatorSaveItem.Name = "entityContextBindingNavigatorSaveItem";
			this.entityContextBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.entityContextBindingNavigatorSaveItem.Text = "Save Data";
			// 
			// DatabaseControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.entityContextBindingNavigator);
			this.Controls.Add(this.c_TableLayoutPanel);
			this.Name = "DatabaseControl";
			this.Size = new System.Drawing.Size(589, 563);
			this.c_TableLayoutPanel.ResumeLayout(false);
			this.c_TableLayoutPanel.PerformLayout();
			this.c_SplitContainerA.Panel1.ResumeLayout(false);
			this.c_SplitContainerA.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.c_SplitContainerA)).EndInit();
			this.c_SplitContainerA.ResumeLayout(false);
			this.c_SplitContainerB.Panel1.ResumeLayout(false);
			this.c_SplitContainerB.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.c_SplitContainerB)).EndInit();
			this.c_SplitContainerB.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.entityContextBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.entityContextBindingNavigator)).EndInit();
			this.entityContextBindingNavigator.ResumeLayout(false);
			this.entityContextBindingNavigator.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel c_TableLayoutPanel;
		private System.Windows.Forms.SplitContainer c_SplitContainerA;
		private System.Windows.Forms.SplitContainer c_SplitContainerB;
		private DatabaseControlProperties databaseProperties1;
		private DatabaseControlSelected databaseSelected1;
		private DatabaseControlTables databaseTables1;
		private DatabaseControlRecords databaseRecords1;
		private System.Windows.Forms.BindingSource entityContextBindingSource;
		private System.Windows.Forms.BindingNavigator entityContextBindingNavigator;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.ToolStripButton entityContextBindingNavigatorSaveItem;
	}
}
