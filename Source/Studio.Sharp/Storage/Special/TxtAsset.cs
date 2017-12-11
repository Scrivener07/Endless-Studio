namespace Sharp.Storage.Special
{
	public class TxtAsset : FileAsset
	{
		protected override string DefaultExtension { get { return ".txt"; } }
		public TxtAsset(string filepath) : base(filepath) { }
	}
}
