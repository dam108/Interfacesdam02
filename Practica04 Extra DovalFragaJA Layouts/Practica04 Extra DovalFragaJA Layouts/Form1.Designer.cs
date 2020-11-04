namespace Practica04_Extra_DovalFragaJA_Layouts
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
            this.engadirBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.eliminarTrabajadorBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.profesionAnadir_TextBox = new System.Windows.Forms.TextBox();
            this.profesion_ListBox = new System.Windows.Forms.ListBox();
            this.eliminarProfesion_Btn = new System.Windows.Forms.Button();
            this.anadirProfesion_Btn = new System.Windows.Forms.Button();
            this.advertencia_Lbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.provinciasAnadir_TextBox = new System.Windows.Forms.TextBox();
            this.provincias_ComboBox = new System.Windows.Forms.ComboBox();
            this.eliminarProvincia_Btn = new System.Windows.Forms.Button();
            this.anadirProvincia_Btn = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.detalleTrabajador_TextBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.trabajadores_ListView = new System.Windows.Forms.ListView();
            this.nombre_ListView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.provincia_ListView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.profesion_ListView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.apellido2_TextBox = new System.Windows.Forms.TextBox();
            this.apellido1_TextBox = new System.Windows.Forms.TextBox();
            this.nombre_TextBox = new System.Windows.Forms.TextBox();
            this.dni_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // engadirBtn
            // 
            this.engadirBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.engadirBtn.Location = new System.Drawing.Point(4, 677);
            this.engadirBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.engadirBtn.Name = "engadirBtn";
            this.engadirBtn.Size = new System.Drawing.Size(626, 37);
            this.engadirBtn.TabIndex = 12;
            this.engadirBtn.Text = "Engadir traballador";
            this.engadirBtn.UseVisualStyleBackColor = true;
            this.engadirBtn.Click += new System.EventHandler(this.engadirBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.Location = new System.Drawing.Point(638, 677);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(609, 37);
            this.exitBtn.TabIndex = 16;
            this.exitBtn.Text = "Pechar a aplicación";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // eliminarTrabajadorBtn
            // 
            this.eliminarTrabajadorBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eliminarTrabajadorBtn.Location = new System.Drawing.Point(638, 294);
            this.eliminarTrabajadorBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.eliminarTrabajadorBtn.Name = "eliminarTrabajadorBtn";
            this.eliminarTrabajadorBtn.Size = new System.Drawing.Size(609, 37);
            this.eliminarTrabajadorBtn.TabIndex = 14;
            this.eliminarTrabajadorBtn.Text = "Eliminar traballador";
            this.eliminarTrabajadorBtn.UseVisualStyleBackColor = true;
            this.eliminarTrabajadorBtn.Click += new System.EventHandler(this.eliminarTrabajadorBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.profesionAnadir_TextBox);
            this.groupBox3.Controls.Add(this.profesion_ListBox);
            this.groupBox3.Controls.Add(this.eliminarProfesion_Btn);
            this.groupBox3.Controls.Add(this.anadirProfesion_Btn);
            this.groupBox3.Location = new System.Drawing.Point(4, 444);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(626, 223);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Profesión do traballador";
            // 
            // profesionAnadir_TextBox
            // 
            this.profesionAnadir_TextBox.Location = new System.Drawing.Point(8, 167);
            this.profesionAnadir_TextBox.Name = "profesionAnadir_TextBox";
            this.profesionAnadir_TextBox.Size = new System.Drawing.Size(297, 29);
            this.profesionAnadir_TextBox.TabIndex = 1;
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
            // eliminarProfesion_Btn
            // 
            this.eliminarProfesion_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eliminarProfesion_Btn.Location = new System.Drawing.Point(321, 31);
            this.eliminarProfesion_Btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.eliminarProfesion_Btn.Name = "eliminarProfesion_Btn";
            this.eliminarProfesion_Btn.Size = new System.Drawing.Size(265, 37);
            this.eliminarProfesion_Btn.TabIndex = 2;
            this.eliminarProfesion_Btn.Text = "Eliminar Profesión";
            this.eliminarProfesion_Btn.UseVisualStyleBackColor = true;
            this.eliminarProfesion_Btn.Click += new System.EventHandler(this.eliminarProfesion_Btn_Click);
            // 
            // anadirProfesion_Btn
            // 
            this.anadirProfesion_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.anadirProfesion_Btn.Location = new System.Drawing.Point(321, 162);
            this.anadirProfesion_Btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.anadirProfesion_Btn.Name = "anadirProfesion_Btn";
            this.anadirProfesion_Btn.Size = new System.Drawing.Size(265, 37);
            this.anadirProfesion_Btn.TabIndex = 3;
            this.anadirProfesion_Btn.Text = "Engadir Profesión";
            this.anadirProfesion_Btn.UseVisualStyleBackColor = true;
            this.anadirProfesion_Btn.Click += new System.EventHandler(this.anadirProfesion_Btn_Click);
            // 
            // advertencia_Lbl
            // 
            this.advertencia_Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.advertencia_Lbl.BackColor = System.Drawing.Color.Red;
            this.tableLayoutPanel1.SetColumnSpan(this.advertencia_Lbl, 2);
            this.advertencia_Lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advertencia_Lbl.ForeColor = System.Drawing.Color.White;
            this.advertencia_Lbl.Location = new System.Drawing.Point(4, 731);
            this.advertencia_Lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.advertencia_Lbl.Name = "advertencia_Lbl";
            this.advertencia_Lbl.Size = new System.Drawing.Size(1243, 45);
            this.advertencia_Lbl.TabIndex = 8;
            this.advertencia_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.advertencia_Lbl.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.provinciasAnadir_TextBox);
            this.groupBox2.Controls.Add(this.provincias_ComboBox);
            this.groupBox2.Controls.Add(this.eliminarProvincia_Btn);
            this.groupBox2.Controls.Add(this.anadirProvincia_Btn);
            this.groupBox2.Location = new System.Drawing.Point(4, 294);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(626, 140);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Provincia do traballador";
            // 
            // provinciasAnadir_TextBox
            // 
            this.provinciasAnadir_TextBox.Location = new System.Drawing.Point(8, 79);
            this.provinciasAnadir_TextBox.Name = "provinciasAnadir_TextBox";
            this.provinciasAnadir_TextBox.Size = new System.Drawing.Size(297, 29);
            this.provinciasAnadir_TextBox.TabIndex = 1;
            // 
            // provincias_ComboBox
            // 
            this.provincias_ComboBox.FormattingEnabled = true;
            this.provincias_ComboBox.Location = new System.Drawing.Point(8, 31);
            this.provincias_ComboBox.Name = "provincias_ComboBox";
            this.provincias_ComboBox.Size = new System.Drawing.Size(121, 29);
            this.provincias_ComboBox.TabIndex = 0;
            // 
            // eliminarProvincia_Btn
            // 
            this.eliminarProvincia_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eliminarProvincia_Btn.Location = new System.Drawing.Point(321, 26);
            this.eliminarProvincia_Btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.eliminarProvincia_Btn.Name = "eliminarProvincia_Btn";
            this.eliminarProvincia_Btn.Size = new System.Drawing.Size(265, 37);
            this.eliminarProvincia_Btn.TabIndex = 2;
            this.eliminarProvincia_Btn.Text = "Eliminar Provincia";
            this.eliminarProvincia_Btn.UseVisualStyleBackColor = true;
            this.eliminarProvincia_Btn.Click += new System.EventHandler(this.eliminarProvincia_Btn_Click);
            // 
            // anadirProvincia_Btn
            // 
            this.anadirProvincia_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.anadirProvincia_Btn.Location = new System.Drawing.Point(321, 74);
            this.anadirProvincia_Btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.anadirProvincia_Btn.Name = "anadirProvincia_Btn";
            this.anadirProvincia_Btn.Size = new System.Drawing.Size(265, 37);
            this.anadirProvincia_Btn.TabIndex = 3;
            this.anadirProvincia_Btn.Text = "Engadir Provincia";
            this.anadirProvincia_Btn.UseVisualStyleBackColor = true;
            this.anadirProvincia_Btn.Click += new System.EventHandler(this.anadirProvincia_Btn_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.detalleTrabajador_TextBox);
            this.groupBox5.Location = new System.Drawing.Point(638, 444);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(609, 223);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Detalle do traballador";
            // 
            // detalleTrabajador_TextBox
            // 
            this.detalleTrabajador_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detalleTrabajador_TextBox.Location = new System.Drawing.Point(8, 31);
            this.detalleTrabajador_TextBox.Multiline = true;
            this.detalleTrabajador_TextBox.Name = "detalleTrabajador_TextBox";
            this.detalleTrabajador_TextBox.Size = new System.Drawing.Size(588, 165);
            this.detalleTrabajador_TextBox.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.trabajadores_ListView);
            this.groupBox4.Location = new System.Drawing.Point(638, 5);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(609, 279);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Traballadores dispoñibles";
            // 
            // trabajadores_ListView
            // 
            this.trabajadores_ListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trabajadores_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nombre_ListView,
            this.provincia_ListView,
            this.profesion_ListView});
            this.trabajadores_ListView.HideSelection = false;
            this.trabajadores_ListView.Location = new System.Drawing.Point(8, 31);
            this.trabajadores_ListView.MultiSelect = false;
            this.trabajadores_ListView.Name = "trabajadores_ListView";
            this.trabajadores_ListView.Size = new System.Drawing.Size(588, 233);
            this.trabajadores_ListView.TabIndex = 0;
            this.trabajadores_ListView.UseCompatibleStateImageBehavior = false;
            this.trabajadores_ListView.View = System.Windows.Forms.View.Details;
            this.trabajadores_ListView.DoubleClick += new System.EventHandler(this.trabajadores_ListView_DoubleClick);
            // 
            // nombre_ListView
            // 
            this.nombre_ListView.Text = "Nome e apellidos";
            this.nombre_ListView.Width = 238;
            // 
            // provincia_ListView
            // 
            this.provincia_ListView.Text = "Provincia";
            this.provincia_ListView.Width = 160;
            // 
            // profesion_ListView
            // 
            this.profesion_ListView.Text = "Profesion";
            this.profesion_ListView.Width = 184;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.apellido2_TextBox);
            this.groupBox1.Controls.Add(this.apellido1_TextBox);
            this.groupBox1.Controls.Add(this.nombre_TextBox);
            this.groupBox1.Controls.Add(this.dni_TextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(626, 279);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Identificación do traballador";
            // 
            // apellido2_TextBox
            // 
            this.apellido2_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.apellido2_TextBox.Location = new System.Drawing.Point(106, 144);
            this.apellido2_TextBox.Name = "apellido2_TextBox";
            this.apellido2_TextBox.Size = new System.Drawing.Size(490, 29);
            this.apellido2_TextBox.TabIndex = 3;
            // 
            // apellido1_TextBox
            // 
            this.apellido1_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.apellido1_TextBox.Location = new System.Drawing.Point(106, 107);
            this.apellido1_TextBox.Name = "apellido1_TextBox";
            this.apellido1_TextBox.Size = new System.Drawing.Size(490, 29);
            this.apellido1_TextBox.TabIndex = 2;
            // 
            // nombre_TextBox
            // 
            this.nombre_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nombre_TextBox.Location = new System.Drawing.Point(106, 72);
            this.nombre_TextBox.Name = "nombre_TextBox";
            this.nombre_TextBox.Size = new System.Drawing.Size(490, 29);
            this.nombre_TextBox.TabIndex = 1;
            // 
            // dni_TextBox
            // 
            this.dni_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dni_TextBox.Location = new System.Drawing.Point(106, 35);
            this.dni_TextBox.Name = "dni_TextBox";
            this.dni_TextBox.Size = new System.Drawing.Size(490, 29);
            this.dni_TextBox.TabIndex = 0;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.75939F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.24061F));
            this.tableLayoutPanel1.Controls.Add(this.advertencia_Lbl, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.exitBtn, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.engadirBtn, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.eliminarTrabajadorBtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.70156F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.29844F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 233F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1251, 776);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 785);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Formulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doval Fraga, Jose Angel ListView";
            this.Load += new System.EventHandler(this.Formulario_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button engadirBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button eliminarTrabajadorBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox profesionAnadir_TextBox;
        private System.Windows.Forms.ListBox profesion_ListBox;
        private System.Windows.Forms.Button eliminarProfesion_Btn;
        private System.Windows.Forms.Button anadirProfesion_Btn;
        private System.Windows.Forms.Label advertencia_Lbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox provinciasAnadir_TextBox;
        private System.Windows.Forms.ComboBox provincias_ComboBox;
        private System.Windows.Forms.Button eliminarProvincia_Btn;
        private System.Windows.Forms.Button anadirProvincia_Btn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox detalleTrabajador_TextBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView trabajadores_ListView;
        private System.Windows.Forms.ColumnHeader nombre_ListView;
        private System.Windows.Forms.ColumnHeader provincia_ListView;
        private System.Windows.Forms.ColumnHeader profesion_ListView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox apellido2_TextBox;
        private System.Windows.Forms.TextBox apellido1_TextBox;
        private System.Windows.Forms.TextBox nombre_TextBox;
        private System.Windows.Forms.TextBox dni_TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

