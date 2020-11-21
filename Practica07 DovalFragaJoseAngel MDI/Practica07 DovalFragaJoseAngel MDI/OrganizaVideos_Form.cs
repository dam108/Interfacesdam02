using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica07_DovalFragaJoseAngel_MDI
{
    public partial class OrganizaVideos_Form : Form
    {
        List<string> videos;
        BindingSource videosBS;
        static List<DirectoryInfo> directorios;
        public OrganizaVideos_Form()
        {
            InitializeComponent();
            videos = new List<string>();
            videosBS = new BindingSource();
            directorios = new List<DirectoryInfo>();
            videosBS.DataSource = videos;
            videos_ListBox.DataSource = videosBS;
        }

        private void seleccionar_Btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ListarDirectorio(carpetas_TreeView, fbd.SelectedPath);
                }
                catch (Exception)
                {
                    advertencia("Ha ocurrido un error inesperado, selecciona una carpeta valida");
                }

                try
                {
                    ListarArchivos(fbd);
                    actualizarVinculos();
                }
                catch (ArgumentException)
                {
                    advertencia("No hay archivos de video");
                }

            }
        }

        private void ListarArchivos(FolderBrowserDialog fbd)
        {
            var lst = Directory.GetFiles(fbd.SelectedPath, "*.*", SearchOption.AllDirectories).Where(s =>
                                         s.EndsWith(".mov") || s.EndsWith(".mp4") || s.EndsWith(".avi"));

            string root = fbd.SelectedPath;

            foreach (var item in lst)
            {
                videos.Add(Path.GetFileName(item));
            }
        }

        private void ListarDirectorio(TreeView arbol, string ruta)
        {
            arbol.Nodes.Clear();
            var raizDirectoryInfo = new DirectoryInfo(ruta);
            arbol.Nodes.Add(CrearNodoDirectorio(raizDirectoryInfo));
        }

        private static TreeNode CrearNodoDirectorio ( DirectoryInfo d_info)
        {
            directorios.Add(d_info);

            var nododirectorio = new TreeNode(d_info.Name);

            foreach (var directorio in d_info.GetDirectories())
            {
                nododirectorio.Nodes.Add(CrearNodoDirectorio(directorio));
            }

            return nododirectorio;
        }

        private void advertencia(string txt)
        {
            MessageBox.Show(txt, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void actualizarVinculos()
        {
            videosBS.ResetBindings(false);
        }

        private void carpetas_TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(e.Action == TreeViewAction.ByMouse)
            {
                int n = carpetas_TreeView.SelectedNode.Index;
                rutaCarpeta_Lbl.Visible = true;
                rutaCarpeta_Lbl.Text = carpetas_TreeView.SelectedNode.FullPath;
            }
            else
            {
                advertencia("Seleccione una carpeta del arbol con el ratón");
            }
        }

        private void organizar_Btn_Click(object sender, EventArgs e)
        {
            if(carpetas_TreeView.SelectedNode != null)
            {
                string nombreRutaSeleccionada = carpetas_TreeView.SelectedNode.Text;

                foreach (var item in directorios)
                {
                    if (nombreRutaSeleccionada == item.Name)
                    {
                        OrganizarVideos(item , DateTime.MinValue);
                    }
                }
            } else
            {
                advertencia("Tiene que seleccionar una carpeta en el arbol, no se muestran carpetas primero cargue el arbo con el boton Seleccionar Carpeta)");
            }
        }

        private void OrganizarVideos(DirectoryInfo carpeta, DateTime fecha)
        {
            var lst = Directory.GetFiles(carpeta.FullName, "*.*", SearchOption.AllDirectories).Where(s =>
                                         s.EndsWith(".mov") || s.EndsWith(".mp4") || s.EndsWith(".avi"));

            MessageBox.Show("A continuación seleccione una carpeta donde se van a guardar los videos organizados por fecha",
                "Información",MessageBoxButtons.OK,MessageBoxIcon.Information);

            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fecha == DateTime.MinValue)
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    foreach (var item in lst)
                    {
                        DateTime modificacion = File.GetLastWriteTime(item);

                        String rutaDirFinal = fbd.SelectedPath + @"\" + modificacion.ToString().Substring(6, 4)
                            + @"\" + modificacion.ToString().Substring(3, 2);

                        if (!Directory.Exists(rutaDirFinal))
                        {
                            Directory.CreateDirectory(rutaDirFinal);
                            File.Copy(item, rutaDirFinal + @"\" + Path.GetFileName(item));

                        }
                        else
                        {
                            if (File.Exists(rutaDirFinal + @"\" + Path.GetFileName(item)))
                            {
                                File.Delete(rutaDirFinal + @"\" + Path.GetFileName(item));
                                File.Copy(item, rutaDirFinal + @"\" + Path.GetFileName(item));
                            }
                            else
                            {
                                File.Copy(item, rutaDirFinal + @"\" + Path.GetFileName(item));
                            }
                        }

                    }

                }
            }

            else
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {


                    foreach (var item in lst)
                    {
                        DateTime modificacion = File.GetLastWriteTime(item);

                        if (modificacion >= fecha)
                        {
                            String rutaDirFinal = fbd.SelectedPath + @"\" + modificacion.ToString().Substring(6, 4)
                            + @"\" + modificacion.ToString().Substring(3, 2);

                            if (!Directory.Exists(rutaDirFinal))
                            {
                                Directory.CreateDirectory(rutaDirFinal);
                                File.Copy(item, rutaDirFinal + @"\" + Path.GetFileName(item));

                            }
                            else
                            {
                                if (File.Exists(rutaDirFinal + @"\" + Path.GetFileName(item)))
                                {
                                    File.Delete(rutaDirFinal + @"\" + Path.GetFileName(item));
                                    File.Copy(item, rutaDirFinal + @"\" + Path.GetFileName(item));
                                }
                                else
                                {
                                    File.Copy(item, rutaDirFinal + @"\" + Path.GetFileName(item));
                                }
                            }
                        }
                    }
                }
            }
        }

        private void fecha_DataPicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha = fecha_DataPicker.Value.Date;
            string sfecha = fecha.ToShortDateString();
            var resultado = MessageBox.Show("Quiere organizar todos los videos de la carpeta seleccionada a partir de esta fecha --> " + sfecha,
                "Organizar videos a partir de fecha", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(resultado == DialogResult.Yes)
            {
                if (carpetas_TreeView.SelectedNode != null)
                {
                    string nombreRutaSeleccionada = carpetas_TreeView.SelectedNode.Text;

                    foreach (var item in directorios)
                    {
                        if (nombreRutaSeleccionada == item.Name)
                        {
                            OrganizarVideos(item, fecha);
                        }
                    }
                }
                else
                {
                    advertencia("Tiene que seleccionar una carpeta en el arbol, no se muestran carpetas primero cargue el arbo con el boton Seleccionar Carpeta)");
                }
            }

        }
    }
}
