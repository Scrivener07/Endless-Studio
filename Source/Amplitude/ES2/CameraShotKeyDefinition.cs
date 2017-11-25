namespace Amplitude.ES2
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public partial class CameraShotKeyDefinition : object, System.ComponentModel.INotifyPropertyChanged
	{

		private CameraTargetOffsetDefinition mainTargetOffsetField;

		private CameraTargetOffsetDefinition mainTargetToFollowOffsetField;

		private CameraTargetOffsetDefinition[] additionalTargetOffsetsField;

		private CameraTargetOffsetDefinition[] additionalTargetToFollowOffsetsField;

		private CameraTargetFilterDefinition targetFilterField;

		private CameraTargetFilterDefinition targetToFollowFilterField;

		private SerializableVector3 targetOffsetField;

		private SerializableVector3 targetToFollowOffsetField;

		private SerializableVector3 cameraLocalOffsetField;

		private SerializableVector3 cameraPositionField;

		private SerializableQuaternion cameraRotationField;

		private SerializableVector3 cameraEulerField;

		private SerializableVector3 upVectorField;

		private CameraShotKeyLayerTransitionDefinition_Curve[] transitionField;

		private float startTimeRatioField;

		private float fieldOfViewField;


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public CameraTargetOffsetDefinition MainTargetOffset
		{
			get
			{
				return this.mainTargetOffsetField;
			}
			set
			{
				this.mainTargetOffsetField = value;
				this.RaisePropertyChanged("MainTargetOffset");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public CameraTargetOffsetDefinition MainTargetToFollowOffset
		{
			get
			{
				return this.mainTargetToFollowOffsetField;
			}
			set
			{
				this.mainTargetToFollowOffsetField = value;
				this.RaisePropertyChanged("MainTargetToFollowOffset");
			}
		}


		[System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlArrayItemAttribute("AdditionalTargetOffset", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
		public CameraTargetOffsetDefinition[] AdditionalTargetOffsets
		{
			get
			{
				return this.additionalTargetOffsetsField;
			}
			set
			{
				this.additionalTargetOffsetsField = value;
				this.RaisePropertyChanged("AdditionalTargetOffsets");
			}
		}


		[System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlArrayItemAttribute("AdditionalTargetToFollowOffset", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
		public CameraTargetOffsetDefinition[] AdditionalTargetToFollowOffsets
		{
			get
			{
				return this.additionalTargetToFollowOffsetsField;
			}
			set
			{
				this.additionalTargetToFollowOffsetsField = value;
				this.RaisePropertyChanged("AdditionalTargetToFollowOffsets");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public CameraTargetFilterDefinition TargetFilter
		{
			get
			{
				return this.targetFilterField;
			}
			set
			{
				this.targetFilterField = value;
				this.RaisePropertyChanged("TargetFilter");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public CameraTargetFilterDefinition TargetToFollowFilter
		{
			get
			{
				return this.targetToFollowFilterField;
			}
			set
			{
				this.targetToFollowFilterField = value;
				this.RaisePropertyChanged("TargetToFollowFilter");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SerializableVector3 TargetOffset
		{
			get
			{
				return this.targetOffsetField;
			}
			set
			{
				this.targetOffsetField = value;
				this.RaisePropertyChanged("TargetOffset");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SerializableVector3 TargetToFollowOffset
		{
			get
			{
				return this.targetToFollowOffsetField;
			}
			set
			{
				this.targetToFollowOffsetField = value;
				this.RaisePropertyChanged("TargetToFollowOffset");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SerializableVector3 CameraLocalOffset
		{
			get
			{
				return this.cameraLocalOffsetField;
			}
			set
			{
				this.cameraLocalOffsetField = value;
				this.RaisePropertyChanged("CameraLocalOffset");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SerializableVector3 CameraPosition
		{
			get
			{
				return this.cameraPositionField;
			}
			set
			{
				this.cameraPositionField = value;
				this.RaisePropertyChanged("CameraPosition");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SerializableQuaternion CameraRotation
		{
			get
			{
				return this.cameraRotationField;
			}
			set
			{
				this.cameraRotationField = value;
				this.RaisePropertyChanged("CameraRotation");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SerializableVector3 CameraEuler
		{
			get
			{
				return this.cameraEulerField;
			}
			set
			{
				this.cameraEulerField = value;
				this.RaisePropertyChanged("CameraEuler");
			}
		}


		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public SerializableVector3 UpVector
		{
			get
			{
				return this.upVectorField;
			}
			set
			{
				this.upVectorField = value;
				this.RaisePropertyChanged("UpVector");
			}
		}


		[System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlArrayItemAttribute("LayerTransition", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
		public CameraShotKeyLayerTransitionDefinition_Curve[] Transition
		{
			get
			{
				return this.transitionField;
			}
			set
			{
				this.transitionField = value;
				this.RaisePropertyChanged("Transition");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public float StartTimeRatio
		{
			get
			{
				return this.startTimeRatioField;
			}
			set
			{
				this.startTimeRatioField = value;
				this.RaisePropertyChanged("StartTimeRatio");
			}
		}


		[System.Xml.Serialization.XmlAttributeAttribute()]
		public float FieldOfView
		{
			get
			{
				return this.fieldOfViewField;
			}
			set
			{
				this.fieldOfViewField = value;
				this.RaisePropertyChanged("FieldOfView");
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
