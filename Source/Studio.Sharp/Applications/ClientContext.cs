using Sharp.Applications.Messages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace Sharp.Applications
{
	public class ClientContext<T> : ApplicationContext where T : Form, IClient
	{
		protected readonly T Client = null;

		public FormCollection OpenForms { get { return Application.OpenForms; } }
		public BindingList<string> History { get; private set; }


		public ClientContext(T client) : base(client)
		{
			Client = client ?? throw new ArgumentNullException("client", "The argument Form cannot be null.");
			History = new BindingList<string>();
		}


		public virtual void ShowWindow(Form form)
		{
			if (form != null)
			{
				foreach (Form child in OpenForms)
				{
					if (child.GetType() == form.GetType())
					{
						child.WindowState = FormWindowState.Normal;
						child.Focus();
						return;
					}
				}

				form.StartPosition = FormStartPosition.CenterScreen;
				form.Show();
			}
		}















		public virtual void ShowDialog(Form form)
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


		public virtual void CloseAll(List<string> ignores = null)
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












		#region IClient

		public virtual void Log(string message = null, bool isHot = false)
		{
			var client = Client as IClient;

			if (!String.IsNullOrWhiteSpace(message))
			{
				client.Log(message, History);
			}
		}


		public virtual void Log(MessageItem message)
		{
			var client = Client as IClient;

			if (!String.IsNullOrWhiteSpace(message.Text))
			{
				client.Log(message, History);
			}
		}

		#endregion

	}
}
