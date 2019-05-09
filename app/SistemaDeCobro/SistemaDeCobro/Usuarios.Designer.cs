namespace SistemaDeCobro
{
	partial class FormularioUsuarios
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioUsuarios));
			this.ButAdd = new System.Windows.Forms.Button();
			this.butSearch = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.comboType = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.Pass = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.PassRep = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textNombre = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// ButAdd
			// 
			this.ButAdd.BackColor = System.Drawing.Color.DarkCyan;
			this.ButAdd.Enabled = false;
			this.ButAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButAdd.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButAdd.ForeColor = System.Drawing.Color.White;
			this.ButAdd.Location = new System.Drawing.Point(302, 328);
			this.ButAdd.Name = "ButAdd";
			this.ButAdd.Size = new System.Drawing.Size(87, 34);
			this.ButAdd.TabIndex = 101;
			this.ButAdd.Text = "Agregar";
			this.ButAdd.UseVisualStyleBackColor = false;
			// 
			// butSearch
			// 
			this.butSearch.BackColor = System.Drawing.Color.DarkCyan;
			this.butSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.butSearch.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.butSearch.ForeColor = System.Drawing.Color.White;
			this.butSearch.Location = new System.Drawing.Point(540, 63);
			this.butSearch.Name = "butSearch";
			this.butSearch.Size = new System.Drawing.Size(87, 34);
			this.butSearch.TabIndex = 100;
			this.butSearch.Text = "Buscar";
			this.butSearch.UseVisualStyleBackColor = false;
			this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(302, 63);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(96, 101);
			this.pictureBox1.TabIndex = 99;
			this.pictureBox1.TabStop = false;
			// 
			// comboType
			// 
			this.comboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboType.Enabled = false;
			this.comboType.FormattingEnabled = true;
			this.comboType.Items.AddRange(new object[] {
            "admin",
            "super",
            "capture"});
			this.comboType.Location = new System.Drawing.Point(248, 258);
			this.comboType.Name = "comboType";
			this.comboType.Size = new System.Drawing.Size(189, 21);
			this.comboType.TabIndex = 94;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(165, 205);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(67, 14);
			this.label6.TabIndex = 98;
			this.label6.Text = "Contraseña";
			// 
			// Pass
			// 
			this.Pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Pass.Enabled = false;
			this.Pass.Location = new System.Drawing.Point(248, 199);
			this.Pass.MaxLength = 20;
			this.Pass.Name = "Pass";
			this.Pass.Size = new System.Drawing.Size(189, 20);
			this.Pass.TabIndex = 92;
			this.Pass.UseSystemPasswordChar = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(123, 233);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(109, 14);
			this.label5.TabIndex = 97;
			this.label5.Text = "Repetir contraseña";
			// 
			// PassRep
			// 
			this.PassRep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PassRep.Enabled = false;
			this.PassRep.Location = new System.Drawing.Point(248, 231);
			this.PassRep.MaxLength = 20;
			this.PassRep.Name = "PassRep";
			this.PassRep.Size = new System.Drawing.Size(189, 20);
			this.PassRep.TabIndex = 93;
			this.PassRep.UseSystemPasswordChar = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(143, 265);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(89, 14);
			this.label4.TabIndex = 96;
			this.label4.Text = "Tipo de usuario";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(185, 177);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 14);
			this.label2.TabIndex = 95;
			this.label2.Text = "Nombre";
			// 
			// textNombre
			// 
			this.textNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textNombre.Location = new System.Drawing.Point(248, 171);
			this.textNombre.MaxLength = 20;
			this.textNombre.Name = "textNombre";
			this.textNombre.Size = new System.Drawing.Size(189, 20);
			this.textNombre.TabIndex = 91;
			// 
			// FormularioUsuarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(675, 395);
			this.Controls.Add(this.ButAdd);
			this.Controls.Add(this.butSearch);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.comboType);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.Pass);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.PassRep);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textNombre);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormularioUsuarios";
			this.Text = "Usuarios";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button ButAdd;
		private System.Windows.Forms.Button butSearch;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ComboBox comboType;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox Pass;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox PassRep;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textNombre;
	}
}