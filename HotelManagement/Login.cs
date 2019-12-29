using System;
using System.Collections;
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
	public partial class Login : Form
	{
		DataBaseHelper helper;
		public Login()
		{
			InitializeComponent();
			helper = new DataBaseHelper();
		}

		
		private void Btn_signin_Click(object sender, EventArgs e)
		{
			string username = text_username.Text;
			string password = text_password.Text;
			Validation validation = new Validation();

			if(!validation.CheckEmail(username) && !validation.checkTexboxValue(password))
			{
				MessageBox.Show("invalid data!");
				return;
			}

			ArrayList array=helper.GetUser(username, password);
			if (array.Count > 0)
			{
				new HotelManager(this).Show();
				this.Visible = false;
			}
			else
			{
				MessageBox.Show("Enter Valid Account");
			}
		}
	
		private void Login_Load(object sender, EventArgs e)
		{
		}
			
	

		private void Link_signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			new Registration().ShowDialog();
		}
	}
}
