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
    public partial class TipoTrabajo : Form
    {
        public TipoTrabajo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarTipoTrabajo frm1 = new AgregarTipoTrabajo();
            frm1.Show();
        }
    }
}
