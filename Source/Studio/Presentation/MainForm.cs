using Sharp.Applications;
using Sharp.Reporting;
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
			propertyGrid1.SelectedObject = Program.Game;
		}


		private void testToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Program.Game.Steam.Executable.OpenDirectory();
		}


		#region IClient

		public void Log(string message, BindingList<string> history)
		{
			Trace.WriteLine(message);
		}

		public void Log(MessageItem message, BindingList<string> history)
		{
			Trace.WriteLine(message);
		}

		#endregion


		#region Vanilla

		private void OnProgress(ProgressEventArgs e)
		{
			try
			{
				var window = Program.Studio.GetMessageWindow();
				if (window != null)
				{
					messageWidget1.Message(e.Text, e.Image);
				}
			}
			catch (Exception exception)
			{
				throw exception;
			}
		}


		private async void allocateToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var progress = new Progress<ProgressEventArgs>(OnProgress);
			await Program.Game.AllocateAsync(progress);
		}

		private async void importToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var progress = new Progress<ProgressEventArgs>(OnProgress);
			await Program.Game.ImportAsync(progress);
		}

		private async void exportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var progress = new Progress<ProgressEventArgs>(OnProgress);
			await Program.Game.ExportAsync(progress);
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


	}
}
