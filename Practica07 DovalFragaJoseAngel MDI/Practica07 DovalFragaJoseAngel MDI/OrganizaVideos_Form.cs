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
        //List<Video> videos 
        public OrganizaVideos_Form()
        {
            InitializeComponent();
        }

        private void seleccionar_Btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                string[] archivos = Directory.GetFiles(fbd.SelectedPath, "*.avi | *.mov | *.mp4", SearchOption.AllDirectories);

                foreach (var item in archivos)
                {
                    string nombre = Path.GetFileName(item);
                    string carpeta = 
                }
            }
        }

        private void funcionRecursiva(string carpeta,string padre)
        {
            if(padre == "")
            {

            }

        }
    }
}
