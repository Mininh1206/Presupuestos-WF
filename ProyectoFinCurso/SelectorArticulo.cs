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
    public partial class SelectorArticulo: Form
    {

        BaseDatosMySql bd;

        public DataGridViewRow fila;

        public SelectorArticulo(BaseDatosMySql bd)
        {
            InitializeComponent();
            this.bd = bd;

            bd.cargarArticulosPre(tablaArticulos);

            tablaArticulos.CurrentCell = tablaArticulos.Rows[0].Cells[0];

            actualizarCampos();

            actualizarUnidad();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            errorCantidad.Visible = false;
            try
            {
                if (tablaArticulos.SelectedRows.Count == 1)
                {
                    double cantidad = double.Parse(tbCantidad.Text);
                    fila = tablaArticulos.SelectedRows[0];

                    if (cantidad > 0)
                    {
                        if (MessageBox.Show("¿Quiere realizar esta acción?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    else
                    {
                        errorCantidad.Visible = true;
                    }
                }
            }
            catch (FormatException)
            {
                errorCantidad.Visible = true;
            }
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

        private void tablaArticulos_CurrentCellChanged(object sender, EventArgs e)
        {
            actualizarCampos();

            actualizarUnidad();
        }

        private void actualizarCampos()
        {
            if (tablaArticulos.SelectedRows.Count == 1)
            {
                tbCodigo.Text = tablaArticulos.SelectedRows[0].Cells[0].Value.ToString();
                tbDescripcion.Text = tablaArticulos.SelectedRows[0].Cells[1].Value.ToString();
                tbPrecio.Text = tablaArticulos.SelectedRows[0].Cells[2].Value.ToString();
            }
            else
            {
                tbCodigo.Text = "";
                tbDescripcion.Text = "";
                tbPrecio.Text = "";
            }

            guardar.Enabled = false;
            tbUnidad.Enabled = false;
            tbDescripcion.Enabled = false;
            tbPrecio.Enabled = false;
            aceptar.Enabled = true;
            tbCantidad.Enabled = true;
        }

        private void actualizarUnidad()
        {
            if (tablaArticulos.SelectedRows.Count == 1)
            {
                tbUnidad.Text = bd.getUnidadFromId(tablaArticulos.SelectedRows[0].Cells[0].Value.ToString());
            }
            else
            {
                tbUnidad.Text = "";
            }
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            a1.Visible = false;
            a2.Visible = false;
            a3.Visible = false;
            error.Visible = false;

            if (tbCodigo.Text.Equals("") || tbDescripcion.Text.Equals("") || tbPrecio.Text.Equals("") || tbUnidad.Text.Equals(""))
            {
                a1.Visible = true;
                a2.Visible = true;
                a3.Visible = true;
                error.Visible = true;
            }
            else
            {
                if (MessageBox.Show("¿Está seguro de que quiere añadir este artículo?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    bd.insertarArticulo(tbCodigo.Text, tbDescripcion.Text, double.Parse(tbPrecio.Text), tbUnidad.Text);

                    guardar.Enabled = false;
                    tbUnidad.Enabled = false;
                    tbDescripcion.Enabled = false;
                    tbPrecio.Enabled = false;
                    aceptar.Enabled = true;
                    tbCantidad.Enabled = true;

                    bd.cargarArticulos(tablaArticulos);

                    foreach (DataGridViewRow fila in tablaArticulos.Rows)
                    {
                        if (fila.Cells[0].Value.ToString() == tbCodigo.Text)
                        {
                            tablaArticulos.CurrentCell = fila.Cells[0];
                        }
                    }
                }

            }
        }

        private void tbCodigo_TextChanged(object sender, EventArgs e)
        {
            guardar.Enabled = false;
            tbUnidad.Enabled = false;
            tbDescripcion.Enabled = false;
            tbPrecio.Enabled = false;
            aceptar.Enabled = true;
            tbCantidad.Enabled = true;

            foreach (DataGridViewRow fila in tablaArticulos.Rows)
            {
                if (fila.Cells[0].Value.ToString() == tbCodigo.Text)
                {
                    tablaArticulos.CurrentCell = fila.Cells[0];
                    actualizarCampos();
                    actualizarUnidad();
                }
            }

            if (tbCodigo.Text.Equals("") || !bd.existeArticulo(tbCodigo.Text))
            {
                guardar.Enabled = true;
                tbUnidad.Enabled = true;
                tbDescripcion.Enabled = true;
                tbPrecio.Enabled = true;
                aceptar.Enabled = false;
                tbCantidad.Enabled = false;
            }
        }
    }
}
