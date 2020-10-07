using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica01_Doval_Fraga__Jose_Angel
{
    public partial class Form1 : Form
    {
        ficha_persona[] personas;
        public int n = 0;
        public int indextStructGlobal;

        public Form1()
        {
            InitializeComponent();
            personas = new ficha_persona[10];
            textBox_radioBtn_Otra.Enabled = false;
        }

        public struct ficha_persona
        {
            public string dni, nombre, apellido1, apellido2, strTitulacionMax_otra;
            public bool permisoA, permisoB, permisoC, permisoD,
                permisoE, hombre, mujer, titulacionMax_none,
                titulacionMax_eso, titulacionMax_bach, titulacionMax_fp,
                titulacionMax_Uni, titulacionMax_otra;
            public int indexStruct;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool datosOk = comprobaciones();

            if (existeDni(textBox_DNI.Text))
            {
                MessageBox.Show("Este dni ya esta guardado, intruduzca uno diferente"); textBox_DNI.Clear();
                datosOk = false;
            }
            if (datosOk) 
            {
                bool guardar = guardarDatosEnArray();
                if (guardar)
                {
                    avisoOkGuardar();
                    limpiar();
                }
                else
                {
                    limpiar();
                }
            }
            else
            {
                avisoFailGuardar();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(textBox_Buscar.Text != "")
            {
                if (existeDni(textBox_Buscar.Text))
                {
                    rellenarFormulario(textBox_Buscar.Text);
                }
                else
                {
                    MessageBox.Show("Este dni no se encuentra guardado aun!");
                }
            }
            else
            {
                MessageBox.Show("Introduzca dni para buscar");
            }
        }

        private void rellenarFormulario(String dni)
        {
            limpiar();
            int n = indextStructGlobal;
            textBox_DNI.Text = personas[n].dni;
            textBox_Nombre.Text = personas[n].nombre;
            textBox_Apellido1.Text = personas[n].apellido1;
            textBox_Apellido2.Text = personas[n].apellido2;
            if (personas[n].permisoA) checkedListBox_persmiso.SetItemChecked(0, true);
            if (personas[n].permisoB) checkedListBox_persmiso.SetItemChecked(1, true);
            if (personas[n].permisoC) checkedListBox_persmiso.SetItemChecked(2, true);
            if (personas[n].permisoD) checkedListBox_persmiso.SetItemChecked(3, true);
            if (personas[n].permisoE) checkedListBox_persmiso.SetItemChecked(4, true);
            if (personas[n].hombre) radioButton_Hombre.Checked = true;
            if (personas[n].mujer) radioButton_Mujer.Checked = true;
            if (personas[n].titulacionMax_none) radioButton_Ninguna.Checked = true;
            if (personas[n].titulacionMax_eso) radioButton_ESO.Checked = true;
            if (personas[n].titulacionMax_bach) radioButton_Bach.Checked = true;
            if (personas[n].titulacionMax_fp) radioButton_FP.Checked = true;
            if (personas[n].titulacionMax_Uni) radioButton_Universitaria.Checked = true;
            if (personas[n].titulacionMax_otra)
            {
                radioButton_Otra.Checked = true;
                textBox_radioBtn_Otra.Text = personas[n].strTitulacionMax_otra;
            }

        }

        private bool existeDni(String dni)
        {
            foreach (var i in personas)
            {
                if(dni == i.dni) {
                    indextStructGlobal = i.indexStruct;
                    return true; 
                }
            }
            return false;
        }

        private void avisoOkGuardar()
        {
            MessageBox.Show("Se han guardado todos los campos!");
        }

        private void limpiar()
        {
            textBox_DNI.Clear(); 
            textBox_Nombre.Clear();
            textBox_Apellido1.Clear();
            textBox_Apellido2.Clear();
            for (int i = 0; i < checkedListBox_persmiso.Items.Count; i++)
            {
                checkedListBox_persmiso.SetItemChecked(i, false);
            }

            radioButton_Hombre.Checked = false;
            radioButton_Mujer.Checked = false;
            radioButton_Ninguna.Checked = false;
            radioButton_ESO.Checked = false;
            radioButton_Bach.Checked = false;
            radioButton_FP.Checked = false;
            radioButton_Universitaria.Checked = false;
            radioButton_Otra.Checked = false;
            textBox_radioBtn_Otra.Clear();
        }

        private void avisoFailGuardar()
        {
            MessageBox.Show("Es necesario cubrir todos los campos!"); 
        }

        private bool comprobaciones()
        {

            if (textBox_DNI.Text != "" & textBox_Nombre.Text != "" & textBox_Apellido1.Text != "" & textBox_Apellido2.Text != ""
                & checkedListBox_persmiso.SelectedIndex != -1 & (radioButton_Hombre.Checked == true | radioButton_Mujer.Checked == true) &
                (radioButton_Ninguna.Checked == true | radioButton_ESO.Checked == true | radioButton_Bach.Checked == true | radioButton_FP.Checked == true
            |   radioButton_Universitaria.Checked == true | (radioButton_Otra.Checked == true & textBox_radioBtn_Otra.Text != "")))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private bool guardarDatosEnArray()
        {
            if (n >=0 & n < 10)
            {
                personas[n].indexStruct = n;
                personas[n].dni = textBox_DNI.Text;
                personas[n].nombre = textBox_Nombre.Text;
                personas[n].apellido1 = textBox_Apellido1.Text;
                personas[n].apellido2 = textBox_Apellido2.Text;

                if (checkedListBox_persmiso.GetItemChecked(0)) { personas[n].permisoA = true; }
                if (checkedListBox_persmiso.GetItemChecked(1)) { personas[n].permisoB = true; }
                if (checkedListBox_persmiso.GetItemChecked(2)) { personas[n].permisoC = true; }
                if (checkedListBox_persmiso.GetItemChecked(3)) { personas[n].permisoD = true; }
                if (checkedListBox_persmiso.GetItemChecked(4)) { personas[n].permisoE = true; }

                personas[n].hombre = radioButton_Hombre.Checked;
                personas[n].mujer = radioButton_Mujer.Checked;

                personas[n].titulacionMax_none = radioButton_Ninguna.Checked;
                personas[n].titulacionMax_eso = radioButton_ESO.Checked;
                personas[n].titulacionMax_bach = radioButton_Bach.Checked;
                personas[n].titulacionMax_fp = radioButton_FP.Checked;
                personas[n].titulacionMax_Uni = radioButton_Universitaria.Checked;
                personas[n].titulacionMax_otra = radioButton_Otra.Checked;
                personas[n].strTitulacionMax_otra = textBox_radioBtn_Otra.Text;

                n++;
                return true;
            }
            else
            {
                MessageBox.Show("No se pueden guardar mas registros!");
                return false;
            }
        }

        private void radioButton_Otra_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Otra.Checked) { textBox_radioBtn_Otra.Enabled = true; }
            else
            {
                textBox_radioBtn_Otra.Enabled = false;
                textBox_radioBtn_Otra.Clear();
            }
        }
    }
}
