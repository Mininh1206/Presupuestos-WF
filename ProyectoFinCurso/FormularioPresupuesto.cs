using MySql.Data.MySqlClient;
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
    public partial class FormularioPresupuesto : Form
    {
        BaseDatosMySql bd;

        public FormularioPresupuesto(BaseDatosMySql bd)
        {
            InitializeComponent();
            this.bd = bd;
        }

        public FormularioPresupuesto(BaseDatosMySql bd, string codigo, string formaPago, int codCliente)
        {
            InitializeComponent();
            this.bd = bd;

            if (codigo.Equals(""))
            {
                tbCodPresupuesto.Text = "";
            }
            else
            {
                tbCodPresupuesto.Text = codigo;
                tbCodPresupuesto.Enabled = false;
            }

            tbCodigo.Text = codCliente+"";
            cbFormaPago.SelectedItem = formaPago;

            actualizarDatosCliente();

        }

        private void tbCodigo_TextChanged(object sender, EventArgs e)
        {
            if (!tbCodigo.Text.Equals(""))
            {
                actualizarDatosCliente();
            }
            else
            {
                lNombre.Text = "";
                lApellidos.Text = "";
                lDNI.Text = "";
                lTelefono.Text = "";
                lDireccion.Text = "";
                lCodPostal.Text = "";
                lCorreo.Text = "";
            }


        }

        private void actualizarDatosCliente()
        {
            MySqlDataReader cliente = bd.getClienteFromId(tbCodigo.Text);

            if (cliente != null)
            {
                if (cliente.Read())
                {
                    lDNI.Text = cliente.GetString(1);
                    lNombre.Text = cliente.GetString(2);
                    lApellidos.Text = cliente.GetString(3);
                    lCorreo.Text = cliente.GetString(11);

                    try
                    {
                        lCodPostal.Text = cliente.GetString(6).Equals("") ? "N/A" : cliente.GetString(6);
                    }
                    catch
                    {
                        lCodPostal.Text = "N/A";
                    }

                    try
                    {
                        lDireccion.Text = cliente.GetString(7).Equals("") ? "N/A" : cliente.GetString(7);
                    }
                    catch
                    {
                        lDireccion.Text = "N/A";
                    }

                    try
                    {
                        lTelefono.Text = cliente.GetString(10).Equals("") ? "N/A" : cliente.GetString(10);
                    }
                    catch
                    {
                        lTelefono.Text = "N/A";
                    }

                }
                else
                {
                    lNombre.Text = "N/A";
                    lApellidos.Text = "N/A";
                    lDNI.Text = "N/A";
                    lTelefono.Text = "N/A";
                    lDireccion.Text = "N/A";
                    lCodPostal.Text = "N/A";
                    lCorreo.Text = "N/A";

                }

                cliente.Close();
            }
            else
            {
                lNombre.Text = "";
                lApellidos.Text = "";
                lDNI.Text = "";
                lTelefono.Text = "";
                lDireccion.Text = "";
                lCodPostal.Text = "";
                lCorreo.Text = "";
            }
        }

        private void pbBuscarcliente_Click(object sender, EventArgs e)
        {
            SelectorCliente sc = new SelectorCliente(bd);

            if (sc.ShowDialog() == DialogResult.OK)
            {
                tbCodigo.Text = sc.codigo;
            }
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            tbCodigo.Text = "";
            if (tbCodPresupuesto.Enabled)
            {
                tbCodPresupuesto.Text = "";
            }
            cbFormaPago.SelectedIndex = -1;
            tablaArticulos.Rows.Clear();

            actualizarCostes();
        }

        private void pbAgregarArticulo_Click(object sender, EventArgs e)
        {
            SelectorArticulo sa = new SelectorArticulo(bd);

            if (sa.ShowDialog() == DialogResult.OK)
            {
                tablaArticulos.Rows.Add(sa.fila.Cells[0].Value.ToString(), sa.fila.Cells[1].Value.ToString(), sa.tbCantidad.Text, sa.fila.Cells[2].Value.ToString());
            }

            actualizarCostes();
        }

        private void pbEliminarArticulo_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in tablaArticulos.SelectedRows)
            {
                if (MessageBox.Show("¿Está seguro de que quiere quitar el artículo '"+fila.Cells[1].Value.ToString()+"' de la lista?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    tablaArticulos.Rows.Remove(fila);
                }
            }

            actualizarCostes();
        }

        public void actualizarCostes()
        {
            double total = 0;

            foreach (DataGridViewRow fila in tablaArticulos.Rows)
            {
                double precio = double.Parse(fila.Cells[2].Value.ToString()) * double.Parse(fila.Cells[3].Value.ToString());
                fila.Cells[4].Value = precio;
                total += precio;
            }

            lTotal.Text = total + "€";

        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            a1.Visible = false;
            a2.Visible = false;
            a3.Visible = false;
            error.Visible = false;

            if (tablaArticulos.RowCount == 0 || tbCodigo.Text.Equals("") || tbCodPresupuesto.Text.Equals("") || cbFormaPago.SelectedIndex < 0)
            {
                a1.Visible = true;
                a2.Visible = true;
                a3.Visible = true;
                error.Visible = true;
            }
            else
            {
                if (MessageBox.Show("¿Quiere realizar esta acción?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
