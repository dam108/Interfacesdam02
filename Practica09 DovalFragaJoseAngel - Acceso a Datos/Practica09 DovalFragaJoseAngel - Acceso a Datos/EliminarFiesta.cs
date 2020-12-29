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
    public partial class EliminarFiesta : Form
    {
        //Conexion con SQL
        SqlConnection miConexion = new SqlConnection("Data Source=.;Initial Catalog=practica09;Integrated Security=True");

        public EliminarFiesta()
        {
            InitializeComponent();
            muestraFiestas();
        }

        private void muestraFiestas()
        {

            try
            {
                string consulta = "SELECT codReserva, " +
                    "CASE WHEN sala = 1 THEN CONCAT(fecha, ' - ', nombre,' ',apellido1,' ',apellido2, ' - SALA AMARILLA')" +
                    "WHEN sala = 2 THEN CONCAT(fecha, ' - ', nombre,' ',apellido1,' ',apellido2, ' - SALA VIOLETA') END " +
                    "AS INFOFIESTA FROM reservas INNER JOIN clientes ON reservas.dniCliente = clientes.dniCliente; ";

                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, miConexion);

                using (adaptador)
                {
                    DataTable clientesTabla = new DataTable();
                    adaptador.Fill(clientesTabla);
                    eliminarFiesta_ComboBox.DataSource = clientesTabla.DefaultView;
                    eliminarFiesta_ComboBox.DisplayMember = "INFOFIESTA";
                    eliminarFiesta_ComboBox.ValueMember = "codReserva";
                    eliminarFiesta_ComboBox.SelectedIndex = -1;
                }

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }

        }

        private void eliminarFiesta_Btn_Click(object sender, EventArgs e)
        {
            if(eliminarFiesta_ComboBox.SelectedIndex >= 0)
            {
                //MessageBox.Show(eliminarFiesta_ComboBox.SelectedValue.ToString());

                string consultaEliminar = "DELETE FROM reservas WHERE codReserva=@ID";
                SqlCommand miSqlCommand = new SqlCommand(consultaEliminar, miConexion);

                miConexion.Open();

                miSqlCommand.Parameters.AddWithValue("@ID", eliminarFiesta_ComboBox.SelectedValue);
                miSqlCommand.ExecuteNonQuery();

                miConexion.Close();

                muestraFiestas();

                MessageBox.Show("Se ha eliminado la fiesta correctamente.");

            } 
            else MessageBox.Show("Debes seleccionar una fiesta a eliminar");
        }

        private void EliminarFiesta_Activated(object sender, EventArgs e)
        {
            muestraFiestas();
        }

        private void EliminarFiesta_FormClosed(object sender, FormClosedEventArgs e)
        {
            for (int i = 0; i < ControlVentanas.ventanas.Count; i++)
            {
                if (ControlVentanas.ventanas[i] is EliminarFiesta) ControlVentanas.ventanas.RemoveAt(i);
            }
        }
    }
}
