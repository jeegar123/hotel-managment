using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelManagement
{
	class DataBaseHelper
	{
		public readonly static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\JEEGAR\sem5\C#\Windows form\HotelManagementSystem\Database\hotel_managment_system.mdf;Integrated Security=True;Connect Timeout=30";

		//user  database
		public readonly static string sqlAddUser = "insert into users (firstname,lastname,username,password) values(@firstname,@lastname,@username,@password)";
		public readonly static string sqlGetUser = "select username,password from users where username=@username and password =@password";


		// manage client databse
		public readonly static string sqlAddClient = "insert into client (fullname,email,mobile_number) values(@fullname,@email,@mobile_number)";
		public readonly static string sqlSelectAllClient = "select * from client";
		public readonly static string sqlSelectOneClient = "select * from client where id=@id";
		public readonly static string sqlUpdateClient = "UPDATE  client SET fullname=@fullname , email=@email , mobile_number=@mobile_number where id=@id";
		public readonly static string sqlDeleteClient = "delete from client where id=@id";



		// manage rooms
		public readonly static string sqlAddRoom = "insert into rooms (room_number,room_type,room_status) values(@room_number_value,@room_type_value,@status)";
		public readonly static string sqlSelectAllRooms = "select * from rooms";
		public readonly static string sqlSelectedRoomNumber = "select room_number from rooms where room_type=@room_type";
		public readonly static string sqlSelectedRoomType = "select room_type from rooms where room_number=@room_number";
		public readonly static string sqlUpdateRoom = "UPDATE rooms set room_type=@room_type,room_status=@room_status where room_number=@room_number";
		public readonly static string sqlDeleteRoom = "delete from rooms where room_number=@room_number";

        //manage reservation 
        public readonly static string sqlAddReservation = "insert into reservation(room_number,reservation_id,client_id,room_type,date_in,date_out) values(@room_number,@reservation_id,@client_id,@room_type,@date_in,@date_out)";
        public readonly static string sqlDeleteReservation = "delete from reservation where reservation_id=@reservation_id";
        public readonly static string sqlSelectAllReservation = "select * from reservation";
        public readonly static string sqlUpdateReservation = "update reservation set room_number=@room_number,client_id=@client_id,room_type=@room_type,date_in=@date_in,date_out=@date_out where reservation_id=@id";

		private SqlConnection sqlConnection;
		private SqlCommand sqlCommand;

		public DataBaseHelper()
		{
			sqlConnection = new SqlConnection(connectionString);
			sqlConnection.Open();
		}

		public void AddUser(string firstname, string lastname, string username, string password)
		{
			sqlCommand = new SqlCommand(sqlAddUser, sqlConnection);
			sqlCommand.Parameters.AddWithValue("@firstname", firstname);
			sqlCommand.Parameters.AddWithValue("@lastname", lastname);
			sqlCommand.Parameters.AddWithValue("@username", username);
			sqlCommand.Parameters.AddWithValue("@password", password);
			sqlCommand.CommandType = System.Data.CommandType.Text;
			sqlCommand.ExecuteNonQuery();
		}

		public ArrayList GetUser(string username, string password)
		{
			ArrayList arrayList = new ArrayList();
			sqlCommand = new SqlCommand(sqlGetUser, sqlConnection);
			sqlCommand.Parameters.AddWithValue("@username", username);
			sqlCommand.Parameters.AddWithValue("@password", password);

			sqlCommand.CommandType = System.Data.CommandType.Text;

			SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

			while (sqlDataReader.Read())
			{
				arrayList.Add(sqlDataReader.GetString(0));
				arrayList.Add(sqlDataReader.GetString(1));
			}
			sqlDataReader.Close();
			return arrayList;
		}

		public void AddClient(string fullname, string email, string mobile_number)
		{
			sqlCommand = new SqlCommand(sqlAddClient, sqlConnection);
			sqlCommand.Parameters.AddWithValue("@fullname", fullname);
			sqlCommand.Parameters.AddWithValue("@email", email);
			sqlCommand.Parameters.AddWithValue("@mobile_number", mobile_number);
			sqlCommand.CommandType = System.Data.CommandType.Text;
			sqlCommand.ExecuteNonQuery();
		}

		public BindingSource GetAllClient()
		{
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
			sqlDataAdapter.SelectCommand = new SqlCommand(sqlSelectAllClient, sqlConnection);

			DataTable table = new DataTable();
			sqlDataAdapter.Fill(table);

			BindingSource bindingSource = new BindingSource();
			bindingSource.DataSource = table;
			return bindingSource;
		}

		public ArrayList GetOneClient(int id)
		{
			ArrayList list = new ArrayList();

			sqlCommand = new SqlCommand(sqlSelectOneClient, sqlConnection);
			sqlCommand.Parameters.AddWithValue("@id", id);
			sqlCommand.CommandType = CommandType.Text;
			SqlDataReader dataReader = sqlCommand.ExecuteReader();

			if (dataReader == null) return null;

			while (dataReader.Read())
			{

				list.Add(Convert.ToString(dataReader.GetValue(0)));
				list.Add(dataReader.GetString(1));
				list.Add(dataReader.GetString(2));
				list.Add(dataReader.GetString(3));
			}
			return list;
		}

		public void UpdateClientInformation(int id, string fullname, string email, string mobile_number)
		{
			sqlCommand = new SqlCommand(sqlUpdateClient, sqlConnection);
			sqlCommand.Parameters.AddWithValue("@id", id);
			sqlCommand.Parameters.AddWithValue("@fullname", fullname);
			sqlCommand.Parameters.AddWithValue("@email", email);
			sqlCommand.Parameters.AddWithValue("@mobile_number", mobile_number);
			sqlCommand.CommandType = CommandType.Text;

			sqlCommand.ExecuteNonQuery();
		}

		public void DeleteClient(int id)
		{
			sqlCommand = new SqlCommand(sqlDeleteClient, sqlConnection);
			sqlCommand.Parameters.AddWithValue("@id", id);
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.ExecuteNonQuery();
		}

		public void AddRoom(int room_number, string room_type, string status)
		{
			try
			{
				Close();
			}
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
			catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
			{

			}
			sqlConnection.Open();
			sqlCommand = new SqlCommand(sqlAddRoom, sqlConnection);
			sqlCommand.Parameters.AddWithValue("@room_number_value", room_number);
			sqlCommand.Parameters.AddWithValue("@room_type_value", room_type);
			sqlCommand.Parameters.AddWithValue("@status", status);
			sqlCommand.CommandType = CommandType.Text;


			try
			{
				sqlCommand.ExecuteNonQuery();
				MessageBox.Show("Room Added");
			}
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
			catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
			{
				MessageBox.Show("Room is already available");
			}
			finally
			{
				Close();

			}

		}
  
		public ArrayList GetRoomTypes(int room_number)
		{
			ArrayList arrayList = new ArrayList();
			sqlCommand = new SqlCommand(sqlSelectedRoomType, sqlConnection);
			sqlCommand.Parameters.AddWithValue("@room_number", room_number);
			sqlCommand.CommandType = CommandType.Text;
			SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
			while (sqlDataReader.Read())
			{
				arrayList.Add(sqlDataReader.GetString(0));
			}
			return arrayList;
		}

		public ArrayList GetRoomNumbers(string room_type)
		{
			ArrayList arrayList = new ArrayList();
			try
			{
				Close();
			}
			catch (Exception)
			{

			}
			sqlConnection.Open();
			sqlCommand = new SqlCommand(sqlSelectedRoomNumber, sqlConnection);
			sqlCommand.Parameters.AddWithValue("@room_type", room_type);
			sqlCommand.CommandType = CommandType.Text;

			try
			{
				SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
				while (sqlDataReader.Read())
				{
					arrayList.Add(sqlDataReader.GetValue(0).ToString());
				}
			}
			catch
			{
				return null;
			}
			Close();
			return arrayList;
		}

		public BindingSource GetAllRoom()
		{
			try
			{
				sqlConnection.Close();

			}
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
			catch ( Exception  ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
			{
				sqlConnection.Open();
			}
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
			sqlDataAdapter.SelectCommand = new SqlCommand(sqlSelectAllRooms, sqlConnection);

			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);

			BindingSource bindingSource = new BindingSource();
			bindingSource.DataSource = dataTable;
			return bindingSource;
		}

		public void UpdateRoom(int room_number, string room_type, string status)
		{
			sqlConnection.Open();
			sqlCommand = new SqlCommand(sqlUpdateRoom, sqlConnection);
			sqlCommand.Parameters.AddWithValue("@room_number", room_number);
			sqlCommand.Parameters.AddWithValue("@room_type", room_type);
			sqlCommand.Parameters.AddWithValue("@room_status", status);
			sqlCommand.CommandType = CommandType.Text;

			try
			{
				sqlCommand.ExecuteNonQuery();
				MessageBox.Show("Update Sucessfull");
			}
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
			catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
			{
				MessageBox.Show("Update UnSucessfull");
			}
			finally
			{
				Close();
			}

		}

		public void DeleteRoom(int room_number)
		{

			sqlConnection.Open();
			sqlCommand = new SqlCommand(sqlDeleteRoom, sqlConnection);
			sqlCommand.Parameters.AddWithValue("@room_number", room_number);
			sqlCommand.CommandType = CommandType.Text;

			try
			{
				sqlCommand.ExecuteNonQuery();
				MessageBox.Show("Room is Remove Successfully");
			}
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
			catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
			{
				MessageBox.Show("Room is Not Available");

			}
			finally
			{
				Close();
			}
		}

        public void AddReservation(int room_number,int reservation_id,int client_id,string room_type,string date_in,string date_out)
        {                         
            sqlCommand = new SqlCommand(sqlAddReservation,sqlConnection);
            sqlCommand.Parameters.AddWithValue("@room_number",room_number);
            sqlCommand.Parameters.AddWithValue("@room_type", room_type);
            sqlCommand.Parameters.AddWithValue("@client_id", client_id);
            sqlCommand.Parameters.AddWithValue("@reservation_id", reservation_id);
            sqlCommand.Parameters.AddWithValue("@date_in", date_in);
            sqlCommand.Parameters.AddWithValue("@date_out", date_out);
            sqlCommand.CommandType = CommandType.Text;
            try { sqlCommand.ExecuteNonQuery();
				MessageBox.Show("Inserted ");
			}
            catch(Exception ex)
            {
                // MessageBox.Show("Already Available");
                MessageBox.Show(ex.ToString());
            }
        }
        public void DeleteReservation(int id)
        {
            sqlCommand = new SqlCommand(sqlDeleteReservation, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@reservation_id", id);
            sqlCommand.CommandType = CommandType.Text;
			try { sqlCommand.ExecuteNonQuery(); }
			catch(Exception ed)
			{
				MessageBox.Show(ed.ToString());
			}
        }

        public void UpdateReservation(int reservation_id,int room_number, string room_type,int client_id,string date_in,string date_out )
        {
			sqlCommand = new SqlCommand(sqlUpdateReservation, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@room_number", room_number);
            sqlCommand.Parameters.AddWithValue("@id", reservation_id);
            sqlCommand.Parameters.AddWithValue("@client_id", client_id);
            sqlCommand.Parameters.AddWithValue("@room_type", room_type);
            sqlCommand.Parameters.AddWithValue("@date_in", date_in);
            sqlCommand.Parameters.AddWithValue("@date_out", date_out);
            sqlCommand.CommandType = CommandType.Text;
       
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Update Sucessfull");
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {
                MessageBox.Show("Update UnSucessfull");
            }
            finally
            {
                Close();
            }
        }

        public BindingSource GetAllReservation()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = new SqlCommand(sqlSelectAllReservation,sqlConnection);

            DataTable table = new DataTable();
            sqlDataAdapter.Fill(table);

            BindingSource binding = new BindingSource();
            binding.DataSource = table;

            return binding;
        }


        public void Close()
		{
			sqlConnection.Close();
		}

	

	 }
	   
}


