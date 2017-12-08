using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace ES2.Editor
{
	[Obsolete]
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class Index
	{
		public string Name { get; set; }
		public bool Standalone { get; set; }
		public DLC RequestedDLCName { get; set; }

		public enum DLC
		{
			Vanilla,
			Disharmony
		}


		[XmlArray("Database")]
		[XmlArrayItem("Repository", typeof(Repository))]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public BindingList<Repository> Repositories { get; set; }


		public Index()
		{
			Repositories = new BindingList<Repository>();

		}

	}


	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class Repository
	{
		[XmlAttribute("Target")]
		public string Target { get; set; }


		[XmlElement(ElementName = "File", Type = typeof(File))]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public BindingList<File> Files { get; set; }


		public Repository()
		{
			Target = null;
			Files = new BindingList<File>();
		}

		[TypeConverter(typeof(ExpandableObjectConverter))]
		public class File
		{
			[XmlText]
			public string Path { get; set; }

			[XmlAttribute("Hash")]
			public string Hash { get; set; }

			[XmlIgnore]
			public bool IsModFile { get; set; }


			public File()
			{
				Path = String.Empty;
				Hash = null;
				IsModFile = false;
			}


			public override string ToString()
			{
				return Path;
			}
		}


		public override string ToString()
		{
			return Target;
		}


	}
}
