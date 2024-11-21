namespace Biblioteca
{
    partial class Reporte_formulario
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
            this.crystalReportFormulario = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportFormulario
            // 
            this.crystalReportFormulario.ActiveViewIndex = -1;
            this.crystalReportFormulario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportFormulario.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportFormulario.Location = new System.Drawing.Point(0, 0);
            this.crystalReportFormulario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.crystalReportFormulario.Name = "crystalReportFormulario";
            this.crystalReportFormulario.Size = new System.Drawing.Size(1200, 692);
            this.crystalReportFormulario.TabIndex = 1;
            this.crystalReportFormulario.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportFormulario.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // Reporte_formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.crystalReportFormulario);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Reporte_formulario";
            this.Text = "Reporte_formulario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Reporte_formulario_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportFormulario;
    }
}