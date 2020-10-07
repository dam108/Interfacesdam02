namespace Practica01_Doval_Fraga__Jose_Angel
{
    partial class Form1
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
            this.textBox_DNI = new System.Windows.Forms.TextBox();
            this.label_DNI = new System.Windows.Forms.Label();
            this.label_Nombre = new System.Windows.Forms.Label();
            this.label_Apellido1 = new System.Windows.Forms.Label();
            this.label_Apellido2 = new System.Windows.Forms.Label();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.textBox_Apellido1 = new System.Windows.Forms.TextBox();
            this.textBox_Apellido2 = new System.Windows.Forms.TextBox();
            this.groupBox_PermisoConducir = new System.Windows.Forms.GroupBox();
            this.lbl_advertencia = new System.Windows.Forms.Label();
            this.checkedListBox_persmiso = new System.Windows.Forms.CheckedListBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.textBox_Buscar = new System.Windows.Forms.TextBox();
            this.groupBox_Titulacion = new System.Windows.Forms.GroupBox();
            this.textBox_radioBtn_Otra = new System.Windows.Forms.TextBox();
            this.radioButton_Otra = new System.Windows.Forms.RadioButton();
            this.radioButton_Universitaria = new System.Windows.Forms.RadioButton();
            this.radioButton_FP = new System.Windows.Forms.RadioButton();
            this.radioButton_Bach = new System.Windows.Forms.RadioButton();
            this.radioButton_ESO = new System.Windows.Forms.RadioButton();
            this.radioButton_Ninguna = new System.Windows.Forms.RadioButton();
            this.groupBox_Sexo = new System.Windows.Forms.GroupBox();
            this.radioButton_Mujer = new System.Windows.Forms.RadioButton();
            this.radioButton_Hombre = new System.Windows.Forms.RadioButton();
            this.groupBox_PermisoConducir.SuspendLayout();
            this.groupBox_Titulacion.SuspendLayout();
            this.groupBox_Sexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_DNI
            // 
            this.textBox_DNI.Location = new System.Drawing.Point(101, 22);
            this.textBox_DNI.Name = "textBox_DNI";
            this.textBox_DNI.Size = new System.Drawing.Size(208, 20);
            this.textBox_DNI.TabIndex = 1;
            this.textBox_DNI.Enter += new System.EventHandler(this.textBox_DNI_Enter);
            this.textBox_DNI.Leave += new System.EventHandler(this.textBox_DNI_Leave);
            // 
            // label_DNI
            // 
            this.label_DNI.AutoSize = true;
            this.label_DNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DNI.Location = new System.Drawing.Point(24, 29);
            this.label_DNI.Name = "label_DNI";
            this.label_DNI.Size = new System.Drawing.Size(31, 16);
            this.label_DNI.TabIndex = 1000;
            this.label_DNI.Text = "DNI";
            // 
            // label_Nombre
            // 
            this.label_Nombre.AutoSize = true;
            this.label_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Nombre.Location = new System.Drawing.Point(24, 65);
            this.label_Nombre.Name = "label_Nombre";
            this.label_Nombre.Size = new System.Drawing.Size(57, 16);
            this.label_Nombre.TabIndex = 1000;
            this.label_Nombre.Text = "Nombre";
            // 
            // label_Apellido1
            // 
            this.label_Apellido1.AutoSize = true;
            this.label_Apellido1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Apellido1.Location = new System.Drawing.Point(24, 105);
            this.label_Apellido1.Name = "label_Apellido1";
            this.label_Apellido1.Size = new System.Drawing.Size(68, 16);
            this.label_Apellido1.TabIndex = 1000;
            this.label_Apellido1.Text = "Apellido 1";
            // 
            // label_Apellido2
            // 
            this.label_Apellido2.AutoSize = true;
            this.label_Apellido2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Apellido2.Location = new System.Drawing.Point(24, 142);
            this.label_Apellido2.Name = "label_Apellido2";
            this.label_Apellido2.Size = new System.Drawing.Size(68, 16);
            this.label_Apellido2.TabIndex = 1000;
            this.label_Apellido2.Text = "Apellido 2";
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(101, 58);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(208, 20);
            this.textBox_Nombre.TabIndex = 2;
            this.textBox_Nombre.Enter += new System.EventHandler(this.textBox_Nombre_Enter);
            this.textBox_Nombre.Leave += new System.EventHandler(this.textBox_Nombre_Leave);
            // 
            // textBox_Apellido1
            // 
            this.textBox_Apellido1.Location = new System.Drawing.Point(101, 98);
            this.textBox_Apellido1.Name = "textBox_Apellido1";
            this.textBox_Apellido1.Size = new System.Drawing.Size(208, 20);
            this.textBox_Apellido1.TabIndex = 3;
            this.textBox_Apellido1.Enter += new System.EventHandler(this.textBox_Apellido1_Enter);
            this.textBox_Apellido1.Leave += new System.EventHandler(this.textBox_Apellido1_Leave);
            // 
            // textBox_Apellido2
            // 
            this.textBox_Apellido2.Location = new System.Drawing.Point(101, 135);
            this.textBox_Apellido2.Name = "textBox_Apellido2";
            this.textBox_Apellido2.Size = new System.Drawing.Size(208, 20);
            this.textBox_Apellido2.TabIndex = 4;
            this.textBox_Apellido2.Enter += new System.EventHandler(this.textBox_Apellido2_Enter);
            this.textBox_Apellido2.Leave += new System.EventHandler(this.textBox_Apellido2_Leave);
            // 
            // groupBox_PermisoConducir
            // 
            this.groupBox_PermisoConducir.Controls.Add(this.lbl_advertencia);
            this.groupBox_PermisoConducir.Controls.Add(this.checkedListBox_persmiso);
            this.groupBox_PermisoConducir.Location = new System.Drawing.Point(27, 179);
            this.groupBox_PermisoConducir.Name = "groupBox_PermisoConducir";
            this.groupBox_PermisoConducir.Size = new System.Drawing.Size(282, 206);
            this.groupBox_PermisoConducir.TabIndex = 5;
            this.groupBox_PermisoConducir.TabStop = false;
            this.groupBox_PermisoConducir.Text = "Permiso de Conducir";
            // 
            // lbl_advertencia
            // 
            this.lbl_advertencia.AutoSize = true;
            this.lbl_advertencia.Location = new System.Drawing.Point(22, 171);
            this.lbl_advertencia.Name = "lbl_advertencia";
            this.lbl_advertencia.Size = new System.Drawing.Size(35, 13);
            this.lbl_advertencia.TabIndex = 7;
            this.lbl_advertencia.Text = "label1";
            // 
            // checkedListBox_persmiso
            // 
            this.checkedListBox_persmiso.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.checkedListBox_persmiso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox_persmiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox_persmiso.FormattingEnabled = true;
            this.checkedListBox_persmiso.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.checkedListBox_persmiso.Location = new System.Drawing.Point(20, 40);
            this.checkedListBox_persmiso.Margin = new System.Windows.Forms.Padding(10);
            this.checkedListBox_persmiso.Name = "checkedListBox_persmiso";
            this.checkedListBox_persmiso.Size = new System.Drawing.Size(234, 126);
            this.checkedListBox_persmiso.TabIndex = 6;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(27, 405);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(114, 33);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(195, 405);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(114, 33);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // textBox_Buscar
            // 
            this.textBox_Buscar.Location = new System.Drawing.Point(339, 412);
            this.textBox_Buscar.Name = "textBox_Buscar";
            this.textBox_Buscar.Size = new System.Drawing.Size(285, 20);
            this.textBox_Buscar.TabIndex = 0;
            this.textBox_Buscar.Enter += new System.EventHandler(this.textBox_Buscar_Enter);
            this.textBox_Buscar.Leave += new System.EventHandler(this.textBox_Buscar_Leave);
            // 
            // groupBox_Titulacion
            // 
            this.groupBox_Titulacion.Controls.Add(this.textBox_radioBtn_Otra);
            this.groupBox_Titulacion.Controls.Add(this.radioButton_Otra);
            this.groupBox_Titulacion.Controls.Add(this.radioButton_Universitaria);
            this.groupBox_Titulacion.Controls.Add(this.radioButton_FP);
            this.groupBox_Titulacion.Controls.Add(this.radioButton_Bach);
            this.groupBox_Titulacion.Controls.Add(this.radioButton_ESO);
            this.groupBox_Titulacion.Controls.Add(this.radioButton_Ninguna);
            this.groupBox_Titulacion.Location = new System.Drawing.Point(339, 179);
            this.groupBox_Titulacion.Name = "groupBox_Titulacion";
            this.groupBox_Titulacion.Size = new System.Drawing.Size(285, 206);
            this.groupBox_Titulacion.TabIndex = 10;
            this.groupBox_Titulacion.TabStop = false;
            this.groupBox_Titulacion.Text = "Titulación máxima";
            // 
            // textBox_radioBtn_Otra
            // 
            this.textBox_radioBtn_Otra.Location = new System.Drawing.Point(76, 155);
            this.textBox_radioBtn_Otra.Name = "textBox_radioBtn_Otra";
            this.textBox_radioBtn_Otra.Size = new System.Drawing.Size(192, 20);
            this.textBox_radioBtn_Otra.TabIndex = 17;
            this.textBox_radioBtn_Otra.Enter += new System.EventHandler(this.textBox_radioBtn_Otra_Enter);
            this.textBox_radioBtn_Otra.Leave += new System.EventHandler(this.textBox_radioBtn_Otra_Leave);
            // 
            // radioButton_Otra
            // 
            this.radioButton_Otra.AutoSize = true;
            this.radioButton_Otra.Location = new System.Drawing.Point(25, 155);
            this.radioButton_Otra.Name = "radioButton_Otra";
            this.radioButton_Otra.Size = new System.Drawing.Size(45, 17);
            this.radioButton_Otra.TabIndex = 16;
            this.radioButton_Otra.TabStop = true;
            this.radioButton_Otra.Text = "Otra";
            this.radioButton_Otra.UseVisualStyleBackColor = true;
            this.radioButton_Otra.CheckedChanged += new System.EventHandler(this.radioButton_Otra_CheckedChanged);
            // 
            // radioButton_Universitaria
            // 
            this.radioButton_Universitaria.AutoSize = true;
            this.radioButton_Universitaria.Location = new System.Drawing.Point(25, 132);
            this.radioButton_Universitaria.Name = "radioButton_Universitaria";
            this.radioButton_Universitaria.Size = new System.Drawing.Size(83, 17);
            this.radioButton_Universitaria.TabIndex = 15;
            this.radioButton_Universitaria.TabStop = true;
            this.radioButton_Universitaria.Text = "Universitaria";
            this.radioButton_Universitaria.UseVisualStyleBackColor = true;
            // 
            // radioButton_FP
            // 
            this.radioButton_FP.AutoSize = true;
            this.radioButton_FP.Location = new System.Drawing.Point(25, 109);
            this.radioButton_FP.Name = "radioButton_FP";
            this.radioButton_FP.Size = new System.Drawing.Size(38, 17);
            this.radioButton_FP.TabIndex = 14;
            this.radioButton_FP.TabStop = true;
            this.radioButton_FP.Text = "FP";
            this.radioButton_FP.UseVisualStyleBackColor = true;
            // 
            // radioButton_Bach
            // 
            this.radioButton_Bach.AutoSize = true;
            this.radioButton_Bach.Location = new System.Drawing.Point(25, 86);
            this.radioButton_Bach.Name = "radioButton_Bach";
            this.radioButton_Bach.Size = new System.Drawing.Size(80, 17);
            this.radioButton_Bach.TabIndex = 13;
            this.radioButton_Bach.TabStop = true;
            this.radioButton_Bach.Text = "Bachillerato";
            this.radioButton_Bach.UseVisualStyleBackColor = true;
            // 
            // radioButton_ESO
            // 
            this.radioButton_ESO.AutoSize = true;
            this.radioButton_ESO.Location = new System.Drawing.Point(25, 63);
            this.radioButton_ESO.Name = "radioButton_ESO";
            this.radioButton_ESO.Size = new System.Drawing.Size(47, 17);
            this.radioButton_ESO.TabIndex = 12;
            this.radioButton_ESO.TabStop = true;
            this.radioButton_ESO.Text = "ESO";
            this.radioButton_ESO.UseVisualStyleBackColor = true;
            // 
            // radioButton_Ninguna
            // 
            this.radioButton_Ninguna.AutoSize = true;
            this.radioButton_Ninguna.Location = new System.Drawing.Point(25, 40);
            this.radioButton_Ninguna.Name = "radioButton_Ninguna";
            this.radioButton_Ninguna.Size = new System.Drawing.Size(65, 17);
            this.radioButton_Ninguna.TabIndex = 11;
            this.radioButton_Ninguna.TabStop = true;
            this.radioButton_Ninguna.Text = "Ninguna";
            this.radioButton_Ninguna.UseVisualStyleBackColor = true;
            // 
            // groupBox_Sexo
            // 
            this.groupBox_Sexo.Controls.Add(this.radioButton_Mujer);
            this.groupBox_Sexo.Controls.Add(this.radioButton_Hombre);
            this.groupBox_Sexo.Location = new System.Drawing.Point(339, 29);
            this.groupBox_Sexo.Name = "groupBox_Sexo";
            this.groupBox_Sexo.Size = new System.Drawing.Size(285, 126);
            this.groupBox_Sexo.TabIndex = 7;
            this.groupBox_Sexo.TabStop = false;
            this.groupBox_Sexo.Text = "Sexo";
            // 
            // radioButton_Mujer
            // 
            this.radioButton_Mujer.AutoSize = true;
            this.radioButton_Mujer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.radioButton_Mujer.Location = new System.Drawing.Point(25, 67);
            this.radioButton_Mujer.Name = "radioButton_Mujer";
            this.radioButton_Mujer.Size = new System.Drawing.Size(61, 21);
            this.radioButton_Mujer.TabIndex = 9;
            this.radioButton_Mujer.TabStop = true;
            this.radioButton_Mujer.Text = "Mujer";
            this.radioButton_Mujer.UseVisualStyleBackColor = true;
            // 
            // radioButton_Hombre
            // 
            this.radioButton_Hombre.AutoSize = true;
            this.radioButton_Hombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.radioButton_Hombre.Location = new System.Drawing.Point(25, 32);
            this.radioButton_Hombre.Name = "radioButton_Hombre";
            this.radioButton_Hombre.Size = new System.Drawing.Size(76, 21);
            this.radioButton_Hombre.TabIndex = 8;
            this.radioButton_Hombre.TabStop = true;
            this.radioButton_Hombre.Text = "Hombre";
            this.radioButton_Hombre.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(653, 450);
            this.Controls.Add(this.groupBox_Sexo);
            this.Controls.Add(this.groupBox_Titulacion);
            this.Controls.Add(this.textBox_Buscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox_PermisoConducir);
            this.Controls.Add(this.textBox_Apellido2);
            this.Controls.Add(this.textBox_Apellido1);
            this.Controls.Add(this.textBox_Nombre);
            this.Controls.Add(this.label_Apellido2);
            this.Controls.Add(this.label_Apellido1);
            this.Controls.Add(this.label_Nombre);
            this.Controls.Add(this.label_DNI);
            this.Controls.Add(this.textBox_DNI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Practica 1 Extra Doval Fraga Jose Angel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_PermisoConducir.ResumeLayout(false);
            this.groupBox_PermisoConducir.PerformLayout();
            this.groupBox_Titulacion.ResumeLayout(false);
            this.groupBox_Titulacion.PerformLayout();
            this.groupBox_Sexo.ResumeLayout(false);
            this.groupBox_Sexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_DNI;
        private System.Windows.Forms.Label label_DNI;
        private System.Windows.Forms.Label label_Nombre;
        private System.Windows.Forms.Label label_Apellido1;
        private System.Windows.Forms.Label label_Apellido2;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.TextBox textBox_Apellido1;
        private System.Windows.Forms.TextBox textBox_Apellido2;
        private System.Windows.Forms.GroupBox groupBox_PermisoConducir;
        private System.Windows.Forms.CheckedListBox checkedListBox_persmiso;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox textBox_Buscar;
        private System.Windows.Forms.GroupBox groupBox_Titulacion;
        private System.Windows.Forms.GroupBox groupBox_Sexo;
        private System.Windows.Forms.RadioButton radioButton_Mujer;
        private System.Windows.Forms.RadioButton radioButton_Hombre;
        private System.Windows.Forms.TextBox textBox_radioBtn_Otra;
        private System.Windows.Forms.RadioButton radioButton_Otra;
        private System.Windows.Forms.RadioButton radioButton_Universitaria;
        private System.Windows.Forms.RadioButton radioButton_FP;
        private System.Windows.Forms.RadioButton radioButton_Bach;
        private System.Windows.Forms.RadioButton radioButton_ESO;
        private System.Windows.Forms.RadioButton radioButton_Ninguna;
        private System.Windows.Forms.Label lbl_advertencia;
    }
}

