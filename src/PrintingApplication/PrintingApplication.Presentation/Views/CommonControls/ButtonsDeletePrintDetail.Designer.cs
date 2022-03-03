namespace PrintingApplication.Presentation.Views.CommonControls
{
   partial class ButtonsDeletePrintDetail
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
         this.buttonHapus = new System.Windows.Forms.Button();
         this.buttonTutup = new System.Windows.Forms.Button();
         this.buttonCetak = new System.Windows.Forms.Button();
         this.buttonDetail = new System.Windows.Forms.Button();
         this.tlpButtons.SuspendLayout();
         this.SuspendLayout();
         // 
         // tlpButtons
         // 
         this.tlpButtons.BackColor = System.Drawing.SystemColors.Control;
         this.tlpButtons.ColumnCount = 4;
         this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.tlpButtons.Controls.Add(this.buttonHapus, 0, 0);
         this.tlpButtons.Controls.Add(this.buttonTutup, 3, 0);
         this.tlpButtons.Controls.Add(this.buttonCetak, 1, 0);
         this.tlpButtons.Controls.Add(this.buttonDetail, 2, 0);
         this.tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tlpButtons.Location = new System.Drawing.Point(0, 0);
         this.tlpButtons.Name = "tlpButtons";
         this.tlpButtons.RowCount = 1;
         this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tlpButtons.Size = new System.Drawing.Size(760, 35);
         this.tlpButtons.TabIndex = 4;
         // 
         // buttonHapus
         // 
         this.buttonHapus.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.buttonHapus.Location = new System.Drawing.Point(3, 6);
         this.buttonHapus.Name = "buttonHapus";
         this.buttonHapus.Size = new System.Drawing.Size(75, 23);
         this.buttonHapus.TabIndex = 97;
         this.buttonHapus.Tag = "Hapus";
         this.buttonHapus.Text = "&Hapus";
         this.buttonHapus.UseVisualStyleBackColor = true;
         this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
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
         this.buttonCetak.Location = new System.Drawing.Point(84, 6);
         this.buttonCetak.Name = "buttonCetak";
         this.buttonCetak.Size = new System.Drawing.Size(75, 23);
         this.buttonCetak.TabIndex = 98;
         this.buttonCetak.Tag = "Cetak";
         this.buttonCetak.Text = "&Cetak";
         this.buttonCetak.UseVisualStyleBackColor = true;
         this.buttonCetak.Click += new System.EventHandler(this.buttonCetak_Click);
         // 
         // buttonDetail
         // 
         this.buttonDetail.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.buttonDetail.Location = new System.Drawing.Point(165, 6);
         this.buttonDetail.Name = "buttonDetail";
         this.buttonDetail.Size = new System.Drawing.Size(75, 23);
         this.buttonDetail.TabIndex = 99;
         this.buttonDetail.Tag = "Detail";
         this.buttonDetail.Text = "&Detail";
         this.buttonDetail.UseVisualStyleBackColor = true;
         this.buttonDetail.Click += new System.EventHandler(this.buttonDetail_Click);
         // 
         // ButtonsDeletePrintDetail
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.tlpButtons);
         this.Name = "ButtonsDeletePrintDetail";
         this.Size = new System.Drawing.Size(760, 35);
         this.tlpButtons.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      protected System.Windows.Forms.TableLayoutPanel tlpButtons;
      protected System.Windows.Forms.Button buttonDetail;
      protected System.Windows.Forms.Button buttonHapus;
      protected System.Windows.Forms.Button buttonTutup;
      protected System.Windows.Forms.Button buttonCetak;
   }
}
