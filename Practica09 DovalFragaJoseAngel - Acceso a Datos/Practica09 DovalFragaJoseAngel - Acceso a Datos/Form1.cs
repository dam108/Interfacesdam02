using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica09_DovalFragaJoseAngel___Acceso_a_Datos
{
    public partial class Form1 : Form
    {
        SqlConnection miConexion = new SqlConnection("Data Source=.;Initial Catalog=practica09;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
            MuestraDatos();
        }

        private void MuestraDatos()
        {
            try
            {
                DataSet conjuntoDatos = new DataSet();
                string sql = "SELECT codReserva AS \"Cod.Fiesta\", fecha AS Fecha,CASE WHEN sala=1 THEN 'AMARILLA' WHEN sala=2 THEN 'VIOLETA' END AS Sala, " +
                            "CONCAT(nombre,' ',apellido1,' ',apellido2,' ','(', clientes.dniCliente ,')') AS Cliente," +
                            " invitados AS \"Num.Invitados\" FROM reservas JOIN clientes ON reservas.dniCliente = clientes.dniCliente;";

                miConexion.Open();
                SqlDataAdapter adaptador = new SqlDataAdapter(sql, miConexion);
                adaptador.Fill(conjuntoDatos);
                reservasDataGridView.DataSource = conjuntoDatos.Tables[0];
                miConexion.Close();
            }
            catch (Exception emd)
            {
                MessageBox.Show(emd.ToString());
            }
        }

        private void altaFiestasMenuItem_Click(object sender, EventArgs e)
        {
            if (ComprobarAbiertas(1) == 0)
            {
                NuevaFiesta nuevaFiestaVentana = new NuevaFiesta();
                ControlVentanas.ventanas.Add(nuevaFiestaVentana);
                nuevaFiestaVentana.Show();
            }
            else MessageBox.Show("Ya hay una ventana de este tipo abierta");
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            MuestraDatos();
        }

        private void bajaFiestasMenuItem_Click(object sender, EventArgs e)
        {
            if (ComprobarAbiertas(2) == 0)
            {
                EliminarFiesta nuevaEliminarFiestaVentana = new EliminarFiesta();
                ControlVentanas.ventanas.Add(nuevaEliminarFiestaVentana);
                nuevaEliminarFiestaVentana.Show();
            }
            else MessageBox.Show("Ya hay una ventana de este tipo abierta");
        }

        private void altaClientesMenuItem_Click(object sender, EventArgs e)
        {
            AltaCliente nuevaAltaClienteVentana = new AltaCliente();
            nuevaAltaClienteVentana.Show();
        }

        private void bajaClientesMenuItem_Click(object sender, EventArgs e)
        {
            if (ComprobarAbiertas(3) == 0)
            {
                BajaCliente nuevaBajaClienteVentana = new BajaCliente();
                ControlVentanas.ventanas.Add(nuevaBajaClienteVentana);
                nuevaBajaClienteVentana.Show();
            }
            else
            {
                MessageBox.Show("Ya hay una ventana de este tipo abierta");
            }
        }

        private int ComprobarAbiertas(int n)
        {
            int contadorVentanas = 0;

            if(n == 1)
            {
                foreach (var item in ControlVentanas.ventanas)
                {
                    if (item is NuevaFiesta)
                    {
                        contadorVentanas++;
                    }
                }
            }

            if (n == 2)
            {
                foreach (var item in ControlVentanas.ventanas)
                {
                    if (item is EliminarFiesta)
                    {
                        contadorVentanas++;
                    }
                }
            }

            if (n == 3)
            {
                foreach (var item in ControlVentanas.ventanas)
                {
                    if (item is BajaCliente)
                    {
                        contadorVentanas++;
                    }
                }
            }

            return contadorVentanas;
        }
    }
}
