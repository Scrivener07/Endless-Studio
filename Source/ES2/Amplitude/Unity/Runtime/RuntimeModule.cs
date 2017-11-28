﻿
using ES2.Amplitude.Unity.Runtime.Plugins;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ES2.Amplitude.Unity.Runtime
{
	/// <remarks/>
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlRoot(Namespace = "", IsNullable = true)]
	public class RuntimeModule : INotifyPropertyChanged
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


		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public string Title
		{
			get { return this.titleField; }
			set
			{
				this.titleField = value;
				this.RaisePropertyChanged("Title");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public string Description
		{
			get { return this.descriptionField; }
			set
			{
				this.descriptionField = value;
				this.RaisePropertyChanged("Description");
			}
		}

		/// <remarks/>
		[XmlElement("Author", Form = XmlSchemaForm.Unqualified)]
		public string[] Author
		{
			get { return this.authorField; }
			set
			{
				this.authorField = value;
				this.RaisePropertyChanged("Author");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public string Homepage
		{
			get { return this.homepageField; }
			set
			{
				this.homepageField = value;
				this.RaisePropertyChanged("Homepage");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public string PreviewImageFile
		{
			get { return this.previewImageFileField; }
			set
			{
				this.previewImageFileField = value;
				this.RaisePropertyChanged("PreviewImageFile");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public string ReleaseNotes
		{
			get { return this.releaseNotesField; }
			set
			{
				this.releaseNotesField = value;
				this.RaisePropertyChanged("ReleaseNotes");
			}
		}

		/// <remarks/>
		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public Tags Tags
		{
			get { return this.tagsField; }
			set
			{
				this.tagsField = value;
				this.RaisePropertyChanged("Tags");
			}
		}

		/// <remarks/>
		[XmlElement("Thumbnail", Form = XmlSchemaForm.Unqualified)]
		public string[] Thumbnail
		{
			get { return this.thumbnailField; }
			set
			{
				this.thumbnailField = value;
				this.RaisePropertyChanged("Thumbnail");
			}
		}

		/// <remarks/>
		[XmlArray(Form = XmlSchemaForm.Unqualified)]
		[XmlArrayItem(typeof(AIPlugin), Form = XmlSchemaForm.Unqualified, IsNullable = false)]
		[XmlArrayItem(typeof(DatabasePlugin), Form = XmlSchemaForm.Unqualified, IsNullable = false)]
		[XmlArrayItem(typeof(LocalizationPlugin), Form = XmlSchemaForm.Unqualified, IsNullable = false)]
		[XmlArrayItem(typeof(RegistryPlugin), Form = XmlSchemaForm.Unqualified, IsNullable = false)]
		public RuntimePlugin[] Plugins
		{
			get { return this.pluginsField; }
			set
			{
				this.pluginsField = value;
				this.RaisePropertyChanged("Plugins");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		public RuntimeModuleType Type
		{
			get { return this.typeField; }
			set
			{
				this.typeField = value;
				this.RaisePropertyChanged("Type");
			}
		}

		/// <remarks/>
		[XmlAttribute]
		[DefaultValue("1.0")]
		public string Version
		{
			get { return this.versionField; }
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("Version");
			}
		}

		/// <remarks/>
		[XmlAttribute]
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