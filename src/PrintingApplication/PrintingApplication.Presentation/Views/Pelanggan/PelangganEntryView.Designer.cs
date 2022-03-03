namespace PrintingApplication.Presentation.Views.Pelanggan
{
   partial class PelangganEntryView
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
         this.label1 = new System.Windows.Forms.Label();
         this.textBoxNama = new PrintingApplication.Presentation.Views.CommonControls.BaseTextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.textBoxAlamat = new PrintingApplication.Presentation.Views.CommonControls.BaseTextBox();
         this.textBoxTelpon = new PrintingApplication.Presentation.Views.CommonControls.BaseTextBox();
         this.textBoxKeterangan = new PrintingApplication.Presentation.Views.CommonControls.BaseTextBox();
         this.label8 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.label9 = new System.Windows.Forms.Label();
         this.groupBox1.SuspendLayout();
         this.tableLayoutPanel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.textBoxNama)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.textBoxAlamat)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.textBoxTelpon)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.textBoxKeterangan)).BeginInit();
         this.SuspendLayout();
         // 
         // panelUp
         // 
         this.panelUp.Size = new System.Drawing.Size(373, 40);
         // 
         // operationButtons
         // 
         this.operationButtons.Location = new System.Drawing.Point(210, 197);
         // 
         // groupBox1
         // 
         this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.groupBox1.Controls.Add(this.tableLayoutPanel1);
         this.groupBox1.Location = new System.Drawing.Point(12, 58);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(373, 133);
         this.groupBox1.TabIndex = 5;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "[ DATA ]";
         // 
         // tableLayoutPanel1
         // 
         this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.tableLayoutPanel1.ColumnCount = 4;
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
         this.tableLayoutPanel1.Controls.Add(this.textBoxNama, 2, 0);
         this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
         this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
         this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
         this.tableLayoutPanel1.Controls.Add(this.textBoxAlamat, 2, 1);
         this.tableLayoutPanel1.Controls.Add(this.textBoxTelpon, 2, 2);
         this.tableLayoutPanel1.Controls.Add(this.textBoxKeterangan, 2, 3);
         this.tableLayoutPanel1.Controls.Add(this.label8, 3, 0);
         this.tableLayoutPanel1.Controls.Add(this.label5, 1, 0);
         this.tableLayoutPanel1.Controls.Add(this.label6, 1, 1);
         this.tableLayoutPanel1.Controls.Add(this.label7, 1, 2);
         this.tableLayoutPanel1.Controls.Add(this.label9, 1, 3);
         this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
         this.tableLayoutPanel1.Name = "tableLayoutPanel1";
         this.tableLayoutPanel1.RowCount = 4;
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
         this.tableLayoutPanel1.Size = new System.Drawing.Size(361, 108);
         this.tableLayoutPanel1.TabIndex = 0;
         // 
         // label1
         // 
         this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(3, 6);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(35, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "Nama";
         // 
         // textBoxNama
         // 
         this.textBoxNama.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.textBoxNama.BeforeTouchSize = new System.Drawing.Size(250, 20);
         this.textBoxNama.Location = new System.Drawing.Point(87, 3);
         this.textBoxNama.MaxLength = 100;
         this.textBoxNama.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
         this.textBoxNama.Name = "textBoxNama";
         this.textBoxNama.Size = new System.Drawing.Size(250, 20);
         this.textBoxNama.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
         this.textBoxNama.TabIndex = 0;
         // 
         // label2
         // 
         this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(3, 32);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(39, 13);
         this.label2.TabIndex = 0;
         this.label2.Text = "Alamat";
         // 
         // label3
         // 
         this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(3, 58);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(40, 13);
         this.label3.TabIndex = 0;
         this.label3.Text = "Telpon";
         // 
         // label4
         // 
         this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(3, 86);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(62, 13);
         this.label4.TabIndex = 0;
         this.label4.Text = "Keterangan";
         // 
         // textBoxAlamat
         // 
         this.textBoxAlamat.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.textBoxAlamat.BeforeTouchSize = new System.Drawing.Size(250, 20);
         this.textBoxAlamat.Location = new System.Drawing.Point(87, 29);
         this.textBoxAlamat.MaxLength = 200;
         this.textBoxAlamat.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
         this.textBoxAlamat.Name = "textBoxAlamat";
         this.textBoxAlamat.Size = new System.Drawing.Size(250, 20);
         this.textBoxAlamat.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
         this.textBoxAlamat.TabIndex = 1;
         // 
         // textBoxTelpon
         // 
         this.textBoxTelpon.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.textBoxTelpon.BeforeTouchSize = new System.Drawing.Size(250, 20);
         this.textBoxTelpon.Location = new System.Drawing.Point(87, 55);
         this.textBoxTelpon.MaxLength = 30;
         this.textBoxTelpon.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
         this.textBoxTelpon.Name = "textBoxTelpon";
         this.textBoxTelpon.Size = new System.Drawing.Size(250, 20);
         this.textBoxTelpon.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
         this.textBoxTelpon.TabIndex = 2;
         // 
         // textBoxKeterangan
         // 
         this.textBoxKeterangan.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.textBoxKeterangan.BeforeTouchSize = new System.Drawing.Size(250, 20);
         this.textBoxKeterangan.Location = new System.Drawing.Point(87, 83);
         this.textBoxKeterangan.MaxLength = 30;
         this.textBoxKeterangan.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
         this.textBoxKeterangan.Name = "textBoxKeterangan";
         this.textBoxKeterangan.Size = new System.Drawing.Size(250, 20);
         this.textBoxKeterangan.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
         this.textBoxKeterangan.TabIndex = 3;
         // 
         // label8
         // 
         this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label8.AutoSize = true;
         this.label8.ForeColor = System.Drawing.Color.Red;
         this.label8.Location = new System.Drawing.Point(343, 6);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(11, 13);
         this.label8.TabIndex = 0;
         this.label8.Text = "*";
         // 
         // label5
         // 
         this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(71, 6);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(10, 13);
         this.label5.TabIndex = 0;
         this.label5.Text = ":";
         // 
         // label6
         // 
         this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(71, 32);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(10, 13);
         this.label6.TabIndex = 0;
         this.label6.Text = ":";
         // 
         // label7
         // 
         this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(71, 58);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(10, 13);
         this.label7.TabIndex = 0;
         this.label7.Text = ":";
         // 
         // label9
         // 
         this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label9.AutoSize = true;
         this.label9.Location = new System.Drawing.Point(71, 86);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(10, 13);
         this.label9.TabIndex = 0;
         this.label9.Text = ":";
         // 
         // PelangganEntryView
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(397, 244);
         this.Controls.Add(this.groupBox1);
         this.Name = "PelangganEntryView";
         this.Tag = "ignore";
         this.Text = "Pelanggan";
         this.Controls.SetChildIndex(this.panelUp, 0);
         this.Controls.SetChildIndex(this.operationButtons, 0);
         this.Controls.SetChildIndex(this.groupBox1, 0);
         this.groupBox1.ResumeLayout(false);
         this.tableLayoutPanel1.ResumeLayout(false);
         this.tableLayoutPanel1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.textBoxNama)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.textBoxAlamat)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.textBoxTelpon)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.textBoxKeterangan)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
      private System.Windows.Forms.Label label1;
      private CommonControls.BaseTextBox textBoxNama;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private CommonControls.BaseTextBox textBoxAlamat;
      private CommonControls.BaseTextBox textBoxTelpon;
      private CommonControls.BaseTextBox textBoxKeterangan;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.Label label9;
   }
}