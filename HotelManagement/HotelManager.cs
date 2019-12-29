using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
	public partial class HotelManager : Form
	{
		Login login;
		public HotelManager(Login login)
		{
			InitializeComponent();
			this.login=login;
			this.IsMdiContainer = true;
			
		}

		

		private void HotelManager_FormClosed(object sender, FormClosedEventArgs e)
		{
			login.Close();
		}

		private void ManagedClientToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				ManageClient client = new ManageClient();
				client.MdiParent = this;
				client.WindowState = FormWindowState.Normal;
				client.Show();
			}
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
			catch ( Exception  ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
			{

			}

		}

		private void ManageRoomToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ManageRoom manageRoom = new ManageRoom();
			manageRoom.MdiParent = this;
			manageRoom.WindowState = FormWindowState.Normal;
			manageRoom.Show();

		}

		private void ManageReservationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ManageReservation manageReservation = new ManageReservation();
			manageReservation.MdiParent = this;
			manageReservation.WindowState = FormWindowState.Normal;
			manageReservation.Show();
		}

		private void HotelManager_Load(object sender, EventArgs e)
		{

		}
	}
}
