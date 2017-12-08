using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data.Entity;
using System.Globalization;

namespace ES2.Editor.Framework.Binding.Design
{
	/// <summary>
	/// TypeConverter that shows a list of types that inherit from ObjectContext and can be assigned to the ObjectContextType property.
	/// </summary>
	public class ContextTypeConverter : ReferenceConverter
	{
		public ContextTypeConverter() : base(typeof(Type)) { }


		#region Overrides

		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			return true;
		}


		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			return true;
		}


		public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			List<Type> values = new List<Type>
			{
				null // value for no data source
			};

			foreach (Type type in GetDbContextTypes(context))
			{
				// all types that derive from ObjectContext
				values.Add(type);
			}

			return new StandardValuesCollection(values);
		}


		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string);
		}


		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			if (value is string)
			{
				var values = GetDbContextTypes(context);
				foreach (var t in values)
				{
					if (t.ToString() == (string)value)
					{
						return t;
					}
				}
				return null;
			}
			return base.ConvertFrom(context, culture, value);
		}


		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (destinationType == typeof(string) && value is Type)
			{
				return value.ToString();
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}

		#endregion



		List<Type> GetDbContextTypes(ITypeDescriptorContext context)
		{
			var values = new List<Type>();
			if (context.GetService(typeof(ITypeDiscoveryService)) is ITypeDiscoveryService discoveryService)
			{
				foreach (Type type in discoveryService.GetTypes(typeof(DbContext), true))
				{
					if (type.IsPublic && type.IsVisible && !type.IsAbstract && type != typeof(DbContext))
					{
						values.Add(type);
					}
				}
			}
			return values;
		}


	}
}
