namespace SocketChatMain
{
	partial class Form1
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
			this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
			this.BtnExit = new DevExpress.XtraEditors.SimpleButton();
			this.BtnLoggedOut = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.LblUserNickName = new DevExpress.XtraEditors.LabelControl();
			this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
			this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.ServerOpen = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.accordionControlElement5 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.accordionControlElement6 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
			this.fluentDesignFormContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
			this.SuspendLayout();
			// 
			// fluentDesignFormContainer1
			// 
			this.fluentDesignFormContainer1.Controls.Add(this.BtnExit);
			this.fluentDesignFormContainer1.Controls.Add(this.BtnLoggedOut);
			this.fluentDesignFormContainer1.Controls.Add(this.labelControl2);
			this.fluentDesignFormContainer1.Controls.Add(this.LblUserNickName);
			this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fluentDesignFormContainer1.Location = new System.Drawing.Point(202, 27);
			this.fluentDesignFormContainer1.Margin = new System.Windows.Forms.Padding(2);
			this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
			this.fluentDesignFormContainer1.Size = new System.Drawing.Size(605, 540);
			this.fluentDesignFormContainer1.TabIndex = 0;
			this.fluentDesignFormContainer1.Click += new System.EventHandler(this.fluentDesignFormContainer1_Click);
			// 
			// BtnExit
			// 
			this.BtnExit.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnExit.Appearance.Options.UseFont = true;
			this.BtnExit.Location = new System.Drawing.Point(442, 505);
			this.BtnExit.Name = "BtnExit";
			this.BtnExit.Size = new System.Drawing.Size(140, 34);
			this.BtnExit.TabIndex = 3;
			this.BtnExit.Text = "Exit";
			this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
			// 
			// BtnLoggedOut
			// 
			this.BtnLoggedOut.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnLoggedOut.Appearance.Options.UseFont = true;
			this.BtnLoggedOut.Location = new System.Drawing.Point(283, 505);
			this.BtnLoggedOut.Name = "BtnLoggedOut";
			this.BtnLoggedOut.Size = new System.Drawing.Size(140, 34);
			this.BtnLoggedOut.TabIndex = 2;
			this.BtnLoggedOut.Text = "Logged Out";
			this.BtnLoggedOut.Click += new System.EventHandler(this.BtnLoggedOut_Click);
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl2.Appearance.Options.UseFont = true;
			this.labelControl2.AutoEllipsis = true;
			this.labelControl2.Location = new System.Drawing.Point(8, 510);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(94, 23);
			this.labelControl2.TabIndex = 1;
			this.labelControl2.Text = "Logged in";
			// 
			// LblUserNickName
			// 
			this.LblUserNickName.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblUserNickName.Appearance.Options.UseFont = true;
			this.LblUserNickName.Location = new System.Drawing.Point(108, 508);
			this.LblUserNickName.Name = "LblUserNickName";
			this.LblUserNickName.Size = new System.Drawing.Size(155, 25);
			this.LblUserNickName.TabIndex = 0;
			this.LblUserNickName.Text = "UserNickName";
			// 
			// accordionControl1
			// 
			this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
			this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1});
			this.accordionControl1.Location = new System.Drawing.Point(0, 27);
			this.accordionControl1.Margin = new System.Windows.Forms.Padding(2);
			this.accordionControl1.Name = "accordionControl1";
			this.accordionControl1.RootDisplayMode = DevExpress.XtraBars.Navigation.AccordionControlRootDisplayMode.Footer;
			this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
			this.accordionControl1.Size = new System.Drawing.Size(202, 540);
			this.accordionControl1.TabIndex = 1;
			this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
			// 
			// accordionControlElement1
			// 
			this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement2,
            this.accordionControlElement3,
            this.ServerOpen,
            this.accordionControlElement5,
            this.accordionControlElement6});
			this.accordionControlElement1.Expanded = true;
			this.accordionControlElement1.Name = "accordionControlElement1";
			this.accordionControlElement1.Text = "Element1";
			// 
			// accordionControlElement2
			// 
			this.accordionControlElement2.Name = "accordionControlElement2";
			this.accordionControlElement2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
			this.accordionControlElement2.Text = "HOME";
			this.accordionControlElement2.Click += new System.EventHandler(this.accordionControlElement2_Click);
			// 
			// accordionControlElement3
			// 
			this.accordionControlElement3.Name = "accordionControlElement3";
			this.accordionControlElement3.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
			this.accordionControlElement3.Text = "CHATROOM";
			this.accordionControlElement3.Click += new System.EventHandler(this.accordionControlElement3_Click);
			// 
			// ServerOpen
			// 
			this.ServerOpen.Name = "ServerOpen";
			this.ServerOpen.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
			this.ServerOpen.Text = "Server Open";
			this.ServerOpen.Click += new System.EventHandler(this.ServerOpen_Click);
			// 
			// accordionControlElement5
			// 
			this.accordionControlElement5.Name = "accordionControlElement5";
			this.accordionControlElement5.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
			this.accordionControlElement5.Text = "Element5";
			// 
			// accordionControlElement6
			// 
			this.accordionControlElement6.Name = "accordionControlElement6";
			this.accordionControlElement6.Text = "Element6";
			// 
			// fluentDesignFormControl1
			// 
			this.fluentDesignFormControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.fluentDesignFormControl1.FluentDesignForm = this;
			this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
			this.fluentDesignFormControl1.Margin = new System.Windows.Forms.Padding(2);
			this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
			this.fluentDesignFormControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.fluentDesignFormControl1.Size = new System.Drawing.Size(807, 27);
			this.fluentDesignFormControl1.TabIndex = 2;
			this.fluentDesignFormControl1.TabStop = false;
			this.fluentDesignFormControl1.Validated += new System.EventHandler(this.fluentDesignFormControl1_Validated);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(807, 567);
			this.ControlContainer = this.fluentDesignFormContainer1;
			this.Controls.Add(this.fluentDesignFormContainer1);
			this.Controls.Add(this.accordionControl1);
			this.Controls.Add(this.fluentDesignFormControl1);
			this.FluentDesignFormControl = this.fluentDesignFormControl1;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Form1";
			this.NavigationControl = this.accordionControl1;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SocketChat";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Enter += new System.EventHandler(this.Form1_Enter);
			this.fluentDesignFormContainer1.ResumeLayout(false);
			this.fluentDesignFormContainer1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
		private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
		private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
		private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.SimpleButton BtnExit;
		private DevExpress.XtraEditors.SimpleButton BtnLoggedOut;
		private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
		private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
		private DevExpress.XtraBars.Navigation.AccordionControlElement ServerOpen;
		private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement5;
		private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement6;
		public DevExpress.XtraEditors.LabelControl LblUserNickName;
	}
}

