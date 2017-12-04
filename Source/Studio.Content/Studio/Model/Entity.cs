using System;
using System.ComponentModel;

namespace Studio.Model
{
	[Serializable]
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
