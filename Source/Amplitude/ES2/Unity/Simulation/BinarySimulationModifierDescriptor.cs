namespace Amplitude.ES2.Unity.Simulation
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class BinarySimulationModifierDescriptor : SimulationModifierDescriptor
	{

		private ModifierOperation binaryOperationField;

		private string leftField;

		private string rightField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public ModifierOperation BinaryOperation
		{
			get
			{
				return this.binaryOperationField;
			}
			set
			{
				this.binaryOperationField = value;
				this.RaisePropertyChanged("BinaryOperation");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Left
		{
			get
			{
				return this.leftField;
			}
			set
			{
				this.leftField = value;
				this.RaisePropertyChanged("Left");
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Right
		{
			get
			{
				return this.rightField;
			}
			set
			{
				this.rightField = value;
				this.RaisePropertyChanged("Right");
			}
		}
	}
}
