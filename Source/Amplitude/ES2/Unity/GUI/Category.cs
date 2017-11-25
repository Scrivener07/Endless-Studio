namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class Category : object, System.ComponentModel.INotifyPropertyChanged
	{

		private NewGameEntry[] entryField;

		private AdvancedSettingsGroup[] advancedSettingsGroupField;

		private string nameField;

		private int widthField;

		private int heightField;

		private SettingPrefabStyle settingStyleField;

		private bool withBannerField;

		public Category()
		{
			this.widthField = 40;
			this.heightField = 40;
			this.settingStyleField = SettingPrefabStyle.Standard;
			this.withBannerField = false;
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Entry", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public NewGameEntry[] Entry
		{
			get
			{
				return this.entryField;
			}
			set
			{
				this.entryField = value;
				this.RaisePropertyChanged("Entry");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("AdvancedSettingsGroup", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public AdvancedSettingsGroup[] AdvancedSettingsGroup
		{
			get
			{
				return this.advancedSettingsGroupField;
			}
			set
			{
				this.advancedSettingsGroupField = value;
				this.RaisePropertyChanged("AdvancedSettingsGroup");
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
		[System.ComponentModel.DefaultValueAttribute(40)]
		public int Width
		{
			get
			{
				return this.widthField;
			}
			set
			{
				this.widthField = value;
				this.RaisePropertyChanged("Width");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(40)]
		public int Height
		{
			get
			{
				return this.heightField;
			}
			set
			{
				this.heightField = value;
				this.RaisePropertyChanged("Height");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(SettingPrefabStyle.Standard)]
		public SettingPrefabStyle SettingStyle
		{
			get
			{
				return this.settingStyleField;
			}
			set
			{
				this.settingStyleField = value;
				this.RaisePropertyChanged("SettingStyle");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		[System.ComponentModel.DefaultValueAttribute(false)]
		public bool WithBanner
		{
			get
			{
				return this.withBannerField;
			}
			set
			{
				this.withBannerField = value;
				this.RaisePropertyChanged("WithBanner");
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
