namespace SocketChatMain.ChildForm
{
	partial class c
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
			this.BtnSend = new DevExpress.XtraEditors.SimpleButton();
			this.TxtChatRoom = new DevExpress.XtraEditors.TextEdit();
			this.TxtChatLog = new System.Windows.Forms.TextBox();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.TxtChatNickName = new DevExpress.XtraEditors.TextEdit();
			this.TxtMsg = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.TxtChatRoom.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TxtChatNickName.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// BtnSend
			// 
			this.BtnSend.Location = new System.Drawing.Point(458, 441);
			this.BtnSend.Name = "BtnSend";
			this.BtnSend.Size = new System.Drawing.Size(128, 34);
			this.BtnSend.TabIndex = 0;
			this.BtnSend.Text = "SEND";
			this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
			// 
			// TxtChatRoom
			// 
			this.TxtChatRoom.EditValue = "127.0.0.1";
			this.TxtChatRoom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.TxtChatRoom.Location = new System.Drawing.Point(98, 12);
			this.TxtChatRoom.Name = "TxtChatRoom";
			this.TxtChatRoom.Properties.Appearance.BackColor = System.Drawing.Color.Silver;
			this.TxtChatRoom.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtChatRoom.Properties.Appearance.Options.UseBackColor = true;
			this.TxtChatRoom.Properties.Appearance.Options.UseFont = true;
			this.TxtChatRoom.Size = new System.Drawing.Size(126, 22);
			this.TxtChatRoom.TabIndex = 2;
			// 
			// TxtChatLog
			// 
			this.TxtChatLog.Location = new System.Drawing.Point(12, 38);
			this.TxtChatLog.Multiline = true;
			this.TxtChatLog.Name = "TxtChatLog";
			this.TxtChatLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.TxtChatLog.Size = new System.Drawing.Size(573, 397);
			this.TxtChatLog.TabIndex = 3;
			this.TxtChatLog.Text = "TxtChatLog";
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Location = new System.Drawing.Point(13, 12);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(79, 19);
			this.labelControl1.TabIndex = 4;
			this.labelControl1.Text = "Server IP";
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl2.Appearance.Options.UseFont = true;
			this.labelControl2.Location = new System.Drawing.Point(284, 12);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(144, 19);
			this.labelControl2.TabIndex = 6;
			this.labelControl2.Text = "Your Nickname is";
			// 
			// TxtChatNickName
			// 
			this.TxtChatNickName.EditValue = "NICKNAME";
			this.TxtChatNickName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.TxtChatNickName.Location = new System.Drawing.Point(436, 12);
			this.TxtChatNickName.Name = "TxtChatNickName";
			this.TxtChatNickName.Properties.Appearance.BackColor = System.Drawing.Color.Silver;
			this.TxtChatNickName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtChatNickName.Properties.Appearance.Options.UseBackColor = true;
			this.TxtChatNickName.Properties.Appearance.Options.UseFont = true;
			this.TxtChatNickName.Size = new System.Drawing.Size(147, 22);
			this.TxtChatNickName.TabIndex = 5;
			// 
			// TxtMsg
			// 
			this.TxtMsg.Location = new System.Drawing.Point(12, 448);
			this.TxtMsg.Multiline = true;
			this.TxtMsg.Name = "TxtMsg";
			this.TxtMsg.Size = new System.Drawing.Size(440, 22);
			this.TxtMsg.TabIndex = 7;
			// 
			// c
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(599, 484);
			this.Controls.Add(this.TxtMsg);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.TxtChatNickName);
			this.Controls.Add(this.labelControl1);
			this.Controls.Add(this.TxtChatLog);
			this.Controls.Add(this.TxtChatRoom);
			this.Controls.Add(this.BtnSend);
			this.Name = "c";
			this.Text = "frmCHATROOM";
			this.Load += new System.EventHandler(this.frmCHATROOM_Load);
			((System.ComponentModel.ISupportInitialize)(this.TxtChatRoom.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TxtChatNickName.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.SimpleButton BtnSend;
		private DevExpress.XtraEditors.TextEdit TxtChatRoom;
		private System.Windows.Forms.TextBox TxtChatLog;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.TextEdit TxtChatNickName;
		private System.Windows.Forms.TextBox TxtMsg;
	}
}