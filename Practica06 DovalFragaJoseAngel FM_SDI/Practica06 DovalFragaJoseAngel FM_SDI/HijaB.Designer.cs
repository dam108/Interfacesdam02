namespace Practica06_DovalFragaJoseAngel_FM_SDI
{
    partial class HijaB
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
            this.tipoB_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tipoB_lbl
            // 
            this.tipoB_lbl.AutoSize = true;
            this.tipoB_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoB_lbl.Location = new System.Drawing.Point(141, 88);
            this.tipoB_lbl.Name = "tipoB_lbl";
            this.tipoB_lbl.Size = new System.Drawing.Size(185, 25);
            this.tipoB_lbl.TabIndex = 0;
            this.tipoB_lbl.Text = "VENTANA TIPO B";
            // 
            // HijaB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 215);
            this.Controls.Add(this.tipoB_lbl);
            this.Name = "HijaB";
            this.Text = "HijaB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tipoB_lbl;
    }
}