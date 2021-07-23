using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using static SocketChatMain.ConnectDB;

namespace SocketChatMain
{
	public partial class SocketLogin : DevExpress.XtraEditors.XtraForm
	{
		string TmpNickName;

		public SocketLogin()
		{
			InitializeComponent();
		}
		
		private void simpleButton1_Click(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("Data Source=127.0.0.1;Initial Catalog=SocketChat;User ID=sa;Password=1004;");

			conn.Open();

			try
			{

				SqlCommand cmd = new SqlCommand(@"SELECT UserNickName FROM UserInfo Where UserID = '" + TxtID.Text + "' AND UserPW = '" + TxtPW.Text + "'", conn);

				cmd.ExecuteNonQuery();

				SqlDataReader reader = cmd.ExecuteReader();

				reader.Read();

				TmpNickName = reader["UserNickName"].ToString();

				TxtNickName.Text = TmpNickName;

				//Form1 f1 = new Form1();

				//f1.LblUserNickName.Text = this.TmpNickName;

				conn.Close();

				MessageBox.Show("Hello " + TxtNickName.Text,"Welcome to the SocketChat");

				//로그인 루틴 처리 후

				

				this.Close();

			}
			catch(Exception ex)
			{
				//if ()
				//{
				//	MessageBox.Show(ex.Message, "아이디를 입력해주세요.");
				//}
				MessageBox.Show(ex.Message,"로그인 실패");

			}

		}

		private void SocketLogin_Load(object sender, EventArgs e)
		{

		}

		private void BtnRegister_Click(object sender, EventArgs e)
		{
			SocketChatRegister chatRegister = new SocketChatRegister();
			chatRegister.ShowDialog();
			

		}

		private void BtnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void TxtNickName_EditValueChanged(object sender, EventArgs e)
		{

		}

		private void TxtID_EditValueChanged(object sender, EventArgs e)
		{
			
		}

		private void TxtID_Leave(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("Data Source=127.0.0.1;Initial Catalog=SocketChat;User ID=sa;Password=1004;");

			conn.Open();

			try
			{
				// ID 입력체크
				if (TxtID.Text.Length > 0)
				{

					SqlCommand cmd = new SqlCommand(@"SELECT UserNickName FROM UserInfo Where UserID = '" + TxtID.Text + "'", conn);



					// 계정이 존재하면.
					
					cmd.ExecuteNonQuery();

					SqlDataReader reader = cmd.ExecuteReader();

					reader.Read();

					TmpNickName = reader["UserNickName"].ToString();

					TxtNickName.Text = TmpNickName;

					conn.Close();
				}
				else
				{

				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message,"아이디가 존재하지 않습니다.");

				conn.Close();

			}
		}
	}
}