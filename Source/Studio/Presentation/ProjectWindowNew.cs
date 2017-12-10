using Sharp.Applications;
using Sharp.Applications.Dialogs;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Studio.Presentation
{
	public partial class ProjectWindowNew : Form
	{

		public ProjectWindowNew()
		{
			InitializeComponent();
		}



		#region Loading

		void OnLoad(object sender, EventArgs e)
		{
			Program.Studio.Log("Loading the " + Text + " project window.");
			c_UserDataSelectButton.Enabled = true;
			c_UserDataTextBox.Enabled = true;
			c_SourceSelectButton.Enabled = false;
			c_SourceTextBox.Enabled = false;
			c_AcceptButton.Enabled = false;
			c_NameTextBox.Enabled = false;
		}



		void OnProgress(ProgressEventArgs e)
		{
			if (!String.IsNullOrWhiteSpace(e.Text))
			{
				c_MessageWidget.Message(e.Text, e.Image);
			}

			c_ProgressWidget.ProgressValue = e.Percentage;
			c_ProgressWidget.ProgressText = e.Percentage + "%";
		}

		#endregion


		#region User Selection

		private void UserDataSelectButton_OnClick(object sender, EventArgs e)
		{
			c_UserDataTextBox.Text = SharpDialog.ShowFolderSelect(Program.Game.User.Location);
		}


		private void UserDataTextBox_OnTextChanged(object sender, EventArgs e)
		{
			c_UserDataTextBox.BackColor = Color.MistyRose;

			c_SourceSelectButton.Enabled = false;
			c_SourceTextBox.Enabled = false;
			c_SourceTextBox.Text = null;

			c_NameTextBox.BackColor = Color.MistyRose;
			c_NameTextBox.Enabled = false;
			c_NameTextBox.Text = null;

			var progress = new Progress<ProgressEventArgs>(OnProgress);
			Program.Game.New(c_UserDataTextBox.Text, progress);

			if (Program.Game.Project.Index.HasFormat)
			{
				c_UserDataTextBox.BackColor = Color.Honeydew;

				c_NameTextBox.Enabled = true;
				c_NameTextBox.Text = Program.Game.Project.Index.Xml.Name;

				c_SourceSelectButton.Enabled = true;
				c_SourceTextBox.Enabled = true;
			}
		}

		#endregion


		#region Naming

		private void NameTextBox_OnTextChanged(object sender, EventArgs e)
		{
			c_NameTextBox.BackColor = Color.MistyRose;

			if (Program.Game.Project.Index.HasXmlData)
			{
				c_NameTextBox.BackColor = Color.Honeydew;


				if (String.IsNullOrWhiteSpace(c_NameTextBox.Text))
				{
					c_NameTextBox.Text = new DirectoryInfo(Program.Game.Project.Index.Location).Name;
				}

				Program.Game.Project.Index.Xml.Name = c_NameTextBox.Text;
			}
		}

		#endregion


		#region Source Selection

		private void SourceSelectButton_OnClick(object sender, EventArgs e)
		{
			c_SourceTextBox.Text = SharpDialog.ShowFileBrowser(Program.Game.Steam.Location);

			var progress = new Progress<ProgressEventArgs>(OnProgress);
			Program.Game.Project.DependenciesSetSource(c_SourceTextBox.Text, progress);
		}



		private void SourceSelectTextBox_OnTextChanged(object sender, EventArgs e)
		{
			c_SourceTextBox.BackColor = Color.MistyRose;

			if (Program.Game.Project.Index.HasXmlData)
			{
				if (Program.Game.Project.Index.Xml.Game_Depreciated.Standalone || Program.Game.Project.DependenciesHasSource)
				{
					c_SourceTextBox.BackColor = Color.Honeydew;
					c_AcceptButton.Enabled = true;
					return;
				}
			}
		}

		#endregion


		#region Confirm

		private async void AcceptButton_OnClick(object sender, EventArgs e)
		{
			var progress = new Progress<ProgressEventArgs>(OnProgress);
			if (Program.Game.Project.Index.HasXmlData)
			{
				if (await Program.Game.Project.ImportAsync(progress))
				{
					Program.Game.Project.InvokeUpdate();
					MessageBox.Show("All Done!");


					new ProjectWindowProperties().Show();
				}
			}
		}


		private void CancelButton_OnClick(object sender, EventArgs e)
		{
			Program.Studio.Log("You closed the NEW window.");
			Close();
		}

		#endregion


	}
}
