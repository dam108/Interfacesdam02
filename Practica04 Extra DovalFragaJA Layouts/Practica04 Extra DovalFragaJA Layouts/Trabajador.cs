using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica04_Extra_DovalFragaJA_Layouts
{
    public class Trabajador
    {
        private string dni;
        private string nombre;
        private string apellido1;
        private string apellido2;
        private string provincia;
        private string profesion;

        public Trabajador(string dni, string nombre, string apellido1, string apellido2, string provincia, string profesion)
        {
            this.Dni = dni;
            this.Nombre = nombre;
            this.Apellido1 = apellido1;
            this.Apellido2 = apellido2;
            this.Provincia = provincia;
            this.Profesion = profesion;
        }

        public Trabajador(string dni)
        {
            this.Dni = dni;
            this.Nombre = "";
            this.Apellido1 = "";
            this.Apellido2 = "";
            this.Provincia = "";
            this.Profesion = "";
        }

        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        public string Provincia { get => provincia; set => provincia = value; }
        public string Profesion { get => profesion; set => profesion = value; }

        public override bool Equals(object obj)
        {
            return obj is Trabajador trabajador &&
                   dni.ToLower() == trabajador.dni.ToLower();
        }

        public override int GetHashCode()
        {
            return 1456690394 + EqualityComparer<string>.Default.GetHashCode(dni);
        }
    }
}
