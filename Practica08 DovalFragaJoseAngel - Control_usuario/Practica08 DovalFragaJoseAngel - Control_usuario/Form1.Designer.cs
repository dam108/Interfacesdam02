namespace Practica08_DovalFragaJoseAngel___Control_usuario
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
            this.tablaPresiones_Lbl = new System.Windows.Forms.Label();
            this.presiones_DataGridView = new System.Windows.Forms.DataGridView();
            this.cargarPresions_Btn = new System.Windows.Forms.Button();
            this.presionesOptibas_Btn = new System.Windows.Forms.Button();
            this.volcarPresiones_Btn = new System.Windows.Forms.Button();
            this.presion_Control4 = new ControlesPractica08.presion_Control();
            this.presion_Control3 = new ControlesPractica08.presion_Control();
            this.presion_Control2 = new ControlesPractica08.presion_Control();
            this.presion_Control1 = new ControlesPractica08.presion_Control();
            ((System.ComponentModel.ISupportInitialize)(this.presiones_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaPresiones_Lbl
            // 
            this.tablaPresiones_Lbl.AutoSize = true;
            this.tablaPresiones_Lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaPresiones_Lbl.Location = new System.Drawing.Point(762, 249);
            this.tablaPresiones_Lbl.Name = "tablaPresiones_Lbl";
            this.tablaPresiones_Lbl.Size = new System.Drawing.Size(151, 21);
            this.tablaPresiones_Lbl.TabIndex = 4;
            this.tablaPresiones_Lbl.Text = "Tabla de Presiones";
            // 
            // presiones_DataGridView
            // 
            this.presiones_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.presiones_DataGridView.Location = new System.Drawing.Point(12, 285);
            this.presiones_DataGridView.Name = "presiones_DataGridView";
            this.presiones_DataGridView.Size = new System.Drawing.Size(1614, 153);
            this.presiones_DataGridView.TabIndex = 5;
            // 
            // cargarPresions_Btn
            // 
            this.cargarPresions_Btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargarPresions_Btn.Location = new System.Drawing.Point(133, 444);
            this.cargarPresions_Btn.Name = "cargarPresions_Btn";
            this.cargarPresions_Btn.Size = new System.Drawing.Size(278, 67);
            this.cargarPresions_Btn.TabIndex = 6;
            this.cargarPresions_Btn.Text = "Cargar archivo de presiones";
            this.cargarPresions_Btn.UseVisualStyleBackColor = true;
            this.cargarPresions_Btn.Click += new System.EventHandler(this.cargarPresions_Btn_Click);
            // 
            // presionesOptibas_Btn
            // 
            this.presionesOptibas_Btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presionesOptibas_Btn.Location = new System.Drawing.Point(694, 444);
            this.presionesOptibas_Btn.Name = "presionesOptibas_Btn";
            this.presionesOptibas_Btn.Size = new System.Drawing.Size(278, 67);
            this.presionesOptibas_Btn.TabIndex = 6;
            this.presionesOptibas_Btn.Text = "Poner presiones óptimas";
            this.presionesOptibas_Btn.UseVisualStyleBackColor = true;
            this.presionesOptibas_Btn.Click += new System.EventHandler(this.presionesOptibas_Btn_Click);
            // 
            // volcarPresiones_Btn
            // 
            this.volcarPresiones_Btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volcarPresiones_Btn.Location = new System.Drawing.Point(1227, 444);
            this.volcarPresiones_Btn.Name = "volcarPresiones_Btn";
            this.volcarPresiones_Btn.Size = new System.Drawing.Size(278, 67);
            this.volcarPresiones_Btn.TabIndex = 6;
            this.volcarPresiones_Btn.Text = "Volcar presiones actuales a un fichero";
            this.volcarPresiones_Btn.UseVisualStyleBackColor = true;
            this.volcarPresiones_Btn.Click += new System.EventHandler(this.volcarPresiones_Btn_Click);
            // 
            // presion_Control4
            // 
            this.presion_Control4.Ds = null;
            this.presion_Control4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presion_Control4.Location = new System.Drawing.Point(1227, 13);
            this.presion_Control4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.presion_Control4.Name = "presion_Control4";
            this.presion_Control4.Presion = "2.5";
            this.presion_Control4.Size = new System.Drawing.Size(399, 232);
            this.presion_Control4.TabIndex = 3;
            // 
            // presion_Control3
            // 
            this.presion_Control3.Ds = null;
            this.presion_Control3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presion_Control3.Location = new System.Drawing.Point(822, 13);
            this.presion_Control3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.presion_Control3.Name = "presion_Control3";
            this.presion_Control3.Presion = "2.5";
            this.presion_Control3.Size = new System.Drawing.Size(399, 232);
            this.presion_Control3.TabIndex = 2;
            // 
            // presion_Control2
            // 
            this.presion_Control2.Ds = null;
            this.presion_Control2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presion_Control2.Location = new System.Drawing.Point(417, 13);
            this.presion_Control2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.presion_Control2.Name = "presion_Control2";
            this.presion_Control2.Presion = "2.5";
            this.presion_Control2.Size = new System.Drawing.Size(399, 232);
            this.presion_Control2.TabIndex = 1;
            // 
            // presion_Control1
            // 
            this.presion_Control1.Ds = null;
            this.presion_Control1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presion_Control1.Location = new System.Drawing.Point(12, 13);
            this.presion_Control1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.presion_Control1.Name = "presion_Control1";
            this.presion_Control1.Presion = "2.5";
            this.presion_Control1.Size = new System.Drawing.Size(399, 232);
            this.presion_Control1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1638, 527);
            this.Controls.Add(this.volcarPresiones_Btn);
            this.Controls.Add(this.presionesOptibas_Btn);
            this.Controls.Add(this.cargarPresions_Btn);
            this.Controls.Add(this.presiones_DataGridView);
            this.Controls.Add(this.tablaPresiones_Lbl);
            this.Controls.Add(this.presion_Control4);
            this.Controls.Add(this.presion_Control3);
            this.Controls.Add(this.presion_Control2);
            this.Controls.Add(this.presion_Control1);
            this.Name = "Form1";
            this.Text = "Doval Fraga Jose Angel Practica08";
            ((System.ComponentModel.ISupportInitialize)(this.presiones_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlesPractica08.presion_Control presion_Control1;
        private ControlesPractica08.presion_Control presion_Control2;
        private ControlesPractica08.presion_Control presion_Control3;
        private ControlesPractica08.presion_Control presion_Control4;
        private System.Windows.Forms.Label tablaPresiones_Lbl;
        private System.Windows.Forms.DataGridView presiones_DataGridView;
        private System.Windows.Forms.Button cargarPresions_Btn;
        private System.Windows.Forms.Button presionesOptibas_Btn;
        private System.Windows.Forms.Button volcarPresiones_Btn;
    }
}

