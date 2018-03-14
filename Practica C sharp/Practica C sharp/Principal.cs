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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
  
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNomina_Click(object sender, EventArgs e)
        {
            Form cambio = new Nomina();
            cambio.Show();
            this.Hide();
            cambio.Location = new Point(400, 190);
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            Form cambio = new Principal();
            cambio.Location = new Point(400, 190);
        }
    }
}
