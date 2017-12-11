using Sharp.Reporting;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Sharp.Storage.Special
{
	[DebuggerStepThrough]
	public abstract class XmlAsset<T> : FileAsset where T : class
	{
		public virtual T Xml { get; set; }
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


		public abstract bool Read(IProgress<ProgressEventArgs> progress = null);
		public virtual async Task<bool> ReadAsync(IProgress<ProgressEventArgs> progress = null)
		{
			return await Task.Run(() => Read(progress));
		}


		public abstract bool Write(IProgress<ProgressEventArgs> progress = null);
		public virtual async Task<bool> WriteAsync(IProgress<ProgressEventArgs> progress = null)
		{
			return await Task.Run(() => Write(progress));
		}


	}
}
