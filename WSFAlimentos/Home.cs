using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSFAlimentos
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarProducto form = new AgregarProducto();
            form.Show();

        }

        private void crearVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Venta form = new Venta();
            form.Show();
        }
    }
}
