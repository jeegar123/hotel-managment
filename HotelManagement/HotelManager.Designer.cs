namespace HotelManagement
{
	partial class HotelManager
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.managedClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.manageRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.manageReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.BlueViolet;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managedClientToolStripMenuItem,
            this.manageRoomToolStripMenuItem,
            this.manageReservationToolStripMenuItem,
            this.logoutToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(909, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// managedClientToolStripMenuItem
			// 
			this.managedClientToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.managedClientToolStripMenuItem.Name = "managedClientToolStripMenuItem";
			this.managedClientToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
			this.managedClientToolStripMenuItem.Text = "Manage Client";
			this.managedClientToolStripMenuItem.Click += new System.EventHandler(this.ManagedClientToolStripMenuItem_Click);
			// 
			// manageRoomToolStripMenuItem
			// 
			this.manageRoomToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.manageRoomToolStripMenuItem.Name = "manageRoomToolStripMenuItem";
			this.manageRoomToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
			this.manageRoomToolStripMenuItem.Text = "Manage Room";
			this.manageRoomToolStripMenuItem.Click += new System.EventHandler(this.ManageRoomToolStripMenuItem_Click);
			// 
			// manageReservationToolStripMenuItem
			// 
			this.manageReservationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.manageReservationToolStripMenuItem.Name = "manageReservationToolStripMenuItem";
			this.manageReservationToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
			this.manageReservationToolStripMenuItem.Text = "Manage Reservation";
			this.manageReservationToolStripMenuItem.Click += new System.EventHandler(this.ManageReservationToolStripMenuItem_Click);
			// 
			// logoutToolStripMenuItem
			// 
			this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
			this.logoutToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
			// 
			// HotelManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.RoyalBlue;
			this.ClientSize = new System.Drawing.Size(909, 471);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "HotelManager";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "HotelManager";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HotelManager_FormClosed);
			this.Load += new System.EventHandler(this.HotelManager_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem managedClientToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem manageRoomToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem manageReservationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
	}
}