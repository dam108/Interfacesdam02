
namespace Practica07_DovalFragaJoseAngel_MDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscaPalabrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encriptaGIFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizaVideosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ventanasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.ventanasToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1117, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscaPalabrasToolStripMenuItem,
            this.encriptaGIFToolStripMenuItem,
            this.organizaVideosToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // buscaPalabrasToolStripMenuItem
            // 
            this.buscaPalabrasToolStripMenuItem.Name = "buscaPalabrasToolStripMenuItem";
            this.buscaPalabrasToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.buscaPalabrasToolStripMenuItem.Text = "Busca Palabras";
            this.buscaPalabrasToolStripMenuItem.Click += new System.EventHandler(this.buscaPalabrasToolStripMenuItem_Click);
            // 
            // encriptaGIFToolStripMenuItem
            // 
            this.encriptaGIFToolStripMenuItem.Name = "encriptaGIFToolStripMenuItem";
            this.encriptaGIFToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.encriptaGIFToolStripMenuItem.Text = "Encripta GIF";
            this.encriptaGIFToolStripMenuItem.Click += new System.EventHandler(this.encriptaGIFToolStripMenuItem_Click);
            // 
            // organizaVideosToolStripMenuItem
            // 
            this.organizaVideosToolStripMenuItem.Name = "organizaVideosToolStripMenuItem";
            this.organizaVideosToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.organizaVideosToolStripMenuItem.Text = "Organiza Videos";
            this.organizaVideosToolStripMenuItem.Click += new System.EventHandler(this.organizaVideosToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(156, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ventanasToolStripMenuItem
            // 
            this.ventanasToolStripMenuItem.Name = "ventanasToolStripMenuItem";
            this.ventanasToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.ventanasToolStripMenuItem.Text = "Ventanas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 626);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Practica06 Doval Fraga, Jose Angel  MDI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscaPalabrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encriptaGIFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizaVideosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventanasToolStripMenuItem;
    }
}

