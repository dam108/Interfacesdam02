using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlesPractica08
{
    public partial class presion_Control : UserControl
    {
        public DataSet Ds { get; set; }
        public string Presion { get => this.presion_TextBox.Text; set => this.presion_TextBox.Text = value; }

        public presion_Control()
        {
            InitializeComponent();
            presion_progressBar.Minimum = 0;
            presion_progressBar.Maximum = 40;
            presion_progressBar.Step = 1;
            presion_progressBar.Value = 25;
        }

        private void menos_Btn_Click(object sender, EventArgs e)
        {

            double n = Convert.ToDouble(presion_TextBox.Text, System.Globalization.CultureInfo.InvariantCulture);
            if (n == 0.0d)
            {
                n = 0.0d;
                presion_TextBox.Text = Convert.ToString(n, System.Globalization.CultureInfo.InvariantCulture);
                presion_progressBar.Value = 0;
            }
            else
            {
                n = n - 0.1d;
                presion_TextBox.Text = Convert.ToString(n, System.Globalization.CultureInfo.InvariantCulture);
                if(presion_progressBar.Value > 0) presion_progressBar.Value--;
            }
        }

        private void mas_Btn_Click(object sender, EventArgs e)
        {
            double n = Convert.ToDouble(presion_TextBox.Text, System.Globalization.CultureInfo.InvariantCulture);
            if (n == 4.0d)
            {
                n = 4.0d;
                presion_TextBox.Text = Convert.ToString(n, System.Globalization.CultureInfo.InvariantCulture);
                presion_progressBar.Value = 40;
            }
            else
            {
                n = n + 0.1d;
                presion_TextBox.Text = Convert.ToString(n, System.Globalization.CultureInfo.InvariantCulture);
                if(presion_progressBar.Value < 40) presion_progressBar.Value++;
            }
        }

        private void presion_TextBox_TextChanged(object sender, EventArgs e)
        {
            double optima = 0;

            if(rueda_Lbl.Text == "Rueda DI" || rueda_Lbl.Text == "Rueda TI")
            {
                String sOptima = Ds.Tables[0].Rows[0].Field<String>("optima");
                optima = Convert.ToDouble(sOptima);
            }
            else if (rueda_Lbl.Text == "Rueda DD" || rueda_Lbl.Text == "Rueda TD")
            {
                String sOptima = Ds.Tables[0].Rows[2].Field<String>("optima");
                optima = Convert.ToDouble(sOptima);
            }
            else
            {
                optima = 2.5;
            }


            double diferenciaNegativa = optima - 0.5;
            double diferenciaPositiva = optima + 0.5;

            double n = Convert.ToDouble(presion_TextBox.Text, System.Globalization.CultureInfo.InvariantCulture);
            presion_progressBar.Value = Convert.ToInt32( n * 10.0d);

            if (n > diferenciaPositiva)
            {
                presion_panel.BackColor = Color.Red;
            }
            else if (n < diferenciaNegativa)
            {
                presion_panel.BackColor = Color.Gray;
            }
            else
            {
                presion_panel.BackColor = Color.Green;
            }
        }

        public void cambiarEtiqueta(int pos)
        {
            String nombre = Ds.Tables[0].Rows[pos].Field<String>("posicion");

            rueda_Lbl.Text = "Rueda " + nombre;
        }

        public void cambiarPresion(int pos, int tipo)
        {
            if(tipo == 0)
            {
                string presion = Ds.Tables[0].Rows[pos].Field<String>("presion");

                presion_TextBox.Text = presion.Replace(",", ".");
            }
            else if(tipo == 1)
            {
                string presion = Ds.Tables[0].Rows[pos].Field<String>("optima");
                presion_TextBox.Text = presion.Replace(",", ".");
            }
        }
    }
}
