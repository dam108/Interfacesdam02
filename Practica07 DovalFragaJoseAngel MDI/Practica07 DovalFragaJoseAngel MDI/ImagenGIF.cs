using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica07_DovalFragaJoseAngel_MDI
{
    public class ImagenGIF
    {
        public String Nombre { get; set; }
        public String Path { get; set; }
        public String NombreMostrar { get; set; }

        public ImagenGIF(){}

        // constructor para cuando la imagen esta encriptada
        public ImagenGIF(string nombre, string path)
        {
            this.Nombre = nombre;
            this.Path = path;
            this.NombreMostrar = nombre;
        }
        //Contrusctor para cuando la imagen sin encriptar
        public ImagenGIF(string nombre, string path, string nombreMostrar)
        {
            this.Nombre = nombre;
            this.Path = path;
            this.NombreMostrar = nombre + nombreMostrar;
        }
    }
}
