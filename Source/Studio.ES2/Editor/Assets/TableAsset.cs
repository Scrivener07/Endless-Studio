using ES2.Editor.Model;
using Sharp.Reporting;
using Sharp.Storage.Special;
using System;

namespace ES2.Editor.Assets
{
	public class TableAsset : XmlAsset<Datatable>
	{
		private readonly DataStore Data;
		public override Datatable Xml { get; protected set; }


		public TableAsset(DataStore datastore, string filepath) : base(filepath)
		{
			Data = datastore ?? throw new ArgumentNullException("datastore", "The data store cannot be null.");
		}


		protected override bool PostRead(IProgress<ProgressEventArgs> progress = null)
		{
			if (!IsNull)
			{
				var message = "The file '" + FilePath + "' contains '" + Xml.Count + "' elements.";
				Logs.Entry(message);

				if (Xml.Count <= 0)
				{
					Report.Progress(progress, Report.Message(message, MessageIcon.Warning));
					return true;
				}
				else
				{
					Report.Progress(progress, Report.Message(message, MessageIcon.Complete));
					return true;
				}
			}
			else
			{
				var message = "The file '" + FilePath + "' could not be deserialized.";
				Logs.Entry(message);
				Report.Progress(progress, Report.Message(message, MessageIcon.Error));
				return false;
			}
		}


	}
}
