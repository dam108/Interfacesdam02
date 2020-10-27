using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica04_DovalFragaJA_ListView
{
    public static class Comprobaciones
    {
        public static bool dniOK(string dni)
        {
            if (dni.Length == 9)
            {
                string strnumeros = dni.Substring(0, 8);
                for (int i = 0; i < strnumeros.Length; i++)
                {
                    char a = strnumeros[i];
                    if (!char.IsDigit(a)) return false;
                }
                string letra = dni.Substring(8);
                int numeros = Int32.Parse(strnumeros);
                char letraMinuscula = Char.ToLower(letra[0]);
                if (!Char.IsLetter(letraMinuscula) || letraMinuscula != calcularLetraDni(numeros)) return false;
                else return true;
            }
            else return false;
        }

        private static char calcularLetraDni(int n)
        {
            string minusculas = "trwagmyfpdxbnjzsqvhlcke";
            int resto = n % 23;
            return minusculas[resto];
        }

        public static bool existeDni(string dni, List<Trabajador> lista)
        {
            Trabajador momentaneo = new Trabajador(dni);
            if (lista.Contains(momentaneo)) return true;
            else return false;
        }

        public static bool nombreOK(string nombre)
        {
            if (nombre != "") return true;
            else return false;
        }

        public static bool apellidoOK(string nombre)
        {
            if (nombre != "") return true;
            else return false;
        }

        public static bool cajaVacia(string txt)
        {
            if (txt == "") return true;
            else return false;
        }

        public static bool provinciaSeleccionada(int n)
        {
            if (n >= 0) return true;
            else return false;
        }

        public static bool profesionSeleccionada(int n)
        {
            if (n >= 0) return true;
            else return false;
        }

    }
}
