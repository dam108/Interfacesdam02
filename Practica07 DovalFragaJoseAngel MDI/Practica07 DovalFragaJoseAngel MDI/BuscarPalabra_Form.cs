using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Practica07_DovalFragaJoseAngel_MDI
{
    public partial class BuscarPalabra_Form : Form
    {
        List<String> lineas;
        BindingSource lineasBS = new BindingSource();
        string rutaArchivoOriginal;
        int start = 0;
        int indexOfSearchText = 0;

        public BuscarPalabra_Form()
        {
            InitializeComponent();
            lineas = new List<string>();

            lineasBS.DataSource = lineas;
            mostrarLineas_ListBox.DataSource = lineasBS;
        }

        private void abrirArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog elegirArchivo = new OpenFileDialog();
            if(elegirArchivo != null)
            {
                try
                {
                    elegirArchivo.ShowDialog();
                    string leerArchivo = File.ReadAllText(elegirArchivo.FileName);
                    rutaArchivoOriginal = elegirArchivo.FileName;
                    mostrarTexto_RichTextBox.Text = leerArchivo;
                    //MessageBox.Show(nombreArchivo);
                }
                catch(ArgumentException)
                {
                    advertencia("no se puede dejar vacio la seleccion de la imagen");
                }
            }
        }

        private void buscar_Btn_Click(object sender, EventArgs e)
        {

            if (mostrarTexto_RichTextBox.Text != "")
            {
                if (palabraBuscar_TextBox.Text != "")
                {
                    int finalWhile = 0;

                    // buscamos cada palabra en el texto, lo resaltamos

                    while (finalWhile != mostrarTexto_RichTextBox.Text.Length)
                    {
                        int startindex = 0;
                        if (palabraBuscar_TextBox.Text.Length > 0)
                            startindex = EncuentraMiTexto(palabraBuscar_TextBox.Text.Trim(), start, mostrarTexto_RichTextBox.Text.Length);
                        // si encontramos el texto lo resaltamos
                        if (startindex >= 0)
                        {
                            // creamos el resaltado en rojo
                            mostrarTexto_RichTextBox.SelectionColor = Color.Red;
                            // encontramos el final del index que es igual que el numero de caracteres en el textbox
                            int endindex = palabraBuscar_TextBox.Text.Length;
                            // resaltamos la palabra en rojo
                            mostrarTexto_RichTextBox.Select(startindex, endindex);
                            // igualamos la variable start con la posicion anterior para seguir desde aqui
                            start = startindex + endindex;

                            // añadimos la linea al nuestra lista par luego mostrar en el listBox
                            //lineas.Add("Linea: " + (mostrarTexto_RichTextBox.GetLineFromCharIndex(startindex) + 1));
                        }
                        finalWhile++;
                    }

                    // buscamos la palabra en el documento y guardamos su linea
                    using (var sr = new StreamReader(rutaArchivoOriginal))
                    {
                        int index = 0;
                        while (!sr.EndOfStream)
                        {
                            index++;
                            var line = sr.ReadLine();
                            if (String.IsNullOrEmpty(line)) continue;
                            if (line.IndexOf(palabraBuscar_TextBox.Text, StringComparison.CurrentCultureIgnoreCase) >= 0)
                            {

                                lineas.Add("Linea: " + index);
                            }
                        }
                    }
                        actualizarBinding();
                }
                else
                {
                    advertencia("Escriba una palabra a buscar");
                }
            }
            else
            {
                advertencia("Seleccione un archivo txt con click derecho en la caja grande primero");
            }
        }

        private int EncuentraMiTexto(string textEncontrar, int posicionInicial, int posicionFinal)
        {

            // establecemos el valor por defecto de lo que vamos a devolver en -1
            int devolverValor = -1;

            // tenemos que especificar un valor de comienzo valido 
            // si el valor de comienzo es -1 se acaba la busqueda
            if (posicionInicial >= 0 && indexOfSearchText >= 0)
            {
                // un valor valido para la posicion final
                if (posicionFinal > posicionInicial || posicionFinal == -1)
                {
                    // encontramos la posicion de la cadena buscada en el richBox
                    indexOfSearchText = mostrarTexto_RichTextBox.Find(textEncontrar, posicionInicial, posicionFinal, RichTextBoxFinds.None);
                    // determinamos si el texto fue encontrado en el richBox
                    if (indexOfSearchText != -1)
                    {
                        // devolvemos el valor del index encontrado
                        devolverValor = indexOfSearchText;
                    }
                }
            }
            return devolverValor;
        }

        // Reseteamos valores cuando se introduce otra palabra a buscar
        private void palabraBuscar_TextBox_TextChanged(object sender, EventArgs e)
        {
            start = 0;
            indexOfSearchText = 0;
            mostrarTexto_RichTextBox.SelectAll();
            mostrarTexto_RichTextBox.SelectionColor = Color.Black;
            lineas.Clear();
            actualizarBinding();
        }

        private void advertencia(string txt)
        {
            MessageBox.Show(txt, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void actualizarBinding()
        {
            lineasBS.ResetBindings(false);
        }

        private void borrarLineaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mostrarLineas_ListBox.SelectedIndex >= 0)
            {
                int n = Int16.Parse(mostrarLineas_ListBox.SelectedItem.ToString().Substring(7));
                List<String> texto = new List<string>();

                //Abrir y leer un archivo de texto linea a linea

                try
                {
                    StreamReader sr = new StreamReader(rutaArchivoOriginal);

                    String linea;


                    while ((linea = sr.ReadLine()) != null)
                    {
                        texto.Add(linea);
                    }

                    sr.Close();
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("No se ha encontrado el archivo");
                }

                if (n >= 0)
                {
                    texto.RemoveAt(n - 1);
                    lineas.Clear();
                    palabraBuscar_TextBox.Clear();
                    actualizarBinding();
                    File.WriteAllLines(rutaArchivoOriginal, texto.ToArray());
                    string leerArchivo = File.ReadAllText(rutaArchivoOriginal);
                    mostrarTexto_RichTextBox.Text = leerArchivo;
                }
                else
                {
                    advertencia("No hay una linea seleccionada para borrar");
                }

            }
        }

        private void copiarLineaAOtroArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int n = Int16.Parse(mostrarLineas_ListBox.SelectedItem.ToString().Substring(7));
            int linea = n - 1;

            try
            {
                // abrimos el archivo del que queremos leer
                string[] datos = File.ReadAllLines(rutaArchivoOriginal);

                // sacamos el nombre del archivo de su ruta 
                string nombreArchivo = sacarNombre(rutaArchivoOriginal);

                // guardamos la linea en el archivo y si no existe lo creamos
                // se va guardar en la carpeta debug
                File.AppendAllText("lineas" + nombreArchivo, datos[linea]);
                MessageBox.Show("Se ha guardado la linea correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                Console.WriteLine("No se ha encontrado el archivo");
            }
        }

        private string sacarNombre(string path)
        {
             return Path.GetFileName(path);
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}