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
    public partial class Articulos : Form
    {

        BaseDatosMySql bd;

        public Articulos()
        {
            InitializeComponent();
        }

        public Articulos(BaseDatosMySql bd)
        {
            InitializeComponent();
            this.bd = bd;

            bd.cargarArticulos(tablaArticulos);
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow fila in tablaArticulos.SelectedRows)
            {
                bd.eliminarPresupuesto(fila.Cells[0].Value.ToString());
            }

            bd.cargarArticulos(tablaArticulos);

        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tbBuscador_TextChanged(object sender, EventArgs e)
        {
            tablaArticulos.ClearSelection();
            if (tbBuscador.Text.Length >= 3)
            {
                foreach (DataGridViewRow temp in tablaArticulos.Rows)
                {
                    bool visible = false;
                    for (int c = 0; c < temp.Cells.Count; c++)
                    {
                        if (temp.Cells[c].Value.ToString().ToUpper().Contains(tbBuscador.Text.ToUpper()))
                        {
                            visible = true;
                        }
                    }
                    temp.Visible = visible;
                }
            }
            else
            {
                foreach (DataGridViewRow temp in tablaArticulos.Rows)
                {
                    temp.Visible = true;
                }
            }
        }

        private void pbAcualizarArticulos_Click(object sender, EventArgs e)
        {
            bd.cargarArticulos(tablaArticulos);
        }
    }
}
