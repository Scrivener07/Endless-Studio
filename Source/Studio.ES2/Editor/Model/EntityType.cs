using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace ES2.Editor.Model
{
	[DefaultProperty("Name")]
	public abstract class EntityType : Entity, IEntityNamed
	{
		EntityTypeMeta Meta;


		[Key, Column(Order = 1)]
		[Category("Attribute"), Description(Modeling.NameDescription)]
		[XmlAttribute("Name")]
		public virtual string Name { get; set; }


		public EntityType()
		{
			Name = Guid.NewGuid().ToString();
			Meta = new EntityTypeMeta();
		}


		public void SetMeta(EntityTypeMeta entityTypeMeta)
		{
			Meta = entityTypeMeta;
		}


		public EntityTypeMeta GetMeta()
		{
			return Meta;
		}


	}
}
