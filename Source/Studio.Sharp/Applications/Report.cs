using System;

namespace Sharp.Applications
{
	public static class Report
	{
		public const bool Failed = false;
		public const bool Success = true;
		public const bool Complete = true;


		public static void Progress(IProgress<ProgressEventArgs> progress, ProgressEventArgs arg)
		{
			if (progress == null)
			{
				return;
			}
			progress.Report(arg);
		}


		public static ProgressEventArgs Message(string message, int image = -1)
		{
			return new ProgressEventArgs(0, message, image);
		}


		public static ProgressEventArgs Percent(int percent, string message = null, int image = -1)
		{
			return new ProgressEventArgs(percent, message, image);
		}


		public static ProgressEventArgs Percent(int total, int completed, string message = null, int image = -1)
		{
			int percent = CalculatePercent(total, completed);
			return new ProgressEventArgs(percent, message, image);
		}


		public static int CalculatePercent(int total, int completed)
		{
			int percentage = (total <= 0 ? 0 : (100 * completed) / total);
			return percentage;
		}


	}
}
