namespace PrintingApplication.Presentation.Views.CommonControls
{
   partial class DetailView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailView));
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.buttonTutup = new System.Windows.Forms.Button();
            this.buttonCetak = new System.Windows.Forms.Button();
            this.listDataGrid = new PrintingApplication.Presentation.Views.CommonControls.ListDataGrid();
            this.tlpButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpButtons
            // 
            this.tlpButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpButtons.BackColor = System.Drawing.SystemColors.Control;
            this.tlpButtons.ColumnCount = 2;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 679F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpButtons.Controls.Add(this.buttonTutup, 1, 0);
            this.tlpButtons.Controls.Add(this.buttonCetak, 0, 0);
            this.tlpButtons.Location = new System.Drawing.Point(8, 415);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 1;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.Size = new System.Drawing.Size(760, 35);
            this.tlpButtons.TabIndex = 5;
            // 
            // buttonTutup
            // 
            this.buttonTutup.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonTutup.Location = new System.Drawing.Point(682, 6);
            this.buttonTutup.Name = "buttonTutup";
            this.buttonTutup.Size = new System.Drawing.Size(75, 23);
            this.buttonTutup.TabIndex = 100;
            this.buttonTutup.Tag = "ignore";
            this.buttonTutup.Text = "Tutu&p";
            this.buttonTutup.UseVisualStyleBackColor = true;
            this.buttonTutup.Click += new System.EventHandler(this.buttonTutup_Click);
            // 
            // buttonCetak
            // 
            this.buttonCetak.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonCetak.Location = new System.Drawing.Point(3, 6);
            this.buttonCetak.Name = "buttonCetak";
            this.buttonCetak.Size = new System.Drawing.Size(75, 23);
            this.buttonCetak.TabIndex = 99;
            this.buttonCetak.Text = "&Cetak";
            this.buttonCetak.UseVisualStyleBackColor = true;
            this.buttonCetak.Click += new System.EventHandler(this.buttonCetak_Click);
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
            this.listDataGrid.Location = new System.Drawing.Point(12, 58);
            this.listDataGrid.Name = "listDataGrid";
            this.listDataGrid.ShowRowHeader = true;
            this.listDataGrid.Size = new System.Drawing.Size(760, 351);
            this.listDataGrid.TabIndex = 0;
            this.listDataGrid.Text = "listDataGrid1";
            // 
            // DetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.listDataGrid);
            this.Controls.Add(this.tlpButtons);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DetailView";
            this.Tag = "ignore";
            this.Text = "BaseDetailTransaksiView";
            this.Load += new System.EventHandler(this.DetailView_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DetailView_KeyDown);
            this.Controls.SetChildIndex(this.panelUp, 0);
            this.Controls.SetChildIndex(this.tlpButtons, 0);
            this.Controls.SetChildIndex(this.listDataGrid, 0);
            this.tlpButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listDataGrid)).EndInit();
            this.ResumeLayout(false);

      }

      #endregion

      protected System.Windows.Forms.TableLayoutPanel tlpButtons;
      protected System.Windows.Forms.Button buttonTutup;
      private ListDataGrid listDataGrid;
      private System.Windows.Forms.Button buttonCetak;
   }
}