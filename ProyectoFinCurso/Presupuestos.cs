using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System;
using System.Windows.Forms;

namespace ProyectoFinCurso
{
    public partial class Presupuestos : Form
    {
        BaseDatosMySql bd;

        public Presupuestos()
        {
            InitializeComponent();
        }

        public Presupuestos(BaseDatosMySql bd)
        {
            InitializeComponent();
            this.bd = bd;
            bd.cargarPresupuestos(tablaPresupuestos);
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioPresupuesto alta = new FormularioPresupuesto(bd);

            alta.Text = "Alta de presupuesto";

            if (alta.ShowDialog() == DialogResult.OK)
            {
                bd.insertarPresupuesto(alta.tbCodPresupuesto.Text, new MySqlDateTime(DateTime.Now), alta.cbFormaPago.Text, alta.lTotal.Text.Replace('€', ' ').Trim(), alta.tbCodigo.Text, alta.tablaArticulos);

                bd.cargarPresupuestos(tablaPresupuestos);
            }

        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in tablaPresupuestos.SelectedRows)
            {
                bd.eliminarPresupuesto(fila.Cells[0].Value.ToString());

                bd.cargarPresupuestos(tablaPresupuestos);
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (tablaPresupuestos.SelectedRows.Count == 1)
            {
                
                MySqlDataReader lector = bd.getPresupuestoFromId(tablaPresupuestos.SelectedRows[0].Cells[0].Value.ToString());

                if (lector != null)
                {
                    if (lector.Read())
                    {
                        string codigo = lector.GetString(0);
                        string formaPago = lector.GetString(1);
                        int codCliente = lector.GetInt32(2);

                        lector.Close();

                        FormularioPresupuesto modificar = new FormularioPresupuesto(bd, codigo, formaPago, codCliente);

                        modificar.Text = "Modificar presupuesto";

                        bd.cargarAticulosFromId(codigo, modificar.tablaArticulos);

                        modificar.actualizarCostes();

                        if (modificar.ShowDialog() == DialogResult.OK)
                        {
                            bd.actualizarPresupuesto(modificar.tbCodPresupuesto.Text, new MySqlDateTime(DateTime.Now), modificar.cbFormaPago.Text, modificar.lTotal.Text.Replace('€', ' ').Trim(), modificar.tbCodigo.Text, modificar.tablaArticulos);
                            
                            bd.cargarPresupuestos(tablaPresupuestos);
                        }

                    }
                }

            }


        }

        private void tbBuscador_TextChanged(object sender, EventArgs e)
        {
            tablaPresupuestos.ClearSelection();
            if (tbBuscador.Text.Length >= 3)
            {
                foreach (DataGridViewRow temp in tablaPresupuestos.Rows)
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
                foreach (DataGridViewRow temp in tablaPresupuestos.Rows)
                {
                    temp.Visible = true;
                }
            }
        }

        private void clonarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tablaPresupuestos.SelectedRows.Count == 1)
            {

                MySqlDataReader lector = bd.getPresupuestoFromId(tablaPresupuestos.SelectedRows[0].Cells[0].Value.ToString());

                if (lector != null)
                {
                    if (lector.Read())
                    {
                        string codigo = lector.GetString(0);
                        string formaPago = lector.GetString(1);
                        int codCliente = lector.GetInt32(2);

                        lector.Close();

                        FormularioPresupuesto clonar = new FormularioPresupuesto(bd, "", formaPago, codCliente);

                        clonar.Text = "Clonar presupuesto";

                        bd.cargarAticulosFromId(codigo, clonar.tablaArticulos);

                        clonar.actualizarCostes();

                        if (clonar.ShowDialog() == DialogResult.OK)
                        {
                            bd.insertarPresupuesto(clonar.tbCodPresupuesto.Text, new MySqlDateTime(DateTime.Now), clonar.cbFormaPago.Text, clonar.lTotal.Text.Replace('€', ' ').Trim(), clonar.tbCodigo.Text, clonar.tablaArticulos);

                            bd.cargarPresupuestos(tablaPresupuestos);
                        }

                    }
                }

            }
        }

        private void pbActualizarPresupuestos_Click(object sender, EventArgs e)
        {
            bd.cargarPresupuestos(tablaPresupuestos);
        }
    }
}
