namespace Amplitude.ES2.Unity.GUI
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class FleetsScreenGuiElement : WindowGuiElement
	{

		private FleetActionButtonItem[] fleetActionButtonField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("FleetActionButton", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public FleetActionButtonItem[] FleetActionButton
		{
			get
			{
				return this.fleetActionButtonField;
			}
			set
			{
				this.fleetActionButtonField = value;
				this.RaisePropertyChanged("FleetActionButton");
			}
		}
	}
}
