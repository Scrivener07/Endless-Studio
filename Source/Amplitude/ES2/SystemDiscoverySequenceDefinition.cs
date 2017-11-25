using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Amplitude.ES2
{
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlRoot(Namespace = "", IsNullable = true)]
	public class SystemDiscoverySequenceDefinition : DatatableElement
	{

		private PlanetTransformation[] planetTransformationField;
		private PlanetTransformation[] galaxyPlanetTransformationField;
		private ShipTransformation[] shipTransformationField;
		private Shot[] shotField;
		private StarSystemTransformation starSystemTransformField;
		private SerializableVector3 galaxyCameraPositionField;
		private SerializableVector3 galaxyCameraEulerAnglesField;
		private PlanetoidRadiusFromPlanetSize[] planetoidRadiusFromPlanetSizeField;
		private string categoryField;


		[XmlElement("PlanetTransformation", Form = XmlSchemaForm.Unqualified)]
		public PlanetTransformation[] PlanetTransformation
		{
			get { return this.planetTransformationField; }
			set
			{
				this.planetTransformationField = value;
				this.RaisePropertyChanged("PlanetTransformation");
			}
		}


		[XmlElement("GalaxyPlanetTransformation", Form = XmlSchemaForm.Unqualified)]
		public PlanetTransformation[] GalaxyPlanetTransformation
		{
			get { return this.galaxyPlanetTransformationField; }
			set
			{
				this.galaxyPlanetTransformationField = value;
				this.RaisePropertyChanged("GalaxyPlanetTransformation");
			}
		}


		[XmlElement("ShipTransformation", Form = XmlSchemaForm.Unqualified)]
		public ShipTransformation[] ShipTransformation
		{
			get { return this.shipTransformationField; }
			set
			{
				this.shipTransformationField = value;
				this.RaisePropertyChanged("ShipTransformation");
			}
		}


		[XmlElement("Shot", Form = XmlSchemaForm.Unqualified)]
		public Shot[] Shot
		{
			get { return this.shotField; }
			set
			{
				this.shotField = value;
				this.RaisePropertyChanged("Shot");
			}
		}


		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public StarSystemTransformation StarSystemTransform
		{
			get { return this.starSystemTransformField; }
			set
			{
				this.starSystemTransformField = value;
				this.RaisePropertyChanged("StarSystemTransform");
			}
		}


		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public SerializableVector3 GalaxyCameraPosition
		{
			get { return this.galaxyCameraPositionField; }
			set
			{
				this.galaxyCameraPositionField = value;
				this.RaisePropertyChanged("GalaxyCameraPosition");
			}
		}


		[XmlElement(Form = XmlSchemaForm.Unqualified)]
		public SerializableVector3 GalaxyCameraEulerAngles
		{
			get { return this.galaxyCameraEulerAnglesField; }
			set
			{
				this.galaxyCameraEulerAnglesField = value;
				this.RaisePropertyChanged("GalaxyCameraEulerAngles");
			}
		}


		[XmlElement("PlanetoidRadiusFromPlanetSize", Form = XmlSchemaForm.Unqualified)]
		public PlanetoidRadiusFromPlanetSize[] PlanetoidRadiusFromPlanetSize
		{
			get { return this.planetoidRadiusFromPlanetSizeField; }
			set
			{
				this.planetoidRadiusFromPlanetSizeField = value;
				this.RaisePropertyChanged("PlanetoidRadiusFromPlanetSize");
			}
		}


		[XmlAttribute]
		public string Category
		{
			get { return this.categoryField; }
			set
			{
				this.categoryField = value;
				this.RaisePropertyChanged("Category");
			}
		}


	}
}
