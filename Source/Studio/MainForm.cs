using System;
using System.Windows.Forms;

namespace Studio
{
	public partial class MainForm : Form
	{
		StudioContext context;


		public MainForm()
		{
			context = new StudioContext();
			InitializeComponent();
		}


		private void OnLoad(object sender, EventArgs e)
		{
			propertyGrid.SelectedObject = context.DataSource;
		}


	}
}
