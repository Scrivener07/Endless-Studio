namespace ES2.Editor.Assets
{
	public class ModificationAsset : TableAsset
	{
		public ModificationAsset(DataStore datastore, string filepath) : base(datastore, filepath) { }

		public override string ToString()
		{
			return "Unknown Modification";
		}

	}
}
