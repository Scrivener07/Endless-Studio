using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Amplitude.ES2.Unity.GUI
{
	[XmlInclude(typeof(DownloadableContentGuiElement))]
	[XmlInclude(typeof(AllianceGuiElement))]
	[XmlInclude(typeof(ScanViewCaptionGroupGuiElement))]
	[XmlInclude(typeof(ScanViewWindowGuiElement))]
	[XmlInclude(typeof(PlanetScanViewWindowGuiElement))]
	[XmlInclude(typeof(StarSystemOverviewScanViewGuiElement))]
	[XmlInclude(typeof(RecipeSlotGuiElement))]
	[XmlInclude(typeof(GovernmentGuiElement))]
	[XmlInclude(typeof(ObjectiveSetGuiElement))]
	[XmlInclude(typeof(QuestGuiElement))]
	[XmlInclude(typeof(TutorialGuiElement))]
	[XmlInclude(typeof(LawGuiElement))]
	[XmlInclude(typeof(TechnologyGuiElement2))]
	[XmlInclude(typeof(ControlBannerGuiElement))]
	[XmlInclude(typeof(HeroGuiElement))]
	[XmlInclude(typeof(TableGuiElement))]
	[XmlInclude(typeof(ExtendedGuiElement))]
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
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlRoot(Namespace = "", IsNullable = true)]
	public partial class GuiElement : INotifyPropertyChanged
	{

		private string titleField;

		private string descriptionField;

		private GuiElementIconCollection iconsField;

		private string nameField;


		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public string Title
		{
			get
			{
				return this.titleField;
			}
			set
			{
				this.titleField = value;
				this.RaisePropertyChanged("Title");
			}
		}


		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				this.RaisePropertyChanged("Description");
			}
		}


		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public GuiElementIconCollection Icons
		{
			get
			{
				return this.iconsField;
			}
			set
			{
				this.iconsField = value;
				this.RaisePropertyChanged("Icons");
			}
		}


		[XmlAttribute]
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
