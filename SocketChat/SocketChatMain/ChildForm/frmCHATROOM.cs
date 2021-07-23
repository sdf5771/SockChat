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
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Data.SqlClient;
using System.Data.Sql;

namespace SocketChatMain.ChildForm
{
	public partial class c : DevExpress.XtraEditors.XtraForm
	{
		TcpClient clientSocket = new TcpClient(); // 소켓
		NetworkStream stream = default(NetworkStream);
		string message = string.Empty;
		string TmpNickName;

		public c()
		{
			InitializeComponent();
		}

		private void BtnSend_Click(object sender, EventArgs e)
		{
			TxtMsg.Text = "";


		}

		private void frmCHATROOM_Load(object sender, EventArgs e)
		{
			SqlConnection conn = new SqlConnection("Data Source=127.0.0.1;Initial Catalog=SocketChat;User ID=sa;Password=1004;");

			conn.Open();

			SqlCommand cmd = new SqlCommand(@"SELECT * FROM UserInfo", conn);

			cmd.ExecuteNonQuery();

			SqlDataReader reader = cmd.ExecuteReader();

			reader.Read();

			//NICKNAME
			TxtChatNickName.Text = "";
			TmpNickName = reader["UserNickName"].ToString();
			TxtChatNickName.Text = TmpNickName;

			//채팅 텍스트박스 초기화
			TxtChatLog.Text = ""; 
			TxtChatRoom.Text = ""; //접속 IP

			try
			{
				clientSocket.Connect(TxtChatRoom.Text, 9999); // 접속 IP 및 포트
				stream = clientSocket.GetStream();
			}
			catch (Exception e2)
			{
				MessageBox.Show("Server is not running" + e2, "Connect Failed");
				Application.Exit();
			}

			message = "채팅 서버에 연결되었습니다.";
			DisplayText(message);

			byte[] buffer = Encoding.Unicode.GetBytes(TxtChatNickName.Text + "$"); // DB에서 불러오거나 입력한 닉네임
			stream.Write(buffer, 0, buffer.Length);
			stream.Flush();

			Thread t_handler = new Thread(GetMessage);
			t_handler.IsBackground = true;
			t_handler.Start();
		}

		private void GetMessage() // 메세지 받기
		{
			while (true)
			{
				stream = clientSocket.GetStream();
				int BUFFERSIZE = clientSocket.ReceiveBufferSize;
				byte[] buffer = new byte[BUFFERSIZE];
				int bytes = stream.Read(buffer, 0, buffer.Length);

				string message = Encoding.Unicode.GetString(buffer, 0, bytes);
				DisplayText(message);
			}
		}

		private void DisplayText(string text) // Server에 메세지 출력
		{
			if (TxtMsg.InvokeRequired)
			{
				TxtMsg.BeginInvoke(new MethodInvoker(delegate
				{
					TxtMsg.AppendText(text + Environment.NewLine);
				}));
			}
			else
				TxtMsg.AppendText(text + Environment.NewLine);
		}

	}
}