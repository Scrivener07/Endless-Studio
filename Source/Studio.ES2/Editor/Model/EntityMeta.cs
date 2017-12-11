using ES2.Editor.Assets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing.Design;

namespace ES2.Editor.Model
{
	[ComplexType]
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class EntityMeta
	{

		/// <summary>
		/// The asset that "owns" this entity.
		/// </summary>
		[NotMapped]
		public TableAsset Asset { get; set; }



		// current
		public string Owner { get; set; }
		public string Location { get; set; }

		// override
		public string Comment { get; set; }


		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		public virtual BindingList<TextData> TextList { get; set; }




		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		public virtual Stack<string> NameStack { get; set; }




		[Browsable(true), DisplayName("Dependencies")]
		[Description("Description that would be viewed")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		[Editor(arrayeditor, typeof(UITypeEditor))]
		public virtual string[] Dependencies { get; set; }




		public EntityMeta()
		{
			Owner = "unknown";
			Location = "unknown";
			Comment = String.Empty;

			Dependencies = new string[2];
			Dependencies[0] = "none";
			Dependencies[1] = "none";

			NameStack = new Stack<string>();


			TextList = new BindingList<TextData>();
		}



		public override string ToString()
		{
			return Owner;
		}


		const string arrayeditor = "System.Windows.Forms.Design.StringArrayEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
	}






	[ComplexType]
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class MetaInfo
	{
		public string Mod { get; set; }
		public string File { get; set; }



		public MetaInfo()
		{
			Mod = String.Empty;
			File = String.Empty;
		}


		public override string ToString()
		{
			return Mod;
		}
	}






	[ComplexType]
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class TextData
	{
		[Key]
		public virtual string Id { get; set; }
		public string Text { get; set; }

		public TextData()
		{
			Id = Guid.NewGuid().ToString();
		}
	}
}
