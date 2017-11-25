﻿namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class StepGuiElement : object, System.ComponentModel.INotifyPropertyChanged
	{

		private ObjectiveSetGuiElement[] objectiveSetField;

		private string nameField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ObjectiveSet", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ObjectiveSetGuiElement[] ObjectiveSet
		{
			get
			{
				return this.objectiveSetField;
			}
			set
			{
				this.objectiveSetField = value;
				this.RaisePropertyChanged("ObjectiveSet");
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
