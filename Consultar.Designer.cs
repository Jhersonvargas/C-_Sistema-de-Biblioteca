namespace Biblioteca
{
    partial class consultar
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
            this.cbelegir = new System.Windows.Forms.ComboBox();
            this.txt = new System.Windows.Forms.TextBox();
            this.DtgriLibro = new System.Windows.Forms.DataGridView();
            this.btnbuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtgriLibro)).BeginInit();
            this.SuspendLayout();
            // 
            // cbelegir
            // 
            this.cbelegir.FormattingEnabled = true;
            this.cbelegir.Location = new System.Drawing.Point(4, 15);
            this.cbelegir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbelegir.Name = "cbelegir";
            this.cbelegir.Size = new System.Drawing.Size(180, 24);
            this.cbelegir.TabIndex = 2;
            this.cbelegir.Text = "seleccionar";
            this.cbelegir.SelectedIndexChanged += new System.EventHandler(this.cbelegir_SelectedIndexChanged);
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(195, 16);
            this.txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(750, 22);
            this.txt.TabIndex = 3;
            this.txt.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // DtgriLibro
            // 
            this.DtgriLibro.AllowUserToAddRows = false;
            this.DtgriLibro.AllowUserToDeleteRows = false;
            this.DtgriLibro.BackgroundColor = System.Drawing.Color.Beige;
            this.DtgriLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgriLibro.Location = new System.Drawing.Point(4, 57);
            this.DtgriLibro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DtgriLibro.Name = "DtgriLibro";
            this.DtgriLibro.ReadOnly = true;
            this.DtgriLibro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgriLibro.Size = new System.Drawing.Size(1080, 497);
            this.DtgriLibro.TabIndex = 6;
            this.DtgriLibro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgrLibro_CellContentClick);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnbuscar.Image = global::Biblioteca.Properties.Resources.xmag_search_find_export_locate_5984__1_;
            this.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbuscar.Location = new System.Drawing.Point(972, 5);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(112, 43);
            this.btnbuscar.TabIndex = 4;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1125, 588);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.cbelegir);
            this.Controls.Add(this.DtgriLibro);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "consultar";
            this.Text = "Consultar";
            this.Load += new System.EventHandler(this.Consultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgriLibro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbelegir;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.DataGridView DtgriLibro;
    }
}