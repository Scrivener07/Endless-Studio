using System;

namespace ES2.Editor.Framework.Binding
{
	/// <summary>
	/// Provides data for the <see cref="DataError"/> event.
	/// </summary>
	public class DataErrorEventArgs : EventArgs
	{
		/// <summary>
		/// Gets or sets the <see cref="Exception"/> that triggered the event.
		/// </summary>
		public Exception Exception { get; set; }

		/// <summary>
		/// Whether the error was handled and the source exception should be ignored.
		/// </summary>
		public bool Handled { get; set; }


		/// <summary>
		/// Initializes a new instance of a <see cref="DataErrorEventArgs"/>.
		/// </summary>
		/// <param name="exception"><see cref="Exception"/> that triggered the event.</param>
		public DataErrorEventArgs(Exception exception)
		{
			Exception = exception;
		}


	}
}
