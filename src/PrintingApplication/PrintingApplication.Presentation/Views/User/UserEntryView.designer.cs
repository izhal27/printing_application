namespace PrintingApplication.Presentation.Views.User
{
   partial class UserEntryView
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
         this.textBoxLoginID = new PrintingApplication.Presentation.Views.CommonControls.BaseTextBox();
         this.label4 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.textBoxPassword = new PrintingApplication.Presentation.Views.CommonControls.BaseTextBox();
         this.comboBoxRole = new PrintingApplication.Presentation.Views.ModelControls.ComboBoxRole();
         this.label6 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.label8 = new System.Windows.Forms.Label();
         this.label9 = new System.Windows.Forms.Label();
         this.buttonShowPassword = new System.Windows.Forms.Button();
         this.groupBoxData.SuspendLayout();
         this.tableLayoutPanel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.textBoxLoginID)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.textBoxPassword)).BeginInit();
         this.SuspendLayout();
         // 
         // panelUp
         // 
         this.panelUp.Size = new System.Drawing.Size(495, 40);
         // 
         // operationButtons
         // 
         this.operationButtons.Location = new System.Drawing.Point(227, 179);
         // 
         // groupBoxData
         // 
         this.groupBoxData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.groupBoxData.Controls.Add(this.tableLayoutPanel1);
         this.groupBoxData.Location = new System.Drawing.Point(12, 58);
         this.groupBoxData.Name = "groupBoxData";
         this.groupBoxData.Size = new System.Drawing.Size(390, 115);
         this.groupBoxData.TabIndex = 4;
         this.groupBoxData.TabStop = false;
         this.groupBoxData.Text = "[ DATA ]";
         // 
         // tableLayoutPanel1
         // 
         this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.tableLayoutPanel1.ColumnCount = 5;
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
         this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
         this.tableLayoutPanel1.Controls.Add(this.label2, 3, 0);
         this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
         this.tableLayoutPanel1.Controls.Add(this.textBoxLoginID, 2, 0);
         this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
         this.tableLayoutPanel1.Controls.Add(this.label5, 1, 1);
         this.tableLayoutPanel1.Controls.Add(this.textBoxPassword, 2, 1);
         this.tableLayoutPanel1.Controls.Add(this.comboBoxRole, 2, 2);
         this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
         this.tableLayoutPanel1.Controls.Add(this.label7, 3, 1);
         this.tableLayoutPanel1.Controls.Add(this.label8, 3, 2);
         this.tableLayoutPanel1.Controls.Add(this.label9, 1, 2);
         this.tableLayoutPanel1.Controls.Add(this.buttonShowPassword, 4, 1);
         this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
         this.tableLayoutPanel1.Name = "tableLayoutPanel1";
         this.tableLayoutPanel1.RowCount = 3;
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.tableLayoutPanel1.Size = new System.Drawing.Size(378, 90);
         this.tableLayoutPanel1.TabIndex = 0;
         // 
         // label1
         // 
         this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(3, 8);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(47, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "Login ID";
         // 
         // label2
         // 
         this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label2.AutoSize = true;
         this.label2.ForeColor = System.Drawing.Color.Red;
         this.label2.Location = new System.Drawing.Point(334, 8);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(11, 13);
         this.label2.TabIndex = 0;
         this.label2.Text = "*";
         // 
         // label3
         // 
         this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(3, 38);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(53, 13);
         this.label3.TabIndex = 0;
         this.label3.Text = "Password";
         // 
         // textBoxLoginID
         // 
         this.textBoxLoginID.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.textBoxLoginID.BeforeTouchSize = new System.Drawing.Size(250, 20);
         this.textBoxLoginID.Location = new System.Drawing.Point(78, 5);
         this.textBoxLoginID.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
         this.textBoxLoginID.Name = "textBoxLoginID";
         this.textBoxLoginID.Size = new System.Drawing.Size(250, 20);
         this.textBoxLoginID.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
         this.textBoxLoginID.TabIndex = 0;
         // 
         // label4
         // 
         this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(62, 8);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(10, 13);
         this.label4.TabIndex = 0;
         this.label4.Text = ":";
         // 
         // label5
         // 
         this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(62, 38);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(10, 13);
         this.label5.TabIndex = 0;
         this.label5.Text = ":";
         // 
         // textBoxPassword
         // 
         this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.textBoxPassword.BeforeTouchSize = new System.Drawing.Size(250, 20);
         this.textBoxPassword.Location = new System.Drawing.Point(78, 35);
         this.textBoxPassword.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
         this.textBoxPassword.Name = "textBoxPassword";
         this.textBoxPassword.PasswordChar = '●';
         this.textBoxPassword.Size = new System.Drawing.Size(250, 20);
         this.textBoxPassword.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
         this.textBoxPassword.TabIndex = 1;
         this.textBoxPassword.UseSystemPasswordChar = true;
         this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
         this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
         this.textBoxPassword.ImeModeChanged += new System.EventHandler(this.textBoxPassword_ImeModeChanged);
         // 
         // comboBoxRole
         // 
         this.comboBoxRole.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.comboBoxRole.Location = new System.Drawing.Point(78, 64);
         this.comboBoxRole.Name = "comboBoxRole";
         this.comboBoxRole.SelectedItem = null;
         this.comboBoxRole.Size = new System.Drawing.Size(250, 21);
         this.comboBoxRole.TabIndex = 2;
         // 
         // label6
         // 
         this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(3, 68);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(29, 13);
         this.label6.TabIndex = 0;
         this.label6.Text = "Role";
         // 
         // label7
         // 
         this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label7.AutoSize = true;
         this.label7.ForeColor = System.Drawing.Color.Red;
         this.label7.Location = new System.Drawing.Point(334, 38);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(11, 13);
         this.label7.TabIndex = 0;
         this.label7.Text = "*";
         // 
         // label8
         // 
         this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label8.AutoSize = true;
         this.label8.ForeColor = System.Drawing.Color.Red;
         this.label8.Location = new System.Drawing.Point(334, 68);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(11, 13);
         this.label8.TabIndex = 0;
         this.label8.Text = "*";
         // 
         // label9
         // 
         this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label9.AutoSize = true;
         this.label9.Location = new System.Drawing.Point(62, 68);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(10, 13);
         this.label9.TabIndex = 0;
         this.label9.Text = ":";
         // 
         // buttonShowPassword
         // 
         this.buttonShowPassword.Enabled = false;
         this.buttonShowPassword.Image = global::PrintingApplication.Presentation.Properties.Resources.eye_16;
         this.buttonShowPassword.Location = new System.Drawing.Point(351, 33);
         this.buttonShowPassword.Name = "buttonShowPassword";
         this.buttonShowPassword.Size = new System.Drawing.Size(23, 23);
         this.buttonShowPassword.TabIndex = 3;
         this.buttonShowPassword.UseVisualStyleBackColor = true;
         this.buttonShowPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonShowPassword_MouseDown);
         this.buttonShowPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonShowPassword_MouseUp);
         // 
         // UserEntryView
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(414, 226);
         this.Controls.Add(this.groupBoxData);
         this.Name = "UserEntryView";
         this.Tag = "ignore";
         this.Text = "User";
         this.Load += new System.EventHandler(this.UserEntryView_Load);
         this.Controls.SetChildIndex(this.operationButtons, 0);
         this.Controls.SetChildIndex(this.panelUp, 0);
         this.Controls.SetChildIndex(this.groupBoxData, 0);
         this.groupBoxData.ResumeLayout(false);
         this.tableLayoutPanel1.ResumeLayout(false);
         this.tableLayoutPanel1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.textBoxLoginID)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.textBoxPassword)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion
      private System.Windows.Forms.GroupBox groupBoxData;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label3;
      private CommonControls.BaseTextBox textBoxLoginID;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label2;
      private CommonControls.BaseTextBox textBoxPassword;
      private ModelControls.ComboBoxRole comboBoxRole;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.Button buttonShowPassword;
   }
}