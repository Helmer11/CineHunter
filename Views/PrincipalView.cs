using CineHunter.Interfaces;
using CineHunter.Models;
using CineHunter.Services;
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
    public partial class PrincipalView : Form
    {
        private readonly IPeliculas movie;
        public PrincipalView()
        {
            InitializeComponent();
            movie = new PeliculaService();
            this.getPeliculas();
        }

        private void getPeliculas()
        {
            dgvPeliculas.DataSource = movie.getListaPelicula();
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

        private void DetalleActore_Click(object sender, EventArgs e)
        {
            DetalleActoresView detalle = new DetalleActoresView();
            detalle.Visible = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string titulo = txbBuscar.Text;

            if(titulo == string.Empty)
            {
                MessageBox.Show("El campo de busqueda está vacio ");
            }

            dgvPeliculas.DataSource = movie.getListaPelicula(titulo);
            this.getPeliculas();
        }

        private void EliminarPelicula_Click(object sender, EventArgs e)
        {
            DetallePeliculaView d = new DetallePeliculaView();
            d.Visible = true;
        }
    }
}
