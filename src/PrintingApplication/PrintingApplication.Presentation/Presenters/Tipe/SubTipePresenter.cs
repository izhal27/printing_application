using Equin.ApplicationFramework;
using PrintingApplication.CommonComponents;
using PrintingApplication.Presentation.Helper;
using PrintingApplication.Presentation.Views.CommonControls;
using PrintingApplication.Services.Services;
using Syncfusion.WinForms.DataGrid.Events;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintingApplication.Presentation.Presenters.JenisOrderan
{
    public class SubTipePresenter : ISubTipePresenter
    {
        private ISubTipeView _view;
        private ISubTipeServices _services;
        private List<ISubTipeModel> _listObjs;
        private BindingListView<SubTipeModel> _bindingView;
        private static string _typeName = "Sub Tipe";

        public ISubTipeView GetView
        {
            get { return _view; }
        }

        public SubTipePresenter()
        {
            _services = new SubTipeServices(new SubTipeRepository(), new ModelDataAnnotationCheck());
            _view = new SubTipeView();

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
                    _bindingView = new BindingListView<SubTipeModel>(_listObjs);
                    _view.ListDataGrid.DataSource = _bindingView;
                }
            }
        }

        private void _view_OnCreateData(object sender, EventArgs e)
        {
            var view = new SubTipeEntryView();
            view.OnSaveData += SubTipeEntryView_OnSaveData;
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
                    var model = _services.GetById(((SubTipeModel)listDataGrid.SelectedItem).id);

                    if (model != null)
                    {
                        var view = new SubTipeEntryView(false, model);
                        view.OnSaveData += SubTipeEntryView_OnSaveData;
                        view.ShowDialog();
                    }
                }
            }
        }

        private void SubTipeEntryView_OnSaveData(object sender, EventArgs e)
        {
            using (new WaitCursorHandler())
            {
                try
                {
                    var listDataGrid = _view.ListDataGrid;
                    var newModel = ((ModelEventArgs<SubTipeModel>)e).Value;
                    var view = ((SubTipeEntryView)sender);

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
                        var model = _services.GetById(((SubTipeModel)_view.ListDataGrid.SelectedItem).id);

                        _services.Delete(model);
                        Messages.InfoDelete(_typeName);

                        if (_listObjs.Remove((SubTipeModel)_view.ListDataGrid.SelectedItem))
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
