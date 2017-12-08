using System;
using System.ComponentModel;

namespace ES2.Editor.Framework.Binding.Design
{
	/// <summary>
	/// Exposes all the EntitySets in a EntityDataSource as a list of PropertyDescriptor objects.
	/// </summary>
	/// <remarks>
	/// This is required for showing the available EntitySets in the drop down that
	/// appears when editing the "DataMember" property of a complex bound control.
	/// Reflected from DataViewManagerListItemTypeDescriptor
	/// </remarks>
	class EntitySetTypeDescriptor : ICustomTypeDescriptor
	{
		EntityDataSource _DataSource;
		PropertyDescriptorCollection _PropertyDescriptors;


		internal EntitySetTypeDescriptor(EntityDataSource dataSource)
		{
			this._DataSource = dataSource;
		}

		internal void Reset()
		{
			this._PropertyDescriptors = null;
		}


		#region ICustomTypeDescriptor

		object ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { return this; }
		AttributeCollection ICustomTypeDescriptor.GetAttributes() { return new AttributeCollection(null); }
		string ICustomTypeDescriptor.GetClassName() { return null; }
		string ICustomTypeDescriptor.GetComponentName() { return null; }
		TypeConverter ICustomTypeDescriptor.GetConverter() { return null; }
		EventDescriptor ICustomTypeDescriptor.GetDefaultEvent() { return null; }
		PropertyDescriptor ICustomTypeDescriptor.GetDefaultProperty() { return null; }
		object ICustomTypeDescriptor.GetEditor(Type editorBaseType) { return null; }
		EventDescriptorCollection ICustomTypeDescriptor.GetEvents() { return new EventDescriptorCollection(null); }
		EventDescriptorCollection ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { return new EventDescriptorCollection(null); }
		PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties() { return ((ICustomTypeDescriptor)this).GetProperties(null); }


		PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(Attribute[] attributes)
		{
			if (this._PropertyDescriptors == null)
			{
				PropertyDescriptor[] properties = null;
				int count = this._DataSource.EntitySets.Count;
				properties = new PropertyDescriptor[count];
				for (int i = 0; i < count; i++)
				{
					properties[i] = new EntitySetPropertyDescriptor(this._DataSource.EntitySets[i]);
				}
				this._PropertyDescriptors = new PropertyDescriptorCollection(properties);
			}
			return this._PropertyDescriptors;
		}

		#endregion
	}



	/// <summary>
	/// Custom PropertyDescriptor used by the EntitySetTypeDescriptor (above)
	/// to expose EntitySets as properties.
	/// </summary>
	/// <remarks>
	/// Reflected from DataTablePropertyDescriptor
	/// </remarks>
	class EntitySetPropertyDescriptor : PropertyDescriptor
	{
		EntitySet _view;


		internal EntitySetPropertyDescriptor(EntitySet view) : base(view.Name, null)
		{
			_view = view;
		}


		#region Overrides

		public override void ResetValue(object component) { }
		public override void SetValue(object component, object value) { }
		public override bool ShouldSerializeValue(object component) { return false; }
		public override Type ComponentType { get { return typeof(EntitySet); } }
		public override bool IsReadOnly { get { return false; } }
		public override Type PropertyType { get { return typeof(IBindingList); } }


		public override bool CanResetValue(object component)
		{
			return false;
		}

		public override bool Equals(object other)
		{
			if (other is EntitySetPropertyDescriptor)
			{
				var descriptor = (EntitySetPropertyDescriptor)other;
				return descriptor._view == this._view;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return this._view.GetHashCode();
		}

		public override object GetValue(object component)
		{
			return _view.List;
		}

		#endregion
	}
}
