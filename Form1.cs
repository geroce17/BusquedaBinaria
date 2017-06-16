using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusquedaBinaria
{
    public partial class Form1 : Form
    {
        Vector vec;
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdLlenar_Click(object sender, EventArgs e)
        {
            vec = new Vector(Convert.ToInt32(txtLlenar.Text));
            vec.llenar(Convert.ToInt32(txtLim.Text));
        }

        private void cmdOrdenar_Click(object sender, EventArgs e)
        {
            vec.ordenar();
        }

        private void cmdMostrar_Click(object sender, EventArgs e)
        {
            txtMostrar.Text = vec.mostrar();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            txtMostrar.Text = vec.busquedaBin(Convert.ToInt32(txtBusqueda.Text));
        }
    }
}
