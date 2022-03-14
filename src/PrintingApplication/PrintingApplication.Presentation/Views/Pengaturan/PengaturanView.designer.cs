namespace PrintingApplication.Presentation.Views.Pengaturan
{
   partial class PengaturanView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PengaturanView));
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxTipePrinter = new System.Windows.Forms.ComboBox();
            this.pctBoxLogo = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonPilihImage = new System.Windows.Forms.Button();
            this.buttonHapusLogo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pctBoxBackground = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.buttnoPilihImageBackground = new System.Windows.Forms.Button();
            this.buttonHapusBackground = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.textBoxNama = new PrintingApplication.Presentation.Views.CommonControls.BaseTextBox();
            this.textBoxAlamat1 = new PrintingApplication.Presentation.Views.CommonControls.BaseTextBox();
            this.textBoxAlamat2 = new PrintingApplication.Presentation.Views.CommonControls.BaseTextBox();
            this.textBoxContact = new PrintingApplication.Presentation.Views.CommonControls.BaseTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxLogo)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxBackground)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxNama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxAlamat1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxAlamat2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxContact)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonSave.Location = new System.Drawing.Point(8, 5);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(89, 5);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.47368F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.52632F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxNama, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxAlamat1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxAlamat2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxContact, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxTipePrinter, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(380, 208);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Alamat - 1";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Alamat - 2";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Contact";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tipe Printer";
            // 
            // comboBoxTipePrinter
            // 
            this.comboBoxTipePrinter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxTipePrinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipePrinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTipePrinter.FormattingEnabled = true;
            this.comboBoxTipePrinter.Location = new System.Drawing.Point(114, 173);
            this.comboBoxTipePrinter.Name = "comboBoxTipePrinter";
            this.comboBoxTipePrinter.Size = new System.Drawing.Size(247, 26);
            this.comboBoxTipePrinter.TabIndex = 5;
            // 
            // pctBoxLogo
            // 
            this.pctBoxLogo.Location = new System.Drawing.Point(6, 19);
            this.pctBoxLogo.Name = "pctBoxLogo";
            this.pctBoxLogo.Size = new System.Drawing.Size(150, 150);
            this.pctBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoxLogo.TabIndex = 5;
            this.pctBoxLogo.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.buttonPilihImage, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonHapusLogo, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 175);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(150, 30);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // buttonPilihImage
            // 
            this.buttonPilihImage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonPilihImage.Location = new System.Drawing.Point(22, 5);
            this.buttonPilihImage.Name = "buttonPilihImage";
            this.buttonPilihImage.Size = new System.Drawing.Size(50, 20);
            this.buttonPilihImage.TabIndex = 0;
            this.buttonPilihImage.Text = "Pilih";
            this.buttonPilihImage.UseVisualStyleBackColor = true;
            this.buttonPilihImage.Click += new System.EventHandler(this.buttonPilihLogo_Click);
            // 
            // buttonHapusLogo
            // 
            this.buttonHapusLogo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonHapusLogo.Location = new System.Drawing.Point(78, 5);
            this.buttonHapusLogo.Name = "buttonHapusLogo";
            this.buttonHapusLogo.Size = new System.Drawing.Size(50, 20);
            this.buttonHapusLogo.TabIndex = 0;
            this.buttonHapusLogo.Text = "Hapus";
            this.buttonHapusLogo.UseVisualStyleBackColor = true;
            this.buttonHapusLogo.Click += new System.EventHandler(this.buttonHapusLogo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pctBoxLogo);
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Location = new System.Drawing.Point(392, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 208);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[ Logo ]";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.buttonSave, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonCancel, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(374, 485);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(173, 34);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(564, 525);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "[ Data Percetakan ]";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pctBoxBackground);
            this.groupBox3.Controls.Add(this.tableLayoutPanel4);
            this.groupBox3.Location = new System.Drawing.Point(6, 233);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(547, 246);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "[ Background ]";
            // 
            // pctBoxBackground
            // 
            this.pctBoxBackground.Location = new System.Drawing.Point(6, 19);
            this.pctBoxBackground.Name = "pctBoxBackground";
            this.pctBoxBackground.Size = new System.Drawing.Size(535, 185);
            this.pctBoxBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoxBackground.TabIndex = 5;
            this.pctBoxBackground.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.buttnoPilihImageBackground, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.buttonHapusBackground, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(407, 210);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(134, 30);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // buttnoPilihImageBackground
            // 
            this.buttnoPilihImageBackground.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttnoPilihImageBackground.Location = new System.Drawing.Point(14, 5);
            this.buttnoPilihImageBackground.Name = "buttnoPilihImageBackground";
            this.buttnoPilihImageBackground.Size = new System.Drawing.Size(50, 20);
            this.buttnoPilihImageBackground.TabIndex = 0;
            this.buttnoPilihImageBackground.Text = "Pilih";
            this.buttnoPilihImageBackground.UseVisualStyleBackColor = true;
            this.buttnoPilihImageBackground.Click += new System.EventHandler(this.buttnoPilihImageBackground_Click);
            // 
            // buttonHapusBackground
            // 
            this.buttonHapusBackground.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonHapusBackground.Location = new System.Drawing.Point(70, 5);
            this.buttonHapusBackground.Name = "buttonHapusBackground";
            this.buttonHapusBackground.Size = new System.Drawing.Size(50, 20);
            this.buttonHapusBackground.TabIndex = 0;
            this.buttonHapusBackground.Text = "Hapus";
            this.buttonHapusBackground.UseVisualStyleBackColor = true;
            this.buttonHapusBackground.Click += new System.EventHandler(this.buttonHapusBackground_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxNama.BeforeTouchSize = new System.Drawing.Size(247, 24);
            this.textBoxNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNama.Location = new System.Drawing.Point(114, 8);
            this.textBoxNama.MaxLength = 255;
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(247, 24);
            this.textBoxNama.TabIndex = 1;
            // 
            // textBoxAlamat1
            // 
            this.textBoxAlamat1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxAlamat1.BeforeTouchSize = new System.Drawing.Size(247, 24);
            this.textBoxAlamat1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAlamat1.Location = new System.Drawing.Point(114, 49);
            this.textBoxAlamat1.MaxLength = 255;
            this.textBoxAlamat1.Name = "textBoxAlamat1";
            this.textBoxAlamat1.Size = new System.Drawing.Size(247, 24);
            this.textBoxAlamat1.TabIndex = 2;
            // 
            // textBoxAlamat2
            // 
            this.textBoxAlamat2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxAlamat2.BeforeTouchSize = new System.Drawing.Size(247, 24);
            this.textBoxAlamat2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAlamat2.Location = new System.Drawing.Point(114, 90);
            this.textBoxAlamat2.MaxLength = 255;
            this.textBoxAlamat2.Name = "textBoxAlamat2";
            this.textBoxAlamat2.Size = new System.Drawing.Size(247, 24);
            this.textBoxAlamat2.TabIndex = 3;
            // 
            // textBoxContact
            // 
            this.textBoxContact.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxContact.BeforeTouchSize = new System.Drawing.Size(247, 24);
            this.textBoxContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContact.Location = new System.Drawing.Point(114, 131);
            this.textBoxContact.MaxLength = 255;
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(247, 24);
            this.textBoxContact.TabIndex = 4;
            // 
            // PengaturanView
            // 
            this.AccessibleName = "Alat";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 549);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PengaturanView";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pengaturan";
            this.Load += new System.EventHandler(this.PengaturanView_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxLogo)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxBackground)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textBoxNama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxAlamat1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxAlamat2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxContact)).EndInit();
            this.ResumeLayout(false);

      }

      #endregion
      private System.Windows.Forms.Button buttonSave;
      private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private CommonControls.BaseTextBox textBoxNama;
        private CommonControls.BaseTextBox textBoxAlamat1;
        private CommonControls.BaseTextBox textBoxAlamat2;
        private CommonControls.BaseTextBox textBoxContact;
        private System.Windows.Forms.ComboBox comboBoxTipePrinter;
        private System.Windows.Forms.PictureBox pctBoxLogo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonPilihImage;
        private System.Windows.Forms.Button buttonHapusLogo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pctBoxBackground;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button buttnoPilihImageBackground;
        private System.Windows.Forms.Button buttonHapusBackground;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}