using Sharp.Applications;
using System;
using System.Threading.Tasks;

namespace Sharp.Applications.Storage.Special
{
	public abstract class XmlAsset<T> : FileAsset where T : class
	{
		public virtual T Xml { get; set; }
		public bool HasXml { get { return Xml != null; } }

		protected override string DefaultExtension { get { return ext; } }
		const string ext = ".xml";


		public XmlAsset() : base()
		{
			Xml = null;
		}

		public XmlAsset(string filepath) : base(filepath)
		{
			Xml = null;
		}


		public virtual async Task<bool> ReadAsync(IProgress<ProgressEventArgs> progress = null)
		{
			return await Task.Run(() => Read(progress));
		}

		public abstract bool Read(IProgress<ProgressEventArgs> progress = null);



		public virtual async Task<bool> WriteAsync(IProgress<ProgressEventArgs> progress = null)
		{
			return await Task.Run(() => Write(progress));
		}

		public abstract bool Write(IProgress<ProgressEventArgs> progress = null);

	}
}
