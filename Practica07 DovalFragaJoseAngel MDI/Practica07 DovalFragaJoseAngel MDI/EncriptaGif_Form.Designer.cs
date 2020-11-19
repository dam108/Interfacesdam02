
namespace Practica07_DovalFragaJoseAngel_MDI
{
    partial class EncriptaGif_Form
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
            this.gif_Picturebox = new System.Windows.Forms.PictureBox();
            this.gif_ListBox = new System.Windows.Forms.ListBox();
            this.EncriptarGif_Btn = new System.Windows.Forms.Button();
            this.encriptarCarpeta_Btn = new System.Windows.Forms.Button();
            this.desenciptar_Btn = new System.Windows.Forms.Button();
            this.mostrar_Btn = new System.Windows.Forms.Button();
            this.barraDeProgreso = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.finalEncriptar_Lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gif_Picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // gif_Picturebox
            // 
            this.gif_Picturebox.Location = new System.Drawing.Point(20, 20);
            this.gif_Picturebox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gif_Picturebox.Name = "gif_Picturebox";
            this.gif_Picturebox.Size = new System.Drawing.Size(432, 456);
            this.gif_Picturebox.TabIndex = 0;
            this.gif_Picturebox.TabStop = false;
            // 
            // gif_ListBox
            // 
            this.gif_ListBox.FormattingEnabled = true;
            this.gif_ListBox.ItemHeight = 20;
            this.gif_ListBox.Location = new System.Drawing.Point(460, 20);
            this.gif_ListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gif_ListBox.Name = "gif_ListBox";
            this.gif_ListBox.Size = new System.Drawing.Size(304, 304);
            this.gif_ListBox.TabIndex = 1;
            this.gif_ListBox.SelectedValueChanged += new System.EventHandler(this.gif_ListBox_SelectedValueChanged);
            // 
            // EncriptarGif_Btn
            // 
            this.EncriptarGif_Btn.BackColor = System.Drawing.Color.Red;
            this.EncriptarGif_Btn.Location = new System.Drawing.Point(772, 20);
            this.EncriptarGif_Btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EncriptarGif_Btn.Name = "EncriptarGif_Btn";
            this.EncriptarGif_Btn.Size = new System.Drawing.Size(245, 55);
            this.EncriptarGif_Btn.TabIndex = 2;
            this.EncriptarGif_Btn.Text = "Encriptar Archivo GIF";
            this.EncriptarGif_Btn.UseVisualStyleBackColor = false;
            this.EncriptarGif_Btn.Click += new System.EventHandler(this.EncriptarGif_Btn_Click);
            // 
            // encriptarCarpeta_Btn
            // 
            this.encriptarCarpeta_Btn.BackColor = System.Drawing.Color.Red;
            this.encriptarCarpeta_Btn.Location = new System.Drawing.Point(772, 85);
            this.encriptarCarpeta_Btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.encriptarCarpeta_Btn.Name = "encriptarCarpeta_Btn";
            this.encriptarCarpeta_Btn.Size = new System.Drawing.Size(245, 55);
            this.encriptarCarpeta_Btn.TabIndex = 2;
            this.encriptarCarpeta_Btn.Text = "Encriptar Carpeta con GIF";
            this.encriptarCarpeta_Btn.UseVisualStyleBackColor = false;
            this.encriptarCarpeta_Btn.Click += new System.EventHandler(this.encriptarCarpeta_Btn_Click);
            // 
            // desenciptar_Btn
            // 
            this.desenciptar_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.desenciptar_Btn.Location = new System.Drawing.Point(772, 150);
            this.desenciptar_Btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.desenciptar_Btn.Name = "desenciptar_Btn";
            this.desenciptar_Btn.Size = new System.Drawing.Size(245, 57);
            this.desenciptar_Btn.TabIndex = 2;
            this.desenciptar_Btn.Text = "Desencriptar";
            this.desenciptar_Btn.UseVisualStyleBackColor = false;
            this.desenciptar_Btn.Click += new System.EventHandler(this.desenciptar_Btn_Click);
            // 
            // mostrar_Btn
            // 
            this.mostrar_Btn.Location = new System.Drawing.Point(772, 217);
            this.mostrar_Btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mostrar_Btn.Name = "mostrar_Btn";
            this.mostrar_Btn.Size = new System.Drawing.Size(245, 107);
            this.mostrar_Btn.TabIndex = 2;
            this.mostrar_Btn.Text = "Mostrar";
            this.mostrar_Btn.UseVisualStyleBackColor = true;
            this.mostrar_Btn.Click += new System.EventHandler(this.mostrar_Btn_Click);
            // 
            // barraDeProgreso
            // 
            this.barraDeProgreso.Location = new System.Drawing.Point(457, 420);
            this.barraDeProgreso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barraDeProgreso.Name = "barraDeProgreso";
            this.barraDeProgreso.Size = new System.Drawing.Size(560, 56);
            this.barraDeProgreso.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(460, 390);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Progreso de la encriptación";
            // 
            // finalEncriptar_Lbl
            // 
            this.finalEncriptar_Lbl.AutoSize = true;
            this.finalEncriptar_Lbl.Location = new System.Drawing.Point(844, 390);
            this.finalEncriptar_Lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.finalEncriptar_Lbl.Name = "finalEncriptar_Lbl";
            this.finalEncriptar_Lbl.Size = new System.Drawing.Size(173, 20);
            this.finalEncriptar_Lbl.TabIndex = 4;
            this.finalEncriptar_Lbl.Text = "Encriptacion Finalizada";
            this.finalEncriptar_Lbl.Visible = false;
            // 
            // EncriptaGif_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 490);
            this.Controls.Add(this.finalEncriptar_Lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barraDeProgreso);
            this.Controls.Add(this.mostrar_Btn);
            this.Controls.Add(this.desenciptar_Btn);
            this.Controls.Add(this.encriptarCarpeta_Btn);
            this.Controls.Add(this.EncriptarGif_Btn);
            this.Controls.Add(this.gif_ListBox);
            this.Controls.Add(this.gif_Picturebox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EncriptaGif_Form";
            this.Text = "Encriptador de GIFs";
            ((System.ComponentModel.ISupportInitialize)(this.gif_Picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox gif_Picturebox;
        private System.Windows.Forms.ListBox gif_ListBox;
        private System.Windows.Forms.Button EncriptarGif_Btn;
        private System.Windows.Forms.Button encriptarCarpeta_Btn;
        private System.Windows.Forms.Button desenciptar_Btn;
        private System.Windows.Forms.Button mostrar_Btn;
        private System.Windows.Forms.ProgressBar barraDeProgreso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label finalEncriptar_Lbl;
    }
}