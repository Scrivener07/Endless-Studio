using ES2.XSD.Amplitude.Unity.Runtime.RuntimeModule_SCHEMA;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Amplitude.Studio
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Test();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}


		private static void Test()
		{
			RuntimeModule runtimeModule = new RuntimeModule();
			runtimeModule.Name = "Scrivener07_HelloWorld";
			runtimeModule.Type = RuntimeModuleType.Extension;
			runtimeModule.Version = new Version(1, 0, 0, 0).ToString();
			runtimeModule.Title = "Hello World";
			runtimeModule.Description = "This modification was created programmatically.";
			runtimeModule.Author = new string[1] { "Scrivener07" };
			runtimeModule.Homepage = "https://github.com/Scrivener07/Endless-Studio";
			runtimeModule.PreviewImageFile = "PreviewImageFile.png";
			runtimeModule.Thumbnail = new string[3] { "Thumb1.png", "Thumb2.png", "Thumb3.png" };
			runtimeModule.ReleaseNotes = "Lets serialize to XML first, then we can talk about releases.";
			runtimeModule.Tags = new Tags();
			runtimeModule.Tags.Value = "dsaDsadsa";
			runtimeModule.Plugins = new RuntimePlugin[2];

			DatabasePlugin database1 = new DatabasePlugin();
			database1.DataType = "RemappingDefinition, Assembly-CSharp";
			database1.FilePath = new string[1] { "Mapping/Remapping.xml" };
			runtimeModule.Plugins[0] = database1;

			DatabasePlugin database2 = new DatabasePlugin();
			database2.DataType = "PlanetRemappingDefinition, Assembly-CSharp";
			database2.FilePath = new string[1] { "Mapping/PlanetRemapping.xml" };
			runtimeModule.Plugins[1] = database2;

			Serialize(runtimeModule, Environment.CurrentDirectory);
		}


		private static void Serialize(this RuntimeModule runtimeModule, string path)
		{
			XmlSerializerNamespaces EmptyNameSpace = new XmlSerializerNamespaces();
			EmptyNameSpace.Add("", "");
			string file = Path.Combine(path, runtimeModule.Name + ".xml");
			StreamWriter stream = new StreamWriter(file);
			XmlSerializer serializer = new XmlSerializer(typeof(RuntimeModule));
			serializer.Serialize(stream, runtimeModule, EmptyNameSpace);
			stream.Close();
		}


	}
}
