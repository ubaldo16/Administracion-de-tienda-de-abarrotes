namespace SistemaDeCobro
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.MemberLab = new System.Windows.Forms.Label();
			this.PasLabel = new System.Windows.Forms.Label();
			this.userLabel = new System.Windows.Forms.Label();
			this.buttonLog = new System.Windows.Forms.Button();
			this.textBoxPass = new System.Windows.Forms.TextBox();
			this.textboxUser = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.MemberLab);
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(176, 239);
			this.panel1.TabIndex = 90;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(33, 100);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(107, 117);
			this.pictureBox1.TabIndex = 83;
			this.pictureBox1.TabStop = false;
			// 
			// MemberLab
			// 
			this.MemberLab.AutoSize = true;
			this.MemberLab.BackColor = System.Drawing.Color.Transparent;
			this.MemberLab.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MemberLab.ForeColor = System.Drawing.SystemColors.Info;
			this.MemberLab.Location = new System.Drawing.Point(10, 51);
			this.MemberLab.Name = "MemberLab";
			this.MemberLab.Size = new System.Drawing.Size(149, 27);
			this.MemberLab.TabIndex = 82;
			this.MemberLab.Text = "Inicia Sesion";
			// 
			// PasLabel
			// 
			this.PasLabel.AutoSize = true;
			this.PasLabel.BackColor = System.Drawing.Color.Transparent;
			this.PasLabel.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PasLabel.Location = new System.Drawing.Point(208, 118);
			this.PasLabel.Name = "PasLabel";
			this.PasLabel.Size = new System.Drawing.Size(67, 14);
			this.PasLabel.TabIndex = 87;
			this.PasLabel.Text = "Contraseña";
			// 
			// userLabel
			// 
			this.userLabel.AutoSize = true;
			this.userLabel.BackColor = System.Drawing.Color.Transparent;
			this.userLabel.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.userLabel.Location = new System.Drawing.Point(247, 65);
			this.userLabel.Name = "userLabel";
			this.userLabel.Size = new System.Drawing.Size(28, 14);
			this.userLabel.TabIndex = 88;
			this.userLabel.Text = "RFC";
			// 
			// buttonLog
			// 
			this.buttonLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.buttonLog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLog.BackgroundImage")));
			this.buttonLog.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
			this.buttonLog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.buttonLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonLog.Location = new System.Drawing.Point(231, 179);
			this.buttonLog.Name = "buttonLog";
			this.buttonLog.Size = new System.Drawing.Size(120, 53);
			this.buttonLog.TabIndex = 89;
			this.buttonLog.UseVisualStyleBackColor = false;
			this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
			// 
			// textBoxPass
			// 
			this.textBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxPass.Location = new System.Drawing.Point(290, 116);
			this.textBoxPass.MaxLength = 20;
			this.textBoxPass.Name = "textBoxPass";
			this.textBoxPass.Size = new System.Drawing.Size(100, 20);
			this.textBoxPass.TabIndex = 86;
			this.textBoxPass.UseSystemPasswordChar = true;
			// 
			// textboxUser
			// 
			this.textboxUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textboxUser.Location = new System.Drawing.Point(290, 67);
			this.textboxUser.MaxLength = 20;
			this.textboxUser.Name = "textboxUser";
			this.textboxUser.Size = new System.Drawing.Size(100, 20);
			this.textboxUser.TabIndex = 85;
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(412, 243);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.PasLabel);
			this.Controls.Add(this.userLabel);
			this.Controls.Add(this.buttonLog);
			this.Controls.Add(this.textBoxPass);
			this.Controls.Add(this.textboxUser);
			this.Name = "Login";
			this.Text = "Login";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label MemberLab;
		private System.Windows.Forms.Label PasLabel;
		private System.Windows.Forms.Label userLabel;
		private System.Windows.Forms.Button buttonLog;
		private System.Windows.Forms.TextBox textBoxPass;
		private System.Windows.Forms.TextBox textboxUser;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}