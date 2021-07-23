using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SocketChatMain
{
	public partial class Form1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
	{
		

		ChildForm.frmHome FrmHome = new ChildForm.frmHome();
		ChildForm.c frmCHATROOM = new ChildForm.c();

		string TmpNickName;
		public Form1()
		{
			InitializeComponent();
			SocketLogin socketLogin = new SocketLogin();
			socketLogin.ShowDialog();

		}
		
		private void fluentDesignFormContainer1_Click(object sender, EventArgs e)
		{
			
		}

		private void fluentDesignFormControl1_Validated(object sender, EventArgs e)
		{

		}

		private void Form1_Enter(object sender, EventArgs e)
		{
			
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//Child Form (FrmHome)
			FrmHome.TopLevel = false;

			this.Controls.Add(FrmHome);

			FrmHome.Parent = this.fluentDesignFormContainer1;

			FrmHome.Text = "";

			FrmHome.ControlBox = false;

			//Child Form (FrmCHATROOM)
			frmCHATROOM.TopLevel = false;

			this.Controls.Add(frmCHATROOM);

			frmCHATROOM.Parent = this.fluentDesignFormContainer1;

			frmCHATROOM.Text = "";

			frmCHATROOM.ControlBox = false;

			try
			{

				SqlConnection conn = new SqlConnection("Data Source=127.0.0.1;Initial Catalog=SocketChat;User ID=sa;Password=1004;");

				conn.Open();

				SqlCommand cmd = new SqlCommand(@"SELECT * FROM UserInfo",conn);

				cmd.ExecuteNonQuery();

				SqlDataReader reader = cmd.ExecuteReader();

				reader.Read();

				TmpNickName = reader["UserNickName"].ToString();

				LblUserNickName.Text = TmpNickName;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void accordionControlElement2_Click(object sender, EventArgs e)
		{
			frmCHATROOM.Hide();
			
			FrmHome.Hide();
			FrmHome.Show();

		}

		private void accordionControlElement3_Click(object sender, EventArgs e)
		{
			FrmHome.Hide();

			frmCHATROOM.Hide();
			frmCHATROOM.Show();

		}

		private void BtnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void BtnLoggedOut_Click(object sender, EventArgs e)
		{

			LblUserNickName.Text = "Empty";

			SocketLogin socketLogin = new SocketLogin();
			socketLogin.ShowDialog();

		}

		private void ServerOpen_Click(object sender, EventArgs e)
		{
			
		}
	}
}
