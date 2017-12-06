using Sharp.Applications;
using Sharp.Applications.Messages;
using Studio.Framework;
using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Windows.Forms;

namespace Studio.Presentation
{
	public partial class MainForm : Form, IClient
	{
		EntityContext context;


		public MainForm()
		{
			InitializeComponent();
		}


		private void OnLoad(object sender, EventArgs e)
		{
			context = new EntityContext();
			Database.SetInitializer(new EntityInitializer());
			context.ClearTables();
			context.SaveChanges();
			context.RuntimeModules.Load();
		}


		#region TableControl

		private void TableControl_OnNodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			//TableSelected(e.Node.Text);
		}

		private void TableSelected(string tableName)
		{
			//try
			//{
			//	this.c_TableLabel.Text = tableName;
			//	this.c_SourceBinding.DataMember = tableName;
			//	this.c_EntityNavigator.DataMember = tableName;
			//	this.c_ChartView.SelectPage(tableName + "_TabPage");
			//	Program.App.Log("You have selected the " + tableName + " context table.");
			//}
			//catch (Exception exception)
			//{
			//	var message = ExceptionHelper.GetWarning(exception);
			//	var item = new MessageItem("The table '" + tableName + "' you selected threw an exception! \n" + message, MessagePriority.Hot);
			//	Program.App.Log(item);
			//}
		}

		#endregion


		#region GridControl

		private void GridControl_OnSelectionChanged(object sender, EventArgs e)
		{

		}

		#endregion


		#region IClient

		public void Log(string message, BindingList<string> history)
		{
			throw new NotImplementedException("IClient member is not implemented.");
		}

		public void Log(MessageItem message, BindingList<string> history)
		{
			throw new NotImplementedException("IClient member is not implemented.");
		}

		#endregion


	}
}
