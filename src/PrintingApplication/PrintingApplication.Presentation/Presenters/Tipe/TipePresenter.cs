using Equin.ApplicationFramework;
using PrintingApplication.CommonComponents;
using PrintingApplication.Domain.Models.JenisOrderan;
using PrintingApplication.Infrastructure.DataAccess.Repositories.JenisOrderan;
using PrintingApplication.Presentation.Helper;
using PrintingApplication.Presentation.Views.CommonControls;
using PrintingApplication.Presentation.Views.Tipe;
using PrintingApplication.Services.Services;
using PrintingApplication.Services.Services.JenisOrderan;
using Syncfusion.WinForms.DataGrid.Events;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace PrintingApplication.Presentation.Presenters.JenisOrderan
{
    public class TipePresenter : IJenisOrderanPresenter
    {
        private IJenisOrderanView _view;
        private IJenisOrderanServices _services;
        private List<IJenisOrderanModel> _listObjs;
        private BindingListView<JenisOrderanModel> _bindingView;
        private static string _typeName = "Tipe";

        public IJenisOrderanView GetView
        {
            get { return _view; }
        }

        public TipePresenter()
        {
            _view = new JenisOrderanView();
            _services = new JenisOrderanServices(new JenisOrderanRepository(), new ModelDataAnnotationCheck());

            _view.OnLoadData += _view_LoadData;
            _view.OnButtonTambahClick += _view_OnCreateData;
            _view.OnButtonUbahClick += _view_OnUpdateData;
            _view.OnButtonHapusClick += _view_OnDeleteData;
            _view.OnButtonRefreshClick += _view_OnRefreshData;

            _view.OnDataGridCellDoubleClick += OnDataGrid_CellDoubleClick;
        }

        private void _view_LoadData(object sender, EventArgs e)
        {
            using (new WaitCursorHandler())
            {
                if (_view.ListDataGrid != null)
                {
                    _listObjs = _services.GetAll().ToList();
                    _bindingView = new BindingListView<JenisOrderanModel>(_listObjs);
                    _view.ListDataGrid.DataSource = _bindingView;
                }
            }
        }

        private void _view_OnCreateData(object sender, EventArgs e)
        {
            var view = new JenisOrderanEntryView();
            view.OnSaveData += TipeEntryView_OnSaveData;
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
                    var model = _services.GetById(((JenisOrderanModel)listDataGrid.SelectedItem).id);

                    if (model != null)
                    {
                        var view = new JenisOrderanEntryView(false, model);
                        view.OnSaveData += TipeEntryView_OnSaveData;
                        view.ShowDialog();
                    }
                }
            }
        }

        private void TipeEntryView_OnSaveData(object sender, EventArgs e)
        {
            using (new WaitCursorHandler())
            {
                try
                {
                    var listDataGrid = _view.ListDataGrid;
                    var newModel = ((ModelEventArgs<JenisOrderanModel>)e).Value;
                    var view = ((JenisOrderanEntryView)sender);

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
                        var model = _services.GetById(((JenisOrderanModel)_view.ListDataGrid.SelectedItem).id);

                        _services.Delete(model);
                        Messages.InfoDelete(_typeName);

                        if (_listObjs.Remove((JenisOrderanModel)_view.ListDataGrid.SelectedItem))
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

        private void OnDataGrid_CellDoubleClick(object sender, CellClickEventArgs e)
        {
            _view_OnUpdateData(sender, e);
        }
    }
}
