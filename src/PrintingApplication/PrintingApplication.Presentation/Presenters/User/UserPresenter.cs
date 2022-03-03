using Equin.ApplicationFramework;
using PrintingApplication.CommonComponents;
using PrintingApplication.Domain.Models.User;
using PrintingApplication.Infrastructure.DataAccess.Repositories.User;
using PrintingApplication.Presentation.Helper;
using PrintingApplication.Presentation.Views.CommonControls;
using PrintingApplication.Presentation.Views.User;
using PrintingApplication.Services.Services;
using PrintingApplication.Services.Services.User;
using Syncfusion.WinForms.DataGrid.Events;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintingApplication.Presentation.Presenters.User
{
    public class UserPresenter : IUserPresenter
    {
        private IUserView _view;
        private IUserServices _services;
        private List<IUserModel> _listObjs;
        private BindingListView<UserModel> _bindingView;
        private static string _typeName = "User";

        public IUserView GetView
        {
            get { return _view; }
        }

        public UserPresenter()
        {
            _view = new UserView();
            _services = new UserServices(new UserRepository(), new ModelDataAnnotationCheck());

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
                    _bindingView = new BindingListView<UserModel>(_listObjs);
                    _view.ListDataGrid.DataSource = _bindingView;
                }
            }
        }

        private void _view_OnCreateData(object sender, EventArgs e)
        {
            var view = new UserEntryView();
            view.OnSaveData += UserEntryView_OnSaveData;
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
                    var model = _services.GetById(((UserModel)listDataGrid.SelectedItem).id);

                    if (model != null)
                    {
                        var view = new UserEntryView(false, model);
                        view.OnSaveData += UserEntryView_OnSaveData;
                        view.ShowDialog();
                    }
                }
            }
        }

        private void UserEntryView_OnSaveData(object sender, EventArgs e)
        {
            using (new WaitCursorHandler())
            {
                try
                {
                    var listDataGrid = _view.ListDataGrid;
                    var newModel = ((ModelEventArgs<UserModel>)e).Value;
                    var view = ((UserEntryView)sender);

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
                            model.login_id = newModel.login_id;
                            model.Role = newModel.Role;

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
                        var model = _services.GetById(((UserModel)_view.ListDataGrid.SelectedItem).id);

                        _services.Delete(model);
                        Messages.InfoDelete(_typeName);

                        if (_listObjs.Remove((UserModel)_view.ListDataGrid.SelectedItem))
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
