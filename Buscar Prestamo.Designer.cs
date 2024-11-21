namespace Biblioteca
{
    partial class Buscar_Prestamo
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
            this.CBtipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DPdesde = new System.Windows.Forms.DateTimePicker();
            this.BTMbuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DPhasta = new System.Windows.Forms.DateTimePicker();
            this.DGprestamo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGprestamo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo";
            // 
            // CBtipo
            // 
            this.CBtipo.FormattingEnabled = true;
            this.CBtipo.Location = new System.Drawing.Point(95, 46);
            this.CBtipo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CBtipo.Name = "CBtipo";
            this.CBtipo.Size = new System.Drawing.Size(256, 24);
            this.CBtipo.TabIndex = 1;
            this.CBtipo.Text = "seleccionar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Desde";
            // 
            // DPdesde
            // 
            this.DPdesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DPdesde.Location = new System.Drawing.Point(548, 49);
            this.DPdesde.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.DPdesde.Name = "DPdesde";
            this.DPdesde.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DPdesde.Size = new System.Drawing.Size(205, 22);
            this.DPdesde.TabIndex = 3;
            this.DPdesde.Value = new System.DateTime(2023, 9, 20, 13, 54, 57, 0);
            // 
            // BTMbuscar
            // 
            this.BTMbuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTMbuscar.Image = global::Biblioteca.Properties.Resources.xmag_search_find_export_locate_59841;
            this.BTMbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTMbuscar.Location = new System.Drawing.Point(1219, 43);
            this.BTMbuscar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BTMbuscar.Name = "BTMbuscar";
            this.BTMbuscar.Size = new System.Drawing.Size(195, 49);
            this.BTMbuscar.TabIndex = 4;
            this.BTMbuscar.Text = "Buscar";
            this.BTMbuscar.UseVisualStyleBackColor = false;
            this.BTMbuscar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(859, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hasta";
            // 
            // DPhasta
            // 
            this.DPhasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DPhasta.Location = new System.Drawing.Point(921, 53);
            this.DPhasta.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.DPhasta.Name = "DPhasta";
            this.DPhasta.Size = new System.Drawing.Size(235, 22);
            this.DPhasta.TabIndex = 6;
            // 
            // DGprestamo
            // 
            this.DGprestamo.AllowUserToAddRows = false;
            this.DGprestamo.AllowUserToDeleteRows = false;
            this.DGprestamo.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGprestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGprestamo.Location = new System.Drawing.Point(48, 102);
            this.DGprestamo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGprestamo.Name = "DGprestamo";
            this.DGprestamo.ReadOnly = true;
            this.DGprestamo.RowHeadersWidth = 62;
            this.DGprestamo.RowTemplate.Height = 28;
            this.DGprestamo.Size = new System.Drawing.Size(1367, 511);
            this.DGprestamo.TabIndex = 7;
            this.DGprestamo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGprestamo_CellContentClick);
            // 
            // Buscar_Prestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1457, 635);
            this.Controls.Add(this.DGprestamo);
            this.Controls.Add(this.DPhasta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTMbuscar);
            this.Controls.Add(this.DPdesde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBtipo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Buscar_Prestamo";
            this.Text = "Buscar_Prestamo";
            this.Load += new System.EventHandler(this.Buscar_Prestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGprestamo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBtipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DPdesde;
        private System.Windows.Forms.Button BTMbuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DPhasta;
        private System.Windows.Forms.DataGridView DGprestamo;
    }
}