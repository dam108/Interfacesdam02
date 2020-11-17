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
        string nombreArchivo;
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

            elegirArchivo.ShowDialog();
            string leerArchivo = File.ReadAllText(elegirArchivo.FileName);
            nombreArchivo = elegirArchivo.FileName;
            rutaArchivoOriginal = elegirArchivo.FileName;
            mostrarTexto_RichTextBox.Text = leerArchivo;
        }

        private void buscar_Btn_Click(object sender, EventArgs e)
        {

            if (mostrarTexto_RichTextBox.Text != "")
            {
                if(palabraBuscar_TextBox.Text != "")
                {
                    int finalWhile = 0;

                    while(finalWhile != mostrarTexto_RichTextBox.Text.Length)
                    {
                        int startindex = 0;
                        if (palabraBuscar_TextBox.Text.Length > 0)
                            startindex = EncuentraMiTexto(palabraBuscar_TextBox.Text.Trim(), start, mostrarTexto_RichTextBox.Text.Length);
                        // If string was found in the RichTextBox, highlight it
                        if (startindex >= 0)
                        {
                            // Set the highlight color as red
                            mostrarTexto_RichTextBox.SelectionColor = Color.Red;
                            // Find the end index. End Index = number of characters in textbox
                            int endindex = palabraBuscar_TextBox.Text.Length;
                            // Highlight the search string
                            mostrarTexto_RichTextBox.Select(startindex, endindex);
                            // mark the start position after the position of
                            // last search string
                            start = startindex + endindex;

                            // añadimos la linea al nuestra lista par luego mostrar en el listBox
                            lineas.Add( "Linea: " + (mostrarTexto_RichTextBox.GetLineFromCharIndex(startindex) + 1));
                        }
                        finalWhile++;
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
            // Unselect the previously searched string
            //if (posicionInicial > 0 && posicionFinal > 0 && indexOfSearchText >= 0)
            //{
            //    mostrarTexto_RichTextBox.Undo();
            //}

            // Set the return value to -1 by default.
            int devolverValor = -1;

            // A valid starting index should be specified.
            // if indexOfSearchText = -1, the end of search
            if (posicionInicial >= 0 && indexOfSearchText >= 0)
            {
                // A valid ending index
                if (posicionFinal > posicionInicial || posicionFinal == -1)
                {
                    // Find the position of search string in RichTextBox
                    indexOfSearchText = mostrarTexto_RichTextBox.Find(textEncontrar, posicionInicial, posicionFinal, RichTextBoxFinds.None);
                    // Determine whether the text was found in richTextBox1.
                    if (indexOfSearchText != -1)
                    {
                        // Return the index to the specified search text.
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
            mostrarTexto_RichTextBox.Undo();
            lineas.Clear();
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
            if(mostrarLineas_ListBox.SelectedIndex >= 0)
            {
                int n = Int16.Parse(mostrarLineas_ListBox.SelectedItem.ToString().Substring(7));
                MessageBox.Show(mostrarLineas_ListBox.SelectedItem.ToString().Substring(7));
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

                texto.RemoveAt(n-1);

                File.WriteAllLines(rutaArchivoOriginal, texto.ToArray());

            }
        }

        private void copiarLineaAOtroArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
