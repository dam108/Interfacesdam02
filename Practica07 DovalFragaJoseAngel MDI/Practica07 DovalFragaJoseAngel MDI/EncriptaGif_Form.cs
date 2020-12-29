using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Practica07_DovalFragaJoseAngel_MDI
{
    public partial class EncriptaGif_Form : Form
    {
        private List<ImagenGIF> imagenes;
        BindingSource imagenesBS;

        public EncriptaGif_Form()
        {
            InitializeComponent();
            imagenes = new List<ImagenGIF>();
            imagenesBS = new BindingSource();
            imagenesBS.DataSource = imagenes;
            gif_ListBox.DataSource = imagenesBS;
            gif_ListBox.DisplayMember = "NombreMostrar";
        }

        private void EncriptarGif_Btn_Click(object sender, EventArgs e)
        {
            finalEncriptar_Lbl.Visible = false;
            OpenFileDialog elegirArchivo = new OpenFileDialog();

            elegirArchivo.DefaultExt = ".gif";
            elegirArchivo.Filter = "GIF Files (*.gif)|*.gif";
            elegirArchivo.ShowDialog();
            string ruta = elegirArchivo.FileName;

            if (ruta != "")
            {
                try
                {
                    if (!existeImagen(ruta))
                    {
                        string nombre = Path.GetFileName(ruta);

                        if (!comprobarSiEstaEncriptado(ruta))
                        {

                            barraDeProgreso.Value = 0;
                            imagenes.Add(new ImagenGIF(nombre, ruta, "( encriptado)"));
                            barraDeProgreso.Value = 100;
                            finalEncriptar_Lbl.Visible = true;
                        }
                        else
                        {
                            barraDeProgreso.Value = 0;
                            encriptarDesencriptaImagen(ruta);
                            imagenes.Add(new ImagenGIF(nombre, ruta, "( encriptado)"));
                            barraDeProgreso.Value = 100;
                            finalEncriptar_Lbl.Visible = true;
                        }
                        //se actualizan vinculos
                        actualizarVinculos();
                        gif_ListBox.ClearSelected();
                    }
                    else
                    {
                        advertencia("Esta imagen ya esta en la lista");
                    }
                }
                catch (ArgumentException)
                {
                    advertencia("No se puede dejar vacia la seleccion de imagen");
                }
            }
        }

        private bool existeImagen(string ruta)
        {
            foreach (var item in imagenes)
            {
                if (item.Path == ruta) return true;
                //return false;
            }
            return false;
        }

        private void actualizarVinculos()
        {
            imagenesBS.ResetBindings(false);
        }

        private void advertencia(string txt)
        {
            MessageBox.Show(txt, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void encriptarDesencriptaImagen(string ruta) 
        {
            //leer los Bytes y guardarlos en una matriz de bytes
            Byte[] archivoBytes = File.ReadAllBytes(ruta);
            // cambiar primer byte por tercer byte
            // guardamos el byte 3
            Byte tres = archivoBytes[2];
            //copiamos lo que hay en el byte 1 a la posicion 3
            archivoBytes[2] = archivoBytes[0];
            // lo guardado del 3 la copiamos a la posicion 1
            archivoBytes[0] = tres;
            //Borramos el archivo
            File.Delete(ruta);
            // guardar bytes en un archivo nuevo con el mismo nombre y ruta
            File.WriteAllBytes(ruta, archivoBytes);
        }

        private void desenciptar_Btn_Click(object sender, EventArgs e)
        {
            finalEncriptar_Lbl.Visible = false;
            if(gif_ListBox.SelectedIndex >= 0)
            {
                if (!comprobarSiEstaEncriptado(imagenes[gif_ListBox.SelectedIndex].Path))
                {
                    barraDeProgreso.Value = 0;
                    encriptarDesencriptaImagen(imagenes[gif_ListBox.SelectedIndex].Path);
                    imagenes[gif_ListBox.SelectedIndex].NombreMostrar = imagenes[gif_ListBox.SelectedIndex].Nombre;
                    actualizarVinculos();
                    gif_Picturebox.Image = new Bitmap(new MemoryStream(File.ReadAllBytes(imagenes[gif_ListBox.SelectedIndex].Path)));
                    barraDeProgreso.Value = 100;
                    finalEncriptar_Lbl.Visible = true;
                }
                else
                {
                    advertencia("Este archivo ya esta desencriptado");
                }
            }
            else
            {
                advertencia("Se debe seleccionar una imagen de la lista para desencriptar");
            }
        }

        private void gif_ListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (gif_ListBox.SelectedIndex >= 0)
            {
                Image oldPic = gif_Picturebox.Image;

                try
                {
                    gif_Picturebox.Image = new Bitmap(new MemoryStream(File.ReadAllBytes(imagenes[gif_ListBox.SelectedIndex].Path)));
                }
                catch (ArgumentException)
                {
                    encriptarDesencriptaImagen(imagenes[gif_ListBox.SelectedIndex].Path);
                    gif_Picturebox.Image = new Bitmap(new MemoryStream(File.ReadAllBytes(imagenes[gif_ListBox.SelectedIndex].Path)));
                    encriptarDesencriptaImagen(imagenes[gif_ListBox.SelectedIndex].Path);
                }

                if (oldPic != null ) oldPic.Dispose();
            }
        }

        private void encriptarCarpeta_Btn_Click(object sender, EventArgs e)
        {
            finalEncriptar_Lbl.Visible = false;
            imagenes.Clear();
            actualizarVinculos();

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                String [] archivos = Directory.GetFiles(fbd.SelectedPath, "*.gif",SearchOption.AllDirectories);

                foreach (var item in archivos)
                {
                    barraDeProgreso.Value = 0;
                    string nombre = Path.GetFileName(item);
                    string path = item;

                    if (!comprobarSiEstaEncriptado(item))
                    {
                        imagenes.Add(new ImagenGIF(nombre, path, "( encriptado)"));
                    }
                    else
                    {
                        encriptarDesencriptaImagen(path);
                        Console.WriteLine(path);

                        imagenes.Add(new ImagenGIF(nombre, path, "( encriptado)"));
                    }
                    barraDeProgreso.Value = 100;
                    finalEncriptar_Lbl.Visible = true;
                }
                actualizarVinculos();
            }
        }

        private bool comprobarSiEstaEncriptado(string ruta)
        {
            if (File.Exists(ruta))
            {
                Byte[] bytes = File.ReadAllBytes(ruta);

                if (bytes[0] == 71)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        private void mostrar_Btn_Click(object sender, EventArgs e)
        {
            finalEncriptar_Lbl.Visible = false;
            if (gif_ListBox.SelectedIndex >= 0)
            {
                System.Diagnostics.Process.Start(imagenes[gif_ListBox.SelectedIndex].Path);
            }
            else
            {
                advertencia("Debes seleccionar una imagen");
            }
        }

    }
}
