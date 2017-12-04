using System;
using System.Windows.Forms;


namespace Sharp.Applications.Dialogs
{
	public static class SharpDialog
	{
		public static string ShowTextDialog(string text, string caption)
		{
			Form prompt = new Form();
			prompt.Width = 500;
			prompt.Height = 150;
			prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
			prompt.Text = caption;
			prompt.StartPosition = FormStartPosition.CenterScreen;
			Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
			TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
			Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70 };
			confirmation.Click += (sender, e) => { prompt.Close(); };
			prompt.Controls.Add(textBox);
			prompt.Controls.Add(confirmation);
			prompt.Controls.Add(textLabel);
			prompt.AcceptButton = confirmation;
			prompt.ShowDialog();
			return textBox.Text;
		}


		public static string ShowFileBrowser(string initialdirectory, string filter = FileFilter.Any)
		{
			var fileBrowse = new OpenFileDialog();
			fileBrowse.CheckFileExists = true;
			fileBrowse.Filter = filter;
			fileBrowse.InitialDirectory = initialdirectory;
			fileBrowse.FileName = null;

			if (fileBrowse.ShowDialog() == DialogResult.OK)
			{
				return fileBrowse.FileName;
			}
			else
			{
				return null;
			}
		}


		public static string ShowFolderBrowser(string initialdirectory)
		{
			var browser = new FolderBrowserDialog();
			browser.ShowNewFolderButton = true;
			browser.SelectedPath = initialdirectory;

			if (browser.ShowDialog(new WindowWrapper(IntPtr.Zero)) != DialogResult.OK)
			{
				return String.Empty;
			}

			return browser.SelectedPath;
		}


		public static string ShowFolderSelect(string initialdirectory)
		{
			var browser = new OpenFileDialog();
			browser.InitialDirectory = initialdirectory;
			browser.Filter = FileFilter.Folders;
			browser.AddExtension = false;
			browser.CheckFileExists = false;
			browser.DereferenceLinks = true;
			browser.Multiselect = false;

			if (Environment.OSVersion.Version.Major >= 6)
			{
				var reflector = new DialogReflector("System.Windows.Forms");

				uint num = 0;
				Type typeIFileDialog = reflector.GetType("FileDialogNative.IFileDialog");

				object dialog = reflector.Call(browser, "CreateVistaDialog");
				reflector.Call(browser, "OnBeforeVistaDialog", dialog);

				uint options = (uint)reflector.CallAs(typeof(System.Windows.Forms.FileDialog), browser, "GetOptions");
				options |= (uint)reflector.GetEnum("FileDialogNative.FOS", "FOS_PICKFOLDERS");
				reflector.CallAs(typeIFileDialog, dialog, "SetOptions", options);

				object pfde = reflector.New("FileDialog.VistaDialogEvents", browser);
				object[] parameters = new object[] { pfde, num };

				reflector.CallAs2(typeIFileDialog, dialog, "Advise", parameters);
				num = (uint)parameters[1];

				try
				{
					int ret0 = (int)reflector.CallAs(typeIFileDialog, dialog, "Show", IntPtr.Zero);
					if (ret0 == 0)
					{
						return browser.FileName;
					}
				}
				finally
				{
					reflector.CallAs(typeIFileDialog, dialog, "Unadvise", num);
					GC.KeepAlive(pfde);
				}
			}
			else
			{
				return ShowFolderBrowser(initialdirectory);
			}

			return String.Empty;
		}


	}
}
