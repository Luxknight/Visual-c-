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
    public partial class Nomina : Form
    {
        public Nomina()
        {
            InitializeComponent();
        }

        double sueldobase, resultadob, totalextra, total;
        int D, ext;

        private void txtDias_TextChanged(object sender, EventArgs e)
        {
            int dias;
            int.TryParse(txtDias.Text, out dias);
            D = dias;
        }

        private void txthoras_TextChanged(object sender, EventArgs e)
        {
            int extra;
            int.TryParse(txthoras.Text, out extra);
            ext = extra;
        }

        private void txtExtra_TextChanged(object sender, EventArgs e)
        {
            int Suelextra;
            int.TryParse(txthoras.Text, out Suelextra);
            resultadob = Suelextra;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            Ticket cambio = new Ticket(txtNombre.Text,txtSueldo.Text,txtTotal.Text,txtExtra.Text);
            cambio.Show();
            this.Hide();
            cambio.Location = new Point(400, 190);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            totalextra = ext * 100;
            total = sueldobase*D;
            txtExtra.Text = Convert.ToString(totalextra);
            txtTotal.Text = Convert.ToString(total);
        }

        private void txtSueldo_TextChanged(object sender, EventArgs e)
        {
            double SBase;
            Double.TryParse(txtSueldo.Text, out SBase);
            sueldobase=SBase;
        }
    }
}
