namespace Practica01_Extra_Jose_Angel_Doval_Fraga
{
    partial class Practica01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Practica01));
            this.lbl_dni = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_apellido1 = new System.Windows.Forms.Label();
            this.lbl_apellido2 = new System.Windows.Forms.Label();
            this.txtBox_dni = new System.Windows.Forms.TextBox();
            this.txtBox_nombre = new System.Windows.Forms.TextBox();
            this.txtBox_apellido1 = new System.Windows.Forms.TextBox();
            this.txtBox_apellido2 = new System.Windows.Forms.TextBox();
            this.grpBox_titulacion = new System.Windows.Forms.GroupBox();
            this.rdBtn_otra = new System.Windows.Forms.RadioButton();
            this.rdBtn_uni = new System.Windows.Forms.RadioButton();
            this.rdBtn_fp = new System.Windows.Forms.RadioButton();
            this.rdBtn_bach = new System.Windows.Forms.RadioButton();
            this.rdBtn_eso = new System.Windows.Forms.RadioButton();
            this.rdBtn_none = new System.Windows.Forms.RadioButton();
            this.txtBox_rdbtn_otra = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txtBox_buscar = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.grpBox_perm = new System.Windows.Forms.GroupBox();
            this.chkBox_E = new System.Windows.Forms.CheckBox();
            this.chkBox_D = new System.Windows.Forms.CheckBox();
            this.chkBox_C = new System.Windows.Forms.CheckBox();
            this.chkBox_B = new System.Windows.Forms.CheckBox();
            this.chkBox_A = new System.Windows.Forms.CheckBox();
            this.grpBox_sex = new System.Windows.Forms.GroupBox();
            this.rdBtn_mujer = new System.Windows.Forms.RadioButton();
            this.rdBtn_hombre = new System.Windows.Forms.RadioButton();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.lbl_advertencia = new System.Windows.Forms.Label();
            this.grpBox_titulacion.SuspendLayout();
            this.grpBox_perm.SuspendLayout();
            this.grpBox_sex.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_dni
            // 
            resources.ApplyResources(this.lbl_dni, "lbl_dni");
            this.lbl_dni.Name = "lbl_dni";
            // 
            // lbl_Nombre
            // 
            resources.ApplyResources(this.lbl_Nombre, "lbl_Nombre");
            this.lbl_Nombre.Name = "lbl_Nombre";
            // 
            // lbl_apellido1
            // 
            resources.ApplyResources(this.lbl_apellido1, "lbl_apellido1");
            this.lbl_apellido1.Name = "lbl_apellido1";
            // 
            // lbl_apellido2
            // 
            resources.ApplyResources(this.lbl_apellido2, "lbl_apellido2");
            this.lbl_apellido2.Name = "lbl_apellido2";
            // 
            // txtBox_dni
            // 
            resources.ApplyResources(this.txtBox_dni, "txtBox_dni");
            this.txtBox_dni.Name = "txtBox_dni";
            this.txtBox_dni.Enter += new System.EventHandler(this.txtBox_dni_Enter);
            this.txtBox_dni.Leave += new System.EventHandler(this.txtBox_dni_Leave);
            // 
            // txtBox_nombre
            // 
            resources.ApplyResources(this.txtBox_nombre, "txtBox_nombre");
            this.txtBox_nombre.Name = "txtBox_nombre";
            this.txtBox_nombre.Enter += new System.EventHandler(this.txtBox_nombre_Enter);
            this.txtBox_nombre.Leave += new System.EventHandler(this.txtBox_nombre_Leave);
            // 
            // txtBox_apellido1
            // 
            resources.ApplyResources(this.txtBox_apellido1, "txtBox_apellido1");
            this.txtBox_apellido1.Name = "txtBox_apellido1";
            this.txtBox_apellido1.Enter += new System.EventHandler(this.txtBox_apellido1_Enter);
            this.txtBox_apellido1.Leave += new System.EventHandler(this.txtBox_apellido1_Leave);
            // 
            // txtBox_apellido2
            // 
            resources.ApplyResources(this.txtBox_apellido2, "txtBox_apellido2");
            this.txtBox_apellido2.Name = "txtBox_apellido2";
            this.txtBox_apellido2.Enter += new System.EventHandler(this.txtBox_apellido2_Enter);
            this.txtBox_apellido2.Leave += new System.EventHandler(this.txtBox_apellido2_Leave);
            // 
            // grpBox_titulacion
            // 
            this.grpBox_titulacion.Controls.Add(this.rdBtn_otra);
            this.grpBox_titulacion.Controls.Add(this.rdBtn_uni);
            this.grpBox_titulacion.Controls.Add(this.rdBtn_fp);
            this.grpBox_titulacion.Controls.Add(this.rdBtn_bach);
            this.grpBox_titulacion.Controls.Add(this.rdBtn_eso);
            this.grpBox_titulacion.Controls.Add(this.rdBtn_none);
            this.grpBox_titulacion.Controls.Add(this.txtBox_rdbtn_otra);
            resources.ApplyResources(this.grpBox_titulacion, "grpBox_titulacion");
            this.grpBox_titulacion.Name = "grpBox_titulacion";
            this.grpBox_titulacion.TabStop = false;
            // 
            // rdBtn_otra
            // 
            resources.ApplyResources(this.rdBtn_otra, "rdBtn_otra");
            this.rdBtn_otra.Name = "rdBtn_otra";
            this.rdBtn_otra.TabStop = true;
            this.rdBtn_otra.UseVisualStyleBackColor = true;
            this.rdBtn_otra.CheckedChanged += new System.EventHandler(this.rdBtn_otra_CheckedChanged);
            // 
            // rdBtn_uni
            // 
            resources.ApplyResources(this.rdBtn_uni, "rdBtn_uni");
            this.rdBtn_uni.Name = "rdBtn_uni";
            this.rdBtn_uni.TabStop = true;
            this.rdBtn_uni.UseVisualStyleBackColor = true;
            // 
            // rdBtn_fp
            // 
            resources.ApplyResources(this.rdBtn_fp, "rdBtn_fp");
            this.rdBtn_fp.Name = "rdBtn_fp";
            this.rdBtn_fp.TabStop = true;
            this.rdBtn_fp.UseVisualStyleBackColor = true;
            // 
            // rdBtn_bach
            // 
            resources.ApplyResources(this.rdBtn_bach, "rdBtn_bach");
            this.rdBtn_bach.Name = "rdBtn_bach";
            this.rdBtn_bach.TabStop = true;
            this.rdBtn_bach.UseVisualStyleBackColor = true;
            // 
            // rdBtn_eso
            // 
            resources.ApplyResources(this.rdBtn_eso, "rdBtn_eso");
            this.rdBtn_eso.Name = "rdBtn_eso";
            this.rdBtn_eso.TabStop = true;
            this.rdBtn_eso.UseVisualStyleBackColor = true;
            // 
            // rdBtn_none
            // 
            resources.ApplyResources(this.rdBtn_none, "rdBtn_none");
            this.rdBtn_none.Name = "rdBtn_none";
            this.rdBtn_none.TabStop = true;
            this.rdBtn_none.UseVisualStyleBackColor = true;
            // 
            // txtBox_rdbtn_otra
            // 
            resources.ApplyResources(this.txtBox_rdbtn_otra, "txtBox_rdbtn_otra");
            this.txtBox_rdbtn_otra.Name = "txtBox_rdbtn_otra";
            // 
            // btn_buscar
            // 
            resources.ApplyResources(this.btn_buscar, "btn_buscar");
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txtBox_buscar
            // 
            resources.ApplyResources(this.txtBox_buscar, "txtBox_buscar");
            this.txtBox_buscar.Name = "txtBox_buscar";
            this.txtBox_buscar.Enter += new System.EventHandler(this.txtBox_buscar_Enter);
            this.txtBox_buscar.Leave += new System.EventHandler(this.txtBox_buscar_Leave);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // grpBox_perm
            // 
            this.grpBox_perm.Controls.Add(this.chkBox_E);
            this.grpBox_perm.Controls.Add(this.chkBox_D);
            this.grpBox_perm.Controls.Add(this.chkBox_C);
            this.grpBox_perm.Controls.Add(this.chkBox_B);
            this.grpBox_perm.Controls.Add(this.chkBox_A);
            resources.ApplyResources(this.grpBox_perm, "grpBox_perm");
            this.grpBox_perm.Name = "grpBox_perm";
            this.grpBox_perm.TabStop = false;
            // 
            // chkBox_E
            // 
            resources.ApplyResources(this.chkBox_E, "chkBox_E");
            this.chkBox_E.Name = "chkBox_E";
            this.chkBox_E.UseVisualStyleBackColor = true;
            // 
            // chkBox_D
            // 
            resources.ApplyResources(this.chkBox_D, "chkBox_D");
            this.chkBox_D.Name = "chkBox_D";
            this.chkBox_D.UseVisualStyleBackColor = true;
            // 
            // chkBox_C
            // 
            resources.ApplyResources(this.chkBox_C, "chkBox_C");
            this.chkBox_C.Name = "chkBox_C";
            this.chkBox_C.UseVisualStyleBackColor = true;
            // 
            // chkBox_B
            // 
            resources.ApplyResources(this.chkBox_B, "chkBox_B");
            this.chkBox_B.Name = "chkBox_B";
            this.chkBox_B.UseVisualStyleBackColor = true;
            // 
            // chkBox_A
            // 
            resources.ApplyResources(this.chkBox_A, "chkBox_A");
            this.chkBox_A.Name = "chkBox_A";
            this.chkBox_A.UseVisualStyleBackColor = true;
            // 
            // grpBox_sex
            // 
            this.grpBox_sex.Controls.Add(this.rdBtn_mujer);
            this.grpBox_sex.Controls.Add(this.rdBtn_hombre);
            resources.ApplyResources(this.grpBox_sex, "grpBox_sex");
            this.grpBox_sex.Name = "grpBox_sex";
            this.grpBox_sex.TabStop = false;
            // 
            // rdBtn_mujer
            // 
            resources.ApplyResources(this.rdBtn_mujer, "rdBtn_mujer");
            this.rdBtn_mujer.Name = "rdBtn_mujer";
            this.rdBtn_mujer.TabStop = true;
            this.rdBtn_mujer.UseVisualStyleBackColor = true;
            // 
            // rdBtn_hombre
            // 
            resources.ApplyResources(this.rdBtn_hombre, "rdBtn_hombre");
            this.rdBtn_hombre.Name = "rdBtn_hombre";
            this.rdBtn_hombre.TabStop = true;
            this.rdBtn_hombre.UseVisualStyleBackColor = true;
            // 
            // btn_guardar
            // 
            resources.ApplyResources(this.btn_guardar, "btn_guardar");
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // lbl_advertencia
            // 
            resources.ApplyResources(this.lbl_advertencia, "lbl_advertencia");
            this.lbl_advertencia.Name = "lbl_advertencia";
            // 
            // Practica01
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.lbl_advertencia);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.grpBox_perm);
            this.Controls.Add(this.grpBox_sex);
            this.Controls.Add(this.grpBox_titulacion);
            this.Controls.Add(this.txtBox_buscar);
            this.Controls.Add(this.txtBox_apellido2);
            this.Controls.Add(this.txtBox_apellido1);
            this.Controls.Add(this.txtBox_nombre);
            this.Controls.Add(this.txtBox_dni);
            this.Controls.Add(this.lbl_apellido2);
            this.Controls.Add(this.lbl_apellido1);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.lbl_dni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Practica01";
            this.Load += new System.EventHandler(this.Practica01_Load);
            this.grpBox_titulacion.ResumeLayout(false);
            this.grpBox_titulacion.PerformLayout();
            this.grpBox_perm.ResumeLayout(false);
            this.grpBox_perm.PerformLayout();
            this.grpBox_sex.ResumeLayout(false);
            this.grpBox_sex.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_apellido1;
        private System.Windows.Forms.Label lbl_apellido2;
        private System.Windows.Forms.TextBox txtBox_dni;
        private System.Windows.Forms.TextBox txtBox_nombre;
        private System.Windows.Forms.TextBox txtBox_apellido1;
        private System.Windows.Forms.TextBox txtBox_apellido2;
        private System.Windows.Forms.GroupBox grpBox_titulacion;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txtBox_buscar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox grpBox_perm;
        private System.Windows.Forms.GroupBox grpBox_sex;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.RadioButton rdBtn_otra;
        private System.Windows.Forms.RadioButton rdBtn_uni;
        private System.Windows.Forms.RadioButton rdBtn_fp;
        private System.Windows.Forms.RadioButton rdBtn_bach;
        private System.Windows.Forms.RadioButton rdBtn_eso;
        private System.Windows.Forms.RadioButton rdBtn_none;
        private System.Windows.Forms.CheckBox chkBox_E;
        private System.Windows.Forms.CheckBox chkBox_D;
        private System.Windows.Forms.CheckBox chkBox_C;
        private System.Windows.Forms.CheckBox chkBox_B;
        private System.Windows.Forms.CheckBox chkBox_A;
        private System.Windows.Forms.RadioButton rdBtn_mujer;
        private System.Windows.Forms.RadioButton rdBtn_hombre;
        private System.Windows.Forms.TextBox txtBox_rdbtn_otra;
        private System.Windows.Forms.Label lbl_advertencia;
    }
}

