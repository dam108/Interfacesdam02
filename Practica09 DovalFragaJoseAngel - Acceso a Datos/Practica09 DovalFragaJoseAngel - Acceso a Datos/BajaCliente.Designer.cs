﻿
namespace Practica09_DovalFragaJoseAngel___Acceso_a_Datos
{
    partial class BajaCliente
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
            this.clientesComboBox = new System.Windows.Forms.ComboBox();
            this.eliminar_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clientes";
            // 
            // clientesComboBox
            // 
            this.clientesComboBox.FormattingEnabled = true;
            this.clientesComboBox.Location = new System.Drawing.Point(122, 23);
            this.clientesComboBox.Name = "clientesComboBox";
            this.clientesComboBox.Size = new System.Drawing.Size(432, 21);
            this.clientesComboBox.TabIndex = 0;
            // 
            // eliminar_Btn
            // 
            this.eliminar_Btn.Location = new System.Drawing.Point(580, 21);
            this.eliminar_Btn.Name = "eliminar_Btn";
            this.eliminar_Btn.Size = new System.Drawing.Size(96, 23);
            this.eliminar_Btn.TabIndex = 1;
            this.eliminar_Btn.Text = "Eliminar";
            this.eliminar_Btn.UseVisualStyleBackColor = true;
            this.eliminar_Btn.Click += new System.EventHandler(this.eliminar_Btn_Click);
            // 
            // BajaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 83);
            this.Controls.Add(this.eliminar_Btn);
            this.Controls.Add(this.clientesComboBox);
            this.Controls.Add(this.label1);
            this.Name = "BajaCliente";
            this.Text = "Eliminar Cliente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BajaCliente_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox clientesComboBox;
        private System.Windows.Forms.Button eliminar_Btn;
    }
}