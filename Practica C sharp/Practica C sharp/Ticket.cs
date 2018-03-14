using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_C_sharp
{
    public partial class Ticket : Form
    {
        public Ticket(string nombre,string sueldobase,string sueldototal,string sueldoextra)
        {
            InitializeComponent();
            txtNombreimprimir.Text = nombre;
            txtSueldoBase.Text = sueldobase;
            txtSueldoextra.Text = sueldoextra;
            txtSueldototal.Text = sueldototal;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form cambio = new Nomina();
            cambio.Show();
            this.Hide();
            cambio.Location = new Point(400, 190);
        }
    }
}
