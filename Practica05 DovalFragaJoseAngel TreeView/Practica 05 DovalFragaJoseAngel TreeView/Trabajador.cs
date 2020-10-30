using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_05_DovalFragaJoseAngel_TreeView
{
    class Trabajador
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Localidad { get; set; }
        public string Cargo { get; set; }
        public int Id_padre {get; set;}
        

        public Trabajador(string nombre, string apellido, string localidad, string cargo, int ip)
        {
            Nombre = nombre;
            Apellido = apellido;
            Localidad = localidad;
            Cargo = cargo;
            Id_padre = ip;
        }

        public Trabajador(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }

        public Trabajador(string localidad)
        {
            Localidad = localidad;
        }

    }
}
