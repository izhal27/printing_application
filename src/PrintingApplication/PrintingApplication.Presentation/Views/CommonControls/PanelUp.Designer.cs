namespace PrintingApplication.Presentation.Views.CommonControls
{
   partial class PanelUp
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
         this.panelInfo = new System.Windows.Forms.Panel();
         this.labelInfo = new System.Windows.Forms.Label();
         this.panelInfo.SuspendLayout();
         this.SuspendLayout();
         // 
         // panelInfo
         // 
         this.panelInfo.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
         this.panelInfo.Controls.Add(this.labelInfo);
         this.panelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
         this.panelInfo.Location = new System.Drawing.Point(0, 0);
         this.panelInfo.Name = "panelInfo";
         this.panelInfo.Size = new System.Drawing.Size(803, 40);
         this.panelInfo.TabIndex = 1;
         // 
         // labelInfo
         // 
         this.labelInfo.AutoSize = true;
         this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelInfo.ForeColor = System.Drawing.SystemColors.Control;
         this.labelInfo.Location = new System.Drawing.Point(12, 10);
         this.labelInfo.Name = "labelInfo";
         this.labelInfo.Size = new System.Drawing.Size(37, 20);
         this.labelInfo.TabIndex = 1;
         this.labelInfo.Text = "Info";
         // 
         // PanelUp
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.panelInfo);
         this.Name = "PanelUp";
         this.Size = new System.Drawing.Size(803, 40);
         this.panelInfo.ResumeLayout(false);
         this.panelInfo.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      protected System.Windows.Forms.Panel panelInfo;
      protected System.Windows.Forms.Label labelInfo;
   }
}
