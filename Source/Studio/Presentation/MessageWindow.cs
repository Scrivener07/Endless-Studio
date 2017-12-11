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
			bindingSource1.DataSource = Program.Studio.History;
		}


		public void Message(string text, int image = -1, bool popup = false)
		{
			Program.Studio.History.Add(text);
			messageWidget1.Message(text, image, popup);
		}


		public void Clear()
		{
			messageWidget1.Clear();
		}


	}
}
