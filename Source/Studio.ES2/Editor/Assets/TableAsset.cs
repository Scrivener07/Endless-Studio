using ES2.Editor.Model;
using Sharp.Applications;
using Sharp.Applications.Messages;
using Sharp.Applications.Storage.Special;
using System;
using System.Xml;
using System.Xml.Serialization;

namespace ES2.Editor.Assets
{
	public class TableAsset : XmlAsset<Datatable>
	{
		public override Datatable Xml { get; set; }

		public bool HasXmlElements { get { return Xml.Count > 0; } }




		public TableAsset() : base()
		{
			Xml = null;
		}

		public TableAsset(string filepath) : base(filepath)
		{
			Xml = new Datatable();
		}


		#region Xml Overrides

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
					var message = ExceptionMessage.GetWarning(exception);
					Logs.Entry(message);
					Report.Progress(progress, Report.Message("Message: '" + Logs.Message + "' Exception: '" + message + "'", DisplayIcon.Error));
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
					var message = ExceptionMessage.GetWarning(exception);
					Logs.Entry(message);
					Report.Progress(progress, Report.Message("Message: '" + Logs.Message + "' Exception: '" + message + "'", DisplayIcon.Error));
				}

				return PostRead(progress);
			}
			else
			{
				var msg = "Aborting deserialization. The file '" + FilePath + "' cannot be found";
				Logs.Entry(msg);
				Report.Progress(progress, Report.Message(msg, DisplayIcon.Error));
				return false;
			}
		}

		#endregion


		private bool PostRead(IProgress<ProgressEventArgs> progress = null)
		{
			if (HasXmlData)
			{
				var msg = "The file '" + FilePath + "' contains '" + Xml.Count + "' elements.";
				Logs.Entry(msg);

				if (Xml.Count <= 0)
				{
					Report.Progress(progress, Report.Message(msg, DisplayIcon.Warning));
					return true;
				}

				Report.Progress(progress, Report.Message(msg, DisplayIcon.Complete));
				return true;
			}
			else
			{
				var msg = "The file '" + FilePath + "' could not be deserialized.";
				Logs.Entry(msg);
				Report.Progress(progress, Report.Message(msg, DisplayIcon.Error));
				return false;
			}
		}


	}
}
