
namespace Practica07_DovalFragaJoseAngel_MDI
{
    partial class OrganizaVideos_Form
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
            this.label2 = new System.Windows.Forms.Label();
            this.rutaCarpeta_Lbl = new System.Windows.Forms.Label();
            this.seleccionar_Btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.fecha_DataPicker = new System.Windows.Forms.DateTimePicker();
            this.organizar_Btn = new System.Windows.Forms.Button();
            this.carpetas_TreeView = new System.Windows.Forms.TreeView();
            this.videos_ListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carpetas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Videos Carpeta Seleccionada";
            // 
            // rutaCarpeta_Lbl
            // 
            this.rutaCarpeta_Lbl.AutoSize = true;
            this.rutaCarpeta_Lbl.Location = new System.Drawing.Point(523, 156);
            this.rutaCarpeta_Lbl.Name = "rutaCarpeta_Lbl";
            this.rutaCarpeta_Lbl.Size = new System.Drawing.Size(0, 20);
            this.rutaCarpeta_Lbl.TabIndex = 2;
            this.rutaCarpeta_Lbl.Visible = false;
            // 
            // seleccionar_Btn
            // 
            this.seleccionar_Btn.Location = new System.Drawing.Point(523, 32);
            this.seleccionar_Btn.Name = "seleccionar_Btn";
            this.seleccionar_Btn.Size = new System.Drawing.Size(280, 63);
            this.seleccionar_Btn.TabIndex = 3;
            this.seleccionar_Btn.Text = "Seleccionar Carpeta";
            this.seleccionar_Btn.UseVisualStyleBackColor = true;
            this.seleccionar_Btn.Click += new System.EventHandler(this.seleccionar_Btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(523, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Carpeta Seleccionada";
            // 
            // fecha_DataPicker
            // 
            this.fecha_DataPicker.Location = new System.Drawing.Point(523, 251);
            this.fecha_DataPicker.Name = "fecha_DataPicker";
            this.fecha_DataPicker.Size = new System.Drawing.Size(280, 26);
            this.fecha_DataPicker.TabIndex = 5;
            // 
            // organizar_Btn
            // 
            this.organizar_Btn.Location = new System.Drawing.Point(523, 407);
            this.organizar_Btn.Name = "organizar_Btn";
            this.organizar_Btn.Size = new System.Drawing.Size(280, 49);
            this.organizar_Btn.TabIndex = 6;
            this.organizar_Btn.Text = "Organiza";
            this.organizar_Btn.UseVisualStyleBackColor = true;
            // 
            // carpetas_TreeView
            // 
            this.carpetas_TreeView.Location = new System.Drawing.Point(12, 32);
            this.carpetas_TreeView.Name = "carpetas_TreeView";
            this.carpetas_TreeView.Size = new System.Drawing.Size(273, 424);
            this.carpetas_TreeView.TabIndex = 7;
            // 
            // videos_ListBox
            // 
            this.videos_ListBox.FormattingEnabled = true;
            this.videos_ListBox.ItemHeight = 20;
            this.videos_ListBox.Location = new System.Drawing.Point(291, 32);
            this.videos_ListBox.Name = "videos_ListBox";
            this.videos_ListBox.Size = new System.Drawing.Size(226, 424);
            this.videos_ListBox.TabIndex = 8;
            // 
            // OrganizaVideos_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 472);
            this.Controls.Add(this.videos_ListBox);
            this.Controls.Add(this.carpetas_TreeView);
            this.Controls.Add(this.organizar_Btn);
            this.Controls.Add(this.fecha_DataPicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.seleccionar_Btn);
            this.Controls.Add(this.rutaCarpeta_Lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OrganizaVideos_Form";
            this.Text = "Organizador de Videos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label rutaCarpeta_Lbl;
        private System.Windows.Forms.Button seleccionar_Btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker fecha_DataPicker;
        private System.Windows.Forms.Button organizar_Btn;
        private System.Windows.Forms.TreeView carpetas_TreeView;
        private System.Windows.Forms.ListBox videos_ListBox;
    }
}