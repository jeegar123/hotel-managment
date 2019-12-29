using System;
using System.Collections;
using System.Windows.Forms;

namespace HotelManagement
{

	public partial class ManageClient : Form
	{
		Validation validation;
		DataBaseHelper dataBaseHelper;
		public static bool checkid;
		public ManageClient()
		{
			InitializeComponent();
			validation = new Validation();
			text_client_id.Visible = false;
			label_id.Visible = false;
			dataBaseHelper = new DataBaseHelper();

		}

		private void Btn_reset_Click(object sender, EventArgs e)
		{
			text_client_email.Text = null;
			text_client_id.Text = null;
			text_client_fullname.Text = null;
			text_client_mobil_number.Text = null;
			if (!checkid)
			{
				text_client_id.Visible = false;
				label_id.Visible = false;
				checkid = true;
			}
			
			//dataGridView1.Refresh();
		}

		private void Btn_add_client_Click(object sender, EventArgs e)
		{
			try
			{
				string fullname = text_client_fullname.Text;
				string email = text_client_email.Text;
				string mobile_number = text_client_mobil_number.Text;

				if (validation.CheckEmail(email) && validation.checkTexboxValue(fullname) && validation.checkTexboxValue(mobile_number))
				{
					dataBaseHelper.AddClient(fullname, email, mobile_number);
					MessageBox.Show("added");
				}
				else
				{
					MessageBox.Show("invalid operation");
				}
			}
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
			catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
			{
				MessageBox.Show("invalid operation");
			}
			dataGridView1.DataSource = dataBaseHelper.GetAllClient();
			dataGridView1.Refresh();
            Btn_reset_Click(null, null);

        }

		

		private void ManageClient_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'hotel_managment_systemDataSet1.client' table. You can move, or remove it, as needed.
			this.clientTableAdapter.Fill(this.hotel_managment_systemDataSet1.client);
			dataGridView1.DataSource = dataBaseHelper.GetAllClient();
		}


		private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
				
			checkid = true;
			if (checkid)
			{
				label_id.Visible = true;
				text_client_id.Visible = true;
				checkid = false;
			}
			try
			{
				text_client_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
				text_client_fullname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
				text_client_email.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
				
				text_client_mobil_number.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
				

			}
			catch (Exception)
			{
				Btn_reset_Click(null, null);
			}
            

        }

		private void Btn_edit_client_Click(object sender, EventArgs e)
		{
			try
			{
				string fullname = text_client_fullname.Text;
				string email = text_client_email.Text;
				string mobile_number = text_client_mobil_number.Text;
				string id = text_client_id.Text;
				int client_id = Convert.ToInt32(id);

				if (validation.CheckEmail(email) && validation.checkTexboxValue(fullname) && validation.checkTexboxValue(mobile_number) && validation.checkTexboxValue(id))
				{
					dataBaseHelper.UpdateClientInformation(client_id, fullname, email, mobile_number);
					MessageBox.Show("Successfully update");
				}
				else
				{
					MessageBox.Show("UnSuccessfully update");
					Btn_reset_Click(null, null);
				}

			}
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
			catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
			{
				MessageBox.Show("sorry invalid operation");
			}
            Btn_reset_Click(null, null);
            dataGridView1.DataSource = dataBaseHelper.GetAllClient();
			dataGridView1.Refresh();
            
        }

		private void Btn_delete_client_Click(object sender, EventArgs e)
		{
			try
			{
				string fullname = text_client_fullname.Text;
				string email = text_client_email.Text;
				string mobile_number = text_client_mobil_number.Text;
				string id = text_client_id.Text;
				int client_id = Convert.ToInt32(id);
				if (validation.CheckEmail(email) && validation.checkTexboxValue(fullname) && validation.checkTexboxValue(mobile_number) && validation.checkTexboxValue(id))
				{
					dataBaseHelper.DeleteClient(client_id);
					MessageBox.Show("Succesfully deleted");
				}
				else
				{
					MessageBox.Show("UnSuccesfully deleted");
				}
			}
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
			catch(Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
			{
				MessageBox.Show("invalid operation");
			}
            Btn_reset_Click(null, null);
            dataGridView1.DataSource = dataBaseHelper.GetAllClient();
			dataGridView1.Refresh();
            
        }

	
	}
}
