using ES2.Amplitude.Unity.Runtime;
using Sharp.Reporting;
using Sharp.Storage.Special;
using System;

namespace ES2.Editor.Assets
{
	public class ModificationAsset : XmlAsset<RuntimeModule>
	{
		public override RuntimeModule Xml { get; protected set; }

		public string ModName
		{
			get
			{
				if (Xml != null) { return Xml.Name; }
				else { return "null"; }
			}
		}


		public ModificationAsset(string filepath) : base(filepath)
		{
			Xml = null;
		}


		#region Xml-Operations

		public override bool Read(IProgress<ProgressEventArgs> progress = null)
		{
			if (Exists)
			{
				try
				{
					Xml = RuntimeModule.Deserialize(FilePath);
				}
				catch (Exception exception)
				{
					string warning = MessageFormat.GetWarning(exception);
					Logs.Entry(warning);
					Report.Progress(progress, Report.Message(warning, MessageIcon.Error));
					return false;
				}
				return PostRead(progress);
			}
			else
			{
				string warning = "The file at " + FilePath + " does not exist.";
				Logs.Entry(warning);
				Report.Progress(progress, Report.Message(warning, MessageIcon.Warning));
				return false;
			}
		}

		private bool PostRead(IProgress<ProgressEventArgs> progress = null)
		{
			if (!IsNull)
			{
				string message = "The modification " + Xml.Name + " has been read from the file " + FilePath;
				Logs.Entry(message);
				Report.Progress(progress, Report.Message(message));
				return true;
			}
			else
			{
				string warning = "Could not read the file at " + FilePath;
				Logs.Entry(warning);
				Report.Progress(progress, Report.Message(warning, MessageIcon.Warning));
				return false;
			}
		}


		public override bool Write(IProgress<ProgressEventArgs> progress = null)
		{
			throw new NotImplementedException("Writing a runtime module to disk is not yet implemented.");
		}

		#endregion


		public override string ToString()
		{
			if (!IsNull)
				if (!String.IsNullOrWhiteSpace(Xml.Name))
					return Xml.Name;
			if (!String.IsNullOrWhiteSpace(URI))
				return URI;
			return "null";
		}


	}
}
