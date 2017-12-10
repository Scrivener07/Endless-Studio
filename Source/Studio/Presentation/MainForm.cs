using Sharp.Applications;
using Sharp.Applications.Messages;
using System;
using System.ComponentModel;
using System.Diagnostics;
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
		}


		#region IClient

		public void Log(string message, BindingList<string> history)
		{
			Trace.WriteLine(message);
			//messageStatusStrip1.Log(message, Program.Studio.History);
		}

		public void Log(MessageItem message, BindingList<string> history)
		{
			Trace.WriteLine(message);
			//messageStatusStrip1.Log(message, Program.Studio.History);
		}

		#endregion


		#region ToolStrip

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


		#endregion


		#region Dummy

		void OnProgress(ProgressEventArgs e)
		{

		}


		private void Main_OpenButton_Click(object sender, EventArgs e)
		{
			var progress = new Progress<ProgressEventArgs>(OnProgress);
			Program.Game.Open(progress);
		}


		private void Main_SaveButton_Click(object sender, EventArgs e)
		{
			var progress = new Progress<ProgressEventArgs>(OnProgress);
			Program.Game.Save(progress);
		}


		#endregion


	}
}
