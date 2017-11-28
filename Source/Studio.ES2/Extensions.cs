using ES2.Amplitude.Unity.Runtime;
using System.IO;
using System.Xml.Serialization;

namespace Studio
{
	public static class Extensions
	{
		public static void Serialize(this RuntimeModule runtimeModule, string path)
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
