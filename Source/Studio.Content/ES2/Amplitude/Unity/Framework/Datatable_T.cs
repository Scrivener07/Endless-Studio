using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES2.Amplitude.Unity.Framework
{
	public class Datatable<T> : Dictionary<string, T> where T : IDatatableElement
	{

	}
}
