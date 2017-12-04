using System.Windows.Forms;

namespace Studio.Presentation
{
	public partial class DatabaseControlSelected : UserControl
	{
		public string Table { get { return c_TabelLabel.Text; } set { c_TabelLabel.Text = value; } }
		public string Record { get { return c_RecordLabel.Text; } set { c_RecordLabel.Text = value; } }


		public DatabaseControlSelected()
		{
			InitializeComponent();
		}
	}
}
