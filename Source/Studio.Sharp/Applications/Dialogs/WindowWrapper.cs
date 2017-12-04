using System;
using System.Windows.Forms;

namespace Sharp.Applications.Dialogs
{
	/// <summary>
	/// Creates IWin32Window around an IntPtr.
	/// </summary>
	public class WindowWrapper : IWin32Window
	{
		/// <summary>
		/// Original pointer
		/// </summary>
		public IntPtr Handle { get { return handleField; } }
		private IntPtr handleField;


		/// <summary>
		/// Creates a WindowWrapper.
		/// </summary>
		/// <param name="handle">The dandle to wrap.</param>
		public WindowWrapper(IntPtr handle)
		{
			handleField = handle;
		}


	}
}
