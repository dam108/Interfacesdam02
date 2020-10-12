using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica01_Extra_02_Jose_Angel_Doval_Fraga1
{
    class Persona
    {
        private string dni, nombre, apellido1, apellido2, strTitullacionMax_otra;
        private bool permisoA, permisoB, permisoC, permisoD, permisoE,
            hombre, mujer, titulacionMax_none, titulacionMax_eso,
            titulacionMax_bach, titulacionMax_fp, titulacionMax_Uni,
            titulacionMax_otra;

         public Persona(string dni, string nombre, string apellido1, string apellido2, string strTitullacionMax_otra, bool permisoA, bool permisoB,
                bool permisoC, bool permisoD, bool permisoE, bool hombre, bool mujer, bool titulacionMax_none,
                bool titulacionMax_eso, bool titulacionMax_bach, bool titulacionMax_fp, bool titulacionMax_Uni,
                bool titulacionMax_otra)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.permisoA = permisoA;
            this.permisoB = permisoB;
            this.permisoC = permisoC;
            this.permisoD = permisoD;
            this.permisoE = permisoE;
            this.hombre = hombre;
            this.mujer = mujer;
            this.titulacionMax_none = titulacionMax_none;
            this.titulacionMax_eso = titulacionMax_eso;
            this.titulacionMax_bach = titulacionMax_bach;
            this.titulacionMax_fp = titulacionMax_fp;
            this.titulacionMax_Uni = titulacionMax_Uni;
            this.titulacionMax_otra = titulacionMax_otra;
            this.strTitullacionMax_otra = strTitullacionMax_otra;
        }

        public Persona(string dni) {
            this.dni = dni;
        }

        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        public string StrTitullacionMax_otra { get => strTitullacionMax_otra; set => strTitullacionMax_otra = value; }
        public bool PermisoA { get => permisoA; set => permisoA = value; }
        public bool PermisoB { get => permisoB; set => permisoB = value; }
        public bool PermisoC { get => permisoC; set => permisoC = value; }
        public bool PermisoD { get => permisoD; set => permisoD = value; }
        public bool PermisoE { get => permisoE; set => permisoE = value; }
        public bool Hombre { get => hombre; set => hombre = value; }
        public bool Mujer { get => mujer; set => mujer = value; }
        public bool TitulacionMax_none { get => titulacionMax_none; set => titulacionMax_none = value; }
        public bool TitulacionMax_eso { get => titulacionMax_eso; set => titulacionMax_eso = value; }
        public bool TitulacionMax_bach { get => titulacionMax_bach; set => titulacionMax_bach = value; }
        public bool TitulacionMax_fp { get => titulacionMax_fp; set => titulacionMax_fp = value; }
        public bool TitulacionMax_Uni { get => titulacionMax_Uni; set => titulacionMax_Uni = value; }
        public bool TitulacionMax_otra { get => titulacionMax_otra; set => titulacionMax_otra = value; }

        public override bool Equals(object obj)
        {
            return obj is Persona persona &&
                   dni == persona.dni;
        }
    }


}
