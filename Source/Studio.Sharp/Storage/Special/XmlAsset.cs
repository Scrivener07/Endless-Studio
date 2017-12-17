using Sharp.Reporting;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Sharp.Storage.Special
{
	[DebuggerStepThrough]
	public abstract class XmlAsset<T> : FileAsset where T : class
	{
		public virtual T Xml { get; protected set; }
		public bool IsNull { get { return Xml == null; } }

		protected override string DefaultExtension { get { return ".xml"; } }


		public XmlAsset(string filepath) : base(filepath)
		{
			if (!String.Equals(DefaultExtension, Extension, StringComparison.OrdinalIgnoreCase))
			{
				throw new ArgumentException("The asset has an incorrect URI format.");
			}
			Xml = null;
		}


		public virtual bool Read(IProgress<ProgressEventArgs> progress = null)
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
						XmlSerializer serializer = new XmlSerializer(typeof(T));
						Xml = (T)serializer.Deserialize(reader);
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
				var message = "Aborting deserialization. The file '" + FilePath + "' does not exist.";
				Logs.Entry(message);
				Report.Progress(progress, Report.Message(message, MessageIcon.Error));
				return false;
			}
		}

		public virtual async Task<bool> ReadAsync(IProgress<ProgressEventArgs> progress = null)
		{
			return await Task.Run(() => Read(progress));
		}


		protected virtual bool PostRead(IProgress<ProgressEventArgs> progress = null)
		{
			if (!IsNull)
			{
				var message = "The file '" + FilePath + "' has been deserialized.";
				Logs.Entry(message);
				Report.Progress(progress, Report.Message(message, MessageIcon.Complete));
				return true;
			}
			else
			{
				var message = "The file '" + FilePath + "' could not be deserialized.";
				Logs.Entry(message);
				Report.Progress(progress, Report.Message(message, MessageIcon.Error));
				return false;
			}
		}



		public virtual bool Write(IProgress<ProgressEventArgs> progress = null)
		{
			bool success = false;
			try
			{
				XmlSerializer serializer = new XmlSerializer(typeof(T));
				XmlWriterSettings settings = new XmlWriterSettings
				{
					Indent = true
				};

				using (var writer = XmlWriter.Create(FilePath, settings))
				{
					serializer.Serialize(writer, Xml);
					success = true;
				}
			}
			catch (Exception exception)
			{
				var message = MessageFormat.GetWarning(exception);
				Logs.Entry(message);
				Report.Progress(progress, Report.Message("Message: '" + Logs.Message + "' Exception: '" + message + "'", MessageIcon.Error));
				success = false;
			}
			PostWrite();
			return success;
		}

		public virtual async Task<bool> WriteAsync(IProgress<ProgressEventArgs> progress = null)
		{
			return await Task.Run(() => Write(progress));
		}


		protected virtual void PostWrite(IProgress<ProgressEventArgs> progress = null)
		{
			Report.Progress(progress, Report.Message("Done serializing xml to " + FilePath, MessageIcon.InformationB));
		}


	}
}
