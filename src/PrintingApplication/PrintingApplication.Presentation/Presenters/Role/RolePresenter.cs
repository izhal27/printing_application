using Equin.ApplicationFramework;
using PrintingApplication.CommonComponents;
using PrintingApplication.Domain.Models.Role;
using PrintingApplication.Infrastructure.DataAccess.Repositories.Role;
using PrintingApplication.Presentation.Helper;
using PrintingApplication.Presentation.Views.CommonControls;
using PrintingApplication.Services.Services;
using PrintingApplication.Services.Services.Role;
using Syncfusion.WinForms.DataGrid.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Presenters.Role
{
    public class RolePresenter : IRolePresenter
    {
        private IRoleView _view;
        private IRoleServices _services;
        private List<IRoleModel> _listObjs;
        private BindingListView<RoleModel> _bindingView;
        private static string _typeName = "Role";
        private RoleManager _roleManager;

        public IRoleView GetView
        {
            get { return _view; }
        }

        public RolePresenter()
        {
            _view = new RoleView();
            _services = new RoleServices(new RoleRepository(), new ModelDataAnnotationCheck());
            _roleManager = new RoleManager();

            _roleManager = new RoleManager();
            _roleManager.TreeView = _view.TreeViewAction;
            // Enable buttons
            _roleManager.EnableButtons((Form)_view);

            // Atur DataSource ComboBox menu
            var listKvp = _roleManager.DataSourceMenuParent();
            _view.ComboBoxMenu.SetDataSource(listKvp, false);

            PopulateMenuStripToTreeView();

            _view.OnLoadData += _view_LoadData;
            _view.OnListDataGridSelectionChanged += _view_OnListDataGridSelectionChanged;
            _view.OnComboBoxMenuSelectedIndexChanged += _view_OnComboBoxMenuSelectedIndexChanged;
            _view.OnButtonTambahClick += _view_OnCreateData;
            _view.OnButtonUbahClick += _view_OnUpdateData;
            _view.OnButtonHapusClick += _view_OnDeleteData;
            _view.OnButtonRefreshClick += _view_OnRefreshData;
            _view.OnButtonUpdateActionClick += _view_OnButtonUpdateActionClick;

            _view.OnDataGridCellDoubleClick += OnDataGrid_CellDoubleClick;
        }

        private void _view_LoadData(object sender, EventArgs e)
        {
            using (new WaitCursorHandler())
            {
                if (_view.ListDataGrid != null)
                {
                    _listObjs = _services.GetAll().ToList();
                    _bindingView = new BindingListView<RoleModel>(_listObjs);
                    _view.ListDataGrid.DataSource = _bindingView;
                }
            }
        }

        private void _view_OnListDataGridSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PopulateRoleToTreeView();
        }

        private void _view_OnComboBoxMenuSelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateMenuStripToTreeView();
        }

        private void _view_OnCreateData(object sender, EventArgs e)
        {
            var view = new RoleEntryView();
            view.OnSaveData += RoleEntryView_OnSaveData;
            view.ShowDialog();
        }

        private void _view_OnUpdateData(object sender, EventArgs e)
        {
            using (new WaitCursorHandler())
            {
                ListDataGrid listDataGrid = null;

                if (sender is ListDataGrid)
                {
                    listDataGrid = (ListDataGrid)sender;
                }
                else
                {
                    listDataGrid = _view.ListDataGrid;
                }

                if (listDataGrid != null && listDataGrid.SelectedItem != null)
                {
                    var model = _services.GetById(((RoleModel)listDataGrid.SelectedItem).id);

                    if (model != null)
                    {
                        var view = new RoleEntryView(false, model);
                        view.OnSaveData += RoleEntryView_OnSaveData;
                        view.ShowDialog();
                    }
                }
            }
        }

        private void RoleEntryView_OnSaveData(object sender, EventArgs e)
        {
            using (new WaitCursorHandler())
            {
                try
                {
                    var listDataGrid = _view.ListDataGrid;
                    var newModel = ((ModelEventArgs<RoleModel>)e).Value;
                    var view = ((RoleEntryView)sender);

                    if (newModel.id == default(uint))
                    {
                        _services.Insert(newModel);
                        view.Controls.ClearControls();
                        Messages.InfoSave(_typeName);

                        _listObjs.Add(newModel);
                        _bindingView.DataSource = _listObjs;

                        if (listDataGrid.SelectedItem != null)
                        {
                            listDataGrid.SelectedItem = null;
                        }

                        listDataGrid.SelectedItem = newModel;
                    }
                    else
                    {
                        _services.Update(newModel);
                        Messages.InfoUpdate(_typeName);
                        view.Close();

                        var model = _bindingView.Where(b => b.id == newModel.id).FirstOrDefault();

                        if (model != null)
                        {
                            model.kode = newModel.kode;
                            model.nama = newModel.nama;
                            model.keterangan = newModel.keterangan;

                            _bindingView.Refresh();
                        }
                    }
                }
                catch (ArgumentException ex)
                {
                    Messages.Error(ex);
                }
                catch (DataAccessException ex)
                {
                    Messages.Error(ex);
                }
            }
        }

        private void _view_OnDeleteData(object sender, EventArgs e)
        {
            using (new WaitCursorHandler())
            {
                if (_view.ListDataGrid != null && _view.ListDataGrid.SelectedItem != null && Messages.ConfirmDelete(_typeName))
                {
                    try
                    {
                        var model = _services.GetById(((RoleModel)_view.ListDataGrid.SelectedItem).id);

                        _services.Delete(model);
                        Messages.InfoDelete(_typeName);

                        if (_listObjs.Remove((RoleModel)_view.ListDataGrid.SelectedItem))
                        {
                            _bindingView.DataSource = _listObjs;
                        }
                    }
                    catch (DataAccessException ex)
                    {
                        Messages.Error(ex);
                        _view_OnRefreshData(null, null);
                    }
                    finally
                    {
                        if (_view.ListDataGrid.SelectedItem != null)
                        {
                            _view.ListDataGrid.SelectedItem = null;
                        }
                    }
                }
            }
        }

        private void _view_OnRefreshData(object sender, EventArgs e)
        {
            _listObjs = _services.GetAll().ToList();
            _bindingView.DataSource = _listObjs;
        }

        private void _view_OnButtonUpdateActionClick(object sender, EventArgs e)
        {
            try
            {
                if (_view.ListDataGrid.SelectedItem != null)
                {
                    if (Messages.Confirm($"Update action Role terpilih?"))
                    {
                        var itemSelected = (RoleModel)_view.ListDataGrid.SelectedItem;
                        _roleManager.UpdateRole(itemSelected.kode, _view.ComboBoxMenu.SelectedValue.ToString());
                        Messages.Info("Role berhasil diupdate");
                    }
                }
            }
            catch (ArgumentException ex)
            {
                Messages.Error(ex);
            }
            catch (DataAccessException ex)
            {
                Messages.Error(ex);
            }
        }

        private void OnDataGrid_CellDoubleClick(object sender, CellClickEventArgs e)
        {
            _view_OnUpdateData(sender, e);
        }

        private void PopulateMenuStripToTreeView()
        {
            _roleManager.PopulateMenuStripToTreeView(_view.ComboBoxMenu.SelectedValue.ToString());
            // Terapkan role terpilih ke TreeView
            PopulateRoleToTreeView();
        }

        private void PopulateRoleToTreeView()
        {
            if (_view.ListDataGrid.SelectedItem != null)
            {
                var itemSelected = (RoleModel)_view.ListDataGrid.SelectedItem;
                _roleManager.PopulateRoleDetailToTreeView(itemSelected.kode, _view.ComboBoxMenu.SelectedValue.ToString());
            }
        }
    }
}
