using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica01_Extra_Jose_Angel_Doval_Fraga
{
    public partial class Practica01 : Form
    {
        //varables globales
        ficha_persona[] personas;
        public bool cajavalida = true;
        public int indextStructGlobal;
        public int n = 0;
        public bool structLleno;

        public Practica01()
        {
            InitializeComponent();
            personas = new ficha_persona[10];
        }

        // Declaración del struct
        public struct ficha_persona
        {
            public string dni, nombre, apellido1, apellido2, strTitulacionMax_otra;
            public bool permisoA, permisoB, permisoC, permisoD,
                permisoE, hombre, mujer, titulacionMax_none,
                titulacionMax_eso, titulacionMax_bach, titulacionMax_fp,
                titulacionMax_Uni, titulacionMax_otra;
            public int indexStruct;
        }

        // evento click Btn Guardar
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            bool datosOk = comprobaciones(txtBox_dni.Text);

            if (datosOk)
            {

                bool guardarDatos = guardarDatosEnArray();

                if (guardarDatos)
                {
                    avisoOkGuardar();
                    limpiarForulario();
                    txtBox_buscar.Focus();
                }

            }
        }

        // Evento boton buscar
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Console.WriteLine(txtBox_buscar.Text);
            if (txtBox_buscar.Text != "" & comprobarDni(txtBox_buscar.Text))
            {
                advertenciaDown();
                if (existeDni(txtBox_buscar.Text))
                {
                    advertenciaDown();
                    rellenarFormulario(txtBox_buscar.Text);
                }
                else
                {
                    advertenciaUp("Este dni no esta en nuestra base de datos");
                }
            }
            else
            {
                advertenciaUp("Introduzca dni para buscar ( formato : 12345678A) ");
                txtBox_buscar.Focus();
            }
        }

        //rellenar formulario
        private void rellenarFormulario(String dni)
        {
            limpiarForulario();
            int n = indextStructGlobal;
            txtBox_dni.Text = personas[n].dni;
            txtBox_nombre.Text = personas[n].nombre;
            txtBox_apellido1.Text = personas[n].apellido1;
            txtBox_apellido2.Text = personas[n].apellido2;
            chkBox_A.Checked = personas[n].permisoA;
            chkBox_B.Checked = personas[n].permisoB;
            chkBox_C.Checked = personas[n].permisoC;
            chkBox_D.Checked = personas[n].permisoD;
            chkBox_E.Checked = personas[n].permisoE;
            rdBtn_hombre.Checked = personas[n].hombre;
            rdBtn_mujer.Checked = personas[n].mujer;
            rdBtn_none.Checked = personas[n].titulacionMax_none;
            rdBtn_eso.Checked = personas[n].titulacionMax_eso;
            rdBtn_bach.Checked = personas[n].titulacionMax_bach;
            rdBtn_fp.Checked = personas[n].titulacionMax_fp;
            rdBtn_uni.Checked = personas[n].titulacionMax_Uni;
            rdBtn_otra.Checked = personas[n].titulacionMax_otra;
            txtBox_rdbtn_otra.Text = personas[n].strTitulacionMax_otra;
            txtBox_dni.BackColor = Color.White;
        }

        // Metodo para limpiar formulario
        private void limpiarForulario()
        {
            txtBox_dni.Clear();
            txtBox_nombre.Clear();
            txtBox_apellido1.Clear();
            txtBox_apellido2.Clear();
            chkBox_A.Checked = false;
            chkBox_B.Checked = false;
            chkBox_C.Checked = false;
            chkBox_D.Checked = false;
            chkBox_E.Checked = false;
            rdBtn_hombre.Checked = false;
            rdBtn_mujer.Checked = false;
            rdBtn_none.Checked = false;
            rdBtn_eso.Checked = false;
            rdBtn_bach.Checked = false;
            rdBtn_fp.Checked = false;
            rdBtn_uni.Checked = false;
            rdBtn_otra.Checked = false;
            txtBox_rdbtn_otra.Clear();
            if (txtBox_rdbtn_otra.BackColor == Color.OrangeRed)
            {
                txtBox_rdbtn_otra.BackColor = Color.White;
            }
            advertenciaDown();
        }

        // Metodo para guardar datos
        private bool guardarDatosEnArray()
        {
            if (n >= 0 & n < 10)
            {
                personas[n].indexStruct = n;
                personas[n].dni = txtBox_dni.Text;
                personas[n].nombre = txtBox_nombre.Text;
                personas[n].apellido1 = txtBox_apellido1.Text;
                personas[n].apellido2 = txtBox_apellido2.Text;
                personas[n].permisoA = chkBox_A.Checked;
                personas[n].permisoB = chkBox_B.Checked;
                personas[n].permisoC = chkBox_C.Checked;
                personas[n].permisoD = chkBox_D.Checked;
                personas[n].permisoE = chkBox_E.Checked;
                personas[n].hombre = rdBtn_hombre.Checked;
                personas[n].mujer = rdBtn_mujer.Checked;
                personas[n].titulacionMax_none = rdBtn_none.Checked;
                personas[n].titulacionMax_eso = rdBtn_eso.Checked;
                personas[n].titulacionMax_bach = rdBtn_bach.Checked;
                personas[n].titulacionMax_fp = rdBtn_fp.Checked;
                personas[n].titulacionMax_Uni = rdBtn_uni.Checked;
                personas[n].titulacionMax_otra = rdBtn_otra.Checked;
                personas[n].strTitulacionMax_otra = txtBox_rdbtn_otra.Text;

                n++;
                return true;
            }
            else
            {
                advertenciaUp("No se admiten mas registros");
                structLleno = true;
                return false;
            }
        }

        // Metodo para cuando se guarda todo ok
        private void avisoOkGuardar()
        {
            MessageBox.Show("Se han guardado todos los campos!");
        }

        //Metodo comprobaciones
        private bool comprobaciones(String dni)
        {
            if (!existeDni(dni) && comprobarTxtBoxes() &&  comprobarPermChecked() && comprobarSexChecked() && comprobarTituloChecked() )
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        // Metodo para ver si el dni que se intenta guardar existe
        private bool existeDni(String dni)
        {
            foreach (var i in personas)
            {
                if (dni == i.dni)
                {
                    indextStructGlobal = i.indexStruct;
                    advertenciaUp("Este dni ya existe");
                    txtBox_dni.Focus();
                    txtBox_dni.BackColor = Color.OrangeRed;
                    return true;
                }
            }
            advertenciaDown();
            return false;
        }

        // Evento de entrada en textBox buscar
        private void txtBox_buscar_Enter(object sender, EventArgs e)
        {
            if (cajavalida) txtBox_buscar.BackColor = Color.FromArgb(160, 210, 208);
            else txtBox_buscar.BackColor = Color.OrangeRed;
        }
        private void txtBox_buscar_Leave(object sender, EventArgs e)
        {
            txtBox_buscar.BackColor = Color.White;
        }

        //Eventos ganar y perder foco textBox Nombre
        private void txtBox_nombre_Enter(object sender, EventArgs e)
        {
            if (cajavalida)
            {
                txtBox_nombre.BackColor = Color.FromArgb(160, 210, 208);
            }
            else
            {
                txtBox_nombre.BackColor = Color.OrangeRed;
            }

        }
        private void txtBox_nombre_Leave(object sender, EventArgs e)
        {
            if (!cajaVacia(txtBox_nombre.Text))
            {
                txtBox_nombre.BackColor = Color.White;
                advertenciaDown();
                cajavalida = true;
            }
            else
            {
                txtBox_nombre.BackColor = Color.OrangeRed;
                advertenciaUp("El nombre no se puede dejar en blanco.");
                cajavalida = false;
                txtBox_nombre.Focus();
            }
        }

        //Eventos para ganar y perder foco textBox Apellido 1
        private void txtBox_apellido1_Enter(object sender, EventArgs e)
        {
            if (cajavalida)
            {
                txtBox_apellido1.BackColor = Color.FromArgb(160, 210, 208);
            }
            else
            {
                txtBox_apellido1.BackColor = Color.OrangeRed;
            }
        }
        private void txtBox_apellido1_Leave(object sender, EventArgs e)
        {
            if (!cajaVacia(txtBox_apellido1.Text))
            {
                txtBox_apellido1.BackColor = Color.White;
                advertenciaDown();
                cajavalida = true;
            }
            else
            {
                txtBox_apellido1.BackColor = Color.OrangeRed;
                advertenciaUp("El primer Apellido no se puede dejar en blanco.");
                cajavalida = false;
                txtBox_apellido1.Focus();
            }
        }

        //Eventos para ganar y perder foco textBox Apellido 1
        private void txtBox_apellido2_Enter(object sender, EventArgs e)
        {
            if (cajavalida)
            {
                txtBox_apellido2.BackColor = Color.FromArgb(160, 210, 208);
            }
            else
            {
                txtBox_apellido2.BackColor = Color.OrangeRed;
            }
        }
        private void txtBox_apellido2_Leave(object sender, EventArgs e)
        {
            if (!cajaVacia(txtBox_apellido2.Text))
            {
                txtBox_apellido2.BackColor = Color.White;
                advertenciaDown();
                cajavalida = true;
            }
            else
            {
                txtBox_apellido2.BackColor = Color.OrangeRed;
                advertenciaUp("El Segundo Apellido no se puede dejar en blanco.");
                cajavalida = false;
                txtBox_apellido2.Focus();
            }
        }

        //Eventos ganar y perder foco textBox DNI
        private void txtBox_dni_Enter(object sender, EventArgs e)
        {
            if (cajavalida)
            {
                txtBox_dni.BackColor = Color.FromArgb(160, 210, 208);
            }
            else
            {
                txtBox_dni.BackColor = Color.OrangeRed;
            }
         }
        private void txtBox_dni_Leave(object sender, EventArgs e)
        {
            if (comprobarDni(txtBox_dni.Text))
            {
                txtBox_dni.BackColor = Color.White;
                advertenciaDown();
                cajavalida = true;
            }
            else
            {
                txtBox_dni.BackColor = Color.OrangeRed;
                advertenciaUp("Dni no valido, utiliza el formato --> 12345678A");
                cajavalida = false;
                txtBox_dni.Focus();
            }
        }

        //advertenciaUp y advertenciaDown
        private void advertenciaUp(String txt)
        {
            lbl_advertencia.Visible = true;
            lbl_advertencia.BackColor = Color.OrangeRed;
            lbl_advertencia.Text = txt;
        }
        private void advertenciaDown()
        {
            lbl_advertencia.Visible = false;
        }

        // comprobamos dni
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

        // comprobamos si la caja esta vacia
        private bool cajaVacia(String txt) 
        {
            if (txt == "") return true;
            else return false;
        }

        // comprobamos que no hay textboxes vacios
        private bool comprobarTxtBoxes()
        {
            if(txtBox_dni.Text !="" & txtBox_nombre.Text != "" & txtBox_apellido1.Text != "" & txtBox_apellido2.Text != "")
            {
                advertenciaDown();
                return true;
            }
            else
            {
                advertenciaUp("No se pueden dejar Campos sin cubrir");
                return false;
            }
        }

        // metodo para comprobar si hay algun permiso de conducir marcado
        public bool comprobarPermChecked()
        {
            if (chkBox_A.Checked == true | chkBox_B.Checked == true |
                chkBox_C.Checked == true | chkBox_D.Checked == true |
                chkBox_E.Checked == true)
            {
                advertenciaDown();
                return true;
            }
            else
            {
                advertenciaUp("No se puede guardar si no se marca un permiso de conducir");
                return false;
            }
        }

        // metodo para comprbar si hay algun sexo marcado
        public bool comprobarSexChecked()
        {
            if (rdBtn_hombre.Checked == true | rdBtn_mujer.Checked == true)
            {
                advertenciaDown();
                return true;
            }
            else
            {
                advertenciaUp("No se puede guardar si no se marca un sexo");
                return false;
            }
        }

        // metodo para comprobar si hay alguna titulación marcada y validacion txtBox otra titulacion
        public bool comprobarTituloChecked()
        {
            if (rdBtn_none.Checked == true | rdBtn_eso.Checked == true | rdBtn_bach.Checked == true |
                rdBtn_fp.Checked == true | rdBtn_uni.Checked == true | (rdBtn_otra.Checked == true & txtBox_rdbtn_otra.Text != ""))
            {
                advertenciaDown();
                return true;
            }
            else
            {
                if (rdBtn_otra.Checked == false)
                {
                    advertenciaUp("No se puede guardar si no se marca un Titulo academico");
                    return false;
                }
                else 
                {
                    advertenciaUp("Si se marca la opcion Otra se tiene que cubir la caja de texto");
                    txtBox_rdbtn_otra.BackColor = Color.OrangeRed;
                    txtBox_rdbtn_otra.Focus();
                    return false;
                }
            }
        }

        // evento radioBtn otra cambio de estado
        private void rdBtn_otra_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtn_otra.Checked)
            {
                txtBox_rdbtn_otra.Enabled = true;
                txtBox_rdbtn_otra.Focus();
            }
            else
            {
                txtBox_rdbtn_otra.Enabled = false;
                txtBox_rdbtn_otra.Clear();
            }
        }

        // Evento Load ( nada mas carga el programa)
        private void Practica01_Load(object sender, EventArgs e)
        {
            txtBox_rdbtn_otra.Enabled = false;
        }
    }
}
