﻿using ES2.Editor.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace ES2.Editor.Model
{
	[DefaultProperty("Name")]
	public abstract class EntityType : Entity, IEntityNamed
	{
		[Key, Column(Order = 1)]
		[Category("Attribute"), Description("The unique key name of this element.")]
		[XmlAttribute("Name")]
		public virtual string Name { get; set; }


		[XmlIgnore]
		[Column(Order = 0), Category(Annotations.Studio.DefaultCategory), Description(Annotations.Studio.DefaultDescription)]
		[Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		public virtual EntityTypeMeta Meta { get; set; }


		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		public virtual List<MetaInfo> DependencyList { get; set; }


		/// <summary>
		/// Each entity must store its type within the element cache. 
		/// Store the type in the entities static constructor or use the annotation attribute.
		/// </summary>
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public static TypeDictionary Serializer { get; private set; }


		static EntityType()
		{
			Serializer = new TypeDictionary();
		}

		public EntityType()
		{
			Name = Guid.NewGuid().ToString();

			Meta = new EntityTypeMeta();
			DependencyList = new List<MetaInfo>();
		}


	}
}
