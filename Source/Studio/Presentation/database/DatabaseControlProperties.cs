using System.Drawing;
using System.Windows.Forms;

namespace Studio.Presentation
{
	public partial class DatabaseControlProperties : UserControl
	{
		public object SelectedObject
		{
			get { return c_PropertyGrid.SelectedObject; }
			set { c_PropertyGrid.SelectedObject = value; }
		}


		public DatabaseControlProperties()
		{
			InitializeComponent();
			this.c_PropertyGrid.CategoryForeColor = SystemColors.InactiveCaptionText;
			this.c_PropertyGrid.PropertySort = PropertySort.NoSort;
			this.c_PropertyGrid.UseCompatibleTextRendering = true;
		}


	}
}
