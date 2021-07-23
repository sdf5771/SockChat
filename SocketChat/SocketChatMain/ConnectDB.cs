using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SocketChatMain
{
	class ConnectDB
	{
		
		SqlConnection conn = new SqlConnection("Data Source=127.0.0.1;Initial Catalog=SocketChat;User ID=sa;Password=1004;");

	}
}
