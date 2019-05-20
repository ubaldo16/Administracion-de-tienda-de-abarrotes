namespace SistemaDeCobro
{
	partial class ProveedoresL
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.Modificar = new System.Windows.Forms.Button();
			this.ButDelete = new System.Windows.Forms.Button();
			this.buttonSelection = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// Modificar
			// 
			this.Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Modificar.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Modificar.ForeColor = System.Drawing.Color.White;
			this.Modificar.Location = new System.Drawing.Point(512, 382);
			this.Modificar.Name = "Modificar";
			this.Modificar.Size = new System.Drawing.Size(94, 39);
			this.Modificar.TabIndex = 108;
			this.Modificar.Text = "Modificar";
			this.Modificar.UseVisualStyleBackColor = false;
			// 
			// ButDelete
			// 
			this.ButDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.ButDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButDelete.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButDelete.ForeColor = System.Drawing.Color.White;
			this.ButDelete.Location = new System.Drawing.Point(343, 382);
			this.ButDelete.Name = "ButDelete";
			this.ButDelete.Size = new System.Drawing.Size(94, 39);
			this.ButDelete.TabIndex = 107;
			this.ButDelete.Text = "Eliminar";
			this.ButDelete.UseVisualStyleBackColor = false;
			// 
			// buttonSelection
			// 
			this.buttonSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.buttonSelection.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSelection.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSelection.ForeColor = System.Drawing.Color.White;
			this.buttonSelection.Location = new System.Drawing.Point(172, 382);
			this.buttonSelection.Name = "buttonSelection";
			this.buttonSelection.Size = new System.Drawing.Size(93, 39);
			this.buttonSelection.TabIndex = 106;
			this.buttonSelection.Text = "Seleccionar";
			this.buttonSelection.UseVisualStyleBackColor = false;
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
			this.dataGridView1.Location = new System.Drawing.Point(145, 73);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(480, 272);
			this.dataGridView1.TabIndex = 105;
			// 
			// ProveedoresL
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(771, 495);
			this.Controls.Add(this.Modificar);
			this.Controls.Add(this.ButDelete);
			this.Controls.Add(this.buttonSelection);
			this.Controls.Add(this.dataGridView1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ProveedoresL";
			this.Text = "ProveedoresL";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Modificar;
		private System.Windows.Forms.Button ButDelete;
		private System.Windows.Forms.Button buttonSelection;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}