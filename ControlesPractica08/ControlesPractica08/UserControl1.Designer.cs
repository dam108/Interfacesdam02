namespace ControlesPractica08
{
    partial class presion_Control
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

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.presion_panel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.presion_progressBar = new System.Windows.Forms.ProgressBar();
            this.presion_TextBox = new System.Windows.Forms.TextBox();
            this.mas_Btn = new System.Windows.Forms.Button();
            this.menos_Btn = new System.Windows.Forms.Button();
            this.rueda_Lbl = new System.Windows.Forms.Label();
            this.presion_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // presion_panel
            // 
            this.presion_panel.Controls.Add(this.label3);
            this.presion_panel.Controls.Add(this.label2);
            this.presion_panel.Controls.Add(this.presion_progressBar);
            this.presion_panel.Controls.Add(this.presion_TextBox);
            this.presion_panel.Controls.Add(this.mas_Btn);
            this.presion_panel.Controls.Add(this.menos_Btn);
            this.presion_panel.Controls.Add(this.rueda_Lbl);
            this.presion_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.presion_panel.Location = new System.Drawing.Point(0, 0);
            this.presion_panel.Name = "presion_panel";
            this.presion_panel.Size = new System.Drawing.Size(399, 232);
            this.presion_panel.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "4 Bar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "0 Bar";
            // 
            // presion_progressBar
            // 
            this.presion_progressBar.Location = new System.Drawing.Point(5, 157);
            this.presion_progressBar.Name = "presion_progressBar";
            this.presion_progressBar.Size = new System.Drawing.Size(389, 46);
            this.presion_progressBar.TabIndex = 11;
            // 
            // presion_TextBox
            // 
            this.presion_TextBox.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presion_TextBox.Location = new System.Drawing.Point(131, 49);
            this.presion_TextBox.Multiline = true;
            this.presion_TextBox.Name = "presion_TextBox";
            this.presion_TextBox.ReadOnly = true;
            this.presion_TextBox.Size = new System.Drawing.Size(137, 100);
            this.presion_TextBox.TabIndex = 10;
            this.presion_TextBox.Text = "2.5";
            this.presion_TextBox.TextChanged += new System.EventHandler(this.presion_TextBox_TextChanged);
            // 
            // mas_Btn
            // 
            this.mas_Btn.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mas_Btn.Location = new System.Drawing.Point(274, 49);
            this.mas_Btn.Name = "mas_Btn";
            this.mas_Btn.Size = new System.Drawing.Size(120, 102);
            this.mas_Btn.TabIndex = 8;
            this.mas_Btn.Text = "+";
            this.mas_Btn.UseVisualStyleBackColor = true;
            this.mas_Btn.Click += new System.EventHandler(this.mas_Btn_Click);
            // 
            // menos_Btn
            // 
            this.menos_Btn.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menos_Btn.Location = new System.Drawing.Point(5, 49);
            this.menos_Btn.Name = "menos_Btn";
            this.menos_Btn.Size = new System.Drawing.Size(120, 102);
            this.menos_Btn.TabIndex = 9;
            this.menos_Btn.Text = "-";
            this.menos_Btn.UseVisualStyleBackColor = true;
            this.menos_Btn.Click += new System.EventHandler(this.menos_Btn_Click);
            // 
            // rueda_Lbl
            // 
            this.rueda_Lbl.AutoSize = true;
            this.rueda_Lbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rueda_Lbl.Location = new System.Drawing.Point(129, 10);
            this.rueda_Lbl.Name = "rueda_Lbl";
            this.rueda_Lbl.Size = new System.Drawing.Size(72, 30);
            this.rueda_Lbl.TabIndex = 7;
            this.rueda_Lbl.Text = "Rueda";
            // 
            // presion_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.presion_panel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "presion_Control";
            this.Size = new System.Drawing.Size(399, 232);
            this.presion_panel.ResumeLayout(false);
            this.presion_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel presion_panel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar presion_progressBar;
        private System.Windows.Forms.TextBox presion_TextBox;
        private System.Windows.Forms.Button mas_Btn;
        private System.Windows.Forms.Button menos_Btn;
        private System.Windows.Forms.Label rueda_Lbl;
    }
}
