namespace HotelManagement
{
	partial class ManageClient
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
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.text_client_id = new System.Windows.Forms.TextBox();
			this.text_client_mobil_number = new System.Windows.Forms.TextBox();
			this.text_client_email = new System.Windows.Forms.TextBox();
			this.text_client_fullname = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label_id = new System.Windows.Forms.Label();
			this.btn_add_client = new System.Windows.Forms.Button();
			this.btn_reset = new System.Windows.Forms.Button();
			this.btn_delete_client = new System.Windows.Forms.Button();
			this.btn_edit_client = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mobilenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.hotel_managment_systemDataSet1 = new HotelManagement.hotel_managment_systemDataSet1();
			this.clientTableAdapter = new HotelManagement.hotel_managment_systemDataSet1TableAdapters.clientTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
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
			this.splitContainer1.Panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.splitContainer1.Panel1.Controls.Add(this.label4);
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			this.splitContainer1.Panel1.Controls.Add(this.text_client_id);
			this.splitContainer1.Panel1.Controls.Add(this.text_client_mobil_number);
			this.splitContainer1.Panel1.Controls.Add(this.text_client_email);
			this.splitContainer1.Panel1.Controls.Add(this.text_client_fullname);
			this.splitContainer1.Panel1.Controls.Add(this.label3);
			this.splitContainer1.Panel1.Controls.Add(this.label2);
			this.splitContainer1.Panel1.Controls.Add(this.label_id);
			this.splitContainer1.Panel1.Controls.Add(this.btn_add_client);
			this.splitContainer1.Panel1.Controls.Add(this.btn_reset);
			this.splitContainer1.Panel1.Controls.Add(this.btn_delete_client);
			this.splitContainer1.Panel1.Controls.Add(this.btn_edit_client);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
			this.splitContainer1.Size = new System.Drawing.Size(972, 573);
			this.splitContainer1.SplitterDistance = 410;
			this.splitContainer1.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Blue;
			this.label4.Location = new System.Drawing.Point(12, 22);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(389, 63);
			this.label4.TabIndex = 6;
			this.label4.Text = "Manage Client";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(29, 246);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 72);
			this.label1.TabIndex = 5;
			this.label1.Text = "Phone No.\r\n or\r\nMobile No.\r\n";
			// 
			// text_client_id
			// 
			this.text_client_id.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.text_client_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.text_client_id.Location = new System.Drawing.Point(139, 126);
			this.text_client_id.Name = "text_client_id";
			this.text_client_id.Size = new System.Drawing.Size(250, 30);
			this.text_client_id.TabIndex = 4;
			// 
			// text_client_mobil_number
			// 
			this.text_client_mobil_number.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.text_client_mobil_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.text_client_mobil_number.Location = new System.Drawing.Point(139, 257);
			this.text_client_mobil_number.Name = "text_client_mobil_number";
			this.text_client_mobil_number.Size = new System.Drawing.Size(250, 30);
			this.text_client_mobil_number.TabIndex = 3;
			// 
			// text_client_email
			// 
			this.text_client_email.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.text_client_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.text_client_email.Location = new System.Drawing.Point(139, 207);
			this.text_client_email.Name = "text_client_email";
			this.text_client_email.Size = new System.Drawing.Size(250, 30);
			this.text_client_email.TabIndex = 3;
			// 
			// text_client_fullname
			// 
			this.text_client_fullname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.text_client_fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.text_client_fullname.Location = new System.Drawing.Point(139, 168);
			this.text_client_fullname.Name = "text_client_fullname";
			this.text_client_fullname.Size = new System.Drawing.Size(250, 30);
			this.text_client_fullname.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(29, 213);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 24);
			this.label3.TabIndex = 1;
			this.label3.Text = "Email";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(29, 174);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "Fullname";
			// 
			// label_id
			// 
			this.label_id.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label_id.AutoSize = true;
			this.label_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_id.ForeColor = System.Drawing.Color.White;
			this.label_id.Location = new System.Drawing.Point(29, 132);
			this.label_id.Name = "label_id";
			this.label_id.Size = new System.Drawing.Size(27, 24);
			this.label_id.TabIndex = 1;
			this.label_id.Text = "Id";
			// 
			// btn_add_client
			// 
			this.btn_add_client.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btn_add_client.BackColor = System.Drawing.Color.Green;
			this.btn_add_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_add_client.ForeColor = System.Drawing.Color.White;
			this.btn_add_client.Location = new System.Drawing.Point(12, 402);
			this.btn_add_client.Name = "btn_add_client";
			this.btn_add_client.Size = new System.Drawing.Size(178, 41);
			this.btn_add_client.TabIndex = 0;
			this.btn_add_client.Text = "Add Client";
			this.btn_add_client.UseVisualStyleBackColor = false;
			this.btn_add_client.Click += new System.EventHandler(this.Btn_add_client_Click);
			// 
			// btn_reset
			// 
			this.btn_reset.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btn_reset.BackColor = System.Drawing.Color.RoyalBlue;
			this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_reset.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btn_reset.Location = new System.Drawing.Point(211, 462);
			this.btn_reset.Name = "btn_reset";
			this.btn_reset.Size = new System.Drawing.Size(178, 41);
			this.btn_reset.TabIndex = 0;
			this.btn_reset.Text = "Reset";
			this.btn_reset.UseVisualStyleBackColor = false;
			this.btn_reset.Click += new System.EventHandler(this.Btn_reset_Click);
			// 
			// btn_delete_client
			// 
			this.btn_delete_client.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btn_delete_client.BackColor = System.Drawing.Color.Red;
			this.btn_delete_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_delete_client.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btn_delete_client.Location = new System.Drawing.Point(12, 462);
			this.btn_delete_client.Name = "btn_delete_client";
			this.btn_delete_client.Size = new System.Drawing.Size(178, 41);
			this.btn_delete_client.TabIndex = 0;
			this.btn_delete_client.Text = "Delete Client";
			this.btn_delete_client.UseVisualStyleBackColor = false;
			this.btn_delete_client.Click += new System.EventHandler(this.Btn_delete_client_Click);
			// 
			// btn_edit_client
			// 
			this.btn_edit_client.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btn_edit_client.BackColor = System.Drawing.Color.Blue;
			this.btn_edit_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_edit_client.ForeColor = System.Drawing.Color.White;
			this.btn_edit_client.Location = new System.Drawing.Point(211, 402);
			this.btn_edit_client.Name = "btn_edit_client";
			this.btn_edit_client.Size = new System.Drawing.Size(178, 41);
			this.btn_edit_client.TabIndex = 0;
			this.btn_edit_client.Text = "Edit Client";
			this.btn_edit_client.UseVisualStyleBackColor = false;
			this.btn_edit_client.Click += new System.EventHandler(this.Btn_edit_client_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fullnameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.mobilenumberDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.clientBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(3, 3);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(552, 567);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// fullnameDataGridViewTextBoxColumn
			// 
			this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "fullname";
			this.fullnameDataGridViewTextBoxColumn.HeaderText = "fullname";
			this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
			// 
			// emailDataGridViewTextBoxColumn
			// 
			this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
			this.emailDataGridViewTextBoxColumn.HeaderText = "email";
			this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
			// 
			// mobilenumberDataGridViewTextBoxColumn
			// 
			this.mobilenumberDataGridViewTextBoxColumn.DataPropertyName = "mobile_number";
			this.mobilenumberDataGridViewTextBoxColumn.HeaderText = "mobile_number";
			this.mobilenumberDataGridViewTextBoxColumn.Name = "mobilenumberDataGridViewTextBoxColumn";
			// 
			// clientBindingSource
			// 
			this.clientBindingSource.DataMember = "client";
			this.clientBindingSource.DataSource = this.hotel_managment_systemDataSet1;
			// 
			// hotel_managment_systemDataSet1
			// 
			this.hotel_managment_systemDataSet1.DataSetName = "hotel_managment_systemDataSet1";
			this.hotel_managment_systemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// clientTableAdapter
			// 
			this.clientTableAdapter.ClearBeforeFill = true;
			// 
			// ManageClient
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(972, 573);
			this.Controls.Add(this.splitContainer1);
			this.Name = "ManageClient";
			this.Text = "ManageClient";
			this.Load += new System.EventHandler(this.ManageClient_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.hotel_managment_systemDataSet1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btn_edit_client;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label_id;
		private System.Windows.Forms.Button btn_add_client;
		private System.Windows.Forms.Button btn_delete_client;
		private System.Windows.Forms.TextBox text_client_id;
		private System.Windows.Forms.TextBox text_client_fullname;
		private System.Windows.Forms.TextBox text_client_mobil_number;
		private System.Windows.Forms.TextBox text_client_email;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_reset;
		private System.Windows.Forms.Label label4;
		private hotel_managment_systemDataSet1 hotel_managment_systemDataSet1;
		private System.Windows.Forms.BindingSource clientBindingSource;
		private hotel_managment_systemDataSet1TableAdapters.clientTableAdapter clientTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn mobilenumberDataGridViewTextBoxColumn;
	}
}