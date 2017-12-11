using Sharp.Reporting;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Studio.Presentation
{
	public partial class MessageStatusStrip : UserControl
	{
		public MessageStatusStrip()
		{
			InitializeComponent();
		}

		void OnLoad(object sender, EventArgs e)
		{
			AutoSize = true;

			// This makes the designer crash.
			// this.Log("The quick brown fox jumped over this lazy dog.", Program.App.History);
			// this.Log("The quick brown fox jumped over this lazy dog again, and this quick brown fox jumped over this lazy dog again, and this quick brown fox jumped over this lazy dog again.", Program.App.History);
			// this.Log(new MessageItem("The quick brown fox jumped over this lazy dog and raised the red flag.", MessagePriority.Hot), Program.App.History);
		}


		private void ToolStrip_OnItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			if (e.ClickedItem == c_MessageHistoryDropDown)
			{
				c_MessageHistoryDropDown.Image = ES2.Properties.Resources.FlagThreadNotFlagged_16x;
			}

			if (e.ClickedItem == c_MessageHistoryClearButton)
			{
				c_MessageHistoryClearButton.Enabled = false;
				c_MessageHistoryDropDown.Enabled = false;
				c_MessageHistoryDropDown.Image = ES2.Properties.Resources.FlagThreadNotFlagged_16x;
				Program.Studio.History.Clear();
				c_MessageHistoryDropDown.DropDownItems.Clear();
			}
		}


		public void Log(MessageItem message, BindingList<string> history)
		{
			c_MessageLabel.Text = message.Text;
			history.Add(message.Text);

			if (history.Count > 0)
			{
				c_MessageHistoryClearButton.Enabled = true;
				c_MessageHistoryDropDown.Enabled = true;
			}
			else
			{
				c_MessageHistoryClearButton.Enabled = false;
				c_MessageHistoryDropDown.Enabled = false;
			}

			var entry = new ToolStripLabel() { Text = message.Text, Name = message.Text, Image = new Bitmap(16, 16) };
			c_MessageHistoryDropDown.Image = ES2.Properties.Resources.Flag_16x;

			if (message.Priority == MessagePriority.Hot)
			{
				entry.Image = ES2.Properties.Resources.FlagThreadFlagged_16x;
				c_MessageHistoryDropDown.Image = ES2.Properties.Resources.FlagThreadFlagged_16x;
			}

			c_MessageHistoryDropDown.DropDownItems.Add(entry);
		}


		public void Log(string message, BindingList<string> history)
		{
			c_MessageLabel.Text = message;

			history.Add(message);
			if (history.Count > 0)
			{
				c_MessageHistoryClearButton.Enabled = true;
				c_MessageHistoryDropDown.Enabled = true;
			}
			else
			{
				c_MessageHistoryClearButton.Enabled = false;
				c_MessageHistoryDropDown.Enabled = false;
			}
			var entry = new ToolStripLabel() { Text = message, Name = message, Image = new Bitmap(16, 16) };
			c_MessageHistoryDropDown.Image = ES2.Properties.Resources.Flag_16x;
			c_MessageHistoryDropDown.DropDownItems.Add(entry);
		}


	}
}
