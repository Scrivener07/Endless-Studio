namespace Sharp.Applications.Storage.Special
{
	public class TxtAsset : FileAsset
	{
		protected override string DefaultExtension { get { return ext; } }
		const string ext = ".txt";


		public TxtAsset() : base()
		{
			// contructor
		}


		public TxtAsset(string filepath) : base(filepath)
		{
			// contructor
		}

	}
}
