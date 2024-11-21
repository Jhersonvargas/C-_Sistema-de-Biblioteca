namespace Biblioteca
{
    partial class Consultar_Libros_Por_Año
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
            this.DtgriLibroPorAño = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdesde = new System.Windows.Forms.TextBox();
            this.txthasta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtgriLibroPorAño)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgriLibroPorAño
            // 
            this.DtgriLibroPorAño.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.DtgriLibroPorAño.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgriLibroPorAño.Location = new System.Drawing.Point(17, 73);
            this.DtgriLibroPorAño.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DtgriLibroPorAño.Name = "DtgriLibroPorAño";
            this.DtgriLibroPorAño.Size = new System.Drawing.Size(1043, 484);
            this.DtgriLibroPorAño.TabIndex = 0;
            this.DtgriLibroPorAño.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Desde:";
            // 
            // txtdesde
            // 
            this.txtdesde.Location = new System.Drawing.Point(81, 25);
            this.txtdesde.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtdesde.Name = "txtdesde";
            this.txtdesde.Size = new System.Drawing.Size(369, 22);
            this.txtdesde.TabIndex = 2;
            // 
            // txthasta
            // 
            this.txthasta.Location = new System.Drawing.Point(569, 25);
            this.txthasta.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txthasta.Name = "txthasta";
            this.txthasta.Size = new System.Drawing.Size(318, 22);
            this.txthasta.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(507, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasta:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::Biblioteca.Properties.Resources.xmag_search_find_export_locate_5984__1_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(910, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Consultar_Libros_Por_Año
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1113, 592);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txthasta);
            this.Controls.Add(this.txtdesde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DtgriLibroPorAño);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Consultar_Libros_Por_Año";
            this.Text = "Consultar_Libros_Por_Año";
            this.Load += new System.EventHandler(this.Consultar_Libros_Por_Año_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgriLibroPorAño)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgriLibroPorAño;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdesde;
        private System.Windows.Forms.TextBox txthasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}