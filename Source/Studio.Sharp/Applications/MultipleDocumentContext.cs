using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace Sharp.Applications
{
	public class MultipleDocumentContext<T> : ClientContext<T> where T : Form, IClient
	{
		public MultipleDocumentContext(T client) : base(client)
		{
			if (client.IsMdiContainer == false)
				throw new ArgumentContextException("The argument Form must have 'IsMdiContainer' enabled.");
		}


		public override void ShowWindow(Form form)
		{
			if (Client is T && Client.IsMdiContainer)
			{
				if (form != null)
				{
					foreach (Form child in Client.MdiChildren)
					{
						if (child.GetType() == form.GetType())
						{
							child.WindowState = FormWindowState.Normal;
							child.Focus();
							return;
						}
					}
					form.StartPosition = FormStartPosition.CenterScreen;
					form.MdiParent = Client;
					form.Show();
				}
			}
		}


		public override void ShowDialog(Form form)
		{
			if (Client is IClient && Client.IsMdiContainer)
			{
				try
				{
					if (form != null)
					{
						form.StartPosition = FormStartPosition.CenterScreen;
						form.ShowDialog(Client);
					}
				}
				catch (Exception exception)
				{
					Trace.WriteLine(exception.InnerException.Message);
				}
			}
		}


		public override void CloseAll(List<string> ignores = null)
		{
			if (ignores == null || ignores.Count <= 0)
			{
				foreach (Form child in Client.MdiChildren)
				{
					child.Close();
				}
				return;
			}
			else
			{
				foreach (Form child in Client.MdiChildren)
				{
					if (!ignores.Contains(child.GetType().Name))
					{
						child.Close();
					}
				}
				return;
			}
		}


	}
}
