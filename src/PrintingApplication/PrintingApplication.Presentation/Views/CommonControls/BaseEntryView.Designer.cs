namespace PrintingApplication.Presentation.Views.CommonControls
{
   partial class BaseEntryView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseEntryView));
            this.panelUp = new PrintingApplication.Presentation.Views.CommonControls.PanelUp();
            this.operationButtons = new PrintingApplication.Presentation.Views.CommonControls.OperationButtons();
            this.SuspendLayout();
            // 
            // panelUp
            // 
            this.panelUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUp.LabelInfo = "Info";
            this.panelUp.Location = new System.Drawing.Point(12, 12);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(460, 40);
            this.panelUp.TabIndex = 2;
            this.panelUp.TabStop = false;
            // 
            // operationButtons
            // 
            this.operationButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.operationButtons.Location = new System.Drawing.Point(297, 315);
            this.operationButtons.Name = "operationButtons";
            this.operationButtons.Size = new System.Drawing.Size(175, 35);
            this.operationButtons.TabIndex = 3;
            // 
            // BaseEntryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 362);
            this.Controls.Add(this.operationButtons);
            this.Controls.Add(this.panelUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BaseEntryView";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaseEntryView";
            this.Load += new System.EventHandler(this.BaseEntryView_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BaseEntryView_KeyDown);
            this.ResumeLayout(false);

      }

      #endregion

      protected PanelUp panelUp;
      protected OperationButtons operationButtons;
   }
}