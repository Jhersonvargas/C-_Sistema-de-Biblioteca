namespace Biblioteca
{
    partial class RegistrarLibros
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbAutor = new System.Windows.Forms.ComboBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txteditorial = new System.Windows.Forms.TextBox();
            this.txtpais = new System.Windows.Forms.TextBox();
            this.txtpaginas = new System.Windows.Forms.TextBox();
            this.txtaño = new System.Windows.Forms.TextBox();
            this.txtexistencia = new System.Windows.Forms.TextBox();
            this.añadir_combox = new System.Windows.Forms.Button();
            this.cmdeditar = new System.Windows.Forms.Button();
            this.cmdgrabar = new System.Windows.Forms.Button();
            this.cmdnuevo = new System.Windows.Forms.Button();
            this.cmdbuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id_libro:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Autor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Titulo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 203);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Editorial:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 250);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pais:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 304);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nro_Pagina:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(315, 304);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Año:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(507, 304);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Existencia:";
            // 
            // cbAutor
            // 
            this.cbAutor.FormattingEnabled = true;
            this.cbAutor.Location = new System.Drawing.Point(141, 95);
            this.cbAutor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbAutor.Name = "cbAutor";
            this.cbAutor.Size = new System.Drawing.Size(554, 21);
            this.cbAutor.TabIndex = 12;
            this.cbAutor.SelectedIndexChanged += new System.EventHandler(this.cbAutor_SelectedIndexChanged);
            this.cbAutor.Click += new System.EventHandler(this.cbAutor_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(141, 45);
            this.txtid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(417, 20);
            this.txtid.TabIndex = 13;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(141, 153);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(554, 20);
            this.txtTitulo.TabIndex = 14;
            // 
            // txteditorial
            // 
            this.txteditorial.Location = new System.Drawing.Point(141, 200);
            this.txteditorial.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txteditorial.Name = "txteditorial";
            this.txteditorial.Size = new System.Drawing.Size(554, 20);
            this.txteditorial.TabIndex = 15;
            // 
            // txtpais
            // 
            this.txtpais.Location = new System.Drawing.Point(141, 243);
            this.txtpais.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtpais.Name = "txtpais";
            this.txtpais.Size = new System.Drawing.Size(554, 20);
            this.txtpais.TabIndex = 16;
            // 
            // txtpaginas
            // 
            this.txtpaginas.Location = new System.Drawing.Point(141, 301);
            this.txtpaginas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtpaginas.Name = "txtpaginas";
            this.txtpaginas.Size = new System.Drawing.Size(98, 20);
            this.txtpaginas.TabIndex = 17;
            // 
            // txtaño
            // 
            this.txtaño.Location = new System.Drawing.Point(352, 301);
            this.txtaño.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtaño.Name = "txtaño";
            this.txtaño.Size = new System.Drawing.Size(108, 20);
            this.txtaño.TabIndex = 18;
            // 
            // txtexistencia
            // 
            this.txtexistencia.Location = new System.Drawing.Point(579, 301);
            this.txtexistencia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtexistencia.Name = "txtexistencia";
            this.txtexistencia.Size = new System.Drawing.Size(116, 20);
            this.txtexistencia.TabIndex = 19;
            // 
            // añadir_combox
            // 
            this.añadir_combox.BackColor = System.Drawing.Color.White;
            this.añadir_combox.Image = global::Biblioteca.Properties.Resources.Open_folder_add_36742;
            this.añadir_combox.Location = new System.Drawing.Point(702, 83);
            this.añadir_combox.Name = "añadir_combox";
            this.añadir_combox.Size = new System.Drawing.Size(52, 42);
            this.añadir_combox.TabIndex = 20;
            this.añadir_combox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.añadir_combox.UseVisualStyleBackColor = false;
            this.añadir_combox.Click += new System.EventHandler(this.añadir_combox_Click);
            // 
            // cmdeditar
            // 
            this.cmdeditar.BackColor = System.Drawing.Color.White;
            this.cmdeditar.Image = global::Biblioteca.Properties.Resources.generatetables_ok_home_out_edit_generar_1491;
            this.cmdeditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdeditar.Location = new System.Drawing.Point(468, 363);
            this.cmdeditar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdeditar.Name = "cmdeditar";
            this.cmdeditar.Size = new System.Drawing.Size(92, 39);
            this.cmdeditar.TabIndex = 11;
            this.cmdeditar.Text = "Editar";
            this.cmdeditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdeditar.UseVisualStyleBackColor = false;
            this.cmdeditar.Click += new System.EventHandler(this.cmdeditar_Click);
            // 
            // cmdgrabar
            // 
            this.cmdgrabar.BackColor = System.Drawing.Color.White;
            this.cmdgrabar.Image = global::Biblioteca.Properties.Resources.databaseuntil_basededato_12919;
            this.cmdgrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdgrabar.Location = new System.Drawing.Point(322, 363);
            this.cmdgrabar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdgrabar.Name = "cmdgrabar";
            this.cmdgrabar.Size = new System.Drawing.Size(99, 39);
            this.cmdgrabar.TabIndex = 10;
            this.cmdgrabar.Text = "Grabar";
            this.cmdgrabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdgrabar.UseVisualStyleBackColor = false;
            this.cmdgrabar.Click += new System.EventHandler(this.cmdgrabar_Click);
            // 
            // cmdnuevo
            // 
            this.cmdnuevo.BackColor = System.Drawing.Color.White;
            this.cmdnuevo.Image = global::Biblioteca.Properties.Resources._1486485588_add_create_new_math_sign_cross_plus_81186;
            this.cmdnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdnuevo.Location = new System.Drawing.Point(175, 363);
            this.cmdnuevo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdnuevo.Name = "cmdnuevo";
            this.cmdnuevo.Size = new System.Drawing.Size(107, 39);
            this.cmdnuevo.TabIndex = 9;
            this.cmdnuevo.Text = "Nuevo";
            this.cmdnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdnuevo.UseVisualStyleBackColor = false;
            this.cmdnuevo.Click += new System.EventHandler(this.cmdnuevo_Click);
            // 
            // cmdbuscar
            // 
            this.cmdbuscar.BackColor = System.Drawing.Color.White;
            this.cmdbuscar.Image = global::Biblioteca.Properties.Resources.xmag_search_find_export_locate_5984;
            this.cmdbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdbuscar.Location = new System.Drawing.Point(566, 38);
            this.cmdbuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdbuscar.Name = "cmdbuscar";
            this.cmdbuscar.Size = new System.Drawing.Size(130, 33);
            this.cmdbuscar.TabIndex = 8;
            this.cmdbuscar.Text = "Buscar";
            this.cmdbuscar.UseVisualStyleBackColor = false;
            this.cmdbuscar.Click += new System.EventHandler(this.cmdbuscar_Click);
            // 
            // RegistrarLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 495);
            this.Controls.Add(this.añadir_combox);
            this.Controls.Add(this.txtexistencia);
            this.Controls.Add(this.txtaño);
            this.Controls.Add(this.txtpaginas);
            this.Controls.Add(this.txtpais);
            this.Controls.Add(this.txteditorial);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.cbAutor);
            this.Controls.Add(this.cmdeditar);
            this.Controls.Add(this.cmdgrabar);
            this.Controls.Add(this.cmdnuevo);
            this.Controls.Add(this.cmdbuscar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "RegistrarLibros";
            this.Text = "RegistrarLibros";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cmdbuscar;
        private System.Windows.Forms.Button cmdnuevo;
        private System.Windows.Forms.Button cmdgrabar;
        private System.Windows.Forms.Button cmdeditar;
        private System.Windows.Forms.ComboBox cbAutor;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txteditorial;
        private System.Windows.Forms.TextBox txtpais;
        private System.Windows.Forms.TextBox txtpaginas;
        private System.Windows.Forms.TextBox txtaño;
        private System.Windows.Forms.TextBox txtexistencia;
        private System.Windows.Forms.Button añadir_combox;
    }
}

