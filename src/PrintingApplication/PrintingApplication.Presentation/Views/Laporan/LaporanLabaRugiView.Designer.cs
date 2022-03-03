namespace PrintingApplication.Presentation.Views.Laporan
{
   partial class LaporanLabaRugiView
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaporanLabaRugiView));
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.comboBoxBulan = new PrintingApplication.Presentation.Views.CommonControls.ComboBoxBulan();
         this.numericUpDownTahun = new System.Windows.Forms.NumericUpDown();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
         this.label9 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label10 = new System.Windows.Forms.Label();
         this.label13 = new System.Windows.Forms.Label();
         this.labelHpp = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.label28 = new System.Windows.Forms.Label();
         this.labelTotalSelisih = new System.Windows.Forms.Label();
         this.labelDiskonPenjualan = new System.Windows.Forms.Label();
         this.labelPengeluaran = new System.Windows.Forms.Label();
         this.labelPenjualan = new System.Windows.Forms.Label();
         this.label21 = new System.Windows.Forms.Label();
         this.label14 = new System.Windows.Forms.Label();
         this.label17 = new System.Windows.Forms.Label();
         this.label20 = new System.Windows.Forms.Label();
         this.label23 = new System.Windows.Forms.Label();
         this.label25 = new System.Windows.Forms.Label();
         this.label26 = new System.Windows.Forms.Label();
         this.label27 = new System.Windows.Forms.Label();
         this.label31 = new System.Windows.Forms.Label();
         this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
         this.buttonCetak = new System.Windows.Forms.Button();
         this.buttonTutup = new System.Windows.Forms.Button();
         this.panelUp = new PrintingApplication.Presentation.Views.CommonControls.PanelUp();
         this.groupBox1.SuspendLayout();
         this.tableLayoutPanel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTahun)).BeginInit();
         this.groupBox2.SuspendLayout();
         this.tableLayoutPanel2.SuspendLayout();
         this.tableLayoutPanel5.SuspendLayout();
         this.SuspendLayout();
         // 
         // groupBox1
         // 
         this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.groupBox1.Controls.Add(this.tableLayoutPanel1);
         this.groupBox1.Location = new System.Drawing.Point(12, 58);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(360, 55);
         this.groupBox1.TabIndex = 1;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "[ DATA ]";
         // 
         // tableLayoutPanel1
         // 
         this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.tableLayoutPanel1.ColumnCount = 4;
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
         this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
         this.tableLayoutPanel1.Controls.Add(this.comboBoxBulan, 2, 0);
         this.tableLayoutPanel1.Controls.Add(this.numericUpDownTahun, 3, 0);
         this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
         this.tableLayoutPanel1.Name = "tableLayoutPanel1";
         this.tableLayoutPanel1.RowCount = 1;
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tableLayoutPanel1.Size = new System.Drawing.Size(348, 30);
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
         this.label1.Text = "Bulan";
         // 
         // label2
         // 
         this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(129, 8);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(10, 13);
         this.label2.TabIndex = 0;
         this.label2.Text = ":";
         // 
         // comboBoxBulan
         // 
         this.comboBoxBulan.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.comboBoxBulan.Location = new System.Drawing.Point(145, 4);
         this.comboBoxBulan.Name = "comboBoxBulan";
         this.comboBoxBulan.Size = new System.Drawing.Size(125, 21);
         this.comboBoxBulan.TabIndex = 0;
         this.comboBoxBulan.SelectedIndexChanged += new System.EventHandler(this.comboBoxBulan_SelectedIndexChanged);
         // 
         // numericUpDownTahun
         // 
         this.numericUpDownTahun.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.numericUpDownTahun.Location = new System.Drawing.Point(276, 5);
         this.numericUpDownTahun.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
         this.numericUpDownTahun.Minimum = new decimal(new int[] {
            1945,
            0,
            0,
            0});
         this.numericUpDownTahun.Name = "numericUpDownTahun";
         this.numericUpDownTahun.Size = new System.Drawing.Size(65, 20);
         this.numericUpDownTahun.TabIndex = 1;
         this.numericUpDownTahun.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         this.numericUpDownTahun.Value = new decimal(new int[] {
            1945,
            0,
            0,
            0});
         this.numericUpDownTahun.ValueChanged += new System.EventHandler(this.numericUpDownTahun_ValueChanged);
         // 
         // groupBox2
         // 
         this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.groupBox2.Controls.Add(this.tableLayoutPanel2);
         this.groupBox2.Location = new System.Drawing.Point(12, 119);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Size = new System.Drawing.Size(360, 205);
         this.groupBox2.TabIndex = 2;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "[ TOTAL ]";
         // 
         // tableLayoutPanel2
         // 
         this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.tableLayoutPanel2.ColumnCount = 4;
         this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
         this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
         this.tableLayoutPanel2.Controls.Add(this.label9, 0, 1);
         this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
         this.tableLayoutPanel2.Controls.Add(this.label10, 0, 2);
         this.tableLayoutPanel2.Controls.Add(this.label13, 0, 3);
         this.tableLayoutPanel2.Controls.Add(this.labelHpp, 2, 1);
         this.tableLayoutPanel2.Controls.Add(this.label7, 1, 0);
         this.tableLayoutPanel2.Controls.Add(this.label28, 0, 5);
         this.tableLayoutPanel2.Controls.Add(this.labelTotalSelisih, 2, 5);
         this.tableLayoutPanel2.Controls.Add(this.labelDiskonPenjualan, 2, 3);
         this.tableLayoutPanel2.Controls.Add(this.labelPengeluaran, 2, 2);
         this.tableLayoutPanel2.Controls.Add(this.labelPenjualan, 2, 0);
         this.tableLayoutPanel2.Controls.Add(this.label21, 0, 4);
         this.tableLayoutPanel2.Controls.Add(this.label14, 1, 1);
         this.tableLayoutPanel2.Controls.Add(this.label17, 1, 2);
         this.tableLayoutPanel2.Controls.Add(this.label20, 1, 3);
         this.tableLayoutPanel2.Controls.Add(this.label23, 3, 0);
         this.tableLayoutPanel2.Controls.Add(this.label25, 3, 1);
         this.tableLayoutPanel2.Controls.Add(this.label26, 3, 2);
         this.tableLayoutPanel2.Controls.Add(this.label27, 3, 3);
         this.tableLayoutPanel2.Controls.Add(this.label31, 1, 5);
         this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 19);
         this.tableLayoutPanel2.Name = "tableLayoutPanel2";
         this.tableLayoutPanel2.RowCount = 6;
         this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
         this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
         this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
         this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
         this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
         this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
         this.tableLayoutPanel2.Size = new System.Drawing.Size(348, 180);
         this.tableLayoutPanel2.TabIndex = 0;
         // 
         // label9
         // 
         this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label9.AutoSize = true;
         this.label9.Location = new System.Drawing.Point(3, 37);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(120, 13);
         this.label9.TabIndex = 0;
         this.label9.Text = "Harga Pokok Penjualan";
         // 
         // label3
         // 
         this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(3, 8);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(54, 13);
         this.label3.TabIndex = 0;
         this.label3.Text = "Penjualan";
         // 
         // label10
         // 
         this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label10.AutoSize = true;
         this.label10.Location = new System.Drawing.Point(3, 66);
         this.label10.Name = "label10";
         this.label10.Size = new System.Drawing.Size(67, 13);
         this.label10.TabIndex = 0;
         this.label10.Text = "Pengeluaran";
         // 
         // label13
         // 
         this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label13.AutoSize = true;
         this.label13.Location = new System.Drawing.Point(3, 95);
         this.label13.Name = "label13";
         this.label13.Size = new System.Drawing.Size(90, 13);
         this.label13.TabIndex = 0;
         this.label13.Text = "Diskon Penjualan";
         // 
         // labelHpp
         // 
         this.labelHpp.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.labelHpp.AutoSize = true;
         this.labelHpp.Location = new System.Drawing.Point(311, 37);
         this.labelHpp.Name = "labelHpp";
         this.labelHpp.Size = new System.Drawing.Size(13, 13);
         this.labelHpp.TabIndex = 0;
         this.labelHpp.Text = "0";
         // 
         // label7
         // 
         this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(129, 8);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(10, 13);
         this.label7.TabIndex = 0;
         this.label7.Text = ":";
         // 
         // label28
         // 
         this.label28.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label28.AutoSize = true;
         this.label28.Location = new System.Drawing.Point(3, 156);
         this.label28.Name = "label28";
         this.label28.Size = new System.Drawing.Size(37, 13);
         this.label28.TabIndex = 0;
         this.label28.Text = "Selisih";
         // 
         // labelTotalSelisih
         // 
         this.labelTotalSelisih.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.labelTotalSelisih.AutoSize = true;
         this.labelTotalSelisih.Location = new System.Drawing.Point(311, 156);
         this.labelTotalSelisih.Name = "labelTotalSelisih";
         this.labelTotalSelisih.Size = new System.Drawing.Size(13, 13);
         this.labelTotalSelisih.TabIndex = 0;
         this.labelTotalSelisih.Text = "0";
         this.labelTotalSelisih.TextChanged += new System.EventHandler(this.labelTotalSelisih_TextChanged);
         // 
         // labelDiskonPenjualan
         // 
         this.labelDiskonPenjualan.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.labelDiskonPenjualan.AutoSize = true;
         this.labelDiskonPenjualan.Location = new System.Drawing.Point(311, 95);
         this.labelDiskonPenjualan.Name = "labelDiskonPenjualan";
         this.labelDiskonPenjualan.Size = new System.Drawing.Size(13, 13);
         this.labelDiskonPenjualan.TabIndex = 0;
         this.labelDiskonPenjualan.Text = "0";
         // 
         // labelPengeluaran
         // 
         this.labelPengeluaran.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.labelPengeluaran.AutoSize = true;
         this.labelPengeluaran.Location = new System.Drawing.Point(311, 66);
         this.labelPengeluaran.Name = "labelPengeluaran";
         this.labelPengeluaran.Size = new System.Drawing.Size(13, 13);
         this.labelPengeluaran.TabIndex = 0;
         this.labelPengeluaran.Text = "0";
         // 
         // labelPenjualan
         // 
         this.labelPenjualan.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.labelPenjualan.AutoSize = true;
         this.labelPenjualan.Location = new System.Drawing.Point(311, 8);
         this.labelPenjualan.Name = "labelPenjualan";
         this.labelPenjualan.Size = new System.Drawing.Size(13, 13);
         this.labelPenjualan.TabIndex = 0;
         this.labelPenjualan.Text = "0";
         // 
         // label21
         // 
         this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.label21.AutoSize = true;
         this.tableLayoutPanel2.SetColumnSpan(this.label21, 4);
         this.label21.Location = new System.Drawing.Point(4, 124);
         this.label21.Name = "label21";
         this.label21.Size = new System.Drawing.Size(340, 13);
         this.label21.TabIndex = 0;
         this.label21.Text = "---------------------------------------------------------------------------------" +
    "------------------------------";
         // 
         // label14
         // 
         this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label14.AutoSize = true;
         this.label14.Location = new System.Drawing.Point(129, 37);
         this.label14.Name = "label14";
         this.label14.Size = new System.Drawing.Size(10, 13);
         this.label14.TabIndex = 0;
         this.label14.Text = ":";
         // 
         // label17
         // 
         this.label17.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label17.AutoSize = true;
         this.label17.Location = new System.Drawing.Point(129, 66);
         this.label17.Name = "label17";
         this.label17.Size = new System.Drawing.Size(10, 13);
         this.label17.TabIndex = 0;
         this.label17.Text = ":";
         // 
         // label20
         // 
         this.label20.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label20.AutoSize = true;
         this.label20.Location = new System.Drawing.Point(129, 95);
         this.label20.Name = "label20";
         this.label20.Size = new System.Drawing.Size(10, 13);
         this.label20.TabIndex = 0;
         this.label20.Text = ":";
         // 
         // label23
         // 
         this.label23.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label23.AutoSize = true;
         this.label23.ForeColor = System.Drawing.Color.Red;
         this.label23.Location = new System.Drawing.Point(330, 8);
         this.label23.Name = "label23";
         this.label23.Size = new System.Drawing.Size(10, 13);
         this.label23.TabIndex = 0;
         this.label23.Text = "-";
         // 
         // label25
         // 
         this.label25.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label25.AutoSize = true;
         this.label25.ForeColor = System.Drawing.Color.Red;
         this.label25.Location = new System.Drawing.Point(330, 37);
         this.label25.Name = "label25";
         this.label25.Size = new System.Drawing.Size(10, 13);
         this.label25.TabIndex = 0;
         this.label25.Text = "-";
         // 
         // label26
         // 
         this.label26.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label26.AutoSize = true;
         this.label26.ForeColor = System.Drawing.Color.Red;
         this.label26.Location = new System.Drawing.Point(330, 66);
         this.label26.Name = "label26";
         this.label26.Size = new System.Drawing.Size(10, 13);
         this.label26.TabIndex = 0;
         this.label26.Text = "-";
         // 
         // label27
         // 
         this.label27.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label27.AutoSize = true;
         this.label27.ForeColor = System.Drawing.Color.Red;
         this.label27.Location = new System.Drawing.Point(330, 95);
         this.label27.Name = "label27";
         this.label27.Size = new System.Drawing.Size(10, 13);
         this.label27.TabIndex = 0;
         this.label27.Text = "-";
         // 
         // label31
         // 
         this.label31.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label31.AutoSize = true;
         this.label31.Location = new System.Drawing.Point(129, 156);
         this.label31.Name = "label31";
         this.label31.Size = new System.Drawing.Size(10, 13);
         this.label31.TabIndex = 0;
         this.label31.Text = ":";
         // 
         // tableLayoutPanel5
         // 
         this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.tableLayoutPanel5.ColumnCount = 2;
         this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel5.Controls.Add(this.buttonCetak, 0, 0);
         this.tableLayoutPanel5.Controls.Add(this.buttonTutup, 1, 0);
         this.tableLayoutPanel5.Location = new System.Drawing.Point(201, 331);
         this.tableLayoutPanel5.Name = "tableLayoutPanel5";
         this.tableLayoutPanel5.RowCount = 1;
         this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel5.Size = new System.Drawing.Size(171, 30);
         this.tableLayoutPanel5.TabIndex = 108;
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
         // panelUp
         // 
         this.panelUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.panelUp.LabelInfo = "Info";
         this.panelUp.Location = new System.Drawing.Point(12, 12);
         this.panelUp.Name = "panelUp";
         this.panelUp.Size = new System.Drawing.Size(360, 40);
         this.panelUp.TabIndex = 0;
         this.panelUp.TabStop = false;
         // 
         // LaporanLabaRugiView
         // 
         this.AccessibleName = "Laporan";
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(384, 373);
         this.Controls.Add(this.tableLayoutPanel5);
         this.Controls.Add(this.groupBox2);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.panelUp);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "LaporanLabaRugiView";
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Laporan Laba Rugi";
         this.Load += new System.EventHandler(this.LaporanLabaRugiView_Load);
         this.groupBox1.ResumeLayout(false);
         this.tableLayoutPanel1.ResumeLayout(false);
         this.tableLayoutPanel1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTahun)).EndInit();
         this.groupBox2.ResumeLayout(false);
         this.tableLayoutPanel2.ResumeLayout(false);
         this.tableLayoutPanel2.PerformLayout();
         this.tableLayoutPanel5.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private CommonControls.PanelUp panelUp;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private CommonControls.ComboBoxBulan comboBoxBulan;
      private System.Windows.Forms.GroupBox groupBox2;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.Label labelPenjualan;
      private System.Windows.Forms.Label labelHpp;
      private System.Windows.Forms.Label labelPengeluaran;
      private System.Windows.Forms.Label labelDiskonPenjualan;
      private System.Windows.Forms.Label label21;
      private System.Windows.Forms.Label labelTotalSelisih;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
      protected System.Windows.Forms.Button buttonCetak;
      protected System.Windows.Forms.Button buttonTutup;
      private System.Windows.Forms.NumericUpDown numericUpDownTahun;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.Label label10;
      private System.Windows.Forms.Label label13;
      private System.Windows.Forms.Label label14;
      private System.Windows.Forms.Label label17;
      private System.Windows.Forms.Label label20;
      private System.Windows.Forms.Label label23;
      private System.Windows.Forms.Label label25;
      private System.Windows.Forms.Label label26;
      private System.Windows.Forms.Label label27;
      private System.Windows.Forms.Label label28;
      private System.Windows.Forms.Label label31;
   }
}