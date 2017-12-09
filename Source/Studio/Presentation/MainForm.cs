using Sharp.Applications;
using Sharp.Applications.Messages;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Studio.Presentation
{
	public partial class MainForm : Form, IClient
	{
		public MainForm()
		{
			InitializeComponent();
		}


		private void OnLoad(object sender, EventArgs e)
		{
			Main_ProjectControl.Context = Program.Game;
		}


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


		private void ViewMessages_ToolStripMenuItem_OnClick(object sender, EventArgs e)
		{
			Program.Studio.ShowMessages();
		}

		private void FileNew_ToolStripMenuItem_OnClick(object sender, EventArgs e)
		{
			Program.Studio.ShowProjectNew();
		}

		private void FileOpen_ToolStripMenuItem_OnClick(object sender, EventArgs e)
		{
			Program.Studio.ShowProjectOpen();
		}

		private void FileExit_ToolStripMenuItem_OnClick(object sender, EventArgs e)
		{
			Application.Exit();
		}


	}
}
