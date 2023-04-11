using CineHunter.Interfaces;
using CineHunter.Models;
using CineHunter.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        readonly IActores actores;
        private string path;

        public PeliculasView()
        {
            InitializeComponent();
            genero = new GeneroService();
            movie = new PeliculaService();
            peli = new Peliculas();
            actores = new ActoresServices();
            getCargarGenero();
            this.getCargarAutor();

        }

        private void getCargarAutor()
        {
            CbActores.DisplayMember = "Nombre_Completo";
            CbActores.ValueMember = "Actor_id";
            CbActores.DataSource = actores.getActores();
        }

        public void getCargarGenero()
        {
            CbGenero.DisplayMember = "Descripcion";
            CbGenero.ValueMember = "Genero_id";
            CbGenero.DataSource = genero.GetGeneros();
        }
        private void Aceptarbtn_Click(object sender, EventArgs e)
        {
            var currentpath = Path.GetFullPath("images_Peliculas/"); 
            peli.Titulo = txbTitulo.Text;
            peli.Descripcion = txbDescripcion.Text;
            peli.GeneroID = (byte) CbGenero.SelectedValue;
            peli.ActorID = Convert.ToInt32(CbActores.SelectedValue);
            peli.Anio = dtpAnio.Value;
            peli.Fecha_Estreno = dtpFechaExtreno.Value;

            File.Copy(path, currentpath + peli.Titulo + ".jpg", true);
            peli.ImagenPelicula = currentpath + peli.Titulo + ".jpg";

            var resultado = movie.setAgregarPelicula(peli);

            MessageBox.Show(resultado);
        }

        private void BtnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPEG(*.JPG)|*.JPG|PNG(*.PNG)|*.PNG|GIF(*.GIF)|*.GIF";

            if (ofd.ShowDialog() == DialogResult.OK)
            {

                pbFoto.Image = Image.FromFile(ofd.FileName);
                path = ofd.FileName;
            }
            else
            {
                MessageBox.Show("El fomato no es correcto");
            }
        }
    }
}
