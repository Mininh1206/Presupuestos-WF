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
    public partial class SelectorCliente : Form
    {

        BaseDatosMySql bd;

        public string codigo;

        public SelectorCliente(BaseDatosMySql bd)
        {
            InitializeComponent();
            this.bd = bd;
            bd.cargarClientesPre(tablaClientes);
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            if (tablaClientes.SelectedRows.Count == 1)
            {
                codigo = tablaClientes.SelectedRows[0].Cells[0].Value.ToString();

                this.DialogResult = DialogResult.OK;
            }
        }

        private void tbBuscador_TextChanged(object sender, EventArgs e)
        {
            tablaClientes.ClearSelection();
            if (tbBuscador.Text.Length >= 3)
            {
                foreach (DataGridViewRow temp in tablaClientes.Rows)
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
                foreach (DataGridViewRow temp in tablaClientes.Rows)
                {
                    temp.Visible = true;
                }
            }
        }
    }
}
