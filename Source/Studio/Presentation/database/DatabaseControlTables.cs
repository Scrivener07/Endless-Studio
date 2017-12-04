using Studio.Framework;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Studio.Presentation
{
	public partial class DatabaseControlTables : UserControl
	{
		[Category("Database")]
		public event TreeNodeMouseClickEventHandler NodeMouseClick
		{
			add { c_TreeView.NodeMouseClick += value; }
			remove { c_TreeView.NodeMouseClick -= value; }
		}


		public DatabaseControlTables()
		{
			InitializeComponent();
		}


		private void OnLoad(object sender, EventArgs e)
		{
			c_TreeView.Nodes.Add(new TreeNode("default"));

			using (EntityContext context = new EntityContext())
			{
				context.GetTableNames().ForEach(name => c_TreeView.Nodes.Add(new TreeNode(name) { Name = name }));
			}
		}

		private void c_TreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{

		}
	}
}
