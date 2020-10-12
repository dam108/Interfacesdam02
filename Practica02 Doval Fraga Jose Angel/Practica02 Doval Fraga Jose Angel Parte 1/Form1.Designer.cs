namespace Practica02_Doval_Fraga_Jose_Angel_Parte_1
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
            this.gBox_insertar = new System.Windows.Forms.GroupBox();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.txtAlto = new System.Windows.Forms.TextBox();
            this.txtAncho = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lbl_alto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_cm = new System.Windows.Forms.Label();
            this.lbl_ancho = new System.Windows.Forms.Label();
            this.lbl_color = new System.Windows.Forms.Label();
            this.lbl_modelo = new System.Windows.Forms.Label();
            this.gBox_salida = new System.Windows.Forms.GroupBox();
            this.btnEliminarTodas = new System.Windows.Forms.Button();
            this.btnEliminarAlfombra = new System.Windows.Forms.Button();
            this.btnInfoAlfombra = new System.Windows.Forms.Button();
            this.cboAlfombras = new System.Windows.Forms.ComboBox();
            this.lblAdvertencia = new System.Windows.Forms.Label();
            this.gBox_insertar.SuspendLayout();
            this.gBox_salida.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBox_insertar
            // 
            this.gBox_insertar.Controls.Add(this.btnAñadir);
            this.gBox_insertar.Controls.Add(this.txtAlto);
            this.gBox_insertar.Controls.Add(this.txtAncho);
            this.gBox_insertar.Controls.Add(this.txtColor);
            this.gBox_insertar.Controls.Add(this.txtModelo);
            this.gBox_insertar.Controls.Add(this.lbl_alto);
            this.gBox_insertar.Controls.Add(this.label1);
            this.gBox_insertar.Controls.Add(this.lbl_cm);
            this.gBox_insertar.Controls.Add(this.lbl_ancho);
            this.gBox_insertar.Controls.Add(this.lbl_color);
            this.gBox_insertar.Controls.Add(this.lbl_modelo);
            this.gBox_insertar.Location = new System.Drawing.Point(13, 14);
            this.gBox_insertar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gBox_insertar.Name = "gBox_insertar";
            this.gBox_insertar.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gBox_insertar.Size = new System.Drawing.Size(995, 162);
            this.gBox_insertar.TabIndex = 1;
            this.gBox_insertar.TabStop = false;
            this.gBox_insertar.Text = "Nova alfombra";
            // 
            // btnAñadir
            // 
            this.btnAñadir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadir.Location = new System.Drawing.Point(759, 41);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(203, 28);
            this.btnAñadir.TabIndex = 5;
            this.btnAñadir.Text = "Engadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // txtAlto
            // 
            this.txtAlto.Location = new System.Drawing.Point(591, 92);
            this.txtAlto.Name = "txtAlto";
            this.txtAlto.Size = new System.Drawing.Size(88, 29);
            this.txtAlto.TabIndex = 4;
            this.txtAlto.Enter += new System.EventHandler(this.txtAlto_Enter);
            this.txtAlto.Leave += new System.EventHandler(this.txtAlto_Leave);
            // 
            // txtAncho
            // 
            this.txtAncho.Location = new System.Drawing.Point(379, 92);
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(88, 29);
            this.txtAncho.TabIndex = 3;
            this.txtAncho.Enter += new System.EventHandler(this.txtAncho_Enter);
            this.txtAncho.Leave += new System.EventHandler(this.txtAncho_Leave);
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(130, 92);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(150, 29);
            this.txtColor.TabIndex = 2;
            this.txtColor.Enter += new System.EventHandler(this.txtColor_Enter);
            this.txtColor.Leave += new System.EventHandler(this.txtColor_Leave);
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(130, 41);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(596, 29);
            this.txtModelo.TabIndex = 1;
            this.txtModelo.Enter += new System.EventHandler(this.txtModelo_Enter);
            this.txtModelo.Leave += new System.EventHandler(this.txtModelo_Leave);
            // 
            // lbl_alto
            // 
            this.lbl_alto.AutoSize = true;
            this.lbl_alto.Location = new System.Drawing.Point(547, 100);
            this.lbl_alto.Name = "lbl_alto";
            this.lbl_alto.Size = new System.Drawing.Size(38, 21);
            this.lbl_alto.TabIndex = 0;
            this.lbl_alto.Text = "Alto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(685, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "(cm)";
            // 
            // lbl_cm
            // 
            this.lbl_cm.AutoSize = true;
            this.lbl_cm.Location = new System.Drawing.Point(473, 100);
            this.lbl_cm.Name = "lbl_cm";
            this.lbl_cm.Size = new System.Drawing.Size(41, 21);
            this.lbl_cm.TabIndex = 0;
            this.lbl_cm.Text = "(cm)";
            // 
            // lbl_ancho
            // 
            this.lbl_ancho.AutoSize = true;
            this.lbl_ancho.Location = new System.Drawing.Point(319, 100);
            this.lbl_ancho.Name = "lbl_ancho";
            this.lbl_ancho.Size = new System.Drawing.Size(54, 21);
            this.lbl_ancho.TabIndex = 0;
            this.lbl_ancho.Text = "Ancho";
            // 
            // lbl_color
            // 
            this.lbl_color.AutoSize = true;
            this.lbl_color.Location = new System.Drawing.Point(28, 100);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(35, 21);
            this.lbl_color.TabIndex = 0;
            this.lbl_color.Text = "Cor";
            // 
            // lbl_modelo
            // 
            this.lbl_modelo.AutoSize = true;
            this.lbl_modelo.Location = new System.Drawing.Point(28, 44);
            this.lbl_modelo.Name = "lbl_modelo";
            this.lbl_modelo.Size = new System.Drawing.Size(63, 21);
            this.lbl_modelo.TabIndex = 0;
            this.lbl_modelo.Text = "Modelo";
            // 
            // gBox_salida
            // 
            this.gBox_salida.Controls.Add(this.btnEliminarTodas);
            this.gBox_salida.Controls.Add(this.btnEliminarAlfombra);
            this.gBox_salida.Controls.Add(this.btnInfoAlfombra);
            this.gBox_salida.Controls.Add(this.cboAlfombras);
            this.gBox_salida.Location = new System.Drawing.Point(13, 255);
            this.gBox_salida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gBox_salida.Name = "gBox_salida";
            this.gBox_salida.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gBox_salida.Size = new System.Drawing.Size(995, 162);
            this.gBox_salida.TabIndex = 2;
            this.gBox_salida.TabStop = false;
            this.gBox_salida.Text = "Alfombras dipoñibles";
            // 
            // btnEliminarTodas
            // 
            this.btnEliminarTodas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTodas.Location = new System.Drawing.Point(588, 99);
            this.btnEliminarTodas.Name = "btnEliminarTodas";
            this.btnEliminarTodas.Size = new System.Drawing.Size(374, 28);
            this.btnEliminarTodas.TabIndex = 3;
            this.btnEliminarTodas.Text = "Eliminar todas";
            this.btnEliminarTodas.UseVisualStyleBackColor = true;
            // 
            // btnEliminarAlfombra
            // 
            this.btnEliminarAlfombra.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAlfombra.Location = new System.Drawing.Point(379, 99);
            this.btnEliminarAlfombra.Name = "btnEliminarAlfombra";
            this.btnEliminarAlfombra.Size = new System.Drawing.Size(203, 28);
            this.btnEliminarAlfombra.TabIndex = 2;
            this.btnEliminarAlfombra.Text = "Eliminar alfombra";
            this.btnEliminarAlfombra.UseVisualStyleBackColor = true;
            // 
            // btnInfoAlfombra
            // 
            this.btnInfoAlfombra.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfoAlfombra.Location = new System.Drawing.Point(32, 99);
            this.btnInfoAlfombra.Name = "btnInfoAlfombra";
            this.btnInfoAlfombra.Size = new System.Drawing.Size(341, 28);
            this.btnInfoAlfombra.TabIndex = 1;
            this.btnInfoAlfombra.Text = "Información da alfombra";
            this.btnInfoAlfombra.UseVisualStyleBackColor = true;
            // 
            // cboAlfombras
            // 
            this.cboAlfombras.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAlfombras.FormattingEnabled = true;
            this.cboAlfombras.Location = new System.Drawing.Point(32, 46);
            this.cboAlfombras.Name = "cboAlfombras";
            this.cboAlfombras.Size = new System.Drawing.Size(930, 25);
            this.cboAlfombras.TabIndex = 0;
            // 
            // lblAdvertencia
            // 
            this.lblAdvertencia.Location = new System.Drawing.Point(13, 205);
            this.lblAdvertencia.Name = "lblAdvertencia";
            this.lblAdvertencia.Size = new System.Drawing.Size(995, 25);
            this.lblAdvertencia.TabIndex = 1;
            this.lblAdvertencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 431);
            this.Controls.Add(this.lblAdvertencia);
            this.Controls.Add(this.gBox_salida);
            this.Controls.Add(this.gBox_insertar);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Alfombras Doval Fraga Jose Angel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gBox_insertar.ResumeLayout(false);
            this.gBox_insertar.PerformLayout();
            this.gBox_salida.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBox_insertar;
        private System.Windows.Forms.GroupBox gBox_salida;
        private System.Windows.Forms.TextBox txtAncho;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lbl_alto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_cm;
        private System.Windows.Forms.Label lbl_ancho;
        private System.Windows.Forms.Label lbl_color;
        private System.Windows.Forms.Label lbl_modelo;
        private System.Windows.Forms.TextBox txtAlto;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Button btnInfoAlfombra;
        private System.Windows.Forms.ComboBox cboAlfombras;
        private System.Windows.Forms.Button btnEliminarTodas;
        private System.Windows.Forms.Button btnEliminarAlfombra;
        private System.Windows.Forms.Label lblAdvertencia;
    }
}

