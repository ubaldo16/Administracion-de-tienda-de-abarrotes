﻿namespace SistemaDeCobro
{
	partial class Proveedores
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proveedores));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label11 = new System.Windows.Forms.Label();
			this.textRFC = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textNombre = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textCalle = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.textCP = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.textNumExt = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textCol = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textTel = new System.Windows.Forms.TextBox();
			this.ButAdd = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.buttonBuscar = new System.Windows.Forms.Button();
			this.Modificar = new System.Windows.Forms.Button();
			this.ButDelete = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.Cancel = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(45, 199);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(56, 14);
			this.label11.TabIndex = 121;
			this.label11.Text = "* Usuario";
			// 
			// textRFC
			// 
			this.textRFC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textRFC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.textRFC.Location = new System.Drawing.Point(102, 197);
			this.textRFC.MaxLength = 13;
			this.textRFC.Name = "textRFC";
			this.textRFC.Size = new System.Drawing.Size(138, 20);
			this.textRFC.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(264, 199);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 14);
			this.label2.TabIndex = 119;
			this.label2.Text = "* Nombre";
			// 
			// textNombre
			// 
			this.textNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textNombre.Location = new System.Drawing.Point(317, 197);
			this.textNombre.MaxLength = 20;
			this.textNombre.Name = "textNombre";
			this.textNombre.Size = new System.Drawing.Size(138, 20);
			this.textNombre.TabIndex = 2;
			this.textNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNombre_KeyPress);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(44, 261);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(41, 14);
			this.label5.TabIndex = 129;
			this.label5.Text = "* Calle";
			// 
			// textCalle
			// 
			this.textCalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textCalle.Location = new System.Drawing.Point(102, 257);
			this.textCalle.MaxLength = 20;
			this.textCalle.Name = "textCalle";
			this.textCalle.Size = new System.Drawing.Size(138, 20);
			this.textCalle.TabIndex = 3;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(45, 299);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(40, 14);
			this.label10.TabIndex = 127;
			this.label10.Text = "* C. P.";
			// 
			// textCP
			// 
			this.textCP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textCP.Location = new System.Drawing.Point(102, 297);
			this.textCP.MaxLength = 20;
			this.textCP.Name = "textCP";
			this.textCP.Size = new System.Drawing.Size(138, 20);
			this.textCP.TabIndex = 7;
			this.textCP.TextChanged += new System.EventHandler(this.textCP_TextChanged);
			this.textCP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCP_KeyPress);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(484, 261);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(102, 14);
			this.label9.TabIndex = 125;
			this.label9.Text = "* Número Exterior";
			// 
			// textNumExt
			// 
			this.textNumExt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textNumExt.Location = new System.Drawing.Point(593, 259);
			this.textNumExt.MaxLength = 20;
			this.textNumExt.Name = "textNumExt";
			this.textNumExt.Size = new System.Drawing.Size(138, 20);
			this.textNumExt.TabIndex = 5;
			this.textNumExt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNumExt_KeyPress);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(264, 261);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(54, 14);
			this.label8.TabIndex = 123;
			this.label8.Text = "* Colonia";
			// 
			// textCol
			// 
			this.textCol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textCol.Location = new System.Drawing.Point(317, 259);
			this.textCol.MaxLength = 20;
			this.textCol.Name = "textCol";
			this.textCol.Size = new System.Drawing.Size(138, 20);
			this.textCol.TabIndex = 4;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(45, 358);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(60, 14);
			this.label7.TabIndex = 131;
			this.label7.Text = "* Teléfono";
			// 
			// textTel
			// 
			this.textTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textTel.Location = new System.Drawing.Point(102, 356);
			this.textTel.MaxLength = 20;
			this.textTel.Name = "textTel";
			this.textTel.Size = new System.Drawing.Size(138, 20);
			this.textTel.TabIndex = 8;
			this.textTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTel_KeyPress);
			// 
			// ButAdd
			// 
			this.ButAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.ButAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButAdd.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButAdd.ForeColor = System.Drawing.Color.White;
			this.ButAdd.Location = new System.Drawing.Point(321, 449);
			this.ButAdd.Name = "ButAdd";
			this.ButAdd.Size = new System.Drawing.Size(87, 34);
			this.ButAdd.TabIndex = 9;
			this.ButAdd.Text = "Agregar";
			this.ButAdd.UseVisualStyleBackColor = false;
			this.ButAdd.Click += new System.EventHandler(this.ButAdd_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(321, 53);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(123, 112);
			this.pictureBox1.TabIndex = 134;
			this.pictureBox1.TabStop = false;
			// 
			// buttonBuscar
			// 
			this.buttonBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonBuscar.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonBuscar.ForeColor = System.Drawing.Color.White;
			this.buttonBuscar.Location = new System.Drawing.Point(656, 53);
			this.buttonBuscar.Name = "buttonBuscar";
			this.buttonBuscar.Size = new System.Drawing.Size(87, 34);
			this.buttonBuscar.TabIndex = 10;
			this.buttonBuscar.Text = "Buscar";
			this.buttonBuscar.UseVisualStyleBackColor = false;
			this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
			// 
			// Modificar
			// 
			this.Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Modificar.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Modificar.ForeColor = System.Drawing.Color.White;
			this.Modificar.Location = new System.Drawing.Point(503, 427);
			this.Modificar.Name = "Modificar";
			this.Modificar.Size = new System.Drawing.Size(94, 39);
			this.Modificar.TabIndex = 138;
			this.Modificar.Text = "Modificar";
			this.Modificar.UseVisualStyleBackColor = false;
			this.Modificar.Visible = false;
			this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
			// 
			// ButDelete
			// 
			this.ButDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.ButDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButDelete.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButDelete.ForeColor = System.Drawing.Color.White;
			this.ButDelete.Location = new System.Drawing.Point(334, 427);
			this.ButDelete.Name = "ButDelete";
			this.ButDelete.Size = new System.Drawing.Size(94, 39);
			this.ButDelete.TabIndex = 8;
			this.ButDelete.Text = "Eliminar";
			this.ButDelete.UseVisualStyleBackColor = false;
			this.ButDelete.Visible = false;
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(134, 93);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(514, 299);
			this.dataGridView1.TabIndex = 135;
			this.dataGridView1.Visible = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(29, 34);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(30, 25);
			this.button1.TabIndex = 10;
			this.button1.Text = "<";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Visible = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.MediumBlue;
			this.label1.Location = new System.Drawing.Point(247, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(270, 31);
			this.label1.TabIndex = 139;
			this.label1.Text = "Lista de Proveedores";
			this.label1.Visible = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.MediumBlue;
			this.label3.Location = new System.Drawing.Point(226, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(314, 31);
			this.label3.TabIndex = 140;
			this.label3.Text = "Registro de Proveedores";
			// 
			// Cancel
			// 
			this.Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Cancel.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Cancel.ForeColor = System.Drawing.Color.White;
			this.Cancel.Location = new System.Drawing.Point(584, 432);
			this.Cancel.Name = "Cancel";
			this.Cancel.Size = new System.Drawing.Size(87, 34);
			this.Cancel.TabIndex = 145;
			this.Cancel.Text = "Cancelar";
			this.Cancel.UseVisualStyleBackColor = false;
			this.Cancel.Visible = false;
			this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(287, 432);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(153, 34);
			this.button2.TabIndex = 144;
			this.button2.Text = "Modificar Registro";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Visible = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.MediumBlue;
			this.label4.Location = new System.Drawing.Point(198, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(363, 31);
			this.label4.TabIndex = 146;
			this.label4.Text = "Modificación de Proveedores";
			this.label4.Visible = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Britannic Bold", 9F);
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(529, 427);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(197, 14);
			this.label6.TabIndex = 147;
			this.label6.Text = "* Todos los campos son obligatorios";
			// 
			// Proveedores
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(771, 495);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.Cancel);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Modificar);
			this.Controls.Add(this.ButDelete);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.buttonBuscar);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.ButAdd);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textTel);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textCalle);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.textCP);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.textNumExt);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.textCol);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.textRFC);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textNombre);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Proveedores";
			this.Text = "Proveedores";
			this.Load += new System.EventHandler(this.Proveedores_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textRFC;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textNombre;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textCalle;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textCP;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textNumExt;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textCol;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textTel;
		private System.Windows.Forms.Button ButAdd;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button buttonBuscar;
		private System.Windows.Forms.Button Modificar;
		private System.Windows.Forms.Button ButDelete;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button Cancel;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
	}
}