using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Disco
    {
        public string Titulo { get; set; }

        public Artista Artista { get; set; }

        public string UrlImagenTapa { get; set; }

        public Estilo Genero { get; set; }

        public Edicion Tipo { get; set; }
    }
}
