using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Disco
    {
        public Disco()
        {
            EnStock = true;
        }

        public int Id { get; set; }

        [DisplayName("Título")]
        public string Titulo { get; set; }

        public Artista Artista { get; set; }

        [DisplayName("Cantidad Canciones")]
        public int cantidadCanciones { get; set; }

        public string UrlImagenTapa { get; set; }

        [DisplayName("Género")]
        public Estilo Genero { get; set; }

        public Edicion Tipo { get; set; }

        public bool EnStock { get; set; }
    }
}
