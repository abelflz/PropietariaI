using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gestion_Inventario
{
    public partial class FrmEditarArticulo : Form
    {
        public string ConnectionString { get; set; }
        public FrmEditarArticulo()
        {
            InitializeComponent();
        }

        private void SaveArticle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbxArt.Text))
            {
                MessageBox.Show("Debe elegir un Artículo de la lista", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxArt.Focus();
            }
            else
            {
                SqlConnection Conn = new SqlConnection();
                Conn.ConnectionString = ConnectionString;
                Conn.Open();

                string query2 = "select idTipoInventario from tipoinventario where descripcion_inventario = '"+ cbxTipoInventario.Text + "'";
                SqlCommand cmd2 = new SqlCommand(query2, Conn);
                var idTipoInven = cmd2.ExecuteScalar();
                string SidTipoInven = idTipoInven.ToString();
                int IidTipoInven = Convert.ToInt32(SidTipoInven);

                string query = "UPDATE articulo SET descripcion_articulo = @descripcion, idTipoInventario = @itipoI, costoUnitario = @costo, estado_articulo = @estado," +
                    " existencia = @existe WHERE descripcion_articulo = @descripcion";
                SqlCommand cmd = new SqlCommand(query, Conn);
                cmd.Parameters.Add(new SqlParameter("@descripcion", cbxArt.Text));
                cmd.Parameters.Add(new SqlParameter("@itipoI", IidTipoInven));
                cmd.Parameters.Add(new SqlParameter("@costo", txtCostoU.Text));
                cmd.Parameters.Add(new SqlParameter("@estado", comboBox3.Text));
                cmd.Parameters.Add(new SqlParameter("@existe", txtExiste.Text));
                MessageBox.Show(cmd.ExecuteNonQuery() + " Articulo Actualizado Exitosamente");
                Conn.Close();

                FrmMenu menu = (FrmMenu)Application.OpenForms["FrmMenu"];
                menu.ConnectionString = this.ConnectionString;

                menu.all();
                menu.Refresh();

                this.Close();
            }
        }

        private void FrmEditarArticulo_Load(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = ConnectionString;
            Conn.Open();
            string query = "select descripcion_inventario from tipoinventario";
            SqlCommand cmd = new SqlCommand(query, Conn);

            SqlDataReader sqlReader = cmd.ExecuteReader();

            while (sqlReader.Read())
            {
                cbxTipoInventario.Items.Add(sqlReader["descripcion_inventario"].ToString());
            }
            Conn.Close();
            Conn.Open();

            string query2 = "select descripcion_articulo from articulo";

            SqlCommand cmd2 = new SqlCommand(query2, Conn);

            SqlDataReader sqlReader2 = cmd2.ExecuteReader();

            while (sqlReader2.Read())
            {
                cbxArt.Items.Add(sqlReader2["descripcion_articulo"].ToString());
            }
            Conn.Close();
        }

        private void cbxArt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection Conn = new SqlConnection();
                Conn.ConnectionString = ConnectionString;
                Conn.Open();
                SqlCommand cmd2 = new SqlCommand("select idTipoInventario from articulo where descripcion_articulo = '" + cbxArt.Text + "'", Conn);
                var idTipo = cmd2.ExecuteScalar();
                string ver = idTipo.ToString();

                string query = "select descripcion_inventario from tipoinventario where idTipoInventario = '"+ ver +"'";
                SqlCommand cmd = new SqlCommand(query, Conn);
                var desc = cmd.ExecuteScalar();
                string descripcion = desc.ToString();

                cbxTipoInventario.Text = descripcion;

                SqlCommand cmd3 = new SqlCommand("select costoUnitario from articulo where descripcion_articulo = '" + cbxArt.Text + "'", Conn);
                var costo = cmd3.ExecuteScalar();
                string Scosto = costo.ToString();
                txtCostoU.Text = Scosto;

                string query4 = "select estado_articulo from articulo where descripcion_articulo = '" + cbxArt.Text + "'";
                SqlCommand cmd4 = new SqlCommand(query4, Conn);
                var estado = cmd4.ExecuteScalar();
                string Sestado = estado.ToString();
                comboBox3.Text = Sestado;

                string query5 = "select existencia from articulo where descripcion_articulo = '" + cbxArt.Text + "'";
                SqlCommand cmd5 = new SqlCommand(query5, Conn);
                var existencia = cmd5.ExecuteScalar();
                string Sexistencia = existencia.ToString();
                txtExiste.Text = Sexistencia;

                Conn.Close();
            }
            catch (Exception)
            {
            }
        }
    }
}
