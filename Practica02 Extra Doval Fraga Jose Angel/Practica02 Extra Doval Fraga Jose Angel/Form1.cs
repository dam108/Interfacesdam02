using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica02_Extra_Doval_Fraga_Jose_Angel
{

    public partial class Form1 : Form
    {

        //
        // Variables Globales
        //
        public bool CajaValida = true;
        public List<Registro> Registros;

        public Form1()
        {
            InitializeComponent();
            Registros = new List<Registro>();
        }

        //
        // Struct con los campos del combobox
        //
        public struct Registro
        {
            public string modelo, color, alto, ancho;
        }

        //
        // Evento eliminar todos los items de la lista y del combobox
        //
        private void EliminarTodasButtons_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro que quieres borrar todos los datos?", "Borrar",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                alfombrasComboBox.Items.Clear();
                alfombrasComboBox.Text = "";
                Registros.Clear();
                alfombrasPictureBox.Hide();
            }
            else
            {
                MessageBox.Show("No se han eliminado los datos");
            }


        }

        //
        // Evento eliminar un item de la lista del combobox
        //
        private void EliminarAlfombraButton_Click(object sender, EventArgs e)
        {
            int n = NumItemSeleccionado();
            if (n >= 0)
            {
                AdvertenciaDown();
                alfombrasComboBox.Items.RemoveAt(n);
                Registros.RemoveAt(n);
                alfombrasComboBox.Text = "";
                alfombrasPictureBox.Hide();
            }
            else
            {
                AdvertenciaUp("Se debe seleccionar un item de la lista!");
            }
        }

        //
        // Evento click boton iformación
        //
        private void AlfombraInfoButton_Click(object sender, EventArgs e)
        {
            int n = NumItemSeleccionado();

            if (n >= 0)
            {
                AdvertenciaDown();
                alfombrasPictureBox.Show();
                // posibles opciones para enseñar en el pictureBox son alfombra1 , alfombra2 , alfombra3
                //y estan guardadas en la carpeta /pics/ al lado de los ejecutables en /bin/debug/
                alfombrasPictureBox.ImageLocation = Environment.CurrentDirectory + "/pics/" + Registros[n].modelo + ".jpg";
                MessageBox.Show("Modelo: " + Registros[n].modelo + "\nColor: " + Registros[n].color +
                                    "\nAncho: " + Registros[n].ancho + "cm\nAlto: " + Registros[n].alto + "cm");

            }
            else { AdvertenciaUp("se debe seleccionar un elemento de la lista"); }
        }
        //
        // Metodo para saber el numero del item seleccionado
        //
        private int NumItemSeleccionado()
        {
            return alfombrasComboBox.SelectedIndex;
        }

        //
        // Evento Boton añadir
        //
        private void AñadirButton_Click(object sender, EventArgs e)
        {
            if (ComprobacionCajasVacias())
            {
                AdvertenciaDown();
                //Guardamos los datos del struct en la Lista
                Registros.Add(new Registro()
                {
                    modelo = modelTextBox.Text,
                    color = colorTextBox.Text,
                    alto = altoTextBox.Text,
                    ancho = anchoTextBox.Text
                });
                // mostramos msg de guardado exitoso
                MessageBox.Show("Se han guardado los datos con exito!");
                // Guardamos los campos en el combobox
                alfombrasComboBox.Items.Add("Modelo: " + modelTextBox.Text + " Color: " + colorTextBox.Text);
                //limpiamos los cuadros de texto
                Limpiar();

            }
            else
            {
                AdvertenciaUp("se deben cubrir todos los campos");
            }
        }

        //
        // Metodo Limpiar
        //
        private void Limpiar()
        {
            modelTextBox.Clear();
            colorTextBox.Clear();
            altoTextBox.Clear();
            anchoTextBox.Clear();
        }

        //
        // Metodo coprobar cajas vacias
        //
        private bool ComprobacionCajasVacias()
        {
            if (modelTextBox.Text != "" & colorTextBox.Text != "" & anchoTextBox.Text != "" & altoTextBox.Text != "") return true;
            else return false;
        }

        //
        // Advertencia
        //
        private void AdvertenciaDown()
        {
            advertenciaLabel.Visible = false;
        }
        private void AdvertenciaUp(string txt)
        {
            advertenciaLabel.Visible = true;
            advertenciaLabel.BackColor = Color.OrangeRed;
            advertenciaLabel.Text = txt;
        }

        //
        // Metodo para comprobar si la caja esta vacia
        //
        private bool CajaVacia(string txt)
        {
            if (txt != "") return true;
            else return false;
        }

        //
        // Evento load
        //
        private void Form1_Load(object sender, EventArgs e)
        {
            advertenciaLabel.Visible = false;
            //gBox_insertar.Focus();
        }

        //
        // Eventos txtModelo
        //
        private void ModeloTextBox_Enter(object sender, EventArgs e)
        {
            if (CajaValida)
            {
                modelTextBox.BackColor = Color.FromArgb(160, 210, 208);
            }
            else
            {
                modelTextBox.BackColor = Color.OrangeRed;
            }
        }
        private void ModeloTextBox_Leave(object sender, EventArgs e)
        {
            if (CajaVacia(modelTextBox.Text))
            {
                modelTextBox.BackColor = Color.White;
                AdvertenciaDown();
                CajaValida = true;
            }
            else
            {
                modelTextBox.BackColor = Color.OrangeRed;
                AdvertenciaUp("Se requiere un Modelo de alfombra");
                CajaValida = false;
                modelTextBox.Focus();
            }
        }

        //
        // Eventos Color
        //
        private void ColorTextBox_Enter(object sender, EventArgs e)
        {
            if (CajaValida)
            {
                colorTextBox.BackColor = Color.FromArgb(160, 210, 208);
            }
            else
            {
                colorTextBox.BackColor = Color.OrangeRed;
            }
        }
        private void ColorTextBox_Leave(object sender, EventArgs e)
        {
            if (CajaVacia(colorTextBox.Text))
            {
                colorTextBox.BackColor = Color.White;
                AdvertenciaDown();
                CajaValida = true;
            }
            else
            {
                colorTextBox.BackColor = Color.OrangeRed;
                AdvertenciaUp("Se requiere un color de alfombra");
                CajaValida = false;
                colorTextBox.Focus();
            }
        }

        //
        // Event Ancho
        // 
        private void AnchoTextBox_Enter(object sender, EventArgs e)
        {
            if (CajaValida)
            {
                anchoTextBox.BackColor = Color.FromArgb(160, 210, 208);
            }
            else
            {
                anchoTextBox.BackColor = Color.OrangeRed;
            }
        }
        private void AnchoTextBox_Leave(object sender, EventArgs e)
        {
            if (CajaVacia(anchoTextBox.Text) & CajaNumValida(anchoTextBox.Text))
            {
                anchoTextBox.BackColor = Color.White;
                AdvertenciaDown();
                CajaValida = true;
            }
            else
            {
                anchoTextBox.BackColor = Color.OrangeRed;
                AdvertenciaUp("Se requiere un ancho en centimetros para la alfombra");
                CajaValida = false;
                anchoTextBox.Focus();
            }
        }

        //
        // Event Ancho
        // 
        private void AltoTextBox_Enter(object sender, EventArgs e)
        {
            if (CajaValida)
            {
                altoTextBox.BackColor = Color.FromArgb(160, 210, 208);
            }
            else
            {
                altoTextBox.BackColor = Color.OrangeRed;
            }
        }
        private void AltoTextBox_Leave(object sender, EventArgs e)
        {
            if (CajaVacia(altoTextBox.Text) & CajaNumValida(altoTextBox.Text))
            {
                altoTextBox.BackColor = Color.White;
                AdvertenciaDown();
                CajaValida = true;
            }
            else
            {
                altoTextBox.BackColor = Color.OrangeRed;
                AdvertenciaUp("Se requiere un alto en centimetros para la alfombra");
                CajaValida = false;
                altoTextBox.Focus();
            }
        }

        //
        // Metodos para comprobar si el valor introducido es numerico
        //
        private bool CajaNumValida(string txt)
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
