namespace PrintingApplication.Presentation.Views.Laporan
{
   partial class LaporanStatusBarangView
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaporanStatusBarangView));
         this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
         this.buttonCetak = new System.Windows.Forms.Button();
         this.buttonTutup = new System.Windows.Forms.Button();
         this.label5 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.label8 = new System.Windows.Forms.Label();
         this.labelStokAwal = new System.Windows.Forms.Label();
         this.labelStokTerjual = new System.Windows.Forms.Label();
         this.labelStokAkhir = new System.Windows.Forms.Label();
         this.label13 = new System.Windows.Forms.Label();
         this.label18 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label10 = new System.Windows.Forms.Label();
         this.labelStokMasuk = new System.Windows.Forms.Label();
         this.label15 = new System.Windows.Forms.Label();
         this.dateTimePickerTanggal = new System.Windows.Forms.DateTimePicker();
         this.label11 = new System.Windows.Forms.Label();
         this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
         this.label16 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label9 = new System.Windows.Forms.Label();
         this.labelPenyesuaianStok = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.labelReturnPenjualan = new System.Windows.Forms.Label();
         this.label12 = new System.Windows.Forms.Label();
         this.label21 = new System.Windows.Forms.Label();
         this.label17 = new System.Windows.Forms.Label();
         this.label20 = new System.Windows.Forms.Label();
         this.labelReturnPembelian = new System.Windows.Forms.Label();
         this.label23 = new System.Windows.Forms.Label();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.panelUp = new PrintingApplication.Presentation.Views.CommonControls.PanelUp();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
         this.label14 = new System.Windows.Forms.Label();
         this.label19 = new System.Windows.Forms.Label();
         this.tableLayoutPanel2.SuspendLayout();
         this.tableLayoutPanel1.SuspendLayout();
         this.groupBox1.SuspendLayout();
         this.groupBox2.SuspendLayout();
         this.tableLayoutPanel3.SuspendLayout();
         this.SuspendLayout();
         // 
         // tableLayoutPanel2
         // 
         this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.tableLayoutPanel2.ColumnCount = 2;
         this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel2.Controls.Add(this.buttonCetak, 0, 0);
         this.tableLayoutPanel2.Controls.Add(this.buttonTutup, 1, 0);
         this.tableLayoutPanel2.Location = new System.Drawing.Point(201, 390);
         this.tableLayoutPanel2.Name = "tableLayoutPanel2";
         this.tableLayoutPanel2.RowCount = 1;
         this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel2.Size = new System.Drawing.Size(171, 30);
         this.tableLayoutPanel2.TabIndex = 107;
         // 
         // buttonCetak
         // 
         this.buttonCetak.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.buttonCetak.Location = new System.Drawing.Point(7, 3);
         this.buttonCetak.Name = "buttonCetak";
         this.buttonCetak.Size = new System.Drawing.Size(75, 23);
         this.buttonCetak.TabIndex = 99;
         this.buttonCetak.Tag = "ignore";
         this.buttonCetak.Text = "&Cetak";
         this.buttonCetak.UseVisualStyleBackColor = true;
         this.buttonCetak.Click += new System.EventHandler(this.buttonCetak_Click);
         // 
         // buttonTutup
         // 
         this.buttonTutup.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.buttonTutup.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.buttonTutup.Location = new System.Drawing.Point(88, 3);
         this.buttonTutup.Name = "buttonTutup";
         this.buttonTutup.Size = new System.Drawing.Size(75, 23);
         this.buttonTutup.TabIndex = 99;
         this.buttonTutup.Tag = "ignore";
         this.buttonTutup.Text = "&Tutup";
         this.buttonTutup.UseVisualStyleBackColor = true;
         // 
         // label5
         // 
         this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(3, 8);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(55, 13);
         this.label5.TabIndex = 0;
         this.label5.Text = "Stok Awal";
         // 
         // label6
         // 
         this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(3, 68);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(64, 13);
         this.label6.TabIndex = 0;
         this.label6.Text = "Stok Terjual";
         // 
         // label7
         // 
         this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.label7.AutoSize = true;
         this.tableLayoutPanel1.SetColumnSpan(this.label7, 4);
         this.label7.Location = new System.Drawing.Point(5, 188);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(337, 13);
         this.label7.TabIndex = 0;
         this.label7.Text = "---------------------------------------------------------------------------------" +
    "-----------------------------";
         // 
         // label8
         // 
         this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(3, 218);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(56, 13);
         this.label8.TabIndex = 0;
         this.label8.Text = "Stok Akhir";
         // 
         // labelStokAwal
         // 
         this.labelStokAwal.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.labelStokAwal.AutoSize = true;
         this.labelStokAwal.Location = new System.Drawing.Point(308, 8);
         this.labelStokAwal.Name = "labelStokAwal";
         this.labelStokAwal.Size = new System.Drawing.Size(13, 13);
         this.labelStokAwal.TabIndex = 0;
         this.labelStokAwal.Text = "0";
         this.labelStokAwal.TextAlign = System.Drawing.ContentAlignment.TopRight;
         // 
         // labelStokTerjual
         // 
         this.labelStokTerjual.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.labelStokTerjual.AutoSize = true;
         this.labelStokTerjual.Location = new System.Drawing.Point(308, 68);
         this.labelStokTerjual.Name = "labelStokTerjual";
         this.labelStokTerjual.Size = new System.Drawing.Size(13, 13);
         this.labelStokTerjual.TabIndex = 0;
         this.labelStokTerjual.Text = "0";
         this.labelStokTerjual.TextAlign = System.Drawing.ContentAlignment.TopRight;
         // 
         // labelStokAkhir
         // 
         this.labelStokAkhir.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.labelStokAkhir.AutoSize = true;
         this.labelStokAkhir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelStokAkhir.Location = new System.Drawing.Point(308, 218);
         this.labelStokAkhir.Name = "labelStokAkhir";
         this.labelStokAkhir.Size = new System.Drawing.Size(13, 13);
         this.labelStokAkhir.TabIndex = 0;
         this.labelStokAkhir.Text = "0";
         this.labelStokAkhir.TextAlign = System.Drawing.ContentAlignment.TopRight;
         // 
         // label13
         // 
         this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label13.AutoSize = true;
         this.label13.Location = new System.Drawing.Point(102, 8);
         this.label13.Name = "label13";
         this.label13.Size = new System.Drawing.Size(10, 13);
         this.label13.TabIndex = 0;
         this.label13.Text = ":";
         // 
         // label18
         // 
         this.label18.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label18.AutoSize = true;
         this.label18.ForeColor = System.Drawing.Color.Red;
         this.label18.Location = new System.Drawing.Point(327, 68);
         this.label18.Name = "label18";
         this.label18.Size = new System.Drawing.Size(10, 13);
         this.label18.TabIndex = 0;
         this.label18.Text = "-";
         // 
         // label3
         // 
         this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(3, 38);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(64, 13);
         this.label3.TabIndex = 0;
         this.label3.Text = "Stok Masuk";
         // 
         // label10
         // 
         this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label10.AutoSize = true;
         this.label10.ForeColor = System.Drawing.Color.Green;
         this.label10.Location = new System.Drawing.Point(327, 38);
         this.label10.Name = "label10";
         this.label10.Size = new System.Drawing.Size(13, 13);
         this.label10.TabIndex = 0;
         this.label10.Text = "+";
         // 
         // labelStokMasuk
         // 
         this.labelStokMasuk.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.labelStokMasuk.AutoSize = true;
         this.labelStokMasuk.Location = new System.Drawing.Point(308, 38);
         this.labelStokMasuk.Name = "labelStokMasuk";
         this.labelStokMasuk.Size = new System.Drawing.Size(13, 13);
         this.labelStokMasuk.TabIndex = 0;
         this.labelStokMasuk.Text = "0";
         this.labelStokMasuk.TextAlign = System.Drawing.ContentAlignment.TopRight;
         // 
         // label15
         // 
         this.label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label15.AutoSize = true;
         this.label15.Location = new System.Drawing.Point(102, 38);
         this.label15.Name = "label15";
         this.label15.Size = new System.Drawing.Size(10, 13);
         this.label15.TabIndex = 0;
         this.label15.Text = ":";
         // 
         // dateTimePickerTanggal
         // 
         this.dateTimePickerTanggal.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.dateTimePickerTanggal.Location = new System.Drawing.Point(118, 5);
         this.dateTimePickerTanggal.MinDate = new System.DateTime(1945, 8, 17, 0, 0, 0, 0);
         this.dateTimePickerTanggal.Name = "dateTimePickerTanggal";
         this.dateTimePickerTanggal.Size = new System.Drawing.Size(150, 20);
         this.dateTimePickerTanggal.TabIndex = 0;
         this.dateTimePickerTanggal.ValueChanged += new System.EventHandler(this.dateTimePickerTanggal_ValueChanged);
         // 
         // label11
         // 
         this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label11.AutoSize = true;
         this.label11.Location = new System.Drawing.Point(102, 68);
         this.label11.Name = "label11";
         this.label11.Size = new System.Drawing.Size(10, 13);
         this.label11.TabIndex = 0;
         this.label11.Text = ":";
         // 
         // tableLayoutPanel1
         // 
         this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.tableLayoutPanel1.ColumnCount = 4;
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
         this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
         this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
         this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
         this.tableLayoutPanel1.Controls.Add(this.label8, 0, 7);
         this.tableLayoutPanel1.Controls.Add(this.labelStokAwal, 2, 0);
         this.tableLayoutPanel1.Controls.Add(this.labelStokTerjual, 2, 2);
         this.tableLayoutPanel1.Controls.Add(this.labelStokAkhir, 2, 7);
         this.tableLayoutPanel1.Controls.Add(this.label13, 1, 0);
         this.tableLayoutPanel1.Controls.Add(this.label16, 1, 7);
         this.tableLayoutPanel1.Controls.Add(this.label18, 3, 2);
         this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
         this.tableLayoutPanel1.Controls.Add(this.label10, 3, 1);
         this.tableLayoutPanel1.Controls.Add(this.labelStokMasuk, 2, 1);
         this.tableLayoutPanel1.Controls.Add(this.label15, 1, 1);
         this.tableLayoutPanel1.Controls.Add(this.label11, 1, 2);
         this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
         this.tableLayoutPanel1.Controls.Add(this.label9, 1, 3);
         this.tableLayoutPanel1.Controls.Add(this.labelPenyesuaianStok, 2, 3);
         this.tableLayoutPanel1.Controls.Add(this.label1, 0, 4);
         this.tableLayoutPanel1.Controls.Add(this.label2, 1, 4);
         this.tableLayoutPanel1.Controls.Add(this.labelReturnPenjualan, 2, 4);
         this.tableLayoutPanel1.Controls.Add(this.label12, 3, 4);
         this.tableLayoutPanel1.Controls.Add(this.label21, 3, 3);
         this.tableLayoutPanel1.Controls.Add(this.label17, 0, 5);
         this.tableLayoutPanel1.Controls.Add(this.label20, 1, 5);
         this.tableLayoutPanel1.Controls.Add(this.labelReturnPembelian, 2, 5);
         this.tableLayoutPanel1.Controls.Add(this.label23, 3, 5);
         this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
         this.tableLayoutPanel1.Name = "tableLayoutPanel1";
         this.tableLayoutPanel1.RowCount = 8;
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
         this.tableLayoutPanel1.Size = new System.Drawing.Size(348, 240);
         this.tableLayoutPanel1.TabIndex = 0;
         // 
         // label16
         // 
         this.label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label16.AutoSize = true;
         this.label16.Location = new System.Drawing.Point(102, 218);
         this.label16.Name = "label16";
         this.label16.Size = new System.Drawing.Size(10, 13);
         this.label16.TabIndex = 0;
         this.label16.Text = ":";
         // 
         // label4
         // 
         this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(3, 98);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(93, 13);
         this.label4.TabIndex = 0;
         this.label4.Text = "Penyesuaian Stok";
         // 
         // label9
         // 
         this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label9.AutoSize = true;
         this.label9.Location = new System.Drawing.Point(102, 98);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(10, 13);
         this.label9.TabIndex = 0;
         this.label9.Text = ":";
         // 
         // labelPenyesuaianStok
         // 
         this.labelPenyesuaianStok.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.labelPenyesuaianStok.AutoSize = true;
         this.labelPenyesuaianStok.Location = new System.Drawing.Point(308, 98);
         this.labelPenyesuaianStok.Name = "labelPenyesuaianStok";
         this.labelPenyesuaianStok.Size = new System.Drawing.Size(13, 13);
         this.labelPenyesuaianStok.TabIndex = 0;
         this.labelPenyesuaianStok.Text = "0";
         this.labelPenyesuaianStok.TextAlign = System.Drawing.ContentAlignment.TopRight;
         // 
         // label1
         // 
         this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(3, 128);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(89, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "Return Penjualan";
         // 
         // label2
         // 
         this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(102, 128);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(10, 13);
         this.label2.TabIndex = 0;
         this.label2.Text = ":";
         // 
         // labelReturnPenjualan
         // 
         this.labelReturnPenjualan.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.labelReturnPenjualan.AutoSize = true;
         this.labelReturnPenjualan.Location = new System.Drawing.Point(308, 128);
         this.labelReturnPenjualan.Name = "labelReturnPenjualan";
         this.labelReturnPenjualan.Size = new System.Drawing.Size(13, 13);
         this.labelReturnPenjualan.TabIndex = 0;
         this.labelReturnPenjualan.Text = "0";
         this.labelReturnPenjualan.TextAlign = System.Drawing.ContentAlignment.TopRight;
         // 
         // label12
         // 
         this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label12.AutoSize = true;
         this.label12.ForeColor = System.Drawing.Color.Green;
         this.label12.Location = new System.Drawing.Point(327, 128);
         this.label12.Name = "label12";
         this.label12.Size = new System.Drawing.Size(13, 13);
         this.label12.TabIndex = 0;
         this.label12.Text = "+";
         // 
         // label21
         // 
         this.label21.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label21.AutoSize = true;
         this.label21.ForeColor = System.Drawing.Color.Red;
         this.label21.Location = new System.Drawing.Point(327, 98);
         this.label21.Name = "label21";
         this.label21.Size = new System.Drawing.Size(10, 13);
         this.label21.TabIndex = 0;
         this.label21.Text = "-";
         // 
         // label17
         // 
         this.label17.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label17.AutoSize = true;
         this.label17.Location = new System.Drawing.Point(3, 158);
         this.label17.Name = "label17";
         this.label17.Size = new System.Drawing.Size(91, 13);
         this.label17.TabIndex = 0;
         this.label17.Text = "Return Pembelian";
         // 
         // label20
         // 
         this.label20.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label20.AutoSize = true;
         this.label20.Location = new System.Drawing.Point(102, 158);
         this.label20.Name = "label20";
         this.label20.Size = new System.Drawing.Size(10, 13);
         this.label20.TabIndex = 0;
         this.label20.Text = ":";
         // 
         // labelReturnPembelian
         // 
         this.labelReturnPembelian.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.labelReturnPembelian.AutoSize = true;
         this.labelReturnPembelian.Location = new System.Drawing.Point(308, 158);
         this.labelReturnPembelian.Name = "labelReturnPembelian";
         this.labelReturnPembelian.Size = new System.Drawing.Size(13, 13);
         this.labelReturnPembelian.TabIndex = 0;
         this.labelReturnPembelian.Text = "0";
         this.labelReturnPembelian.TextAlign = System.Drawing.ContentAlignment.TopRight;
         // 
         // label23
         // 
         this.label23.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label23.AutoSize = true;
         this.label23.ForeColor = System.Drawing.Color.Red;
         this.label23.Location = new System.Drawing.Point(327, 158);
         this.label23.Name = "label23";
         this.label23.Size = new System.Drawing.Size(10, 13);
         this.label23.TabIndex = 0;
         this.label23.Text = "-";
         // 
         // groupBox1
         // 
         this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.groupBox1.Controls.Add(this.tableLayoutPanel1);
         this.groupBox1.Location = new System.Drawing.Point(12, 119);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(360, 265);
         this.groupBox1.TabIndex = 106;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "[ STATUS ]";
         // 
         // panelUp
         // 
         this.panelUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.panelUp.LabelInfo = "Info";
         this.panelUp.Location = new System.Drawing.Point(12, 12);
         this.panelUp.Name = "panelUp";
         this.panelUp.Size = new System.Drawing.Size(360, 40);
         this.panelUp.TabIndex = 108;
         this.panelUp.TabStop = false;
         // 
         // groupBox2
         // 
         this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.groupBox2.Controls.Add(this.tableLayoutPanel3);
         this.groupBox2.Location = new System.Drawing.Point(12, 58);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Size = new System.Drawing.Size(360, 55);
         this.groupBox2.TabIndex = 109;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "[ DATA ]";
         // 
         // tableLayoutPanel3
         // 
         this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.tableLayoutPanel3.ColumnCount = 3;
         this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
         this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 233F));
         this.tableLayoutPanel3.Controls.Add(this.label14, 1, 0);
         this.tableLayoutPanel3.Controls.Add(this.label19, 0, 0);
         this.tableLayoutPanel3.Controls.Add(this.dateTimePickerTanggal, 2, 0);
         this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 19);
         this.tableLayoutPanel3.Name = "tableLayoutPanel3";
         this.tableLayoutPanel3.RowCount = 1;
         this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tableLayoutPanel3.Size = new System.Drawing.Size(348, 30);
         this.tableLayoutPanel3.TabIndex = 0;
         // 
         // label14
         // 
         this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label14.AutoSize = true;
         this.label14.Location = new System.Drawing.Point(102, 8);
         this.label14.Name = "label14";
         this.label14.Size = new System.Drawing.Size(10, 13);
         this.label14.TabIndex = 0;
         this.label14.Text = ":";
         // 
         // label19
         // 
         this.label19.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label19.AutoSize = true;
         this.label19.Location = new System.Drawing.Point(3, 8);
         this.label19.Name = "label19";
         this.label19.Size = new System.Drawing.Size(46, 13);
         this.label19.TabIndex = 0;
         this.label19.Text = "Tanggal";
         // 
         // LaporanStatusBarangView
         // 
         this.AccessibleName = "Laporan";
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(384, 432);
         this.Controls.Add(this.groupBox2);
         this.Controls.Add(this.panelUp);
         this.Controls.Add(this.tableLayoutPanel2);
         this.Controls.Add(this.groupBox1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "LaporanStatusBarangView";
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Laporan Status Barang";
         this.Load += new System.EventHandler(this.LaporanStatusBarangView_Load);
         this.tableLayoutPanel2.ResumeLayout(false);
         this.tableLayoutPanel1.ResumeLayout(false);
         this.tableLayoutPanel1.PerformLayout();
         this.groupBox1.ResumeLayout(false);
         this.groupBox2.ResumeLayout(false);
         this.tableLayoutPanel3.ResumeLayout(false);
         this.tableLayoutPanel3.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private CommonControls.PanelUp panelUp;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
      protected System.Windows.Forms.Button buttonCetak;
      protected System.Windows.Forms.Button buttonTutup;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.Label labelStokAwal;
      private System.Windows.Forms.Label labelStokTerjual;
      private System.Windows.Forms.Label labelStokAkhir;
      private System.Windows.Forms.Label label13;
      private System.Windows.Forms.Label label16;
      private System.Windows.Forms.Label label18;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label10;
      private System.Windows.Forms.Label labelStokMasuk;
      private System.Windows.Forms.Label label15;
      private System.Windows.Forms.DateTimePicker dateTimePickerTanggal;
      private System.Windows.Forms.Label label11;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.Label labelPenyesuaianStok;
      private System.Windows.Forms.Label label12;
      private System.Windows.Forms.GroupBox groupBox2;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
      private System.Windows.Forms.Label label14;
      private System.Windows.Forms.Label label19;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label labelReturnPenjualan;
      private System.Windows.Forms.Label label21;
      private System.Windows.Forms.Label label17;
      private System.Windows.Forms.Label label20;
      private System.Windows.Forms.Label labelReturnPembelian;
      private System.Windows.Forms.Label label23;
   }
}