﻿namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class MainMenuScreenGuiElement : WindowGuiElement
	{

		private MainMenuEntry[] entryField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Entry", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public MainMenuEntry[] Entry
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
	}
}
