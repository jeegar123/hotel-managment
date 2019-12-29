namespace HotelManagement
{
	partial class ManageRoom
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageRoom));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.label4 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.comboBox_room_type = new System.Windows.Forms.ComboBox();
			this.comboBox_room_no = new System.Windows.Forms.ComboBox();
			this.btn_add_room = new System.Windows.Forms.Button();
			this.btn_reset = new System.Windows.Forms.Button();
			this.btn_delete_room = new System.Windows.Forms.Button();
			this.btn_edit_room = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.rad_btn_no = new System.Windows.Forms.RadioButton();
			this.rad_btn_yes = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
			this.dataGridView_room = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_room)).BeginInit();
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
			this.splitContainer1.Panel1.BackColor = System.Drawing.Color.MediumPurple;
			this.splitContainer1.Panel1.Controls.Add(this.label4);
			this.splitContainer1.Panel1.Controls.Add(this.pictureBox2);
			this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
			this.splitContainer1.Panel1.Controls.Add(this.comboBox_room_type);
			this.splitContainer1.Panel1.Controls.Add(this.comboBox_room_no);
			this.splitContainer1.Panel1.Controls.Add(this.btn_add_room);
			this.splitContainer1.Panel1.Controls.Add(this.btn_reset);
			this.splitContainer1.Panel1.Controls.Add(this.btn_delete_room);
			this.splitContainer1.Panel1.Controls.Add(this.btn_edit_room);
			this.splitContainer1.Panel1.Controls.Add(this.label3);
			this.splitContainer1.Panel1.Controls.Add(this.rad_btn_no);
			this.splitContainer1.Panel1.Controls.Add(this.rad_btn_yes);
			this.splitContainer1.Panel1.Controls.Add(this.label2);
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.vScrollBar1);
			this.splitContainer1.Panel2.Controls.Add(this.dataGridView_room);
			this.splitContainer1.Size = new System.Drawing.Size(902, 563);
			this.splitContainer1.SplitterDistance = 341;
			this.splitContainer1.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Blue;
			this.label4.Location = new System.Drawing.Point(3, 27);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(337, 53);
			this.label4.TabIndex = 14;
			this.label4.Text = "Manage Room";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(216, 235);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(47, 36);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox2.TabIndex = 13;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(114, 235);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(29, 36);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 12;
			this.pictureBox1.TabStop = false;
			// 
			// comboBox_room_type
			// 
			this.comboBox_room_type.FormattingEnabled = true;
			this.comboBox_room_type.Location = new System.Drawing.Point(128, 196);
			this.comboBox_room_type.Name = "comboBox_room_type";
			this.comboBox_room_type.Size = new System.Drawing.Size(181, 21);
			this.comboBox_room_type.TabIndex = 11;
			this.comboBox_room_type.SelectedIndexChanged += new System.EventHandler(this.ComboBox_room_type_SelectedIndexChanged);
			this.comboBox_room_type.MouseLeave += new System.EventHandler(this.ComboBox_room_type_MouseLeave);
			// 
			// comboBox_room_no
			// 
			this.comboBox_room_no.FormattingEnabled = true;
			this.comboBox_room_no.Location = new System.Drawing.Point(128, 163);
			this.comboBox_room_no.Name = "comboBox_room_no";
			this.comboBox_room_no.Size = new System.Drawing.Size(181, 21);
			this.comboBox_room_no.TabIndex = 10;
			this.comboBox_room_no.SelectedIndexChanged += new System.EventHandler(this.ComboBox_room_no_SelectedIndexChanged);
			// 
			// btn_add_room
			// 
			this.btn_add_room.BackColor = System.Drawing.Color.Green;
			this.btn_add_room.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_add_room.ForeColor = System.Drawing.Color.White;
			this.btn_add_room.Location = new System.Drawing.Point(37, 337);
			this.btn_add_room.Name = "btn_add_room";
			this.btn_add_room.Size = new System.Drawing.Size(126, 41);
			this.btn_add_room.TabIndex = 6;
			this.btn_add_room.Text = "Add Room";
			this.btn_add_room.UseVisualStyleBackColor = false;
			this.btn_add_room.Click += new System.EventHandler(this.Btn_add_room_Click);
			// 
			// btn_reset
			// 
			this.btn_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_reset.ForeColor = System.Drawing.Color.White;
			this.btn_reset.Location = new System.Drawing.Point(37, 464);
			this.btn_reset.Name = "btn_reset";
			this.btn_reset.Size = new System.Drawing.Size(287, 41);
			this.btn_reset.TabIndex = 7;
			this.btn_reset.Text = "Reset";
			this.btn_reset.UseVisualStyleBackColor = false;
			this.btn_reset.Click += new System.EventHandler(this.Btn_reset_Click);
			// 
			// btn_delete_room
			// 
			this.btn_delete_room.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btn_delete_room.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_delete_room.ForeColor = System.Drawing.Color.White;
			this.btn_delete_room.Location = new System.Drawing.Point(119, 393);
			this.btn_delete_room.Name = "btn_delete_room";
			this.btn_delete_room.Size = new System.Drawing.Size(126, 41);
			this.btn_delete_room.TabIndex = 8;
			this.btn_delete_room.Text = "Delete Room";
			this.btn_delete_room.UseVisualStyleBackColor = false;
			this.btn_delete_room.Click += new System.EventHandler(this.Btn_delete_room_Click);
			// 
			// btn_edit_room
			// 
			this.btn_edit_room.BackColor = System.Drawing.Color.Navy;
			this.btn_edit_room.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_edit_room.ForeColor = System.Drawing.Color.White;
			this.btn_edit_room.Location = new System.Drawing.Point(198, 337);
			this.btn_edit_room.Name = "btn_edit_room";
			this.btn_edit_room.Size = new System.Drawing.Size(126, 41);
			this.btn_edit_room.TabIndex = 9;
			this.btn_edit_room.Text = "Edit Room";
			this.btn_edit_room.UseVisualStyleBackColor = false;
			this.btn_edit_room.Click += new System.EventHandler(this.Btn_edit_room_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.Control;
			this.label3.Location = new System.Drawing.Point(26, 240);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 24);
			this.label3.TabIndex = 3;
			this.label3.Text = "Free";
			// 
			// rad_btn_no
			// 
			this.rad_btn_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rad_btn_no.ForeColor = System.Drawing.Color.MediumBlue;
			this.rad_btn_no.Location = new System.Drawing.Point(269, 237);
			this.rad_btn_no.Name = "rad_btn_no";
			this.rad_btn_no.Size = new System.Drawing.Size(57, 29);
			this.rad_btn_no.TabIndex = 2;
			this.rad_btn_no.TabStop = true;
			this.rad_btn_no.Text = "No";
			this.rad_btn_no.UseVisualStyleBackColor = true;
			// 
			// rad_btn_yes
			// 
			this.rad_btn_yes.Checked = true;
			this.rad_btn_yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rad_btn_yes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.rad_btn_yes.Location = new System.Drawing.Point(144, 237);
			this.rad_btn_yes.Name = "rad_btn_yes";
			this.rad_btn_yes.Size = new System.Drawing.Size(67, 29);
			this.rad_btn_yes.TabIndex = 1;
			this.rad_btn_yes.TabStop = true;
			this.rad_btn_yes.Text = "Yes";
			this.rad_btn_yes.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.Control;
			this.label2.Location = new System.Drawing.Point(13, 193);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(118, 24);
			this.label2.TabIndex = 0;
			this.label2.Text = "Room Type";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Control;
			this.label1.Location = new System.Drawing.Point(26, 163);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Room No.";
			// 
			// vScrollBar1
			// 
			this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
			this.vScrollBar1.Location = new System.Drawing.Point(530, 0);
			this.vScrollBar1.Name = "vScrollBar1";
			this.vScrollBar1.Size = new System.Drawing.Size(27, 563);
			this.vScrollBar1.TabIndex = 1;
			// 
			// dataGridView_room
			// 
			this.dataGridView_room.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView_room.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView_room.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_room.Location = new System.Drawing.Point(5, 3);
			this.dataGridView_room.Name = "dataGridView_room";
			this.dataGridView_room.Size = new System.Drawing.Size(519, 560);
			this.dataGridView_room.TabIndex = 0;
			this.dataGridView_room.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_room_CellClick);
			this.dataGridView_room.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_room_CellContentClick);
			// 
			// ManageRoom
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(902, 563);
			this.Controls.Add(this.splitContainer1);
			this.Name = "ManageRoom";
			this.Text = "ManageRoom";
			this.Load += new System.EventHandler(this.ManageRoom_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_room)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView_room;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RadioButton rad_btn_no;
		private System.Windows.Forms.RadioButton rad_btn_yes;
		private System.Windows.Forms.Button btn_add_room;
		private System.Windows.Forms.Button btn_reset;
		private System.Windows.Forms.Button btn_delete_room;
		private System.Windows.Forms.Button btn_edit_room;
		private System.Windows.Forms.ComboBox comboBox_room_type;
		private System.Windows.Forms.ComboBox comboBox_room_no;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.VScrollBar vScrollBar1;
	}
}