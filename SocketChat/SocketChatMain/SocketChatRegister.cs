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
using System.Data;
using System.Data.SqlClient;
using static SocketChatMain.ConnectDB;

namespace SocketChatMain
{
	
	public partial class SocketChatRegister : DevExpress.XtraEditors.XtraForm
	{
		string tempSeq; // Str SQL User Seq Temp
		int tmpSeq; // Int SQL User Seq Temp

		public SocketChatRegister()
		{
			InitializeComponent();
		}

		private void BtnRegister_Click(object sender, EventArgs e)
		{
			
			
				SqlConnection conn = new SqlConnection("Data Source=127.0.0.1;Initial Catalog=SocketChat;User ID=sa;Password=1004;");

				conn.Open();
			try
			{

				SqlCommand cmd1 = new SqlCommand(@"SELECT top(1)UserSeq From UserInfo ORDER BY UserSeq DESC", conn);

				cmd1.ExecuteNonQuery();

				SqlDataReader reader = cmd1.ExecuteReader();

				reader.Read();
				//DB에서 받아온 값 데이터형 변환 Str - Int
				tempSeq = reader["UserSeq"].ToString();

				tmpSeq = Convert.ToInt32(tempSeq);

				//존재하는 시퀀스 값에서 플러스
				tmpSeq = tmpSeq + 1;

				conn.Close();

			}
			catch (Exception ex)
			{
				// UserSeq가 Null일 경우 루틴
				if (tempSeq is null)
				{
					MessageBox.Show("현재 DataBase에 저장된 시퀀스 넘버가 없습니다. 새로 생성합니다.");

					tempSeq = tempSeq + 1;

					tmpSeq = Convert.ToInt32(tempSeq);
				}
				else
				{
					MessageBox.Show(ex.Message, "DataBase Connection Error!!, Check Server information");
				}
				conn.Close();
			}

			try
			{
				conn.Open();
					SqlCommand cmd = new SqlCommand(@"INSERT INTO Userinfo(UserSeq,UserID,UserNickName,UserPW,UserGroup,UserStatus)
			VALUES ('" + tmpSeq + "','" + TxtID.Text + "','" + TxtNickName.Text + "','" + TxtPW.Text + "','" + 1 + "','" + 1 + "')", conn);

					cmd.ExecuteNonQuery();

					conn.Close();

					MessageBox.Show("User Regist Success");
				
				

			}catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "DataBase Connection Error!!, Check Server information");
				
			}
		}

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void BtnInitialize_Click(object sender, EventArgs e)
		{
			TxtID.Text = "";
			TxtNickName.Text = "";
			TxtPW.Text = "";
		}
	}
}