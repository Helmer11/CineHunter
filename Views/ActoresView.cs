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
using System.IO;

namespace CineHunter.Views
{
    public partial class ActoresView : Form
    {
        private readonly IActores act;
        private readonly Actores actores;
        private string path;

        public ActoresView()
        {
            InitializeComponent();
            act = new ActoresServices();
            actores = new Actores();
        }


        private void btnCargaImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPEG(*.JPG)|*.JPG|PNG(*.PNG)|*.PNG|GIF(*.GIF)|*.GIF";
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                pbFoto.Image = Image.FromFile(ofd.FileName);
                path = ofd.FileName;
            } else
            {
                MessageBox.Show("El fomato no es correcto");
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var currentpath = Path.GetFullPath("images_Actores/");
            
            actores.Nombre_Completo = txbNombreCompleto.Text;
                actores.Fecha_Nacimiento = dtpFechaNacimiento.Value;
                actores.Sexo = Convert.ToChar(Cbsexo.Text);
            File.Copy(path, currentpath + actores.Nombre_Completo + ".jpg", true);
            actores.Foto = currentpath + actores.Nombre_Completo + ".jpg";
           
            var result = act.setAgregarActores(actores); 

            MessageBox.Show(result);

           
           

            

        }

    }
}
