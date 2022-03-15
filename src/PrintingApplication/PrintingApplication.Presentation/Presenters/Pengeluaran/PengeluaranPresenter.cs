using Equin.ApplicationFramework;
using PrintingApplication.CommonComponents;
using PrintingApplication.Domain.Models.Pengeluaran;
using PrintingApplication.Infrastructure.DataAccess.Repositories.Pengeluaran;
using PrintingApplication.Presentation.Helper;
using PrintingApplication.Presentation.Views.CommonControls;
using PrintingApplication.Presentation.Views.Pengeluaran;
using PrintingApplication.Services.Services;
using PrintingApplication.Services.Services.Pengeluaran;
using Syncfusion.WinForms.DataGrid.Events;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintingApplication.Presentation.Presenters.Pengeluaran
{
    public class PengeluaranPresenter : IPengeluaranPresenter
    {
        private IPengeluaranView _view;
        private IPengeluaranServices _services;
        private List<IPengeluaranModel> _listObjs;
        private BindingListView<PengeluaranModel> _bindingView;
        private static string _typeName = "Pengeluaran";

        public IPengeluaranView GetView
        {
            get { return _view; }
        }

        public PengeluaranPresenter()
        {
            _view = new PengeluaranView();
            _services = new PengeluaranServices(new PengeluaranRepository(), new ModelDataAnnotationCheck());

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
                    _listObjs = _services.GetByDate(DateTime.Now.Date).ToList();
                    _bindingView = new BindingListView<PengeluaranModel>(_listObjs);
                    _view.ListDataGrid.DataSource = _bindingView;
                    _bindingView.ListChanged += _bindingView_ListChanged;
                    HitungRingkasan();
                }
            }
        }

        private void _bindingView_ListChanged(object sender, System.ComponentModel.ListChangedEventArgs e)
        {
            HitungRingkasan();
        }

        private void HitungRingkasan()
        {
            _view.LabelTotal.Text = _bindingView.Sum(p => p.total).ToString("N0");
        }

        private void _view_OnCreateData(object sender, EventArgs e)
        {
            var view = new PengeluaranEntryView();
            view.OnSaveData += PengeluaranEntryView_OnSaveData;
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
                    var model = _services.GetById(((PengeluaranModel)listDataGrid.SelectedItem).id);

                    if (model != null)
                    {
                        var view = new PengeluaranEntryView(false, model);
                        view.OnSaveData += PengeluaranEntryView_OnSaveData;
                        view.ShowDialog();
                    }
                }
            }
        }

        private void PengeluaranEntryView_OnSaveData(object sender, EventArgs e)
        {
            using (new WaitCursorHandler())
            {
                try
                {
                    var listDataGrid = _view.ListDataGrid;
                    var newModel = ((ModelEventArgs<PengeluaranModel>)e).Value;
                    var view = ((PengeluaranEntryView)sender);

                    if (newModel.id == default(uint))
                    {
                        newModel.tanggal = DateTime.Now;
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
                            model.total = newModel.total;
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
                        var model = _services.GetById(((PengeluaranModel)_view.ListDataGrid.SelectedItem).id);

                        _services.Delete(model);
                        Messages.InfoDelete(_typeName);

                        if (_listObjs.Remove((PengeluaranModel)_view.ListDataGrid.SelectedItem))
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
            //_listObjs = _services.GetByDate(DateTime.Now.Date).ToList();
            _bindingView.DataSource = _listObjs;
            _view.LabelTotal.Text = _listObjs.Sum(p => p.total).ToString("N0");
        }

        private void OnDataGrid_CellDoubleClick(object sender, CellClickEventArgs e)
        {
            _view_OnUpdateData(sender, e);
        }
    }
}
