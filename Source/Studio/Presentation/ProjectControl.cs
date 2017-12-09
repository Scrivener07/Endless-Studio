using System;
using System.Windows.Forms;

namespace Studio.Presentation
{
	public partial class ProjectControl : UserControl
	{
		public object Context
		{
			get { return propertyGrid1.SelectedObject; }
			set { propertyGrid1.SelectedObject = value; }
		}


		public ProjectControl()
		{
			InitializeComponent();
		}


		private void OnLoad(object sender, EventArgs e)
		{

		}


	}
}
