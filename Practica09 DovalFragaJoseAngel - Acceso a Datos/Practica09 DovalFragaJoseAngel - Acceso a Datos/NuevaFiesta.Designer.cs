
namespace Practica09_DovalFragaJoseAngel___Acceso_a_Datos
{
    partial class NuevaFiesta
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.fecha_DatePicker = new System.Windows.Forms.DateTimePicker();
            this.comensales_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.cancelar_Btn = new System.Windows.Forms.Button();
            this.clientes_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sala_Lbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guardar_Btn = new System.Windows.Forms.Button();
            this.elegirSala_Lbl = new System.Windows.Forms.Label();
            this.sala_ContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.amarillaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.violetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.comensales_NumericUpDown)).BeginInit();
            this.sala_ContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha de celebración:";
            // 
            // fecha_DatePicker
            // 
            this.fecha_DatePicker.Location = new System.Drawing.Point(183, 20);
            this.fecha_DatePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fecha_DatePicker.Name = "fecha_DatePicker";
            this.fecha_DatePicker.Size = new System.Drawing.Size(552, 29);
            this.fecha_DatePicker.TabIndex = 0;
            // 
            // comensales_NumericUpDown
            // 
            this.comensales_NumericUpDown.Location = new System.Drawing.Point(339, 65);
            this.comensales_NumericUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comensales_NumericUpDown.Name = "comensales_NumericUpDown";
            this.comensales_NumericUpDown.Size = new System.Drawing.Size(52, 29);
            this.comensales_NumericUpDown.TabIndex = 2;
            // 
            // cancelar_Btn
            // 
            this.cancelar_Btn.Location = new System.Drawing.Point(403, 127);
            this.cancelar_Btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelar_Btn.Name = "cancelar_Btn";
            this.cancelar_Btn.Size = new System.Drawing.Size(112, 37);
            this.cancelar_Btn.TabIndex = 5;
            this.cancelar_Btn.Text = "Cancelar";
            this.cancelar_Btn.UseVisualStyleBackColor = true;
            this.cancelar_Btn.Click += new System.EventHandler(this.cancelar_Btn_Click);
            // 
            // clientes_comboBox
            // 
            this.clientes_comboBox.FormattingEnabled = true;
            this.clientes_comboBox.Location = new System.Drawing.Point(473, 63);
            this.clientes_comboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clientes_comboBox.Name = "clientes_comboBox";
            this.clientes_comboBox.Size = new System.Drawing.Size(262, 29);
            this.clientes_comboBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cliente";
            // 
            // sala_Lbl
            // 
            this.sala_Lbl.AutoSize = true;
            this.sala_Lbl.Location = new System.Drawing.Point(18, 67);
            this.sala_Lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sala_Lbl.Name = "sala_Lbl";
            this.sala_Lbl.Size = new System.Drawing.Size(39, 21);
            this.sala_Lbl.TabIndex = 0;
            this.sala_Lbl.Text = "Sala";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Comensales";
            // 
            // guardar_Btn
            // 
            this.guardar_Btn.Location = new System.Drawing.Point(253, 127);
            this.guardar_Btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guardar_Btn.Name = "guardar_Btn";
            this.guardar_Btn.Size = new System.Drawing.Size(112, 37);
            this.guardar_Btn.TabIndex = 4;
            this.guardar_Btn.Text = "Guardar";
            this.guardar_Btn.UseVisualStyleBackColor = true;
            this.guardar_Btn.Click += new System.EventHandler(this.guardar_Btn_Click);
            // 
            // elegirSala_Lbl
            // 
            this.elegirSala_Lbl.AutoSize = true;
            this.elegirSala_Lbl.ContextMenuStrip = this.sala_ContextMenu;
            this.elegirSala_Lbl.Location = new System.Drawing.Point(64, 67);
            this.elegirSala_Lbl.Name = "elegirSala_Lbl";
            this.elegirSala_Lbl.Size = new System.Drawing.Size(0, 21);
            this.elegirSala_Lbl.TabIndex = 1;
            // 
            // sala_ContextMenu
            // 
            this.sala_ContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.amarillaToolStripMenuItem,
            this.violetaToolStripMenuItem});
            this.sala_ContextMenu.Name = "sala_ContextMenu";
            this.sala_ContextMenu.Size = new System.Drawing.Size(132, 48);
            // 
            // amarillaToolStripMenuItem
            // 
            this.amarillaToolStripMenuItem.Name = "amarillaToolStripMenuItem";
            this.amarillaToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.amarillaToolStripMenuItem.Text = "AMARILLA";
            this.amarillaToolStripMenuItem.Click += new System.EventHandler(this.amarillaToolStripMenuItem_Click);
            // 
            // violetaToolStripMenuItem
            // 
            this.violetaToolStripMenuItem.Name = "violetaToolStripMenuItem";
            this.violetaToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.violetaToolStripMenuItem.Text = "VIOLETA";
            this.violetaToolStripMenuItem.Click += new System.EventHandler(this.violetaToolStripMenuItem_Click);
            // 
            // NuevaFiesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 198);
            this.Controls.Add(this.elegirSala_Lbl);
            this.Controls.Add(this.clientes_comboBox);
            this.Controls.Add(this.guardar_Btn);
            this.Controls.Add(this.cancelar_Btn);
            this.Controls.Add(this.comensales_NumericUpDown);
            this.Controls.Add(this.fecha_DatePicker);
            this.Controls.Add(this.sala_Lbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NuevaFiesta";
            this.Text = "Nueva Fiesta";
            this.Activated += new System.EventHandler(this.NuevaFiesta_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NuevaFiesta_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.comensales_NumericUpDown)).EndInit();
            this.sala_ContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fecha_DatePicker;
        private System.Windows.Forms.NumericUpDown comensales_NumericUpDown;
        private System.Windows.Forms.Button cancelar_Btn;
        private System.Windows.Forms.ComboBox clientes_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sala_Lbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button guardar_Btn;
        private System.Windows.Forms.Label elegirSala_Lbl;
        private System.Windows.Forms.ContextMenuStrip sala_ContextMenu;
        private System.Windows.Forms.ToolStripMenuItem amarillaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem violetaToolStripMenuItem;
    }
}