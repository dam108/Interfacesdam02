using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Net.Mail;

namespace Practica03_Extra_DovalFragaJA_ListaTlf
{
    public partial class Formulario : Form
    {
        //variables globales
        List<Persona> contactos;
        BindingSource listaContactosBS;
        Image image;

        public Formulario()
        {
            InitializeComponent();
        }

        //
        // Eventos
        //

        // Evento para cuanda carga el formulario
        private void Formulario_Load(object sender, EventArgs e)
        {
            // inciamos la lista de contactos y creamos dos contactos
            contactos = new List<Persona>();
            contactos.Add(new Persona("Jose Doval", "981982456", "joseDoval@gmail.com", "Jose Doval.png"));
            contactos.Add(new Persona("Juan", "981775645", "juan@gmail.com", "Juan.png"));

            // Vinculamos la lista de contactos con el ListBox
            listaContactosBS = new BindingSource();
            listaContactosBS.DataSource = contactos;
            contactosListBox.DataSource = listaContactosBS;

            //listaContactosBS.AllowNew = true; // esto solo hace falta si usamos el boton añadir nuevo que trae el navigator por defecto
            contactosListBox.DisplayMember = "nombre";
            listaNavigator.BindingSource = this.listaContactosBS;
            
            // visibilidad en botones del navigator
            NuevoButton.Enabled = true;
            modificarButton.Enabled = true;
            eliminarButton.Enabled = true;
            anadirButton.Enabled = false;
            anadirButton.Visible = false;


        }

        // Evento para cuando seleccionamos un item del listBox
        private void contactosListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n = contactosListBox.SelectedIndex;
            MostrarCampos(n);
        }

        // Evento eliminar item seleccionado 
        private void eliminarButton_Click(object sender, EventArgs e)
        {
            int n = contactosListBox.SelectedIndex;
            EliminarDatosEnLista(n);
        }

        // Evento para modificar un contacto de la lista
        private void modificarButton_Click(object sender, EventArgs e)
        {
            int n = contactosListBox.SelectedIndex;
            if (n >= 0)
            {
                AdvertenciaDown();
                if (ComprobarCampos())
                {
                    ModificarDatosEnLista(n);
                    LimpiarCampos();
                    contactosListBox.Focus();
                }
            }
            else
            {
                AdvertenciaUp("No hay contactos que modificar!");
            }

        }

        // Evento para el boton nuevo
        private void NuevoButton_Click(object sender, EventArgs e)
        {
            HabilitarCajas();
            AdvertenciaDown();
            LimpiarCampos();
            nombreTextBox.Focus();
            NuevoOff();
        }

        // Evento cuando haces click en el picture Box para cargar una imagen desde el disco
        private void fotoPictureBox_Click(object sender, EventArgs e)
        {
            CargarImagen();
        }

        // Evento para añadir un contacto nuevo con el boton añadir
        private void anadirButton_Click(object sender, EventArgs e)
        {
            bool check = ComprobarCampos();
            bool duplicado = ExisteNombre(nombreTextBox.Text);
            if (duplicado)
            {
                AdvertenciaUp("Este contacto ya existe!");
            }
            else
            {
                if (check)
                {
                    AdvertenciaDown();
                    GuardarDatosEnLista();
                    AnadirOff();
                }
            }
        }

        // Evento Keypress en el textbox telefono que no deja escribir nada que no sea un numero
        private void telefonoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); // solo deja pulsar numeros 
        }

        //
        // Metodos
        //

        // Metodo para Eliminar Datos en lista
        private void EliminarDatosEnLista(int n)
        {
            if (n >= 0)
            {
                string name, nameImg;
                name = nombreTextBox.Text;
                nameImg = name + ".png";

                BorrarImagen(nameImg);
                contactos.RemoveAt(n);

                listaContactosBS.ResetBindings(false);

                LimpiarCampos();
            }
            else
            {
                AdvertenciaUp("No hay contactos a eliminar");
            }

        }

        // Metodo para modificar Datos en lista
        private void ModificarDatosEnLista(int n)
        {
            string name, tel, em, nameImg;
            name = nombreTextBox.Text;
            tel = telefonoTextBox.Text;
            em = emailTextBox.Text;
            nameImg = name + ".png";

            string oldImg = contactos[n].NombreFoto;
            BorrarImagen(oldImg);

            GuardarImagen(nameImg);
            contactos[n].Nombre = name;
            contactos[n].Telefono = tel;
            contactos[n].Email = em;
            contactos[n].NombreFoto = nameImg;

            listaContactosBS.ResetBindings(false);
        }

        // Metodo para mostrar los campos del item seleccionado
        private void MostrarCampos(int n)
        {
            if (n >= 0)
            {
                AdvertenciaDown();
                nombreTextBox.Text = contactos[n].Nombre;
                telefonoTextBox.Text = contactos[n].Telefono;
                emailTextBox.Text = contactos[n].Email;
                string foto = contactos[n].NombreFoto;
                // en vez de cargar las imagenes directamente en la variable , hacemos un stream para luego poder borrarlo al modificar
                using (FileStream fs = new FileStream(@"..\..\..\imgs\" + foto, FileMode.Open))
                {
                    fotoPictureBox.Image = Image.FromStream(fs);
                    fs.Close();
                }
            }
            else
            {
                //advertimos de que no hay ningun contacto
                AdvertenciaUp("No hay ningun contacto , pulsa nuevo para crear uno");
            }
        }

        // Metodo para cambiar el boton nuevo por añadir
        private void NuevoOff()
        {
            NuevoButton.Enabled = false;
            NuevoButton.Visible = false;
            anadirButton.Enabled = true;
            anadirButton.Visible = true;
            modificarButton.Enabled = false;
            eliminarButton.Enabled = false;
        }

        // Metodo para cambiar el boton añadir por nuevo
        private void AnadirOff()
        {
            NuevoButton.Enabled = true;
            NuevoButton.Visible = true;
            anadirButton.Enabled = false;
            anadirButton.Visible = false;
            modificarButton.Enabled = true;
            eliminarButton.Enabled = true;
        }

        // Metodo para limpiar todos los campos de formulario antes de agregar un contacto nuevo
        private void LimpiarCampos()
        {
            nombreTextBox.Text = "";
            telefonoTextBox.Text = "";
            emailTextBox.Text = "";
            image = Properties.Resources.FotoLimpiar;
            fotoPictureBox.Image = null;
            fotoPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            fotoPictureBox.BackgroundImage = image;

        }

        // Metodo que abre un explorador de archivos y devuelve una imagen 
        private void CargarImagen()
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\";
            getImage.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpef|PNG (*.png)|*.png|GIF (*.gif)|*.gif";
            if (getImage.ShowDialog() == DialogResult.OK)
            {
                fotoPictureBox.Image = Image.FromFile(getImage.FileName);
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna imagen", "");
            }
        }

        // Metodo para guardar los datos de un nuevo contacto en la lista de contactos
        private void GuardarDatosEnLista()
        {
            string name, tel, em, nameImg;
            name = nombreTextBox.Text;
            tel = telefonoTextBox.Text;
            em = emailTextBox.Text;
            nameImg = name + ".png";
            GuardarImagen(nameImg);
            contactos.Add(new Persona(name, tel, em, nameImg));

            listaContactosBS.ResetBindings(false);
        }

        // Metodo para guardar una imagen en la carpetan img dentro del proyecto
        private void GuardarImagen(string nameImg)
        {
            if (System.IO.File.Exists(@"..\..\..\imgs\" + nameImg))
            {
                System.IO.File.Delete(@"..\..\..\imgs\" + nameImg);
            }


            fotoPictureBox.Image.Save(@"..\..\..\imgs\" + nameImg);

        }

        //metodo para borrar una imagen de la carpeta img dentro del proyecto
        private void BorrarImagen(string nameImg)
        {
            if (System.IO.File.Exists(@"..\..\..\imgs\" + nameImg))
            {
                System.IO.File.Delete(@"..\..\..\imgs\" + nameImg);
            }
        }

        // Metodo para comprobar que todos los campos estan cubiertos
        private bool ComprobarCampos()
        {
            if (ComprobarNombre() && ComprobarTelefono() && ComprobarEmail(emailTextBox.Text) && ComprobarFoto())
            {
                AdvertenciaDown();
                return true;
            }
            else
            {
                return false;
            }
        }

        // Metodo para comprobar el pictureBox de la foto
        private bool ComprobarFoto()
        {
            if (fotoPictureBox.Image != null)
            {
                AdvertenciaDown();
                return true;
            }
            else
            {
                AdvertenciaUp("Debe seleccionar una imagen");
                return false;
            }
        }

        // Metodo para comprobar el textBox del email
        private bool ComprobarEmail(string correo)
        {
            try
            {
                MailAddress m = new MailAddress(correo);
                AdvertenciaDown();
                return true;
            }
            catch (FormatException)
            {
                AdvertenciaUp("Escriba un email valido! (nombre@dominio.com)");
                emailTextBox.Focus();
                return false;
            }
            catch (ArgumentException)
            {
                AdvertenciaUp("Escriba un email valido! (nombre@dominio.com)");
                emailTextBox.Focus();
                return false;
            }
        }

        // Metodo para comprobar el textBox del telefono
        private bool ComprobarTelefono()
        {
            if (telefonoTextBox.Text.Length == 9 && CajaNumValida(telefonoTextBox.Text))
            {
                return true;
            }
            else
            {
                AdvertenciaUp("Se debe introducir un telefono valido! (605846532)");
                telefonoTextBox.Focus();
                return false;
            }
        }

        // Metodo para comprobar que el cuadro del nombre no esta vacio
        private bool ComprobarNombre()
        {
            if (nombreTextBox.Text != "")
            {
                return true;
            }
            else
            {
                AdvertenciaUp("Se debe introducir un nombre valido! (David Perez)");
                nombreTextBox.Focus();
                return false;
            }
        }

        //Metodo para comprobar si el nombre existe o no
        private bool ExisteNombre(string name)
        {
            Persona momentaneo = new Persona(name, "", "", "");
            if (contactos.Contains(momentaneo)) return true;
            else return false;
        }

        // Metodos para comprobar si el valor introducido es numerico
        private bool CajaNumValida(string txt)
        {
            for (int i = 0; i < txt.Length; i++)
            {
                char a = txt[i];
                if (!char.IsDigit(a)) return false;
            }
            return true;
        }

        // Metodos Advertencias
        private void AdvertenciaDown()
        {
            advertenciaLbl.Visible = false;
        }
        private void AdvertenciaUp(string txt)
        {
            advertenciaLbl.Visible = true;
            advertenciaLbl.BackColor = Color.OrangeRed;
            advertenciaLbl.Text = txt;
        }

        // Metodos para habilitar y deshabilitar cajas de texto
        private void HabilitarCajas()
        {
            nombreTextBox.Enabled = true;
            telefonoTextBox.Enabled = true;
            emailTextBox.Enabled = true;
            fotoPictureBox.Enabled = true;
        }
        private void DeshabilitarCajas()
        {
            nombreTextBox.Enabled = false;
            telefonoTextBox.Enabled = false;
            emailTextBox.Enabled = false;
            fotoPictureBox.Enabled = false;
        }
    }
}
