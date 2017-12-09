using System;
using System.Windows.Forms;

namespace Studio.Presentation
{
	public partial class ProjectWindowProperties : Form
	{
		public ProjectWindowProperties()
		{
			InitializeComponent();
		}


		private void OnLoad(object sender, EventArgs e)
		{
			bindingSource1.DataSource = Program.Game.Project;
		}


		private void bindingSource1_CurrentChanged(object sender, EventArgs e)
		{
			c_PropertyGrid.SelectedObject = Program.Game.Project;

		}


		private void DataWindow_Activated(object sender, EventArgs e)
		{
			c_PropertyGrid.SelectedObject = Program.Game.Project;
		}


	}
}
