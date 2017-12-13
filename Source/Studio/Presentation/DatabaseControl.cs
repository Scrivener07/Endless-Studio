using ES2.Editor.Framework;
using ES2.Editor.Model;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Studio.Presentation
{
	public partial class DatabaseControl : UserControl
	{
		//[Category("Data")]
		//public BindingSource BindingSource
		//{
		//	get { return EntityBinding; }
		//	set { EntityBinding = value; }
		//}


		public DatabaseControl()
		{
			InitializeComponent();
			c_DataGridView.AutoGenerateColumns = true; // create columns automatically
			c_DataGridView.AllowUserToOrderColumns = true;
			c_DataGridView.AllowUserToResizeRows = false;
			c_DataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
			c_DataGridView.AlternatingRowsDefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
			c_DataGridView.AlternatingRowsDefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
			c_DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			c_DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			c_DataGridView.MultiSelect = false;
			c_DataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			c_PropertyGrid.CategoryForeColor = SystemColors.InactiveCaptionText;
			c_PropertyGrid.PropertySort = PropertySort.NoSort;
			c_PropertyGrid.UseCompatibleTextRendering = true;
		}


		private void OnLoad(object sender, System.EventArgs e)
		{
			c_DataGridView.AutoGenerateColumns = true; // create columns automatically

			c_TreeView.Nodes.Add(new TreeNode("default"));

			using (EntityContext context = new EntityContext())
			{
				context.GetTableNames().ForEach(name => c_TreeView.Nodes.Add(new TreeNode(name) { Name = name }));
			}

			//TableSelected("RuntimeModules"); // TODO: temporary mic test
		}


		private void c_TreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			TableSelected(e.Node.Text);
		}


		#region Selected

		private void TableSelected(string tableName)
		{
			EntityBinding.DataMember = tableName;
			EntityNavigator.DataMember = tableName;
			SelectedTableName = tableName;
			Trace.WriteLine("You have selected the " + tableName + " table.");
		}


		private object SelectedObject
		{
			get { return c_PropertyGrid.SelectedObject; }
			set { c_PropertyGrid.SelectedObject = value; }
		}

		private string SelectedTableName { get { return c_TabelLabel.Text; } set { c_TabelLabel.Text = value; } }
		private string SelectedRecordName { get { return c_RecordLabel.Text; } set { c_RecordLabel.Text = value; } }

		private void c_DataGridView_SelectionChanged(object sender, System.EventArgs e)
		{
			if (sender is DataGridView)
			{
				var grid = sender as DataGridView;

				if (grid.SelectedRows.Count > 0)
				{
					var dataItem = grid.SelectedRows[0].DataBoundItem;

					if (dataItem != null)
					{
						c_PropertyGrid.SelectedObject = dataItem;

						string selectedName = "unknown";

						if (dataItem is IEntityNamed)
						{
							var kSelected = dataItem as IEntityNamed;
							selectedName = kSelected.Name;
						}

						Trace.WriteLine("You have selected the '" + selectedName + "' record from the '" + dataItem.GetType().Name + "' table.");
						c_RecordLabel.Text = selectedName;
						return;
					}
				}
			}

			c_RecordLabel.Text = "null record";
			Trace.WriteLine("You have selected a null record.");
		}

		#endregion


	}
}
