namespace Practica06_DovalFragaJoseAngel_FM_SDI
{
    partial class HijaC
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
            this.tipoC_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tipoC_lbl
            // 
            this.tipoC_lbl.AutoSize = true;
            this.tipoC_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoC_lbl.Location = new System.Drawing.Point(141, 88);
            this.tipoC_lbl.Name = "tipoC_lbl";
            this.tipoC_lbl.Size = new System.Drawing.Size(185, 25);
            this.tipoC_lbl.TabIndex = 0;
            this.tipoC_lbl.Text = "VENTANA TIPO C";
            // 
            // HijaC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 215);
            this.Controls.Add(this.tipoC_lbl);
            this.Name = "HijaC";
            this.Text = "HijaC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tipoC_lbl;
    }
}