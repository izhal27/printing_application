using PrintingApplication.Domain.Models.Role;
using PrintingApplication.Infrastructure.DataAccess.Repositories.Role;
using PrintingApplication.Services.Services;
using PrintingApplication.Services.Services.Role;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace PrintingApplication.Presentation.Helper
{
    public class RoleManager
    {

        #region >> Fields <<

        private IRoleServices _roleServices;
        private IFormActionServices _formActionServices;
        // Untuk trace tiap2 property di object FormActionModel
        private int _colActNo = 0;

        #endregion

        // ----------------------------------------------------------------------//

        #region >> Properties <<

        public static string RoleKode { private get; set; }
        public static MenuStrip MenuStrip { private get; set; }
        public static ToolStrip ToolStrip { private get; set; }
        public TreeView TreeView { private get; set; }

        #endregion

        // ----------------------------------------------------------------------//

        #region >> Constructor <<

        public RoleManager()
        {
            _roleServices = new RoleServices(new RoleRepository(), new ModelDataAnnotationCheck());
            _formActionServices = new FormActionServices(new FormActionRepository(), new ModelDataAnnotationCheck());
        }

        #endregion

        // ----------------------------------------------------------------------//

        #region >> Reset form_action and role_detail <<

        /// <summary>
        /// Method yang digunakan untuk mereset tabel form_action dan role_detail
        /// </summary>
        /// <param name="assembly">Assembly aplikasi</param>
        public void ResetFormAction(Assembly assembly)
        {
            try
            {
                if (MenuStrip == null)
                {
                    throw new NullReferenceException("Anda tidak mempunyai MenuStrip untuk dimapping ke tabel role_detail");
                }

                if (MenuStrip != null)
                {
                    _formActionServices.DeleteAll();
                    _roleServices.DeleteAllRoleDetail();
                    GetTypeFromAssembly(assembly);

                    PopulateMenuStrip(MenuStrip.Items);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        /// <summary>
        /// Ambil semua Type form di Assembly
        /// </summary>
        /// <param name="assembly">Assembly aplikasi</param>
        private void GetTypeFromAssembly(Assembly assembly)
        {
            // Ambil semua object di assembly yang bertipe class dan WindowsForm,
            // dan form yang tidak mengandung nama Main atau Base
            var formTypes = assembly.GetTypes().Where(t => t.IsClass && (t.BaseType.Name.Contains("View") &&
                            !(t.Name.Contains("Main") || t.Name.Contains("Entry") || t.Name.Contains("Base"))));

            // Looping semua Form di list formTypes
            foreach (var type in formTypes)
            {
                // Buat instance Form dari Type Form tersebut
                Form form = (Form)Activator.CreateInstance(type);

                // Lewati jika Form mempunyai Tag ignore
                if (form.TagIgnore()) continue;

                PopulateButtonFormToFormAction(form);
            }
        }

        /// <summary>
        /// Isi Button action yang ada di Form ke tabel form_action
        /// </summary>
        /// <param name="form">Form target</param>
        private void PopulateButtonFormToFormAction(Form form)
        {
            // Buat object FormAction dari Form tersebut
            var formAction = new FormActionModel();
            formAction.form_name = form.Name;
            formAction.form_text = form.Text;

            // Looping setiap Control yang bertipe Button pada Form
            foreach (Control ctrl in form.Controls)
            {
                PopulateButtonToRoleDetail(form, formAction, ctrl);
            }

            // Reset nilai kolom act dan dispose object Form
            _colActNo = 0;
            form.Dispose();

            // Simpan data Form ke tabel form_action
            _formActionServices.Insert(formAction);
        }

        /// <summary>
        /// Isi setiap Button yang ada di Form ke tabel role_detail
        /// </summary>
        /// <param name="form">Form target</param>
        /// <param name="formAction">FormActionModel object</param>
        /// <param name="control">Control target</param>
        private void PopulateButtonToRoleDetail(Form form, FormActionModel formAction, Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                // Kita hanya ingin memilih Control Button saja
                if (ctrl is Button)
                {
                    var button = (Button)ctrl;

                    // Lewati Button yang mempunyai Tag ignore
                    if (button.TagIgnore()) continue;

                    // Ambil menu_name dari Tag Button jika tersedia, sebaliknya ambil dari Text Button
                    string buttonText = button.Tag != null ? button.Tag.ToString() : button.Text;

                    // Tambahkan ke kolom act baru jika Button ditemukan
                    _colActNo += 1;
                    string colActName = $"act_{_colActNo}"; // Nama property

                    // Atur property berdasarkan nama dari property
                    // cari property berdasarkan nama (contoh act_1)
                    // lalu isi value property tersebut berdasarkan tag / text dari Button
                    var propertyInfo = formAction.GetType().GetProperty(colActName);
                    propertyInfo.SetValue(formAction, Convert.ChangeType(buttonText, propertyInfo.PropertyType), null);

                    // Buat RoleDetail object
                    var roleDetail = new RoleDetailModel()
                    {
                        role_kode = RoleKode,
                        menu_name = buttonText,
                        menu_parent = form.AccessibleName, // Menu header (parent) di MenuStrip
                        form_action = form.Name,
                        tag = "action"
                    };

                    // Simpan data Button ke tabel role_detail
                    _roleServices.Insert(roleDetail);
                }

                PopulateButtonToRoleDetail(form, formAction, ctrl); // Recursive method
            }
        }

        /// <summary>
        /// Isi data dari setiap menu di MenuStrip ke tabel role_detail
        /// </summary>
        /// <param name="toolStripItemCollection">ToolStripItemCollection MenuStrip</param>
        private void PopulateMenuStrip(ToolStripItemCollection toolStripItemCollection)
        {
            foreach (var menu in toolStripItemCollection)
            {
                // Lewati menu jika bukan MenuItem (bisa saja Separator atau ComboBox)
                if (!(menu is ToolStripMenuItem)) continue;

                var menuItem = (ToolStripMenuItem)menu;

                // Lewati Menu yang mempunyai Tag ignore
                if (menuItem.TagIgnore()) continue;

                var roleDetail = new RoleDetailModel()
                {
                    role_kode = RoleKode,
                    menu_name = menuItem.Tag.ToString(),
                    menu_parent = menuItem.AccessibleDescription, // Menu header (parent) di MenuStrip
                    form_action = null,
                    tag = menuItem.AccessibleName
                };

                // Simpan data Menu ke tabel role_detail
                _roleServices.Insert(roleDetail);

                PopulateMenuStrip(menuItem.DropDownItems); // Recursive method
            }
        }

        #endregion

        // ----------------------------------------------------------------------//

        #region >> Populate TreeView <<

        /// <summary>
        /// DataSource Menu (parent/header) di MenuStrip
        /// </summary>
        /// <returns>Menbemalikan nilai List KeyValuePair</returns>
        public List<KeyValuePair<object, string>> DataSourceMenuParent()
        {
            return MenuStrip.Items.Cast<ToolStripDropDownItem>().Where(m => !m.TagIgnore()).ToList()
               .Select(m => new KeyValuePair<object, string>(m.Tag.ToString(), m.Tag.ToString())).ToList();
        }

        /// <summary>
        /// Method yang digunakan untuk mengisi setiap data Menu di MenuStrip ke TreeView
        /// </summary>
        /// <param name="menuParent">Menu (parent/header) terpilih</param>
        public void PopulateMenuStripToTreeView(string menuParent)
        {
            if (MenuStrip == null)
            {
                throw new NullReferenceException("Anda tidak mempunyai MenuStrip untuk dimapping ke TreeView");
            }

            if (TreeView == null)
            {
                throw new NullReferenceException("Anda tidak mempunyai TreeView untuk menampilkan data Role detail");
            }

            // Hapus semua node pada TreeView jika TreeView tersebut terdapat node
            if (TreeView.Nodes != null) TreeView.Nodes.Clear();

            // Ambil semua data pada tabel form_action
            var listFormAction = _formActionServices.GetAll().ToList();

            // Looping setiap menu pada MenuStrip
            foreach (ToolStripDropDownItem item in MenuStrip.Items)
            {
                if (item.Tag != null)
                {
                    // Lewati setiap menu yang mempunyai Tag ignore atau
                    // Tag menu tidak sama dengan menu parent terpilih
                    if (item.TagIgnore() || !menuParent.Equals(item.Tag.ToString()))
                        continue;

                    // Buat node baru sebagai node root/parent utk ditambahkan ke treeview
                    TreeNode node = new TreeNode(item.Tag.ToString());
                    // Tambahkan object NodeTag ke Tag node parent
                    node.Tag = new NodeTag()
                    {
                        FormAction = "",
                        Tag = "menu",
                        MenuParent = ""
                    };

                    TreeView.Nodes.Add(node);

                    // Tambahkan node baru ke TreeView jika
                    // node tersebut memiliki node child (DropDownItem):
                    AddMenuToTree(listFormAction, node, item);
                }
            }

            TreeView.ExpandAll();
            TreeView.SelectedNode = TreeView.Nodes[0];
        }

        /// <summary>
        /// Tambahkan node child dari Menu parent
        /// </summary>
        /// <param name="listFormAction">Data FormActionModel</param>
        /// <param name="treeNode">Node parent</param>
        /// <param name="toolStripMenuItem">Menu item parent</param>
        private void AddMenuToTree(List<IFormActionModel> listFormAction, TreeNode treeNode
           , ToolStripDropDownItem toolStripMenuItem)
        {
            // Cek apakah toolStripMenuItem mempunyai sub MenuItem
            // yang merupakan DropDownItem
            if (toolStripMenuItem.DropDownItems.Count > 0)
            {
                foreach (var item in toolStripMenuItem.DropDownItems)
                {
                    // Lewati jika sub MenuItem bukan merupakan toolstripmenuitem (bisa saja ToolStripSeparator)
                    if (!(item is ToolStripMenuItem)) continue;

                    var menuItem = (ToolStripMenuItem)item;

                    // Lewati jika sub MenuItem mempunyai Tag ignore
                    if (menuItem.TagIgnore()) continue;

                    // Buat node child menu / sub menu / menuForm
                    var node = new TreeNode(menuItem.Text.Replace("&", ""));
                    // Tambahkan object NodeTag ke Tag node child
                    node.Tag = new NodeTag()
                    {
                        FormAction = menuItem.Tag.ToString(), // Form name
                        Tag = menuItem.AccessibleName, // menu / menuForm
                        MenuParent = menuItem.AccessibleDescription // Menu header (parent) di MenuStrip
                    };

                    // Tambahkan node child ke node parent
                    treeNode.Nodes.Add(node);

                    // Cek jika ada sub menu item lagi dengan recursive method
                    AddMenuToTree(listFormAction, node, menuItem);

                    // Tambahkan node action(node untuk Button) ke node terakhir
                    // yang merupakan menu form (menu yang memanggil form)
                    // Cek jika terdapat value pada AccessibleName
                    if (!string.IsNullOrWhiteSpace(menuItem.AccessibleName))
                    {
                        var accsName = menuItem.AccessibleName;

                        if (accsName.Equals("menuForm")) // Menu yang memanggil Form
                        {
                            // Cek jika nama form terdapat pada listFormAction,
                            var formAction = listFormAction.Where(fa => fa.form_name.Equals(menuItem.Tag.ToString())).FirstOrDefault();

                            if (formAction != null)
                            {
                                // Looping setiap property di object FormActionModel
                                foreach (var prop in formAction.GetType().GetProperties())
                                {
                                    // Tidak termasuk kolom form_name dan form_text
                                    if (prop.Name.Equals("form_name") || prop.Name.Equals("form_text")) continue;

                                    // Lewati property yang tidak memilike value
                                    if (prop.GetValue(formAction, null) == null) continue;

                                    // Buat node (button) action
                                    var actionNode = new TreeNode(prop.GetValue(formAction, null).ToString());
                                    // Tambahkan object NodeTag pada Tag node (button) action
                                    actionNode.Tag = new NodeTag()
                                    {
                                        FormAction = menuItem.Tag.ToString(), // Form name
                                        Tag = "action",
                                        MenuParent = menuItem.AccessibleDescription // Menu header (parent) di MenuStrip
                                    };

                                    node.Text = formAction.form_text; // Node  menuForm text sesuai Form name
                                                                      // Tambahkan object NodeTag pada Tag node Form
                                    node.Tag = new NodeTag()
                                    {
                                        FormAction = menuItem.Tag.ToString(), // Form name
                                        Tag = menuItem.AccessibleName, // menuForm
                                        MenuParent = menuItem.AccessibleDescription // Menu header (parent) di MenuStrip
                                    };

                                    // Tambahkan node (button) action ke node Form
                                    node.Nodes.Add(actionNode);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Centang node pada TreeView sesuai dengan Role kode yang diambil dari tabel role_detail
        /// </summary>
        /// <param name="roleKode">Role kode</param>
        /// <param name="menuParent">Menu (parent/header) terpilih</param>
        public void PopulateRoleDetailToTreeView(string roleKode, string menuParent)
        {
            // Ambil data role_detail sesuai dengan role kode dan menu (parent/header) terpilih
            var listRoleDetail = _roleServices.GetByMenuParent(roleKode, menuParent).ToList();

            if (listRoleDetail.Count == 0) // Data tidak ada/tidak ditemukan role kode pada tabel role_detail
            {
                foreach (TreeNode node in TreeView.Nodes)
                {
                    node.Checked = false;

                    ClearChecked(node.Nodes);
                }
            }
            else
            {
                PopulateItemChecked(listRoleDetail, TreeView.Nodes);
            }
        }

        /// <summary>
        /// Method yang digunakkan untuk membersihkan centang pada node TreeView
        /// </summary>
        /// <param name="nodes">TreeNodeCollection TreeView</param>
        private void ClearChecked(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                node.Checked = false;

                ClearChecked(node.Nodes); // Recursive method
            }
        }

        /// <summary>
        /// Method yang digunakan untuk mencetang node sesuai data yang ada pada tabel role_detail
        /// </summary>
        /// <param name="listRoleDetail">Data RoleDetail</param>
        /// <param name="nodes">TreeNodeCollection TreeView</param>
        private void PopulateItemChecked(List<IRoleDetailModel> listRoleDetail, TreeNodeCollection nodes)
        {
            // Looping semua node pada TreeNodeCollection TreeView
            foreach (TreeNode node in nodes)
            {
                var nodeTag = (NodeTag)node.Tag; // Buat object NodeTag dari Tag pada node
                bool status = false; // Status checked

                switch (nodeTag.Tag)
                {
                    case "menu":

                        // Cari berdasarkan menu_name
                        status = listRoleDetail.Any(rd => rd.menu_name.Equals(node.Text));

                        break;
                    case "menuForm":

                        // Cari berdasarkan form_action
                        status = listRoleDetail.Any(rd => rd.menu_name.Equals(nodeTag.FormAction));

                        break;
                    case "action":

                        // Cari berdasarkan menu_name dan form_action
                        status = listRoleDetail.Any(rd => rd.menu_name.Equals(node.Text) && rd.form_action.Equals(nodeTag.FormAction));

                        break;
                }

                node.Checked = status; // True jika ditemukan pada list role detail

                PopulateItemChecked(listRoleDetail, node.Nodes); // Recursive method
            }
        }

        #endregion

        // ----------------------------------------------------------------------//

        #region >> Update Role <<

        /// <summary>
        /// Method yang digunakkan untuk mengupdate data role pada tabel role_detail
        /// sesuai dengan node yang tercentang pada TreeView
        /// </summary>
        /// <param name="roleKode">Role kode</param>
        /// <param name="menuParent">Menu (parent/header) terpilih</param>
        public void UpdateRole(string roleKode, string menuParent)
        {
            // Buat object RoleDetail yang ingin di update
            var roleDetail = new RoleDetailModel()
            {
                role_kode = roleKode,
                menu_name = null,
                menu_parent = menuParent, // Menu header (parent) di MenuStrip
                form_action = null,
                tag = null
            };

            // Hapus semua data sesuai role kode dan menu parent terpilih
            _roleServices.Delete(roleDetail);

            var listRoleDetail = new List<RoleDetailModel>();

            // isi data role detail sesuai node yang di check
            InsertItemChecked(listRoleDetail, roleKode, menuParent, TreeView.Nodes);

            _roleServices.Insert(listRoleDetail);
        }

        /// <summary>
        /// Method yang digunakan untuk menyimpan node yang tercentang ke tabel role_detail
        /// </summary>
        /// <param name="listRoleDetail">Data RoleDetail</param>
        /// <param name="roleKode">Role kode</param>
        /// <param name="menuParent">Menu (parent/header) terpilih</param>
        /// <param name="nodes">TreeNodeCollection TreeView</param>
        private void InsertItemChecked(List<RoleDetailModel> listRoleDetail, string roleKode
           , string menuParent, TreeNodeCollection nodes)
        {
            // Looping node di TreeView
            foreach (TreeNode node in nodes)
            {
                // Hanya menyimpan node yang tercentang
                if (node.Checked)
                {
                    // Buat instance object NodeTag dari Tag pada node
                    var nodeTag = (NodeTag)node.Tag;

                    var roleDetail = new RoleDetailModel();
                    roleDetail.role_kode = roleKode;
                    roleDetail.tag = nodeTag.Tag; // menu / menuForm / action
                    roleDetail.menu_parent = menuParent; // Menu header (parent) di MenuStrip

                    switch (roleDetail.tag)
                    {
                        case "menu":

                            roleDetail.menu_name = node.Text; // Menu tag
                            roleDetail.form_action = null;

                            break;
                        case "menuForm":

                            roleDetail.menu_name = nodeTag.FormAction; // Form name
                            roleDetail.form_action = null;

                            break;
                        case "action":

                            roleDetail.menu_name = node.Text; // Button Tag/Text
                            roleDetail.form_action = nodeTag.FormAction; // Form name

                            break;
                    }

                    // Tambahkan object RoleDetail ke list
                    listRoleDetail.Add(roleDetail);
                }

                InsertItemChecked(listRoleDetail, roleKode, menuParent, node.Nodes); // Recursive method
            }
        }

        #endregion

        // ----------------------------------------------------------------------//

        #region >> Enable MenuStrip and ToolStrip <<

        /// <summary>
        /// Method yang digunakan untuk menerapkan Role ke MenuStrip dan ToolStrip
        /// </summary>
        public void PopulateRoleDetailToMenuStripAndToolStrip()
        {
            // Ambil data RoleDetail sesuai dengan Role kode
            var listRoleDetail = _roleServices.GetAllByRoleKode(RoleKode).ToList();

            if (MenuStrip != null) // Jika MenuStrip tersedia
            {
                // Jika data tidak ditemukan, maka disable semua MenuItem pada MenuStrip,
                // kecuali yang mempunyai Tag ignore  
                if (listRoleDetail.Count == 0)
                {
                    foreach (ToolStripMenuItem menu in MenuStrip.Items)
                    {
                        menu.Enabled = menu.TagIgnore(); // True jika mempunyai Tag ignore
                    }
                }
                else
                {
                    EnableMenuStripItem(listRoleDetail, MenuStrip.Items);
                }
            }

            if (ToolStrip != null) // Jika ToolStrip tersedia
            {
                // Jika data tidak ditemukan, maka disable semua ToolStripItem,
                // kecuali yang mempunyai Tag ignore  
                if (listRoleDetail.Count == 0)
                {
                    foreach (var item in ToolStrip.Items)
                    {
                        if (item is ToolStripButton)
                        {
                            var button = (ToolStripButton)item;

                            button.Enabled = item.TagIgnore(); // True jika mempunyai Tag ignore
                        }

                        if (item is ToolStripDropDownButton)
                        {
                            var dropDownButton = (ToolStripDropDownButton)item;

                            dropDownButton.Enabled = item.TagIgnore(); // True jika mempunyai Tag ignore

                            DisableToolStripItem(dropDownButton.DropDownItems);
                        }
                    }
                }
                else
                {
                    EnableToolStripItem(listRoleDetail, ToolStrip);
                }
            }
        }

        /// <summary>
        /// Method yang digunakan untuk Enable/Disable Menu pada MenuStrip
        /// </summary>
        /// <param name="listRoleDetail">Data RoleDetail</param>
        /// <param name="items">ToolStripItemCollection MenuStrip</param>
        private void EnableMenuStripItem(List<IRoleDetailModel> listRoleDetail, ToolStripItemCollection items)
        {
            foreach (var menu in items)
            {
                // Lewati jika bukan MenuItem
                if (!(menu is ToolStripMenuItem)) continue;

                var menuItem = (ToolStripMenuItem)menu;

                // Lewati jika Menu mempunyai Tag ignore
                if (menuItem.TagIgnore()) continue;

                // Cek jika Menu terdapat pada list RoleDetail
                var status = listRoleDetail.Any(rd => rd.menu_name.Equals(menuItem.Tag.ToString()) &&
                             rd.menu_parent.Equals(menuItem.AccessibleDescription));

                menuItem.Enabled = status; // True jika ditemukan pada list role detail

                EnableMenuStripItem(listRoleDetail, menuItem.DropDownItems); // Recursive method
            }
        }

        /// <summary>
        /// Method yang digunakan untuk Enable/Disable ToolStripItem pada ToolStrip
        /// </summary>
        /// <param name="listRoleDetail">Data RoleDetail</param>
        /// <param name="toolStrip">ToolStrip target</param>
        private void EnableToolStripItem(List<IRoleDetailModel> listRoleDetail, ToolStrip toolStrip)
        {
            foreach (var item in toolStrip.Items)
            {
                if (item is ToolStripButton)
                {
                    var button = (ToolStripButton)item;

                    // Lewati jika ToolStripButton mempunyai Tag ignore
                    if (button.TagIgnore()) continue;

                    // Cek jika ToolStripButton terdapat pada list RoleDetail
                    var status = listRoleDetail.Any(rd => rd.menu_name.Equals(button.Tag.ToString()));

                    button.Enabled = status; // True jika ditemukan pada list role detail
                }

                if (item is ToolStripDropDownButton)
                {
                    var dropDownButton = (ToolStripDropDownButton)item;

                    // Lewati jika ToolStripDropDownButton mempunyai Tag ignore
                    if (dropDownButton.TagIgnore()) continue;

                    // Cek jika ToolStripDropDownButton terdapat pada list RoleDetail
                    var status = listRoleDetail.Any(rd => rd.menu_name.Equals(dropDownButton.Tag.ToString()));

                    if (!status) // Lewati jika ToolStripDropDownButton tidak ditemukan
                    {
                        dropDownButton.Enabled = status; // false
                        continue;
                    }

                    EnableToolStripMenuItem(listRoleDetail, dropDownButton.DropDownItems); // Recursive method
                }
            }
        }

        /// <summary>
        /// Recursive method untuk Enable/Disable ToolStripItem pada ToolStrip
        /// </summary>
        /// <param name="listRoleDetail">Data RoleDetail</param>
        /// <param name="items">ToolStripItemCollection ToolStrip</param>
        private void EnableToolStripMenuItem(List<IRoleDetailModel> listRoleDetail, ToolStripItemCollection items)
        {
            foreach (var item in items)
            {
                if (item is ToolStripMenuItem)
                {
                    var menuItem = (ToolStripMenuItem)item;

                    // Lewati jika ToolStripMenuItem mempunyai Tag ignore
                    if (menuItem.TagIgnore()) continue;

                    // Cek jika ToolStripMenuItem terdapat pada list RoleDetail
                    var status = listRoleDetail.Any(rd => rd.menu_name.Equals(menuItem.Tag.ToString()));

                    if (!status) // Lewati jika ToolStripMenuItem tidak ditemukan
                    {
                        menuItem.Enabled = status; // false
                        continue;
                    }

                    EnableToolStripMenuItem(listRoleDetail, menuItem.DropDownItems); // Recursive method
                }
            }
        }

        /// <summary>
        /// Method yang digunakan untuk Mendisable ToolStripItem pada ToolStrip
        /// </summary>
        /// <param name="items">ToolStripItemCollection ToolStrip</param>
        private void DisableToolStripItem(ToolStripItemCollection items)
        {
            foreach (var item in items)
            {
                if (item is ToolStripButton)
                {
                    var button = (ToolStripButton)item;

                    button.Enabled = button.TagIgnore(); // True jika mempunyai Tag ignore
                }

                if (item is ToolStripDropDownButton)
                {
                    var dropDownButton = (ToolStripDropDownButton)item;

                    dropDownButton.Enabled = dropDownButton.TagIgnore(); // True jika mempunyai Tag ignore

                    DisableToolStripItem(dropDownButton.DropDownItems); // Recursive method
                }
            }
        }

        #endregion

        // ----------------------------------------------------------------------//

        #region >> Action Control/Button <<

        /// <summary>
        /// Enable / disable buttons pada form sesuai dengan data di tabel role_detail
        /// </summary>
        /// <param name="formTarget">Form target</param>
        public void EnableButtons(Control form)
        {
            // Ambil data sesuai Role kode dan Form name
            var actionButtons = _roleServices.GetAllMenuNameByTagAction(RoleKode, form.Name).ToList();

            EnableButtons(form, actionButtons);
        }

        /// <summary>
        /// Enable / disable buttons pada form sesuai dengan data di tabel role_detail
        /// </summary>
        /// <param name="form">Form target</param>
        /// <param name="actionButtons">List action button</param>
        private void EnableButtons(Control form, List<string> actionButtons)
        {
            foreach (Control ctrl in form.Controls)
            {
                if (ctrl is Button)
                {
                    var button = (Button)ctrl;

                    if (button.Tag != null)
                    {
                        if (button.TagIgnore()) continue;

                        // Cek berdasarkan Tag
                        // True jika button tag ditemukan pada list action,
                        // sebaliknya false jika tidak ditemukan
                        button.Enabled = actionButtons.Any(a => a.Equals(button.Tag.ToString()));
                    }
                    else
                    {
                        // Cek berdasarkan Button text
                        button.Enabled = actionButtons.Any(a => a.Equals(button.Text));
                    }
                }

                EnableButtons(ctrl, actionButtons);
            }
        }

        #endregion

    }

    /// <summary>
    /// Class yang digunakan untuk mapping informasi role_detail ke Tag Node di TreeView
    /// </summary>
    public class NodeTag
    {
        public string MenuParent { get; set; }
        public string FormAction { get; set; }
        public string Tag { get; set; }
    }

}
