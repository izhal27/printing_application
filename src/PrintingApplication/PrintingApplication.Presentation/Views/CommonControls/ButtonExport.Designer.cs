namespace PrintingApplication.Presentation.Views.CommonControls
{
   partial class ButtonExport
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
         Syncfusion.Windows.Forms.Tools.SplitButtonRenderer splitButtonRenderer1 = new Syncfusion.Windows.Forms.Tools.SplitButtonRenderer();
         this.splitButtonExport = new Syncfusion.Windows.Forms.Tools.SplitButton();
         this.buttonExcel = new Syncfusion.Windows.Forms.Tools.toolstripitem();
         this.buttonPDF = new Syncfusion.Windows.Forms.Tools.toolstripitem();
         this.SuspendLayout();
         // 
         // splitButtonExport
         // 
         this.splitButtonExport.BackColor = System.Drawing.SystemColors.Control;
         this.splitButtonExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
         this.splitButtonExport.BeforeTouchSize = new System.Drawing.Size(75, 23);
         this.splitButtonExport.Dock = System.Windows.Forms.DockStyle.Fill;
         this.splitButtonExport.DropDownItems.Add(this.buttonExcel);
         this.splitButtonExport.DropDownItems.Add(this.buttonPDF);
         this.splitButtonExport.DropDownPosition = Syncfusion.Windows.Forms.Tools.Position.Bottom;
         this.splitButtonExport.ForeColor = System.Drawing.Color.Black;
         this.splitButtonExport.Location = new System.Drawing.Point(0, 0);
         this.splitButtonExport.MinimumSize = new System.Drawing.Size(75, 23);
         this.splitButtonExport.Name = "splitButtonExport";
         splitButtonRenderer1.SplitButton = this.splitButtonExport;
         this.splitButtonExport.Renderer = splitButtonRenderer1;
         this.splitButtonExport.ShowDropDownOnButtonClick = false;
         this.splitButtonExport.Size = new System.Drawing.Size(75, 23);
         this.splitButtonExport.Style = Syncfusion.Windows.Forms.Tools.SplitButtonVisualStyle.Default;
         this.splitButtonExport.TabIndex = 0;
         this.splitButtonExport.Text = "Export";
         this.splitButtonExport.DropDowItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.splitButtonExport_DropDowItemClicked);
         // 
         // buttonExcel
         // 
         this.buttonExcel.Name = "buttonExcel";
         this.buttonExcel.Size = new System.Drawing.Size(23, 23);
         this.buttonExcel.Text = "Excel";
         // 
         // buttonPDF
         // 
         this.buttonPDF.Name = "buttonPDF";
         this.buttonPDF.Size = new System.Drawing.Size(23, 23);
         this.buttonPDF.Text = "PDF";
         // 
         // ButtonExport
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.splitButtonExport);
         this.Name = "ButtonExport";
         this.Size = new System.Drawing.Size(75, 23);
         this.ResumeLayout(false);

      }

      #endregion

      private Syncfusion.Windows.Forms.Tools.SplitButton splitButtonExport;
      private Syncfusion.Windows.Forms.Tools.toolstripitem buttonExcel;
      private Syncfusion.Windows.Forms.Tools.toolstripitem buttonPDF;
   }
}
