namespace HotelManagement
{
	partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.text_username = new System.Windows.Forms.TextBox();
			this.text_password = new System.Windows.Forms.TextBox();
			this.link_signup = new System.Windows.Forms.LinkLabel();
			this.btn_sign_in = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// text_username
			// 
			this.text_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.text_username.Location = new System.Drawing.Point(12, 306);
			this.text_username.Name = "text_username";
			this.text_username.Size = new System.Drawing.Size(585, 38);
			this.text_username.TabIndex = 0;
			// 
			// text_password
			// 
			this.text_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.text_password.Location = new System.Drawing.Point(12, 394);
			this.text_password.Name = "text_password";
			this.text_password.PasswordChar = '*';
			this.text_password.Size = new System.Drawing.Size(585, 38);
			this.text_password.TabIndex = 1;
			// 
			// link_signup
			// 
			this.link_signup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.link_signup.AutoSize = true;
			this.link_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.link_signup.Location = new System.Drawing.Point(247, 549);
			this.link_signup.Name = "link_signup";
			this.link_signup.Size = new System.Drawing.Size(110, 31);
			this.link_signup.TabIndex = 4;
			this.link_signup.TabStop = true;
			this.link_signup.Text = "Sign Up";
			this.link_signup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_signup_LinkClicked);
			// 
			// btn_sign_in
			// 
			this.btn_sign_in.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_sign_in.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btn_sign_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_sign_in.Location = new System.Drawing.Point(209, 438);
			this.btn_sign_in.Name = "btn_sign_in";
			this.btn_sign_in.Size = new System.Drawing.Size(219, 45);
			this.btn_sign_in.TabIndex = 6;
			this.btn_sign_in.Text = "Sign in";
			this.btn_sign_in.UseVisualStyleBackColor = false;
			this.btn_sign_in.Click += new System.EventHandler(this.Btn_signin_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(165, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(286, 244);
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(242, 272);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(139, 31);
			this.label1.TabIndex = 8;
			this.label1.Text = "Username";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(247, 360);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(134, 31);
			this.label2.TabIndex = 8;
			this.label2.Text = "Password";
			// 
			// Login
			// 
			this.AcceptButton = this.btn_sign_in;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.Highlight;
			this.ClientSize = new System.Drawing.Size(601, 589);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btn_sign_in);
			this.Controls.Add(this.link_signup);
			this.Controls.Add(this.text_password);
			this.Controls.Add(this.text_username);
			this.MaximizeBox = false;
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login ";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox text_username;
		private System.Windows.Forms.TextBox text_password;
		private System.Windows.Forms.LinkLabel link_signup;
		private System.Windows.Forms.Button btn_sign_in;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

