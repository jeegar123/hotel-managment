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
	public partial class ManageRoom : Form
	{

		String []roomtype = {"Single","Double","Triple","Kingsize","QueenSize"};
		Validation validation;
		DataBaseHelper dataBaseHelper;
		public ManageRoom()
		{
			InitializeComponent();
			validation = new Validation();
			dataBaseHelper = new DataBaseHelper();
			
		}

		

		private void ManageRoom_Load(object sender, EventArgs e)
		{
			comboBox_room_type.Text = "Room Type";
			comboBox_room_no.Text = "Room Number";
			for (int i=0;i<roomtype.Length;i++)
			{
				comboBox_room_type.Items.Add(roomtype[i]);
			}

			dataGridView_room.DataSource = dataBaseHelper.GetAllRoom();
			dataGridView_room.Refresh();

		}

		private void ComboBox_room_type_MouseLeave(object sender, EventArgs e)
		{
					
		}

		private void Btn_add_room_Click(object sender, EventArgs e)
		{
			string room_number = comboBox_room_no.Text;
			string room_type = comboBox_room_type.Text;
			string status="empty";
			if (rad_btn_yes.Checked)
			{
				status = "full";
			}
			if(validation.checkRoomNumber(room_number) && validation.checkTexboxValue(room_type) && !room_type.Equals("Room Type"))
			{
				dataBaseHelper.AddRoom(Convert.ToInt32(room_number) ,room_type,status);
			}
		    dataGridView_room.DataSource = dataBaseHelper.GetAllRoom();
			dataGridView_room.Refresh();
			Btn_reset_Click(null,null);
		}

		private void Btn_reset_Click(object sender, EventArgs e)
		{
			comboBox_room_type.Text = "Room Type";
			comboBox_room_no.Text = "Room Number";
		}

		
		

		private void ComboBox_room_type_SelectedIndexChanged(object sender, EventArgs e)
		{
			
			if (!comboBox_room_type.Text.Equals("Room Type"))
			{
				ArrayList arrayList = dataBaseHelper.GetRoomNumbers(comboBox_room_type.Text);
					
				comboBox_room_no.DataSource = arrayList;
			}
		}

		private void Btn_edit_room_Click(object sender, EventArgs e)
		{
			string room_number = comboBox_room_no.Text;
			string room_type = comboBox_room_type.Text;
			string status = "empty";
			if (rad_btn_yes.Checked)
			{
				status = "full";
			}
			if (validation.checkRoomNumber(room_number) && validation.checkTexboxValue(room_type) && !room_type.Equals("Room Type"))
			{
				dataBaseHelper.UpdateRoom(Convert.ToInt32(room_number),room_type,status);
			}
			dataGridView_room.DataSource = dataBaseHelper.GetAllRoom();
			dataGridView_room.Refresh();
			Btn_reset_Click(null,null);
		}

		private void ComboBox_room_no_SelectedIndexChanged(object sender, EventArgs e)
		{
			
			if (!validation.checkRoomNumber (comboBox_room_no.Text) && comboBox_room_no.Text.Equals("Room Number"))
			{
				ArrayList arrayList = dataBaseHelper.GetRoomTypes(Convert.ToInt32(comboBox_room_no.Text));			
				comboBox_room_type.DataSource = arrayList;
			}
		}

		private void DataGridView_room_CellClick(object sender, DataGridViewCellEventArgs e)
		{

			comboBox_room_no.Text = dataGridView_room.Rows[e.RowIndex].Cells[0].Value.ToString();
			comboBox_room_type.Text = dataGridView_room.Rows[e.RowIndex].Cells[1].Value.ToString();

			if (dataGridView_room.Rows[e.RowIndex].Cells[2].Value.ToString().Equals("full"))
				rad_btn_yes.Checked=true;
			else
				rad_btn_no.Checked=true;
		}

		private void Btn_delete_room_Click(object sender, EventArgs e)
		{
			try
			{
				int room = Convert.ToInt32(comboBox_room_no.Text);
				dataBaseHelper.DeleteRoom(room);
			}
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
			catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
			{
				
			}
			finally
			{
				Btn_reset_Click(null, null);
				dataGridView_room.DataSource = dataBaseHelper.GetAllRoom();
				dataGridView_room.Refresh();
			}
			
		}

		private void DataGridView_room_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
