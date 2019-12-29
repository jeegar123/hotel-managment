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
	public partial class ManageReservation : Form
	{

        DataBaseHelper databasehelper;
    
		public ManageReservation()
		{
			InitializeComponent();
            databasehelper = new DataBaseHelper();
		}

		private void Btn_add_reservation_Click(object sender, EventArgs e)
		{
			try
			{
				int reservation_id = Convert.ToInt32(text_reservation_id.Text);
				int client_id = Convert.ToInt32(text_client_id.Text);
				int room_number = Convert.ToInt32(comboBox_room_no.Text);
				string room_type = comboBox_room_type.Text;
				string date_of_in = date_in.Text;
				string date_of_out = date_out.Text;
				databasehelper.AddReservation(room_number, reservation_id, client_id, room_type, date_of_in, date_of_out);
			}
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
			catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
			{
				MessageBox.Show("invalid operation");
			}
			dataGridView1.DataSource = databasehelper.GetAllReservation();
			dataGridView1.Refresh();
			Btn_reset_Click(null, null);
		}

		private void Btn_edit_reservation_Click(object sender, EventArgs e)
		{
			try
			{
				int reservation_id = Convert.ToInt32(text_reservation_id.Text);
				int client_id = Convert.ToInt32(text_client_id.Text);
				int room_number = Convert.ToInt32(comboBox_room_no.Text);
				string room_type = comboBox_room_type.Text;
				string date_of_in = date_in.Text;
				string date_of_out = date_out.Text;

				databasehelper.UpdateReservation(reservation_id, room_number, room_type, client_id, date_of_in, date_of_out);
			}
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
			catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
			{
				MessageBox.Show("invalid operation");
			}
			Btn_reset_Click(null,null);
			dataGridView1.DataSource = databasehelper.GetAllReservation();
			dataGridView1.Refresh(); 
		}
		
		private void Btn_delete_reservation_Click(object sender, EventArgs e)
		{
			try
			{
				int reservation_id = 0;
				reservation_id = Convert.ToInt32(text_reservation_id.Text);
				databasehelper.DeleteReservation(reservation_id);
				MessageBox.Show("Delete Successfull");
			}
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
			catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
			{
				MessageBox.Show("invalid operation");
			}
			Btn_reset_Click(null, null);
			dataGridView1.Refresh();
			dataGridView1.DataSource = databasehelper.GetAllReservation();
		}

		private void Btn_reset_Click(object sender, EventArgs e)
		{
			text_reservation_id.ResetText();
			text_client_id.ResetText();
			comboBox_room_no.ResetText();
			comboBox_room_type.ResetText();
			date_in.ResetText();
			date_out.ResetText();
		}

       

        private void ManageReservation_Load(object sender, EventArgs e)
        {			// TODO: This line of code loads data into the 'hotel_managment_systemDataSet.reservation' table. You can move, or remove it, as needed.
			dataGridView1.DataSource= databasehelper.GetAllReservation();		
        }

		private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

			text_client_id.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			text_reservation_id.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			comboBox_room_no.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			comboBox_room_type.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
			date_in.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
			date_out.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
		}

		private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			text_client_id.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			text_reservation_id.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			comboBox_room_no.Text= dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			comboBox_room_type.Text= dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
			date_in.Text= dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
			date_out.Text= dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();


		}
	}
}
