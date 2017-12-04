using System.Diagnostics;
using System.Windows.Forms;

namespace Studio.Presentation
{
	public partial class DatabaseControl : UserControl
	{
		public DatabaseControl()
		{
			InitializeComponent();
			TableSelected("Dummy");
		}


		#region Tables

		private void Tables_OnNodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			TableSelected(e.Node.Text);
		}

		private void TableSelected(string tableName)
		{
			this.databaseSelected1.Table = tableName;
			//this.c_SourceBinding.DataMember = tableName;
			//this.c_EntityNavigator.DataMember = tableName;
			Trace.WriteLine("You have selected the " + tableName + " table.");
		}

		#endregion


		#region Records
		#endregion


	}
}
