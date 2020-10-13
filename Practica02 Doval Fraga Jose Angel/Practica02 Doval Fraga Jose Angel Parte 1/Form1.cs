using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica02_Doval_Fraga_Jose_Angel_Parte_1
{

    public partial class Form1 : Form
    {

        //
        // Variables Globales
        //
        public bool _cajavalida = true;
        public List<registro> _registros;

        public Form1()
        {
            InitializeComponent();
            _registros = new List<registro>();
        }

        //
        // Struct con los campos del combobox
        //
        public struct registro
        {
            public string modelo, color, alto, ancho;
        }

        //
        // Evento eliminar todos los items de la lista y del combobox
        //
        private void btnEliminarTodas_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Estas seguro que quieres borrar todos los datos?","Borrar",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cboAlfombras.Items.Clear();
                cboAlfombras.Text = "";
                _registros.Clear();
            }
            else 
            {
                MessageBox.Show("No se han eliminado los datos");
            }

            
        }

        //
        // Evento eliminar un item de la lista del combobox
        //
        private void btnEliminarAlfombra_Click(object sender, EventArgs e)
        {
            int n = numItemSeleccionado();
            if (n >= 0)
            {
                advertenciaDown();
                cboAlfombras.Items.RemoveAt(n);
                _registros.RemoveAt(n);
                cboAlfombras.Text = "";
            }
            else
            {
                advertenciaUp("Se debe seleccionar un item de la lista!");
            }
        }

        //
        // Evento click boton iformación
        //
        private void btnInfoAlfombra_Click(object sender, EventArgs e)
        {
            int n = numItemSeleccionado();

            if (n >= 0)
            {
                advertenciaDown();
                MessageBox.Show("Modelo: " + _registros[n].modelo + "\nColor: "+ _registros[n].color +
                    "\nAncho: "+ _registros[n].ancho + "cm\nAlto: "+ _registros[n].alto + "cm");
            }
            else { advertenciaUp("se debe seleccionar un elemento de la lista"); }
        }
        //
        // Metodo para saber el numero del item seleccionado
        //
        private int numItemSeleccionado()
        {
            return cboAlfombras.SelectedIndex;
        }

        //
        // Evento Boton añadir
        //
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if(comprobacionCajasVacias())
            {
                advertenciaDown();
                //Guardamos los datos del struct en la Lista
                _registros.Add(new registro()
                {
                    modelo = txtModelo.Text,
                    color = txtColor.Text,
                    alto = txtAlto.Text,
                    ancho = txtAncho.Text
                });
                // mostramos msg de guardado exitoso
                MessageBox.Show("Se han guardado los datos con exito!");
                // Guardamos los campos en el combobox
                cboAlfombras.Items.Add("Modelo: " + txtModelo.Text + " Color: " + txtColor.Text);
                //limpiamos los cuadros de texto
                limpiar();

            }
            else
            {
                advertenciaUp("se deben cubrir todos los campos");
            }
        }

        //
        // Metodo limpiar
        //
        private void limpiar()
        {
            txtModelo.Clear();
            txtColor.Clear();
            txtAlto.Clear();
            txtAncho.Clear();
        }
        
        //
        // Metodo coprobar cajas vacias
        //
        private bool comprobacionCajasVacias()
        {
            if (txtModelo.Text != "" & txtColor.Text != "" & txtAncho.Text != "" & txtAlto.Text != "") return true;
            else return false;
        }

        //
        // Advertencia
        //
        private void advertenciaDown()
        {
            lblAdvertencia.Visible = false;
        }
        private void advertenciaUp(string txt)
        {
            lblAdvertencia.Visible = true;
            lblAdvertencia.BackColor = Color.OrangeRed;
            lblAdvertencia.Text = txt;
        }

        //
        // Metodo para comprobar si la caja esta vacia
        //
        private bool cajaVacia(string txt)
        {
            if (txt != "") return true;
            else return false;
        }

        //
        // Evento load
        //
        private void Form1_Load(object sender, EventArgs e)
        {
            lblAdvertencia.Visible = false;
            //gBox_insertar.Focus();
        }

        //
        // Eventos txtModelo
        //
        private void txtModelo_Enter(object sender, EventArgs e)
        {
            if (_cajavalida)
            {
                txtModelo.BackColor = Color.FromArgb(160, 210, 208);
            }
            else
            {
                txtModelo.BackColor = Color.OrangeRed;
            }
        }
        private void txtModelo_Leave(object sender, EventArgs e)
        {
            if (cajaVacia(txtModelo.Text))
            {
                txtModelo.BackColor = Color.White;
                advertenciaDown();
                _cajavalida = true;
            }
            else
            {
                txtModelo.BackColor = Color.OrangeRed;
                advertenciaUp("Se requiere un Modelo de alfombra");
                _cajavalida = false;
                txtModelo.Focus();
            }
        }

        //
        // Eventos Color
        //
        private void txtColor_Enter(object sender, EventArgs e)
        {
            if (_cajavalida)
            {
                txtColor.BackColor = Color.FromArgb(160, 210, 208);
            }
            else
            {
                txtColor.BackColor = Color.OrangeRed;
            }
        }
        private void txtColor_Leave(object sender, EventArgs e)
        {
            if (cajaVacia(txtColor.Text))
            {
                txtColor.BackColor = Color.White;
                advertenciaDown();
                _cajavalida = true;
            }
            else
            {
                txtColor.BackColor = Color.OrangeRed;
                advertenciaUp("Se requiere un color de alfombra");
                _cajavalida = false;
                txtColor.Focus();
            }
        }

        //
        // Event Ancho
        // 
        private void txtAncho_Enter(object sender, EventArgs e)
        {
            if (_cajavalida)
            {
                txtAncho.BackColor = Color.FromArgb(160, 210, 208);
            }
            else
            {
                txtAncho.BackColor = Color.OrangeRed;
            }
        }
        private void txtAncho_Leave(object sender, EventArgs e)
        {
            if (cajaVacia(txtAncho.Text) & cajaNumValida(txtAncho.Text))
            {
                txtAncho.BackColor = Color.White;
                advertenciaDown();
                _cajavalida = true;
            }
            else
            {
                txtAncho.BackColor = Color.OrangeRed;
                advertenciaUp("Se requiere un ancho en centimetros para la alfombra");
                _cajavalida = false;
                txtAncho.Focus();
            }
        }

        //
        // Event Ancho
        // 
        private void txtAlto_Enter(object sender, EventArgs e)
        {
            if (_cajavalida)
            {
                txtAlto.BackColor = Color.FromArgb(160, 210, 208);
            }
            else
            {
                txtAlto.BackColor = Color.OrangeRed;
            }
        }
        private void txtAlto_Leave(object sender, EventArgs e)
        {
            if (cajaVacia(txtAlto.Text) & cajaNumValida(txtAlto.Text))
            {
                txtAlto.BackColor = Color.White;
                advertenciaDown();
                _cajavalida = true;
            }
            else
            {
                txtAlto.BackColor = Color.OrangeRed;
                advertenciaUp("Se requiere un alto en centimetros para la alfombra");
                _cajavalida = false;
                txtAlto.Focus();
            }
        }

        //
        // Metodos para comprobar si el valor introducido es numerico
        //
        private bool cajaNumValida(string txt)
        {
            for (int i = 0; i < txt.Length; i++)
            {
                char a = txt[i];
                if (!char.IsDigit(a)) return false;
            }
            return true;
        }
    }
}
