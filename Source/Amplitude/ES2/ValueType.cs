﻿using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Amplitude.ES2
{
	[XmlInclude(typeof(GuiCursorImage))]
	[XmlInclude(typeof(GuiCursorHotSpot))]
	[XmlInclude(typeof(XmlColor))]
	[XmlInclude(typeof(DummyGeneratorInfo))]
	[XmlInclude(typeof(SimulationDescriptorReference))]
	[XmlInclude(typeof(IconDefinition))]
	[XmlInclude(typeof(SimulationDescriptorReference))]
	[GeneratedCode("xsd", "2.0.50727.3038")]
	[Serializable]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	public class ValueType : INotifyPropertyChanged
	{
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
