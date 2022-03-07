namespace PrintingApplication.Presentation.Views.Orderan
{
   partial class OrderanView
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxNoNota = new PrintingApplication.Presentation.Views.CommonControls.BaseTextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.listDataGrid = new PrintingApplication.Presentation.Views.CommonControls.ListDataGrid();
            this.panelInfoDigital = new PrintingApplication.Presentation.Views.CommonControls.PanelInfoDigital();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCari = new System.Windows.Forms.Button();
            this.buttonClearData = new System.Windows.Forms.Button();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.buttonBayar = new System.Windows.Forms.Button();
            this.buttonTutup = new System.Windows.Forms.Button();
            this.buttonCetakNota = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxNoNota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listDataGrid)).BeginInit();
            this.tlpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 55);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[ DATA ]";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.textBoxNoNota, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label27, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label28, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(246, 30);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBoxNoNota
            // 
            this.textBoxNoNota.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxNoNota.BeforeTouchSize = new System.Drawing.Size(148, 20);
            this.textBoxNoNota.Location = new System.Drawing.Point(72, 5);
            this.textBoxNoNota.Name = "textBoxNoNota";
            this.textBoxNoNota.ReadOnly = true;
            this.textBoxNoNota.Size = new System.Drawing.Size(148, 20);
            this.textBoxNoNota.TabIndex = 10;
            this.textBoxNoNota.TabStop = false;
            this.textBoxNoNota.ThemeName = "Default";
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(3, 8);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(47, 13);
            this.label27.TabIndex = 0;
            this.label27.Text = "No Nota";
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(56, 8);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(10, 13);
            this.label28.TabIndex = 0;
            this.label28.Text = ":";
            // 
            // listDataGrid
            // 
            this.listDataGrid.AccessibleName = "Table";
            this.listDataGrid.AllowEditing = false;
            this.listDataGrid.AllowResizingColumns = true;
            this.listDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listDataGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.listDataGrid.Location = new System.Drawing.Point(12, 119);
            this.listDataGrid.Name = "listDataGrid";
            this.listDataGrid.ShowRowHeader = true;
            this.listDataGrid.Size = new System.Drawing.Size(760, 290);
            this.listDataGrid.TabIndex = 1;
            this.listDataGrid.Text = "listDataGrid1";
            // 
            // panelInfoDigital
            // 
            this.panelInfoDigital.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInfoDigital.BackColor = System.Drawing.Color.Black;
            this.panelInfoDigital.Location = new System.Drawing.Point(372, 58);
            this.panelInfoDigital.Name = "panelInfoDigital";
            this.panelInfoDigital.Size = new System.Drawing.Size(400, 55);
            this.panelInfoDigital.TabIndex = 9;
            // 
            // tlpButtons
            // 
            this.tlpButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpButtons.BackColor = System.Drawing.SystemColors.Control;
            this.tlpButtons.ColumnCount = 6;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpButtons.Controls.Add(this.buttonCari, 0, 0);
            this.tlpButtons.Controls.Add(this.buttonClearData, 3, 0);
            this.tlpButtons.Controls.Add(this.buttonHapus, 1, 0);
            this.tlpButtons.Controls.Add(this.buttonBayar, 2, 0);
            this.tlpButtons.Controls.Add(this.buttonTutup, 5, 0);
            this.tlpButtons.Controls.Add(this.buttonCetakNota, 4, 0);
            this.tlpButtons.Location = new System.Drawing.Point(12, 415);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 1;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.Size = new System.Drawing.Size(760, 35);
            this.tlpButtons.TabIndex = 10;
            // 
            // buttonCari
            // 
            this.buttonCari.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonCari.Location = new System.Drawing.Point(3, 6);
            this.buttonCari.Name = "buttonCari";
            this.buttonCari.Size = new System.Drawing.Size(75, 23);
            this.buttonCari.TabIndex = 95;
            this.buttonCari.Tag = "ignore";
            this.buttonCari.Text = "(F2) &Tambah";
            this.buttonCari.UseVisualStyleBackColor = true;
            this.buttonCari.Click += new System.EventHandler(this.buttonCari_Click);
            // 
            // buttonClearData
            // 
            this.buttonClearData.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonClearData.Location = new System.Drawing.Point(246, 6);
            this.buttonClearData.Name = "buttonClearData";
            this.buttonClearData.Size = new System.Drawing.Size(100, 23);
            this.buttonClearData.TabIndex = 98;
            this.buttonClearData.Tag = "ignore";
            this.buttonClearData.Text = "(F5) &Clear Data";
            this.buttonClearData.UseVisualStyleBackColor = true;
            this.buttonClearData.Click += new System.EventHandler(this.buttonClearData_Click);
            // 
            // buttonHapus
            // 
            this.buttonHapus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonHapus.Location = new System.Drawing.Point(84, 6);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(75, 23);
            this.buttonHapus.TabIndex = 96;
            this.buttonHapus.Tag = "ignore";
            this.buttonHapus.Text = "(F3) &Hapus";
            this.buttonHapus.UseVisualStyleBackColor = true;
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
            // 
            // buttonBayar
            // 
            this.buttonBayar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonBayar.Location = new System.Drawing.Point(165, 6);
            this.buttonBayar.Name = "buttonBayar";
            this.buttonBayar.Size = new System.Drawing.Size(75, 23);
            this.buttonBayar.TabIndex = 97;
            this.buttonBayar.Tag = "ignore";
            this.buttonBayar.Text = "(F4) &Bayar";
            this.buttonBayar.UseVisualStyleBackColor = true;
            this.buttonBayar.Click += new System.EventHandler(this.buttonBayar_Click);
            // 
            // buttonTutup
            // 
            this.buttonTutup.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonTutup.Location = new System.Drawing.Point(682, 6);
            this.buttonTutup.Name = "buttonTutup";
            this.buttonTutup.Size = new System.Drawing.Size(75, 23);
            this.buttonTutup.TabIndex = 100;
            this.buttonTutup.Tag = "ignore";
            this.buttonTutup.Text = "(F12) Tutu&p";
            this.buttonTutup.UseVisualStyleBackColor = true;
            this.buttonTutup.Click += new System.EventHandler(this.buttonTutup_Click);
            // 
            // buttonCetakNota
            // 
            this.buttonCetakNota.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonCetakNota.Location = new System.Drawing.Point(352, 6);
            this.buttonCetakNota.Name = "buttonCetakNota";
            this.buttonCetakNota.Size = new System.Drawing.Size(100, 23);
            this.buttonCetakNota.TabIndex = 99;
            this.buttonCetakNota.Tag = "ignore";
            this.buttonCetakNota.Text = "(F6) &Cetak Nota";
            this.buttonCetakNota.UseVisualStyleBackColor = true;
            this.buttonCetakNota.Click += new System.EventHandler(this.buttonCetakNota_Click);
            // 
            // OrderanView
            // 
            this.AccessibleName = "Transaksi";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.tlpButtons);
            this.Controls.Add(this.panelInfoDigital);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listDataGrid);
            this.KeyPreview = true;
            this.Name = "OrderanView";
            this.Text = "Orderan Barang";
            this.Load += new System.EventHandler(this.PenjualanView_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PenjualanView_KeyDown);
            this.Controls.SetChildIndex(this.listDataGrid, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.panelUp, 0);
            this.Controls.SetChildIndex(this.panelInfoDigital, 0);
            this.Controls.SetChildIndex(this.tlpButtons, 0);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxNoNota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listDataGrid)).EndInit();
            this.tlpButtons.ResumeLayout(false);
            this.ResumeLayout(false);

      }

      #endregion
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
      private CommonControls.BaseTextBox textBoxNoNota;
      private System.Windows.Forms.Label label27;
      private System.Windows.Forms.Label label28;
      private CommonControls.ListDataGrid listDataGrid;
      private CommonControls.PanelInfoDigital panelInfoDigital;
      protected System.Windows.Forms.TableLayoutPanel tlpButtons;
      protected System.Windows.Forms.Button buttonCari;
      protected System.Windows.Forms.Button buttonClearData;
      protected System.Windows.Forms.Button buttonHapus;
      protected System.Windows.Forms.Button buttonBayar;
      protected System.Windows.Forms.Button buttonTutup;
      protected System.Windows.Forms.Button buttonCetakNota;
   }
}