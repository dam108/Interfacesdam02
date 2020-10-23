namespace Practica03_Extra_DovalFragaJA_ListaTlf
{
    partial class Formulario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario));
            this.contactosListBox = new System.Windows.Forms.ListBox();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.nombreLbl = new System.Windows.Forms.Label();
            this.telefonoLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.fotoLbl = new System.Windows.Forms.Label();
            this.advertenciaLbl = new System.Windows.Forms.Label();
            this.listaNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.modificarButton = new System.Windows.Forms.ToolStripButton();
            this.anadirButton = new System.Windows.Forms.ToolStripButton();
            this.NuevoButton = new System.Windows.Forms.ToolStripButton();
            this.eliminarButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaNavigator)).BeginInit();
            this.listaNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // contactosListBox
            // 
            this.contactosListBox.FormattingEnabled = true;
            this.contactosListBox.ItemHeight = 21;
            this.contactosListBox.Location = new System.Drawing.Point(17, 282);
            this.contactosListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.contactosListBox.Name = "contactosListBox";
            this.contactosListBox.Size = new System.Drawing.Size(301, 235);
            this.contactosListBox.TabIndex = 3;
            this.contactosListBox.SelectedIndexChanged += new System.EventHandler(this.contactosListBox_SelectedIndexChanged);
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.Image = global::Practica03_Extra_DovalFragaJA_ListaTlf.Properties.Resources.FotoLimpiar;
            this.fotoPictureBox.Location = new System.Drawing.Point(375, 30);
            this.fotoPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(150, 152);
            this.fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoPictureBox.TabIndex = 1;
            this.fotoPictureBox.TabStop = false;
            this.fotoPictureBox.Click += new System.EventHandler(this.fotoPictureBox_Click);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(106, 61);
            this.nombreTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(212, 29);
            this.nombreTextBox.TabIndex = 0;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.Location = new System.Drawing.Point(106, 91);
            this.telefonoTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(212, 29);
            this.telefonoTextBox.TabIndex = 1;
            this.telefonoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telefonoTextBox_KeyPress);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(106, 122);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(212, 29);
            this.emailTextBox.TabIndex = 2;
            // 
            // nombreLbl
            // 
            this.nombreLbl.AutoSize = true;
            this.nombreLbl.Location = new System.Drawing.Point(13, 64);
            this.nombreLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nombreLbl.Name = "nombreLbl";
            this.nombreLbl.Size = new System.Drawing.Size(71, 21);
            this.nombreLbl.TabIndex = 0;
            this.nombreLbl.Text = "Nombre:";
            // 
            // telefonoLbl
            // 
            this.telefonoLbl.AutoSize = true;
            this.telefonoLbl.Location = new System.Drawing.Point(13, 94);
            this.telefonoLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.telefonoLbl.Name = "telefonoLbl";
            this.telefonoLbl.Size = new System.Drawing.Size(71, 21);
            this.telefonoLbl.TabIndex = 0;
            this.telefonoLbl.Text = "Teléfono:";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(13, 125);
            this.emailLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(51, 21);
            this.emailLbl.TabIndex = 0;
            this.emailLbl.Text = "Email:";
            // 
            // fotoLbl
            // 
            this.fotoLbl.AutoSize = true;
            this.fotoLbl.Location = new System.Drawing.Point(430, 187);
            this.fotoLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fotoLbl.Name = "fotoLbl";
            this.fotoLbl.Size = new System.Drawing.Size(41, 21);
            this.fotoLbl.TabIndex = 0;
            this.fotoLbl.Text = "Foto";
            // 
            // advertenciaLbl
            // 
            this.advertenciaLbl.Location = new System.Drawing.Point(13, 533);
            this.advertenciaLbl.Name = "advertenciaLbl";
            this.advertenciaLbl.Size = new System.Drawing.Size(539, 31);
            this.advertenciaLbl.TabIndex = 0;
            this.advertenciaLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.advertenciaLbl.Visible = false;
            // 
            // listaNavigator
            // 
            this.listaNavigator.AddNewItem = null;
            this.listaNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaNavigator.DeleteItem = null;
            this.listaNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.NuevoButton,
            this.modificarButton,
            this.eliminarButton,
            this.anadirButton});
            this.listaNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaNavigator.Name = "listaNavigator";
            this.listaNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaNavigator.Size = new System.Drawing.Size(565, 25);
            this.listaNavigator.TabIndex = 8;
            this.listaNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // modificarButton
            // 
            this.modificarButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.modificarButton.Image = ((System.Drawing.Image)(resources.GetObject("modificarButton.Image")));
            this.modificarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.modificarButton.Name = "modificarButton";
            this.modificarButton.Size = new System.Drawing.Size(62, 22);
            this.modificarButton.Text = "Modificar";
            this.modificarButton.Click += new System.EventHandler(this.modificarButton_Click);
            // 
            // anadirButton
            // 
            this.anadirButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.anadirButton.Image = ((System.Drawing.Image)(resources.GetObject("anadirButton.Image")));
            this.anadirButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.anadirButton.Name = "anadirButton";
            this.anadirButton.Size = new System.Drawing.Size(46, 22);
            this.anadirButton.Text = "Añadir";
            this.anadirButton.Click += new System.EventHandler(this.anadirButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.NuevoButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoButton.Image")));
            this.NuevoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(46, 22);
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // eliminarButton
            // 
            this.eliminarButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.eliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("eliminarButton.Image")));
            this.eliminarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(54, 22);
            this.eliminarButton.Text = "Eliminar";
            this.eliminarButton.Click += new System.EventHandler(this.eliminarButton_Click);
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 573);
            this.Controls.Add(this.listaNavigator);
            this.Controls.Add(this.advertenciaLbl);
            this.Controls.Add(this.fotoLbl);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.telefonoLbl);
            this.Controls.Add(this.nombreLbl);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.fotoPictureBox);
            this.Controls.Add(this.contactosListBox);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Formulario";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Practica 3 Doval Fraga Jose Angel";
            this.Load += new System.EventHandler(this.Formulario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaNavigator)).EndInit();
            this.listaNavigator.ResumeLayout(false);
            this.listaNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox contactosListBox;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label nombreLbl;
        private System.Windows.Forms.Label telefonoLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label fotoLbl;
        private System.Windows.Forms.Label advertenciaLbl;
        private System.Windows.Forms.BindingNavigator listaNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton modificarButton;
        private System.Windows.Forms.ToolStripButton anadirButton;
        private System.Windows.Forms.ToolStripButton NuevoButton;
        private System.Windows.Forms.ToolStripButton eliminarButton;
    }
}

