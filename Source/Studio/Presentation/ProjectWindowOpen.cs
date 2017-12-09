using ES2.Editor;
using Sharp.Applications;
using Sharp.Applications.Dialogs;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Studio.Presentation
{
	public partial class ProjectWindowOpen : Form
	{

		public ProjectWindowOpen()
		{
			InitializeComponent();
		}


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


		private void c_UserDataSelectButton_Click(object sender, EventArgs e)
		{
			c_UserDataTextBox.Text = SharpDialog.ShowFileBrowser(Program.Game.User.Location, "Modification |index.xml");
		}


		private void c_UserDataTextBox_TextChanged(object sender, EventArgs e)
		{
			c_UserDataTextBox.BackColor = Color.MistyRose;

			c_SourceSelectButton.Enabled = false;
			c_SourceTextBox.BackColor = Color.MistyRose;
			c_SourceTextBox.Enabled = false;
			c_SourceTextBox.Text = null;

			c_NameTextBox.BackColor = Color.MistyRose;
			c_NameTextBox.Enabled = false;
			c_NameTextBox.Text = null;

			var progress = new Progress<ProgressEventArgs>(OnProgress);

			if (Program.Game.Project.Open(c_UserDataTextBox.Text, progress))
			{
				if (Program.Game.Project.DataManagerIndex.HasXml)
				{
					c_UserDataTextBox.BackColor = Color.White;

					c_NameTextBox.Enabled = false;
					c_NameTextBox.Text = Program.Game.Project.DataManagerIndex.GetName();
					c_NameTextBox.BackColor = Color.White;

					if (Program.Game.Project.DataManagerIndex.Xml.Game.Standalone)
					{
						c_SourceSelectButton.Enabled = false;
						c_SourceTextBox.Enabled = false;
						c_SourceTextBox.Text = "The modification is already a standalone source.";
						c_SourceTextBox.BackColor = Color.White;
						c_AcceptButton.Enabled = true;
					}
					else
					{

						if (Program.Game.Project.DependenciesHasSource)
						{
							c_SourceTextBox.Text = Program.Game.Project.DependenciesSource.DataManagerIndex.FilePath;
							c_SourceTextBox.BackColor = Color.White;
							c_AcceptButton.Enabled = true;
						}
						else
						{
							c_SourceSelectButton.Enabled = true;
							c_SourceTextBox.Enabled = true;
						}
					}


				}
			}
		}


		private void c_SourceSelectButton_Click(object sender, EventArgs e)
		{
			c_SourceTextBox.Text = SharpDialog.ShowFileBrowser(Program.Game.Game.Location, "Modification |index.xml");

			var progress = new Progress<ProgressEventArgs>(OnProgress);
			Program.Game.Project.DependenciesSetSource(c_SourceTextBox.Text, progress);
		}


		private void c_SourceTextBox_TextChanged(object sender, EventArgs e)
		{
			if (c_SourceTextBox.Enabled)
			{
				c_SourceTextBox.BackColor = Color.MistyRose;
				if (Program.Game.Project.DependenciesHasSource && Program.Game.Project.DependenciesSource.DataManagerIndex.HasXml)
				{
					// do stuff
				}
			}
		}


		private async void c_AcceptButton_Click(object sender, EventArgs e)
		{
			if (Program.Game.Project.DataManagerIndex.HasXml || Program.Game.Project.State == ProjectState.Ready)
			{
				c_AcceptButton.Enabled = false;
				c_CancelButton.Enabled = false;
				c_UserDataSelectButton.Enabled = false;
				c_UserDataTextBox.Enabled = false;
				c_SourceSelectButton.Enabled = false;
				c_SourceTextBox.Enabled = false;

				var progress = new Progress<ProgressEventArgs>(OnProgress);

				if (await Program.Game.Project.ImportAsync(progress))
				{
					Program.Game.Project.InvokeUpdate();
					c_CancelButton.Enabled = true;
					MessageBox.Show("All Done!");
					new ProjectWindowProperties().Show();
				}
			}
		}


		private void c_CancelButton_Click(object sender, EventArgs e)
		{
			Close();
		}


	}
}
