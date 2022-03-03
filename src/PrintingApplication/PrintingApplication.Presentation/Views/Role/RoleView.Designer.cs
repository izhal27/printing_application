namespace PrintingApplication.Presentation.Views.Role
{
   partial class RoleView
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.listDataGrid = new PrintingApplication.Presentation.Views.CommonControls.ListDataGrid();
         this.crudcButtons = new PrintingApplication.Presentation.Views.CommonControls.CRUDCButtons();
         this.grpBoxAction = new System.Windows.Forms.GroupBox();
         this.treeViewAction = new System.Windows.Forms.TreeView();
         this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
         this.buttonUpdate = new System.Windows.Forms.Button();
         this.checkBoxPilihSemua = new System.Windows.Forms.CheckBox();
         this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
         this.label1 = new System.Windows.Forms.Label();
         this.comboBoxMenu = new System.Windows.Forms.ComboBox();
         this.groupBox1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.listDataGrid)).BeginInit();
         this.grpBoxAction.SuspendLayout();
         this.tableLayoutPanel2.SuspendLayout();
         this.tableLayoutPanel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // groupBox1
         // 
         this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.groupBox1.Controls.Add(this.listDataGrid);
         this.groupBox1.Location = new System.Drawing.Point(12, 58);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(254, 351);
         this.groupBox1.TabIndex = 1;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "[ ROLE ]";
         // 
         // listDataGrid
         // 
         this.listDataGrid.AccessibleName = "Table";
         this.listDataGrid.AllowEditing = false;
         this.listDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.listDataGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
         this.listDataGrid.Location = new System.Drawing.Point(6, 19);
         this.listDataGrid.Name = "listDataGrid";
         this.listDataGrid.ShowRowHeader = true;
         this.listDataGrid.Size = new System.Drawing.Size(242, 326);
         this.listDataGrid.TabIndex = 0;
         this.listDataGrid.Text = "listDataGrid1";
         this.listDataGrid.SelectionChanged += new Syncfusion.WinForms.DataGrid.Events.SelectionChangedEventHandler(this.listDataGrid_SelectionChanged);
         // 
         // crudcButtons
         // 
         this.crudcButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.crudcButtons.BackColor = System.Drawing.Color.Transparent;
         this.crudcButtons.Location = new System.Drawing.Point(12, 415);
         this.crudcButtons.Name = "crudcButtons";
         this.crudcButtons.Size = new System.Drawing.Size(760, 35);
         this.crudcButtons.TabIndex = 2;
         // 
         // grpBoxAction
         // 
         this.grpBoxAction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.grpBoxAction.Controls.Add(this.treeViewAction);
         this.grpBoxAction.Controls.Add(this.tableLayoutPanel2);
         this.grpBoxAction.Controls.Add(this.tableLayoutPanel1);
         this.grpBoxAction.Location = new System.Drawing.Point(272, 58);
         this.grpBoxAction.Name = "grpBoxAction";
         this.grpBoxAction.Size = new System.Drawing.Size(500, 351);
         this.grpBoxAction.TabIndex = 3;
         this.grpBoxAction.TabStop = false;
         this.grpBoxAction.Text = "[ ACTION ]";
         // 
         // treeViewAction
         // 
         this.treeViewAction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.treeViewAction.CheckBoxes = true;
         this.treeViewAction.Location = new System.Drawing.Point(6, 55);
         this.treeViewAction.Name = "treeViewAction";
         this.treeViewAction.Size = new System.Drawing.Size(488, 254);
         this.treeViewAction.TabIndex = 1;
         // 
         // tableLayoutPanel2
         // 
         this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.tableLayoutPanel2.ColumnCount = 2;
         this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tableLayoutPanel2.Controls.Add(this.buttonUpdate, 1, 0);
         this.tableLayoutPanel2.Controls.Add(this.checkBoxPilihSemua, 0, 0);
         this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 315);
         this.tableLayoutPanel2.Name = "tableLayoutPanel2";
         this.tableLayoutPanel2.RowCount = 1;
         this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tableLayoutPanel2.Size = new System.Drawing.Size(488, 30);
         this.tableLayoutPanel2.TabIndex = 0;
         // 
         // buttonUpdate
         // 
         this.buttonUpdate.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.buttonUpdate.Location = new System.Drawing.Point(90, 3);
         this.buttonUpdate.Name = "buttonUpdate";
         this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
         this.buttonUpdate.TabIndex = 0;
         this.buttonUpdate.Tag = "Update";
         this.buttonUpdate.Text = "Update";
         this.buttonUpdate.UseVisualStyleBackColor = true;
         this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
         // 
         // checkBoxPilihSemua
         // 
         this.checkBoxPilihSemua.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.checkBoxPilihSemua.AutoSize = true;
         this.checkBoxPilihSemua.Location = new System.Drawing.Point(3, 6);
         this.checkBoxPilihSemua.Name = "checkBoxPilihSemua";
         this.checkBoxPilihSemua.Size = new System.Drawing.Size(81, 17);
         this.checkBoxPilihSemua.TabIndex = 1;
         this.checkBoxPilihSemua.Text = "Pilih Semua";
         this.checkBoxPilihSemua.UseVisualStyleBackColor = true;
         this.checkBoxPilihSemua.CheckedChanged += new System.EventHandler(this.checkBoxPilihSemua_CheckedChanged);
         // 
         // tableLayoutPanel1
         // 
         this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.tableLayoutPanel1.ColumnCount = 2;
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
         this.tableLayoutPanel1.Controls.Add(this.comboBoxMenu, 1, 0);
         this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
         this.tableLayoutPanel1.Name = "tableLayoutPanel1";
         this.tableLayoutPanel1.RowCount = 1;
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tableLayoutPanel1.Size = new System.Drawing.Size(488, 30);
         this.tableLayoutPanel1.TabIndex = 0;
         // 
         // label1
         // 
         this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(3, 8);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(34, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "Menu";
         // 
         // comboBoxMenu
         // 
         this.comboBoxMenu.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.comboBoxMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.comboBoxMenu.FormattingEnabled = true;
         this.comboBoxMenu.Location = new System.Drawing.Point(43, 4);
         this.comboBoxMenu.Name = "comboBoxMenu";
         this.comboBoxMenu.Size = new System.Drawing.Size(150, 21);
         this.comboBoxMenu.TabIndex = 1;
         this.comboBoxMenu.SelectedIndexChanged += new System.EventHandler(this.comboBoxMenu_SelectedIndexChanged);
         // 
         // RoleView
         // 
         this.AccessibleName = "Master";
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(784, 462);
         this.Controls.Add(this.grpBoxAction);
         this.Controls.Add(this.crudcButtons);
         this.Controls.Add(this.groupBox1);
         this.Name = "RoleView";
         this.Text = "Role";
         this.Load += new System.EventHandler(this.RoleView_Load);
         this.Controls.SetChildIndex(this.panelUp, 0);
         this.Controls.SetChildIndex(this.groupBox1, 0);
         this.Controls.SetChildIndex(this.crudcButtons, 0);
         this.Controls.SetChildIndex(this.grpBoxAction, 0);
         this.groupBox1.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.listDataGrid)).EndInit();
         this.grpBoxAction.ResumeLayout(false);
         this.tableLayoutPanel2.ResumeLayout(false);
         this.tableLayoutPanel2.PerformLayout();
         this.tableLayoutPanel1.ResumeLayout(false);
         this.tableLayoutPanel1.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox groupBox1;
      private CommonControls.CRUDCButtons crudcButtons;
      private System.Windows.Forms.GroupBox grpBoxAction;
      private System.Windows.Forms.TreeView treeViewAction;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
      private System.Windows.Forms.Button buttonUpdate;
      private System.Windows.Forms.CheckBox checkBoxPilihSemua;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.ComboBox comboBoxMenu;
      private CommonControls.ListDataGrid listDataGrid;
   }
}