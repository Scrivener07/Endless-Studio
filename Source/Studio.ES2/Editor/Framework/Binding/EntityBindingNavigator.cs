using ES2.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;

namespace ES2.Editor.Framework.Binding
{
	/// <summary>
	/// DataSource component that exposes EntityFramework ObjectSet and provides navigation,
	/// add/remove, and save/cancel changes buttons.
	/// </summary>
	/// <remarks>
	/// This class contains a <see cref="entitySource"/> and exposes one of the entity sets available for binding.
	/// </remarks>r
	[ToolboxItem(true), ToolboxBitmap(typeof(EntityBindingNavigator), "EntityBindingNavigator.png")]
	[DefaultProperty("DataSource"), ComplexBindingProperties("DataSource", "DataMember")]
	public partial class EntityBindingNavigator : ToolStrip
	{
		/// <summary>
		/// Gets or sets the data source for this navigator.
		/// </summary>
		[DefaultValue(null), AttributeProvider(typeof(IListSource))]
		public object DataSource
		{
			get { return _SourceObject; }
			set { _SourceObject = value; UpdateCurrencyManager(); }
		}

		object _SourceObject;
		EntityDataSource entitySource { get { return _SourceObject as EntityDataSource; } }



		/// <summary>
		/// Gets or sets the specific list in a <see cref="DataSource"/> object that the navigator should display.
		/// </summary>
		[DefaultValue(""), Editor("System.Windows.Forms.Design.DataMemberListEditor, System.Design", typeof(UITypeEditor))]
		public string DataMember
		{
			get { return _dataMember; }
			set { _dataMember = value; UpdateCurrencyManager(); }
		}
		string _dataMember = String.Empty;



		CurrencyManager _currencyManager;




		/// <summary>
		/// Gets a reference to the list being managed by this navigator.
		/// </summary>
		[Browsable(false)]
		public IBindingList List { get { return _currencyManager != null ? _currencyManager.List as IBindingList : null; } }


		/// <summary>
		/// Gets the item that is currently selected.
		/// </summary>
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public object CurrentItem { get { return _currencyManager != null ? _currencyManager.Current : null; } }


		/// <summary>
		/// Gets or sets the index of the item that is currently selected.
		/// </summary>
		[Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public int Position
		{
			get { return _currencyManager != null ? _currencyManager.Position : -1; }
			set { if (_currencyManager != null) _currencyManager.Position = value; }
		}


		#region Button Properties

		/// <summary>
		/// Gets or sets whether the control should display the navigation buttons.
		/// </summary>
		[DefaultValue(true)]
		public bool ShowNavigationButtons
		{
			get { return _showBtnNav; }
			set { _showBtnNav = c_FirstButton.Visible = c_PreviousButton.Visible = c_NextButton.Visible = c_CurrentLabel.Visible = c_LastButton.Visible = _sepNav.Visible = value; }
		}


		/// <summary>
		/// Gets or sets whether the control should display the add/remove item buttons.
		/// </summary>
		[DefaultValue(true)]
		public bool ShowAddRemoveButtons
		{
			get { return _showBtnAdd; }
			set { _showBtnAdd = c_AddButton.Visible = c_RemoveButton.Visible = _sepAddRemove.Visible = value; }
		}


		/// <summary>
		/// Gets or sets whether the control should display the save/undo/refresh buttons.
		/// </summary>
		[DefaultValue(true)]
		public bool ShowSaveUndoRefreshButtons
		{
			get { return _showBtnSave; }
			set { _showBtnSave = c_SaveButton.Visible = c_UndoButton.Visible = c_RefreshButton.Visible = value; }
		}


		#endregion


		/// <summary>
		/// Initializes a new instance of a <see cref="EntityBindingNavigator"/>.
		/// </summary>
		public EntityBindingNavigator()
		{
			InitializeComponent();
			Dock = DockStyle.Top;
			ShowNavigationButtons = ShowAddRemoveButtons = ShowSaveUndoRefreshButtons = true;
			UpdateUI();
		}

		#region Forms

		bool _showBtnNav, _showBtnAdd, _showBtnSave;

		ToolStripButton c_FirstButton, c_PreviousButton, c_NextButton, c_LastButton;
		ToolStripLabel c_CurrentLabel;
		ToolStripButton c_SaveButton, c_UndoButton, c_RefreshButton;
		ToolStripButton c_AddButton, c_RemoveButton;
		ToolStripSeparator _sepNav, _sepAddRemove;


		void InitializeComponent()
		{


			c_FirstButton = new ToolStripButton("First", Resources.Backward_16x, _btnFirst_Click);
			c_PreviousButton = new ToolStripButton("Previous", Resources.Previous_16x, _btnPrev_Click);
			c_CurrentLabel = new ToolStripLabel("0 of 0");
			c_NextButton = new ToolStripButton("Next", Resources.Next_16x, _btnNext_Click);
			c_LastButton = new ToolStripButton("Last", Resources.Forward_16x, _btnLast_Click);

			foreach (var btn in new ToolStripButton[] { c_FirstButton, c_PreviousButton, c_NextButton, c_LastButton })
			{
				btn.DisplayStyle = ToolStripItemDisplayStyle.Image;
				Items.Add(btn);
			}
			Items.Insert(2, c_CurrentLabel);

			_sepNav = new ToolStripSeparator();
			Items.Add(_sepNav);

			c_AddButton = new ToolStripButton("Add", Resources.Add_16x, _btnAdd_Click);
			c_RemoveButton = new ToolStripButton("Remove", Resources.Cancel_16x, _btnRemove_Click);

			foreach (var btn in new ToolStripButton[] { c_AddButton, c_RemoveButton })
			{
				btn.DisplayStyle = ToolStripItemDisplayStyle.Image;
				Items.Add(btn);
			}
			_sepAddRemove = new ToolStripSeparator();
			Items.Add(_sepAddRemove);

			c_SaveButton = new ToolStripButton("Save", Resources.Save_16x, _btnSave_Click);
			c_UndoButton = new ToolStripButton("Undo", Resources.Undo_16x, _btnCancel_Click);
			c_RefreshButton = new ToolStripButton("Refresh", Resources.Refresh_16x, _btnRefresh_Click);

			foreach (var btn in new ToolStripButton[] { c_RefreshButton, c_UndoButton, c_SaveButton })
			{
				btn.Alignment = ToolStripItemAlignment.Right;
				Items.Add(btn);
			}

			foreach (ToolStripItem item in Items)
			{
				item.Visible = true;
			}
		}

		#endregion

		#region Binding

		/// <summary>
		/// Sets the DataSource and DataMember properties at the same time.
		/// </summary>
		public void SetDataBinding(object dataSource, string dataMember)
		{
			_SourceObject = dataSource;
			_dataMember = dataMember;
			UpdateCurrencyManager();
		}


		/// <summary>
		/// Update the internal CurrencyManager when the BindingContext changes.
		/// </summary>
		/// <param name="e"></param>
		protected override void OnBindingContextChanged(EventArgs e)
		{
			base.OnBindingContextChanged(e);
			UpdateCurrencyManager();
		}


		// update the currency manager to handle a new DataSource, DataMember, or BindingContext
		void UpdateCurrencyManager()
		{
			// disconnect old
			if (_currencyManager != null)
			{
				_currencyManager.PositionChanged -= _cm_PositionChanged;
				_currencyManager.ListChanged -= _cm_ListChanged;
			}

			// get new currency manager
			_currencyManager = null;
			if (DataSource != null && Parent != null && BindingContext != null)
			{
				try
				{
					_currencyManager = BindingContext[DataSource, DataMember] as CurrencyManager;
				}
				catch { }
			}

			// connect new
			if (_currencyManager != null)
			{
				_currencyManager.PositionChanged += _cm_PositionChanged;
				_currencyManager.ListChanged += _cm_ListChanged;
			}

			// show UI
			UpdateUI();
		}


		void UpdateUI()
		{
			if (_currencyManager != null)
			{
				c_CurrentLabel.Text = string.Format("{0} of {1}", _currencyManager.Position + 1, _currencyManager.Count);
				c_FirstButton.Enabled = c_PreviousButton.Enabled = _currencyManager.Position > 0;
				c_LastButton.Enabled = c_NextButton.Enabled = _currencyManager.Position < _currencyManager.Count - 1;

				var bl = _currencyManager.List as IBindingList;
				c_AddButton.Enabled = bl != null && bl.AllowNew;
				c_RemoveButton.Enabled = bl != null && bl.AllowRemove;
			}
			else
			{
				c_FirstButton.Enabled = c_PreviousButton.Enabled = false;
				c_LastButton.Enabled = c_NextButton.Enabled = false;
				c_AddButton.Enabled = c_RemoveButton.Enabled = false;
			}

			c_SaveButton.Enabled = c_UndoButton.Enabled = c_RefreshButton.Enabled = entitySource != null;
		}


		// update UI when postion/list changes
		void _cm_PositionChanged(object sender, EventArgs e)
		{
			UpdateUI();
			OnPositionChanged(e);
		}


		void _cm_ListChanged(object sender, ListChangedEventArgs e)
		{
			if (e.ListChangedType != ListChangedType.ItemChanged)
			{
				UpdateUI();
			}
			OnListChanged(e);
		}

		#endregion

		#region Events

		/// <summary>
		/// Occurs when the current item changes.
		/// </summary>
		public event EventHandler PositionChanged;

		/// <summary>
		/// Raises the <see cref="PositionChanged"/> event.
		/// </summary>
		/// <param name="e"></param>
		protected virtual void OnPositionChanged(EventArgs e)
		{
			if (PositionChanged != null)
				PositionChanged(this, e);
		}



		/// <summary>
		/// Occurs when the current item changes.
		/// </summary>
		public event ListChangedEventHandler ListChanged;

		/// <summary>
		/// Raises the <see cref="ListChanged"/> event.
		/// </summary>
		/// <param name="e"></param>
		protected virtual void OnListChanged(ListChangedEventArgs e)
		{
			if (ListChanged != null)
				ListChanged(this, e);
		}



		/// <summary>
		/// Occurs before a new item is added to the list.
		/// </summary>
		public event CancelEventHandler AddingNew;

		/// <summary>
		/// Raises the <see cref="AddingNew"/> event.
		/// </summary>
		/// <param name="e"><see cref="CancelEventArgs"/> that contains the event parameters.</param>
		protected virtual void OnAddingNew(CancelEventArgs e)
		{
			if (AddingNew != null)
				AddingNew(this, e);
		}



		/// <summary>
		/// Occurs after a new item is added to the list.
		/// </summary>
		public event EventHandler AddedNew;

		/// <summary>
		/// Raises the <see cref="AddedNew"/> event.
		/// </summary>
		/// <param name="e"><see cref="EventArgs"/> that contains the event parameters.</param>
		protected virtual void OnAddedNew(EventArgs e)
		{
			if (AddedNew != null)
				AddedNew(this, e);
		}



		/// <summary>
		/// Occurs before an item is removed from the list.
		/// </summary>
		public event CancelEventHandler RemovingItem;

		/// <summary>
		/// Raises the <see cref="RemovingItem"/> event.
		/// </summary>
		/// <param name="e"><see cref="CancelEventArgs"/> that contains the event parameters.</param>
		protected virtual void OnRemovingItem(CancelEventArgs e)
		{
			if (RemovingItem != null)
				RemovingItem(this, e);
		}


		/// <summary>
		/// Occurs after an item is removed from the list.
		/// </summary>
		public event EventHandler RemovedItem;

		/// <summary>
		/// Raises the <see cref="RemovedItem"/> event.
		/// </summary>
		/// <param name="e"><see cref="EventArgs"/> that contains the event parameters.</param>
		protected virtual void OnRemovedItem(EventArgs e)
		{
			if (RemovedItem != null)
				RemovedItem(this, e);
		}

		#endregion

		#region Button Events

		// navigation
		void _btnFirst_Click(object sender, EventArgs e)
		{
			if (_currencyManager != null)
			{
				_currencyManager.Position = 0;
			}
		}


		void _btnPrev_Click(object sender, EventArgs e)
		{
			if (_currencyManager != null && _currencyManager.Position > 0)
			{
				_currencyManager.Position--;
			}
		}


		void _btnNext_Click(object sender, EventArgs e)
		{
			if (_currencyManager != null && _currencyManager.Position < _currencyManager.Count - 1)
			{
				_currencyManager.Position++;
			}
		}


		void _btnLast_Click(object sender, EventArgs e)
		{
			if (_currencyManager != null)
			{
				_currencyManager.Position = _currencyManager.Count - 1;
			}
		}

		// add/remove records
		void _btnAdd_Click(object sender, EventArgs e)
		{
			// notify
			var ce = new CancelEventArgs();
			OnAddingNew(ce);

			if (_currencyManager != null && _currencyManager.List is IBindingList && !ce.Cancel)
			{
				// add new
				var bl = _currencyManager.List as IBindingList;
				var newItem = bl.AddNew();

				// notify
				OnAddedNew(e);

				// make sure new item is selected
				_currencyManager.Position = bl.IndexOf(newItem);
			}

		}


		void _btnRemove_Click(object sender, EventArgs e)
		{
			// notify
			var ce = new CancelEventArgs();
			OnRemovingItem(ce);

			if (_currencyManager != null && _currencyManager.Current != null && _currencyManager.List is IBindingList && !ce.Cancel)
			{
				// remove current item
				var bl = _currencyManager.List as IBindingList;
				bl.Remove(_currencyManager.Current);

				// notify
				OnRemovedItem(e);
			}
		}


		// save/cancel/refresh
		void _btnSave_Click(object sender, EventArgs e)
		{
			if (entitySource != null)
			{
				entitySource.SaveChanges();
			}
		}


		void _btnCancel_Click(object sender, EventArgs e)
		{
			if (entitySource != null)
			{
				entitySource.CancelChanges();
			}
		}


		void _btnRefresh_Click(object sender, EventArgs e)
		{
			if (entitySource != null)
			{
				entitySource.Refresh();
			}
		}

		#endregion



	}
}