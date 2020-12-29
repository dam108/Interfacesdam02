
namespace Practica09_DovalFragaJoseAngel___Acceso_a_Datos
{
    partial class EliminarFiesta
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
            this.eliminarFiesta_ComboBox = new System.Windows.Forms.ComboBox();
            this.eliminarFiesta_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fiestas: ";
            // 
            // eliminarFiesta_ComboBox
            // 
            this.eliminarFiesta_ComboBox.FormattingEnabled = true;
            this.eliminarFiesta_ComboBox.Location = new System.Drawing.Point(65, 32);
            this.eliminarFiesta_ComboBox.Name = "eliminarFiesta_ComboBox";
            this.eliminarFiesta_ComboBox.Size = new System.Drawing.Size(513, 21);
            this.eliminarFiesta_ComboBox.TabIndex = 0;
            // 
            // eliminarFiesta_Btn
            // 
            this.eliminarFiesta_Btn.Location = new System.Drawing.Point(596, 29);
            this.eliminarFiesta_Btn.Name = "eliminarFiesta_Btn";
            this.eliminarFiesta_Btn.Size = new System.Drawing.Size(114, 23);
            this.eliminarFiesta_Btn.TabIndex = 1;
            this.eliminarFiesta_Btn.Text = "Eliminar";
            this.eliminarFiesta_Btn.UseVisualStyleBackColor = true;
            this.eliminarFiesta_Btn.Click += new System.EventHandler(this.eliminarFiesta_Btn_Click);
            // 
            // EliminarFiesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 79);
            this.Controls.Add(this.eliminarFiesta_Btn);
            this.Controls.Add(this.eliminarFiesta_ComboBox);
            this.Controls.Add(this.label1);
            this.Name = "EliminarFiesta";
            this.Text = "EliminarFiesta";
            this.Activated += new System.EventHandler(this.EliminarFiesta_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EliminarFiesta_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox eliminarFiesta_ComboBox;
        private System.Windows.Forms.Button eliminarFiesta_Btn;
    }
}