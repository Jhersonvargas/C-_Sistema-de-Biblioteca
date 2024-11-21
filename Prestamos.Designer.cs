namespace Biblioteca
{
    partial class Prestamos
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
            this.botom = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dataGridCL = new System.Windows.Forms.DataGridView();
            this.Lblidlibro = new System.Windows.Forms.Label();
            this.LblAutor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LblLibro = new System.Windows.Forms.Label();
            this.LblExistencia = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.BTAgregar = new System.Windows.Forms.Button();
            this.BTQuitar = new System.Windows.Forms.Button();
            this.DTfechaD = new System.Windows.Forms.DateTimePicker();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.DGidlibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGFecha_Devolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lbtotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevoPrestamo = new System.Windows.Forms.Button();
            this.bttnBuscarPrestamo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // botom
            // 
            this.botom.BackColor = System.Drawing.Color.White;
            this.botom.Image = global::Biblioteca.Properties.Resources.xmag_search_find_export_locate_5984__1_;
            this.botom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botom.Location = new System.Drawing.Point(14, 12);
            this.botom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.botom.Name = "botom";
            this.botom.Size = new System.Drawing.Size(100, 23);
            this.botom.TabIndex = 0;
            this.botom.Text = "Buscar";
            this.botom.UseVisualStyleBackColor = false;
            this.botom.Click += new System.EventHandler(this.botom_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(121, 12);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(936, 20);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dataGridCL
            // 
            this.dataGridCL.AllowUserToAddRows = false;
            this.dataGridCL.AllowUserToDeleteRows = false;
            this.dataGridCL.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.dataGridCL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCL.Location = new System.Drawing.Point(14, 41);
            this.dataGridCL.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridCL.Name = "dataGridCL";
            this.dataGridCL.ReadOnly = true;
            this.dataGridCL.RowHeadersWidth = 62;
            this.dataGridCL.Size = new System.Drawing.Size(1042, 222);
            this.dataGridCL.TabIndex = 2;
            this.dataGridCL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCL_CellContentClick);
            this.dataGridCL.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCL_CellContentDoubleClick);
            this.dataGridCL.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCL_CellDoubleClick);
            // 
            // Lblidlibro
            // 
            this.Lblidlibro.BackColor = System.Drawing.Color.Azure;
            this.Lblidlibro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lblidlibro.Location = new System.Drawing.Point(56, 18);
            this.Lblidlibro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lblidlibro.Name = "Lblidlibro";
            this.Lblidlibro.Size = new System.Drawing.Size(65, 24);
            this.Lblidlibro.TabIndex = 3;
            // 
            // LblAutor
            // 
            this.LblAutor.BackColor = System.Drawing.Color.Azure;
            this.LblAutor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblAutor.Location = new System.Drawing.Point(54, 48);
            this.LblAutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAutor.Name = "LblAutor";
            this.LblAutor.Size = new System.Drawing.Size(65, 24);
            this.LblAutor.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "idlibro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Autor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Libro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(130, 59);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Esistencia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(514, 24);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Fecha";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(514, 54);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Fecha_Devolucion";
            // 
            // LblLibro
            // 
            this.LblLibro.BackColor = System.Drawing.Color.Azure;
            this.LblLibro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblLibro.Location = new System.Drawing.Point(191, 23);
            this.LblLibro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblLibro.Name = "LblLibro";
            this.LblLibro.Size = new System.Drawing.Size(316, 23);
            this.LblLibro.TabIndex = 12;
            // 
            // LblExistencia
            // 
            this.LblExistencia.BackColor = System.Drawing.Color.Azure;
            this.LblExistencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblExistencia.Location = new System.Drawing.Point(191, 58);
            this.LblExistencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblExistencia.Name = "LblExistencia";
            this.LblExistencia.Size = new System.Drawing.Size(316, 23);
            this.LblExistencia.TabIndex = 13;
            // 
            // lblFecha
            // 
            this.lblFecha.BackColor = System.Drawing.Color.Azure;
            this.lblFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFecha.Location = new System.Drawing.Point(635, 20);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(116, 23);
            this.lblFecha.TabIndex = 14;
            this.lblFecha.Click += new System.EventHandler(this.label12_Click);
            // 
            // BTAgregar
            // 
            this.BTAgregar.BackColor = System.Drawing.Color.White;
            this.BTAgregar.Image = global::Biblioteca.Properties.Resources.new_file_21047;
            this.BTAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTAgregar.Location = new System.Drawing.Point(788, 23);
            this.BTAgregar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BTAgregar.Name = "BTAgregar";
            this.BTAgregar.Size = new System.Drawing.Size(118, 43);
            this.BTAgregar.TabIndex = 15;
            this.BTAgregar.Text = "Agregar";
            this.BTAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTAgregar.UseVisualStyleBackColor = false;
            this.BTAgregar.Click += new System.EventHandler(this.BTAgregar_Click);
            // 
            // BTQuitar
            // 
            this.BTQuitar.BackColor = System.Drawing.Color.White;
            this.BTQuitar.Image = global::Biblioteca.Properties.Resources.login_square_arrow_button_outline_icon_icons_com_73220;
            this.BTQuitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTQuitar.Location = new System.Drawing.Point(925, 22);
            this.BTQuitar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BTQuitar.Name = "BTQuitar";
            this.BTQuitar.Size = new System.Drawing.Size(110, 44);
            this.BTQuitar.TabIndex = 16;
            this.BTQuitar.Text = "Quitar";
            this.BTQuitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTQuitar.UseVisualStyleBackColor = false;
            this.BTQuitar.Click += new System.EventHandler(this.BTQuitar_Click);
            // 
            // DTfechaD
            // 
            this.DTfechaD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTfechaD.Location = new System.Drawing.Point(635, 52);
            this.DTfechaD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DTfechaD.Name = "DTfechaD";
            this.DTfechaD.Size = new System.Drawing.Size(118, 20);
            this.DTfechaD.TabIndex = 18;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGidlibro,
            this.DGLibro,
            this.DGAutor,
            this.DGFecha_Devolucion});
            this.dataGridView2.Location = new System.Drawing.Point(14, 369);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.Size = new System.Drawing.Size(940, 254);
            this.dataGridView2.TabIndex = 18;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // DGidlibro
            // 
            this.DGidlibro.HeaderText = "idlibro";
            this.DGidlibro.MinimumWidth = 8;
            this.DGidlibro.Name = "DGidlibro";
            this.DGidlibro.ReadOnly = true;
            // 
            // DGLibro
            // 
            this.DGLibro.HeaderText = "Libro";
            this.DGLibro.MinimumWidth = 8;
            this.DGLibro.Name = "DGLibro";
            this.DGLibro.ReadOnly = true;
            this.DGLibro.Width = 200;
            // 
            // DGAutor
            // 
            this.DGAutor.HeaderText = "Autor";
            this.DGAutor.MinimumWidth = 8;
            this.DGAutor.Name = "DGAutor";
            this.DGAutor.ReadOnly = true;
            this.DGAutor.Width = 200;
            // 
            // DGFecha_Devolucion
            // 
            this.DGFecha_Devolucion.HeaderText = "Fecha_Devolucion";
            this.DGFecha_Devolucion.MinimumWidth = 8;
            this.DGFecha_Devolucion.Name = "DGFecha_Devolucion";
            this.DGFecha_Devolucion.ReadOnly = true;
            this.DGFecha_Devolucion.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.LblExistencia);
            this.groupBox1.Controls.Add(this.DTfechaD);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Lblidlibro);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.BTQuitar);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.LblAutor);
            this.groupBox1.Controls.Add(this.LblLibro);
            this.groupBox1.Controls.Add(this.BTAgregar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Location = new System.Drawing.Point(14, 269);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(1042, 94);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Lbtotal
            // 
            this.Lbtotal.BackColor = System.Drawing.Color.Azure;
            this.Lbtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbtotal.Location = new System.Drawing.Point(980, 577);
            this.Lbtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbtotal.Name = "Lbtotal";
            this.Lbtotal.Size = new System.Drawing.Size(94, 36);
            this.Lbtotal.TabIndex = 20;
            this.Lbtotal.Click += new System.EventHandler(this.Lbtotal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(976, 551);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "total de prestados";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnNuevoPrestamo
            // 
            this.btnNuevoPrestamo.BackColor = System.Drawing.Color.White;
            this.btnNuevoPrestamo.Image = global::Biblioteca.Properties.Resources.arrow_refresh_15732;
            this.btnNuevoPrestamo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoPrestamo.Location = new System.Drawing.Point(980, 410);
            this.btnNuevoPrestamo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNuevoPrestamo.Name = "btnNuevoPrestamo";
            this.btnNuevoPrestamo.Size = new System.Drawing.Size(94, 41);
            this.btnNuevoPrestamo.TabIndex = 22;
            this.btnNuevoPrestamo.Text = "Nuevo  Prestamo";
            this.btnNuevoPrestamo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoPrestamo.UseVisualStyleBackColor = false;
            this.btnNuevoPrestamo.Click += new System.EventHandler(this.btnNuevoPrestamo_Click);
            // 
            // bttnBuscarPrestamo
            // 
            this.bttnBuscarPrestamo.BackColor = System.Drawing.Color.White;
            this.bttnBuscarPrestamo.Image = global::Biblioteca.Properties.Resources.xmag_search_find_export_locate_5984;
            this.bttnBuscarPrestamo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnBuscarPrestamo.Location = new System.Drawing.Point(980, 470);
            this.bttnBuscarPrestamo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttnBuscarPrestamo.Name = "bttnBuscarPrestamo";
            this.bttnBuscarPrestamo.Size = new System.Drawing.Size(94, 42);
            this.bttnBuscarPrestamo.TabIndex = 23;
            this.bttnBuscarPrestamo.Text = "Buscar Prestamo";
            this.bttnBuscarPrestamo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnBuscarPrestamo.UseVisualStyleBackColor = false;
            this.bttnBuscarPrestamo.Click += new System.EventHandler(this.bttnBuscarPrestamo_Click);
            // 
            // Prestamos
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1096, 639);
            this.Controls.Add(this.bttnBuscarPrestamo);
            this.Controls.Add(this.btnNuevoPrestamo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbtotal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridCL);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.botom);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Prestamos";
            this.Text = "Prestamos";
            this.Load += new System.EventHandler(this.Prestamos_Load);
            this.TextChanged += new System.EventHandler(this.Prestamos_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botom;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dataGridCL;
        private System.Windows.Forms.Label Lblidlibro;
        private System.Windows.Forms.Label LblAutor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblLibro;
        private System.Windows.Forms.Label LblExistencia;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button BTAgregar;
        private System.Windows.Forms.Button BTQuitar;
        private System.Windows.Forms.DateTimePicker DTfechaD;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Lbtotal;
        private System.Windows.Forms.Button btnNuevoPrestamo;
        private System.Windows.Forms.Button bttnBuscarPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGidlibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGFecha_Devolucion;
        private System.Windows.Forms.Label label1;
    }
}