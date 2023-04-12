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
    public partial class DetallePeliculaView : Form
    {
        private readonly IPeliculas movie;
        private readonly IActores act;
        readonly Peliculas peli;
        private string path;

        public DetallePeliculaView()
        {
            InitializeComponent();
            movie = new PeliculaService();
            act = new ActoresServices();
            peli = new Peliculas();
            this.getPeliculas();

        }
        private void getPeliculas()
        {
           
            dgvPelicula.DataSource = movie.getListaPelicula();   
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int detalleID = 0;
            if (string.IsNullOrEmpty(txbBuscar.Text))
            {
                MessageBox.Show("El campo id debe estar completado ");
            }
            else
            {
                detalleID = Convert.ToInt32(txbBuscar.Text);
            }

            if(detalleID == 0)
            {
                MessageBox.Show("El campo id debe ser mayor a 0 ");
            } else
            {
                var result = movie.getDetallePelicula(detalleID);
                var currentpath = Path.GetFullPath("images_Peliculas/");
                if (result != null)
                {
                    txbTitulo.Text = result.Rows[0]["Titulo"].ToString();
                    txbDescripcion.Text = result.Rows[0]["Sipnosis"].ToString();
                    dtpAnio.Value = Convert.ToDateTime(result.Rows[0]["Anio"].ToString());
                    dtpFechaExtreno.Value = Convert.ToDateTime(result.Rows[0]["Fecha_Estreno"].ToString());
                    CbActores.Text = result.Rows[0]["Nombre_Completo"].ToString();
                    CbGenero.Text = result.Rows[0]["Genero"].ToString();
                    pbFoto.ImageLocation = result.Rows[0]["ImagenPelicula"].ToString();
               
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idregistro = Convert.ToInt32(txbBuscar.Text);

            var result = movie.setDeletePelicula(idregistro);

            if (result)
            {
                MessageBox.Show("Se elimino el registo");
            }
            else
            {
                MessageBox.Show("Error, al momento de eliminar el registro");
            }
            this.getPeliculas();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var currentpath = Path.GetFullPath("images_Peliculas/");
            peli.Titulo = txbTitulo.Text;
            peli.Descripcion = txbDescripcion.Text;
            peli.GeneroID = (byte)CbGenero.SelectedValue;
            peli.ActorID = Convert.ToInt32(CbActores.SelectedValue);
            peli.Anio = dtpAnio.Value;
            peli.Fecha_Estreno = dtpFechaExtreno.Value;

            File.Copy(path, currentpath + peli.Titulo + ".jpg", true);
            peli.ImagenPelicula = currentpath + peli.Titulo + ".jpg";

            var resultado = movie.setEditaPelicula(peli);

            MessageBox.Show(resultado);
        }
    }
}
