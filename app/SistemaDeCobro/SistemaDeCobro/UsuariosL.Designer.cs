namespace SistemaDeCobro
{
	partial class UsuariosL
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.buttonSelection = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.ButDelete = new System.Windows.Forms.Button();
			this.Modificar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonSelection
			// 
			this.buttonSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.buttonSelection.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSelection.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSelection.ForeColor = System.Drawing.Color.White;
			this.buttonSelection.Location = new System.Drawing.Point(172, 417);
			this.buttonSelection.Name = "buttonSelection";
			this.buttonSelection.Size = new System.Drawing.Size(93, 39);
			this.buttonSelection.TabIndex = 91;
			this.buttonSelection.Text = "Seleccionar";
			this.buttonSelection.UseVisualStyleBackColor = false;
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(118, 109);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(540, 272);
			this.dataGridView1.TabIndex = 90;
			// 
			// ButDelete
			// 
			this.ButDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.ButDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButDelete.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButDelete.ForeColor = System.Drawing.Color.White;
			this.ButDelete.Location = new System.Drawing.Point(337, 417);
			this.ButDelete.Name = "ButDelete";
			this.ButDelete.Size = new System.Drawing.Size(94, 39);
			this.ButDelete.TabIndex = 103;
			this.ButDelete.Text = "Eliminar";
			this.ButDelete.UseVisualStyleBackColor = false;
			this.ButDelete.Click += new System.EventHandler(this.ButDelete_Click);
			// 
			// Modificar
			// 
			this.Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Modificar.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Modificar.ForeColor = System.Drawing.Color.White;
			this.Modificar.Location = new System.Drawing.Point(494, 417);
			this.Modificar.Name = "Modificar";
			this.Modificar.Size = new System.Drawing.Size(94, 39);
			this.Modificar.TabIndex = 104;
			this.Modificar.Text = "Modificar";
			this.Modificar.UseVisualStyleBackColor = false;
			this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
			// 
			// UsuariosL
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(787, 534);
			this.Controls.Add(this.Modificar);
			this.Controls.Add(this.ButDelete);
			this.Controls.Add(this.buttonSelection);
			this.Controls.Add(this.dataGridView1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "UsuariosL";
			this.Text = "UsuariosL";
			this.Load += new System.EventHandler(this.UsuariosL_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button buttonSelection;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button ButDelete;
        private System.Windows.Forms.Button Modificar;
    }
}