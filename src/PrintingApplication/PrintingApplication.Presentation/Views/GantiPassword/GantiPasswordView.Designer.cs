namespace PrintingApplication.Presentation.Views.GantiPassword
{
   partial class GantiPasswordView
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
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.checkBoxShowCharacters = new System.Windows.Forms.CheckBox();
         this.textBoxPasswordSekarang = new PrintingApplication.Presentation.Views.CommonControls.BaseTextBox();
         this.textBoxPasswordBaru = new PrintingApplication.Presentation.Views.CommonControls.BaseTextBox();
         this.textBoxKonfPasswordBaru = new PrintingApplication.Presentation.Views.CommonControls.BaseTextBox();
         this.groupBox1.SuspendLayout();
         this.tableLayoutPanel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.textBoxPasswordSekarang)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.textBoxPasswordBaru)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.textBoxKonfPasswordBaru)).BeginInit();
         this.SuspendLayout();
         // 
         // panelUp
         // 
         this.panelUp.Size = new System.Drawing.Size(336, 40);
         // 
         // operationButtons
         // 
         this.operationButtons.Location = new System.Drawing.Point(173, 209);
         // 
         // groupBox1
         // 
         this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.groupBox1.Controls.Add(this.tableLayoutPanel1);
         this.groupBox1.Location = new System.Drawing.Point(12, 58);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(336, 145);
         this.groupBox1.TabIndex = 104;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "[ DATA ]";
         // 
         // tableLayoutPanel1
         // 
         this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.tableLayoutPanel1.ColumnCount = 2;
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
         this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
         this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
         this.tableLayoutPanel1.Controls.Add(this.checkBoxShowCharacters, 1, 3);
         this.tableLayoutPanel1.Controls.Add(this.textBoxPasswordSekarang, 1, 0);
         this.tableLayoutPanel1.Controls.Add(this.textBoxPasswordBaru, 1, 1);
         this.tableLayoutPanel1.Controls.Add(this.textBoxKonfPasswordBaru, 1, 2);
         this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
         this.tableLayoutPanel1.Name = "tableLayoutPanel1";
         this.tableLayoutPanel1.RowCount = 4;
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
         this.tableLayoutPanel1.Size = new System.Drawing.Size(324, 120);
         this.tableLayoutPanel1.TabIndex = 0;
         // 
         // label1
         // 
         this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(3, 8);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(102, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "Password Sekarang";
         // 
         // label2
         // 
         this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(3, 38);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(78, 13);
         this.label2.TabIndex = 0;
         this.label2.Text = "Password Baru";
         // 
         // label3
         // 
         this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(3, 68);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(106, 13);
         this.label3.TabIndex = 0;
         this.label3.Text = "Konf. Password Baru";
         // 
         // checkBoxShowCharacters
         // 
         this.checkBoxShowCharacters.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.checkBoxShowCharacters.AutoSize = true;
         this.checkBoxShowCharacters.Location = new System.Drawing.Point(115, 96);
         this.checkBoxShowCharacters.Name = "checkBoxShowCharacters";
         this.checkBoxShowCharacters.Size = new System.Drawing.Size(106, 17);
         this.checkBoxShowCharacters.TabIndex = 3;
         this.checkBoxShowCharacters.Text = "Show characters";
         this.checkBoxShowCharacters.UseVisualStyleBackColor = true;
         this.checkBoxShowCharacters.CheckedChanged += new System.EventHandler(this.checkBoxShowCharacters_CheckedChanged);
         // 
         // textBoxPasswordSekarang
         // 
         this.textBoxPasswordSekarang.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.textBoxPasswordSekarang.BeforeTouchSize = new System.Drawing.Size(200, 20);
         this.textBoxPasswordSekarang.Location = new System.Drawing.Point(115, 5);
         this.textBoxPasswordSekarang.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
         this.textBoxPasswordSekarang.Name = "textBoxPasswordSekarang";
         this.textBoxPasswordSekarang.PasswordChar = '●';
         this.textBoxPasswordSekarang.Size = new System.Drawing.Size(200, 20);
         this.textBoxPasswordSekarang.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
         this.textBoxPasswordSekarang.TabIndex = 0;
         this.textBoxPasswordSekarang.UseSystemPasswordChar = true;
         this.textBoxPasswordSekarang.ImeModeChanged += new System.EventHandler(this.textBox_ImeModeChanged);
         // 
         // textBoxPasswordBaru
         // 
         this.textBoxPasswordBaru.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.textBoxPasswordBaru.BeforeTouchSize = new System.Drawing.Size(200, 20);
         this.textBoxPasswordBaru.Location = new System.Drawing.Point(115, 35);
         this.textBoxPasswordBaru.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
         this.textBoxPasswordBaru.Name = "textBoxPasswordBaru";
         this.textBoxPasswordBaru.PasswordChar = '●';
         this.textBoxPasswordBaru.Size = new System.Drawing.Size(200, 20);
         this.textBoxPasswordBaru.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
         this.textBoxPasswordBaru.TabIndex = 1;
         this.textBoxPasswordBaru.UseSystemPasswordChar = true;
         this.textBoxPasswordBaru.ImeModeChanged += new System.EventHandler(this.textBox_ImeModeChanged);
         // 
         // textBoxKonfPasswordBaru
         // 
         this.textBoxKonfPasswordBaru.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.textBoxKonfPasswordBaru.BeforeTouchSize = new System.Drawing.Size(200, 20);
         this.textBoxKonfPasswordBaru.Location = new System.Drawing.Point(115, 65);
         this.textBoxKonfPasswordBaru.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
         this.textBoxKonfPasswordBaru.Name = "textBoxKonfPasswordBaru";
         this.textBoxKonfPasswordBaru.PasswordChar = '●';
         this.textBoxKonfPasswordBaru.Size = new System.Drawing.Size(200, 20);
         this.textBoxKonfPasswordBaru.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
         this.textBoxKonfPasswordBaru.TabIndex = 2;
         this.textBoxKonfPasswordBaru.UseSystemPasswordChar = true;
         this.textBoxKonfPasswordBaru.ImeModeChanged += new System.EventHandler(this.textBox_ImeModeChanged);
         // 
         // GantiPasswordView
         // 
         this.AccessibleName = "Operasi";
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(360, 256);
         this.Controls.Add(this.groupBox1);
         this.Name = "GantiPasswordView";
         this.Tag = "ignore";
         this.Text = "Ganti Password";
         this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GantiPasswordView_KeyDown);
         this.Controls.SetChildIndex(this.panelUp, 0);
         this.Controls.SetChildIndex(this.operationButtons, 0);
         this.Controls.SetChildIndex(this.groupBox1, 0);
         this.groupBox1.ResumeLayout(false);
         this.tableLayoutPanel1.ResumeLayout(false);
         this.tableLayoutPanel1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.textBoxPasswordSekarang)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.textBoxPasswordBaru)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.textBoxKonfPasswordBaru)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.CheckBox checkBoxShowCharacters;
      private CommonControls.BaseTextBox textBoxPasswordSekarang;
      private CommonControls.BaseTextBox textBoxPasswordBaru;
      private CommonControls.BaseTextBox textBoxKonfPasswordBaru;
   }
}