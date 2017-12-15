using ES2.Editor.Model;
using Sharp.Reporting;
using Sharp.Storage.Special;
using System;
using System.Xml;
using System.Xml.Serialization;

namespace ES2.Editor.Assets
{
	public class TableAsset : XmlAsset<Datatable>
	{
		private readonly DataStore Data;
		public override Datatable Xml { get; protected set; }


		public TableAsset(DataStore datastore, string filepath) : base(filepath)
		{
			Data = datastore;
		}


		#region Xml Asset

		public override bool Write(IProgress<ProgressEventArgs> progress = null)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(Datatable));
			XmlWriterSettings settings = new XmlWriterSettings
			{
				Indent = true
			};

			using (var writer = XmlWriter.Create(FilePath, settings))
			{
				try
				{
					serializer.Serialize(writer, Xml);
					return true;
				}
				catch (Exception exception)
				{
					var message = MessageFormat.GetWarning(exception);
					Logs.Entry(message);
					Report.Progress(progress, Report.Message("Message: '" + Logs.Message + "' Exception: '" + message + "'", MessageIcon.Error));
					return false;
				}
			}
		}


		public override bool Read(IProgress<ProgressEventArgs> progress = null)
		{
			if (Exists)
			{
				try
				{
					XmlReaderSettings settings = new XmlReaderSettings
					{
						IgnoreComments = false,
						IgnoreWhitespace = true,
						CloseInput = true
					};
					using (XmlReader reader = XmlReader.Create(FilePath))
					{
						XmlSerializer serializer = new XmlSerializer(typeof(Datatable));
						Xml = (Datatable)serializer.Deserialize(reader);
					}
				}
				catch (Exception exception)
				{
					var message = MessageFormat.GetWarning(exception);
					Logs.Entry(message);
					Report.Progress(progress, Report.Message("Message: '" + Logs.Message + "' Exception: '" + message + "'", MessageIcon.Error));
				}
				return PostRead(progress);
			}
			else
			{
				var message = "Aborting deserialization. The file '" + FilePath + "' cannot be found";
				Logs.Entry(message);
				Report.Progress(progress, Report.Message(message, MessageIcon.Error));
				return false;
			}
		}

		#endregion


		private bool PostRead(IProgress<ProgressEventArgs> progress = null)
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


		public bool HasElements
		{
			get
			{
				if (Xml != null) return Xml.Count > 0;
				else return false;
			}
		}


	}
}
