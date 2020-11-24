using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica08_DovalFragaJoseAngel___Control_usuario
{
    public partial class Form1 : Form
    {
        public FileInfo presionesXML;
        public DataSet ds;

        public Form1()
        {
            InitializeComponent();
            presionesXML = new FileInfo(@"..\..\1111AAA.xml");
            ds = new DataSet();

            presion_Control1.Enabled = false;
            presion_Control2.Enabled = false;
            presion_Control3.Enabled = false;
            presion_Control4.Enabled = false;
        }

        private void cargarPresions_Btn_Click(object sender, EventArgs e)
        {
            ds.Clear();

            try
            {
                ds.ReadXml(presionesXML.FullName);
                presiones_DataGridView.ReadOnly = true;
                presiones_DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                presiones_DataGridView.DataSource = ds;
                presiones_DataGridView.DataMember = "neumatico";

                tablaPresiones_Lbl.Text = "Tabla de Presiones " + Path.GetFileNameWithoutExtension(presionesXML.Name);


                for (int i = 0; i < 4; i++)
                {
                    if (i == 0)
                    {
                        presion_Control1.Ds = ds;
                        presion_Control1.Enabled = true;
                        presion_Control1.cambiarEtiqueta(i);
                        presion_Control1.cambiarPresion(i, 0);
                    }
                    if (i == 1)
                    {
                        presion_Control2.Ds = ds;
                        presion_Control2.Enabled = true;
                        presion_Control2.cambiarEtiqueta(i);
                        presion_Control2.cambiarPresion(i, 0);
                    }
                    if (i == 2) 
                    {
                        presion_Control3.Ds = ds;
                        presion_Control3.Enabled = true;
                        presion_Control3.cambiarEtiqueta(i);
                        presion_Control3.cambiarPresion(i, 0);
                    }
                    if (i == 3) 
                    {
                        presion_Control4.Ds = ds;
                        presion_Control4.Enabled = true;
                        presion_Control4.cambiarEtiqueta(i);
                        presion_Control4.cambiarPresion(i, 0);
                    }
                }

            } catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void presionesOptibas_Btn_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 4; i++)
            {
                if (i == 0)
                {
                    presion_Control1.cambiarPresion(i, 1);
                }
                if (i == 1)
                {
                    presion_Control2.cambiarPresion(i, 1);
                }
                if (i == 2)
                {
                    presion_Control3.cambiarPresion(i, 1);
                }
                if (i == 3)
                {
                    presion_Control4.cambiarPresion(i, 1);
                }
            }
        }

        private void volcarPresiones_Btn_Click(object sender, EventArgs e)
        {
            volcarDatosADataGrid();
            ds.WriteXml(presionesXML.FullName);
            MessageBox.Show("Se han guardado los datos correctamente en el XML");
        }

        private void volcarDatosADataGrid()
        {
            presiones_DataGridView.Rows[0].Cells[1].Value = presion_Control1.Presion.Replace(".",",");
            presiones_DataGridView.Rows[1].Cells[1].Value = presion_Control2.Presion.Replace(".", ",");
            presiones_DataGridView.Rows[2].Cells[1].Value = presion_Control3.Presion.Replace(".", ",");
            presiones_DataGridView.Rows[3].Cells[1].Value = presion_Control4.Presion.Replace(".", ",");
        }
    }
}
