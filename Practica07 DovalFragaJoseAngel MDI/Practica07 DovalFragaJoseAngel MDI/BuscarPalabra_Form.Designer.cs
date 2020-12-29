
namespace Practica07_DovalFragaJoseAngel_MDI
{
    partial class BuscarPalabra_Form
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
            this.mostrarTexto_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.menuContextualRichTextBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.abrirArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.palabraBuscar_TextBox = new System.Windows.Forms.TextBox();
            this.buscar_Btn = new System.Windows.Forms.Button();
            this.mostrarLineas_ListBox = new System.Windows.Forms.ListBox();
            this.menuContextualListBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.borrarLineaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarLineaAOtroArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuContextualRichTextBox.SuspendLayout();
            this.menuContextualListBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(560, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Palabra a Buscar";
            // 
            // mostrarTexto_RichTextBox
            // 
            this.mostrarTexto_RichTextBox.ContextMenuStrip = this.menuContextualRichTextBox;
            this.mostrarTexto_RichTextBox.Location = new System.Drawing.Point(13, 14);
            this.mostrarTexto_RichTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mostrarTexto_RichTextBox.Name = "mostrarTexto_RichTextBox";
            this.mostrarTexto_RichTextBox.Size = new System.Drawing.Size(489, 483);
            this.mostrarTexto_RichTextBox.TabIndex = 2;
            this.mostrarTexto_RichTextBox.Text = "";
            // 
            // menuContextualRichTextBox
            // 
            this.menuContextualRichTextBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirArchivoToolStripMenuItem});
            this.menuContextualRichTextBox.Name = "menuContextualRichTextBox";
            this.menuContextualRichTextBox.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuContextualRichTextBox.Size = new System.Drawing.Size(145, 26);
            this.menuContextualRichTextBox.Text = "Abrir Archivo";
            // 
            // abrirArchivoToolStripMenuItem
            // 
            this.abrirArchivoToolStripMenuItem.Name = "abrirArchivoToolStripMenuItem";
            this.abrirArchivoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.abrirArchivoToolStripMenuItem.Text = "Abrir Archivo";
            this.abrirArchivoToolStripMenuItem.Click += new System.EventHandler(this.abrirArchivoToolStripMenuItem_Click);
            // 
            // palabraBuscar_TextBox
            // 
            this.palabraBuscar_TextBox.Location = new System.Drawing.Point(697, 69);
            this.palabraBuscar_TextBox.Name = "palabraBuscar_TextBox";
            this.palabraBuscar_TextBox.Size = new System.Drawing.Size(175, 26);
            this.palabraBuscar_TextBox.TabIndex = 4;
            this.palabraBuscar_TextBox.TextChanged += new System.EventHandler(this.palabraBuscar_TextBox_TextChanged);
            // 
            // buscar_Btn
            // 
            this.buscar_Btn.Location = new System.Drawing.Point(776, 115);
            this.buscar_Btn.Name = "buscar_Btn";
            this.buscar_Btn.Size = new System.Drawing.Size(96, 34);
            this.buscar_Btn.TabIndex = 5;
            this.buscar_Btn.Text = "Buscar";
            this.buscar_Btn.UseVisualStyleBackColor = true;
            this.buscar_Btn.Click += new System.EventHandler(this.buscar_Btn_Click);
            // 
            // mostrarLineas_ListBox
            // 
            this.mostrarLineas_ListBox.ContextMenuStrip = this.menuContextualListBox;
            this.mostrarLineas_ListBox.FormattingEnabled = true;
            this.mostrarLineas_ListBox.ItemHeight = 20;
            this.mostrarLineas_ListBox.Location = new System.Drawing.Point(534, 155);
            this.mostrarLineas_ListBox.Name = "mostrarLineas_ListBox";
            this.mostrarLineas_ListBox.Size = new System.Drawing.Size(338, 344);
            this.mostrarLineas_ListBox.TabIndex = 7;
            // 
            // menuContextualListBox
            // 
            this.menuContextualListBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrarLineaToolStripMenuItem,
            this.copiarLineaAOtroArchivoToolStripMenuItem});
            this.menuContextualListBox.Name = "menuContextualListBox";
            this.menuContextualListBox.Size = new System.Drawing.Size(212, 70);
            // 
            // borrarLineaToolStripMenuItem
            // 
            this.borrarLineaToolStripMenuItem.Name = "borrarLineaToolStripMenuItem";
            this.borrarLineaToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.borrarLineaToolStripMenuItem.Text = "Borrar linea";
            this.borrarLineaToolStripMenuItem.Click += new System.EventHandler(this.borrarLineaToolStripMenuItem_Click);
            // 
            // copiarLineaAOtroArchivoToolStripMenuItem
            // 
            this.copiarLineaAOtroArchivoToolStripMenuItem.Name = "copiarLineaAOtroArchivoToolStripMenuItem";
            this.copiarLineaAOtroArchivoToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.copiarLineaAOtroArchivoToolStripMenuItem.Text = "copiar linea a otro archivo";
            this.copiarLineaAOtroArchivoToolStripMenuItem.Click += new System.EventHandler(this.copiarLineaAOtroArchivoToolStripMenuItem_Click);
            // 
            // BuscarPalabra_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.mostrarLineas_ListBox);
            this.Controls.Add(this.buscar_Btn);
            this.Controls.Add(this.palabraBuscar_TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mostrarTexto_RichTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BuscarPalabra_Form";
            this.Text = "Buscador de Palabras";
            this.menuContextualRichTextBox.ResumeLayout(false);
            this.menuContextualListBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox mostrarTexto_RichTextBox;
        private System.Windows.Forms.TextBox palabraBuscar_TextBox;
        private System.Windows.Forms.Button buscar_Btn;
        private System.Windows.Forms.ContextMenuStrip menuContextualRichTextBox;
        private System.Windows.Forms.ToolStripMenuItem abrirArchivoToolStripMenuItem;
        private System.Windows.Forms.ListBox mostrarLineas_ListBox;
        private System.Windows.Forms.ContextMenuStrip menuContextualListBox;
        private System.Windows.Forms.ToolStripMenuItem borrarLineaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarLineaAOtroArchivoToolStripMenuItem;
    }
}