﻿namespace SistemaDeCobro
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButAdd
            // 
            this.ButAdd.BackColor = System.Drawing.Color.DarkCyan;
            this.ButAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButAdd.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButAdd.ForeColor = System.Drawing.Color.White;
            this.ButAdd.Location = new System.Drawing.Point(302, 328);
            this.ButAdd.Name = "ButAdd";
            this.ButAdd.Size = new System.Drawing.Size(87, 34);
            this.ButAdd.TabIndex = 101;
            this.ButAdd.Text = "Agregar";
            this.ButAdd.UseVisualStyleBackColor = false;
            this.ButAdd.Click += new System.EventHandler(this.ButAdd_Click);
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
            this.pictureBox1.Location = new System.Drawing.Point(293, 12);
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
            "admin",
            "super",
            "capture"});
            this.Privilegio.Location = new System.Drawing.Point(260, 287);
            this.Privilegio.Name = "Privilegio";
            this.Privilegio.Size = new System.Drawing.Size(189, 21);
            this.Privilegio.TabIndex = 94;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(352, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 14);
            this.label6.TabIndex = 98;
            this.label6.Text = "Contraseña";
            // 
            // Pass
            // 
            this.Pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pass.Location = new System.Drawing.Point(425, 228);
            this.Pass.MaxLength = 20;
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(189, 20);
            this.Pass.TabIndex = 92;
            this.Pass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(155, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 14);
            this.label4.TabIndex = 96;
            this.label4.Text = "Tipo de usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 14);
            this.label2.TabIndex = 95;
            this.label2.Text = "Nombre";
            // 
            // textNombre
            // 
            this.textNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNombre.Location = new System.Drawing.Point(127, 150);
            this.textNombre.MaxLength = 20;
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(189, 20);
            this.textNombre.TabIndex = 91;
            // 
            // textApellidoM
            // 
            this.textApellidoM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textApellidoM.Location = new System.Drawing.Point(127, 178);
            this.textApellidoM.MaxLength = 20;
            this.textApellidoM.Name = "textApellidoM";
            this.textApellidoM.Size = new System.Drawing.Size(189, 20);
            this.textApellidoM.TabIndex = 102;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 14);
            this.label1.TabIndex = 103;
            this.label1.Text = "Apellido Materno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 14);
            this.label3.TabIndex = 105;
            this.label3.Text = "Apellido Paterno";
            // 
            // textApellidoP
            // 
            this.textApellidoP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textApellidoP.Location = new System.Drawing.Point(127, 204);
            this.textApellidoP.MaxLength = 20;
            this.textApellidoP.Name = "textApellidoP";
            this.textApellidoP.Size = new System.Drawing.Size(189, 20);
            this.textApellidoP.TabIndex = 104;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(70, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 14);
            this.label7.TabIndex = 107;
            this.label7.Text = "Telefono";
            // 
            // textTel
            // 
            this.textTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTel.Location = new System.Drawing.Point(127, 230);
            this.textTel.MaxLength = 20;
            this.textTel.Name = "textTel";
            this.textTel.Size = new System.Drawing.Size(189, 20);
            this.textTel.TabIndex = 106;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(374, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 14);
            this.label8.TabIndex = 109;
            this.label8.Text = "Colonia";
            // 
            // textCol
            // 
            this.textCol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textCol.Location = new System.Drawing.Point(425, 150);
            this.textCol.MaxLength = 20;
            this.textCol.Name = "textCol";
            this.textCol.Size = new System.Drawing.Size(189, 20);
            this.textCol.TabIndex = 108;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(326, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 14);
            this.label9.TabIndex = 111;
            this.label9.Text = "Numero Exterior";
            // 
            // textNumExt
            // 
            this.textNumExt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNumExt.Location = new System.Drawing.Point(425, 176);
            this.textNumExt.MaxLength = 20;
            this.textNumExt.Name = "textNumExt";
            this.textNumExt.Size = new System.Drawing.Size(189, 20);
            this.textNumExt.TabIndex = 110;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(342, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 14);
            this.label10.TabIndex = 113;
            this.label10.Text = "Codigo Postal";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // textCP
            // 
            this.textCP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textCP.Location = new System.Drawing.Point(425, 202);
            this.textCP.MaxLength = 20;
            this.textCP.Name = "textCP";
            this.textCP.Size = new System.Drawing.Size(189, 20);
            this.textCP.TabIndex = 112;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(387, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 14);
            this.label5.TabIndex = 115;
            this.label5.Text = "Calle";
            // 
            // textCalle
            // 
            this.textCalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textCalle.Location = new System.Drawing.Point(425, 124);
            this.textCalle.MaxLength = 20;
            this.textCalle.Name = "textCalle";
            this.textCalle.Size = new System.Drawing.Size(189, 20);
            this.textCalle.TabIndex = 114;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(93, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 14);
            this.label11.TabIndex = 117;
            this.label11.Text = "RFC";
            // 
            // textRFC
            // 
            this.textRFC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textRFC.Location = new System.Drawing.Point(127, 124);
            this.textRFC.MaxLength = 20;
            this.textRFC.Name = "textRFC";
            this.textRFC.Size = new System.Drawing.Size(189, 20);
            this.textRFC.TabIndex = 116;
            // 
            // FormularioUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(675, 395);
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
            this.Controls.Add(this.butSearch);
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
		private System.Windows.Forms.Button butSearch;
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
    }
}