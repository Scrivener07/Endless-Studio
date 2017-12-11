using System;
using System.Windows.Forms;

namespace Sharp.Reporting
{
	public partial class MessageWidget : UserControl, IMessage
	{

		public MessageWidget()
		{
			InitializeComponent();
		}


		void OnLoad(object sender, EventArgs e)
		{
			//Dummy();
		}


		public void Message(string text, int image = -1, bool popup = false)
		{
			ListViewItem listViewItem = new ListViewItem(text, image);
			c_ErrorsListView.Items.Add(listViewItem);
			listViewItem.EnsureVisible();

			if (popup)
			{
				if (image == MessageIcon.Error || image == MessageIcon.Warning)
				{
					MessageBox.Show(this, text);
				}
			}
		}


		public void Clear()
		{
			c_ErrorsListView.Items.Clear();
		}


		private void Dummy()
		{
			Clear();
			Message("This is a standard message.", MessageIcon.None);
			Message("This is an information message.", MessageIcon.Information);
			Message("This is a success message.", MessageIcon.Complete);
			Message("This is a warning message.", MessageIcon.Warning);
			Message("This is an error message.", MessageIcon.Error);
		}


	}
}
