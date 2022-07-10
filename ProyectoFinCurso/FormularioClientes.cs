using MySql.Data.Types;
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
    public partial class FormularioClientes : Form
    {

        BaseDatosMySql bd;
        public int codigo;

        public FormularioClientes(BaseDatosMySql bd)
        {
            InitializeComponent();
            this.bd = bd;
            bd.cargarProvincias(cbProvincias);
        }

        public FormularioClientes(BaseDatosMySql bd, int codigo, string dni, string nombre, string apellidos, MySqlDateTime fechaAlta, MySqlDateTime fechaNac, string codPostal, string via, string direccion, int poblacion, int provincia, string telefono, string email)
        {
            InitializeComponent();

            this.bd = bd;
            this.codigo = codigo;
            
            tbNombre.Text = nombre;
            tbApellidos.Text = apellidos;
            tbDNI.Text = dni;
            dtFechaNac.Value = fechaNac.Value;

            bd.cargarProvincias(cbProvincias);
            cbProvincias.SelectedItem = bd.getProvincia(provincia);

            bd.cargarMunicipios(cbMunicipios, bd.getIdProvincia(cbProvincias.Text));
            cbMunicipios.SelectedItem = bd.getMunicipio(poblacion);

            cbVia.SelectedItem = via;
            tbDireccion.Text = direccion;
            tbCodpostal.Text = codPostal;
            tbCorreo.Text = email;
            tbTelefono.Text = telefono;
        }

        private void cbProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProvincias.SelectedItem != null)
            {
                cbMunicipios.Enabled = true;
                bd.cargarMunicipios(cbMunicipios, bd.getIdProvincia(cbProvincias.Text));

                tbCodpostal.Text = cbProvincias.SelectedIndex + 1 + "";
            }
            else
            {
                cbMunicipios.Enabled = false;
            }
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            a1.Visible = false;
            a2.Visible = false;
            a3.Visible = false;
            a4.Visible = false;
            a5.Visible = false;
            a6.Visible = false;
            a7.Visible = false;
            error.Visible = false;
            errorVia.Visible = false;

            if (tbNombre.Text.Equals("") || tbApellidos.Text.Equals("") || tbDNI.Text.Equals("") || dtFechaNac.Text.Equals("") || cbProvincias.Text.Equals("") || cbMunicipios.Text.Equals("") || tbCorreo.Text.Equals(""))
            {
                a1.Visible = true;
                a2.Visible = true;
                a3.Visible = true;
                a4.Visible = true;
                a5.Visible = true;
                a6.Visible = true;
                a7.Visible = true;
                error.Visible = true;

            }
            else
            {
                if (tbDireccion.Text.Equals("") || cbVia.SelectedIndex >= 0)
                {
                    if (MessageBox.Show("¿Quiere realizar esta acción?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    errorVia.Visible = true;
                }
            }

            
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            tbNombre.Text = "";
            tbApellidos.Text = "";
            tbDNI.Text = "";
            dtFechaNac.Value = DateTime.Now.Date;
            cbMunicipios.SelectedIndex = -1;
            cbProvincias.SelectedIndex = -1;
            tbDireccion.Text = "";
            tbCodpostal.Text = "";
            tbCorreo.Text = "";
            tbTelefono.Text = "";

        }

        private void cbVia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbVia.SelectedIndex >= 0)
            {
                errorVia.Visible = false;
            }
            else
            {
                errorVia.Visible = true;
            }
        }
    }
}
