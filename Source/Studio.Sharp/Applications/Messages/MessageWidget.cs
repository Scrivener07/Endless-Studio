using System;
using System.Windows.Forms;

namespace Sharp.Applications.Messages
{
	public partial class MessageWidget : UserControl
	{

		public MessageWidget()
		{
			InitializeComponent();
		}


		void OnLoad(object sender, EventArgs e)
		{

		}


		public void Message(string text, int image = -1, bool popup = false)
		{
			ListViewItem message = new ListViewItem(text, image);
			this.c_ErrorsListView.Items.Add(message);
			//		this.c_ErrorsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent); //performance heavy for EVERY call
			message.EnsureVisible();

			if (popup)
			{
				if (image == DisplayIcon.Error || image == DisplayIcon.Warning)
				{
					MessageBox.Show(this, text);
				}
			}
		}


		public void Clear()
		{
			this.c_ErrorsListView.Items.Clear();
		}


		public void Dummy()
		{
			Clear();
			Message("This is a standard message.", DisplayIcon.None);
			Message("This is an information message.", DisplayIcon.Information);
			Message("This is a success message.", DisplayIcon.Complete);
			Message("This is a warning message.", DisplayIcon.Warning);
			Message("This is an error message.", DisplayIcon.Error);
		}


	}
}
