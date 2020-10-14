using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica02_Doval_Fraga_jose_Angel_Parte_2
{
    public partial class Form1 : Form
    {
        List<String> provincias;
        List<List<String>> localidades = new List<List<string>>();
        BindingSource bsProvincias;
        BindingSource bsLocalidades;

        public Form1()
        {
            InitializeComponent();
        }

        //
        // Evento Load
        //
        private void Form1_Load(object sender, EventArgs e)
        {
            advertenciaDown();
            provincias = new List<string>();
            bsProvincias = new BindingSource();
            bsLocalidades = new BindingSource();

            //llenamos la lista de provincias y la lista bidimensional de Localidades
            rellenarP();
            rellenarL();

            iniciarComboboxes();

            radModificar.Enabled = false;
            txtLocalidad_gestion.Enabled = false;
        }

        //
        // Iniciar Comboboxes
        //
        private void iniciarComboboxes() 
        {
            // enlazamos listas con combosboxes
            bsProvincias.DataSource = provincias;
            cboProvincia.DataSource = bsProvincias;

            bsLocalidades.DataSource = localidades[cboProvincia.SelectedIndex];
            cboLocalidad.DataSource = bsLocalidades;
        }

        //
        // Metodo rellenar Lista de Localidades
        //
        private void rellenarL()
        {
            localidades.Add(new List<string> { "Abegondo", "Betanzos" });
            localidades.Add(new List<string> { "Abadín", "Alfoz" });
            localidades.Add(new List<string> { "Allariz", "Amoeiro" });
            localidades.Add(new List<string> { "Golada", "Vila de Cruces" });
        }

        //
        // Metodo rellenar Lista de provincias
        //
        private void rellenarP()
        {
            provincias.Add("A Coruña");
            provincias.Add("Lugo");
            provincias.Add("Orense");
            provincias.Add("Pontevedra");
        }

        //
        // Evento para cuando se selecciona una provincia mostrar todas sus localidades
        //
        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            desmarcarRdBns();
            bsLocalidades.DataSource = localidades[cboProvincia.SelectedIndex];
            cboLocalidad.DataSource = bsLocalidades;
        }

        //
        // Evento para cuando se selecciona una Localidad o provincia
        //
        private void cboProvincia_Enter(object sender, EventArgs e)
        {
            desmarcarRdBns();
        }
        private void cboLocalidad_Enter(object sender, EventArgs e)
        {
            desmarcarRdBns();
        }

        //
        // Evento click boton ejecutar
        //
        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            advertenciaDown();
            if (comprobarRadioBtnSeleccionados())
            {
                if (radEliminar.Checked)
                {
                    int indexP = cboProvincia.SelectedIndex;
                    int indexL = cboLocalidad.SelectedIndex;
                    if (indexL >= 0)
                    {
                        localidades[indexP].RemoveAt(indexL);
                        refrescarComboBoxes();
                    }
                    else { advertenciaUp("no hay localidades en la lista"); }
                }
                else if (radAgregar.Checked)
                {
                    if (cajaVacia(txtLocalidad_gestion.Text))
                    {
                        int indexP = cboProvincia.SelectedIndex;
                        if (indexP >= 0)
                        {
                            String nuevaLocalidad = txtLocalidad_gestion.Text;
                            txtLocalidad_gestion.Clear();
                            cboLocalidad.Focus();
                            localidades[indexP].Add(nuevaLocalidad);
                            refrescarComboBoxes();
                        }
                        else
                        {
                            advertenciaUp("No hay provincias a la que agregar esta localidad!");
                        }
                    }
                    else 
                    {
                        advertenciaUp("Se debe introducir una Localidad en el cuadro de abajo");
                        txtLocalidad_gestion.Enabled = true;
                        txtLocalidad_gestion.Focus();
                    }
                }
            }
            else
            {
                advertenciaUp("Se debe seleccionar una opcion de la izquierda");
            }
            
        }

        //
        // Evento para cuando se selecciona el radiobtb de agregar
        //
        private void radAgregar_CheckedChanged(object sender, EventArgs e)
        {
            if (radAgregar.Checked)
            {
                txtLocalidad_gestion.Enabled = true;
                txtLocalidad_gestion.Focus();
            }
            else
            {
                txtLocalidad_gestion.Enabled = false;
            }
        }

        //
        // Metodo para refrescar Comboboxes
        //
        private void refrescarComboBoxes()
        {
            //bsProvincias.ResetBindings(true);
            bsLocalidades.ResetBindings(true);
        }

        //
        // Metodo para comrpobar si hay algun radio btn seleccionado
        //
        private bool comprobarRadioBtnSeleccionados() 
        {
            if (!radEliminar.Checked & !radAgregar.Checked & !radModificar.Checked)
            {
                advertenciaUp("Se debe seleccionar una opcion de la izquierda!");
                return false;
            }
            else 
            {
                return true;
            }
        }

        //
        // Metodo para desmarcar radiobuttons
        //
        private void desmarcarRdBns()
        {
            radEliminar.Checked = false;
            radAgregar.Checked = false;
            radModificar.Checked = false;
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
            Console.WriteLine(txt);
        }

        //
        // Metodo para comprobar si la caja esta vacia
        //
        private bool cajaVacia(string txt)
        {
            if (txt != "") return true;
            else return false;
        }

        private void txtLocalidad_gestion_Leave(object sender, EventArgs e)
        {
            if ( !cajaVacia(txtLocalidad_gestion.Text))
            {
                txtLocalidad_gestion.Enabled = false;
            }
        }
    }
}
//
//
//