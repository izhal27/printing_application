namespace PrintingApplication.Presentation.Views.CommonControls
{
   partial class CRUDCButtons
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
         this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
         this.buttonTambah = new System.Windows.Forms.Button();
         this.buttonRefresh = new System.Windows.Forms.Button();
         this.buttonUbah = new System.Windows.Forms.Button();
         this.buttonHapus = new System.Windows.Forms.Button();
         this.buttonTutup = new System.Windows.Forms.Button();
         this.buttonCetak = new System.Windows.Forms.Button();
         this.tlpButtons.SuspendLayout();
         this.SuspendLayout();
         // 
         // tlpButtons
         // 
         this.tlpButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.tlpButtons.BackColor = System.Drawing.SystemColors.Control;
         this.tlpButtons.ColumnCount = 6;
         this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tlpButtons.Controls.Add(this.buttonTambah, 0, 0);
         this.tlpButtons.Controls.Add(this.buttonRefresh, 3, 0);
         this.tlpButtons.Controls.Add(this.buttonUbah, 1, 0);
         this.tlpButtons.Controls.Add(this.buttonHapus, 2, 0);
         this.tlpButtons.Controls.Add(this.buttonTutup, 5, 0);
         this.tlpButtons.Controls.Add(this.buttonCetak, 4, 0);
         this.tlpButtons.Location = new System.Drawing.Point(0, 0);
         this.tlpButtons.Name = "tlpButtons";
         this.tlpButtons.RowCount = 1;
         this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tlpButtons.Size = new System.Drawing.Size(760, 35);
         this.tlpButtons.TabIndex = 3;
         // 
         // buttonTambah
         // 
         this.buttonTambah.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.buttonTambah.Location = new System.Drawing.Point(3, 6);
         this.buttonTambah.Name = "buttonTambah";
         this.buttonTambah.Size = new System.Drawing.Size(75, 23);
         this.buttonTambah.TabIndex = 95;
         this.buttonTambah.Tag = "Tambah";
         this.buttonTambah.Text = "&Tambah";
         this.buttonTambah.UseVisualStyleBackColor = true;
         this.buttonTambah.Click += new System.EventHandler(this.btnTambah_Click);
         // 
         // buttonRefresh
         // 
         this.buttonRefresh.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.buttonRefresh.Location = new System.Drawing.Point(246, 6);
         this.buttonRefresh.Name = "buttonRefresh";
         this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
         this.buttonRefresh.TabIndex = 98;
         this.buttonRefresh.Tag = "ignore";
         this.buttonRefresh.Text = "&Refresh";
         this.buttonRefresh.UseVisualStyleBackColor = true;
         this.buttonRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
         // 
         // buttonUbah
         // 
         this.buttonUbah.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.buttonUbah.Location = new System.Drawing.Point(84, 6);
         this.buttonUbah.Name = "buttonUbah";
         this.buttonUbah.Size = new System.Drawing.Size(75, 23);
         this.buttonUbah.TabIndex = 96;
         this.buttonUbah.Tag = "Ubah";
         this.buttonUbah.Text = "&Ubah";
         this.buttonUbah.UseVisualStyleBackColor = true;
         this.buttonUbah.Click += new System.EventHandler(this.btnUbah_Click);
         // 
         // buttonHapus
         // 
         this.buttonHapus.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.buttonHapus.Location = new System.Drawing.Point(165, 6);
         this.buttonHapus.Name = "buttonHapus";
         this.buttonHapus.Size = new System.Drawing.Size(75, 23);
         this.buttonHapus.TabIndex = 97;
         this.buttonHapus.Tag = "Hapus";
         this.buttonHapus.Text = "&Hapus";
         this.buttonHapus.UseVisualStyleBackColor = true;
         this.buttonHapus.Click += new System.EventHandler(this.btnHapus_Click);
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
         this.buttonTutup.Click += new System.EventHandler(this.btnTutup_Click);
         // 
         // buttonCetak
         // 
         this.buttonCetak.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.buttonCetak.Location = new System.Drawing.Point(327, 6);
         this.buttonCetak.Name = "buttonCetak";
         this.buttonCetak.Size = new System.Drawing.Size(75, 23);
         this.buttonCetak.TabIndex = 99;
         this.buttonCetak.Tag = "Cetak";
         this.buttonCetak.Text = "&Cetak";
         this.buttonCetak.UseVisualStyleBackColor = true;
         this.buttonCetak.Click += new System.EventHandler(this.btnCetak_Click);
         // 
         // CRUDCButtons
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.Transparent;
         this.Controls.Add(this.tlpButtons);
         this.Name = "CRUDCButtons";
         this.Size = new System.Drawing.Size(760, 35);
         this.tlpButtons.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      protected System.Windows.Forms.TableLayoutPanel tlpButtons;
      protected System.Windows.Forms.Button buttonTambah;
      protected System.Windows.Forms.Button buttonRefresh;
      protected System.Windows.Forms.Button buttonUbah;
      protected System.Windows.Forms.Button buttonHapus;
      protected System.Windows.Forms.Button buttonTutup;
      protected System.Windows.Forms.Button buttonCetak;
   }
}
