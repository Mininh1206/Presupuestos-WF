using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System;
using System.Windows.Forms;

namespace ProyectoFinCurso
{
    public partial class Clientes : Form
    {
        BaseDatosMySql bd;

        public Clientes()
        {
            InitializeComponent();
        }

        public Clientes(BaseDatosMySql bd)
        {
            InitializeComponent();
            this.bd = bd;
            bd.cargarClientes(tablaClientes);
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioClientes alta = new FormularioClientes(bd);

            alta.Text = "Alta de cliente";

            if (alta.ShowDialog() == DialogResult.OK)
            {
                string viaDireccion = alta.cbVia.Text.Trim() + " " + alta.tbDireccion.Text.Trim();

                bd.insertarCliente(alta.tbDNI.Text, alta.tbNombre.Text, alta.tbApellidos.Text, new MySqlDateTime(DateTime.Now), new MySqlDateTime(alta.dtFechaNac.Value), alta.tbCodpostal.Text, viaDireccion, bd.getIdMunicipio(alta.cbMunicipios.Text), bd.getIdProvincia(alta.cbProvincias.Text), alta.tbTelefono.Text, alta.tbCorreo.Text);
                bd.cargarClientes(tablaClientes);
            }
        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in tablaClientes.SelectedRows)
            {
                bd.eliminarCliente(fila.Cells[0].Value.ToString());
            }
            bd.cargarClientes(tablaClientes);
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (tablaClientes.SelectedRows.Count==1)
            {

                MySqlDataReader cliente = bd.getClienteFromId(tablaClientes.SelectedRows[0].Cells[0].Value.ToString());

                if (cliente != null)
                {
                    if (cliente.Read())
                    {
                        int codigo = cliente.GetInt32(0);
                        string dni = cliente.GetString(1);
                        string nombre = cliente.GetString(2);
                        string apellidos = cliente.GetString(3);
                        MySqlDateTime fechaAlta = cliente.GetMySqlDateTime(4);
                        MySqlDateTime fechaNac = cliente.GetMySqlDateTime(5);
                        string codPostal = "";
                        try
                        {
                            codPostal = cliente.GetString(6);
                        }
                        catch
                        {

                        }
                        string direccion = "";
                        string via = "";
                        try
                        {
                            via = cliente.GetString(7).Substring(0, cliente.GetString(7).IndexOf(" ")).Trim();
                            direccion = cliente.GetString(7).Substring(cliente.GetString(7).IndexOf(" ")).Trim();
                        }
                        catch
                        {

                        }
                        int poblacion = cliente.GetInt32(8);
                        int provincia = cliente.GetInt32(9);
                        string telefono = "";
                        try
                        {
                            telefono = cliente.GetString(10);
                        }
                        catch
                        {

                        }
                        string email = cliente.GetString(11);

                        cliente.Close();

                        FormularioClientes modificar = new FormularioClientes(bd, codigo, dni, nombre, apellidos, fechaAlta, fechaNac, codPostal, via, direccion, poblacion, provincia, telefono, email);

                        modificar.Text = "Modificar cliente";

                        if (modificar.ShowDialog() == DialogResult.OK)
                        {
                            string viaDireccion = modificar.cbVia.Text.Trim() + " " + modificar.tbDireccion.Text.Trim();

                            bd.actualizarCliente(modificar.codigo, modificar.tbDNI.Text, modificar.tbNombre.Text, modificar.tbApellidos.Text, new MySqlDateTime(modificar.dtFechaNac.Value), modificar.tbCodpostal.Text, viaDireccion, bd.getIdMunicipio(modificar.cbMunicipios.Text), bd.getIdProvincia(modificar.cbProvincias.Text), modificar.tbTelefono.Text, modificar.tbCorreo.Text);
                            bd.cargarClientes(tablaClientes);
                        }
                    }
                }

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

        private void pbAcualizarCliente_Click(object sender, EventArgs e)
        {
            bd.cargarClientes(tablaClientes);
            tablaClientes.ClearSelection();
        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
