using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica04_DovalFragaJA_ListView
{
    public static class Comprobaciones
    {
        public static bool dniOK(string dni)
        {
            // Agregar codigo que compruebe si el dni tiene el formato correcto
            // mientras
            if (dni != "") return true;
            else return false;
        }

        public static bool existeDni(string dni, List<Trabajador> lista)
        {
            // Agregar codigo que compruebe si el dni ya existe dentro de la lista de trabajadores
            // mientras
            return true;
        }

        public static bool nombreOK(string nombre)
        {
            // Agregar codigo que compruebe si nombre tiene formato correcto
            // mientras
            if (nombre != "") return true;
            else return false;
        }

        public static bool apellidoOK(string nombre)
        {
            // Agregar codigo que compruebe si apellido tiene formato correcto
            // mientras
            if (nombre != "") return true;
            else return false;
        }

        public static bool provinciaOK(List<string> p)
        {
            // Agregar codigo que compruebe si la provincia es correcta
            // mientras
            return true;
        }

        public static bool profesionOK(List<string> p)
        {
            // Agregar codigo que compruebe si la profesión es correcta
            // mientras
            return true;
        }

        public static bool cajaVacia(string txt)
        {
            if (txt == "") return true;
            else return false;
        }


    }
}
