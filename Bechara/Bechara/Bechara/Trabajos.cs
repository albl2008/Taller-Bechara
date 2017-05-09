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
    public partial class Trabajos : Form
    {
        public Trabajos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrdenDeTrabajo frm1 = new OrdenDeTrabajo();
            frm1.Show();
        }
    }
}
