using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bechara
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            AgregarCliente frm1 = new AgregarCliente();
            frm1.Show();
        }

        private void autosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vehiculo frm1 = new Vehiculo();
            frm1.Show();
        }

        private void tiposDeTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trabajos frm1 = new Trabajos();
            frm1.Show();
        }

        private void ordenDeTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoTrabajo frm1 = new TipoTrabajo();
            frm1.Show();
        }
    }
}
