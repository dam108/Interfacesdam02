using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica06_DovalFragaJoseAngel_FM_SDI
{
    public partial class Form1 : Form
    {
        List<Form> ventanas;

        public Form1()
        {
            InitializeComponent();
            ventanas = new List<Form>();
            numeroVentanas_Lbl.Text = ventanas.Count.ToString();
        }

        private void hijaA_btn_Click(object sender, EventArgs e)
        {
            int n = consguirPosicionHija(1);
            ventanas.Add(new HijaA((n + 1)));
            ventanas[contarTodas() - 1].Show();
            ActualizarContadorTotal();
            actualizarVinculos();
        }

        private void hijaB_btn_Click(object sender, EventArgs e)
        {
            int n = consguirPosicionHija(2);
            ventanas.Add(new HijaB((n + 1)));
            ventanas[contarTodas() - 1].Show();
            ActualizarContadorTotal();
            actualizarVinculos();
        }

        private void hijaC_btn_Click(object sender, EventArgs e)
        {
            int n = consguirPosicionHija(3);
            ventanas.Add(new HijaC((n + 1)));
            ventanas[contarTodas() - 1].Show();
            ActualizarContadorTotal();
            actualizarVinculos();
        }

        private void mostrar_rdbt_btn_Click(object sender, EventArgs e)
        {
            if (mostrar_tipoA_rbt.Checked == true)
            {
                foreach (Form w in ventanas)
                {
                    if (w is HijaA)
                    {
                        w.Show();
                        ((HijaA) w).Ocultar = false;
                    }
                }
            }
            else if (mostrar_tipoB_rbt.Checked == true)
            {
                foreach (Form w in ventanas)
                {
                    if (w is HijaB)
                    {
                        w.Show();
                        ((HijaB)w).Ocultar = false;
                    }
                }
            }
            else if (mostrar_tipoC_rbt.Checked == true)
            {
                foreach (Form w in ventanas)
                {
                    if (w is HijaC)
                    {
                        w.Show();
                        ((HijaC)w).Ocultar = false;
                    }
                }
            }
            else if (mostrar_todas_rbt.Checked == true)
            {
                foreach (Form w in ventanas)
                {
                    w.Show();
                    if (w is HijaA) ((HijaA)w).Ocultar = false;
                    if (w is HijaB) ((HijaB)w).Ocultar = false;
                    if (w is HijaC) ((HijaC)w).Ocultar = false;
                }
            }
            else
            {
                MessageBox.Show("Se ha de seleccionar un tipo para mostrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            actualizarVinculos();
        }

        private void ocultar_rdbt_btn_Click(object sender, EventArgs e)
        {
            if (ocultar_TipoA_rbt.Checked == true)
            {
                foreach (Form w in ventanas)
                {
                    if (w is HijaA)
                    {
                        w.Hide();
                        ((HijaA)w).Ocultar = true;
                    }
                }
            }
            else if (ocultar_TipoB_rbt.Checked == true)
            {
                foreach (Form w in ventanas)
                {
                    if (w is HijaB)
                    {
                        w.Hide();
                       ((HijaB)w).Ocultar = true;
                    }
                }
            }
            else if (ocultar_TipoC_rbt.Checked == true)
            {
                foreach (Form w in ventanas)
                {
                    if (w is HijaC)
                    {
                        w.Hide();
                       ((HijaC)w).Ocultar = true;
                    }
                }
            }
            else if (ocultar_todas_rbt.Checked == true)
            {
                foreach (Form w in ventanas)
                {
                    w.Hide();
                    if(w is HijaA) ((HijaA)w).Ocultar = true;
                    if (w is HijaB) ((HijaB)w).Ocultar = true;
                    if (w is HijaC) ((HijaC)w).Ocultar = true;
                }
            }
            else
            {
                MessageBox.Show("Se ha de seleccionar un tipo para ocultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            actualizarVinculos();
        }

        private void ActualizarContadorTotal() 
        {
            numeroVentanas_Lbl.Text = ventanas.Count.ToString();
        }

        private int contarTodas()
        {
            return ventanas.Count();
        }

        private void actualizarVinculos() 
        {
            ventanas_ListBox.Items.Clear();
            foreach (Form i in ventanas)
            {
                if (i is HijaA)
                {
                    HijaA x = (HijaA) i;
                    ventanas_ListBox.Items.Add(x.ToString());
                }
                if(i is HijaB)
                {
                    HijaB x = (HijaB)i;
                    ventanas_ListBox.Items.Add(x.ToString());
                }
                if (i is HijaC)
                {
                    HijaC x = (HijaC)i;
                    ventanas_ListBox.Items.Add(x.ToString());
                }
            }
        }

        private void mostrar_listBox_btn_Click(object sender, EventArgs e)
        {
            if (ventanas_ListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Se ha de seleccionar un tipo para Mostrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int n = ventanas_ListBox.SelectedIndex;
                if(ventanas[n] is HijaA)
                {
                    ventanas[n].Show();
                    ((HijaA)ventanas[n]).Ocultar = false;
                }
                if (ventanas[n] is HijaB)
                {
                    ventanas[n].Show();
                    ((HijaB)ventanas[n]).Ocultar = false;
                }
                if (ventanas[n] is HijaC)
                {
                    ventanas[n].Show();
                    ((HijaC)ventanas[n]).Ocultar = false;
                }
                actualizarVinculos();
            }
        }

        private void ocultar_listBox_btn_Click(object sender, EventArgs e)
        {
            if (ventanas_ListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Se ha de seleccionar un tipo para Ocultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int n = ventanas_ListBox.SelectedIndex;
                if (ventanas[n] is HijaA)
                {
                    ventanas[n].Hide();
                    ((HijaA)ventanas[n]).Ocultar = true;
                }
                if (ventanas[n] is HijaB)
                {
                    ventanas[n].Hide();
                    ((HijaB)ventanas[n]).Ocultar = true;
                }
                if (ventanas[n] is HijaC)
                {
                    ventanas[n].Hide();
                    ((HijaC)ventanas[n]).Ocultar = true;
                }
                actualizarVinculos();
            }
        }

        private void cerrar_listBox_btn_Click(object sender, EventArgs e)
        {
            if(ventanas_ListBox.SelectedIndex == -1) 
            {
                MessageBox.Show("Se ha de seleccionar un tipo para Borrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int n = ventanas_ListBox.SelectedIndex;
                ventanas[n].Dispose();
                if (ventanas[n] is HijaA) reordenarVentanas(1, n);
                if (ventanas[n] is HijaB) reordenarVentanas(2, n);
                if (ventanas[n] is HijaC) reordenarVentanas(3, n);
                ventanas.RemoveAt(n);
                actualizarVinculos();
                ActualizarContadorTotal();
            }
        }

        private void reordenarVentanas(int n, int j)
        {
            if (n == 1) 
            {
                for (int i = j; i < ventanas.Count; i++)
                {
                    if (ventanas[i] is HijaA)
                    {
                        ((HijaA) ventanas[i]).NTitulo--;
                        ((HijaA) ventanas[i]).Text = "A - " + ((HijaA) ventanas[i]).NTitulo;
                        ((HijaA)ventanas[i]).tituloCompleto = ((HijaA)ventanas[i]).titulo + " : " + ((HijaA)ventanas[i]).Text;
                    }
                }
            }
            if(n == 2)
            {
                for (int i = j; i < ventanas.Count; i++)
                {
                    if (ventanas[i] is HijaB)
                    {
                        ((HijaB)ventanas[i]).NTitulo--;
                        ((HijaB)ventanas[i]).Text = "B - " + ((HijaB)ventanas[i]).NTitulo;
                        ((HijaB)ventanas[i]).tituloCompleto = ((HijaB)ventanas[i]).titulo + " : " + ((HijaB)ventanas[i]).Text;
                    }
                }

            }
            if(n == 3)
            {
                for (int i = j; i < ventanas.Count; i++)
                {
                    if (ventanas[i] is HijaC)
                    {
                        ((HijaC)ventanas[i]).NTitulo--;
                        ((HijaC)ventanas[i]).Text = "C - " + ((HijaC)ventanas[i]).NTitulo;
                        ((HijaC)ventanas[i]).tituloCompleto = ((HijaC)ventanas[i]).titulo + " : " + ((HijaC)ventanas[i]).Text;
                    }
                }
            }
        }

        private int consguirPosicionHija(int w)
        {

            int n = 0, j = 0, q = 0;
            foreach (Form v in ventanas)
            {
                if(v is HijaA) n++;
                if(v is HijaB) j++;
                if(v is HijaC) q++;
            }
            if (w == 1) return n;
            if (w == 2) return j;
            if (w == 3) return q;
            return 0;

        }
    }
}
