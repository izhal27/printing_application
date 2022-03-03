namespace PrintingApplication.Presentation.Views.Login
{
   partial class LoginView
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
      this.groupBoxLogin = new System.Windows.Forms.GroupBox();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.buttonLogin = new System.Windows.Forms.Button();
      this.buttonCancel = new System.Windows.Forms.Button();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.chkBoxShowCharacters = new System.Windows.Forms.CheckBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.textBoxLoginID = new PrintingApplication.Presentation.Views.CommonControls.BaseTextBox();
      this.textBoxPassword = new PrintingApplication.Presentation.Views.CommonControls.BaseTextBox();
      this.tabControlLogin = new System.Windows.Forms.TabControl();
      this.tabPageLogin = new System.Windows.Forms.TabPage();
      this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
      this.tabPageDatabase = new System.Windows.Forms.TabPage();
      this.groupBoxDatabase = new System.Windows.Forms.GroupBox();
      this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
      this.buttonTesKoneksi = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.textBoxDatabase = new PrintingApplication.Presentation.Views.CommonControls.BaseTextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.textBoxPasswordDatabase = new PrintingApplication.Presentation.Views.CommonControls.BaseTextBox();
      this.textBoxUser = new PrintingApplication.Presentation.Views.CommonControls.BaseTextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.textBoxPort = new PrintingApplication.Presentation.Views.CommonControls.BaseTextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.textBoxServer = new PrintingApplication.Presentation.Views.CommonControls.BaseTextBox();
      this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
      this.buttonSimpan = new System.Windows.Forms.Button();
      this.groupBoxLogin.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.textBoxLoginID)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.textBoxPassword)).BeginInit();
      this.tabControlLogin.SuspendLayout();
      this.tabPageLogin.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
      this.tabPageDatabase.SuspendLayout();
      this.groupBoxDatabase.SuspendLayout();
      this.tableLayoutPanel3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.textBoxDatabase)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.textBoxPasswordDatabase)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.textBoxUser)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.textBoxPort)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.textBoxServer)).BeginInit();
      this.tableLayoutPanel4.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBoxLogin
      // 
      this.groupBoxLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBoxLogin.Controls.Add(this.tableLayoutPanel2);
      this.groupBoxLogin.Controls.Add(this.tableLayoutPanel1);
      this.groupBoxLogin.Location = new System.Drawing.Point(167, 6);
      this.groupBoxLogin.Name = "groupBoxLogin";
      this.groupBoxLogin.Size = new System.Drawing.Size(295, 155);
      this.groupBoxLogin.TabIndex = 9;
      this.groupBoxLogin.TabStop = false;
      this.groupBoxLogin.Text = "[ DATA ]";
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 2;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
      this.tableLayoutPanel2.Controls.Add(this.buttonLogin, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.buttonCancel, 1, 0);
      this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 117);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 1;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(282, 30);
      this.tableLayoutPanel2.TabIndex = 8;
      // 
      // buttonLogin
      // 
      this.buttonLogin.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.buttonLogin.Location = new System.Drawing.Point(123, 3);
      this.buttonLogin.Name = "buttonLogin";
      this.buttonLogin.Size = new System.Drawing.Size(75, 23);
      this.buttonLogin.TabIndex = 99;
      this.buttonLogin.Text = "&Login";
      this.buttonLogin.UseVisualStyleBackColor = true;
      this.buttonLogin.Click += new System.EventHandler(this.btnLogin_Click);
      // 
      // buttonCancel
      // 
      this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.buttonCancel.Location = new System.Drawing.Point(204, 3);
      this.buttonCancel.Name = "buttonCancel";
      this.buttonCancel.Size = new System.Drawing.Size(75, 23);
      this.buttonCancel.TabIndex = 100;
      this.buttonCancel.Text = "&Cancel";
      this.buttonCancel.UseVisualStyleBackColor = true;
      this.buttonCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.Controls.Add(this.chkBoxShowCharacters, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.textBoxLoginID, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.textBoxPassword, 1, 1);
      this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 3;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(282, 90);
      this.tableLayoutPanel1.TabIndex = 8;
      // 
      // chkBoxShowCharacters
      // 
      this.chkBoxShowCharacters.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.chkBoxShowCharacters.AutoSize = true;
      this.chkBoxShowCharacters.Location = new System.Drawing.Point(76, 66);
      this.chkBoxShowCharacters.Name = "chkBoxShowCharacters";
      this.chkBoxShowCharacters.Size = new System.Drawing.Size(106, 17);
      this.chkBoxShowCharacters.TabIndex = 2;
      this.chkBoxShowCharacters.Text = "Show characters";
      this.chkBoxShowCharacters.UseVisualStyleBackColor = true;
      this.chkBoxShowCharacters.CheckedChanged += new System.EventHandler(this.chkBoxShowCharacters_CheckedChanged);
      // 
      // label1
      // 
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.label1.Location = new System.Drawing.Point(3, 5);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(61, 19);
      this.label1.TabIndex = 1;
      this.label1.Text = "Login ID";
      // 
      // label2
      // 
      this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.label2.Location = new System.Drawing.Point(3, 35);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(67, 19);
      this.label2.TabIndex = 2;
      this.label2.Text = "Password";
      // 
      // textBoxLoginID
      // 
      this.textBoxLoginID.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.textBoxLoginID.BeforeTouchSize = new System.Drawing.Size(175, 20);
      this.textBoxLoginID.Location = new System.Drawing.Point(76, 5);
      this.textBoxLoginID.MaxLength = 255;
      this.textBoxLoginID.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
      this.textBoxLoginID.Name = "textBoxLoginID";
      this.textBoxLoginID.Size = new System.Drawing.Size(200, 20);
      this.textBoxLoginID.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
      this.textBoxLoginID.TabIndex = 0;
      // 
      // textBoxPassword
      // 
      this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.textBoxPassword.BeforeTouchSize = new System.Drawing.Size(175, 20);
      this.textBoxPassword.Location = new System.Drawing.Point(76, 35);
      this.textBoxPassword.MaxLength = 255;
      this.textBoxPassword.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
      this.textBoxPassword.Name = "textBoxPassword";
      this.textBoxPassword.PasswordChar = '●';
      this.textBoxPassword.Size = new System.Drawing.Size(200, 20);
      this.textBoxPassword.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
      this.textBoxPassword.TabIndex = 1;
      this.textBoxPassword.UseSystemPasswordChar = true;
      this.textBoxPassword.ImeModeChanged += new System.EventHandler(this.textBoxPassword_ImeModeChanged);
      // 
      // tabControlLogin
      // 
      this.tabControlLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tabControlLogin.Controls.Add(this.tabPageLogin);
      this.tabControlLogin.Controls.Add(this.tabPageDatabase);
      this.tabControlLogin.Location = new System.Drawing.Point(12, 12);
      this.tabControlLogin.Name = "tabControlLogin";
      this.tabControlLogin.SelectedIndex = 0;
      this.tabControlLogin.Size = new System.Drawing.Size(500, 195);
      this.tabControlLogin.TabIndex = 10;
      this.tabControlLogin.TabStop = false;
      // 
      // tabPageLogin
      // 
      this.tabPageLogin.Controls.Add(this.groupBoxLogin);
      this.tabPageLogin.Controls.Add(this.pictureBoxLogo);
      this.tabPageLogin.Location = new System.Drawing.Point(4, 22);
      this.tabPageLogin.Name = "tabPageLogin";
      this.tabPageLogin.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageLogin.Size = new System.Drawing.Size(468, 169);
      this.tabPageLogin.TabIndex = 0;
      this.tabPageLogin.Text = "Login";
      this.tabPageLogin.UseVisualStyleBackColor = true;
      // 
      // pictureBoxLogo
      // 
      this.pictureBoxLogo.Image = global::PrintingApplication.Presentation.Properties.Resources.logo_rumah_scarlett;
      this.pictureBoxLogo.Location = new System.Drawing.Point(6, 6);
      this.pictureBoxLogo.Name = "pictureBoxLogo";
      this.pictureBoxLogo.Size = new System.Drawing.Size(155, 155);
      this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBoxLogo.TabIndex = 8;
      this.pictureBoxLogo.TabStop = false;
      // 
      // tabPageDatabase
      // 
      this.tabPageDatabase.Controls.Add(this.groupBoxDatabase);
      this.tabPageDatabase.Location = new System.Drawing.Point(4, 22);
      this.tabPageDatabase.Name = "tabPageDatabase";
      this.tabPageDatabase.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageDatabase.Size = new System.Drawing.Size(492, 169);
      this.tabPageDatabase.TabIndex = 1;
      this.tabPageDatabase.Text = "Database";
      this.tabPageDatabase.UseVisualStyleBackColor = true;
      // 
      // groupBoxDatabase
      // 
      this.groupBoxDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBoxDatabase.Controls.Add(this.tableLayoutPanel3);
      this.groupBoxDatabase.Location = new System.Drawing.Point(6, 6);
      this.groupBoxDatabase.Name = "groupBoxDatabase";
      this.groupBoxDatabase.Size = new System.Drawing.Size(480, 160);
      this.groupBoxDatabase.TabIndex = 11;
      this.groupBoxDatabase.TabStop = false;
      this.groupBoxDatabase.Text = "[ DATA ]";
      // 
      // tableLayoutPanel3
      // 
      this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel3.ColumnCount = 4;
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 3, 3);
      this.tableLayoutPanel3.Controls.Add(this.label3, 0, 1);
      this.tableLayoutPanel3.Controls.Add(this.textBoxDatabase, 1, 1);
      this.tableLayoutPanel3.Controls.Add(this.label6, 0, 3);
      this.tableLayoutPanel3.Controls.Add(this.textBoxPasswordDatabase, 1, 3);
      this.tableLayoutPanel3.Controls.Add(this.textBoxUser, 1, 2);
      this.tableLayoutPanel3.Controls.Add(this.label4, 0, 2);
      this.tableLayoutPanel3.Controls.Add(this.label5, 2, 0);
      this.tableLayoutPanel3.Controls.Add(this.textBoxPort, 3, 0);
      this.tableLayoutPanel3.Controls.Add(this.label7, 0, 0);
      this.tableLayoutPanel3.Controls.Add(this.textBoxServer, 1, 0);
      this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 19);
      this.tableLayoutPanel3.Name = "tableLayoutPanel3";
      this.tableLayoutPanel3.RowCount = 4;
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel3.Size = new System.Drawing.Size(468, 135);
      this.tableLayoutPanel3.TabIndex = 0;
      // 
      // buttonTesKoneksi
      // 
      this.buttonTesKoneksi.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.buttonTesKoneksi.Location = new System.Drawing.Point(86, 3);
      this.buttonTesKoneksi.Name = "buttonTesKoneksi";
      this.buttonTesKoneksi.Size = new System.Drawing.Size(75, 23);
      this.buttonTesKoneksi.TabIndex = 99;
      this.buttonTesKoneksi.Text = "&Tes Koneksi";
      this.buttonTesKoneksi.UseVisualStyleBackColor = true;
      this.buttonTesKoneksi.Click += new System.EventHandler(this.buttonTesKoneksi_Click);
      // 
      // label3
      // 
      this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.label3.Location = new System.Drawing.Point(3, 40);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(66, 19);
      this.label3.TabIndex = 0;
      this.label3.Text = "Database";
      // 
      // textBoxDatabase
      // 
      this.textBoxDatabase.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.textBoxDatabase.BeforeTouchSize = new System.Drawing.Size(175, 20);
      this.textBoxDatabase.Location = new System.Drawing.Point(76, 39);
      this.textBoxDatabase.MaxLength = 255;
      this.textBoxDatabase.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
      this.textBoxDatabase.Name = "textBoxDatabase";
      this.textBoxDatabase.Size = new System.Drawing.Size(175, 20);
      this.textBoxDatabase.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
      this.textBoxDatabase.TabIndex = 2;
      // 
      // label6
      // 
      this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.label6.Location = new System.Drawing.Point(3, 107);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(67, 19);
      this.label6.TabIndex = 0;
      this.label6.Text = "Password";
      // 
      // textBoxPasswordDatabase
      // 
      this.textBoxPasswordDatabase.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.textBoxPasswordDatabase.BeforeTouchSize = new System.Drawing.Size(175, 20);
      this.textBoxPasswordDatabase.Location = new System.Drawing.Point(76, 107);
      this.textBoxPasswordDatabase.MaxLength = 255;
      this.textBoxPasswordDatabase.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
      this.textBoxPasswordDatabase.Name = "textBoxPasswordDatabase";
      this.textBoxPasswordDatabase.PasswordChar = '●';
      this.textBoxPasswordDatabase.Size = new System.Drawing.Size(175, 20);
      this.textBoxPasswordDatabase.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
      this.textBoxPasswordDatabase.TabIndex = 4;
      this.textBoxPasswordDatabase.UseSystemPasswordChar = true;
      // 
      // textBoxUser
      // 
      this.textBoxUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.textBoxUser.BeforeTouchSize = new System.Drawing.Size(175, 20);
      this.textBoxUser.Location = new System.Drawing.Point(76, 72);
      this.textBoxUser.MaxLength = 255;
      this.textBoxUser.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
      this.textBoxUser.Name = "textBoxUser";
      this.textBoxUser.Size = new System.Drawing.Size(175, 20);
      this.textBoxUser.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
      this.textBoxUser.TabIndex = 3;
      // 
      // label4
      // 
      this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.label4.Location = new System.Drawing.Point(3, 73);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(37, 19);
      this.label4.TabIndex = 0;
      this.label4.Text = "User";
      // 
      // label5
      // 
      this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.label5.Location = new System.Drawing.Point(257, 7);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(35, 19);
      this.label5.TabIndex = 0;
      this.label5.Text = "Port";
      // 
      // textBoxPort
      // 
      this.textBoxPort.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.textBoxPort.BeforeTouchSize = new System.Drawing.Size(175, 20);
      this.textBoxPort.Location = new System.Drawing.Point(298, 6);
      this.textBoxPort.MaxLength = 10;
      this.textBoxPort.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
      this.textBoxPort.Name = "textBoxPort";
      this.textBoxPort.Size = new System.Drawing.Size(143, 20);
      this.textBoxPort.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
      this.textBoxPort.TabIndex = 1;
      // 
      // label7
      // 
      this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.label7.Location = new System.Drawing.Point(3, 7);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(47, 19);
      this.label7.TabIndex = 0;
      this.label7.Text = "Server";
      // 
      // textBoxServer
      // 
      this.textBoxServer.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.textBoxServer.BeforeTouchSize = new System.Drawing.Size(175, 20);
      this.textBoxServer.Location = new System.Drawing.Point(76, 6);
      this.textBoxServer.MaxLength = 255;
      this.textBoxServer.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
      this.textBoxServer.Name = "textBoxServer";
      this.textBoxServer.Size = new System.Drawing.Size(175, 20);
      this.textBoxServer.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
      this.textBoxServer.TabIndex = 0;
      // 
      // tableLayoutPanel4
      // 
      this.tableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.tableLayoutPanel4.ColumnCount = 2;
      this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel4.Controls.Add(this.buttonTesKoneksi, 1, 0);
      this.tableLayoutPanel4.Controls.Add(this.buttonSimpan, 0, 0);
      this.tableLayoutPanel4.Location = new System.Drawing.Point(301, 102);
      this.tableLayoutPanel4.Name = "tableLayoutPanel4";
      this.tableLayoutPanel4.RowCount = 1;
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel4.Size = new System.Drawing.Size(164, 30);
      this.tableLayoutPanel4.TabIndex = 100;
      // 
      // buttonSimpan
      // 
      this.buttonSimpan.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.buttonSimpan.Location = new System.Drawing.Point(3, 3);
      this.buttonSimpan.Name = "buttonSimpan";
      this.buttonSimpan.Size = new System.Drawing.Size(75, 23);
      this.buttonSimpan.TabIndex = 98;
      this.buttonSimpan.Text = "&Simpan";
      this.buttonSimpan.UseVisualStyleBackColor = true;
      this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
      // 
      // LoginView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(524, 215);
      this.Controls.Add(this.tabControlLogin);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "LoginView";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Tag = "ignore";
      this.Text = "Login";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginView_FormClosed);
      this.Load += new System.EventHandler(this.LoginView_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginView_KeyDown);
      this.groupBoxLogin.ResumeLayout(false);
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.textBoxLoginID)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.textBoxPassword)).EndInit();
      this.tabControlLogin.ResumeLayout(false);
      this.tabPageLogin.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
      this.tabPageDatabase.ResumeLayout(false);
      this.groupBoxDatabase.ResumeLayout(false);
      this.tableLayoutPanel3.ResumeLayout(false);
      this.tableLayoutPanel3.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.textBoxDatabase)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.textBoxPasswordDatabase)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.textBoxUser)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.textBoxPort)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.textBoxServer)).EndInit();
      this.tableLayoutPanel4.ResumeLayout(false);
      this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox groupBoxLogin;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
      private System.Windows.Forms.Button buttonLogin;
      private System.Windows.Forms.Button buttonCancel;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
      private System.Windows.Forms.CheckBox chkBoxShowCharacters;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.PictureBox pictureBoxLogo;
      private CommonControls.BaseTextBox textBoxLoginID;
      private CommonControls.BaseTextBox textBoxPassword;
      private System.Windows.Forms.TabControl tabControlLogin;
      private System.Windows.Forms.TabPage tabPageLogin;
      private System.Windows.Forms.TabPage tabPageDatabase;
      private System.Windows.Forms.GroupBox groupBoxDatabase;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label5;
      private CommonControls.BaseTextBox textBoxDatabase;
      private CommonControls.BaseTextBox textBoxUser;
      private CommonControls.BaseTextBox textBoxPasswordDatabase;
      private System.Windows.Forms.Button buttonTesKoneksi;
      private System.Windows.Forms.Label label6;
      private CommonControls.BaseTextBox textBoxPort;
      private System.Windows.Forms.Label label7;
      private CommonControls.BaseTextBox textBoxServer;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    private System.Windows.Forms.Button buttonSimpan;
  }
}