namespace Biblioteca
{
    partial class RegistrarNuuevoActor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtidnombre = new System.Windows.Forms.TextBox();
            this.txtnomAutor = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del autor:";
            // 
            // txtidnombre
            // 
            this.txtidnombre.Location = new System.Drawing.Point(283, 65);
            this.txtidnombre.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtidnombre.Name = "txtidnombre";
            this.txtidnombre.Size = new System.Drawing.Size(148, 22);
            this.txtidnombre.TabIndex = 4;
            // 
            // txtnomAutor
            // 
            this.txtnomAutor.Location = new System.Drawing.Point(283, 110);
            this.txtnomAutor.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtnomAutor.Name = "txtnomAutor";
            this.txtnomAutor.Size = new System.Drawing.Size(148, 22);
            this.txtnomAutor.TabIndex = 5;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.White;
            this.btnActualizar.Image = global::Biblioteca.Properties.Resources.arrow_refresh_15732;
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(412, 203);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(109, 41);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.Image = global::Biblioteca.Properties.Resources.xmag_search_find_export_locate_5984__1_;
            this.btnBuscar.Location = new System.Drawing.Point(440, 60);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(80, 33);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.White;
            this.btnagregar.Image = global::Biblioteca.Properties.Resources.business_application_addmale_useradd_insert_add_user_client_2312;
            this.btnagregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnagregar.Location = new System.Drawing.Point(266, 203);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(102, 41);
            this.btnagregar.TabIndex = 3;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackColor = System.Drawing.Color.White;
            this.btnnuevo.Image = global::Biblioteca.Properties.Resources.new_file_21047;
            this.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnuevo.Location = new System.Drawing.Point(110, 203);
            this.btnnuevo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(99, 41);
            this.btnnuevo.TabIndex = 2;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnuevo.UseVisualStyleBackColor = false;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // RegistrarNuuevoActor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(636, 337);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtnomAutor);
            this.Controls.Add(this.txtidnombre);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "RegistrarNuuevoActor";
            this.Text = "RegistrarNuevoActor";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.TextBox txtidnombre;
        private System.Windows.Forms.TextBox txtnomAutor;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnActualizar;
    }
}