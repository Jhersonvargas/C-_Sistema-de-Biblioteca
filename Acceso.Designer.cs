namespace Biblioteca
{
    partial class Acceso
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
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.btningresar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(294, 79);
            this.txtusuario.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(148, 22);
            this.txtusuario.TabIndex = 2;
            // 
            // txtclave
            // 
            this.txtclave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclave.Location = new System.Drawing.Point(294, 124);
            this.txtclave.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtclave.Name = "txtclave";
            this.txtclave.PasswordChar = '*';
            this.txtclave.Size = new System.Drawing.Size(148, 22);
            this.txtclave.TabIndex = 3;
            // 
            // btningresar
            // 
            this.btningresar.BackColor = System.Drawing.Color.White;
            this.btningresar.Image = global::Biblioteca.Properties.Resources.login_square_arrow_button_outline_icon_icons1;
            this.btningresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btningresar.Location = new System.Drawing.Point(255, 188);
            this.btningresar.Margin = new System.Windows.Forms.Padding(4);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(115, 39);
            this.btningresar.TabIndex = 4;
            this.btningresar.Text = "Ingresar";
            this.btningresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btningresar.UseVisualStyleBackColor = false;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // label2
            // 
            this.label2.Image = global::Biblioteca.Properties.Resources._40_104848;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(158, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clave:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Image = global::Biblioteca.Properties.Resources.user_icon_icons_com_57997;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(158, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Acceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(645, 389);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Acceso";
            this.Text = "Acceso";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.Button btningresar;
    }
}