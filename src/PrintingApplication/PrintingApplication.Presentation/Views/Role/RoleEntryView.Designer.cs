namespace PrintingApplication.Presentation.Views.Role
{
   partial class RoleEntryView
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
         this.groupBoxData = new System.Windows.Forms.GroupBox();
         this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.textBoxNama = new PrintingApplication.Presentation.Views.CommonControls.BaseTextBox();
         this.textBoxKeterangan = new PrintingApplication.Presentation.Views.CommonControls.BaseTextBox();
         this.label4 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.textBoxKode = new PrintingApplication.Presentation.Views.CommonControls.BaseTextBox();
         this.label7 = new System.Windows.Forms.Label();
         this.label8 = new System.Windows.Forms.Label();
         this.groupBoxData.SuspendLayout();
         this.tableLayoutPanel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.textBoxNama)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.textBoxKeterangan)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.textBoxKode)).BeginInit();
         this.SuspendLayout();
         // 
         // panelUp
         // 
         this.panelUp.Size = new System.Drawing.Size(373, 40);
         // 
         // operationButtons
         // 
         this.operationButtons.Location = new System.Drawing.Point(210, 251);
         // 
         // groupBoxData
         // 
         this.groupBoxData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.groupBoxData.Controls.Add(this.tableLayoutPanel1);
         this.groupBoxData.Location = new System.Drawing.Point(12, 58);
         this.groupBoxData.Name = "groupBoxData";
         this.groupBoxData.Size = new System.Drawing.Size(373, 187);
         this.groupBoxData.TabIndex = 5;
         this.groupBoxData.TabStop = false;
         this.groupBoxData.Text = "[ DATA ]";
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
         this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
         this.tableLayoutPanel1.Controls.Add(this.label2, 3, 1);
         this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
         this.tableLayoutPanel1.Controls.Add(this.textBoxNama, 2, 1);
         this.tableLayoutPanel1.Controls.Add(this.textBoxKeterangan, 2, 2);
         this.tableLayoutPanel1.Controls.Add(this.label4, 1, 1);
         this.tableLayoutPanel1.Controls.Add(this.label5, 1, 2);
         this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
         this.tableLayoutPanel1.Controls.Add(this.textBoxKode, 2, 0);
         this.tableLayoutPanel1.Controls.Add(this.label7, 3, 0);
         this.tableLayoutPanel1.Controls.Add(this.label8, 1, 0);
         this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
         this.tableLayoutPanel1.Name = "tableLayoutPanel1";
         this.tableLayoutPanel1.RowCount = 3;
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
         this.tableLayoutPanel1.Size = new System.Drawing.Size(361, 162);
         this.tableLayoutPanel1.TabIndex = 0;
         // 
         // label1
         // 
         this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(3, 32);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(35, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "Nama";
         // 
         // label2
         // 
         this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label2.AutoSize = true;
         this.label2.ForeColor = System.Drawing.Color.Red;
         this.label2.Location = new System.Drawing.Point(343, 32);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(11, 13);
         this.label2.TabIndex = 0;
         this.label2.Text = "*";
         // 
         // label3
         // 
         this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(3, 100);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(62, 13);
         this.label3.TabIndex = 0;
         this.label3.Text = "Keterangan";
         // 
         // textBoxNama
         // 
         this.textBoxNama.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.textBoxNama.BeforeTouchSize = new System.Drawing.Size(250, 20);
         this.textBoxNama.Location = new System.Drawing.Point(87, 29);
         this.textBoxNama.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
         this.textBoxNama.Name = "textBoxNama";
         this.textBoxNama.Size = new System.Drawing.Size(250, 20);
         this.textBoxNama.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
         this.textBoxNama.TabIndex = 1;
         // 
         // textBoxKeterangan
         // 
         this.textBoxKeterangan.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.textBoxKeterangan.BeforeTouchSize = new System.Drawing.Size(250, 20);
         this.textBoxKeterangan.Location = new System.Drawing.Point(87, 57);
         this.textBoxKeterangan.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
         this.textBoxKeterangan.Multiline = true;
         this.textBoxKeterangan.Name = "textBoxKeterangan";
         this.textBoxKeterangan.Size = new System.Drawing.Size(250, 100);
         this.textBoxKeterangan.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
         this.textBoxKeterangan.TabIndex = 2;
         // 
         // label4
         // 
         this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(71, 32);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(10, 13);
         this.label4.TabIndex = 0;
         this.label4.Text = ":";
         // 
         // label5
         // 
         this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(71, 100);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(10, 13);
         this.label5.TabIndex = 0;
         this.label5.Text = ":";
         // 
         // label6
         // 
         this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(3, 6);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(32, 13);
         this.label6.TabIndex = 0;
         this.label6.Text = "Kode";
         // 
         // textBoxKode
         // 
         this.textBoxKode.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.textBoxKode.BeforeTouchSize = new System.Drawing.Size(250, 20);
         this.textBoxKode.Location = new System.Drawing.Point(87, 3);
         this.textBoxKode.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
         this.textBoxKode.Name = "textBoxKode";
         this.textBoxKode.Size = new System.Drawing.Size(250, 20);
         this.textBoxKode.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
         this.textBoxKode.TabIndex = 0;
         // 
         // label7
         // 
         this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label7.AutoSize = true;
         this.label7.ForeColor = System.Drawing.Color.Red;
         this.label7.Location = new System.Drawing.Point(343, 6);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(11, 13);
         this.label7.TabIndex = 0;
         this.label7.Text = "*";
         // 
         // label8
         // 
         this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(71, 6);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(10, 13);
         this.label8.TabIndex = 0;
         this.label8.Text = ":";
         // 
         // RoleEntryView
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(397, 298);
         this.Controls.Add(this.groupBoxData);
         this.Name = "RoleEntryView";
         this.Tag = "ignore";
         this.Text = "Role";
         this.Controls.SetChildIndex(this.panelUp, 0);
         this.Controls.SetChildIndex(this.operationButtons, 0);
         this.Controls.SetChildIndex(this.groupBoxData, 0);
         this.groupBoxData.ResumeLayout(false);
         this.tableLayoutPanel1.ResumeLayout(false);
         this.tableLayoutPanel1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.textBoxNama)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.textBoxKeterangan)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.textBoxKode)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox groupBoxData;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private CommonControls.BaseTextBox textBoxNama;
      private CommonControls.BaseTextBox textBoxKeterangan;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label6;
      private CommonControls.BaseTextBox textBoxKode;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.Label label8;
   }
}