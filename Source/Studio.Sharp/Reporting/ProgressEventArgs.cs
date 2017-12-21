using System;
using System.Diagnostics;

namespace Sharp.Reporting
{
	[DebuggerStepThrough]
	public class ProgressEventArgs : EventArgs
	{
		public readonly int Percentage;
		public readonly string Text;
		public readonly int Image;

		public ProgressEventArgs(int percentage = 0, string message = null, int image = -1)
		{
			Percentage = percentage;
			Text = message;
			Image = image;
		}
	}
}
