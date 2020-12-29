
namespace Practica09_DovalFragaJoseAngel___Acceso_a_Datos
{
    partial class AltaCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dni_TxtBox = new System.Windows.Forms.TextBox();
            this.guardar_Btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nombre_TxtBox = new System.Windows.Forms.TextBox();
            this.apellido1_TxtBox = new System.Windows.Forms.TextBox();
            this.apellido2_TxtBox = new System.Windows.Forms.TextBox();
            this.telefono_TxtBox = new System.Windows.Forms.TextBox();
            this.cancelar_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI";
            // 
            // dni_TxtBox
            // 
            this.dni_TxtBox.Location = new System.Drawing.Point(76, 10);
            this.dni_TxtBox.Name = "dni_TxtBox";
            this.dni_TxtBox.Size = new System.Drawing.Size(306, 20);
            this.dni_TxtBox.TabIndex = 0;
            // 
            // guardar_Btn
            // 
            this.guardar_Btn.Location = new System.Drawing.Point(109, 198);
            this.guardar_Btn.Name = "guardar_Btn";
            this.guardar_Btn.Size = new System.Drawing.Size(75, 23);
            this.guardar_Btn.TabIndex = 5;
            this.guardar_Btn.Text = "Guardar";
            this.guardar_Btn.UseVisualStyleBackColor = true;
            this.guardar_Btn.Click += new System.EventHandler(this.guardar_Btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Apellido 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Apellido 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tlf.";
            // 
            // nombre_TxtBox
            // 
            this.nombre_TxtBox.Location = new System.Drawing.Point(76, 45);
            this.nombre_TxtBox.Name = "nombre_TxtBox";
            this.nombre_TxtBox.Size = new System.Drawing.Size(306, 20);
            this.nombre_TxtBox.TabIndex = 1;
            // 
            // apellido1_TxtBox
            // 
            this.apellido1_TxtBox.Location = new System.Drawing.Point(76, 79);
            this.apellido1_TxtBox.Name = "apellido1_TxtBox";
            this.apellido1_TxtBox.Size = new System.Drawing.Size(306, 20);
            this.apellido1_TxtBox.TabIndex = 2;
            // 
            // apellido2_TxtBox
            // 
            this.apellido2_TxtBox.Location = new System.Drawing.Point(76, 116);
            this.apellido2_TxtBox.Name = "apellido2_TxtBox";
            this.apellido2_TxtBox.Size = new System.Drawing.Size(306, 20);
            this.apellido2_TxtBox.TabIndex = 3;
            // 
            // telefono_TxtBox
            // 
            this.telefono_TxtBox.Location = new System.Drawing.Point(76, 154);
            this.telefono_TxtBox.Name = "telefono_TxtBox";
            this.telefono_TxtBox.Size = new System.Drawing.Size(306, 20);
            this.telefono_TxtBox.TabIndex = 4;
            // 
            // cancelar_Btn
            // 
            this.cancelar_Btn.Location = new System.Drawing.Point(256, 198);
            this.cancelar_Btn.Name = "cancelar_Btn";
            this.cancelar_Btn.Size = new System.Drawing.Size(75, 23);
            this.cancelar_Btn.TabIndex = 6;
            this.cancelar_Btn.Text = "Cancelar";
            this.cancelar_Btn.UseVisualStyleBackColor = true;
            this.cancelar_Btn.Click += new System.EventHandler(this.cancelar_Btn_Click);
            // 
            // AltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 242);
            this.Controls.Add(this.cancelar_Btn);
            this.Controls.Add(this.guardar_Btn);
            this.Controls.Add(this.telefono_TxtBox);
            this.Controls.Add(this.apellido2_TxtBox);
            this.Controls.Add(this.apellido1_TxtBox);
            this.Controls.Add(this.nombre_TxtBox);
            this.Controls.Add(this.dni_TxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AltaCliente";
            this.Text = "Nuevo Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dni_TxtBox;
        private System.Windows.Forms.Button guardar_Btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nombre_TxtBox;
        private System.Windows.Forms.TextBox apellido1_TxtBox;
        private System.Windows.Forms.TextBox apellido2_TxtBox;
        private System.Windows.Forms.TextBox telefono_TxtBox;
        private System.Windows.Forms.Button cancelar_Btn;
    }
}