namespace ES2.Editor.Assets
{
	public class ModificationFile : TableFile
	{
		public ModificationFile(DataStore datastore, string filepath) : base(datastore, filepath) { }

		public override string ToString()
		{
			return "Unknown Modification";
		}

	}
}
