namespace Sharp.Applications.Storage.Special
{
	public class DllAsset : FileAsset
	{
		protected override string DefaultExtension { get { return ext; } }
		const string ext = ".dll";


		public DllAsset() : base()
		{
			// contructor
		}

		public DllAsset(string filepath) : base(filepath)
		{
			// contructor
		}

	}
}
