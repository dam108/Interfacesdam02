namespace Practica02_Extra_Doval_Fraga_Jose_Angel
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
            this.insertarGroupBox = new System.Windows.Forms.GroupBox();
            this.añadirButton = new System.Windows.Forms.Button();
            this.altoTextBox = new System.Windows.Forms.TextBox();
            this.anchoTextBox = new System.Windows.Forms.TextBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.altoLabel = new System.Windows.Forms.Label();
            this.cmLabel2 = new System.Windows.Forms.Label();
            this.cmLabel = new System.Windows.Forms.Label();
            this.anchoLabel = new System.Windows.Forms.Label();
            this.colorLabel = new System.Windows.Forms.Label();
            this.modeloLabel = new System.Windows.Forms.Label();
            this.salidaGroupBox = new System.Windows.Forms.GroupBox();
            this.eliminarTodasButton = new System.Windows.Forms.Button();
            this.alfombraEliminarButton = new System.Windows.Forms.Button();
            this.alfombraInfoButton = new System.Windows.Forms.Button();
            this.alfombrasComboBox = new System.Windows.Forms.ComboBox();
            this.advertenciaLabel = new System.Windows.Forms.Label();
            this.alfombrasPictureBox = new System.Windows.Forms.PictureBox();
            this.insertarGroupBox.SuspendLayout();
            this.salidaGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alfombrasPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // insertarGroupBox
            // 
            this.insertarGroupBox.Controls.Add(this.añadirButton);
            this.insertarGroupBox.Controls.Add(this.altoTextBox);
            this.insertarGroupBox.Controls.Add(this.anchoTextBox);
            this.insertarGroupBox.Controls.Add(this.colorTextBox);
            this.insertarGroupBox.Controls.Add(this.modelTextBox);
            this.insertarGroupBox.Controls.Add(this.altoLabel);
            this.insertarGroupBox.Controls.Add(this.cmLabel2);
            this.insertarGroupBox.Controls.Add(this.cmLabel);
            this.insertarGroupBox.Controls.Add(this.anchoLabel);
            this.insertarGroupBox.Controls.Add(this.colorLabel);
            this.insertarGroupBox.Controls.Add(this.modeloLabel);
            this.insertarGroupBox.Location = new System.Drawing.Point(13, 14);
            this.insertarGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.insertarGroupBox.Name = "insertarGroupBox";
            this.insertarGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.insertarGroupBox.Size = new System.Drawing.Size(995, 162);
            this.insertarGroupBox.TabIndex = 1;
            this.insertarGroupBox.TabStop = false;
            this.insertarGroupBox.Text = "Nova alfombra";
            // 
            // añadirButton
            // 
            this.añadirButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.añadirButton.Location = new System.Drawing.Point(759, 41);
            this.añadirButton.Name = "añadirButton";
            this.añadirButton.Size = new System.Drawing.Size(203, 28);
            this.añadirButton.TabIndex = 5;
            this.añadirButton.Text = "Engadir";
            this.añadirButton.UseVisualStyleBackColor = true;
            this.añadirButton.Click += new System.EventHandler(this.AñadirButton_Click);
            // 
            // altoTextBox
            // 
            this.altoTextBox.Location = new System.Drawing.Point(591, 92);
            this.altoTextBox.Name = "altoTextBox";
            this.altoTextBox.Size = new System.Drawing.Size(88, 29);
            this.altoTextBox.TabIndex = 4;
            this.altoTextBox.Enter += new System.EventHandler(this.AltoTextBox_Enter);
            this.altoTextBox.Leave += new System.EventHandler(this.AltoTextBox_Leave);
            // 
            // anchoTextBox
            // 
            this.anchoTextBox.Location = new System.Drawing.Point(379, 92);
            this.anchoTextBox.Name = "anchoTextBox";
            this.anchoTextBox.Size = new System.Drawing.Size(88, 29);
            this.anchoTextBox.TabIndex = 3;
            this.anchoTextBox.Enter += new System.EventHandler(this.AnchoTextBox_Enter);
            this.anchoTextBox.Leave += new System.EventHandler(this.AnchoTextBox_Leave);
            // 
            // colorTextBox
            // 
            this.colorTextBox.Location = new System.Drawing.Point(130, 92);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(150, 29);
            this.colorTextBox.TabIndex = 2;
            this.colorTextBox.Enter += new System.EventHandler(this.ColorTextBox_Enter);
            this.colorTextBox.Leave += new System.EventHandler(this.ColorTextBox_Leave);
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(130, 41);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(596, 29);
            this.modelTextBox.TabIndex = 1;
            this.modelTextBox.Enter += new System.EventHandler(this.ModeloTextBox_Enter);
            this.modelTextBox.Leave += new System.EventHandler(this.ModeloTextBox_Leave);
            // 
            // altoLabel
            // 
            this.altoLabel.AutoSize = true;
            this.altoLabel.Location = new System.Drawing.Point(547, 100);
            this.altoLabel.Name = "altoLabel";
            this.altoLabel.Size = new System.Drawing.Size(38, 21);
            this.altoLabel.TabIndex = 0;
            this.altoLabel.Text = "Alto";
            // 
            // cmLabel2
            // 
            this.cmLabel2.AutoSize = true;
            this.cmLabel2.Location = new System.Drawing.Point(685, 100);
            this.cmLabel2.Name = "cmLabel2";
            this.cmLabel2.Size = new System.Drawing.Size(41, 21);
            this.cmLabel2.TabIndex = 1;
            this.cmLabel2.Text = "(cm)";
            // 
            // cmLabel
            // 
            this.cmLabel.AutoSize = true;
            this.cmLabel.Location = new System.Drawing.Point(473, 100);
            this.cmLabel.Name = "cmLabel";
            this.cmLabel.Size = new System.Drawing.Size(41, 21);
            this.cmLabel.TabIndex = 0;
            this.cmLabel.Text = "(cm)";
            // 
            // anchoLabel
            // 
            this.anchoLabel.AutoSize = true;
            this.anchoLabel.Location = new System.Drawing.Point(319, 100);
            this.anchoLabel.Name = "anchoLabel";
            this.anchoLabel.Size = new System.Drawing.Size(54, 21);
            this.anchoLabel.TabIndex = 0;
            this.anchoLabel.Text = "Ancho";
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(28, 100);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(35, 21);
            this.colorLabel.TabIndex = 0;
            this.colorLabel.Text = "Cor";
            // 
            // modeloLabel
            // 
            this.modeloLabel.AutoSize = true;
            this.modeloLabel.Location = new System.Drawing.Point(28, 44);
            this.modeloLabel.Name = "modeloLabel";
            this.modeloLabel.Size = new System.Drawing.Size(63, 21);
            this.modeloLabel.TabIndex = 0;
            this.modeloLabel.Text = "Modelo";
            // 
            // salidaGroupBox
            // 
            this.salidaGroupBox.Controls.Add(this.eliminarTodasButton);
            this.salidaGroupBox.Controls.Add(this.alfombraEliminarButton);
            this.salidaGroupBox.Controls.Add(this.alfombraInfoButton);
            this.salidaGroupBox.Controls.Add(this.alfombrasComboBox);
            this.salidaGroupBox.Location = new System.Drawing.Point(13, 255);
            this.salidaGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.salidaGroupBox.Name = "salidaGroupBox";
            this.salidaGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.salidaGroupBox.Size = new System.Drawing.Size(995, 162);
            this.salidaGroupBox.TabIndex = 2;
            this.salidaGroupBox.TabStop = false;
            this.salidaGroupBox.Text = "Alfombras dipoñibles";
            // 
            // eliminarTodasButton
            // 
            this.eliminarTodasButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarTodasButton.Location = new System.Drawing.Point(588, 99);
            this.eliminarTodasButton.Name = "eliminarTodasButton";
            this.eliminarTodasButton.Size = new System.Drawing.Size(374, 28);
            this.eliminarTodasButton.TabIndex = 3;
            this.eliminarTodasButton.Text = "Eliminar todas";
            this.eliminarTodasButton.UseVisualStyleBackColor = true;
            this.eliminarTodasButton.Click += new System.EventHandler(this.EliminarTodasButtons_Click);
            // 
            // alfombraEliminarButton
            // 
            this.alfombraEliminarButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alfombraEliminarButton.Location = new System.Drawing.Point(379, 99);
            this.alfombraEliminarButton.Name = "alfombraEliminarButton";
            this.alfombraEliminarButton.Size = new System.Drawing.Size(203, 28);
            this.alfombraEliminarButton.TabIndex = 2;
            this.alfombraEliminarButton.Text = "Eliminar alfombra";
            this.alfombraEliminarButton.UseVisualStyleBackColor = true;
            this.alfombraEliminarButton.Click += new System.EventHandler(this.EliminarAlfombraButton_Click);
            // 
            // alfombraInfoButton
            // 
            this.alfombraInfoButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alfombraInfoButton.Location = new System.Drawing.Point(32, 99);
            this.alfombraInfoButton.Name = "alfombraInfoButton";
            this.alfombraInfoButton.Size = new System.Drawing.Size(341, 28);
            this.alfombraInfoButton.TabIndex = 1;
            this.alfombraInfoButton.Text = "Información da alfombra";
            this.alfombraInfoButton.UseVisualStyleBackColor = true;
            this.alfombraInfoButton.Click += new System.EventHandler(this.AlfombraInfoButton_Click);
            // 
            // alfombrasComboBox
            // 
            this.alfombrasComboBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alfombrasComboBox.FormattingEnabled = true;
            this.alfombrasComboBox.Location = new System.Drawing.Point(32, 46);
            this.alfombrasComboBox.Name = "alfombrasComboBox";
            this.alfombrasComboBox.Size = new System.Drawing.Size(930, 25);
            this.alfombrasComboBox.TabIndex = 0;
            // 
            // advertenciaLabel
            // 
            this.advertenciaLabel.Location = new System.Drawing.Point(13, 205);
            this.advertenciaLabel.Name = "advertenciaLabel";
            this.advertenciaLabel.Size = new System.Drawing.Size(995, 25);
            this.advertenciaLabel.TabIndex = 1;
            this.advertenciaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alfombrasPictureBox
            // 
            this.alfombrasPictureBox.Location = new System.Drawing.Point(347, 425);
            this.alfombrasPictureBox.Name = "alfombrasPictureBox";
            this.alfombrasPictureBox.Size = new System.Drawing.Size(345, 236);
            this.alfombrasPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alfombrasPictureBox.TabIndex = 3;
            this.alfombrasPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 674);
            this.Controls.Add(this.alfombrasPictureBox);
            this.Controls.Add(this.advertenciaLabel);
            this.Controls.Add(this.salidaGroupBox);
            this.Controls.Add(this.insertarGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Alfombras Doval Fraga Jose Angel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.insertarGroupBox.ResumeLayout(false);
            this.insertarGroupBox.PerformLayout();
            this.salidaGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.alfombrasPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox insertarGroupBox;
        private System.Windows.Forms.GroupBox salidaGroupBox;
        private System.Windows.Forms.TextBox anchoTextBox;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.Label altoLabel;
        private System.Windows.Forms.Label cmLabel2;
        private System.Windows.Forms.Label cmLabel;
        private System.Windows.Forms.Label anchoLabel;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Label modeloLabel;
        private System.Windows.Forms.TextBox altoTextBox;
        private System.Windows.Forms.Button añadirButton;
        private System.Windows.Forms.Button alfombraInfoButton;
        private System.Windows.Forms.ComboBox alfombrasComboBox;
        private System.Windows.Forms.Button eliminarTodasButton;
        private System.Windows.Forms.Button alfombraEliminarButton;
        private System.Windows.Forms.Label advertenciaLabel;
        private System.Windows.Forms.PictureBox alfombrasPictureBox;
    }
}

