using Sharp.Applications.Messages;
using System;
using System.ComponentModel;
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
			if (client == null)
				throw new ArgumentNullException("client", "The argument Form cannot be null.");

			Client = client;
			History = new BindingList<string>();
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
