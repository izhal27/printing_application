namespace PrintingApplication.Presentation.Views.CommonControls
{
   partial class BaseDataView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseDataView));
            this.panelUp = new PrintingApplication.Presentation.Views.CommonControls.PanelUp();
            this.SuspendLayout();
            // 
            // panelUp
            // 
            this.panelUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUp.LabelInfo = "Data";
            this.panelUp.Location = new System.Drawing.Point(12, 12);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(760, 40);
            this.panelUp.TabIndex = 0;
            this.panelUp.TabStop = false;
            // 
            // BaseDataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.panelUp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BaseDataView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaseDataView";
            this.Load += new System.EventHandler(this.BaseDataView_Load);
            this.ResumeLayout(false);

      }

      #endregion

      protected PanelUp panelUp;
   }
}