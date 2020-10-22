namespace Practica03_DovalFragaJA_ListaTelefonica
{
    partial class Formulario
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
            this.contactosListBox = new System.Windows.Forms.ListBox();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.nombreLbl = new System.Windows.Forms.Label();
            this.telefonoLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.fotoLbl = new System.Windows.Forms.Label();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.modificarButton = new System.Windows.Forms.Button();
            this.eliminarButton = new System.Windows.Forms.Button();
            this.advertenciaLbl = new System.Windows.Forms.Label();
            this.anadirButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // contactosListBox
            // 
            this.contactosListBox.FormattingEnabled = true;
            this.contactosListBox.ItemHeight = 21;
            this.contactosListBox.Location = new System.Drawing.Point(17, 282);
            this.contactosListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.contactosListBox.Name = "contactosListBox";
            this.contactosListBox.Size = new System.Drawing.Size(301, 235);
            this.contactosListBox.TabIndex = 3;
            this.contactosListBox.SelectedIndexChanged += new System.EventHandler(this.contactosListBox_SelectedIndexChanged);
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.Image = global::Practica03_DovalFragaJA_ListaTelefonica.Properties.Resources.FotoLimpiar;
            this.fotoPictureBox.Location = new System.Drawing.Point(375, 14);
            this.fotoPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(150, 152);
            this.fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoPictureBox.TabIndex = 1;
            this.fotoPictureBox.TabStop = false;
            this.fotoPictureBox.Click += new System.EventHandler(this.fotoPictureBox_Click);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(106, 45);
            this.nombreTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(212, 29);
            this.nombreTextBox.TabIndex = 0;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.Location = new System.Drawing.Point(106, 75);
            this.telefonoTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(212, 29);
            this.telefonoTextBox.TabIndex = 1;
            this.telefonoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telefonoTextBox_KeyPress);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(106, 106);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(212, 29);
            this.emailTextBox.TabIndex = 2;
            // 
            // nombreLbl
            // 
            this.nombreLbl.AutoSize = true;
            this.nombreLbl.Location = new System.Drawing.Point(13, 48);
            this.nombreLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nombreLbl.Name = "nombreLbl";
            this.nombreLbl.Size = new System.Drawing.Size(71, 21);
            this.nombreLbl.TabIndex = 0;
            this.nombreLbl.Text = "Nombre:";
            // 
            // telefonoLbl
            // 
            this.telefonoLbl.AutoSize = true;
            this.telefonoLbl.Location = new System.Drawing.Point(13, 78);
            this.telefonoLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.telefonoLbl.Name = "telefonoLbl";
            this.telefonoLbl.Size = new System.Drawing.Size(71, 21);
            this.telefonoLbl.TabIndex = 0;
            this.telefonoLbl.Text = "Teléfono:";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(13, 109);
            this.emailLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(51, 21);
            this.emailLbl.TabIndex = 0;
            this.emailLbl.Text = "Email:";
            // 
            // fotoLbl
            // 
            this.fotoLbl.AutoSize = true;
            this.fotoLbl.Location = new System.Drawing.Point(430, 171);
            this.fotoLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fotoLbl.Name = "fotoLbl";
            this.fotoLbl.Size = new System.Drawing.Size(41, 21);
            this.fotoLbl.TabIndex = 0;
            this.fotoLbl.Text = "Foto";
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(351, 282);
            this.NuevoButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(112, 37);
            this.NuevoButton.TabIndex = 4;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // modificarButton
            // 
            this.modificarButton.Location = new System.Drawing.Point(351, 329);
            this.modificarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.modificarButton.Name = "modificarButton";
            this.modificarButton.Size = new System.Drawing.Size(112, 37);
            this.modificarButton.TabIndex = 5;
            this.modificarButton.Text = "Modificar";
            this.modificarButton.UseVisualStyleBackColor = true;
            this.modificarButton.Click += new System.EventHandler(this.modificarButton_Click);
            // 
            // eliminarButton
            // 
            this.eliminarButton.Location = new System.Drawing.Point(351, 376);
            this.eliminarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(112, 37);
            this.eliminarButton.TabIndex = 6;
            this.eliminarButton.Text = "Eliminar";
            this.eliminarButton.UseVisualStyleBackColor = true;
            this.eliminarButton.Click += new System.EventHandler(this.eliminarButton_Click);
            // 
            // advertenciaLbl
            // 
            this.advertenciaLbl.Location = new System.Drawing.Point(13, 533);
            this.advertenciaLbl.Name = "advertenciaLbl";
            this.advertenciaLbl.Size = new System.Drawing.Size(539, 31);
            this.advertenciaLbl.TabIndex = 0;
            this.advertenciaLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.advertenciaLbl.Visible = false;
            // 
            // anadirButton
            // 
            this.anadirButton.Location = new System.Drawing.Point(351, 282);
            this.anadirButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.anadirButton.Name = "anadirButton";
            this.anadirButton.Size = new System.Drawing.Size(112, 37);
            this.anadirButton.TabIndex = 7;
            this.anadirButton.Text = "Añadir";
            this.anadirButton.UseVisualStyleBackColor = true;
            this.anadirButton.Visible = false;
            this.anadirButton.Click += new System.EventHandler(this.anadirButton_Click);
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 573);
            this.Controls.Add(this.advertenciaLbl);
            this.Controls.Add(this.eliminarButton);
            this.Controls.Add(this.modificarButton);
            this.Controls.Add(this.anadirButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.fotoLbl);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.telefonoLbl);
            this.Controls.Add(this.nombreLbl);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.fotoPictureBox);
            this.Controls.Add(this.contactosListBox);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Formulario";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Practica 3 Doval Fraga Jose Angel";
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox contactosListBox;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label nombreLbl;
        private System.Windows.Forms.Label telefonoLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label fotoLbl;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button modificarButton;
        private System.Windows.Forms.Button eliminarButton;
        private System.Windows.Forms.Label advertenciaLbl;
        private System.Windows.Forms.Button anadirButton;
    }
}

