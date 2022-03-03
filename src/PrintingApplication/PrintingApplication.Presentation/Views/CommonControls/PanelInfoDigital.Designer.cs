namespace PrintingApplication.Presentation.Views.CommonControls
{
   partial class PanelInfoDigital
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
         this.labelInfo = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // labelInfo
         // 
         this.labelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
         this.labelInfo.Font = new System.Drawing.Font("Digital-7 Italic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelInfo.ForeColor = System.Drawing.Color.Yellow;
         this.labelInfo.Location = new System.Drawing.Point(0, 0);
         this.labelInfo.Name = "labelInfo";
         this.labelInfo.Size = new System.Drawing.Size(422, 55);
         this.labelInfo.TabIndex = 1;
         this.labelInfo.Text = "0";
         this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // PanelInfoDigital
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.Black;
         this.Controls.Add(this.labelInfo);
         this.Name = "PanelInfoDigital";
         this.Size = new System.Drawing.Size(422, 55);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Label labelInfo;
   }
}
