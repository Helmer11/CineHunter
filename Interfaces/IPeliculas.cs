using CineHunter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineHunter.Interfaces
{
    internal interface IPeliculas
    {
        IEnumerable<IPeliculas> getListaPelicula();

        string setAgregarPelicula(Peliculas peli);
        string setEditaPelicula(Peliculas peli);

        Boolean setDeletePelicula(int IDPelicula);



    }
}
