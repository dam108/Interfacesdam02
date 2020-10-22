using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace Practica03_DovalFragaJA_ListaTelefonica
{
    public partial class Formulario : Form
    {
        //variables globales
        List <Persona> contactos;
        BindingSource listaContactosBS;
        Image image;

        public Formulario()
        {
            InitializeComponent();

            // inciamos la lista de contactos y creamos dos contactos
            contactos = new List<Persona>();

            // Vinculamos la lista de contactos con el ListBox
            listaContactosBS = new BindingSource();
            listaContactosBS.DataSource = contactos;
            contactosListBox.DataSource = listaContactosBS;
            contactosListBox.DisplayMember = "nombre";

            //advertimos de que no hay ningun contacto
            AdvertenciaUp("No hay ningun contacto , pulsa nuevo para crear uno");

            // deshabilitamos cajas de texto
            DeshabilitarCajas();
        }

        // eliminar item seleccionado 
        private void eliminarButton_Click(object sender, EventArgs e)
        {
            int n = contactosListBox.SelectedIndex;
            EliminarDatosEnLista(n);
        }

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

        // Evento para cuando seleccionamos un item del listBox
        private void contactosListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n = contactosListBox.SelectedIndex;
            MostrarCampos(n);
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

        // Evento para el boton nuevo
        private void NuevoButton_Click(object sender, EventArgs e)
        {
            HabilitarCajas();
            AdvertenciaDown();
            LimpiarCampos();
            nombreTextBox.Focus();
            NuevoOff();
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

        // Evento cuando haces click en el picture Box para cargar una imagen desde el disco
        private void fotoPictureBox_Click(object sender, EventArgs e)
        {
            CargarImagen();
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
           if (ComprobarNombre() && ComprobarTelefono() && ComprobarEmail() && ComprobarFoto())
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
            if(fotoPictureBox.Image != null)
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
        private bool ComprobarEmail() 
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(emailTextBox.Text, expresion))
            {
                if (Regex.Replace(emailTextBox.Text, expresion, String.Empty).Length == 0)
                {
                    AdvertenciaDown();
                    return true;
                }
                else
                {
                    AdvertenciaUp("Escriba un email valido! (nombre@dominio.com)");
                    emailTextBox.Focus();
                    return false;
                }
            }
            else
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
            string txt = name;
            foreach (var x in contactos)
            {
                if(x.Nombre == txt)
                {
                    return true;
                }
            }
            return false;
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

        // Advertencia
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

        // habilitar y deshabilitar cajas de texto
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

        // Evento Keypress en el textbox telefono que no deja escribir nada que no sea un numero
        private void telefonoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); // solo deja pulsar numeros 
        }
    }
}
