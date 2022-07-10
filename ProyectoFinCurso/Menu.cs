using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinCurso
{
    public partial class Menu : Form
    {

        BaseDatosMySql bd;

        public Menu()
        {
            InitializeComponent();
            bd = new BaseDatosMySql();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes vClientes = new Clientes(bd);

            this.Hide();

            vClientes.ShowDialog();

            this.Show();
        }

        private void presupuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presupuestos vPresupuestos = new Presupuestos(bd);

            this.Hide();

            vPresupuestos.ShowDialog();

            this.Show();
        }

        private void artículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Articulos vArticulos = new Articulos(bd);

            this.Hide();

            vArticulos.ShowDialog();

            this.Show();
        }
    }
}
