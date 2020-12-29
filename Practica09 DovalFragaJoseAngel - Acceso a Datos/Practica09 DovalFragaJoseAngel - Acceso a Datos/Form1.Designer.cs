
namespace Practica09_DovalFragaJoseAngel___Acceso_a_Datos
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
            this.reservasDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fiestasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaFiestasMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaFiestasMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaClientesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaClientesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.reservasDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reservasDataGridView
            // 
            this.reservasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reservasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservasDataGridView.Location = new System.Drawing.Point(12, 27);
            this.reservasDataGridView.Name = "reservasDataGridView";
            this.reservasDataGridView.Size = new System.Drawing.Size(776, 165);
            this.reservasDataGridView.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fiestasToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.gestionToolStripMenuItem.Text = "Gestion";
            // 
            // fiestasToolStripMenuItem
            // 
            this.fiestasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaFiestasMenuItem,
            this.bajaFiestasMenuItem});
            this.fiestasToolStripMenuItem.Name = "fiestasToolStripMenuItem";
            this.fiestasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fiestasToolStripMenuItem.Text = "Fiestas";
            // 
            // altaFiestasMenuItem
            // 
            this.altaFiestasMenuItem.Name = "altaFiestasMenuItem";
            this.altaFiestasMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altaFiestasMenuItem.Text = "Alta";
            this.altaFiestasMenuItem.Click += new System.EventHandler(this.altaFiestasMenuItem_Click);
            // 
            // bajaFiestasMenuItem
            // 
            this.bajaFiestasMenuItem.Name = "bajaFiestasMenuItem";
            this.bajaFiestasMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bajaFiestasMenuItem.Text = "Baja";
            this.bajaFiestasMenuItem.Click += new System.EventHandler(this.bajaFiestasMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaClientesMenuItem,
            this.bajaClientesMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // altaClientesMenuItem
            // 
            this.altaClientesMenuItem.Name = "altaClientesMenuItem";
            this.altaClientesMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altaClientesMenuItem.Text = "Alta";
            this.altaClientesMenuItem.Click += new System.EventHandler(this.altaClientesMenuItem_Click);
            // 
            // bajaClientesMenuItem
            // 
            this.bajaClientesMenuItem.Name = "bajaClientesMenuItem";
            this.bajaClientesMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bajaClientesMenuItem.Text = "Baja";
            this.bajaClientesMenuItem.Click += new System.EventHandler(this.bajaClientesMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 203);
            this.Controls.Add(this.reservasDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Doval Fraga Jose Angel, Practica09";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.reservasDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView reservasDataGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fiestasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaFiestasMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaFiestasMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaClientesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaClientesMenuItem;
    }
}

