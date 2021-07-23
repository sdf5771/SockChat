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

namespace SocketChatMain.ChildForm
{
	public partial class frmHome : DevExpress.XtraEditors.XtraForm
	{
		public frmHome()
		{
			InitializeComponent();
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}