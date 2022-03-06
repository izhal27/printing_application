using Dexih.Utils.CopyProperties;
using Equin.ApplicationFramework;
using PrintingApplication.CommonComponents;
using PrintingApplication.Domain.Models.Pelanggan;
using PrintingApplication.Infrastructure.DataAccess.Repositories.Pelanggan;
using PrintingApplication.Presentation.Helper;
using PrintingApplication.Presentation.Views.CommonControls;
using PrintingApplication.Presentation.Views.Pelanggan;
using PrintingApplication.Services.Services;
using PrintingApplication.Services.Services.Pelanggan;
using Syncfusion.WinForms.DataGrid.Events;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintingApplication.Presentation.Presenters.Pelanggan
{
    public class PelangganPresenter : IPelangganPresenter
    {
        private IPelangganView _view;
        private IPelangganServices _services;
        private List<IPelangganModel> _listObjs;
        private BindingListView<PelangganModel> _bindingView;
        private static string _typeName = "Pelanggan";

        public IPelangganView GetView
        {
            get { return _view; }
        }

        public PelangganPresenter()
        {
            _view = new PelangganView();
            _services = new PelangganServices(new PelangganRepository(), new ModelDataAnnotationCheck());

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
                    _bindingView = new BindingListView<PelangganModel>(_listObjs);
                    _view.ListDataGrid.DataSource = _bindingView;
                }
            }
        }

        private void _view_OnCreateData(object sender, EventArgs e)
        {
            var view = new PelangganEntryView();
            view.OnSaveData += PelangganEntryView_OnSaveData;
            view.ShowDialog();
        }

        private void _view_OnUpdateData(object sender, EventArgs e)
        {
            using (new WaitCursorHandler())
            {
                var listDataGrid = sender is ListDataGrid ? (ListDataGrid)sender : _view.ListDataGrid;

                if (listDataGrid?.SelectedItem != null)
                {
                    var model = _services.GetById(((PelangganModel)listDataGrid.SelectedItem).id);

                    if (model != null)
                    {
                        var view = new PelangganEntryView(false, model);
                        view.OnSaveData += PelangganEntryView_OnSaveData;
                        view.ShowDialog();
                    }
                }
            }
        }

        private void PelangganEntryView_OnSaveData(object sender, EventArgs e)
        {
            using (new WaitCursorHandler())
            {
                try
                {
                    var listDataGrid = _view.ListDataGrid;
                    var newModel = ((ModelEventArgs<PelangganModel>)e).Value;
                    var view = ((PelangganEntryView)sender);

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
                            newModel.CopyProperties(model);

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
                        var model = _services.GetById(((PelangganModel)_view.ListDataGrid.SelectedItem).id);

                        _services.Delete(model);
                        Messages.InfoDelete(_typeName);

                        if (_listObjs.Remove((PelangganModel)_view.ListDataGrid.SelectedItem))
                        {
                            _bindingView.DataSource = _listObjs;
                        }
                    }
                    catch (DataAccessException ex)
                    {
                        Messages.Error(ex);
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
