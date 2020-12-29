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
    public partial class NuevaFiesta : Form
    {
        SqlConnection miConexion = new SqlConnection("Data Source=.;Initial Catalog=practica09;Integrated Security=True");

        public const int NUM_MAX_AMARILLA = 15;
        public const int NUM_MAX_VIOLETA = 30;
        int sala = 0;

        public NuevaFiesta()
        {
            InitializeComponent();
            elegirSala_Lbl.Text = "Click para elegir sala";
            muestraClientes();
        }

        private void amarillaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comensales_NumericUpDown.Maximum = NUM_MAX_AMARILLA;
            elegirSala_Lbl.Text = "AMARILLA";
            sala = 1;
        }

        private void violetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comensales_NumericUpDown.Maximum = NUM_MAX_VIOLETA;
            elegirSala_Lbl.Text = "VIOLETA";
            sala = 2;
        }

        private void guardar_Btn_Click(object sender, EventArgs e)
        {
            if (ComprobacionesCampos())
            {
                if (comprobaciones(fecha_DatePicker.Value, sala))
                {
                    insertarFiesta();
                    MessageBox.Show("Se ha realizado la reserva correctamente");
                    limpiarCampos();
                }
                else
                {
                    MessageBox.Show("No puede haber dos fiestas con la misma fecha en la misma sala");
                    limpiarCampos();
                }
            }
        }

        private void muestraClientes()
        {
            try { 
                string consulta = "SELECT *, CONCAT(nombre,' ',apellido1,' ',apellido2,' ','(', clientes.dniCliente ,')') AS ClienteCompleto FROM CLIENTES";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, miConexion);

                using (adaptador)
                {
                    DataTable clientesTabla = new DataTable();
                    adaptador.Fill(clientesTabla);
                    clientes_comboBox.DataSource = clientesTabla.DefaultView;
                    clientes_comboBox.DisplayMember = "ClienteCompleto";
                    clientes_comboBox.ValueMember = "dniCliente";
                    clientes_comboBox.SelectedIndex = -1;
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        private void insertarFiesta()
        {
            string insercion = "INSERT INTO reservas (fecha, sala, invitados, dniCliente) VALUES (@fecha, @sala, @invitados, @DC)";
            SqlCommand miSqlCommand = new SqlCommand(insercion, miConexion);
            miConexion.Open();
            miSqlCommand.Parameters.AddWithValue("@fecha", fecha_DatePicker.Value.Date);
            miSqlCommand.Parameters.AddWithValue("@sala", sala);
            miSqlCommand.Parameters.AddWithValue("@invitados", comensales_NumericUpDown.Value);
            miSqlCommand.Parameters.AddWithValue("@DC", clientes_comboBox.SelectedValue);
            miSqlCommand.ExecuteNonQuery();
            miConexion.Close();

            muestraClientes();
        }

        private bool comprobaciones(DateTime fecha, int s)
        {
            bool resultado = false;
            
            try
            {
                string consulta = "SELECT * FROM reservas WHERE fecha=@Fecha AND sala=@Sala";
                SqlCommand miSqlCommand = new SqlCommand(consulta, miConexion);
                SqlDataAdapter miAdaptador = new SqlDataAdapter(miSqlCommand);

                using (miAdaptador)
                {
                    miSqlCommand.Parameters.AddWithValue("@Fecha", fecha.ToString("dd/MM/yyyy"));
                    miSqlCommand.Parameters.AddWithValue("@Sala", s);
                    DataTable consultaComprobacionesTabla = new DataTable();
                    miAdaptador.Fill(consultaComprobacionesTabla);
                    if (consultaComprobacionesTabla.Rows.Count > 0) resultado = false;
                    else resultado = true;
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
            return resultado;
        }

        private void limpiarCampos()
        {
            fecha_DatePicker.Value = DateTime.Now;
            clientes_comboBox.SelectedIndex = -1;
            comensales_NumericUpDown.Maximum = 0;
            elegirSala_Lbl.Text = "Click para elegir sala";
            sala = 0;
        }

        private void cancelar_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ComprobacionesCampos()
        {
            if (sala == 1 || sala == 2)
            {
                if(comensales_NumericUpDown.Value > 0) 
                {
                    if(clientes_comboBox.SelectedIndex >= 0)
                    {
                        return true;
                    }
                    else MessageBox.Show("Debes seleccionar el cliente en la lista desplegable");
                }
                else MessageBox.Show("Debes seleccionar el numero de invitados");
            }
            else MessageBox.Show("Debes elegir una sala, haz click derecho en la etiqueta elegir sala");

            return false;
        }

        private void NuevaFiesta_Activated(object sender, EventArgs e)
        {
            muestraClientes();
        }

        private void NuevaFiesta_FormClosed(object sender, FormClosedEventArgs e)
        {
            for (int i = 0; i < ControlVentanas.ventanas.Count; i++)
            {
                if (ControlVentanas.ventanas[i] is NuevaFiesta) ControlVentanas.ventanas.RemoveAt(i);
            }
        }
    }
}
