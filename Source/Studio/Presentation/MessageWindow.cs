using System;
using System.Windows.Forms;

namespace Studio.Presentation
{
	public partial class MessageWindow : Form
	{
		public MessageWindow()
		{
			InitializeComponent();
		}

		private void MessageWindow_Load(object sender, EventArgs e)
		{
			messageStatusStrip1.Log("", Program.Studio.History);
		}
	}
}
