using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica07_DovalFragaJoseAngel_MDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buscaPalabrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarPalabra_Form bp = new BuscarPalabra_Form();
            bp.MdiParent = this;
            bp.Show();
        }

        private void encriptaGIFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EncriptaGif_Form enG = new EncriptaGif_Form();
            enG.MdiParent = this;
            enG.Show();
        }

        private void organizaVideosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrganizaVideos_Form orV = new OrganizaVideos_Form();
            orV.MdiParent = this;
            orV.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
