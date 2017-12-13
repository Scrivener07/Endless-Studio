using Sharp.Applications;
using Sharp.Applications.Dialogs;
using Studio.Presentation;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace Studio
{
	public class StudioContext<T> : ClientContext<T> where T : Form, IClient
	{
		public string Name { get; private set; }
		public Version Version { get; private set; }


		public StudioContext(T client) : base(client)
		{
			Name = "Endless Studio";
			Version = new Version(0, 3, 1, 0);
			MainForm = new MainSplash();
			Initialize();
		}


		private async void Initialize()
		{
			if (MainForm is ISplash)
			{
				var splash = MainForm as ISplash;
				splash.SetFade(true);
				splash.Title = Name;
				splash.PrimaryMessage = String.Concat(Name, " v", Version.ToString());
				splash.SecondaryMessage = String.Concat("Supports v", Program.Game.Supported.ToString());

				if (await Task.Run(() => Program.Initialize()))
				{
					MainForm.Close();
				}
			}
		}


		protected override void OnMainFormClosed(object sender, EventArgs e)
		{
			if (sender is ISplash)
			{
				MainForm = Client;
				MainForm.Show();
			}
			else if (sender is T)
			{
				base.OnMainFormClosed(sender, e);
			}
		}


		#region Windows

		public void ShowProjectNew()
		{
			throw new NotImplementedException();
			//ShowWindow(new ProjectWindowNew());
		}


		public void ShowProjectOpen()
		{
			throw new NotImplementedException();
			//ShowWindow(new ProjectWindowOpen());
		}


		public void ShowProjectProperties()
		{
			throw new NotImplementedException();
			//ShowWindow(new ProjectWindowProperties());
		}

		[Obsolete]
		public void ShowMessages()
		{
			// TODO: depreciate StudioContext.ShowMessages
			//GetMessageWindow(); 
		}


		public MessageWindow GetMessageWindow()
		{
			var query = OpenForms.Cast<Form>().Where(form => form.Name == "MessageWindow");
			if (query is MessageWindow)
			{
				return query as MessageWindow;
			}
			else
			{
				MessageWindow window = new MessageWindow();
				ShowWindow(window);
				return window;
			}

		}

		#endregion


	}
}