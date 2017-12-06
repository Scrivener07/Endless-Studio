using Studio.Framework;
using Studio.Model;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Studio.Presentation
{
	public partial class DatabaseControl : UserControl
	{

		public DatabaseControl()
		{
			InitializeComponent();
			this.c_DataGridView.AutoGenerateColumns = true;
			this.c_DataGridView.AllowUserToOrderColumns = true;
			this.c_DataGridView.AllowUserToResizeRows = false;
			this.c_DataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
			this.c_DataGridView.AlternatingRowsDefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
			this.c_DataGridView.AlternatingRowsDefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
			this.c_DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			this.c_DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.c_DataGridView.MultiSelect = false;
			this.c_DataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.c_PropertyGrid.CategoryForeColor = SystemColors.InactiveCaptionText;
			this.c_PropertyGrid.PropertySort = PropertySort.NoSort;
			this.c_PropertyGrid.UseCompatibleTextRendering = true;
		}


		private void OnLoad(object sender, System.EventArgs e)
		{
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


		[Category("Data")]
		public BindingSource BindingSource
		{
			get { return EntityBinding; }
			set { EntityBinding = value; }
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

						if (dataItem is INamed)
						{
							var kSelected = dataItem as INamed;
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
