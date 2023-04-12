using CineHunter.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineHunter.Interfaces
{
    internal interface IPeliculas
    {
        DataTable getListaPelicula(string titulo = "");

        DataTable getDetallePelicula(int Detalle_id);
        string setAgregarPelicula(Peliculas peli);
        string setEditaPelicula(Peliculas peli);

        Boolean setDeletePelicula(int IDPelicula);



    }
}
