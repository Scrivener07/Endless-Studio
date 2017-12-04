using System;
using System.Windows.Forms;

namespace Sharp.Applications.Messages
{
	public static class ExceptionMessage
	{
		private static class ExceptionParse
		{
			public const int Type = 0;
			public const int Message = 1;
			public const int Stack = 2;
			public const int Site = 3;
		}


		public static string GetWarning(this Exception exception)
		{
			if (exception == null)
				return "The exception is null.";
			else if (exception.InnerException == null)
				return exception.Message;
			else
				return exception.InnerException.Message;
		}


		public static void ShowBox(this Exception exception)
		{
			var outer = Parse(exception);
			var inner = Parse(exception.InnerException);
			const string div = "----------------------------------------------------------------";

			var message = String.Concat
			(
				String.Concat("Outer Exception", "\n", div, "\n", div, "\n"),
				String.Concat("Type: ", outer[ExceptionParse.Type], "\n"),
				String.Concat("Message: ", outer[ExceptionParse.Message], "\n"),
				String.Concat("Site: ", outer[ExceptionParse.Site], "\n"),
				String.Concat("Stack:\n", outer[ExceptionParse.Stack], "\n\n\n"),

				String.Concat("Inner Exception", "\n", div, "\n", div, "\n"),
				String.Concat("Type: ", inner[ExceptionParse.Type], "\n"),
				String.Concat("Message: ", inner[ExceptionParse.Message], "\n"),
				String.Concat("Site: ", inner[ExceptionParse.Site], "\n"),
				String.Concat("Stack: ", inner[ExceptionParse.Stack], "\n")
			);
			MessageBox.Show(message);
		}


		private static string[] Parse(this Exception exception)
		{
			if (exception == null)
			{
				return new string[4];
			}
			else
			{
				string[] format = new string[4];
				format[ExceptionParse.Type] = exception.GetType().Name;
				format[ExceptionParse.Message] = exception.Message;
				format[ExceptionParse.Stack] = exception.StackTrace;
				format[ExceptionParse.Site] = exception.TargetSite.DeclaringType.ToString();
				return format;
			}
		}


	}
}
