using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class NewGameEntry : object, System.ComponentModel.INotifyPropertyChanged
	{

		private ExtraValue[] extraValueField;

		private string nameField;

		private ControlType typeField;

		private InGameVisibility visibleInGameField;

		private string prefabField;

		public NewGameEntry()
		{
			this.visibleInGameField = InGameVisibility.Invisible;
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ExtraValue", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ExtraValue[] ExtraValue
		{
			get
			{
				return this.extraValueField;
			}
			set
			{
				this.extraValueField = value;
				this.RaisePropertyChanged("ExtraValue");
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

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public ControlType Type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
				this.RaisePropertyChanged("Type");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(InGameVisibility.Invisible)]
		public InGameVisibility VisibleInGame
		{
			get
			{
				return this.visibleInGameField;
			}
			set
			{
				this.visibleInGameField = value;
				this.RaisePropertyChanged("VisibleInGame");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Prefab
		{
			get
			{
				return this.prefabField;
			}
			set
			{
				this.prefabField = value;
				this.RaisePropertyChanged("Prefab");
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
