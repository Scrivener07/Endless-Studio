namespace Sharp.Reporting
{
	partial class MessageWidget
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageWidget));
			this.c_ErrorsListView = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.c_MessageImageList = new System.Windows.Forms.ImageList(this.components);
			this.SuspendLayout();
			// 
			// c_ErrorsListView
			// 
			this.c_ErrorsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.columnHeader1});
			this.c_ErrorsListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c_ErrorsListView.FullRowSelect = true;
			this.c_ErrorsListView.GridLines = true;
			this.c_ErrorsListView.Location = new System.Drawing.Point(0, 0);
			this.c_ErrorsListView.Margin = new System.Windows.Forms.Padding(10);
			this.c_ErrorsListView.Name = "c_ErrorsListView";
			this.c_ErrorsListView.ShowItemToolTips = true;
			this.c_ErrorsListView.Size = new System.Drawing.Size(448, 368);
			this.c_ErrorsListView.SmallImageList = this.c_MessageImageList;
			this.c_ErrorsListView.TabIndex = 1;
			this.c_ErrorsListView.UseCompatibleStateImageBehavior = false;
			this.c_ErrorsListView.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Message";
			this.columnHeader1.Width = 367;
			// 
			// c_MessageImageList
			// 
			this.c_MessageImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("c_MessageImageList.ImageStream")));
			this.c_MessageImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.c_MessageImageList.Images.SetKeyName(0, "Status_CompleteA_16xLG.png");
			this.c_MessageImageList.Images.SetKeyName(1, "Status_CompleteB_16xLG.png");
			this.c_MessageImageList.Images.SetKeyName(2, "Status_InfoA_16xLG.png");
			this.c_MessageImageList.Images.SetKeyName(3, "Status_InfoB_16xLG.png");
			this.c_MessageImageList.Images.SetKeyName(4, "Status_HelpA_16xLG.png");
			this.c_MessageImageList.Images.SetKeyName(5, "Status_HelpB_16xLG.png");
			this.c_MessageImageList.Images.SetKeyName(6, "Status_WarningA_16xLG.png");
			this.c_MessageImageList.Images.SetKeyName(7, "Status_WarningB_16xLG.png");
			this.c_MessageImageList.Images.SetKeyName(8, "Status_ErrorA_16xLG.png");
			this.c_MessageImageList.Images.SetKeyName(9, "Status_ErrorB_16xLG.png");
			this.c_MessageImageList.Images.SetKeyName(10, "Arrow_ForwardA_16xLG.png");
			this.c_MessageImageList.Images.SetKeyName(11, "Arrow_BackwardA_16xLG.png");
			this.c_MessageImageList.Images.SetKeyName(12, "Arrow_ForwardB_16xLG.png");
			this.c_MessageImageList.Images.SetKeyName(13, "Arrow_BackwardB_16xLG.png");
			this.c_MessageImageList.Images.SetKeyName(14, "arrow_Forward_invert_16xMD.png");
			this.c_MessageImageList.Images.SetKeyName(15, "arrow_back_invert_16xMD.png");
			// 
			// MessageWidget
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.c_ErrorsListView);
			this.Name = "MessageWidget";
			this.Size = new System.Drawing.Size(448, 368);
			this.Load += new System.EventHandler(this.OnLoad);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView c_ErrorsListView;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ImageList c_MessageImageList;
	}
}
