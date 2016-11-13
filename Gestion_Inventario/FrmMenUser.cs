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
            LlenarCbxArt();
        }

        public void LlenarCbxArt()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = ConnectionString;
            Conn.Open();
            string query = "select descripcion_articulo from articulo";
            SqlCommand cmd = new SqlCommand(query, Conn);

            SqlDataReader sqlReader = cmd.ExecuteReader();

            while (sqlReader.Read())
            {
                cbxArtD.Items.Add(sqlReader["descripcion_articulo"].ToString());
                cbxRepArt.Items.Add(sqlReader["descripcion_articulo"].ToString());
            }
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
                SqlDataAdapter sda = new SqlDataAdapter(query + " WHERE a.descripcion_articulo like '%" + cbxArtD.Text + "%' ORDER BY a.descripcion_articulo", Conn);

                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView1.DataSource = data;
                dataGridView1.Refresh();
            }
            else if (comboBox1.Text == "Costo Unitario")
            {
                try
                {
                    if (Convert.ToDouble(txtFilter.Text) > -1)
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(query + " WHERE a.costoUnitario like '%" + Convert.ToDouble(txtFilter.Text) + "%'", Conn);


                        DataTable data = new DataTable();
                        sda.Fill(data);
                        dataGridView1.DataSource = data;
                        dataGridView1.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("El valor digitado debe ser un número entero positivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Valor digitado no válido (Sólo se permiten números enteros positivos)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox1.Text == "Estado")
            {
                SqlDataAdapter sda = new SqlDataAdapter(query + " WHERE a.estado_articulo = '" + cbxEstado.Text + "'", Conn);


                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView1.DataSource = data;
                dataGridView1.Refresh();
            }
            else if (comboBox1.Text == "Existencia")
            {
                if(Convert.ToDouble(txtFilter.Text) < 0)
                {
                    MessageBox.Show("No se puede digitar un valor negativo");
                }else
                {
                    SqlDataAdapter sda = new SqlDataAdapter(query + " WHERE a.existencia like '%" + txtFilter.Text + "%' order by a.existencia", Conn);
                    DataTable data = new DataTable();
                    sda.Fill(data);
                    dataGridView1.DataSource = data;
                    dataGridView1.Refresh();
                }  
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

        private void Logout_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* ID
             Nombre Articulo
             Costo Unitario
             Estado
             Existencia*/
            switch (comboBox1.SelectedIndex)
            {
                case 3:
                    cbxArtD.Visible = false;
                    txtFilter.Visible = false;
                    cbxEstado.Visible = true;
                    break;
                case 1:
                    txtFilter.Visible = false;
                    cbxEstado.Visible = false;
                    cbxArtD.Visible = true;
                    break;
                default:
                    cbxEstado.Visible = false;
                    cbxArtD.Visible = false;
                    txtFilter.Visible = true;
                    break;
            }
        }

        private void BuscarT_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConnectionString;
            con.Open();
            string q = "";
            string query = "SELECT idTransaccion as 'ID'," +
                " a.descripcion_articulo as 'Articulo', t.tipo as 'Tipo'," +
                " t.fecha as 'Fecha', t.cantidad_transaccion as 'Cantidad', costo as 'Costo'" +
                " FROM transaccion t INNER JOIN articulo a ON t.idArticulo = a.idArticulo ";
            query += " where 1 = 1 ";

            if (!(string.IsNullOrEmpty(cbxRepArt.Text)))
            {
                q = "select idArticulo from articulo where descripcion_articulo = '" + cbxRepArt.Text + "' ";
                SqlCommand cmdq = new SqlCommand(q, con);
                var i = cmdq.ExecuteScalar();
                int ArticuloID = Convert.ToInt32(i);
                query += " and a.idArticulo = '" + ArticuloID + "' ";
            }
            if (!(string.IsNullOrEmpty(cbxRepTipo.Text)))
            {
                query += " and t.tipo = '" + cbxRepTipo.Text + "' ";
            }
            if (DateDesdeRep.Visible == true && DateHastaRep.Visible == true && LbDesde.Visible == true && LbHasta.Visible == true && gbFecha.Visible == true)
            {
                if (Convert.ToDateTime(DateDesdeRep.Text).Date < Convert.ToDateTime(DateHastaRep.Text).Date)
                {
                    query += " and t.fecha between '" + Convert.ToDateTime(DateDesdeRep.Text) + "' and '" + Convert.ToDateTime(DateHastaRep.Text) + "' ";
                }
                else
                {
                    if (Convert.ToDateTime(DateDesdeRep.Text).Date == Convert.ToDateTime(DateHastaRep.Text).Date)
                    {
                        MessageBox.Show("Las fechas son iguales", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        query += " and t.fecha = '" + Convert.ToDateTime(DateDesdeRep.Text) + "' ";
                    }
                    else
                    {
                        MessageBox.Show("Las fechas son inversas", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        query += " and t.fecha between '" + Convert.ToDateTime(DateHastaRep.Text) + "' and '" + Convert.ToDateTime(DateDesdeRep.Text) + "' ";
                    }
                }
            }
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView2.DataSource = dt;
            dataGridView2.Refresh();
            con.Close();
        }

        private void FindArticleName_Click(object sender, EventArgs e)
        {
            if (LbArticulo.Visible == false && cbxRepArt.Visible == false)
            {
                LbArticulo.Visible = true;
                cbxRepArt.Visible = true;
            }
            else
            {
                LbArticulo.Visible = false;
                cbxRepArt.Visible = false;
            }
        }

        private void FindType_Click(object sender, EventArgs e)
        {
            if (LbTipo.Visible == false && cbxRepTipo.Visible == false)
            {
                LbTipo.Visible = true;
                cbxRepTipo.Visible = true;
            }
            else
            {
                LbTipo.Visible = false;
                cbxRepTipo.Visible = false;
            }
        }

        private void FindDate_Click(object sender, EventArgs e)
        {
            if (gbFecha.Visible == false && LbDesde.Visible == false && LbHasta.Visible == false && DateDesdeRep.Visible == false && DateHastaRep.Visible == false)
            {
                gbFecha.Visible = true;
                LbDesde.Visible = true;
                LbHasta.Visible = true;
                DateDesdeRep.Visible = true;
                DateHastaRep.Visible = true;
            }
            else
            {
                gbFecha.Visible = false;
                LbDesde.Visible = false;
                LbHasta.Visible = false;
                DateDesdeRep.Visible = false;
                DateHastaRep.Visible = false;
            }
        }

        private void GenReport_Click(object sender, EventArgs e)
        {
            string estado = "";
            if (gbFecha.Visible == false && DateDesdeRep.Visible == false && DateHastaRep.Visible == false)
            {
                estado = "no";
            }
            else
            {
                estado = "si";
            }
            Reporte r = new Reporte();
            r.user = "user";
            r.ConnectionString = this.ConnectionString;
            r.FechaDesde = DateDesdeRep.Text;
            r.FechaHasta = DateHastaRep.Text;
            r.Darticulo = cbxRepArt.Text;
            r.tipo = cbxRepTipo.Text;
            r.estadoFecha = estado;
            this.Hide();
            r.ShowDialog();
            this.Close();
        }
    }
}
