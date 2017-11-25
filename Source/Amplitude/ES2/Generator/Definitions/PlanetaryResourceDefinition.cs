﻿namespace Amplitude.ES2.Generator.Definitions
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class PlanetaryResourceDefinition : object, System.ComponentModel.INotifyPropertyChanged
	{

		private string categoryField;

		private string tierField;

		private string tagField;

		private bool maybeVisibleField;

		private string tagWhenVisibleField;

		private string[] planetFilterMustField;

		private string[] planetFilterAnyField;

		private string[] planetFilterNotField;

		private string nameField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string Category
		{
			get
			{
				return this.categoryField;
			}
			set
			{
				this.categoryField = value;
				this.RaisePropertyChanged("Category");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string Tier
		{
			get
			{
				return this.tierField;
			}
			set
			{
				this.tierField = value;
				this.RaisePropertyChanged("Tier");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string Tag
		{
			get
			{
				return this.tagField;
			}
			set
			{
				this.tagField = value;
				this.RaisePropertyChanged("Tag");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public bool MaybeVisible
		{
			get
			{
				return this.maybeVisibleField;
			}
			set
			{
				this.maybeVisibleField = value;
				this.RaisePropertyChanged("MaybeVisible");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string TagWhenVisible
		{
			get
			{
				return this.tagWhenVisibleField;
			}
			set
			{
				this.tagWhenVisibleField = value;
				this.RaisePropertyChanged("TagWhenVisible");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("PlanetFilterMust", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string[] PlanetFilterMust
		{
			get
			{
				return this.planetFilterMustField;
			}
			set
			{
				this.planetFilterMustField = value;
				this.RaisePropertyChanged("PlanetFilterMust");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("PlanetFilterAny", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string[] PlanetFilterAny
		{
			get
			{
				return this.planetFilterAnyField;
			}
			set
			{
				this.planetFilterAnyField = value;
				this.RaisePropertyChanged("PlanetFilterAny");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("PlanetFilterNot", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string[] PlanetFilterNot
		{
			get
			{
				return this.planetFilterNotField;
			}
			set
			{
				this.planetFilterNotField = value;
				this.RaisePropertyChanged("PlanetFilterNot");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				this.RaisePropertyChanged("Name");
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if ((propertyChanged != null))
			{
				propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
