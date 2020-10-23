using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica03_Extra_DovalFragaJA_ListaTlf
{
    public class Persona
    {
        private string nombre;
        private string telefono;
        private string email;
        private string nombreFoto;
        public Persona(string n, string t, string em, string nF)
        {
            this.nombre = n;
            this.telefono = t;
            this.email = em;
            this.nombreFoto = nF;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public string NombreFoto { get => nombreFoto; set => nombreFoto = value; }

        public override bool Equals(object obj)
        {
            return obj is Persona persona &&
                   nombre == persona.nombre;
        }
    }

}
