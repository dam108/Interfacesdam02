using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica04_DovalFragaJA_ListView
{
    public class Trabajador
    {
        private string dni;
        private string nombre;
        private string apellido1;
        private string apellido2;
        private int provincia;
        private int profesion;

        public Trabajador(string dni, string nombre, string apellido1, string apellido2, int provincia, int profesion)
        {
            this.Dni = dni;
            this.Nombre = nombre;
            this.Apellido1 = apellido1;
            this.Apellido2 = apellido2;
            this.Provincia = provincia;
            this.Profesion = profesion;
        }

        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        public int Provincia { get => provincia; set => provincia = value; }
        public int Profesion { get => profesion; set => profesion = value; }
    }
}
