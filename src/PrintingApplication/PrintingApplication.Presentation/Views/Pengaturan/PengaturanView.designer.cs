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
         this.propertyGrid = new System.Windows.Forms.PropertyGrid();
         this.buttonSave = new System.Windows.Forms.Button();
         this.buttonDefault = new System.Windows.Forms.Button();
         this.buttonCancel = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // propertyGrid
         // 
         this.propertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.propertyGrid.Location = new System.Drawing.Point(0, 0);
         this.propertyGrid.Name = "propertyGrid";
         this.propertyGrid.Size = new System.Drawing.Size(369, 330);
         this.propertyGrid.TabIndex = 0;
         // 
         // buttonSave
         // 
         this.buttonSave.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.buttonSave.Location = new System.Drawing.Point(0, 336);
         this.buttonSave.Name = "buttonSave";
         this.buttonSave.Size = new System.Drawing.Size(369, 35);
         this.buttonSave.TabIndex = 1;
         this.buttonSave.Text = "&Save";
         this.buttonSave.UseVisualStyleBackColor = true;
         this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
         // 
         // buttonDefault
         // 
         this.buttonDefault.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.buttonDefault.Location = new System.Drawing.Point(0, 371);
         this.buttonDefault.Name = "buttonDefault";
         this.buttonDefault.Size = new System.Drawing.Size(369, 35);
         this.buttonDefault.TabIndex = 2;
         this.buttonDefault.Text = "&Default Style";
         this.buttonDefault.UseVisualStyleBackColor = true;
         this.buttonDefault.Click += new System.EventHandler(this.buttonDefault_Click);
         // 
         // buttonCancel
         // 
         this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.buttonCancel.Location = new System.Drawing.Point(0, 406);
         this.buttonCancel.Name = "buttonCancel";
         this.buttonCancel.Size = new System.Drawing.Size(369, 35);
         this.buttonCancel.TabIndex = 3;
         this.buttonCancel.Text = "&Cancel";
         this.buttonCancel.UseVisualStyleBackColor = true;
         // 
         // PengaturanView
         // 
         this.AccessibleName = "Alat";
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(369, 441);
         this.Controls.Add(this.buttonSave);
         this.Controls.Add(this.buttonDefault);
         this.Controls.Add(this.propertyGrid);
         this.Controls.Add(this.buttonCancel);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "PengaturanView";
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Pengaturan";
         this.Load += new System.EventHandler(this.PengaturanView_Load);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.PropertyGrid propertyGrid;
      private System.Windows.Forms.Button buttonSave;
      private System.Windows.Forms.Button buttonDefault;
      private System.Windows.Forms.Button buttonCancel;
   }
}