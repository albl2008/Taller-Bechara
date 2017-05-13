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
    public partial class AgregarCliente : Form
    {
        public Boolean aceptar;
        public AgregarCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aceptar = true;
        }
        public TextBox TextBox1
        {
            get
            {
                return textBox1;
            }
        }

        private void AgregarCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
