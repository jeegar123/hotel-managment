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
	public partial class Registration : Form
	{
		DataBaseHelper dataBaseHelper;
		Validation validation;
		public Registration()
		{
			InitializeComponent();
			dataBaseHelper = new DataBaseHelper();
			validation = new Validation();
			
		}

	

		private void Btn_register_Click(object sender, EventArgs e)
		{
			string firstname = text_firstname.Text;
			string lastname = text_lastname.Text;
			string username = text_username.Text;
			string password = text_password.Text;
			if (validation.checkTexboxValue(firstname) && validation.checkTexboxValue(lastname) && validation.CheckEmail(username) && validation.checkTexboxValue(password))
			{
				try
				{
					dataBaseHelper.AddUser(firstname, lastname, username, password);
				}
				catch
				{
					MessageBox.Show("email is already exists ,Please login with email");
					this.ResetText();
					return;
				}

				
				MessageBox.Show("Register Successfull");

			}
			else
			{
				ErrorProvider errorProvider = new ErrorProvider();
				if (!validation.CheckEmail(username))
				{
					errorProvider.SetError(text_username, "enter valid email");
				}
				if (validation.checkTexboxValue(firstname))
				{
					errorProvider.SetError(text_firstname, "enter valid input");
				}
				if (validation.checkTexboxValue(lastname))
				{
					errorProvider.SetError(text_lastname, "enter valid input");
				}
				if (validation.checkTexboxValue(password))
				{
					errorProvider.SetError(text_password, "enter valid input");
				}
				return;
			}

			new Login().Show();
			this.Close();	
		}

		
	}
}
