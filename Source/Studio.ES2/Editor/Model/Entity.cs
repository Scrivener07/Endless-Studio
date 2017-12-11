using System;
using System.ComponentModel;

namespace ES2.Editor.Model
{
	[Serializable]
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public abstract class Entity : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged

		public event PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if ((propertyChanged != null))
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion
	}
}
