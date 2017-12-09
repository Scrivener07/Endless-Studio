using System;
using System.Windows.Forms;

namespace Sharp.Applications.Controls
{
	public partial class ProgressWidget : UserControl
	{

		public int ProgressValue { get { return this.c_ProgressBar.Value; } set { this.c_ProgressBar.Value = value; } }
		public string ProgressText { get { return this.c_ProgressLabel.Text; } set { this.c_ProgressLabel.Text = value; } }


		public ProgressWidget()
		{
			InitializeComponent();
		}


		private void OnLoad(object sender, EventArgs e)
		{

		}


		private void ProgressLabel_OnTextChanged(object sender, EventArgs e)
		{

		}


	}
}
