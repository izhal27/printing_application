namespace PrintingApplication.Presentation.Views.Orderan
{
   partial class BayarOrderanEntryView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BayarOrderanEntryView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dtTanggalOrderan = new System.Windows.Forms.DateTimePicker();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.buttonBayar = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelUp = new PrintingApplication.Presentation.Views.CommonControls.PanelUp();
            this.comboBoxPelanggan = new PrintingApplication.Presentation.Views.ModelControls.ComboBoxPelanggan();
            this.textBoxSubTotal = new PrintingApplication.Presentation.Views.CommonControls.BaseTextBox();
            this.textBoxDiskon = new PrintingApplication.Presentation.Views.CommonControls.BaseTextBoxDigit();
            this.textBoxGrandTotal = new PrintingApplication.Presentation.Views.CommonControls.BaseTextBoxDigit();
            this.textBoxBayar = new PrintingApplication.Presentation.Views.CommonControls.BaseTextBoxDigit();
            this.textBoxKembali = new PrintingApplication.Presentation.Views.CommonControls.BaseTextBoxDigit();
            this.textBoxTotalItem = new PrintingApplication.Presentation.Views.CommonControls.BaseTextBox();
            this.textBoxTotalQty = new PrintingApplication.Presentation.Views.CommonControls.BaseTextBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxSubTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxDiskon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxGrandTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxBayar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxKembali)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxTotalItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxTotalQty)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 409);
            this.groupBox1.TabIndex = 9;
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
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label24, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label25, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxPelanggan, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label28, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxSubTotal, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBoxDiskon, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBoxGrandTotal, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.label27, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.textBoxBayar, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.textBoxKembali, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.label11, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label12, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label13, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxTotalItem, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxTotalQty, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.dtTanggalOrderan, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(345, 384);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tanggal";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pelanggan (F2)";
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(131, 14);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(10, 13);
            this.label24.TabIndex = 0;
            this.label24.Text = ":";
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(131, 56);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(10, 13);
            this.label25.TabIndex = 0;
            this.label25.Text = ":";
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(131, 182);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(10, 13);
            this.label28.TabIndex = 0;
            this.label28.Text = ":";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(131, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Sub Total";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Diskon (F3)";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Grand Total";
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(3, 350);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(65, 20);
            this.label27.TabIndex = 0;
            this.label27.Text = "Kembali";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 305);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Bayar (F4)";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(131, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = ":";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(131, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = ":";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(131, 353);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(10, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = ":";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 95);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Total Item";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 137);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(122, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "Jumlah Orderan";
            // 
            // dtTanggalOrderan
            // 
            this.dtTanggalOrderan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtTanggalOrderan.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTanggalOrderan.Location = new System.Drawing.Point(147, 11);
            this.dtTanggalOrderan.Name = "dtTanggalOrderan";
            this.dtTanggalOrderan.Size = new System.Drawing.Size(186, 20);
            this.dtTanggalOrderan.TabIndex = 13;
            // 
            // tlpButtons
            // 
            this.tlpButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpButtons.BackColor = System.Drawing.SystemColors.Control;
            this.tlpButtons.ColumnCount = 2;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.Controls.Add(this.buttonBayar, 0, 0);
            this.tlpButtons.Controls.Add(this.btnCancel, 1, 0);
            this.tlpButtons.Location = new System.Drawing.Point(169, 473);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 1;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.Size = new System.Drawing.Size(200, 35);
            this.tlpButtons.TabIndex = 102;
            // 
            // buttonBayar
            // 
            this.buttonBayar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonBayar.Location = new System.Drawing.Point(22, 6);
            this.buttonBayar.Name = "buttonBayar";
            this.buttonBayar.Size = new System.Drawing.Size(75, 23);
            this.buttonBayar.TabIndex = 99;
            this.buttonBayar.Tag = "ignore";
            this.buttonBayar.Text = "(F6) &Bayar";
            this.buttonBayar.UseVisualStyleBackColor = true;
            this.buttonBayar.Click += new System.EventHandler(this.buttonnBayar_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(103, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 100;
            this.btnCancel.Tag = "ignore";
            this.btnCancel.Text = "(F12) &Batal";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // panelUp
            // 
            this.panelUp.LabelInfo = "Info";
            this.panelUp.Location = new System.Drawing.Point(12, 12);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(357, 40);
            this.panelUp.TabIndex = 10;
            this.panelUp.TabStop = false;
            // 
            // comboBoxPelanggan
            // 
            this.comboBoxPelanggan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxPelanggan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPelanggan.Location = new System.Drawing.Point(148, 47);
            this.comboBoxPelanggan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxPelanggan.Name = "comboBoxPelanggan";
            this.comboBoxPelanggan.SelectedItem = null;
            this.comboBoxPelanggan.Size = new System.Drawing.Size(185, 32);
            this.comboBoxPelanggan.TabIndex = 0;
            // 
            // textBoxSubTotal
            // 
            this.textBoxSubTotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxSubTotal.BeforeTouchSize = new System.Drawing.Size(186, 26);
            this.textBoxSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubTotal.Location = new System.Drawing.Point(147, 176);
            this.textBoxSubTotal.Name = "textBoxSubTotal";
            this.textBoxSubTotal.ReadOnly = true;
            this.textBoxSubTotal.Size = new System.Drawing.Size(186, 26);
            this.textBoxSubTotal.TabIndex = 11;
            this.textBoxSubTotal.TabStop = false;
            this.textBoxSubTotal.Text = "0";
            this.textBoxSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxSubTotal.ThemeName = "Default";
            // 
            // textBoxDiskon
            // 
            this.textBoxDiskon.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxDiskon.BeforeTouchSize = new System.Drawing.Size(186, 26);
            this.textBoxDiskon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDiskon.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxDiskon.IntegerValue = ((long)(0));
            this.textBoxDiskon.Location = new System.Drawing.Point(147, 218);
            this.textBoxDiskon.MinValue = ((long)(0));
            this.textBoxDiskon.Name = "textBoxDiskon";
            this.textBoxDiskon.Size = new System.Drawing.Size(186, 26);
            this.textBoxDiskon.TabIndex = 2;
            this.textBoxDiskon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxDiskon.ThemeName = "Default";
            this.textBoxDiskon.TextChanged += new System.EventHandler(this.textBoxDiskon_TextChanged);
            // 
            // textBoxGrandTotal
            // 
            this.textBoxGrandTotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxGrandTotal.BeforeTouchSize = new System.Drawing.Size(186, 26);
            this.textBoxGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGrandTotal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxGrandTotal.IntegerValue = ((long)(0));
            this.textBoxGrandTotal.Location = new System.Drawing.Point(147, 260);
            this.textBoxGrandTotal.Name = "textBoxGrandTotal";
            this.textBoxGrandTotal.ReadOnly = true;
            this.textBoxGrandTotal.Size = new System.Drawing.Size(186, 26);
            this.textBoxGrandTotal.TabIndex = 12;
            this.textBoxGrandTotal.TabStop = false;
            this.textBoxGrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxGrandTotal.ThemeName = "Default";
            // 
            // textBoxBayar
            // 
            this.textBoxBayar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxBayar.BeforeTouchSize = new System.Drawing.Size(186, 26);
            this.textBoxBayar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBayar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxBayar.IntegerValue = ((long)(0));
            this.textBoxBayar.Location = new System.Drawing.Point(147, 302);
            this.textBoxBayar.Name = "textBoxBayar";
            this.textBoxBayar.Size = new System.Drawing.Size(186, 26);
            this.textBoxBayar.TabIndex = 3;
            this.textBoxBayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxBayar.ThemeName = "Default";
            this.textBoxBayar.TextChanged += new System.EventHandler(this.textBoxBayar_TextChanged);
            // 
            // textBoxKembali
            // 
            this.textBoxKembali.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxKembali.BeforeTouchSize = new System.Drawing.Size(186, 26);
            this.textBoxKembali.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKembali.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxKembali.IntegerValue = ((long)(0));
            this.textBoxKembali.Location = new System.Drawing.Point(147, 347);
            this.textBoxKembali.Name = "textBoxKembali";
            this.textBoxKembali.ReadOnly = true;
            this.textBoxKembali.Size = new System.Drawing.Size(186, 26);
            this.textBoxKembali.TabIndex = 12;
            this.textBoxKembali.TabStop = false;
            this.textBoxKembali.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxKembali.ThemeName = "Default";
            // 
            // textBoxTotalItem
            // 
            this.textBoxTotalItem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxTotalItem.BeforeTouchSize = new System.Drawing.Size(186, 26);
            this.textBoxTotalItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalItem.Location = new System.Drawing.Point(147, 92);
            this.textBoxTotalItem.Name = "textBoxTotalItem";
            this.textBoxTotalItem.ReadOnly = true;
            this.textBoxTotalItem.Size = new System.Drawing.Size(186, 26);
            this.textBoxTotalItem.TabIndex = 11;
            this.textBoxTotalItem.TabStop = false;
            this.textBoxTotalItem.Text = "0";
            this.textBoxTotalItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxTotalItem.ThemeName = "Default";
            // 
            // textBoxTotalQty
            // 
            this.textBoxTotalQty.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxTotalQty.BeforeTouchSize = new System.Drawing.Size(186, 26);
            this.textBoxTotalQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalQty.Location = new System.Drawing.Point(147, 134);
            this.textBoxTotalQty.Name = "textBoxTotalQty";
            this.textBoxTotalQty.ReadOnly = true;
            this.textBoxTotalQty.Size = new System.Drawing.Size(186, 26);
            this.textBoxTotalQty.TabIndex = 11;
            this.textBoxTotalQty.TabStop = false;
            this.textBoxTotalQty.Text = "0";
            this.textBoxTotalQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxTotalQty.ThemeName = "Default";
            // 
            // BayarOrderanEntryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 520);
            this.Controls.Add(this.tlpButtons);
            this.Controls.Add(this.panelUp);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BayarOrderanEntryView";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "ignore";
            this.Text = "Bayar Orderan";
            this.Load += new System.EventHandler(this.BayarPenjualanEntryView_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BayarPenjualanEntryView_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tlpButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textBoxSubTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxDiskon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxGrandTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxBayar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxKembali)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxTotalItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxTotalQty)).EndInit();
            this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label24;
      private System.Windows.Forms.Label label25;
      private ModelControls.ComboBoxPelanggan comboBoxPelanggan;
      private System.Windows.Forms.Label label27;
      private System.Windows.Forms.Label label28;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label7;
      private CommonControls.BaseTextBox textBoxSubTotal;
      private System.Windows.Forms.Label label8;
      private CommonControls.BaseTextBoxDigit textBoxDiskon;
      private System.Windows.Forms.Label label9;
      private CommonControls.BaseTextBoxDigit textBoxGrandTotal;
      private System.Windows.Forms.Label label10;
      private CommonControls.BaseTextBoxDigit textBoxBayar;
      private CommonControls.BaseTextBoxDigit textBoxKembali;
      private CommonControls.PanelUp panelUp;
      protected System.Windows.Forms.TableLayoutPanel tlpButtons;
      protected System.Windows.Forms.Button buttonBayar;
      protected System.Windows.Forms.Button btnCancel;
      private System.Windows.Forms.Label label11;
      private System.Windows.Forms.Label label12;
      private System.Windows.Forms.Label label13;
      private System.Windows.Forms.Label label14;
      private System.Windows.Forms.Label label15;
      private CommonControls.BaseTextBox textBoxTotalItem;
      private CommonControls.BaseTextBox textBoxTotalQty;
        private System.Windows.Forms.DateTimePicker dtTanggalOrderan;
    }
}