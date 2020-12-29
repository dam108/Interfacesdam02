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
    public partial class AltaCliente : Form
    {
        SqlConnection miConexion = new SqlConnection("Data Source=.;Initial Catalog=practica09;Integrated Security=True");
        public AltaCliente()
        {
            InitializeComponent();
        }
        private void cancelar_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void guardar_Btn_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                try
                {
                    string consulta = "INSERT INTO clientes (dniCliente, nombre, apellido1, apellido2, telefono)" +
                        " VALUES (@DNI, @NOMBRE, @AP1, @AP2, @TEL)";

                    SqlCommand miSqlCommand = new SqlCommand(consulta, miConexion);

                    miConexion.Open();

                    miSqlCommand.Parameters.AddWithValue("@DNI", dni_TxtBox.Text.ToUpper());
                    miSqlCommand.Parameters.AddWithValue("@NOMBRE", nombre_TxtBox.Text);
                    miSqlCommand.Parameters.AddWithValue("@AP1", apellido1_TxtBox.Text);
                    miSqlCommand.Parameters.AddWithValue("@AP2", apellido2_TxtBox.Text);
                    miSqlCommand.Parameters.AddWithValue("@TEL", telefono_TxtBox.Text);

                    miSqlCommand.ExecuteNonQuery();

                    miConexion.Close();

                    MessageBox.Show("Se ha añadido al cliente correctamente");

                    LimpiarCampos();

                } catch(Exception eac)
                {
                    //MessageBox.Show(eac.ToString());
                    MessageBox.Show("No se puede insertar este dni en la base de datos por que ya existe");
                    if (miConexion.State.ToString() == "Open") miConexion.Close();
                    dni_TxtBox.Text = "";
                    dni_TxtBox.Focus();
                }
            }
        }
        private bool validarCampos()
        {
            if(dni_TxtBox.Text != "")
            {
                if (nombre_TxtBox.Text != "")
                {
                    if (apellido1_TxtBox.Text != "")
                    {
                        if (apellido2_TxtBox.Text != "")
                        {
                            if (telefono_TxtBox.Text != "")
                            {
                                return true;
                            }
                            else
                            {
                                MessageBox.Show("Se debe introducir un telefono");
                                telefono_TxtBox.Focus();
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Se debe introducir el segundo apellido");
                            apellido2_TxtBox.Focus();
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Se debe introducir el primer apellido");
                        apellido1_TxtBox.Focus();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Se debe introducir un nombre");
                    nombre_TxtBox.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Se debe introducir un dni");
                dni_TxtBox.Focus();
                return false;
            }
        }
        private void LimpiarCampos()
        {
            dni_TxtBox.Text = "";
            nombre_TxtBox.Text = "";
            apellido1_TxtBox.Text = "";
            apellido2_TxtBox.Text = "";
            telefono_TxtBox.Text = "";
        }
    }
}
