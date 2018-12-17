namespace WSFAlimentos
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDV = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFabreicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTipoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.findAllProductoResponseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvBoleta = new System.Windows.Forms.DataGridView();
            this.ID_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnVenta = new System.Windows.Forms.Button();
            this.dtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.findAllProductoResponseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoleta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rut Cliente";
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(95, 24);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(135, 20);
            this.txtRut.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "-";
            // 
            // txtDV
            // 
            this.txtDV.Location = new System.Drawing.Point(253, 24);
            this.txtDV.Name = "txtDV";
            this.txtDV.Size = new System.Drawing.Size(38, 20);
            this.txtDV.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Descripcion,
            this.Precio,
            this.FechaFabreicacion,
            this.FechaVencimiento,
            this.TipoProducto,
            this.SubTipoProducto});
            this.dataGridView1.Location = new System.Drawing.Point(345, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(743, 126);
            this.dataGridView1.TabIndex = 4;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // FechaFabreicacion
            // 
            this.FechaFabreicacion.HeaderText = "FechaFabreicacion";
            this.FechaFabreicacion.Name = "FechaFabreicacion";
            this.FechaFabreicacion.ReadOnly = true;
            // 
            // FechaVencimiento
            // 
            this.FechaVencimiento.HeaderText = "FechaVencimiento";
            this.FechaVencimiento.Name = "FechaVencimiento";
            this.FechaVencimiento.ReadOnly = true;
            // 
            // TipoProducto
            // 
            this.TipoProducto.HeaderText = "TipoProducto";
            this.TipoProducto.Name = "TipoProducto";
            this.TipoProducto.ReadOnly = true;
            // 
            // SubTipoProducto
            // 
            this.SubTipoProducto.HeaderText = "SubTipoProducto";
            this.SubTipoProducto.Name = "SubTipoProducto";
            this.SubTipoProducto.ReadOnly = true;
            // 
            // findAllProductoResponseBindingSource
            // 
            this.findAllProductoResponseBindingSource.DataSource = typeof(WSFAlimentos.SWProducto.findAllProductoResponse);
            // 
            // dgvBoleta
            // 
            this.dgvBoleta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBoleta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Producto,
            this.PrecioPB,
            this.NombrePB});
            this.dgvBoleta.Location = new System.Drawing.Point(574, 239);
            this.dgvBoleta.Name = "dgvBoleta";
            this.dgvBoleta.Size = new System.Drawing.Size(344, 147);
            this.dgvBoleta.TabIndex = 5;
            // 
            // ID_Producto
            // 
            this.ID_Producto.HeaderText = "ID_Producto";
            this.ID_Producto.Name = "ID_Producto";
            this.ID_Producto.ReadOnly = true;
            // 
            // PrecioPB
            // 
            this.PrecioPB.HeaderText = "Precio";
            this.PrecioPB.Name = "PrecioPB";
            this.PrecioPB.ReadOnly = true;
            // 
            // NombrePB
            // 
            this.NombrePB.HeaderText = "Nombre";
            this.NombrePB.Name = "NombrePB";
            this.NombrePB.ReadOnly = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(381, 239);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnVenta
            // 
            this.btnVenta.Location = new System.Drawing.Point(32, 190);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(75, 23);
            this.btnVenta.TabIndex = 7;
            this.btnVenta.Text = "Crear Venta";
            this.btnVenta.UseVisualStyleBackColor = true;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.Location = new System.Drawing.Point(95, 68);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaEntrega.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fecha Entrega";
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 430);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFechaEntrega);
            this.Controls.Add(this.btnVenta);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvBoleta);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtDV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRut);
            this.Controls.Add(this.label1);
            this.Name = "Venta";
            this.Text = "Venta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.findAllProductoResponseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoleta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDV;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource findAllProductoResponseBindingSource;
        private System.Windows.Forms.DataGridView dgvBoleta;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFabreicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTipoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioPB;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePB;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrega;
        private System.Windows.Forms.Label label3;
    }
}