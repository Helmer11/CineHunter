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
    public partial class DetalleActoresView : Form
    {
        private readonly IActores act;
        private readonly Actores actore;
        private  int detalleID;
        private string path;

        public DetalleActoresView()
        {
            InitializeComponent();
            act = new ActoresServices();
            actore = new Actores();
            this.getActores();
        }

        private void getActores()
        {
            dgvActores.DataSource = act.getActores();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(txbBuscar.Text))
            {
                MessageBox.Show("El campo id debe estar completado ");
            }
            else
            {
                this.detalleID = Convert.ToInt32(txbBuscar.Text);
            }


            if (detalleID == 0)
            {
                MessageBox.Show("El campo id debe ser mayor a 0 ");
            }
            else
            {
                var result = act.getDetalleActores(detalleID);
                var currentpath = Path.GetFullPath("images_Peliculas/");
                if (result != null)
                {
                    txbNombreCompleto.Text = result.Rows[0]["Nombre_Completo"].ToString();
                    Cbsexo.Text = result.Rows[0]["Sexo"].ToString();
                    pbFoto.ImageLocation = result.Rows[0]["Foto"].ToString();
                    dtpFechaNacimiento.Value = Convert.ToDateTime(result.Rows[0]["Fecha_Nacimiento"].ToString());
                }
            }
        }

        private void btnCargaImagen_Click(object sender, EventArgs e)
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var currentpath = Path.GetFullPath("images_Peliculas/");
            actore.Actor_id = this.detalleID;
            actore.Nombre_Completo = txbNombreCompleto.Text;
            actore.Sexo = Convert.ToChar( Cbsexo.Text);
            actore.Fecha_Nacimiento = dtpFechaNacimiento.Value;
            File.Copy(path, currentpath + actore.Nombre_Completo + ".jpg", true);
            actore.Foto = currentpath + actore.Nombre_Completo + ".jpg";

            var resultado = act.setEditaActores(actore);
            this.getActores();
            MessageBox.Show(resultado);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int ActorID = 0;
            if (string.IsNullOrEmpty(txbBuscar.Text))
            {
                MessageBox.Show("El campo id debe estar completa ");
            } 
            else
            {
                ActorID = Convert.ToInt32(txbBuscar.Text);
            }

            if (ActorID == 0)
            {
                MessageBox.Show("El campo id debe ser mayor a 0 ");
            }
            else
            {
                string result = act.setEliminacionActores(ActorID);
                MessageBox.Show(result);
                this.getActores();
            }
        }
    }
}
