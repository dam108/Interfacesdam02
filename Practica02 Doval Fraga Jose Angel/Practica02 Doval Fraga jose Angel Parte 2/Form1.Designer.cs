namespace Practica02_Doval_Fraga_jose_Angel_Parte_2
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
            this.gBox_info = new System.Windows.Forms.GroupBox();
            this.gBoxGestion = new System.Windows.Forms.GroupBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblLocalidad_info = new System.Windows.Forms.Label();
            this.cboProvincia = new System.Windows.Forms.ComboBox();
            this.cboLocalidad = new System.Windows.Forms.ComboBox();
            this.radEliminar = new System.Windows.Forms.RadioButton();
            this.radModificar = new System.Windows.Forms.RadioButton();
            this.radAgregar = new System.Windows.Forms.RadioButton();
            this.lblLocalidad_gestion = new System.Windows.Forms.Label();
            this.txtLocalidad_gestion = new System.Windows.Forms.TextBox();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.gBox_info.SuspendLayout();
            this.gBoxGestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBox_info
            // 
            this.gBox_info.Controls.Add(this.cboLocalidad);
            this.gBox_info.Controls.Add(this.cboProvincia);
            this.gBox_info.Controls.Add(this.lblLocalidad_info);
            this.gBox_info.Controls.Add(this.lblProvincia);
            this.gBox_info.Location = new System.Drawing.Point(12, 12);
            this.gBox_info.Name = "gBox_info";
            this.gBox_info.Size = new System.Drawing.Size(635, 148);
            this.gBox_info.TabIndex = 0;
            this.gBox_info.TabStop = false;
            this.gBox_info.Text = "Información";
            // 
            // gBoxGestion
            // 
            this.gBoxGestion.Controls.Add(this.btnEjecutar);
            this.gBoxGestion.Controls.Add(this.txtLocalidad_gestion);
            this.gBoxGestion.Controls.Add(this.radAgregar);
            this.gBoxGestion.Controls.Add(this.radModificar);
            this.gBoxGestion.Controls.Add(this.lblLocalidad_gestion);
            this.gBoxGestion.Controls.Add(this.radEliminar);
            this.gBoxGestion.Location = new System.Drawing.Point(12, 188);
            this.gBoxGestion.Name = "gBoxGestion";
            this.gBoxGestion.Size = new System.Drawing.Size(635, 211);
            this.gBoxGestion.TabIndex = 1;
            this.gBoxGestion.TabStop = false;
            this.gBoxGestion.Text = "Gestión de información";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(22, 34);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(74, 21);
            this.lblProvincia.TabIndex = 0;
            this.lblProvincia.Text = "Provincia";
            // 
            // lblLocalidad_info
            // 
            this.lblLocalidad_info.AutoSize = true;
            this.lblLocalidad_info.Location = new System.Drawing.Point(22, 81);
            this.lblLocalidad_info.Name = "lblLocalidad_info";
            this.lblLocalidad_info.Size = new System.Drawing.Size(76, 21);
            this.lblLocalidad_info.TabIndex = 0;
            this.lblLocalidad_info.Text = "Localidad";
            // 
            // cboProvincia
            // 
            this.cboProvincia.FormattingEnabled = true;
            this.cboProvincia.Location = new System.Drawing.Point(118, 31);
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.Size = new System.Drawing.Size(495, 29);
            this.cboProvincia.TabIndex = 1;
            // 
            // cboLocalidad
            // 
            this.cboLocalidad.FormattingEnabled = true;
            this.cboLocalidad.Location = new System.Drawing.Point(118, 78);
            this.cboLocalidad.Name = "cboLocalidad";
            this.cboLocalidad.Size = new System.Drawing.Size(495, 29);
            this.cboLocalidad.TabIndex = 1;
            // 
            // radEliminar
            // 
            this.radEliminar.AutoSize = true;
            this.radEliminar.Location = new System.Drawing.Point(26, 42);
            this.radEliminar.Name = "radEliminar";
            this.radEliminar.Size = new System.Drawing.Size(243, 25);
            this.radEliminar.TabIndex = 0;
            this.radEliminar.TabStop = true;
            this.radEliminar.Text = "Eliminar localidad seleccionada";
            this.radEliminar.UseVisualStyleBackColor = true;
            // 
            // radModificar
            // 
            this.radModificar.AutoSize = true;
            this.radModificar.Location = new System.Drawing.Point(26, 73);
            this.radModificar.Name = "radModificar";
            this.radModificar.Size = new System.Drawing.Size(252, 25);
            this.radModificar.TabIndex = 0;
            this.radModificar.TabStop = true;
            this.radModificar.Text = "Modificar localidad seleccionada";
            this.radModificar.UseVisualStyleBackColor = true;
            // 
            // radAgregar
            // 
            this.radAgregar.AutoSize = true;
            this.radAgregar.Location = new System.Drawing.Point(26, 104);
            this.radAgregar.Name = "radAgregar";
            this.radAgregar.Size = new System.Drawing.Size(139, 25);
            this.radAgregar.TabIndex = 0;
            this.radAgregar.TabStop = true;
            this.radAgregar.Text = "Nueva localidad";
            this.radAgregar.UseVisualStyleBackColor = true;
            // 
            // lblLocalidad_gestion
            // 
            this.lblLocalidad_gestion.AutoSize = true;
            this.lblLocalidad_gestion.Location = new System.Drawing.Point(22, 159);
            this.lblLocalidad_gestion.Name = "lblLocalidad_gestion";
            this.lblLocalidad_gestion.Size = new System.Drawing.Size(76, 21);
            this.lblLocalidad_gestion.TabIndex = 0;
            this.lblLocalidad_gestion.Text = "Localidad";
            // 
            // txtLocalidad_gestion
            // 
            this.txtLocalidad_gestion.Location = new System.Drawing.Point(104, 156);
            this.txtLocalidad_gestion.Name = "txtLocalidad_gestion";
            this.txtLocalidad_gestion.Size = new System.Drawing.Size(509, 29);
            this.txtLocalidad_gestion.TabIndex = 1;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(307, 42);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(306, 87);
            this.btnEjecutar.TabIndex = 2;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 423);
            this.Controls.Add(this.gBoxGestion);
            this.Controls.Add(this.gBox_info);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Localidades Doval Fraga Jose Angel";
            this.gBox_info.ResumeLayout(false);
            this.gBox_info.PerformLayout();
            this.gBoxGestion.ResumeLayout(false);
            this.gBoxGestion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBox_info;
        private System.Windows.Forms.ComboBox cboLocalidad;
        private System.Windows.Forms.ComboBox cboProvincia;
        private System.Windows.Forms.Label lblLocalidad_info;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.GroupBox gBoxGestion;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.TextBox txtLocalidad_gestion;
        private System.Windows.Forms.RadioButton radAgregar;
        private System.Windows.Forms.RadioButton radModificar;
        private System.Windows.Forms.Label lblLocalidad_gestion;
        private System.Windows.Forms.RadioButton radEliminar;
    }
}

