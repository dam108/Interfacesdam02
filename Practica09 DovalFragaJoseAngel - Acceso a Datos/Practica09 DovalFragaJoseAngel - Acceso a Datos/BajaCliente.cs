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
    public partial class BajaCliente : Form
    {

        SqlConnection miConexion = new SqlConnection("Data Source=.;Initial Catalog=practica09;Integrated Security=True");

        public BajaCliente()
        {
            InitializeComponent();
            muestraClientes();
        }

        private void eliminar_Btn_Click(object sender, EventArgs e)
        {
            if (clientesComboBox.SelectedIndex >= 0)
            {
                try
                {
                    string consultaEliminar = "DELETE FROM clientes WHERE dniCliente=@ID";
                    SqlCommand miSqlCommand = new SqlCommand(consultaEliminar, miConexion);

                    miConexion.Open();

                    miSqlCommand.Parameters.AddWithValue("@ID", clientesComboBox.SelectedValue);
                    miSqlCommand.ExecuteNonQuery();

                    miConexion.Close();

                    muestraClientes();

                    MessageBox.Show("Se ha eliminado el cliente correctamente.");

                }
                catch(Exception eec)
                {
                    MessageBox.Show("Este cliente tiene reservas hechas primero elimina sus reservas antes de poder eliminar al cliente");
                    if (miConexion.State.ToString() == "Open") miConexion.Close();
                }
            }
            else MessageBox.Show("Debes seleccionar una cliente a eliminar");

        }

        private void muestraClientes()
        {
            try
            {
                string consulta = "SELECT dniCliente, CONCAT(nombre,' ',apellido1,' ', apellido2, ' - TLF: ', telefono)" +
                    " AS DATOSCLIENTE FROM clientes; ";

                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, miConexion);

                using (adaptador)
                {
                    DataTable clientesTabla = new DataTable();
                    adaptador.Fill(clientesTabla);
                    clientesComboBox.DataSource = clientesTabla.DefaultView;
                    clientesComboBox.DisplayMember = "DATOSCLIENTE";
                    clientesComboBox.ValueMember = "dniCliente";
                    clientesComboBox.SelectedIndex = -1;
                }

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        private void BajaCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            for (int i = 0; i < ControlVentanas.ventanas.Count; i++)
            {
                if (ControlVentanas.ventanas[i] is BajaCliente) ControlVentanas.ventanas.RemoveAt(i);
            }
        }
    }
}
