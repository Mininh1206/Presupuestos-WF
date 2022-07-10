using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinCurso
{

    public class BaseDatosMySql
    {

        MySqlConnection conexion;
        MySqlCommand comando;
        MySqlDataReader lector;

        public BaseDatosMySql()
        {
            conexion = new MySqlConnection("Database=docargest; Data Source=localhost; User Id=root; Password=admin");
            //conexion.Open();
        }

        public void insertarCliente(string dni, string nombre, string apellidos, MySqlDateTime fechaAlta, MySqlDateTime fechaNac, string codPostal, string direccion, int poblacion, int provincia, string telefono, string email)
        {
            try
            {
                comando = new MySqlCommand("insert into clientes (DNI, Nombre, Apellidos, FechaAlta, FechaNac, CodPostal, Direccion, Poblacion, Provincia, Telefono, Email) values ('" + dni + "', '" + nombre + "', '" + apellidos + "', '" + (fechaAlta.Year + "-" + fechaAlta.Month + "-" + fechaAlta.Day) + "', '" + (fechaNac.Year + "-" + fechaNac.Month + "-" + fechaNac.Day) + "', '" + codPostal + "', '" + direccion + "', " + poblacion + ", " + provincia + ", '" + telefono + "', '" + email + "')", conexion);

                comando.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Error al añadir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void insertarArticulo(string codigo, string descripcion, double precio, string unidad)
        {
            try
            {
                comando = new MySqlCommand("insert into articulos (Codigo, Descripcion, Precio, Unidad) values ('" + codigo + "', '" + descripcion + "', " + precio + ", '" + unidad + "')", conexion);

                comando.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Error al añadir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void insertarPresupuesto(string codPresupuesto, MySqlDateTime fecha, string formaPago, string total, string codCliente, DataGridView tablaArticulos)
        {
            try
            {
                comando = new MySqlCommand("insert into presupuestos (Codigo, Fecha, FormaPago, Total, CodCliente) values ('" + codPresupuesto + "', '" + (fecha.Year + "-" + fecha.Month + "-" + fecha.Day) + "', '" + formaPago + "', " + total.Replace(',', '.') + ", " + codCliente + ")", conexion);

                comando.ExecuteNonQuery();

                foreach (DataGridViewRow fila in tablaArticulos.Rows)
                {
                    comando = new MySqlCommand("insert into articulosPresupuestos (CodPresupuesto, CodArticulo, Cantidad, Precio) values ('" + codPresupuesto + "', '" + fila.Cells[0].Value.ToString() + "', " + fila.Cells[2].Value.ToString().Replace(',', '.') + ", " + fila.Cells[3].Value.ToString().Replace(',', '.') + ")", conexion);

                    comando.ExecuteNonQuery();
                }
                
            }
            catch
            {
                MessageBox.Show("Error al añadir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void actualizarPresupuesto(string codPresupuesto, MySqlDateTime fecha, string formaPago, string total, string codCliente, DataGridView tablaArticulos)
        {
            
                comando = new MySqlCommand("update presupuestos set Fecha='" + (fecha.Year + "-" + fecha.Month + "-" + fecha.Day) + "', FormaPago='" + formaPago + "', Total=" + total.Replace(',', '.') + ", CodCliente=" + codCliente + " where Codigo='"+codPresupuesto+"'", conexion);

                comando.ExecuteNonQuery();

                comando = new MySqlCommand("delete from articulospresupuestos where CodPresupuesto='" + codPresupuesto + "'", conexion);

                comando.ExecuteNonQuery();

                foreach (DataGridViewRow fila in tablaArticulos.Rows)
                {
                    comando = new MySqlCommand("insert into articulosPresupuestos (CodPresupuesto, CodArticulo, Cantidad, Precio) values ('" + codPresupuesto + "', '" + fila.Cells[0].Value.ToString() + "', " + fila.Cells[2].Value.ToString().Replace(',', '.') + ", " + fila.Cells[3].Value.ToString().Replace(',', '.') + ")", conexion);

                    comando.ExecuteNonQuery();
                }

        }

        public void actualizarCliente(int codigo, string dni, string nombre, string apellidos, MySqlDateTime fechaNac, string codPostal, string direccion, int poblacion, int provincia, string telefono, string email)
        {
            comando = new MySqlCommand("update clientes set DNI='"+dni+"', Nombre='"+nombre+"', Apellidos='"+apellidos+"', FechaNac='"+(fechaNac.Year+"-"+fechaNac.Month+"-"+fechaNac.Day)+"', CodPostal='"+codPostal+"', Direccion='"+direccion+"', Poblacion="+poblacion+", Provincia="+provincia+", Telefono='"+telefono+"', Email='"+email+"' where Codigo="+codigo, conexion);

            comando.ExecuteNonQuery();
        }

        public void eliminarCliente(string codigo)
        {
            if (MessageBox.Show("¿Esta seguro de que quiere eliminar el cliente con el código "+codigo+"?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                comando = new MySqlCommand("delete from clientes where Codigo=" + codigo, conexion);

                comando.ExecuteNonQuery();
            }
        }

        public void eliminarArticulo(string codigo)
        {
            if (MessageBox.Show("¿Esta seguro de que quiere eliminar el artículo con el código " + codigo + "?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                comando = new MySqlCommand("delete from articulos where Codigo=" + codigo, conexion);

                comando.ExecuteNonQuery();
            }
        }

        public void eliminarPresupuesto(string codigo)
        {
            if (MessageBox.Show("¿Esta seguro de que quiere eliminar el presupuesto con el código " + codigo + "?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                comando = new MySqlCommand("delete from presupuestos where Codigo='" + codigo + "'", conexion);

                comando.ExecuteNonQuery();
            }
        }

        public void cargarProvincias(ComboBox cProvincias)
        {
            comando = new MySqlCommand("select provincia from provincias", conexion);

            lector = comando.ExecuteReader();

            cProvincias.Items.Clear();

            while (lector.Read())
            {
                cProvincias.Items.Add(lector.GetValue(0));
            }

            lector.Close();

        }

        public void cargarClientes(DataGridView tablaClientes)
        {
            comando = new MySqlCommand("select Codigo, Nombre, Apellidos, Telefono, prov.provincia, mun.municipio from clientes c join provincias prov on c.Provincia=prov.id join municipios mun on c.Poblacion=mun.id", conexion);

            lector = comando.ExecuteReader();

            tablaClientes.Rows.Clear();

            while (lector.Read())
            {
                tablaClientes.Rows.Add(lector.GetValue(0), lector.GetValue(1), lector.GetValue(2), lector.GetValue(3), lector.GetValue(4), lector.GetValue(5));
            }

            lector.Close();

        }

        public void cargarArticulos(DataGridView tablaClientes)
        {
            comando = new MySqlCommand("select Codigo, Descripcion, Precio from articulos", conexion);

            lector = comando.ExecuteReader();

            tablaClientes.Rows.Clear();

            while (lector.Read())
            {
                tablaClientes.Rows.Add(lector.GetValue(0), lector.GetValue(1), lector.GetDouble(2));
            }

            lector.Close();

        }

        public void cargarClientesPre(DataGridView tablaClientes)
        {
            comando = new MySqlCommand("select Codigo, DNI, Nombre, Apellidos, Direccion, CodPostal, Telefono, Email from clientes", conexion);

            lector = comando.ExecuteReader();

            tablaClientes.Rows.Clear();

            while (lector.Read())
            {
                tablaClientes.Rows.Add(lector.GetValue(0), lector.GetValue(1), lector.GetValue(2), lector.GetValue(3), lector.GetValue(4), lector.GetValue(5), lector.GetValue(6), lector.GetValue(7));
            }

            lector.Close();

        }

        public void cargarArticulosPre(DataGridView tablaArticulos)
        {
            comando = new MySqlCommand("select Codigo, Descripcion, Precio from articulos", conexion);

            lector = comando.ExecuteReader();

            tablaArticulos.Rows.Clear();

            while (lector.Read())
            {
                tablaArticulos.Rows.Add(lector.GetString(0), lector.GetString(1), lector.GetDouble(2));
            }

            lector.Close();

        }

        public string getUnidadFromId(string codigo)
        {
            try
            {
                comando = new MySqlCommand("select Unidad from articulos where Codigo='" + codigo + "'", conexion);

                lector = comando.ExecuteReader();

                string unidad = "";

                if (lector.Read())
                {
                    unidad = lector.GetString(0);
                }

                lector.Close();

                return unidad;
            }
            catch
            {
                return "";
            }
        }

        public void cargarPresupuestos(DataGridView tablaPresupuestos)
        {
            comando = new MySqlCommand("select pre.Codigo, pre.Fecha, pre.FormaPago, pre.Total, concat(cli.Nombre, ' ', cli.Apellidos) from presupuestos pre join clientes cli on pre.CodCliente=cli.Codigo", conexion);

            lector = comando.ExecuteReader();

            tablaPresupuestos.Rows.Clear();

            while (lector.Read())
            {
                tablaPresupuestos.Rows.Add(lector.GetString(0), lector.GetMySqlDateTime(1).Day + "-" + lector.GetMySqlDateTime(1).Month + "-" + lector.GetMySqlDateTime(1).Year, lector.GetString(2), lector.GetDouble(3), lector.GetString(4));
            }

            lector.Close();

        }

        public void cargarMunicipios(ComboBox cMunicipios, int id)
        {
            comando = new MySqlCommand("select municipio from municipios where provincia="+id, conexion);

            lector = comando.ExecuteReader();

            cMunicipios.Items.Clear();

            while (lector.Read())
            {
                cMunicipios.Items.Add(lector.GetValue(0));
            }

            lector.Close();

        }

        public int getIdProvincia(string provincia)
        {
            comando = new MySqlCommand("select id from provincias where provincia='" + provincia + "'", conexion);

            lector = comando.ExecuteReader();

            int id = 0;

            if (lector.Read())
                id = lector.GetInt32(0);

            lector.Close();

            return id;

        }

        public string getMunicipio(int poblacion)
        {
            comando = new MySqlCommand("select municipio from municipios where id=" + poblacion, conexion);

            lector = comando.ExecuteReader();

            string r = "";

            if (lector.Read())
                r = lector.GetString(0);

            lector.Close();

            return r;
        }

        public int getIdMunicipio(string municipio)
        {
            comando = new MySqlCommand("select id from municipios where municipio='" + municipio + "'", conexion);

            lector = comando.ExecuteReader();

            int id = 0;

            if (lector.Read())
                id = lector.GetInt32(0);

            lector.Close();

            return id;

        }

        public string getProvincia(int provincia)
        {
            try
            {
                comando = new MySqlCommand("select provincia from provincias where id=" + provincia, conexion);

                lector = comando.ExecuteReader();

                string r = "";

                if (lector.Read())
                    r = lector.GetString(0);

                lector.Close();

                return r;
            }
            catch
            {
                return "";
            }
        }

        public MySqlDataReader getClienteFromId(string codigo)
        {
            try
            {
                comando = new MySqlCommand("select * from clientes where Codigo=" + codigo, conexion);

                lector = comando.ExecuteReader();

                return lector;
            }
            catch
            {
                return null;
            }
        }

        public MySqlDataReader getPresupuestoFromId(string codigo)
        {
            try
            {
                comando = new MySqlCommand("select Codigo, FormaPago, CodCliente from presupuestos where Codigo='" + codigo + "'", conexion);

                lector = comando.ExecuteReader();

                return lector;
            }
            catch
            {
                return null;
            }
        }

        public void cargarAticulosFromId(string codigo, DataGridView tablaArticulos)
        {
            try
            {
                comando = new MySqlCommand("select ap.CodArticulo, a.Descripcion, ap.Cantidad, ap.Precio from articulosPresupuestos ap join articulos a on ap.CodArticulo=a.Codigo where CodPresupuesto='" + codigo+"'", conexion);

                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    tablaArticulos.Rows.Add(lector.GetString(0), lector.GetString(1), lector.GetDouble(2), lector.GetDouble(3));
                }

                lector.Close();
            }
            catch
            {
                MessageBox.Show("Error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool existeArticulo(string codigo)
        {
            comando = new MySqlCommand("select * from articulos where Codigo='" + codigo + "'", conexion);

            lector = comando.ExecuteReader();

            bool existe = false;

            if (lector.Read())
            {
                existe = true;
            }

            lector.Close();

            return existe;
        }

    }
}
