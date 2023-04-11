using CineHunter.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineHunter.Interfaces
{
    internal interface IGenero
    {
        DataTable GetGeneros();
        string setAgregarGenero(Generos gene);

        string setEditaGenero(Generos gene);

        string setEliminarGenero(int IDGenero);
    }
}
