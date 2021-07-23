namespace SocketChatMain.ChildForm
{
	partial class frmHome
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
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
			this.imageListBoxControl1 = new DevExpress.XtraEditors.ImageListBoxControl();
			this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
			this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imageListBoxControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Location = new System.Drawing.Point(129, 12);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(335, 58);
			this.labelControl1.TabIndex = 0;
			this.labelControl1.Text = "SOCKETCHAT";
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl2.Appearance.Options.UseFont = true;
			this.labelControl2.Location = new System.Drawing.Point(167, 64);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(254, 42);
			this.labelControl2.TabIndex = 1;
			this.labelControl2.Text = "HELLO FELLAZ";
			// 
			// listBoxControl1
			// 
			this.listBoxControl1.Location = new System.Drawing.Point(50, 311);
			this.listBoxControl1.Name = "listBoxControl1";
			this.listBoxControl1.Size = new System.Drawing.Size(494, 139);
			this.listBoxControl1.TabIndex = 2;
			// 
			// imageListBoxControl1
			// 
			this.imageListBoxControl1.Location = new System.Drawing.Point(294, 119);
			this.imageListBoxControl1.Name = "imageListBoxControl1";
			this.imageListBoxControl1.Size = new System.Drawing.Size(249, 186);
			this.imageListBoxControl1.TabIndex = 3;
			// 
			// pictureEdit1
			// 
			this.pictureEdit1.Location = new System.Drawing.Point(50, 119);
			this.pictureEdit1.Name = "pictureEdit1";
			this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
			this.pictureEdit1.Size = new System.Drawing.Size(238, 186);
			this.pictureEdit1.TabIndex = 4;
			// 
			// simpleButton1
			// 
			this.simpleButton1.Location = new System.Drawing.Point(205, 453);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new System.Drawing.Size(191, 24);
			this.simpleButton1.TabIndex = 5;
			this.simpleButton1.Text = "CLOSE";
			this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
			// 
			// frmHome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(598, 479);
			this.Controls.Add(this.simpleButton1);
			this.Controls.Add(this.pictureEdit1);
			this.Controls.Add(this.imageListBoxControl1);
			this.Controls.Add(this.listBoxControl1);
			this.Controls.Add(this.labelControl1);
			this.Controls.Add(this.labelControl2);
			this.Name = "frmHome";
			this.Text = "frmHome";
			((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imageListBoxControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
		private DevExpress.XtraEditors.ImageListBoxControl imageListBoxControl1;
		private DevExpress.XtraEditors.PictureEdit pictureEdit1;
		private DevExpress.XtraEditors.SimpleButton simpleButton1;
	}
}