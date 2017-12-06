using System;
using System.Windows.Forms;

namespace Sharp.Applications.Dialogs
{
	public partial class SplashBase : Form, ISplash
	{
		protected SplashState status = SplashState.Opened;
		protected bool fadeClose = false;
		protected const int fadeInterval = 50;
		protected const double fadeOpacityStep = .05;


		public SplashBase()
		{
			InitializeComponent();
			Ticker.Interval = fadeInterval;
			Title = "Sample Title";
			PrimaryMessage = "Sample Message 1";
			SecondaryMessage = "Sample Message 2";
		}


		private void OnLoad(object sender, EventArgs e)
		{
			Ticker.Enabled = true;
		}


		#region ISplash Members

		public string Title { get { return TitleLabel.Text; } set { TitleLabel.Text = value; } }
		public string PrimaryMessage { get { return MessageLabel1.Text; } set { MessageLabel1.Text = value; } }
		public string SecondaryMessage { get { return MessageLabel2.Text; } set { MessageLabel2.Text = value; } }

		public bool DoFadeOpen { set { if (value) { Opacity = 0; status = SplashState.Opening; } } }
		public bool DoFadeClose { set { fadeClose = value; } }


		public virtual void SetFade(bool enable)
		{
			DoFadeOpen = enable;
			DoFadeClose = enable;
		}

		#endregion



		private void OnTick(object sender, EventArgs e)
		{
			if (status == SplashState.Opening)
			{
				if (Opacity < 1)
					Opacity += fadeOpacityStep;
				else
					status = SplashState.Opened;
			}
			else if (status == SplashState.Closing)
			{
				if (Opacity > .10)
				{
					Opacity -= fadeOpacityStep;
				}
				else
				{
					status = SplashState.Closed;
				}
			}
			else if (status == SplashState.Closed)
			{
				Ticker.Enabled = false;
				Ticker.Dispose();
				Close();
			}
		}


		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			if (status == SplashState.Opened)
			{
				if (fadeClose)
					status = SplashState.Closing;
				else
					status = SplashState.Closed;
			}
		}


	}
}
