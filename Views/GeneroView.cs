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
    public partial class GeneroView : Form
    {
       private readonly IGenero gen;
       private readonly Generos gener;

        public GeneroView()
        {
            InitializeComponent();
            gen = new GeneroService();
            gener = new Generos();
            getCargarGenero();
        }
        private void getCargarGenero()
        {
            dgvGenero.DataSource = gen.GetGeneros();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            gener.Descriopcion = txbDescripcion.Text;
             var result = gen.setAgregarGenero(gener);
            txbDescripcion.Clear();
            MessageBox.Show(result);
            this.getCargarGenero();   

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
