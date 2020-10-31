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

        public override string ToString()
        {
            return Nombre + ", " + Apellido + ", " + Localidad + ", " + Cargo + ", " + Id_padre.ToString();
        }
    }
}