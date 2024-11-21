namespace Biblioteca
{
    partial class ReporteLibrosAñoResultado
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
            this.crystalReportLibro = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportLibro
            // 
            this.crystalReportLibro.ActiveViewIndex = -1;
            this.crystalReportLibro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportLibro.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportLibro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportLibro.Location = new System.Drawing.Point(0, 0);
            this.crystalReportLibro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.crystalReportLibro.Name = "crystalReportLibro";
            this.crystalReportLibro.Size = new System.Drawing.Size(1200, 692);
            this.crystalReportLibro.TabIndex = 0;
            this.crystalReportLibro.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportLibro.Load += new System.EventHandler(this.crystalReportLibro_Load);
            // 
            // ReporteLibrosAñoResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.crystalReportLibro);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReporteLibrosAñoResultado";
            this.Text = "ReporteLibroFecha";
            this.Load += new System.EventHandler(this.ReporteLibroFecha_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportLibro;
    }
}