namespace Practica04_DovalFragaJA_ListView
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.eliminarBtn = new System.Windows.Forms.Button();
            this.engadirBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dni_TextBox = new System.Windows.Forms.TextBox();
            this.nombre_TextBox = new System.Windows.Forms.TextBox();
            this.apellido1_TextBox = new System.Windows.Forms.TextBox();
            this.apellido2_TextBox = new System.Windows.Forms.TextBox();
            this.provincias_ComboBox = new System.Windows.Forms.ComboBox();
            this.provinciasAnadir_TextBox = new System.Windows.Forms.TextBox();
            this.anadirProvincia_Btn = new System.Windows.Forms.Button();
            this.eliminarProvincia_Btn = new System.Windows.Forms.Button();
            this.profesion_ListBox = new System.Windows.Forms.ListBox();
            this.profesionAnadir_TextBox = new System.Windows.Forms.TextBox();
            this.anadirProfesion_Btn = new System.Windows.Forms.Button();
            this.eliminarProfesion_Btn = new System.Windows.Forms.Button();
            this.trabajadores_ListView = new System.Windows.Forms.ListView();
            this.detalleTrabajador_TextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.apellido2_TextBox);
            this.groupBox1.Controls.Add(this.apellido1_TextBox);
            this.groupBox1.Controls.Add(this.nombre_TextBox);
            this.groupBox1.Controls.Add(this.dni_TextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(603, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Identificación do traballador";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.provinciasAnadir_TextBox);
            this.groupBox2.Controls.Add(this.provincias_ComboBox);
            this.groupBox2.Controls.Add(this.eliminarProvincia_Btn);
            this.groupBox2.Controls.Add(this.anadirProvincia_Btn);
            this.groupBox2.Location = new System.Drawing.Point(13, 223);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(603, 123);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Provincia do traballador";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.profesionAnadir_TextBox);
            this.groupBox3.Controls.Add(this.profesion_ListBox);
            this.groupBox3.Controls.Add(this.eliminarProfesion_Btn);
            this.groupBox3.Controls.Add(this.anadirProfesion_Btn);
            this.groupBox3.Location = new System.Drawing.Point(13, 356);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(603, 209);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Profesión do traballador";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.trabajadores_ListView);
            this.groupBox4.Location = new System.Drawing.Point(634, 14);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(603, 272);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Traballadores dispoñibles";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.detalleTrabajador_TextBox);
            this.groupBox5.Location = new System.Drawing.Point(634, 356);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(603, 209);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Detalle do traballador";
            // 
            // eliminarBtn
            // 
            this.eliminarBtn.Location = new System.Drawing.Point(634, 297);
            this.eliminarBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.eliminarBtn.Name = "eliminarBtn";
            this.eliminarBtn.Size = new System.Drawing.Size(603, 37);
            this.eliminarBtn.TabIndex = 1;
            this.eliminarBtn.Text = "Elinimar traballador";
            this.eliminarBtn.UseVisualStyleBackColor = true;
            // 
            // engadirBtn
            // 
            this.engadirBtn.Location = new System.Drawing.Point(13, 594);
            this.engadirBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.engadirBtn.Name = "engadirBtn";
            this.engadirBtn.Size = new System.Drawing.Size(603, 37);
            this.engadirBtn.TabIndex = 1;
            this.engadirBtn.Text = "Engadir traballador";
            this.engadirBtn.UseVisualStyleBackColor = true;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(634, 594);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(603, 37);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "Pechar a aplicación";
            this.exitBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Apellido 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 147);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Apellido 2:";
            // 
            // dni_TextBox
            // 
            this.dni_TextBox.Location = new System.Drawing.Point(106, 35);
            this.dni_TextBox.Name = "dni_TextBox";
            this.dni_TextBox.Size = new System.Drawing.Size(490, 29);
            this.dni_TextBox.TabIndex = 1;
            // 
            // nombre_TextBox
            // 
            this.nombre_TextBox.Location = new System.Drawing.Point(106, 72);
            this.nombre_TextBox.Name = "nombre_TextBox";
            this.nombre_TextBox.Size = new System.Drawing.Size(490, 29);
            this.nombre_TextBox.TabIndex = 1;
            // 
            // apellido1_TextBox
            // 
            this.apellido1_TextBox.Location = new System.Drawing.Point(106, 107);
            this.apellido1_TextBox.Name = "apellido1_TextBox";
            this.apellido1_TextBox.Size = new System.Drawing.Size(490, 29);
            this.apellido1_TextBox.TabIndex = 1;
            // 
            // apellido2_TextBox
            // 
            this.apellido2_TextBox.Location = new System.Drawing.Point(106, 144);
            this.apellido2_TextBox.Name = "apellido2_TextBox";
            this.apellido2_TextBox.Size = new System.Drawing.Size(490, 29);
            this.apellido2_TextBox.TabIndex = 1;
            // 
            // provincias_ComboBox
            // 
            this.provincias_ComboBox.FormattingEnabled = true;
            this.provincias_ComboBox.Location = new System.Drawing.Point(8, 31);
            this.provincias_ComboBox.Name = "provincias_ComboBox";
            this.provincias_ComboBox.Size = new System.Drawing.Size(121, 29);
            this.provincias_ComboBox.TabIndex = 0;
            // 
            // provinciasAnadir_TextBox
            // 
            this.provinciasAnadir_TextBox.Location = new System.Drawing.Point(8, 79);
            this.provinciasAnadir_TextBox.Name = "provinciasAnadir_TextBox";
            this.provinciasAnadir_TextBox.Size = new System.Drawing.Size(297, 29);
            this.provinciasAnadir_TextBox.TabIndex = 1;
            // 
            // anadirProvincia_Btn
            // 
            this.anadirProvincia_Btn.Location = new System.Drawing.Point(321, 74);
            this.anadirProvincia_Btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.anadirProvincia_Btn.Name = "anadirProvincia_Btn";
            this.anadirProvincia_Btn.Size = new System.Drawing.Size(265, 37);
            this.anadirProvincia_Btn.TabIndex = 1;
            this.anadirProvincia_Btn.Text = "Engadir Provincia";
            this.anadirProvincia_Btn.UseVisualStyleBackColor = true;
            // 
            // eliminarProvincia_Btn
            // 
            this.eliminarProvincia_Btn.Location = new System.Drawing.Point(321, 26);
            this.eliminarProvincia_Btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.eliminarProvincia_Btn.Name = "eliminarProvincia_Btn";
            this.eliminarProvincia_Btn.Size = new System.Drawing.Size(265, 37);
            this.eliminarProvincia_Btn.TabIndex = 1;
            this.eliminarProvincia_Btn.Text = "Eliminar Provincia";
            this.eliminarProvincia_Btn.UseVisualStyleBackColor = true;
            // 
            // profesion_ListBox
            // 
            this.profesion_ListBox.FormattingEnabled = true;
            this.profesion_ListBox.ItemHeight = 21;
            this.profesion_ListBox.Location = new System.Drawing.Point(8, 31);
            this.profesion_ListBox.Name = "profesion_ListBox";
            this.profesion_ListBox.Size = new System.Drawing.Size(297, 130);
            this.profesion_ListBox.TabIndex = 0;
            // 
            // profesionAnadir_TextBox
            // 
            this.profesionAnadir_TextBox.Location = new System.Drawing.Point(8, 167);
            this.profesionAnadir_TextBox.Name = "profesionAnadir_TextBox";
            this.profesionAnadir_TextBox.Size = new System.Drawing.Size(297, 29);
            this.profesionAnadir_TextBox.TabIndex = 1;
            // 
            // anadirProfesion_Btn
            // 
            this.anadirProfesion_Btn.Location = new System.Drawing.Point(321, 162);
            this.anadirProfesion_Btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.anadirProfesion_Btn.Name = "anadirProfesion_Btn";
            this.anadirProfesion_Btn.Size = new System.Drawing.Size(265, 37);
            this.anadirProfesion_Btn.TabIndex = 1;
            this.anadirProfesion_Btn.Text = "Engadir Profesión";
            this.anadirProfesion_Btn.UseVisualStyleBackColor = true;
            // 
            // eliminarProfesion_Btn
            // 
            this.eliminarProfesion_Btn.Location = new System.Drawing.Point(321, 31);
            this.eliminarProfesion_Btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.eliminarProfesion_Btn.Name = "eliminarProfesion_Btn";
            this.eliminarProfesion_Btn.Size = new System.Drawing.Size(265, 37);
            this.eliminarProfesion_Btn.TabIndex = 1;
            this.eliminarProfesion_Btn.Text = "Eliminar Profesión";
            this.eliminarProfesion_Btn.UseVisualStyleBackColor = true;
            // 
            // trabajadores_ListView
            // 
            this.trabajadores_ListView.HideSelection = false;
            this.trabajadores_ListView.Location = new System.Drawing.Point(8, 31);
            this.trabajadores_ListView.Name = "trabajadores_ListView";
            this.trabajadores_ListView.Size = new System.Drawing.Size(588, 233);
            this.trabajadores_ListView.TabIndex = 0;
            this.trabajadores_ListView.UseCompatibleStateImageBehavior = false;
            // 
            // detalleTrabajador_TextBox
            // 
            this.detalleTrabajador_TextBox.Location = new System.Drawing.Point(8, 31);
            this.detalleTrabajador_TextBox.Multiline = true;
            this.detalleTrabajador_TextBox.Name = "detalleTrabajador_TextBox";
            this.detalleTrabajador_TextBox.Size = new System.Drawing.Size(529, 165);
            this.detalleTrabajador_TextBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 645);
            this.Controls.Add(this.engadirBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.eliminarBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button eliminarBtn;
        private System.Windows.Forms.Button engadirBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TextBox apellido2_TextBox;
        private System.Windows.Forms.TextBox apellido1_TextBox;
        private System.Windows.Forms.TextBox nombre_TextBox;
        private System.Windows.Forms.TextBox dni_TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox provinciasAnadir_TextBox;
        private System.Windows.Forms.ComboBox provincias_ComboBox;
        private System.Windows.Forms.Button eliminarProvincia_Btn;
        private System.Windows.Forms.Button anadirProvincia_Btn;
        private System.Windows.Forms.TextBox profesionAnadir_TextBox;
        private System.Windows.Forms.ListBox profesion_ListBox;
        private System.Windows.Forms.Button eliminarProfesion_Btn;
        private System.Windows.Forms.Button anadirProfesion_Btn;
        private System.Windows.Forms.ListView trabajadores_ListView;
        private System.Windows.Forms.TextBox detalleTrabajador_TextBox;
    }
}

