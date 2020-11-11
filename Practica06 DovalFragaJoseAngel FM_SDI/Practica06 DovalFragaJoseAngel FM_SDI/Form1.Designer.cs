namespace Practica06_DovalFragaJoseAngel_FM_SDI
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
            this.hijaA_btn = new System.Windows.Forms.Button();
            this.hijaB_btn = new System.Windows.Forms.Button();
            this.hijaC_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mostrar_todas_rbt = new System.Windows.Forms.RadioButton();
            this.mostrar_tipoC_rbt = new System.Windows.Forms.RadioButton();
            this.mostrar_tipoB_rbt = new System.Windows.Forms.RadioButton();
            this.mostrar_tipoA_rbt = new System.Windows.Forms.RadioButton();
            this.mostrar_rdbt_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ocultar_todas_rbt = new System.Windows.Forms.RadioButton();
            this.ocultar_rdbt_btn = new System.Windows.Forms.Button();
            this.ocultar_TipoC_rbt = new System.Windows.Forms.RadioButton();
            this.ocultar_TipoB_rbt = new System.Windows.Forms.RadioButton();
            this.ocultar_TipoA_rbt = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ventanas_ListBox = new System.Windows.Forms.ListBox();
            this.cerrar_listBox_btn = new System.Windows.Forms.Button();
            this.ocultar_listBox_btn = new System.Windows.Forms.Button();
            this.mostrar_listBox_btn = new System.Windows.Forms.Button();
            this.nhijos_info_lbl = new System.Windows.Forms.Label();
            this.numeroVentanas_Lbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // hijaA_btn
            // 
            this.hijaA_btn.Location = new System.Drawing.Point(27, 42);
            this.hijaA_btn.Name = "hijaA_btn";
            this.hijaA_btn.Size = new System.Drawing.Size(75, 23);
            this.hijaA_btn.TabIndex = 0;
            this.hijaA_btn.Text = "Hija A";
            this.hijaA_btn.UseVisualStyleBackColor = true;
            this.hijaA_btn.Click += new System.EventHandler(this.hijaA_btn_Click);
            // 
            // hijaB_btn
            // 
            this.hijaB_btn.Location = new System.Drawing.Point(27, 71);
            this.hijaB_btn.Name = "hijaB_btn";
            this.hijaB_btn.Size = new System.Drawing.Size(75, 23);
            this.hijaB_btn.TabIndex = 0;
            this.hijaB_btn.Text = "Hija B";
            this.hijaB_btn.UseVisualStyleBackColor = true;
            this.hijaB_btn.Click += new System.EventHandler(this.hijaB_btn_Click);
            // 
            // hijaC_btn
            // 
            this.hijaC_btn.Location = new System.Drawing.Point(27, 100);
            this.hijaC_btn.Name = "hijaC_btn";
            this.hijaC_btn.Size = new System.Drawing.Size(75, 23);
            this.hijaC_btn.TabIndex = 0;
            this.hijaC_btn.Text = "Hija C";
            this.hijaC_btn.UseVisualStyleBackColor = true;
            this.hijaC_btn.Click += new System.EventHandler(this.hijaC_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mostrar_todas_rbt);
            this.groupBox1.Controls.Add(this.mostrar_tipoC_rbt);
            this.groupBox1.Controls.Add(this.mostrar_tipoB_rbt);
            this.groupBox1.Controls.Add(this.mostrar_tipoA_rbt);
            this.groupBox1.Controls.Add(this.mostrar_rdbt_btn);
            this.groupBox1.Location = new System.Drawing.Point(143, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 175);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mostrar";
            // 
            // mostrar_todas_rbt
            // 
            this.mostrar_todas_rbt.AutoSize = true;
            this.mostrar_todas_rbt.Location = new System.Drawing.Point(22, 97);
            this.mostrar_todas_rbt.Name = "mostrar_todas_rbt";
            this.mostrar_todas_rbt.Size = new System.Drawing.Size(55, 17);
            this.mostrar_todas_rbt.TabIndex = 1;
            this.mostrar_todas_rbt.TabStop = true;
            this.mostrar_todas_rbt.Text = "Todas";
            this.mostrar_todas_rbt.UseVisualStyleBackColor = true;
            // 
            // mostrar_tipoC_rbt
            // 
            this.mostrar_tipoC_rbt.AutoSize = true;
            this.mostrar_tipoC_rbt.Location = new System.Drawing.Point(22, 74);
            this.mostrar_tipoC_rbt.Name = "mostrar_tipoC_rbt";
            this.mostrar_tipoC_rbt.Size = new System.Drawing.Size(56, 17);
            this.mostrar_tipoC_rbt.TabIndex = 1;
            this.mostrar_tipoC_rbt.TabStop = true;
            this.mostrar_tipoC_rbt.Text = "Tipo C";
            this.mostrar_tipoC_rbt.UseVisualStyleBackColor = true;
            // 
            // mostrar_tipoB_rbt
            // 
            this.mostrar_tipoB_rbt.AutoSize = true;
            this.mostrar_tipoB_rbt.Location = new System.Drawing.Point(22, 51);
            this.mostrar_tipoB_rbt.Name = "mostrar_tipoB_rbt";
            this.mostrar_tipoB_rbt.Size = new System.Drawing.Size(56, 17);
            this.mostrar_tipoB_rbt.TabIndex = 1;
            this.mostrar_tipoB_rbt.TabStop = true;
            this.mostrar_tipoB_rbt.Text = "Tipo B";
            this.mostrar_tipoB_rbt.UseVisualStyleBackColor = true;
            // 
            // mostrar_tipoA_rbt
            // 
            this.mostrar_tipoA_rbt.AutoSize = true;
            this.mostrar_tipoA_rbt.Location = new System.Drawing.Point(22, 28);
            this.mostrar_tipoA_rbt.Name = "mostrar_tipoA_rbt";
            this.mostrar_tipoA_rbt.Size = new System.Drawing.Size(56, 17);
            this.mostrar_tipoA_rbt.TabIndex = 1;
            this.mostrar_tipoA_rbt.TabStop = true;
            this.mostrar_tipoA_rbt.Text = "Tipo A";
            this.mostrar_tipoA_rbt.UseVisualStyleBackColor = true;
            // 
            // mostrar_rdbt_btn
            // 
            this.mostrar_rdbt_btn.Location = new System.Drawing.Point(22, 131);
            this.mostrar_rdbt_btn.Name = "mostrar_rdbt_btn";
            this.mostrar_rdbt_btn.Size = new System.Drawing.Size(75, 23);
            this.mostrar_rdbt_btn.TabIndex = 0;
            this.mostrar_rdbt_btn.Text = "Mostrar";
            this.mostrar_rdbt_btn.UseVisualStyleBackColor = true;
            this.mostrar_rdbt_btn.Click += new System.EventHandler(this.mostrar_rdbt_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ocultar_todas_rbt);
            this.groupBox2.Controls.Add(this.ocultar_rdbt_btn);
            this.groupBox2.Controls.Add(this.ocultar_TipoC_rbt);
            this.groupBox2.Controls.Add(this.ocultar_TipoB_rbt);
            this.groupBox2.Controls.Add(this.ocultar_TipoA_rbt);
            this.groupBox2.Location = new System.Drawing.Point(383, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 175);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ocultar";
            // 
            // ocultar_todas_rbt
            // 
            this.ocultar_todas_rbt.AutoSize = true;
            this.ocultar_todas_rbt.Location = new System.Drawing.Point(16, 99);
            this.ocultar_todas_rbt.Name = "ocultar_todas_rbt";
            this.ocultar_todas_rbt.Size = new System.Drawing.Size(55, 17);
            this.ocultar_todas_rbt.TabIndex = 1;
            this.ocultar_todas_rbt.TabStop = true;
            this.ocultar_todas_rbt.Text = "Todas";
            this.ocultar_todas_rbt.UseVisualStyleBackColor = true;
            // 
            // ocultar_rdbt_btn
            // 
            this.ocultar_rdbt_btn.Location = new System.Drawing.Point(16, 131);
            this.ocultar_rdbt_btn.Name = "ocultar_rdbt_btn";
            this.ocultar_rdbt_btn.Size = new System.Drawing.Size(75, 23);
            this.ocultar_rdbt_btn.TabIndex = 0;
            this.ocultar_rdbt_btn.Text = "Ocultar";
            this.ocultar_rdbt_btn.UseVisualStyleBackColor = true;
            this.ocultar_rdbt_btn.Click += new System.EventHandler(this.ocultar_rdbt_btn_Click);
            // 
            // ocultar_TipoC_rbt
            // 
            this.ocultar_TipoC_rbt.AutoSize = true;
            this.ocultar_TipoC_rbt.Location = new System.Drawing.Point(16, 76);
            this.ocultar_TipoC_rbt.Name = "ocultar_TipoC_rbt";
            this.ocultar_TipoC_rbt.Size = new System.Drawing.Size(56, 17);
            this.ocultar_TipoC_rbt.TabIndex = 1;
            this.ocultar_TipoC_rbt.TabStop = true;
            this.ocultar_TipoC_rbt.Text = "Tipo C";
            this.ocultar_TipoC_rbt.UseVisualStyleBackColor = true;
            // 
            // ocultar_TipoB_rbt
            // 
            this.ocultar_TipoB_rbt.AutoSize = true;
            this.ocultar_TipoB_rbt.Location = new System.Drawing.Point(15, 53);
            this.ocultar_TipoB_rbt.Name = "ocultar_TipoB_rbt";
            this.ocultar_TipoB_rbt.Size = new System.Drawing.Size(56, 17);
            this.ocultar_TipoB_rbt.TabIndex = 1;
            this.ocultar_TipoB_rbt.TabStop = true;
            this.ocultar_TipoB_rbt.Text = "Tipo B";
            this.ocultar_TipoB_rbt.UseVisualStyleBackColor = true;
            // 
            // ocultar_TipoA_rbt
            // 
            this.ocultar_TipoA_rbt.AutoSize = true;
            this.ocultar_TipoA_rbt.Location = new System.Drawing.Point(16, 30);
            this.ocultar_TipoA_rbt.Name = "ocultar_TipoA_rbt";
            this.ocultar_TipoA_rbt.Size = new System.Drawing.Size(56, 17);
            this.ocultar_TipoA_rbt.TabIndex = 1;
            this.ocultar_TipoA_rbt.TabStop = true;
            this.ocultar_TipoA_rbt.Text = "Tipo A";
            this.ocultar_TipoA_rbt.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ventanas_ListBox);
            this.groupBox3.Controls.Add(this.cerrar_listBox_btn);
            this.groupBox3.Controls.Add(this.ocultar_listBox_btn);
            this.groupBox3.Controls.Add(this.mostrar_listBox_btn);
            this.groupBox3.Location = new System.Drawing.Point(625, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(347, 175);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ventanas hijas";
            // 
            // ventanas_ListBox
            // 
            this.ventanas_ListBox.FormattingEnabled = true;
            this.ventanas_ListBox.Location = new System.Drawing.Point(23, 28);
            this.ventanas_ListBox.Name = "ventanas_ListBox";
            this.ventanas_ListBox.Size = new System.Drawing.Size(303, 95);
            this.ventanas_ListBox.TabIndex = 1;
            // 
            // cerrar_listBox_btn
            // 
            this.cerrar_listBox_btn.Location = new System.Drawing.Point(168, 131);
            this.cerrar_listBox_btn.Name = "cerrar_listBox_btn";
            this.cerrar_listBox_btn.Size = new System.Drawing.Size(75, 23);
            this.cerrar_listBox_btn.TabIndex = 0;
            this.cerrar_listBox_btn.Text = "Cerrar";
            this.cerrar_listBox_btn.UseVisualStyleBackColor = true;
            this.cerrar_listBox_btn.Click += new System.EventHandler(this.cerrar_listBox_btn_Click);
            // 
            // ocultar_listBox_btn
            // 
            this.ocultar_listBox_btn.Location = new System.Drawing.Point(87, 131);
            this.ocultar_listBox_btn.Name = "ocultar_listBox_btn";
            this.ocultar_listBox_btn.Size = new System.Drawing.Size(75, 23);
            this.ocultar_listBox_btn.TabIndex = 0;
            this.ocultar_listBox_btn.Text = "Ocultar";
            this.ocultar_listBox_btn.UseVisualStyleBackColor = true;
            this.ocultar_listBox_btn.Click += new System.EventHandler(this.ocultar_listBox_btn_Click);
            // 
            // mostrar_listBox_btn
            // 
            this.mostrar_listBox_btn.Location = new System.Drawing.Point(6, 131);
            this.mostrar_listBox_btn.Name = "mostrar_listBox_btn";
            this.mostrar_listBox_btn.Size = new System.Drawing.Size(75, 23);
            this.mostrar_listBox_btn.TabIndex = 0;
            this.mostrar_listBox_btn.Text = "Mostar";
            this.mostrar_listBox_btn.UseVisualStyleBackColor = true;
            this.mostrar_listBox_btn.Click += new System.EventHandler(this.mostrar_listBox_btn_Click);
            // 
            // nhijos_info_lbl
            // 
            this.nhijos_info_lbl.AutoSize = true;
            this.nhijos_info_lbl.Location = new System.Drawing.Point(177, 222);
            this.nhijos_info_lbl.Name = "nhijos_info_lbl";
            this.nhijos_info_lbl.Size = new System.Drawing.Size(132, 13);
            this.nhijos_info_lbl.TabIndex = 2;
            this.nhijos_info_lbl.Text = "Número de hijos actuales: ";
            // 
            // numeroVentanas_Lbl
            // 
            this.numeroVentanas_Lbl.AutoSize = true;
            this.numeroVentanas_Lbl.Location = new System.Drawing.Point(315, 222);
            this.numeroVentanas_Lbl.Name = "numeroVentanas_Lbl";
            this.numeroVentanas_Lbl.Size = new System.Drawing.Size(0, 13);
            this.numeroVentanas_Lbl.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 256);
            this.Controls.Add(this.numeroVentanas_Lbl);
            this.Controls.Add(this.nhijos_info_lbl);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.hijaC_btn);
            this.Controls.Add(this.hijaB_btn);
            this.Controls.Add(this.hijaA_btn);
            this.Name = "Form1";
            this.Text = "Practica 06 JoseAngelDovalFraga SDI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hijaA_btn;
        private System.Windows.Forms.Button hijaB_btn;
        private System.Windows.Forms.Button hijaC_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton mostrar_todas_rbt;
        private System.Windows.Forms.RadioButton mostrar_tipoC_rbt;
        private System.Windows.Forms.RadioButton mostrar_tipoB_rbt;
        private System.Windows.Forms.RadioButton mostrar_tipoA_rbt;
        private System.Windows.Forms.Button mostrar_rdbt_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton ocultar_todas_rbt;
        private System.Windows.Forms.Button ocultar_rdbt_btn;
        private System.Windows.Forms.RadioButton ocultar_TipoC_rbt;
        private System.Windows.Forms.RadioButton ocultar_TipoB_rbt;
        private System.Windows.Forms.RadioButton ocultar_TipoA_rbt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox ventanas_ListBox;
        private System.Windows.Forms.Button cerrar_listBox_btn;
        private System.Windows.Forms.Button ocultar_listBox_btn;
        private System.Windows.Forms.Button mostrar_listBox_btn;
        private System.Windows.Forms.Label nhijos_info_lbl;
        private System.Windows.Forms.Label numeroVentanas_Lbl;
    }
}

