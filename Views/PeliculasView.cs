using CineHunter.Interfaces;
using CineHunter.Models;
using CineHunter.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineHunter.Views
{
    public partial class PeliculasView : Form
    {
       readonly IPeliculas movie;
        readonly IGenero genero;
       readonly Peliculas peli;

        public PeliculasView()
        {
            InitializeComponent();
            genero = new GeneroService();
            movie = new PeliculaService();
            peli = new Peliculas();
            getCargarGenero();
        }

        public void getCargarGenero()
        {
            CbGenero.DisplayMember = "Descripcion";
            CbGenero.ValueMember = "Genero_id";
            CbGenero.DataSource = genero.GetGeneros();
        }



        private void Aceptarbtn_Click(object sender, EventArgs e)
        {
            peli.Titulo = txbTitulo.Text;
            peli.Descripcion = txbDescripcion.Text;
            peli.GeneroID = (byte) CbGenero.SelectedValue;
            peli.ActorID = Convert.ToInt32(txbActores.Text);
            peli.Anio = dtpAnio.Value;
            peli.Fecha_Estreno = dtpFechaExtreno.Value;

           var resultado = movie.setAgregarPelicula(peli);

            MessageBox.Show(resultado);
        }

       
    }
}
