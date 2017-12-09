namespace Studio.Presentation
{
	partial class ProjectWindowNew
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectWindowNew));
			this.c_SourceSelectTable = new System.Windows.Forms.TableLayoutPanel();
			this.c_SourceTextBox = new System.Windows.Forms.TextBox();
			this.c_SourceSelectButton = new System.Windows.Forms.Button();
			this.c_SourceSelectLabel = new System.Windows.Forms.Label();
			this.c_UserDataSelectHintLabel = new System.Windows.Forms.Label();
			this.c_NameTable = new System.Windows.Forms.TableLayoutPanel();
			this.c_NameLabel = new System.Windows.Forms.Label();
			this.c_NameTextBox = new System.Windows.Forms.TextBox();
			this.c_UserDataSelectTable = new System.Windows.Forms.TableLayoutPanel();
			this.c_UserDataTextBox = new System.Windows.Forms.TextBox();
			this.c_UserDataSelectLabel = new System.Windows.Forms.Label();
			this.c_UserDataSelectButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.Images = new System.Windows.Forms.ImageList(this.components);
			this.c_CancelButton = new System.Windows.Forms.Button();
			this.c_AcceptButton = new System.Windows.Forms.Button();
			this.c_ConfirmPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.c_TableLayout = new System.Windows.Forms.TableLayoutPanel();
			this.c_ProgressWidget = new Sharp.Applications.Controls.ProgressWidget();
			this.c_MessageWidget = new Sharp.Applications.Messages.MessageWidget();
			this.c_SourceSelectTable.SuspendLayout();
			this.c_NameTable.SuspendLayout();
			this.c_UserDataSelectTable.SuspendLayout();
			this.c_ConfirmPanel.SuspendLayout();
			this.c_TableLayout.SuspendLayout();
			this.SuspendLayout();
			// 
			// c_SourceSelectTable
			// 
			this.c_SourceSelectTable.ColumnCount = 3;
			this.c_SourceSelectTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.c_SourceSelectTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.c_SourceSelectTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.c_SourceSelectTable.Controls.Add(this.c_SourceTextBox, 1, 0);
			this.c_SourceSelectTable.Controls.Add(this.c_SourceSelectButton, 2, 0);
			this.c_SourceSelectTable.Controls.Add(this.c_SourceSelectLabel, 0, 0);
			this.c_SourceSelectTable.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c_SourceSelectTable.Location = new System.Drawing.Point(3, 137);
			this.c_SourceSelectTable.Name = "c_SourceSelectTable";
			this.c_SourceSelectTable.RowCount = 1;
			this.c_SourceSelectTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.c_SourceSelectTable.Size = new System.Drawing.Size(830, 31);
			this.c_SourceSelectTable.TabIndex = 4;
			// 
			// c_SourceTextBox
			// 
			this.c_SourceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.c_SourceTextBox.Location = new System.Drawing.Point(59, 5);
			this.c_SourceTextBox.Name = "c_SourceTextBox";
			this.c_SourceTextBox.Size = new System.Drawing.Size(687, 20);
			this.c_SourceTextBox.TabIndex = 2;
			this.c_SourceTextBox.TextChanged += new System.EventHandler(this.SourceSelectTextBox_OnTextChanged);
			// 
			// c_SourceSelectButton
			// 
			this.c_SourceSelectButton.Location = new System.Drawing.Point(752, 3);
			this.c_SourceSelectButton.Name = "c_SourceSelectButton";
			this.c_SourceSelectButton.Size = new System.Drawing.Size(75, 25);
			this.c_SourceSelectButton.TabIndex = 0;
			this.c_SourceSelectButton.Text = "Select";
			this.c_SourceSelectButton.UseVisualStyleBackColor = true;
			this.c_SourceSelectButton.Click += new System.EventHandler(this.SourceSelectButton_OnClick);
			// 
			// c_SourceSelectLabel
			// 
			this.c_SourceSelectLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.c_SourceSelectLabel.AutoSize = true;
			this.c_SourceSelectLabel.Location = new System.Drawing.Point(3, 9);
			this.c_SourceSelectLabel.Name = "c_SourceSelectLabel";
			this.c_SourceSelectLabel.Size = new System.Drawing.Size(50, 13);
			this.c_SourceSelectLabel.TabIndex = 3;
			this.c_SourceSelectLabel.Text = "Source   ";
			// 
			// c_UserDataSelectHintLabel
			// 
			this.c_UserDataSelectHintLabel.AutoSize = true;
			this.c_UserDataSelectHintLabel.Location = new System.Drawing.Point(5, 5);
			this.c_UserDataSelectHintLabel.Margin = new System.Windows.Forms.Padding(5);
			this.c_UserDataSelectHintLabel.Name = "c_UserDataSelectHintLabel";
			this.c_UserDataSelectHintLabel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.c_UserDataSelectHintLabel.Size = new System.Drawing.Size(228, 19);
			this.c_UserDataSelectHintLabel.TabIndex = 7;
			this.c_UserDataSelectHintLabel.Text = "Select a directory to create a new modification.";
			this.c_UserDataSelectHintLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// c_NameTable
			// 
			this.c_NameTable.ColumnCount = 2;
			this.c_NameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.c_NameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.c_NameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.c_NameTable.Controls.Add(this.c_NameLabel, 0, 0);
			this.c_NameTable.Controls.Add(this.c_NameTextBox, 1, 0);
			this.c_NameTable.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c_NameTable.Location = new System.Drawing.Point(3, 69);
			this.c_NameTable.Name = "c_NameTable";
			this.c_NameTable.RowCount = 1;
			this.c_NameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.c_NameTable.Size = new System.Drawing.Size(830, 33);
			this.c_NameTable.TabIndex = 8;
			// 
			// c_NameLabel
			// 
			this.c_NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.c_NameLabel.AutoSize = true;
			this.c_NameLabel.Location = new System.Drawing.Point(3, 10);
			this.c_NameLabel.Name = "c_NameLabel";
			this.c_NameLabel.Size = new System.Drawing.Size(35, 13);
			this.c_NameLabel.TabIndex = 3;
			this.c_NameLabel.Text = "Name";
			// 
			// c_NameTextBox
			// 
			this.c_NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.c_NameTextBox.Location = new System.Drawing.Point(44, 6);
			this.c_NameTextBox.Name = "c_NameTextBox";
			this.c_NameTextBox.Size = new System.Drawing.Size(783, 20);
			this.c_NameTextBox.TabIndex = 2;
			this.c_NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_OnTextChanged);
			// 
			// c_UserDataSelectTable
			// 
			this.c_UserDataSelectTable.ColumnCount = 3;
			this.c_UserDataSelectTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.c_UserDataSelectTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.c_UserDataSelectTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.c_UserDataSelectTable.Controls.Add(this.c_UserDataTextBox, 1, 0);
			this.c_UserDataSelectTable.Controls.Add(this.c_UserDataSelectLabel, 0, 0);
			this.c_UserDataSelectTable.Controls.Add(this.c_UserDataSelectButton, 2, 0);
			this.c_UserDataSelectTable.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c_UserDataSelectTable.Location = new System.Drawing.Point(3, 32);
			this.c_UserDataSelectTable.Name = "c_UserDataSelectTable";
			this.c_UserDataSelectTable.RowCount = 1;
			this.c_UserDataSelectTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.c_UserDataSelectTable.Size = new System.Drawing.Size(830, 31);
			this.c_UserDataSelectTable.TabIndex = 11;
			// 
			// c_UserDataTextBox
			// 
			this.c_UserDataTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.c_UserDataTextBox.Enabled = false;
			this.c_UserDataTextBox.Location = new System.Drawing.Point(58, 5);
			this.c_UserDataTextBox.Name = "c_UserDataTextBox";
			this.c_UserDataTextBox.Size = new System.Drawing.Size(688, 20);
			this.c_UserDataTextBox.TabIndex = 2;
			this.c_UserDataTextBox.TextChanged += new System.EventHandler(this.UserDataTextBox_OnTextChanged);
			// 
			// c_UserDataSelectLabel
			// 
			this.c_UserDataSelectLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.c_UserDataSelectLabel.AutoSize = true;
			this.c_UserDataSelectLabel.Location = new System.Drawing.Point(3, 9);
			this.c_UserDataSelectLabel.Name = "c_UserDataSelectLabel";
			this.c_UserDataSelectLabel.Size = new System.Drawing.Size(49, 13);
			this.c_UserDataSelectLabel.TabIndex = 3;
			this.c_UserDataSelectLabel.Text = "Directory";
			// 
			// c_UserDataSelectButton
			// 
			this.c_UserDataSelectButton.Location = new System.Drawing.Point(752, 3);
			this.c_UserDataSelectButton.Name = "c_UserDataSelectButton";
			this.c_UserDataSelectButton.Size = new System.Drawing.Size(75, 25);
			this.c_UserDataSelectButton.TabIndex = 0;
			this.c_UserDataSelectButton.Text = "Select";
			this.c_UserDataSelectButton.UseVisualStyleBackColor = true;
			this.c_UserDataSelectButton.Click += new System.EventHandler(this.UserDataSelectButton_OnClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(5, 110);
			this.label1.Margin = new System.Windows.Forms.Padding(5);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.label1.Size = new System.Drawing.Size(167, 19);
			this.label1.TabIndex = 10;
			this.label1.Text = "Choose the source game content.";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Images
			// 
			this.Images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Images.ImageStream")));
			this.Images.TransparentColor = System.Drawing.Color.Transparent;
			this.Images.Images.SetKeyName(0, "DatabaseProject_7342_32x.png");
			this.Images.Images.SetKeyName(1, "GenericVSProject_9906_32x.png");
			this.Images.Images.SetKeyName(2, "SoftwareDefinitionModel_11321_48x.png");
			this.Images.Images.SetKeyName(3, "SoftwareDefinitionModel_11321_32x.png");
			// 
			// c_CancelButton
			// 
			this.c_CancelButton.Location = new System.Drawing.Point(84, 3);
			this.c_CancelButton.Name = "c_CancelButton";
			this.c_CancelButton.Size = new System.Drawing.Size(75, 23);
			this.c_CancelButton.TabIndex = 1;
			this.c_CancelButton.Text = "Cancel";
			this.c_CancelButton.UseVisualStyleBackColor = true;
			this.c_CancelButton.Click += new System.EventHandler(this.CancelButton_OnClick);
			// 
			// c_AcceptButton
			// 
			this.c_AcceptButton.Location = new System.Drawing.Point(3, 3);
			this.c_AcceptButton.Name = "c_AcceptButton";
			this.c_AcceptButton.Size = new System.Drawing.Size(75, 23);
			this.c_AcceptButton.TabIndex = 0;
			this.c_AcceptButton.Text = "Accept";
			this.c_AcceptButton.UseVisualStyleBackColor = true;
			this.c_AcceptButton.Click += new System.EventHandler(this.AcceptButton_OnClick);
			// 
			// c_ConfirmPanel
			// 
			this.c_ConfirmPanel.AutoSize = true;
			this.c_ConfirmPanel.Controls.Add(this.c_AcceptButton);
			this.c_ConfirmPanel.Controls.Add(this.c_CancelButton);
			this.c_ConfirmPanel.Location = new System.Drawing.Point(3, 594);
			this.c_ConfirmPanel.Name = "c_ConfirmPanel";
			this.c_ConfirmPanel.Size = new System.Drawing.Size(162, 29);
			this.c_ConfirmPanel.TabIndex = 5;
			// 
			// c_TableLayout
			// 
			this.c_TableLayout.ColumnCount = 1;
			this.c_TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.c_TableLayout.Controls.Add(this.c_ConfirmPanel, 0, 7);
			this.c_TableLayout.Controls.Add(this.c_ProgressWidget, 0, 6);
			this.c_TableLayout.Controls.Add(this.c_MessageWidget, 0, 5);
			this.c_TableLayout.Controls.Add(this.c_UserDataSelectTable, 0, 1);
			this.c_TableLayout.Controls.Add(this.c_UserDataSelectHintLabel, 0, 0);
			this.c_TableLayout.Controls.Add(this.c_SourceSelectTable, 0, 4);
			this.c_TableLayout.Controls.Add(this.c_NameTable, 0, 2);
			this.c_TableLayout.Controls.Add(this.label1, 0, 3);
			this.c_TableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c_TableLayout.Location = new System.Drawing.Point(0, 0);
			this.c_TableLayout.Name = "c_TableLayout";
			this.c_TableLayout.RowCount = 8;
			this.c_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.c_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.c_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.c_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.c_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.c_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.c_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.c_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.c_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.c_TableLayout.Size = new System.Drawing.Size(836, 626);
			this.c_TableLayout.TabIndex = 14;
			// 
			// c_ProgressWidget
			// 
			this.c_ProgressWidget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.c_ProgressWidget.AutoSize = true;
			this.c_ProgressWidget.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.c_ProgressWidget.Location = new System.Drawing.Point(3, 537);
			this.c_ProgressWidget.MaximumSize = new System.Drawing.Size(1600, 60);
			this.c_ProgressWidget.MinimumSize = new System.Drawing.Size(100, 10);
			this.c_ProgressWidget.Name = "c_ProgressWidget";
			this.c_ProgressWidget.ProgressText = "Progress %";
			this.c_ProgressWidget.ProgressValue = 0;
			this.c_ProgressWidget.Size = new System.Drawing.Size(830, 51);
			this.c_ProgressWidget.TabIndex = 12;
			// 
			// c_MessageWidget
			// 
			this.c_MessageWidget.AutoScroll = true;
			this.c_MessageWidget.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c_MessageWidget.Location = new System.Drawing.Point(3, 174);
			this.c_MessageWidget.MinimumSize = new System.Drawing.Size(100, 10);
			this.c_MessageWidget.Name = "c_MessageWidget";
			this.c_MessageWidget.Size = new System.Drawing.Size(830, 357);
			this.c_MessageWidget.TabIndex = 13;
			// 
			// NewWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(836, 626);
			this.Controls.Add(this.c_TableLayout);
			this.Name = "NewWindow";
			this.Text = "New";
			this.Load += new System.EventHandler(this.OnLoad);
			this.c_SourceSelectTable.ResumeLayout(false);
			this.c_SourceSelectTable.PerformLayout();
			this.c_NameTable.ResumeLayout(false);
			this.c_NameTable.PerformLayout();
			this.c_UserDataSelectTable.ResumeLayout(false);
			this.c_UserDataSelectTable.PerformLayout();
			this.c_ConfirmPanel.ResumeLayout(false);
			this.c_TableLayout.ResumeLayout(false);
			this.c_TableLayout.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel c_SourceSelectTable;
		private System.Windows.Forms.Button c_SourceSelectButton;
		private System.Windows.Forms.TextBox c_SourceTextBox;
		private System.Windows.Forms.Label c_SourceSelectLabel;
		private System.Windows.Forms.Label c_UserDataSelectHintLabel;
		private System.Windows.Forms.TableLayoutPanel c_NameTable;
		private System.Windows.Forms.TextBox c_NameTextBox;
		private System.Windows.Forms.Label c_NameLabel;
		private System.Windows.Forms.ImageList Images;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TableLayoutPanel c_UserDataSelectTable;
		private System.Windows.Forms.Label c_UserDataSelectLabel;
		private System.Windows.Forms.Button c_UserDataSelectButton;
		private System.Windows.Forms.FlowLayoutPanel c_ConfirmPanel;
		private System.Windows.Forms.Button c_AcceptButton;
		private System.Windows.Forms.Button c_CancelButton;
		private Sharp.Applications.Controls.ProgressWidget c_ProgressWidget;
		private Sharp.Applications.Messages.MessageWidget c_MessageWidget;
		private System.Windows.Forms.TableLayoutPanel c_TableLayout;
		private System.Windows.Forms.TextBox c_UserDataTextBox;
	}
}