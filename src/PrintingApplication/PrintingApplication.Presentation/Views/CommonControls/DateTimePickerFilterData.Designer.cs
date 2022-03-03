namespace PrintingApplication.Presentation.Views.CommonControls
{
   partial class DateTimePickerFilterData
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

      #region Component Designer generated code

      /// <summary> 
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
         this.radioButtonSemua = new System.Windows.Forms.RadioButton();
         this.radioButtonTanggal = new System.Windows.Forms.RadioButton();
         this.radioButtonPeriode = new System.Windows.Forms.RadioButton();
         this.dateTimePickerTanggal = new System.Windows.Forms.DateTimePicker();
         this.dateTimePickerPeriodeAwal = new System.Windows.Forms.DateTimePicker();
         this.label1 = new System.Windows.Forms.Label();
         this.dateTimePickerPeriodeAkhir = new System.Windows.Forms.DateTimePicker();
         this.buttonTampilkan = new System.Windows.Forms.Button();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.groupBox1.SuspendLayout();
         this.tableLayoutPanel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.tableLayoutPanel1);
         this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.groupBox1.Location = new System.Drawing.Point(0, 0);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(446, 145);
         this.groupBox1.TabIndex = 0;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "[ FILTER BY ]";
         // 
         // tableLayoutPanel1
         // 
         this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.tableLayoutPanel1.ColumnCount = 5;
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tableLayoutPanel1.Controls.Add(this.radioButtonSemua, 0, 0);
         this.tableLayoutPanel1.Controls.Add(this.radioButtonTanggal, 0, 1);
         this.tableLayoutPanel1.Controls.Add(this.radioButtonPeriode, 0, 2);
         this.tableLayoutPanel1.Controls.Add(this.dateTimePickerTanggal, 2, 1);
         this.tableLayoutPanel1.Controls.Add(this.dateTimePickerPeriodeAwal, 2, 2);
         this.tableLayoutPanel1.Controls.Add(this.label1, 3, 2);
         this.tableLayoutPanel1.Controls.Add(this.dateTimePickerPeriodeAkhir, 4, 2);
         this.tableLayoutPanel1.Controls.Add(this.buttonTampilkan, 2, 3);
         this.tableLayoutPanel1.Controls.Add(this.label3, 1, 1);
         this.tableLayoutPanel1.Controls.Add(this.label4, 1, 2);
         this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
         this.tableLayoutPanel1.Name = "tableLayoutPanel1";
         this.tableLayoutPanel1.RowCount = 4;
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
         this.tableLayoutPanel1.Size = new System.Drawing.Size(434, 120);
         this.tableLayoutPanel1.TabIndex = 0;
         // 
         // radioButtonSemua
         // 
         this.radioButtonSemua.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.radioButtonSemua.AutoSize = true;
         this.radioButtonSemua.Checked = true;
         this.radioButtonSemua.Location = new System.Drawing.Point(3, 6);
         this.radioButtonSemua.Name = "radioButtonSemua";
         this.radioButtonSemua.Size = new System.Drawing.Size(58, 17);
         this.radioButtonSemua.TabIndex = 0;
         this.radioButtonSemua.TabStop = true;
         this.radioButtonSemua.Text = "Semua";
         this.radioButtonSemua.UseVisualStyleBackColor = true;
         // 
         // radioButtonTanggal
         // 
         this.radioButtonTanggal.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.radioButtonTanggal.AutoSize = true;
         this.radioButtonTanggal.Location = new System.Drawing.Point(3, 36);
         this.radioButtonTanggal.Name = "radioButtonTanggal";
         this.radioButtonTanggal.Size = new System.Drawing.Size(64, 17);
         this.radioButtonTanggal.TabIndex = 0;
         this.radioButtonTanggal.Text = "Tanggal";
         this.radioButtonTanggal.UseVisualStyleBackColor = true;
         this.radioButtonTanggal.CheckedChanged += new System.EventHandler(this.radioButtonTanggal_CheckedChanged);
         // 
         // radioButtonPeriode
         // 
         this.radioButtonPeriode.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.radioButtonPeriode.AutoSize = true;
         this.radioButtonPeriode.Location = new System.Drawing.Point(3, 66);
         this.radioButtonPeriode.Name = "radioButtonPeriode";
         this.radioButtonPeriode.Size = new System.Drawing.Size(61, 17);
         this.radioButtonPeriode.TabIndex = 0;
         this.radioButtonPeriode.Text = "Periode";
         this.radioButtonPeriode.UseVisualStyleBackColor = true;
         this.radioButtonPeriode.CheckedChanged += new System.EventHandler(this.radioButtonPeriode_CheckedChanged);
         // 
         // dateTimePickerTanggal
         // 
         this.dateTimePickerTanggal.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.dateTimePickerTanggal.Location = new System.Drawing.Point(89, 35);
         this.dateTimePickerTanggal.MinDate = new System.DateTime(1945, 8, 17, 0, 0, 0, 0);
         this.dateTimePickerTanggal.Name = "dateTimePickerTanggal";
         this.dateTimePickerTanggal.Size = new System.Drawing.Size(150, 20);
         this.dateTimePickerTanggal.TabIndex = 1;
         // 
         // dateTimePickerPeriodeAwal
         // 
         this.dateTimePickerPeriodeAwal.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.dateTimePickerPeriodeAwal.Location = new System.Drawing.Point(89, 65);
         this.dateTimePickerPeriodeAwal.MinDate = new System.DateTime(1945, 8, 17, 0, 0, 0, 0);
         this.dateTimePickerPeriodeAwal.Name = "dateTimePickerPeriodeAwal";
         this.dateTimePickerPeriodeAwal.Size = new System.Drawing.Size(150, 20);
         this.dateTimePickerPeriodeAwal.TabIndex = 1;
         // 
         // label1
         // 
         this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(245, 68);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(23, 13);
         this.label1.TabIndex = 2;
         this.label1.Text = "s/d";
         // 
         // dateTimePickerPeriodeAkhir
         // 
         this.dateTimePickerPeriodeAkhir.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.dateTimePickerPeriodeAkhir.Location = new System.Drawing.Point(274, 65);
         this.dateTimePickerPeriodeAkhir.MinDate = new System.DateTime(1945, 8, 17, 0, 0, 0, 0);
         this.dateTimePickerPeriodeAkhir.Name = "dateTimePickerPeriodeAkhir";
         this.dateTimePickerPeriodeAkhir.Size = new System.Drawing.Size(150, 20);
         this.dateTimePickerPeriodeAkhir.TabIndex = 1;
         // 
         // buttonTampilkan
         // 
         this.buttonTampilkan.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.buttonTampilkan.Location = new System.Drawing.Point(89, 93);
         this.buttonTampilkan.Name = "buttonTampilkan";
         this.buttonTampilkan.Size = new System.Drawing.Size(75, 23);
         this.buttonTampilkan.TabIndex = 3;
         this.buttonTampilkan.Tag = "ignore";
         this.buttonTampilkan.Text = "Tampilkan";
         this.buttonTampilkan.UseVisualStyleBackColor = true;
         this.buttonTampilkan.Click += new System.EventHandler(this.buttonTampilkan_Click);
         // 
         // label3
         // 
         this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(73, 38);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(10, 13);
         this.label3.TabIndex = 2;
         this.label3.Text = ":";
         // 
         // label4
         // 
         this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(73, 68);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(10, 13);
         this.label4.TabIndex = 2;
         this.label4.Text = ":";
         // 
         // DateTimePickerFilterData
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.groupBox1);
         this.Name = "DateTimePickerFilterData";
         this.Size = new System.Drawing.Size(446, 145);
         this.groupBox1.ResumeLayout(false);
         this.tableLayoutPanel1.ResumeLayout(false);
         this.tableLayoutPanel1.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
      private System.Windows.Forms.RadioButton radioButtonSemua;
      private System.Windows.Forms.RadioButton radioButtonTanggal;
      private System.Windows.Forms.RadioButton radioButtonPeriode;
      private System.Windows.Forms.DateTimePicker dateTimePickerTanggal;
      private System.Windows.Forms.DateTimePicker dateTimePickerPeriodeAwal;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.DateTimePicker dateTimePickerPeriodeAkhir;
      private System.Windows.Forms.Button buttonTampilkan;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
   }
}
