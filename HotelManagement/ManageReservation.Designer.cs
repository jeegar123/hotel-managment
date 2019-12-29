namespace HotelManagement
{
	partial class ManageReservation
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.label7 = new System.Windows.Forms.Label();
			this.btn_add_reservation = new System.Windows.Forms.Button();
			this.btn_reset = new System.Windows.Forms.Button();
			this.btn_delete_reservation = new System.Windows.Forms.Button();
			this.btn_edit_reservation = new System.Windows.Forms.Button();
			this.date_out = new System.Windows.Forms.DateTimePicker();
			this.date_in = new System.Windows.Forms.DateTimePicker();
			this.comboBox_room_type = new System.Windows.Forms.ComboBox();
			this.comboBox_room_no = new System.Windows.Forms.ComboBox();
			this.text_client_id = new System.Windows.Forms.TextBox();
			this.text_reservation_id = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.roomnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.reservationidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clientidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.roomtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.reservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.hotel_managment_systemDataSet = new HotelManagement.hotel_managment_systemDataSet();
			this.reservationTableAdapter = new HotelManagement.hotel_managment_systemDataSetTableAdapters.reservationTableAdapter();
			this.hotel_managment_systemDataSet1 = new HotelManagement.hotel_managment_systemDataSet();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.hotel_managment_systemDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.hotel_managment_systemDataSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.BackColor = System.Drawing.Color.RoyalBlue;
			this.splitContainer1.Panel1.Controls.Add(this.label7);
			this.splitContainer1.Panel1.Controls.Add(this.btn_add_reservation);
			this.splitContainer1.Panel1.Controls.Add(this.btn_reset);
			this.splitContainer1.Panel1.Controls.Add(this.btn_delete_reservation);
			this.splitContainer1.Panel1.Controls.Add(this.btn_edit_reservation);
			this.splitContainer1.Panel1.Controls.Add(this.date_out);
			this.splitContainer1.Panel1.Controls.Add(this.date_in);
			this.splitContainer1.Panel1.Controls.Add(this.comboBox_room_type);
			this.splitContainer1.Panel1.Controls.Add(this.comboBox_room_no);
			this.splitContainer1.Panel1.Controls.Add(this.text_client_id);
			this.splitContainer1.Panel1.Controls.Add(this.text_reservation_id);
			this.splitContainer1.Panel1.Controls.Add(this.label6);
			this.splitContainer1.Panel1.Controls.Add(this.label5);
			this.splitContainer1.Panel1.Controls.Add(this.label4);
			this.splitContainer1.Panel1.Controls.Add(this.label3);
			this.splitContainer1.Panel1.Controls.Add(this.label2);
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			this.splitContainer1.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
			this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
			this.splitContainer1.Size = new System.Drawing.Size(962, 503);
			this.splitContainer1.SplitterDistance = 386;
			this.splitContainer1.TabIndex = 0;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.RoyalBlue;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Bold);
			this.label7.ForeColor = System.Drawing.Color.DarkViolet;
			this.label7.Location = new System.Drawing.Point(3, 20);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(317, 35);
			this.label7.TabIndex = 14;
			this.label7.Text = "Manage Reservation";
			// 
			// btn_add_reservation
			// 
			this.btn_add_reservation.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btn_add_reservation.BackColor = System.Drawing.Color.Green;
			this.btn_add_reservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
			this.btn_add_reservation.ForeColor = System.Drawing.SystemColors.Control;
			this.btn_add_reservation.Location = new System.Drawing.Point(21, 343);
			this.btn_add_reservation.Name = "btn_add_reservation";
			this.btn_add_reservation.Size = new System.Drawing.Size(126, 41);
			this.btn_add_reservation.TabIndex = 10;
			this.btn_add_reservation.Text = "Add Reservation";
			this.btn_add_reservation.UseVisualStyleBackColor = false;
			this.btn_add_reservation.Click += new System.EventHandler(this.Btn_add_reservation_Click);
			// 
			// btn_reset
			// 
			this.btn_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_reset.BackColor = System.Drawing.Color.CornflowerBlue;
			this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			this.btn_reset.ForeColor = System.Drawing.Color.White;
			this.btn_reset.Location = new System.Drawing.Point(21, 458);
			this.btn_reset.Name = "btn_reset";
			this.btn_reset.Size = new System.Drawing.Size(344, 41);
			this.btn_reset.TabIndex = 11;
			this.btn_reset.Text = "Reset";
			this.btn_reset.UseVisualStyleBackColor = false;
			this.btn_reset.Click += new System.EventHandler(this.Btn_reset_Click);
			// 
			// btn_delete_reservation
			// 
			this.btn_delete_reservation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_delete_reservation.BackColor = System.Drawing.Color.Red;
			this.btn_delete_reservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
			this.btn_delete_reservation.ForeColor = System.Drawing.Color.White;
			this.btn_delete_reservation.Location = new System.Drawing.Point(103, 399);
			this.btn_delete_reservation.Name = "btn_delete_reservation";
			this.btn_delete_reservation.Size = new System.Drawing.Size(183, 41);
			this.btn_delete_reservation.TabIndex = 12;
			this.btn_delete_reservation.Text = "Delete Reservation";
			this.btn_delete_reservation.UseVisualStyleBackColor = false;
			this.btn_delete_reservation.Click += new System.EventHandler(this.Btn_delete_reservation_Click);
			// 
			// btn_edit_reservation
			// 
			this.btn_edit_reservation.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btn_edit_reservation.BackColor = System.Drawing.Color.Navy;
			this.btn_edit_reservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
			this.btn_edit_reservation.ForeColor = System.Drawing.Color.White;
			this.btn_edit_reservation.Location = new System.Drawing.Point(239, 343);
			this.btn_edit_reservation.Name = "btn_edit_reservation";
			this.btn_edit_reservation.Size = new System.Drawing.Size(126, 41);
			this.btn_edit_reservation.TabIndex = 13;
			this.btn_edit_reservation.Text = "Edit Reservation";
			this.btn_edit_reservation.UseVisualStyleBackColor = false;
			this.btn_edit_reservation.Click += new System.EventHandler(this.Btn_edit_reservation_Click);
			// 
			// date_out
			// 
			this.date_out.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.date_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
			this.date_out.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.date_out.Location = new System.Drawing.Point(108, 306);
			this.date_out.Name = "date_out";
			this.date_out.Size = new System.Drawing.Size(257, 20);
			this.date_out.TabIndex = 5;
			// 
			// date_in
			// 
			this.date_in.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.date_in.CustomFormat = "";
			this.date_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
			this.date_in.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.date_in.Location = new System.Drawing.Point(108, 270);
			this.date_in.Name = "date_in";
			this.date_in.Size = new System.Drawing.Size(257, 20);
			this.date_in.TabIndex = 5;
			// 
			// comboBox_room_type
			// 
			this.comboBox_room_type.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBox_room_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox_room_type.FormattingEnabled = true;
			this.comboBox_room_type.Location = new System.Drawing.Point(140, 221);
			this.comboBox_room_type.Name = "comboBox_room_type";
			this.comboBox_room_type.Size = new System.Drawing.Size(212, 28);
			this.comboBox_room_type.TabIndex = 4;
			// 
			// comboBox_room_no
			// 
			this.comboBox_room_no.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBox_room_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox_room_no.FormattingEnabled = true;
			this.comboBox_room_no.Location = new System.Drawing.Point(140, 182);
			this.comboBox_room_no.Name = "comboBox_room_no";
			this.comboBox_room_no.Size = new System.Drawing.Size(212, 28);
			this.comboBox_room_no.TabIndex = 4;
			// 
			// text_client_id
			// 
			this.text_client_id.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.text_client_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.text_client_id.Location = new System.Drawing.Point(140, 130);
			this.text_client_id.Name = "text_client_id";
			this.text_client_id.Size = new System.Drawing.Size(212, 30);
			this.text_client_id.TabIndex = 3;
			// 
			// text_reservation_id
			// 
			this.text_reservation_id.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.text_reservation_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.text_reservation_id.Location = new System.Drawing.Point(140, 89);
			this.text_reservation_id.Name = "text_reservation_id";
			this.text_reservation_id.Size = new System.Drawing.Size(212, 30);
			this.text_reservation_id.TabIndex = 3;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(14, 306);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(86, 22);
			this.label6.TabIndex = 2;
			this.label6.Text = "Date out";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(17, 268);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(74, 22);
			this.label5.TabIndex = 2;
			this.label5.Text = "Date In";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(12, 225);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(112, 22);
			this.label4.TabIndex = 2;
			this.label4.Text = "Room Type";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(12, 182);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(98, 22);
			this.label3.TabIndex = 2;
			this.label3.Text = "Room No.";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(12, 137);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 22);
			this.label2.TabIndex = 1;
			this.label2.Text = "Client ID";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(3, 93);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(142, 22);
			this.label1.TabIndex = 0;
			this.label1.Text = "Reservation ID";
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomnumberDataGridViewTextBoxColumn,
            this.reservationidDataGridViewTextBoxColumn,
            this.clientidDataGridViewTextBoxColumn,
            this.roomtypeDataGridViewTextBoxColumn,
            this.dateinDataGridViewTextBoxColumn,
            this.dateoutDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.reservationBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(3, 3);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(566, 500);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
			// 
			// roomnumberDataGridViewTextBoxColumn
			// 
			this.roomnumberDataGridViewTextBoxColumn.DataPropertyName = "room_number";
			this.roomnumberDataGridViewTextBoxColumn.HeaderText = "room_number";
			this.roomnumberDataGridViewTextBoxColumn.Name = "roomnumberDataGridViewTextBoxColumn";
			// 
			// reservationidDataGridViewTextBoxColumn
			// 
			this.reservationidDataGridViewTextBoxColumn.DataPropertyName = "reservation_id";
			this.reservationidDataGridViewTextBoxColumn.HeaderText = "reservation_id";
			this.reservationidDataGridViewTextBoxColumn.Name = "reservationidDataGridViewTextBoxColumn";
			this.reservationidDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// clientidDataGridViewTextBoxColumn
			// 
			this.clientidDataGridViewTextBoxColumn.DataPropertyName = "client_id";
			this.clientidDataGridViewTextBoxColumn.HeaderText = "client_id";
			this.clientidDataGridViewTextBoxColumn.Name = "clientidDataGridViewTextBoxColumn";
			// 
			// roomtypeDataGridViewTextBoxColumn
			// 
			this.roomtypeDataGridViewTextBoxColumn.DataPropertyName = "room_type";
			this.roomtypeDataGridViewTextBoxColumn.HeaderText = "room_type";
			this.roomtypeDataGridViewTextBoxColumn.Name = "roomtypeDataGridViewTextBoxColumn";
			// 
			// dateinDataGridViewTextBoxColumn
			// 
			this.dateinDataGridViewTextBoxColumn.DataPropertyName = "date_in";
			this.dateinDataGridViewTextBoxColumn.HeaderText = "date_in";
			this.dateinDataGridViewTextBoxColumn.Name = "dateinDataGridViewTextBoxColumn";
			// 
			// dateoutDataGridViewTextBoxColumn
			// 
			this.dateoutDataGridViewTextBoxColumn.DataPropertyName = "date_out";
			this.dateoutDataGridViewTextBoxColumn.HeaderText = "date_out";
			this.dateoutDataGridViewTextBoxColumn.Name = "dateoutDataGridViewTextBoxColumn";
			// 
			// reservationBindingSource
			// 
			this.reservationBindingSource.DataMember = "reservation";
			this.reservationBindingSource.DataSource = this.hotel_managment_systemDataSet;
			// 
			// hotel_managment_systemDataSet
			// 
			this.hotel_managment_systemDataSet.DataSetName = "hotel_managment_systemDataSet";
			this.hotel_managment_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// reservationTableAdapter
			// 
			this.reservationTableAdapter.ClearBeforeFill = true;
			// 
			// hotel_managment_systemDataSet1
			// 
			this.hotel_managment_systemDataSet1.DataSetName = "hotel_managment_systemDataSet";
			this.hotel_managment_systemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// ManageReservation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(962, 503);
			this.Controls.Add(this.splitContainer1);
			this.Name = "ManageReservation";
			this.Text = "ManageReservation";
			this.Load += new System.EventHandler(this.ManageReservation_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.hotel_managment_systemDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.hotel_managment_systemDataSet1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TextBox text_client_id;
		private System.Windows.Forms.TextBox text_reservation_id;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox_room_type;
		private System.Windows.Forms.ComboBox comboBox_room_no;
		private System.Windows.Forms.DateTimePicker date_out;
		private System.Windows.Forms.Button btn_add_reservation;
		private System.Windows.Forms.Button btn_reset;
		private System.Windows.Forms.Button btn_delete_reservation;
		private System.Windows.Forms.Button btn_edit_reservation;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker date_in;
		private hotel_managment_systemDataSet hotel_managment_systemDataSet;
		private System.Windows.Forms.BindingSource reservationBindingSource;
		private hotel_managment_systemDataSetTableAdapters.reservationTableAdapter reservationTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn roomnumberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn reservationidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn clientidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn roomtypeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateinDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateoutDataGridViewTextBoxColumn;
		private hotel_managment_systemDataSet hotel_managment_systemDataSet1;
	}
}