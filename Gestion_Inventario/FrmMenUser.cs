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
    public partial class FrmMenUser : Form
    {
        public string ConnectionString { get; set; }
        public FrmMenUser()
        {
            InitializeComponent();
        }

        private void FrmMenUser_Load(object sender, EventArgs e)
        {
            LlenarDGVArticulo();
            LlenarDGVTransaccion();
            LlenarDGVTipoTransaccion();
        }

        private void LlenarDGVTipoTransaccion()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = ConnectionString;
            Conn.Open();
            string query = "select idTipoInventario as 'ID Tipo Inventario', descripcion_inventario as 'Descripción', cuentacontable_inventario as 'Cuenta Contable', estado_inventario as 'Estado' from tipoinventario";
            SqlDataAdapter sda = new SqlDataAdapter(query, Conn);

            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView4.DataSource = data;
            dataGridView4.Refresh();
            dataGridView4.AutoResizeColumns();
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            Conn.Close();
        }

        private void BusquedaTransaccion()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = ConnectionString;
            Conn.Open();

            string query = "SELECT idTransaccion as 'ID Transaccion', " +
                "a.descripcion_articulo as 'Articulo', t.tipo as 'Tipo de Transaccion', "
                + " t.fecha as 'Fecha', t.cantidad_transaccion as 'Cantidad', costo as 'Costo'"
                + " FROM transaccion t INNER JOIN articulo a ON t.idArticulo = a.idArticulo";

            if (comboBox2.Text == "Transaccion ID")
            {
                SqlDataAdapter sda = new SqlDataAdapter(query + " WHERE t.idTransaccion = '" + txtFilter2.Text + "'", Conn);

                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView2.DataSource = data;
                dataGridView2.Refresh();
            }

            else if (comboBox2.Text == "Articulo")
            {
                SqlDataAdapter sda = new SqlDataAdapter(query + " WHERE a.descripcion_articulo like '%" + txtFilter2.Text + "%'", Conn);

                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView2.DataSource = data;
                dataGridView2.Refresh();
            }

            else if (comboBox2.Text == "Tipo")
            {
                SqlDataAdapter sda = new SqlDataAdapter(query + " WHERE t.tipo like '%" + txtFilter2.Text + "%'", Conn);

                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView2.DataSource = data;
                dataGridView2.Refresh();
            }

            else if (comboBox2.Text == "Costo")
            {
                SqlDataAdapter sda = new SqlDataAdapter(query + " WHERE t.costo like '%" + txtFilter2.Text + "%'", Conn);

                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView2.DataSource = data;
                dataGridView2.Refresh();
            }

            Conn.Close();
            txtFilter2.Text = "";
        }

        private void LlenarDGVTransaccion()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = ConnectionString;
            Conn.Open();

            string query = "SELECT idTransaccion as 'ID Transaccion', " +
                "a.descripcion_articulo as 'Articulo', t.tipo as 'Tipo de Transaccion', "
                + " t.fecha as 'Fecha', t.cantidad_transaccion as 'Cantidad', costo as 'Costo'"
                + " FROM transaccion t INNER JOIN articulo a ON t.idArticulo = a.idArticulo";

            SqlDataAdapter da = new SqlDataAdapter(query, Conn);

            DataTable data = new DataTable();
            da.Fill(data);

            dataGridView2.DataSource = data;
            dataGridView2.AutoResizeColumns();
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataGridView2.Refresh();
            dataGridView2.Update();

            Conn.Close();
        }

        private void busquedaDGVArticulo()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = ConnectionString;
            Conn.Open();

            string query = "SELECT a.idArticulo as 'ID', a.descripcion_articulo as 'Nombre Articulo', " +
            " a.costoUnitario as 'Costo Unitario', a.estado_articulo as 'Estado', a.existencia as 'Existencia' " +
            " FROM articulo a ";

            if (comboBox1.Text == "ID")
            {
                SqlDataAdapter sda = new SqlDataAdapter(query + " WHERE a.idArticulo = '" + txtFilter.Text + "'", Conn);


                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView1.DataSource = data;
                dataGridView1.Refresh();
            }
            else if (comboBox1.Text == "Nombre Articulo")
            {
                SqlDataAdapter sda = new SqlDataAdapter(query + " WHERE a.descripcion_articulo like '%" + txtFilter.Text + "%' ORDER BY a.descripcion_articulo", Conn);

                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView1.DataSource = data;
                dataGridView1.Refresh();
            }
            else if (comboBox1.Text == "Costo Unitario")
            {
                SqlDataAdapter sda = new SqlDataAdapter(query + " WHERE a.costoUnitario like '%" + txtFilter.Text + "%'", Conn);


                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView1.DataSource = data;
                dataGridView1.Refresh();
            }
            else if (comboBox1.Text == "Estado")
            {
                SqlDataAdapter sda = new SqlDataAdapter(query + " WHERE a.estado_articulo = '" + txtFilter.Text + "'", Conn);


                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView1.DataSource = data;
                dataGridView1.Refresh();
            }
            else if (comboBox1.Text == "Existencia")
            {
                SqlDataAdapter sda = new SqlDataAdapter(query + " WHERE a.existencia like '%" + txtFilter.Text + "%' order by a.existencia", Conn);
                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView1.DataSource = data;
                dataGridView1.Refresh();
            }

            Conn.Close();
            txtFilter.Text = "";
        }

        private void LlenarDGVArticulo()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = ConnectionString;
            Conn.Open();

            string query = "SELECT a.idArticulo as 'ID', a.descripcion_articulo as 'Nombre Articulo', " +
            " a.costoUnitario as 'Costo Unitario', a.estado_articulo as 'Estado', a.existencia as 'Existencia' " +
            " FROM articulo a ";
            SqlDataAdapter da = new SqlDataAdapter(query, Conn);
            DataTable data = new DataTable();
            da.Fill(data);

            dataGridView1.DataSource = data;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataGridView1.Refresh();
            dataGridView1.Update();

            Conn.Close();
    }

        private void Buscar_Click_1(object sender, EventArgs e)
        {
            busquedaDGVArticulo();
        }

        private void All_Click(object sender, EventArgs e)
        {
            LlenarDGVArticulo();
        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            LlenarDGVTransaccion();
        }

        private void BuscarT_Click(object sender, EventArgs e)
        {
            BusquedaTransaccion();
        }
    }
}
