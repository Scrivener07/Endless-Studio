namespace Sharp.Storage.Special
{
	public class DllAsset : FileAsset
	{
		protected override string DefaultExtension { get { return ".dll"; } }
		public DllAsset(string filepath) : base(filepath) { }
	}
}
