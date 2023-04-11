using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineHunter.Models
{
    internal class Peliculas
    {
        public int Pelicula_id { get; set; }

        public string Titulo { get; set; }

        public string Descripcion { get;set; }

        public DateTime Anio { get; set; }

        public DateTime Fecha_Estreno { get; set; }

        public string ImagenPelicula { get; set; }

        public int ActorID { get; set; }

        public int GeneroID { get; set; }

        public bool Estado { get;set; }
       
        public virtual ICollection<Actores> Actor { get; set; }

        public virtual ICollection<Generos> Genero { get; set; }



    }
}
