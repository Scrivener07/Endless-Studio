using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;

namespace Studio.Presentation
{
	public partial class DatabaseControlRecords : UserControl
	{
		[Category("Data")]
		[DefaultValue(null), AttributeProvider(typeof(IListSource))]
		public object DataSource { get { return c_DataGridView.DataSource; } set { c_DataGridView.DataSource = value; } }


		[Category("Data")]
		[DefaultValue(""), Editor("System.Windows.Forms.Design.DataMemberListEditor, System.Design", typeof(UITypeEditor))]
		public string DataMember { get { return c_DataGridView.DataMember; } set { c_DataGridView.DataMember = value; } }


		[Category("Action")]
		public event EventHandler SelectionChanged
		{
			add { c_DataGridView.SelectionChanged += value; }
			remove { c_DataGridView.SelectionChanged -= value; }
		}


		public DatabaseControlRecords()
		{
			InitializeComponent();
			this.c_DataGridView.AllowUserToOrderColumns = true;
			this.c_DataGridView.AllowUserToResizeRows = false;
			this.c_DataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
			this.c_DataGridView.AlternatingRowsDefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
			this.c_DataGridView.AlternatingRowsDefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
			this.c_DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			this.c_DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.c_DataGridView.MultiSelect = false;
			this.c_DataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		}


		private void OnLoad(object sender, System.EventArgs e)
		{
			this.c_DataGridView.AutoGenerateColumns = true;
		}


		private void OnDataError(object sender, DataGridViewDataErrorEventArgs e)
		{
		}


		private void OnCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
		}


	}
}
