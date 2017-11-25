using System.Xml.Serialization;

namespace Amplitude.ES2.Unity.GUI
{
	[XmlInclude(typeof(ContextualDiplomaticTermGuiElement))]
	[XmlInclude(typeof(PlayDeckGuiElement))]
	[XmlInclude(typeof(VictoryConditionGuiElement))]
	[XmlInclude(typeof(DamageDataGuiElement))]
	[XmlInclude(typeof(TradableSectionGuiElement))]
	[XmlInclude(typeof(StarSystemResourceImprovementGuiElement))]
	[XmlInclude(typeof(CuriosityTypeGuiElement))]
	[XmlInclude(typeof(DiplomaticTermGuiElement))]
	[XmlInclude(typeof(ScanViewCaptionItemGuiElement))]
	[XmlInclude(typeof(EntityActionGuiElement))]
	[XmlInclude(typeof(EmpireActionGuiElement))]
	[XmlInclude(typeof(EmpireDiplomaticActionGuiElement))]
	[XmlInclude(typeof(TechnologyQuadrantGuiElement))]
	[XmlInclude(typeof(WindowGuiElement))]
	[XmlInclude(typeof(VictoryScreenGuiElement))]
	[XmlInclude(typeof(MinorFactionDiplomacyModalWindowGuiElement))]
	[XmlInclude(typeof(FidsiParametersGuiElement))]
	[XmlInclude(typeof(FleetsScreenGuiElement))]
	[XmlInclude(typeof(EconomyScreenGuiElement))]
	[XmlInclude(typeof(TechnologyScreenGuiElement))]
	[XmlInclude(typeof(NewGameScreenGuiElement))]
	[XmlInclude(typeof(MainMenuScreenGuiElement))]
	[XmlInclude(typeof(LoadingWindowGuiElement))]
	[XmlInclude(typeof(PoliticsGuiElement))]
	[XmlInclude(typeof(HeroClassGuiElement))]
	[XmlInclude(typeof(ResourceGuiElement))]
	[XmlInclude(typeof(AffinityGuiElement))]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[XmlRootAttribute(Namespace = "", IsNullable = true)]
	public partial class ExtendedGuiElement : GuiElement
	{
		private string symbolStringField;
		private SoundDefinition[] soundsField;
		private GuiTooltipElement tooltipElementField;
		private XmlColor colorField;
		private string altTitleField;
		private MovieDefinition[] moviesField;


		/// <remarks/>
		[XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string SymbolString
		{
			get
			{
				return this.symbolStringField;
			}
			set
			{
				this.symbolStringField = value;
				this.RaisePropertyChanged("SymbolString");
			}
		}

		/// <remarks/>
		[XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[XmlArrayItemAttribute("Sound", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
		public SoundDefinition[] Sounds
		{
			get
			{
				return this.soundsField;
			}
			set
			{
				this.soundsField = value;
				this.RaisePropertyChanged("Sounds");
			}
		}

		/// <remarks/>
		[XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public GuiTooltipElement TooltipElement
		{
			get
			{
				return this.tooltipElementField;
			}
			set
			{
				this.tooltipElementField = value;
				this.RaisePropertyChanged("TooltipElement");
			}
		}

		/// <remarks/>
		[XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public XmlColor Color
		{
			get
			{
				return this.colorField;
			}
			set
			{
				this.colorField = value;
				this.RaisePropertyChanged("Color");
			}
		}

		/// <remarks/>
		[XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string AltTitle
		{
			get
			{
				return this.altTitleField;
			}
			set
			{
				this.altTitleField = value;
				this.RaisePropertyChanged("AltTitle");
			}
		}

		/// <remarks/>
		[XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[XmlArrayItemAttribute("Movie", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
		public MovieDefinition[] Movies
		{
			get
			{
				return this.moviesField;
			}
			set
			{
				this.moviesField = value;
				this.RaisePropertyChanged("Movies");
			}
		}
	}
}
