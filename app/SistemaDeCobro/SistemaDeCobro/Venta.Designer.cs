namespace SistemaDeCobro
{
    partial class Venta
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
			this.components = new System.ComponentModel.Container();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.subtotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Inventario_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.detalleventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.sDCDataSet = new SistemaDeCobro.SDCDataSet();
			this.detalle_ventaTableAdapter = new SistemaDeCobro.SDCDataSetTableAdapters.Detalle_ventaTableAdapter();
			this.tabla_uso = new System.Windows.Forms.DataGridView();
			this.idInventarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cantidadDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.caducidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.perecederoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.inventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.inventarioTableAdapter = new SistemaDeCobro.SDCDataSetTableAdapters.InventarioTableAdapter();
			this.Subtotal_lab = new System.Windows.Forms.Label();
			this.Subtotal_box = new System.Windows.Forms.TextBox();
			this.Cambio_tex = new System.Windows.Forms.TextBox();
			this.efectiv_tex = new System.Windows.Forms.TextBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.ID_emp_tex = new System.Windows.Forms.TextBox();
			this.Id_venta_tex = new System.Windows.Forms.TextBox();
			this.Cambio_label = new System.Windows.Forms.Label();
			this.Fecha_label = new System.Windows.Forms.Label();
			this.ID_venta_label = new System.Windows.Forms.Label();
			this.ID_empl_label = new System.Windows.Forms.Label();
			this.Cancelar = new System.Windows.Forms.Button();
			this.Modificar = new System.Windows.Forms.Button();
			this.Insertar = new System.Windows.Forms.Button();
			this.Precio_lab = new System.Windows.Forms.Label();
			this.Cantidad_labe = new System.Windows.Forms.Label();
			this.Nombre_lab = new System.Windows.Forms.Label();
			this.ID_labe = new System.Windows.Forms.Label();
			this.Precio = new System.Windows.Forms.TextBox();
			this.Cantidad = new System.Windows.Forms.TextBox();
			this.Nombre = new System.Windows.Forms.TextBox();
			this.total_box = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.idVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.empleadoRFCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idDetalleVentaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.ventaTableAdapter = new SistemaDeCobro.SDCDataSetTableAdapters.VentaTableAdapter();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.detalleventaBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sDCDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tabla_uso)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cantidadDataGridViewTextBoxColumn,
            this.subtotalDataGridViewTextBoxColumn,
            this.Inventario_Id});
			this.dataGridView1.DataSource = this.detalleventaBindingSource;
			this.dataGridView1.Enabled = false;
			this.dataGridView1.Location = new System.Drawing.Point(77, 21);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(345, 353);
			this.dataGridView1.TabIndex = 0;
			// 
			// cantidadDataGridViewTextBoxColumn
			// 
			this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
			this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
			this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
			// 
			// subtotalDataGridViewTextBoxColumn
			// 
			this.subtotalDataGridViewTextBoxColumn.DataPropertyName = "Subtotal";
			this.subtotalDataGridViewTextBoxColumn.HeaderText = "Subtotal";
			this.subtotalDataGridViewTextBoxColumn.Name = "subtotalDataGridViewTextBoxColumn";
			// 
			// Inventario_Id
			// 
			this.Inventario_Id.DataPropertyName = "Inventario_Id";
			this.Inventario_Id.HeaderText = "Inventario_Id";
			this.Inventario_Id.Name = "Inventario_Id";
			// 
			// detalleventaBindingSource
			// 
			this.detalleventaBindingSource.DataMember = "Detalle_venta";
			this.detalleventaBindingSource.DataSource = this.sDCDataSet;
			// 
			// sDCDataSet
			// 
			this.sDCDataSet.DataSetName = "SDCDataSet";
			this.sDCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// detalle_ventaTableAdapter
			// 
			this.detalle_ventaTableAdapter.ClearBeforeFill = true;
			// 
			// tabla_uso
			// 
			this.tabla_uso.AutoGenerateColumns = false;
			this.tabla_uso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tabla_uso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idInventarioDataGridViewTextBoxColumn,
            this.idProveedorDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn1,
            this.caducidadDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.perecederoDataGridViewTextBoxColumn});
			this.tabla_uso.DataSource = this.inventarioBindingSource;
			this.tabla_uso.Location = new System.Drawing.Point(402, 407);
			this.tabla_uso.Name = "tabla_uso";
			this.tabla_uso.Size = new System.Drawing.Size(241, 45);
			this.tabla_uso.TabIndex = 1;
			this.tabla_uso.Visible = false;
			// 
			// idInventarioDataGridViewTextBoxColumn
			// 
			this.idInventarioDataGridViewTextBoxColumn.DataPropertyName = "Id_Inventario";
			this.idInventarioDataGridViewTextBoxColumn.HeaderText = "Id_Inventario";
			this.idInventarioDataGridViewTextBoxColumn.Name = "idInventarioDataGridViewTextBoxColumn";
			// 
			// idProveedorDataGridViewTextBoxColumn
			// 
			this.idProveedorDataGridViewTextBoxColumn.DataPropertyName = "Id_Proveedor";
			this.idProveedorDataGridViewTextBoxColumn.HeaderText = "Id_Proveedor";
			this.idProveedorDataGridViewTextBoxColumn.Name = "idProveedorDataGridViewTextBoxColumn";
			// 
			// nombreDataGridViewTextBoxColumn
			// 
			this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
			this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
			this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
			// 
			// cantidadDataGridViewTextBoxColumn1
			// 
			this.cantidadDataGridViewTextBoxColumn1.DataPropertyName = "Cantidad";
			this.cantidadDataGridViewTextBoxColumn1.HeaderText = "Cantidad";
			this.cantidadDataGridViewTextBoxColumn1.Name = "cantidadDataGridViewTextBoxColumn1";
			// 
			// caducidadDataGridViewTextBoxColumn
			// 
			this.caducidadDataGridViewTextBoxColumn.DataPropertyName = "Caducidad";
			this.caducidadDataGridViewTextBoxColumn.HeaderText = "Caducidad";
			this.caducidadDataGridViewTextBoxColumn.Name = "caducidadDataGridViewTextBoxColumn";
			// 
			// precioDataGridViewTextBoxColumn
			// 
			this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
			this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
			this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
			// 
			// perecederoDataGridViewTextBoxColumn
			// 
			this.perecederoDataGridViewTextBoxColumn.DataPropertyName = "Perecedero";
			this.perecederoDataGridViewTextBoxColumn.HeaderText = "Perecedero";
			this.perecederoDataGridViewTextBoxColumn.Name = "perecederoDataGridViewTextBoxColumn";
			// 
			// inventarioBindingSource
			// 
			this.inventarioBindingSource.DataMember = "Inventario";
			this.inventarioBindingSource.DataSource = this.sDCDataSet;
			// 
			// inventarioTableAdapter
			// 
			this.inventarioTableAdapter.ClearBeforeFill = true;
			// 
			// Subtotal_lab
			// 
			this.Subtotal_lab.AutoSize = true;
			this.Subtotal_lab.Font = new System.Drawing.Font("Britannic Bold", 9F);
			this.Subtotal_lab.Location = new System.Drawing.Point(442, 261);
			this.Subtotal_lab.Name = "Subtotal_lab";
			this.Subtotal_lab.Size = new System.Drawing.Size(50, 14);
			this.Subtotal_lab.TabIndex = 202;
			this.Subtotal_lab.Text = "Subtotal";
			// 
			// Subtotal_box
			// 
			this.Subtotal_box.Enabled = false;
			this.Subtotal_box.Location = new System.Drawing.Point(493, 258);
			this.Subtotal_box.Name = "Subtotal_box";
			this.Subtotal_box.Size = new System.Drawing.Size(100, 20);
			this.Subtotal_box.TabIndex = 201;
			// 
			// Cambio_tex
			// 
			this.Cambio_tex.Enabled = false;
			this.Cambio_tex.Location = new System.Drawing.Point(667, 298);
			this.Cambio_tex.Name = "Cambio_tex";
			this.Cambio_tex.Size = new System.Drawing.Size(76, 20);
			this.Cambio_tex.TabIndex = 200;
			// 
			// efectiv_tex
			// 
			this.efectiv_tex.Location = new System.Drawing.Point(667, 258);
			this.efectiv_tex.Name = "efectiv_tex";
			this.efectiv_tex.Size = new System.Drawing.Size(76, 20);
			this.efectiv_tex.TabIndex = 199;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(132, 446);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker1.TabIndex = 198;
			// 
			// ID_emp_tex
			// 
			this.ID_emp_tex.Enabled = false;
			this.ID_emp_tex.Location = new System.Drawing.Point(151, 415);
			this.ID_emp_tex.Name = "ID_emp_tex";
			this.ID_emp_tex.Size = new System.Drawing.Size(69, 20);
			this.ID_emp_tex.TabIndex = 197;
			// 
			// Id_venta_tex
			// 
			this.Id_venta_tex.Enabled = false;
			this.Id_venta_tex.Location = new System.Drawing.Point(151, 389);
			this.Id_venta_tex.Name = "Id_venta_tex";
			this.Id_venta_tex.Size = new System.Drawing.Size(69, 20);
			this.Id_venta_tex.TabIndex = 196;
			// 
			// Cambio_label
			// 
			this.Cambio_label.AutoSize = true;
			this.Cambio_label.Font = new System.Drawing.Font("Britannic Bold", 9F);
			this.Cambio_label.Location = new System.Drawing.Point(619, 301);
			this.Cambio_label.Name = "Cambio_label";
			this.Cambio_label.Size = new System.Drawing.Size(45, 14);
			this.Cambio_label.TabIndex = 195;
			this.Cambio_label.Text = "Cambio";
			// 
			// Fecha_label
			// 
			this.Fecha_label.AutoSize = true;
			this.Fecha_label.Font = new System.Drawing.Font("Britannic Bold", 9F);
			this.Fecha_label.Location = new System.Drawing.Point(75, 447);
			this.Fecha_label.Name = "Fecha_label";
			this.Fecha_label.Size = new System.Drawing.Size(41, 14);
			this.Fecha_label.TabIndex = 193;
			this.Fecha_label.Text = "Fecha:";
			// 
			// ID_venta_label
			// 
			this.ID_venta_label.AutoSize = true;
			this.ID_venta_label.Font = new System.Drawing.Font("Britannic Bold", 9F);
			this.ID_venta_label.Location = new System.Drawing.Point(75, 394);
			this.ID_venta_label.Name = "ID_venta_label";
			this.ID_venta_label.Size = new System.Drawing.Size(51, 14);
			this.ID_venta_label.TabIndex = 192;
			this.ID_venta_label.Text = "ID venta";
			// 
			// ID_empl_label
			// 
			this.ID_empl_label.AutoSize = true;
			this.ID_empl_label.Font = new System.Drawing.Font("Britannic Bold", 9F);
			this.ID_empl_label.Location = new System.Drawing.Point(75, 418);
			this.ID_empl_label.Name = "ID_empl_label";
			this.ID_empl_label.Size = new System.Drawing.Size(73, 14);
			this.ID_empl_label.TabIndex = 191;
			this.ID_empl_label.Text = "ID empleado";
			// 
			// Cancelar
			// 
			this.Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Cancelar.Font = new System.Drawing.Font("Britannic Bold", 9.75F);
			this.Cancelar.ForeColor = System.Drawing.Color.White;
			this.Cancelar.Location = new System.Drawing.Point(666, 423);
			this.Cancelar.Name = "Cancelar";
			this.Cancelar.Size = new System.Drawing.Size(87, 34);
			this.Cancelar.TabIndex = 190;
			this.Cancelar.Text = "Cancelar";
			this.Cancelar.UseVisualStyleBackColor = false;
			this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
			// 
			// Modificar
			// 
			this.Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Modificar.Font = new System.Drawing.Font("Britannic Bold", 9.75F);
			this.Modificar.ForeColor = System.Drawing.Color.White;
			this.Modificar.Location = new System.Drawing.Point(555, 361);
			this.Modificar.Name = "Modificar";
			this.Modificar.Size = new System.Drawing.Size(87, 34);
			this.Modificar.TabIndex = 189;
			this.Modificar.Text = "Pagar";
			this.Modificar.UseVisualStyleBackColor = false;
			this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
			// 
			// Insertar
			// 
			this.Insertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.Insertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Insertar.Font = new System.Drawing.Font("Britannic Bold", 9.75F);
			this.Insertar.ForeColor = System.Drawing.Color.White;
			this.Insertar.Location = new System.Drawing.Point(555, 168);
			this.Insertar.Name = "Insertar";
			this.Insertar.Size = new System.Drawing.Size(87, 34);
			this.Insertar.TabIndex = 188;
			this.Insertar.Text = "Agregar producto";
			this.Insertar.UseVisualStyleBackColor = false;
			this.Insertar.Click += new System.EventHandler(this.Insertar_Click);
			// 
			// Precio_lab
			// 
			this.Precio_lab.AutoSize = true;
			this.Precio_lab.Font = new System.Drawing.Font("Britannic Bold", 9F);
			this.Precio_lab.Location = new System.Drawing.Point(606, 98);
			this.Precio_lab.Name = "Precio_lab";
			this.Precio_lab.Size = new System.Drawing.Size(40, 14);
			this.Precio_lab.TabIndex = 187;
			this.Precio_lab.Text = "Precio";
			// 
			// Cantidad_labe
			// 
			this.Cantidad_labe.AutoSize = true;
			this.Cantidad_labe.BackColor = System.Drawing.Color.Transparent;
			this.Cantidad_labe.Font = new System.Drawing.Font("Britannic Bold", 9F);
			this.Cantidad_labe.Location = new System.Drawing.Point(444, 98);
			this.Cantidad_labe.Name = "Cantidad_labe";
			this.Cantidad_labe.Size = new System.Drawing.Size(52, 14);
			this.Cantidad_labe.TabIndex = 186;
			this.Cantidad_labe.Text = "Cantidad";
			// 
			// Nombre_lab
			// 
			this.Nombre_lab.AutoSize = true;
			this.Nombre_lab.Font = new System.Drawing.Font("Britannic Bold", 9F);
			this.Nombre_lab.Location = new System.Drawing.Point(606, 68);
			this.Nombre_lab.Name = "Nombre_lab";
			this.Nombre_lab.Size = new System.Drawing.Size(47, 14);
			this.Nombre_lab.TabIndex = 185;
			this.Nombre_lab.Text = "Nombre";
			// 
			// ID_labe
			// 
			this.ID_labe.AutoSize = true;
			this.ID_labe.BackColor = System.Drawing.Color.Transparent;
			this.ID_labe.Font = new System.Drawing.Font("Britannic Bold", 9F);
			this.ID_labe.Location = new System.Drawing.Point(446, 35);
			this.ID_labe.Name = "ID_labe";
			this.ID_labe.Size = new System.Drawing.Size(54, 14);
			this.ID_labe.TabIndex = 184;
			this.ID_labe.Text = "Producto";
			// 
			// Precio
			// 
			this.Precio.Enabled = false;
			this.Precio.Location = new System.Drawing.Point(659, 95);
			this.Precio.Name = "Precio";
			this.Precio.Size = new System.Drawing.Size(100, 20);
			this.Precio.TabIndex = 183;
			// 
			// Cantidad
			// 
			this.Cantidad.Location = new System.Drawing.Point(502, 98);
			this.Cantidad.Name = "Cantidad";
			this.Cantidad.Size = new System.Drawing.Size(68, 20);
			this.Cantidad.TabIndex = 182;
			this.Cantidad.TextChanged += new System.EventHandler(this.Cantidad_TextChanged);
			// 
			// Nombre
			// 
			this.Nombre.Enabled = false;
			this.Nombre.Location = new System.Drawing.Point(659, 65);
			this.Nombre.Name = "Nombre";
			this.Nombre.Size = new System.Drawing.Size(100, 20);
			this.Nombre.TabIndex = 181;
			// 
			// total_box
			// 
			this.total_box.Enabled = false;
			this.total_box.Location = new System.Drawing.Point(493, 294);
			this.total_box.Name = "total_box";
			this.total_box.Size = new System.Drawing.Size(100, 20);
			this.total_box.TabIndex = 203;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Britannic Bold", 9F);
			this.label1.Location = new System.Drawing.Point(446, 297);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 14);
			this.label1.TabIndex = 204;
			this.label1.Text = "Total";
			// 
			// dataGridView2
			// 
			this.dataGridView2.AutoGenerateColumns = false;
			this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVentaDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.empleadoRFCDataGridViewTextBoxColumn,
            this.idDetalleVentaDataGridViewTextBoxColumn1});
			this.dataGridView2.DataSource = this.ventaBindingSource;
			this.dataGridView2.Enabled = false;
			this.dataGridView2.Location = new System.Drawing.Point(42, 92);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(380, 277);
			this.dataGridView2.TabIndex = 205;
			this.dataGridView2.Visible = false;
			// 
			// idVentaDataGridViewTextBoxColumn
			// 
			this.idVentaDataGridViewTextBoxColumn.DataPropertyName = "IdVenta";
			this.idVentaDataGridViewTextBoxColumn.HeaderText = "IdVenta";
			this.idVentaDataGridViewTextBoxColumn.Name = "idVentaDataGridViewTextBoxColumn";
			// 
			// totalDataGridViewTextBoxColumn
			// 
			this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
			this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
			this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
			// 
			// fechaDataGridViewTextBoxColumn
			// 
			this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
			this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
			this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
			// 
			// empleadoRFCDataGridViewTextBoxColumn
			// 
			this.empleadoRFCDataGridViewTextBoxColumn.DataPropertyName = "Empleado_RFC";
			this.empleadoRFCDataGridViewTextBoxColumn.HeaderText = "Empleado_RFC";
			this.empleadoRFCDataGridViewTextBoxColumn.Name = "empleadoRFCDataGridViewTextBoxColumn";
			// 
			// idDetalleVentaDataGridViewTextBoxColumn1
			// 
			this.idDetalleVentaDataGridViewTextBoxColumn1.DataPropertyName = "Id_DetalleVenta";
			this.idDetalleVentaDataGridViewTextBoxColumn1.HeaderText = "Id_DetalleVenta";
			this.idDetalleVentaDataGridViewTextBoxColumn1.Name = "idDetalleVentaDataGridViewTextBoxColumn1";
			// 
			// ventaBindingSource
			// 
			this.ventaBindingSource.DataMember = "Venta";
			this.ventaBindingSource.DataSource = this.sDCDataSet;
			// 
			// ventaTableAdapter
			// 
			this.ventaTableAdapter.ClearBeforeFill = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Britannic Bold", 9F);
			this.label2.Location = new System.Drawing.Point(600, 261);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 14);
			this.label2.TabIndex = 206;
			this.label2.Text = "Efectivo ($)";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.MediumBlue;
			this.label4.Location = new System.Drawing.Point(568, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(85, 31);
			this.label4.TabIndex = 207;
			this.label4.Text = "Venta";
			this.label4.Visible = false;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(449, 61);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 208;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// Venta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(771, 495);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.total_box);
			this.Controls.Add(this.Subtotal_lab);
			this.Controls.Add(this.Subtotal_box);
			this.Controls.Add(this.Cambio_tex);
			this.Controls.Add(this.efectiv_tex);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.ID_emp_tex);
			this.Controls.Add(this.Id_venta_tex);
			this.Controls.Add(this.Cambio_label);
			this.Controls.Add(this.Fecha_label);
			this.Controls.Add(this.ID_venta_label);
			this.Controls.Add(this.ID_empl_label);
			this.Controls.Add(this.Cancelar);
			this.Controls.Add(this.Modificar);
			this.Controls.Add(this.Insertar);
			this.Controls.Add(this.Precio_lab);
			this.Controls.Add(this.Cantidad_labe);
			this.Controls.Add(this.Nombre_lab);
			this.Controls.Add(this.ID_labe);
			this.Controls.Add(this.Precio);
			this.Controls.Add(this.Cantidad);
			this.Controls.Add(this.Nombre);
			this.Controls.Add(this.tabla_uso);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.dataGridView2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Venta";
			this.Text = "Venta";
			this.Load += new System.EventHandler(this.Venta_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.detalleventaBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sDCDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tabla_uso)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SDCDataSet sDCDataSet;
        private System.Windows.Forms.BindingSource detalleventaBindingSource;
        private SDCDataSetTableAdapters.Detalle_ventaTableAdapter detalle_ventaTableAdapter;
        private System.Windows.Forms.DataGridView tabla_uso;
        private System.Windows.Forms.BindingSource inventarioBindingSource;
        private SDCDataSetTableAdapters.InventarioTableAdapter inventarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInventarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn caducidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perecederoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label Subtotal_lab;
        private System.Windows.Forms.TextBox Subtotal_box;
        private System.Windows.Forms.TextBox Cambio_tex;
        private System.Windows.Forms.TextBox efectiv_tex;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox ID_emp_tex;
        private System.Windows.Forms.TextBox Id_venta_tex;
        private System.Windows.Forms.Label Cambio_label;
        private System.Windows.Forms.Label Fecha_label;
        private System.Windows.Forms.Label ID_venta_label;
        private System.Windows.Forms.Label ID_empl_label;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.Button Insertar;
        private System.Windows.Forms.Label Precio_lab;
        private System.Windows.Forms.Label Cantidad_labe;
        private System.Windows.Forms.Label Nombre_lab;
        private System.Windows.Forms.Label ID_labe;
        private System.Windows.Forms.TextBox Precio;
        private System.Windows.Forms.TextBox Cantidad;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox total_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource ventaBindingSource;
        private SDCDataSetTableAdapters.VentaTableAdapter ventaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleadoRFCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDetalleVentaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inventario_Id;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBox1;
	}
}