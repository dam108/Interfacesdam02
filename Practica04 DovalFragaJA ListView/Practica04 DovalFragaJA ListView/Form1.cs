using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica04_DovalFragaJA_ListView
{
    public partial class Formulario : Form
    {
        // Declaramos variables globales
        public List<Trabajador> trabajadores;
        public List<string> provincias;
        public List<string> profesiones;
        BindingSource listaProvinciasBS = new BindingSource();
        BindingSource listaProfesionesBS = new BindingSource();


        public Formulario()
        {
            InitializeComponent();
        }

        // Eventos

        private void Formulario_Load(object sender, EventArgs e)
        {
            // inicializamos listas
            trabajadores = new List<Trabajador>() { new Trabajador("79336700V", "Jose Angel", "Doval", "Fraga", 1, 3) };
            provincias = new List<string>() {"A Coruña", "Lugo", "Ourense"} ;
            profesiones = new List<string>() {"Carpintero", "Albañil", "Contable", "Desarrollador"};
            ordenarlistas();

            // Binding de combobox y listBox
            listaProvinciasBS.DataSource = provincias;
            provincias_ComboBox.DataSource = listaProvinciasBS;

            listaProfesionesBS.DataSource = profesiones;
            profesion_ListBox.DataSource = listaProfesionesBS;
        }

        private void anadirProvincia_Btn_Click(object sender, EventArgs e)
        {
            if (!Comprobaciones.cajaVacia(provinciasAnadir_TextBox.Text))
            {
                AdvertenciaDown();
                provincias.Add(provinciasAnadir_TextBox.Text);
                ordenarlistas();
                ActualizarVinculos();
                provinciasAnadir_TextBox.Clear();
            }
            else
            {
                AdvertenciaUp("Tienes que introducir una nueva provincia");
                provinciasAnadir_TextBox.Focus();
            }
        }

        private void eliminarProvincia_Btn_Click(object sender, EventArgs e)
        {
            int n = provincias_ComboBox.SelectedIndex;
            if (n >= 0)
            {
                AdvertenciaDown();
                provincias.RemoveAt(n);
                ordenarlistas();
                ActualizarVinculos();
            }
            else
            {
                AdvertenciaUp("No hay items seleccionados");
            }
        }

        private void anadirProfesion_Btn_Click(object sender, EventArgs e)
        {
            if (!Comprobaciones.cajaVacia(profesionAnadir_TextBox.Text))
            {
                AdvertenciaDown();
                profesiones.Add(profesionAnadir_TextBox.Text);
                ordenarlistas();
                ActualizarVinculos();
                profesionAnadir_TextBox.Clear();
            }
            else
            {
                AdvertenciaUp("Tienes que introducir una nueva profesion");
                profesionAnadir_TextBox.Focus();
            }
        }

        private void eliminarProfesion_Btn_Click(object sender, EventArgs e)
        {
            int n = profesion_ListBox.SelectedIndex;
            if (n >= 0)
            {
                AdvertenciaDown();
                profesiones.RemoveAt(n);
                ordenarlistas();
                ActualizarVinculos();
            }
            else
            {
                AdvertenciaUp("No hay items seleccionados");
            }
        }

        private void engadirBtn_Click(object sender, EventArgs e)
        {

            if (Comprobaciones.dniOK(dni_TextBox.Text))
            {
                AdvertenciaDown();

                if (Comprobaciones.existeDni(dni_TextBox.Text, trabajadores))
                {
                    AdvertenciaDown();

                    if (Comprobaciones.nombreOK(nombre_TextBox.Text))
                    {
                        AdvertenciaDown();
                        if (Comprobaciones.apellidoOK(apellido1_TextBox.Text))
                        {
                            AdvertenciaDown();
                            if (Comprobaciones.apellidoOK(apellido2_TextBox.Text))
                            {
                                AdvertenciaDown();

                                if (Comprobaciones.provinciaSeleccionada(provincias_ComboBox.SelectedIndex))
                                {
                                    AdvertenciaDown();
                                    if (Comprobaciones.profesionSeleccionada(profesion_ListBox.SelectedIndex))
                                    {
                                        AdvertenciaDown();
                                        trabajadores.Add(new Trabajador(dni_TextBox.Text, nombre_TextBox.Text, apellido1_TextBox.Text, apellido2_TextBox.Text, provincias_ComboBox.SelectedIndex, profesion_ListBox.SelectedIndex));
                                        ActualizarVinculos();
                                        limpiarCajas();
                                    }
                                    else
                                    {
                                        AdvertenciaUp("Seleccione una profesion");
                                        provincias_ComboBox.Focus();
                                    }
                                }
                                else
                                {
                                    AdvertenciaUp("Seleccione una provincia");
                                    provincias_ComboBox.Focus();
                                }
                            }
                            else
                            {
                                AdvertenciaUp("El campo del segundo apellido no se puede dejar vacio");
                                apellido2_TextBox.Focus();
                            }
                        }
                        else
                        {
                            AdvertenciaUp("El campo del primer apellido no se puede dejar vacio");
                            apellido1_TextBox.Focus();
                        }
                    }
                    else
                    {
                        AdvertenciaUp("El campo del nombre no se puede dejar vacio");
                        nombre_TextBox.Focus();
                    }
                }
                else
                {
                    AdvertenciaUp("Este trabajador ya existe, introduzca otro dni");
                    dni_TextBox.Focus();
                }
            }
            else
            {
                AdvertenciaUp("El formato del dni no es valido");
                dni_TextBox.Focus();
            }

        }

        // Métodos

        private void ActualizarVinculos()
        {
            listaProfesionesBS.ResetBindings(false);
            listaProvinciasBS.ResetBindings(false);
        }

        private void ordenarlistas() 
        {
            trabajadores.Sort();
            provincias.Sort();
            profesiones.Sort();
        }

        public void AdvertenciaUp(string txt)
        {
            advertencia_Lbl.Visible = true;
            advertencia_Lbl.Text = txt;
        }

        public void AdvertenciaDown()
        {
            advertencia_Lbl.Visible = false;
        }

        private void limpiarCajas()
        {
            dni_TextBox.Text = "";
            nombre_TextBox.Text = "";
            apellido1_TextBox.Text = "";
            apellido2_TextBox.Text = "";
        }

    }
}
