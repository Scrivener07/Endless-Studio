using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace Studio.Model
{
	[DefaultProperty("Name")]
	public abstract class EntityType : Entity, INamed
	{
		[Key, Column(Order = 1)]
		//[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Category("Attribute"), Description("The unique key name of this element.")]
		[XmlAttribute("Name")]
		public virtual string Name { get; set; }


		[XmlIgnore]
		[Column(Order = 0), Category(ModelSettings.Studio.DefaultCategory), Description(ModelSettings.Studio.DefaultDescription)]
		[Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		public virtual EntityMeta Meta { get; set; }




		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public static ElementCache Serializer { get; private set; }





		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		public virtual List<MetaInfo> DependencyList { get; set; }





		static EntityType()
		{
			Serializer = new ElementCache();
		}

		public EntityType()
		{
			Name = Guid.NewGuid().ToString();
			DependencyList = new List<MetaInfo>();
			Meta = new EntityMeta();
		}


	}
}
