using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES2.EntityFramework
{
	public interface IEntity
	{
		/// <summary>
		/// Make sure to use [XmlIgnore]
		/// </summary>
		int ID { get; set; } // EF6
	}
}
