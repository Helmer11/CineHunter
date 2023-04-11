using CineHunter.Models;
using CineHunter.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineHunter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AgregarPelicula_Click(object sender, EventArgs e)
        {
                PeliculasView peli = new PeliculasView();    
                peli.Visible = true;
        }

        private void CrearGenero_Click(object sender, EventArgs e)
        {
            GeneroView genero = new GeneroView();
            genero.Visible = true;
        }

        private void CrearActores_Click(object sender, EventArgs e)
        {
            ActoresView actores = new ActoresView();
            actores.Visible = true; 
        }
    }
}
