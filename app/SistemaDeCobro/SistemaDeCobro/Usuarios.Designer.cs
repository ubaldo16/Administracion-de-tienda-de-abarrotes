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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Privilegio = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Pass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textApellidoM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textApellidoP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textTel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textCol = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textNumExt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textCP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textCalle = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textRFC = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButAdd
            // 
            this.ButAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ButAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButAdd.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButAdd.ForeColor = System.Drawing.Color.White;
            this.ButAdd.Location = new System.Drawing.Point(345, 472);
            this.ButAdd.Name = "ButAdd";
            this.ButAdd.Size = new System.Drawing.Size(87, 34);
            this.ButAdd.TabIndex = 12;
            this.ButAdd.Text = "Agregar";
            this.ButAdd.UseVisualStyleBackColor = false;
            this.ButAdd.Click += new System.EventHandler(this.ButAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(336, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 101);
            this.pictureBox1.TabIndex = 99;
            this.pictureBox1.TabStop = false;
            // 
            // Privilegio
            // 
            this.Privilegio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Privilegio.FormattingEnabled = true;
            this.Privilegio.Items.AddRange(new object[] {
            "Administrador",
            "Empleado"});
            this.Privilegio.Location = new System.Drawing.Point(85, 408);
            this.Privilegio.Name = "Privilegio";
            this.Privilegio.Size = new System.Drawing.Size(130, 21);
            this.Privilegio.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(265, 415);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 14);
            this.label6.TabIndex = 98;
            this.label6.Text = "Contraseña";
            // 
            // Pass
            // 
            this.Pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pass.Location = new System.Drawing.Point(360, 409);
            this.Pass.MaxLength = 20;
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(138, 20);
            this.Pass.TabIndex = 11;
            this.Pass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 14);
            this.label4.TabIndex = 96;
            this.label4.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 14);
            this.label2.TabIndex = 95;
            this.label2.Text = "Nombre";
            // 
            // textNombre
            // 
            this.textNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNombre.Location = new System.Drawing.Point(85, 226);
            this.textNombre.MaxLength = 20;
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(138, 20);
            this.textNombre.TabIndex = 2;
            this.textNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNombre_KeyPress);
            // 
            // textApellidoM
            // 
            this.textApellidoM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textApellidoM.Location = new System.Drawing.Point(637, 226);
            this.textApellidoM.MaxLength = 20;
            this.textApellidoM.Name = "textApellidoM";
            this.textApellidoM.Size = new System.Drawing.Size(138, 20);
            this.textApellidoM.TabIndex = 4;
            this.textApellidoM.TextChanged += new System.EventHandler(this.textApellidoM_TextChanged);
            this.textApellidoM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textApellidoM_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(537, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 14);
            this.label1.TabIndex = 103;
            this.label1.Text = "Apellido Materno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(261, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 14);
            this.label3.TabIndex = 105;
            this.label3.Text = "Apellido Paterno";
            // 
            // textApellidoP
            // 
            this.textApellidoP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textApellidoP.Location = new System.Drawing.Point(360, 226);
            this.textApellidoP.MaxLength = 20;
            this.textApellidoP.Name = "textApellidoP";
            this.textApellidoP.Size = new System.Drawing.Size(138, 20);
            this.textApellidoP.TabIndex = 3;
            this.textApellidoP.TextChanged += new System.EventHandler(this.textApellidoP_TextChanged);
            this.textApellidoP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textApellidoP_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(265, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 14);
            this.label7.TabIndex = 107;
            this.label7.Text = "Telefono";
            // 
            // textTel
            // 
            this.textTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTel.Location = new System.Drawing.Point(360, 339);
            this.textTel.MaxLength = 20;
            this.textTel.Name = "textTel";
            this.textTel.Size = new System.Drawing.Size(138, 20);
            this.textTel.TabIndex = 9;
            this.textTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTel_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(537, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 14);
            this.label8.TabIndex = 109;
            this.label8.Text = "Colonia";
            // 
            // textCol
            // 
            this.textCol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textCol.Location = new System.Drawing.Point(637, 293);
            this.textCol.MaxLength = 20;
            this.textCol.Name = "textCol";
            this.textCol.Size = new System.Drawing.Size(138, 20);
            this.textCol.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(261, 301);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 14);
            this.label9.TabIndex = 111;
            this.label9.Text = "Numero Exterior";
            // 
            // textNumExt
            // 
            this.textNumExt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNumExt.Location = new System.Drawing.Point(360, 295);
            this.textNumExt.MaxLength = 20;
            this.textNumExt.Name = "textNumExt";
            this.textNumExt.Size = new System.Drawing.Size(138, 20);
            this.textNumExt.TabIndex = 6;
            this.textNumExt.TextChanged += new System.EventHandler(this.textNumExt_TextChanged);
            this.textNumExt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNumExt_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 341);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 14);
            this.label10.TabIndex = 113;
            this.label10.Text = "C. P.";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // textCP
            // 
            this.textCP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textCP.Location = new System.Drawing.Point(85, 339);
            this.textCP.MaxLength = 20;
            this.textCP.Name = "textCP";
            this.textCP.Size = new System.Drawing.Size(138, 20);
            this.textCP.TabIndex = 8;
            this.textCP.TextChanged += new System.EventHandler(this.textCP_TextChanged);
            this.textCP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCP_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 14);
            this.label5.TabIndex = 115;
            this.label5.Text = "Calle";
            // 
            // textCalle
            // 
            this.textCalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textCalle.Location = new System.Drawing.Point(85, 293);
            this.textCalle.MaxLength = 20;
            this.textCalle.Name = "textCalle";
            this.textCalle.Size = new System.Drawing.Size(138, 20);
            this.textCalle.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(21, 192);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 14);
            this.label11.TabIndex = 117;
            this.label11.Text = "RFC";
            // 
            // textRFC
            // 
            this.textRFC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textRFC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textRFC.Location = new System.Drawing.Point(85, 186);
            this.textRFC.MaxLength = 13;
            this.textRFC.Name = "textRFC";
            this.textRFC.Size = new System.Drawing.Size(138, 20);
            this.textRFC.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.MediumBlue;
            this.label13.Location = new System.Drawing.Point(258, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(268, 31);
            this.label13.TabIndex = 143;
            this.label13.Text = "Registro de Usuarios";
            // 
            // FormularioUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(787, 534);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textRFC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textCalle);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textCP);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textNumExt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textCol);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textTel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textApellidoP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textApellidoM);
            this.Controls.Add(this.ButAdd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Privilegio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Pass);
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
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ComboBox Privilegio;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox Pass;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textApellidoM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textApellidoP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textTel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textCol;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textNumExt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textCP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textCalle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textRFC;
        private System.Windows.Forms.Label label13;
    }
}