using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineHunter.Models
{
    internal class Actores
    {
        public int Actor_id { get; set; }

        public string Nombre_Completo { get; set;}

        public DateTime Fecha_Nacimiento { get; set; }

        public char Sexo { get; set; }

        public string Foto { get; set; }

        public bool Estado { get; set; }

    }
}
