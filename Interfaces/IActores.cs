using CineHunter.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineHunter.Interfaces
{
    internal interface IActores
    {
        DataTable getActores();
        string setAgregarActores(Actores act);
        string setEditaActores(Actores act);

        string setEliminacionActores(int id);


    }
}
