namespace PrintingApplication.Presentation.Views.Database
{
   partial class BackupRestoreDatabaseView
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupRestoreDatabaseView));
         this.gbData = new System.Windows.Forms.GroupBox();
         this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
         this.label1 = new System.Windows.Forms.Label();
         this.buttonLokasi = new System.Windows.Forms.Button();
         this.textBoxLokasi = new PrintingApplication.Presentation.Views.CommonControls.BaseTextBox();
         this.panelUp = new PrintingApplication.Presentation.Views.CommonControls.PanelUp();
         this.operationButtons = new PrintingApplication.Presentation.Views.CommonControls.OperationButtons();
         this.gbData.SuspendLayout();
         this.tableLayoutPanel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.textBoxLokasi)).BeginInit();
         this.SuspendLayout();
         // 
         // gbData
         // 
         this.gbData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.gbData.Controls.Add(this.tableLayoutPanel1);
         this.gbData.Location = new System.Drawing.Point(12, 58);
         this.gbData.Name = "gbData";
         this.gbData.Size = new System.Drawing.Size(418, 55);
         this.gbData.TabIndex = 104;
         this.gbData.TabStop = false;
         this.gbData.Text = "[ DATA ]";
         // 
         // tableLayoutPanel1
         // 
         this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.tableLayoutPanel1.ColumnCount = 3;
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 385F));
         this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
         this.tableLayoutPanel1.Controls.Add(this.buttonLokasi, 2, 0);
         this.tableLayoutPanel1.Controls.Add(this.textBoxLokasi, 1, 0);
         this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
         this.tableLayoutPanel1.Name = "tableLayoutPanel1";
         this.tableLayoutPanel1.RowCount = 1;
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tableLayoutPanel1.Size = new System.Drawing.Size(406, 30);
         this.tableLayoutPanel1.TabIndex = 0;
         // 
         // label1
         // 
         this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(3, 8);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(57, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "Lokasi File";
         // 
         // buttonLokasi
         // 
         this.buttonLokasi.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.buttonLokasi.Location = new System.Drawing.Point(372, 3);
         this.buttonLokasi.Name = "buttonLokasi";
         this.buttonLokasi.Size = new System.Drawing.Size(25, 23);
         this.buttonLokasi.TabIndex = 1;
         this.buttonLokasi.Tag = "ignore";
         this.buttonLokasi.Text = "...";
         this.buttonLokasi.UseVisualStyleBackColor = true;
         this.buttonLokasi.Click += new System.EventHandler(this.buttonLokasi_Click);
         // 
         // textBoxLokasi
         // 
         this.textBoxLokasi.BeforeTouchSize = new System.Drawing.Size(300, 20);
         this.textBoxLokasi.Location = new System.Drawing.Point(66, 3);
         this.textBoxLokasi.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
         this.textBoxLokasi.Name = "textBoxLokasi";
         this.textBoxLokasi.ReadOnly = true;
         this.textBoxLokasi.Size = new System.Drawing.Size(300, 20);
         this.textBoxLokasi.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
         this.textBoxLokasi.TabIndex = 0;
         // 
         // panelUp
         // 
         this.panelUp.LabelInfo = "Info";
         this.panelUp.Location = new System.Drawing.Point(12, 12);
         this.panelUp.Name = "panelUp";
         this.panelUp.Size = new System.Drawing.Size(460, 40);
         this.panelUp.TabIndex = 105;
         this.panelUp.TabStop = false;
         // 
         // operationButtons
         // 
         this.operationButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.operationButtons.Location = new System.Drawing.Point(230, 119);
         this.operationButtons.Name = "operationButtons";
         this.operationButtons.Size = new System.Drawing.Size(200, 35);
         this.operationButtons.TabIndex = 106;
         // 
         // BackupRestoreDatabaseView
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(442, 166);
         this.Controls.Add(this.operationButtons);
         this.Controls.Add(this.panelUp);
         this.Controls.Add(this.gbData);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "BackupRestoreDatabaseView";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Tag = "ignore";
         this.Text = "Database";
         this.Load += new System.EventHandler(this.BackupRestoreDatabaseView_Load);
         this.gbData.ResumeLayout(false);
         this.tableLayoutPanel1.ResumeLayout(false);
         this.tableLayoutPanel1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.textBoxLokasi)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      protected System.Windows.Forms.GroupBox gbData;
      protected System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
      protected System.Windows.Forms.Label label1;
      protected System.Windows.Forms.Button buttonLokasi;
      private CommonControls.PanelUp panelUp;
      private CommonControls.OperationButtons operationButtons;
      private CommonControls.BaseTextBox textBoxLokasi;
   }
}