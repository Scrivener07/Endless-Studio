using Sharp.Applications;
using Sharp.Applications.Messages;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Studio.Presentation
{
	public partial class MainForm : Form, IClient
	{
		public MainForm()
		{
			InitializeComponent();
		}


		#region IClient

		public void Log(string message, BindingList<string> history)
		{
			throw new NotImplementedException("IClient member is not implemented.");
		}

		public void Log(MessageItem message, BindingList<string> history)
		{
			throw new NotImplementedException("IClient member is not implemented.");
		}

		#endregion


	}
}
