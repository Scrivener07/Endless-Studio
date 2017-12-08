using ES2.Amplitude.Unity.Runtime;
using Sharp.Applications;
using Sharp.Applications.Messages;
using Sharp.Applications.Storage.Special;
using System;
using System.IO;

namespace ES2.Editor.Assets
{
	public class ModificationAsset : XmlAsset<RuntimeModule>
	{
		public override RuntimeModule Xml { get; set; }


		public ModificationAsset() : base()
		{
			Xml = null;
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
					string warning = ExceptionMessage.GetWarning(exception);
					Logs.Entry(warning);
					Report.Progress(progress, Report.Message(warning, DisplayIcon.Error));
					return false;
				}
				return PostRead(progress);
			}
			else
			{
				string warning = "The file at " + FilePath + " does not exist.";
				Logs.Entry(warning);
				Report.Progress(progress, Report.Message(warning, DisplayIcon.Warning));
				return false;
			}
		}

		private bool PostRead(IProgress<ProgressEventArgs> progress = null)
		{
			if (HasXml)
			{
				string msg = "The modification " + Xml.Name + " has been read from the file " + FilePath;
				Logs.Entry(msg);
				Report.Progress(progress, Report.Message(msg));
				return true;
			}
			else
			{
				string msg = "Could not read the file at " + FilePath;
				Logs.Entry(msg);
				Report.Progress(progress, Report.Message(msg, DisplayIcon.Warning));
				return false;
			}
		}


		public override bool Write(IProgress<ProgressEventArgs> progress = null)
		{
			throw new NotImplementedException();
		}

		#endregion


		public string GetResolvedPath(Repository.File file)
		{
			return Path.Combine(Location, file.Path);
		}


		protected override bool EvaluateFormat(string filepath)
		{
			bool hasFormat = base.EvaluateFormat(filepath);
			bool matches = String.Equals("index.xml", Path.GetFileName(filepath), StringComparison.OrdinalIgnoreCase);
			return hasFormat && matches;
		}


		public string GetName()
		{
			if (HasXml)
				if (!String.IsNullOrWhiteSpace(Xml.Name))
					return Xml.Name;
			if (!String.IsNullOrWhiteSpace(Key))
				return Key;
			return "null";
		}



		public override string ToString()
		{
			return GetName();
		}


	}
}
