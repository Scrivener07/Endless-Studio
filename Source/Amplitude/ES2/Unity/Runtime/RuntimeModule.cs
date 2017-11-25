using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Amplitude.ES2.Unity.Runtime
{
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlRoot(Namespace = "", IsNullable = true)]
	public partial class RuntimeModule : object, INotifyPropertyChanged
	{
		private string titleField;
		private string descriptionField;
		private string[] authorField;
		private string homepageField;
		private string previewImageFileField;
		private string releaseNotesField;
		private Tags tagsField;
		private string[] thumbnailField;
		private RuntimePlugin[] pluginsField;
		private RuntimeModuleType typeField;
		private string versionField;
		private string nameField;


		public RuntimeModule()
		{
			this.versionField = "1.0";
		}


		[XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
		public string Title
		{
			get { return this.titleField; }
			set
			{
				this.titleField = value;
				this.RaisePropertyChanged("Title");
			}
		}


		[XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
		public string Description
		{
			get { return this.descriptionField; }
			set
			{
				this.descriptionField = value;
				this.RaisePropertyChanged("Description");
			}
		}


		[XmlElementAttribute("Author", Form = XmlSchemaForm.Unqualified)]
		public string[] Author
		{
			get { return this.authorField; }
			set
			{
				this.authorField = value;
				this.RaisePropertyChanged("Author");
			}
		}


		[XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
		public string Homepage
		{
			get { return this.homepageField; }
			set
			{
				this.homepageField = value;
				this.RaisePropertyChanged("Homepage");
			}
		}


		[XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
		public string PreviewImageFile
		{
			get { return this.previewImageFileField; }
			set
			{
				this.previewImageFileField = value;
				this.RaisePropertyChanged("PreviewImageFile");
			}
		}


		[XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
		public string ReleaseNotes
		{
			get { return this.releaseNotesField; }
			set
			{
				this.releaseNotesField = value;
				this.RaisePropertyChanged("ReleaseNotes");
			}
		}


		[XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
		public Tags Tags
		{
			get { return this.tagsField; }
			set
			{
				this.tagsField = value;
				this.RaisePropertyChanged("Tags");
			}
		}


		[XmlElementAttribute("Thumbnail", Form = XmlSchemaForm.Unqualified)]
		public string[] Thumbnail
		{
			get { return this.thumbnailField; }
			set
			{
				this.thumbnailField = value;
				this.RaisePropertyChanged("Thumbnail");
			}
		}


		[XmlArrayAttribute(Form = XmlSchemaForm.Unqualified)]
		[XmlArrayItemAttribute(typeof(AIPlugin), Form = XmlSchemaForm.Unqualified, IsNullable = false)]
		[XmlArrayItemAttribute(typeof(DatabasePlugin), Form = XmlSchemaForm.Unqualified, IsNullable = false)]
		[XmlArrayItemAttribute(typeof(LocalizationPlugin), Form = XmlSchemaForm.Unqualified, IsNullable = false)]
		[XmlArrayItemAttribute(typeof(RegistryPlugin), Form = XmlSchemaForm.Unqualified, IsNullable = false)]
		public RuntimePlugin[] Plugins
		{
			get { return this.pluginsField; }
			set
			{
				this.pluginsField = value;
				this.RaisePropertyChanged("Plugins");
			}
		}


		[XmlAttributeAttribute()]
		public RuntimeModuleType Type
		{
			get { return this.typeField; }
			set
			{
				this.typeField = value;
				this.RaisePropertyChanged("Type");
			}
		}


		[XmlAttributeAttribute()]
		[DefaultValueAttribute("1.0")]
		public string Version
		{
			get { return this.versionField; }
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("Version");
			}
		}


		[XmlAttributeAttribute()]
		public string Name
		{
			get { return this.nameField; }
			set
			{
				this.nameField = value;
				this.RaisePropertyChanged("Name");
			}
		}


		public event PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if ((propertyChanged != null))
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}


	}
}
