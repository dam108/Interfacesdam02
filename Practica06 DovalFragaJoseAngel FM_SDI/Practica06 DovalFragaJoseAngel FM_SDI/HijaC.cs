using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica06_DovalFragaJoseAngel_FM_SDI
{
    public partial class HijaC : Form
    {
        public bool Ocultar { get; set; }
        public string titulo { get; set; }
        public int NTitulo { get; set; }
        public string tituloCompleto { get; set; }

        public HijaC(int nTitulo)
        {
            InitializeComponent();
            this.titulo = "VENTANA";
            this.NTitulo = nTitulo;
            this.Ocultar = false;
            this.Text = "C - " + NTitulo;
            tituloCompleto = titulo + " : " + this.Text;
            this.ControlBox = false;
        }

        public override string ToString()
        {
            if (!Ocultar) return tituloCompleto;
            else return tituloCompleto + " (oculta)";
        }
    }
}
