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
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace SocketChatMain.ChildForm
{
	public partial class frmServerOpen : DevExpress.XtraEditors.XtraForm
	{
		//서버
		TcpListener server = null; //서버
		TcpClient clientSocket = null; //소켓
		static int counter = 0; //사용자 수
		string date; // Date
					 // 각 클라이언트 마다 리스트에 추가
		public Dictionary<TcpClient, string> clientList = new Dictionary<TcpClient, string>();

		public frmServerOpen()
		{
			InitializeComponent();


			//Thread 생성
			Thread t = new Thread(InitSocket);
			t.IsBackground = true;
			t.Start();
		}

		private void InitSocket()
		{
			server = new TcpListener(IPAddress.Any, 9999); // 서버 접속 IP, Port\
			clientSocket = default(TcpClient); // 소켓 설정
			server.Start(); // 서버 시작
			DisplayText(">> Server Started");

			while (true)
			{
				try
				{
					counter++; // Client 수 증가
					clientSocket = server.AcceptTcpClient(); // client 소켓 접속 허용
					DisplayText(">> Accept connection from client");

					NetworkStream stream = clientSocket.GetStream();
					byte[] buffer = new byte[1024]; //버퍼
					int bytes = stream.Read(buffer, 0, buffer.Length);
					string user_name = Encoding.Unicode.GetString(buffer, 0, bytes);
					user_name = user_name.Substring(0, user_name.IndexOf("$")); // Client 사용자 명

					clientList.Add(clientSocket, user_name); //client 리스트에 추가
					SendMessageAll(user_name + " 님이 입장하셨습니다.", "", false); //모든 client에게 메세지 전송

					//handleClient h_client = new handleClient(); // 클라이언트 추가
					//h_client.OnReceived += new handleClient.MessageDisplayHandler(OnReceived);
					//h_client.OnDisconnected += new handleClient.DisconnectedHandler(h_client_OnDisconnected);
					//h_client.startClient(clientSocket, clientList);
				}
				catch (SocketException se)
				{
					//MessageBox.Show(se,"SocketServer Error!!");
					break;
				}
				catch (Exception ex)
				{
					//MessageBox.Show(ex, "Error!!");
					break;
				}

				clientSocket.Close(); // Client 소켓 닫기
				server.Stop(); // Server 종료
			}
		}

		void h_client_OnDisconnected(TcpClient clientSocket) // Client 접속 해제 핸들러
		{
			if (clientList.ContainsKey(clientSocket))
				clientList.Remove(clientSocket);
		}

		private void OnReceived(string message, string user_name) // Client로 부터 받은 데이터
		{
			if (message.Equals("leaveChat"))
			{
				string displayMessage = "leave user : " + user_name;
				DisplayText(displayMessage);
				SendMessageAll("leaveChat", user_name, true);
			}
			else
			{
				string displayMessage = "From client : " + user_name + " : " + message;
				DisplayText(displayMessage);
				SendMessageAll(message, user_name, true); // 모든 Client에게 전송
			}
		}

		public void SendMessageAll(string message, string user_name, bool flag)
		{
			foreach (var pair in clientList)
			{
				date = DateTime.Now.ToString("yyyy.MM.dd. HH:mm:ss"); //현재 날짜 받기

				TcpClient client = pair.Key as TcpClient;
				NetworkStream stream = client.GetStream();
				byte[] buffer = null;

				if (flag)
				{
					if (message.Equals("leaveChat"))
						buffer = Encoding.Unicode.GetBytes(user_name + " 님이 대화방을 나갔습니다.");
					else
						buffer = Encoding.Unicode.GetBytes("[ " + date + " ]" + user_name + " : " + message);
				}
				else
				{
					buffer = Encoding.Unicode.GetBytes(message);
				}
				stream.Write(buffer, 0, buffer.Length); // Write buffer
				stream.Flush();
			}
		}

		private void DisplayText(string text) // Server 화면에 출력되는 텍스트
		{
			if (ServerTextBox.InvokeRequired)
			{
				ServerTextBox.BeginInvoke(new MethodInvoker(delegate
				{
					ServerTextBox.AppendText(text + Environment.NewLine);
				}));
			}
			else
				ServerTextBox.AppendText(text + Environment.NewLine);
		}

		private void frmServerOpen_Load(object sender, EventArgs e)
		{
			ServerTextBox.Text = "";
		}
	}
}