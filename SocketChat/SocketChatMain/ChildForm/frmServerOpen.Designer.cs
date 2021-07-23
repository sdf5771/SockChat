namespace SocketChatMain.ChildForm
{
	partial class frmServerOpen
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
			this.ServerTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// ServerTextBox
			// 
			this.ServerTextBox.Location = new System.Drawing.Point(13, 8);
			this.ServerTextBox.Multiline = true;
			this.ServerTextBox.Name = "ServerTextBox";
			this.ServerTextBox.Size = new System.Drawing.Size(552, 447);
			this.ServerTextBox.TabIndex = 0;
			this.ServerTextBox.Text = "ServerTextBox";
			// 
			// frmServerOpen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(581, 467);
			this.Controls.Add(this.ServerTextBox);
			this.Name = "frmServerOpen";
			this.Text = "frmServerOpen";
			this.Load += new System.EventHandler(this.frmServerOpen_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox ServerTextBox;
	}
}