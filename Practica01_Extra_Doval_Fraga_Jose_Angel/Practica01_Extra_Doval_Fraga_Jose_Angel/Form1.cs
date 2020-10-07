using System;
using System.Drawing;
using System.Windows.Forms;

namespace Practica01_Doval_Fraga__Jose_Angel
{
    public partial class Form1 : Form
    {
        ficha_persona[] personas;
        public int n = 0;
        public int indextStructGlobal;
        public bool cajavalidada = true;
        public bool structLleno = false;
        public bool dndGuardado = false;
        public bool cambioDniDespuesBucar = false;

        public Form1()
        {
            InitializeComponent();
            personas = new ficha_persona[10];
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
                dndGuardado = true;
                textBox_DNI.Clear();
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
                    if (structLleno)
                    {
                        limpiar();
                        lbl_advertencia.Visible = true;
                        lbl_advertencia.BackColor = Color.Red;
                        lbl_advertencia.Text = "No se puede guardar mas datos!";
                    }
                    else limpiar();
                }
            }
            else
            {
                avisoFailGuardar();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            textBox_Buscar.Focus();
            if (textBox_Buscar.Text != "" & comprobarDni(textBox_Buscar.Text))
            {
                if (existeDni(textBox_Buscar.Text))
                {
                    rellenarFormulario(textBox_Buscar.Text);
                }
                else
                {
                    lbl_advertencia.Visible = true;
                    lbl_advertencia.BackColor = Color.Red;
                    lbl_advertencia.Text = "Este dni no se encuentra guardado aun!";
                }
            }
            else
            {
                lbl_advertencia.Visible = true;
                lbl_advertencia.BackColor = Color.Red;
                lbl_advertencia.Text = "Introduzca dni para buscar (formato: 12345678A) ";
                textBox_Buscar.Focus();
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
                if (dni == i.dni)
                {
                    indextStructGlobal = i.indexStruct;
                    return true;
                }
            }
            return false;
        }

        private bool comprobarDni(string dni)
        {
            if (dni.Length == 9)
            {
                String strnumeros = dni.Substring(0, 8);

                for (int i = 0; i < strnumeros.Length; i++)
                {
                    char a = strnumeros[i];
                    if (!char.IsDigit(a)) return false;
                }
                string letra = dni.Substring(8);
                int numeros = Int32.Parse(strnumeros);
                if (!Char.IsLetter(letra[0]) | Char.ToLower(letra[0]) != calcularLetraDni(numeros)) return false;
                else return true;
            }
            else
            {
                return false;
            }
        }

        private char calcularLetraDni(int n)
        {
            String minusculas = "trwagmyfpdxbnjzsqvhlcke";
            int resto = n % 23;
            return minusculas[resto];
        }

        private void avisoOkGuardar()
        {
            MessageBox.Show("Se han guardado todos los campos!");
        }

        private void limpiar() // preguntar al profesor por la guarrada esta despues de cambiar el dni , despues de buscar
        {
            if (!cambioDniDespuesBucar)
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
                lbl_advertencia.Visible = false;
            }
            else
            {
                textBox_DNI.Focus();
                lbl_advertencia.Text = "dni no valido! usa formato (12345678A)";
            }
        }

        private void avisoFailGuardar()
        {
            if (dndGuardado)
            {
                lbl_advertencia.Visible = true;
                lbl_advertencia.BackColor = Color.Red;
                lbl_advertencia.Text = "Este dni ya esta guardado, intruduzca uno diferente";
                textBox_DNI.Focus();
            }
            else
            {
                lbl_advertencia.Visible = true;
                lbl_advertencia.Text = "Es necesario cubrir todos los campos!";
                lbl_advertencia.BackColor = Color.Red;
            }
        }

        private bool comprobaciones()
        {
            if (textBox_DNI.Text != "" & textBox_Nombre.Text != "" & textBox_Apellido1.Text != "" & textBox_Apellido2.Text != ""
                & checkedListBox_persmiso.SelectedIndex != -1 & (radioButton_Hombre.Checked == true | radioButton_Mujer.Checked == true) &
                (radioButton_Ninguna.Checked == true | radioButton_ESO.Checked == true | radioButton_Bach.Checked == true | radioButton_FP.Checked == true
            | radioButton_Universitaria.Checked == true | (radioButton_Otra.Checked == true & textBox_radioBtn_Otra.Text != "")))
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
            if (n >= 0 & n < 10)
            {
                if (comprobarDni(textBox_DNI.Text))
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
                    textBox_DNI.BackColor = Color.OrangeRed;
                    lbl_advertencia.Visible = true;
                    lbl_advertencia.BackColor = Color.Red;
                    lbl_advertencia.Text = "Dni no valido usa formato : 12345678A";
                    cambioDniDespuesBucar = true;
                    return false;
                }
            }
            else
            {
                lbl_advertencia.Visible = true;
                lbl_advertencia.Text = "No se pueden guardar mas registros!";
                structLleno = true;
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

        // eventos de foco cajas de texto

        // dni
        private void textBox_DNI_Enter(object sender, EventArgs e)
        {
            if (cajavalidada) textBox_DNI.BackColor = Color.FromArgb(160, 210, 208);
            else textBox_DNI.BackColor = Color.OrangeRed;
        }

        private void textBox_DNI_Leave(object sender, EventArgs e)
        {
            if (!comprobarDni(textBox_DNI.Text))
            {
                textBox_DNI.BackColor = Color.OrangeRed;
                lbl_advertencia.Visible = true;
                lbl_advertencia.BackColor = Color.Red;
                lbl_advertencia.Text = "Dni no valido usa formato : 12345678A";
                textBox_DNI.Focus();
                cajavalidada = false;
            }
            else
            {
                textBox_DNI.BackColor = Color.White;
                lbl_advertencia.Visible = false;
                cajavalidada = true;
            }
        }

        // nombre

        private void textBox_Nombre_Enter(object sender, EventArgs e)
        {
            if (cajavalidada) textBox_Nombre.BackColor = Color.FromArgb(160, 210, 208);
            else textBox_Nombre.BackColor = Color.OrangeRed;
        }

        private void textBox_Nombre_Leave(object sender, EventArgs e)
        {
            if (textBox_Nombre.Text == "")
            {
                textBox_Nombre.BackColor = Color.OrangeRed;
                lbl_advertencia.Visible = true;
                lbl_advertencia.BackColor = Color.Red;
                lbl_advertencia.Text = "Se necesita escribir un nombre";
                textBox_Nombre.Focus();
                cajavalidada = false;
            }
            else
            {
                textBox_Nombre.BackColor = Color.White;
                lbl_advertencia.Visible = false;
                cajavalidada = true;
            }

        }

        // apellido 1

        private void textBox_Apellido1_Enter(object sender, EventArgs e)
        {
            if (cajavalidada) textBox_Apellido1.BackColor = Color.FromArgb(160, 210, 208);
            else textBox_Apellido1.BackColor = Color.OrangeRed;
        }

        private void textBox_Apellido1_Leave(object sender, EventArgs e)
        {
            if (textBox_Apellido1.Text == "")
            {
                textBox_Apellido1.BackColor = Color.OrangeRed;
                lbl_advertencia.Visible = true;
                lbl_advertencia.BackColor = Color.Red;
                lbl_advertencia.Text = "Se necesita escribir un Apellido";
                textBox_Apellido1.Focus();
                cajavalidada = false;
            }
            else
            {
                textBox_Apellido1.BackColor = Color.White;
                lbl_advertencia.Visible = false;
                cajavalidada = true;
            }
        }

        // apellido 2

        private void textBox_Apellido2_Enter(object sender, EventArgs e)
        {
            if (cajavalidada) textBox_Apellido2.BackColor = Color.FromArgb(160, 210, 208);
            else textBox_Apellido2.BackColor = Color.OrangeRed;
        }

        private void textBox_Apellido2_Leave(object sender, EventArgs e)
        {
            if (textBox_Apellido2.Text == "")
            {
                textBox_Apellido2.BackColor = Color.OrangeRed;
                lbl_advertencia.Visible = true;
                lbl_advertencia.BackColor = Color.Red;
                lbl_advertencia.Text = "Se necesita escribir un Apellido";
                textBox_Apellido2.Focus();
                cajavalidada = false;
            }
            else
            {
                textBox_Apellido2.BackColor = Color.White;
                lbl_advertencia.Visible = false;
                cajavalidada = true;
            }
        }

        // titulacion maxima Otra

        private void textBox_radioBtn_Otra_Enter(object sender, EventArgs e)
        {
            textBox_radioBtn_Otra.BackColor = Color.FromArgb(160, 210, 208);
        }

        private void textBox_radioBtn_Otra_Leave(object sender, EventArgs e)
        {
            textBox_radioBtn_Otra.BackColor = Color.White;
        }

        // dni buscar

        private void textBox_Buscar_Enter(object sender, EventArgs e)
        {
            textBox_Buscar.BackColor = Color.FromArgb(160, 210, 208);
        }

        private void textBox_Buscar_Leave(object sender, EventArgs e)
        {
            textBox_Buscar.BackColor = Color.White;
        }

        // evento al cargar la applicacion
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_Buscar.Focus();
            lbl_advertencia.Visible = false;
            textBox_radioBtn_Otra.Enabled = false;
        }
    }
}
