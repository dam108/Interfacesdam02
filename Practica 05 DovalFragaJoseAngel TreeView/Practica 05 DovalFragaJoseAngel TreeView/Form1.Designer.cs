namespace Practica_05_DovalFragaJoseAngel_TreeView
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("ferrol");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("cuadrillas", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.trabajadores_TreeView = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.localidad_TextBox = new System.Windows.Forms.TextBox();
            this.altaLocalidad_Btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.apellido_TextBox = new System.Windows.Forms.TextBox();
            this.nombre_TextBox = new System.Windows.Forms.TextBox();
            this.nuevoEmpleado_Btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.localidades_comboBox = new System.Windows.Forms.ComboBox();
            this.trabajadores_Btn = new System.Windows.Forms.Button();
            this.trabajadores_ListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.advertencia_Lbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trabajadores_TreeView
            // 
            this.trabajadores_TreeView.Location = new System.Drawing.Point(20, 21);
            this.trabajadores_TreeView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trabajadores_TreeView.Name = "trabajadores_TreeView";
            treeNode1.Name = "FerrolNode";
            treeNode1.Text = "ferrol";
            treeNode2.Name = "cuadrillasNode";
            treeNode2.Text = "cuadrillas";
            this.trabajadores_TreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.trabajadores_TreeView.Size = new System.Drawing.Size(547, 487);
            this.trabajadores_TreeView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(602, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Localidad";
            // 
            // localidad_TextBox
            // 
            this.localidad_TextBox.Location = new System.Drawing.Point(685, 34);
            this.localidad_TextBox.Name = "localidad_TextBox";
            this.localidad_TextBox.Size = new System.Drawing.Size(196, 29);
            this.localidad_TextBox.TabIndex = 2;
            // 
            // altaLocalidad_Btn
            // 
            this.altaLocalidad_Btn.Location = new System.Drawing.Point(902, 31);
            this.altaLocalidad_Btn.Name = "altaLocalidad_Btn";
            this.altaLocalidad_Btn.Size = new System.Drawing.Size(245, 29);
            this.altaLocalidad_Btn.TabIndex = 3;
            this.altaLocalidad_Btn.Text = "Alta Localidad";
            this.altaLocalidad_Btn.UseVisualStyleBackColor = true;
            this.altaLocalidad_Btn.Click += new System.EventHandler(this.altaLocalidad_Btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.apellido_TextBox);
            this.groupBox1.Controls.Add(this.nombre_TextBox);
            this.groupBox1.Controls.Add(this.nuevoEmpleado_Btn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(606, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 128);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo empleado";
            // 
            // apellido_TextBox
            // 
            this.apellido_TextBox.Location = new System.Drawing.Point(94, 73);
            this.apellido_TextBox.Name = "apellido_TextBox";
            this.apellido_TextBox.Size = new System.Drawing.Size(321, 29);
            this.apellido_TextBox.TabIndex = 2;
            // 
            // nombre_TextBox
            // 
            this.nombre_TextBox.Location = new System.Drawing.Point(94, 31);
            this.nombre_TextBox.Name = "nombre_TextBox";
            this.nombre_TextBox.Size = new System.Drawing.Size(321, 29);
            this.nombre_TextBox.TabIndex = 2;
            // 
            // nuevoEmpleado_Btn
            // 
            this.nuevoEmpleado_Btn.Location = new System.Drawing.Point(421, 31);
            this.nuevoEmpleado_Btn.Name = "nuevoEmpleado_Btn";
            this.nuevoEmpleado_Btn.Size = new System.Drawing.Size(111, 29);
            this.nuevoEmpleado_Btn.TabIndex = 3;
            this.nuevoEmpleado_Btn.Text = "Alta";
            this.nuevoEmpleado_Btn.UseVisualStyleBackColor = true;
            this.nuevoEmpleado_Btn.Click += new System.EventHandler(this.nuevoEmpleado_Btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(602, 237);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Localidades";
            // 
            // localidades_comboBox
            // 
            this.localidades_comboBox.FormattingEnabled = true;
            this.localidades_comboBox.Location = new System.Drawing.Point(700, 234);
            this.localidades_comboBox.Name = "localidades_comboBox";
            this.localidades_comboBox.Size = new System.Drawing.Size(265, 29);
            this.localidades_comboBox.TabIndex = 5;
            // 
            // trabajadores_Btn
            // 
            this.trabajadores_Btn.Location = new System.Drawing.Point(971, 237);
            this.trabajadores_Btn.Name = "trabajadores_Btn";
            this.trabajadores_Btn.Size = new System.Drawing.Size(176, 29);
            this.trabajadores_Btn.TabIndex = 3;
            this.trabajadores_Btn.Text = "Trabajadores";
            this.trabajadores_Btn.UseVisualStyleBackColor = true;
            this.trabajadores_Btn.Click += new System.EventHandler(this.trabajadores_Btn_Click);
            // 
            // trabajadores_ListView
            // 
            this.trabajadores_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.trabajadores_ListView.HideSelection = false;
            this.trabajadores_ListView.Location = new System.Drawing.Point(606, 284);
            this.trabajadores_ListView.Name = "trabajadores_ListView";
            this.trabajadores_ListView.Size = new System.Drawing.Size(541, 224);
            this.trabajadores_ListView.TabIndex = 6;
            this.trabajadores_ListView.UseCompatibleStateImageBehavior = false;
            this.trabajadores_ListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 178;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Apellido";
            this.columnHeader2.Width = 215;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cargo";
            this.columnHeader3.Width = 144;
            // 
            // advertencia_Lbl
            // 
            this.advertencia_Lbl.Location = new System.Drawing.Point(20, 517);
            this.advertencia_Lbl.Name = "advertencia_Lbl";
            this.advertencia_Lbl.Size = new System.Drawing.Size(1127, 27);
            this.advertencia_Lbl.TabIndex = 7;
            this.advertencia_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.advertencia_Lbl.Visible = false;
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 557);
            this.Controls.Add(this.advertencia_Lbl);
            this.Controls.Add(this.trabajadores_ListView);
            this.Controls.Add(this.localidades_comboBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.trabajadores_Btn);
            this.Controls.Add(this.altaLocalidad_Btn);
            this.Controls.Add(this.localidad_TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trabajadores_TreeView);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Formulario";
            this.Text = "Practica 05 DovalFragaJoseAngel ";
            this.Load += new System.EventHandler(this.Formulario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView trabajadores_TreeView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox localidad_TextBox;
        private System.Windows.Forms.Button altaLocalidad_Btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox apellido_TextBox;
        private System.Windows.Forms.TextBox nombre_TextBox;
        private System.Windows.Forms.Button nuevoEmpleado_Btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox localidades_comboBox;
        private System.Windows.Forms.Button trabajadores_Btn;
        private System.Windows.Forms.ListView trabajadores_ListView;
        private System.Windows.Forms.Label advertencia_Lbl;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

