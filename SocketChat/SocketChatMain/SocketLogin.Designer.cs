namespace SocketChatMain
{
	partial class SocketLogin
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
			this.BtnLogin = new DevExpress.XtraEditors.SimpleButton();
			this.BtnExit = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.TxtID = new DevExpress.XtraEditors.TextEdit();
			this.TxtPW = new DevExpress.XtraEditors.TextEdit();
			this.TxtNickName = new DevExpress.XtraEditors.TextEdit();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.BtnRegister = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TxtPW.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TxtNickName.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// BtnLogin
			// 
			this.BtnLogin.Location = new System.Drawing.Point(395, 111);
			this.BtnLogin.Name = "BtnLogin";
			this.BtnLogin.Size = new System.Drawing.Size(63, 51);
			this.BtnLogin.TabIndex = 0;
			this.BtnLogin.Text = "LOGIN";
			this.BtnLogin.Click += new System.EventHandler(this.simpleButton1_Click);
			// 
			// BtnExit
			// 
			this.BtnExit.Location = new System.Drawing.Point(395, 164);
			this.BtnExit.Name = "BtnExit";
			this.BtnExit.Size = new System.Drawing.Size(63, 51);
			this.BtnExit.TabIndex = 1;
			this.BtnExit.Text = "EXIT";
			this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Location = new System.Drawing.Point(170, 121);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(17, 19);
			this.labelControl1.TabIndex = 2;
			this.labelControl1.Text = "ID";
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
			this.labelControl2.Appearance.Options.UseFont = true;
			this.labelControl2.Location = new System.Drawing.Point(170, 187);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(23, 19);
			this.labelControl2.TabIndex = 3;
			this.labelControl2.Text = "PW";
			// 
			// TxtID
			// 
			this.TxtID.Location = new System.Drawing.Point(204, 119);
			this.TxtID.Name = "TxtID";
			this.TxtID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
			this.TxtID.Properties.Appearance.Options.UseFont = true;
			this.TxtID.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.TxtID.Size = new System.Drawing.Size(177, 26);
			this.TxtID.TabIndex = 4;
			this.TxtID.EditValueChanged += new System.EventHandler(this.TxtID_EditValueChanged);
			this.TxtID.Leave += new System.EventHandler(this.TxtID_Leave);
			// 
			// TxtPW
			// 
			this.TxtPW.Location = new System.Drawing.Point(204, 184);
			this.TxtPW.Name = "TxtPW";
			this.TxtPW.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
			this.TxtPW.Properties.Appearance.Options.UseFont = true;
			this.TxtPW.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.TxtPW.Properties.PasswordChar = '*';
			this.TxtPW.Properties.UseSystemPasswordChar = true;
			this.TxtPW.Size = new System.Drawing.Size(177, 26);
			this.TxtPW.TabIndex = 5;
			// 
			// TxtNickName
			// 
			this.TxtNickName.Location = new System.Drawing.Point(204, 151);
			this.TxtNickName.Name = "TxtNickName";
			this.TxtNickName.Properties.Appearance.BackColor = System.Drawing.Color.LightGray;
			this.TxtNickName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
			this.TxtNickName.Properties.Appearance.Options.UseBackColor = true;
			this.TxtNickName.Properties.Appearance.Options.UseFont = true;
			this.TxtNickName.Size = new System.Drawing.Size(177, 26);
			this.TxtNickName.TabIndex = 6;
			this.TxtNickName.EditValueChanged += new System.EventHandler(this.TxtNickName_EditValueChanged);
			// 
			// labelControl3
			// 
			this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
			this.labelControl3.Appearance.Options.UseFont = true;
			this.labelControl3.Location = new System.Drawing.Point(119, 154);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(79, 19);
			this.labelControl3.TabIndex = 7;
			this.labelControl3.Text = "NICKNAME";
			// 
			// BtnRegister
			// 
			this.BtnRegister.Location = new System.Drawing.Point(119, 217);
			this.BtnRegister.Name = "BtnRegister";
			this.BtnRegister.Size = new System.Drawing.Size(339, 18);
			this.BtnRegister.TabIndex = 8;
			this.BtnRegister.Text = "REGIST";
			this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
			// 
			// labelControl5
			// 
			this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl5.Appearance.Options.UseFont = true;
			this.labelControl5.Location = new System.Drawing.Point(82, 11);
			this.labelControl5.Name = "labelControl5";
			this.labelControl5.Size = new System.Drawing.Size(446, 42);
			this.labelControl5.TabIndex = 19;
			this.labelControl5.Text = "WELLCOME SOCKETCHAT";
			// 
			// labelControl4
			// 
			this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl4.Appearance.Options.UseFont = true;
			this.labelControl4.Location = new System.Drawing.Point(223, 50);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(137, 25);
			this.labelControl4.TabIndex = 20;
			this.labelControl4.Text = "USER LOGIN";
			// 
			// SocketLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(583, 246);
			this.Controls.Add(this.labelControl4);
			this.Controls.Add(this.labelControl5);
			this.Controls.Add(this.BtnRegister);
			this.Controls.Add(this.labelControl3);
			this.Controls.Add(this.TxtNickName);
			this.Controls.Add(this.TxtPW);
			this.Controls.Add(this.TxtID);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.labelControl1);
			this.Controls.Add(this.BtnExit);
			this.Controls.Add(this.BtnLogin);
			this.Name = "SocketLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SocketLogin";
			this.Load += new System.EventHandler(this.SocketLogin_Load);
			((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TxtPW.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TxtNickName.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.SimpleButton BtnLogin;
		private DevExpress.XtraEditors.SimpleButton BtnExit;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.TextEdit TxtID;
		private DevExpress.XtraEditors.TextEdit TxtPW;
		private DevExpress.XtraEditors.TextEdit TxtNickName;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.SimpleButton BtnRegister;
		private DevExpress.XtraEditors.LabelControl labelControl5;
		private DevExpress.XtraEditors.LabelControl labelControl4;
	}
}