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
    public partial class FrmMenu : Form
    {
        public string FechaHasta { get; set; }
        public string FechaDesde { get; set; }
        public string ConnectionString { get; set; }

        public string query = "SELECT a.idArticulo as 'ID', a.descripcion_articulo as 'Nombre Articulo', "+
            " a.costoUnitario as 'Costo Unitario', a.estado_articulo as 'Estado', a.existencia as 'Existencia' "+
            " FROM articulo a ";

        public string query2 = "SELECT idTransaccion as 'ID Transaccion', " +
                "a.descripcion_articulo as 'Articulo', t.tipo as 'Tipo de Transaccion', "
                + " t.fecha as 'Fecha', t.cantidad_transaccion as 'Cantidad', costo as 'Costo'"
                + " FROM transaccion t INNER JOIN articulo a ON t.idArticulo = a.idArticulo";
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            all();
            viewtransaccion();
            viewAlmacen();
            viewti();
            actualizarcbxTi();
            LlenarCbxArt();
            LlenarCbxDelT();
        }

        public void LlenarCbxDelT()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = ConnectionString;
            Conn.Open();

            string query = "select idTransaccion from transaccion";
            SqlCommand cmd = new SqlCommand(query, Conn);

            SqlDataReader sqlReader = cmd.ExecuteReader();

            while (sqlReader.Read())
            {
                cbxDelT.Items.Add(sqlReader["idTransaccion"].ToString());
            }
            Conn.Close();
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
                cbxDelArt.Items.Add(sqlReader["descripcion_articulo"].ToString());
                cbxDescArtT.Items.Add(sqlReader["descripcion_articulo"].ToString());
                cbxRepArt.Items.Add(sqlReader["descripcion_articulo"].ToString());
            }
        }

        public void actualizarcbxTi()
        {

            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = ConnectionString;
            Conn.Open();
            string query2 = "select descripcion_inventario from tipoinventario";
            SqlCommand cmd2 = new SqlCommand(query2, Conn);

            SqlDataReader sqlReader = cmd2.ExecuteReader();

            while (sqlReader.Read())
            {
                cbxTipoInventario.Items.Add(sqlReader["descripcion_inventario"].ToString());
                cbxTIPO.Items.Add(sqlReader["descripcion_inventario"].ToString());
            }
            Conn.Close();
        }

        public void viewti()
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
        private void viewAlmacen() {

            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = ConnectionString;
            Conn.Open();
            string query = "select idAlmacen as 'ID', descripcion_almacen as 'Descripción', estado_almacen as 'Estado' from almacen";
            SqlDataAdapter sda = new SqlDataAdapter(query, Conn);

            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView3.DataSource = data;
            dataGridView3.Refresh();
            dataGridView3.AutoResizeColumns();
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            Conn.Close();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = ConnectionString;
            Conn.Open();

            if (comboBox1.Text == "ID")
            {
                SqlDataAdapter sda = new SqlDataAdapter(query+ " WHERE a.idArticulo = '"+txtFilter.Text+"'", Conn);
                
                
                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView1.DataSource = data;
                dataGridView1.Refresh();
            }
            else if (comboBox1.Text == "Nombre Articulo"){
                SqlDataAdapter sda = new SqlDataAdapter(query+ " WHERE a.descripcion_articulo like '%"+ txtFilter.Text + "%' ORDER BY a.descripcion_articulo", Conn);

                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView1.DataSource = data;
                dataGridView1.Refresh();
            }   
            else if(comboBox1.Text == "Costo Unitario")
            {
                SqlDataAdapter sda = new SqlDataAdapter(query + " WHERE a.costoUnitario like '%" + txtFilter.Text + "%'", Conn);


                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView1.DataSource = data;
                dataGridView1.Refresh();
            }   
            else if(comboBox1.Text == "Estado")
            {
                SqlDataAdapter sda = new SqlDataAdapter(query + " WHERE a.estado_articulo = '" + txtFilter.Text + "'", Conn);


                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView1.DataSource = data;
                dataGridView1.Refresh();
            } 
            else if(comboBox1.Text == "Existencia")
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

        private void All_Click(object sender, EventArgs e)
        {
            all();
        }

        public void all()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = ConnectionString;
            Conn.Open();


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

        private void SaveArticle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDA.Text)) {
                MessageBox.Show("Debe insertar un Nombre al Artículo nuevo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDA.Focus();
            } else
            {
                try
                {
                    if (Convert.ToDouble(txtCostoU.Text) < 1)
                    {
                        MessageBox.Show("El costo del Artículo no puede ser Negativo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        SqlConnection Conn = new SqlConnection();
                        Conn.ConnectionString = ConnectionString;
                        Conn.Open();

                        string query1 = "select idTipoInventario from tipoinventario where descripcion_inventario = '" + cbxTipoInventario.Text + "'";
                        SqlCommand cmd1 = new SqlCommand(query1, Conn);
                        int idTipo = (int)cmd1.ExecuteScalar();

                        string query = "INSERT INTO articulo VALUES(@descripcion, @tipoi, @costo, @estadoA, @existencia)";
                        SqlCommand cmd = new SqlCommand(query, Conn);
                        cmd.Parameters.Add(new SqlParameter("@descripcion", txtDA.Text));
                        cmd.Parameters.Add(new SqlParameter("@tipoi", idTipo));
                        cmd.Parameters.Add(new SqlParameter("@costo", txtCostoU.Text));
                        cmd.Parameters.Add(new SqlParameter("@estadoA", comboBox3.Text));
                        cmd.Parameters.Add(new SqlParameter("@existencia", txtExiste.Text));
                        MessageBox.Show(cmd.ExecuteNonQuery() + " Articulo Agregado Exitosamente");
                        Conn.Close();
                    }
                    cbxTipoInventario.SelectedIndex = -1;
                    comboBox3.SelectedIndex = -1;
                    txtDA.Text = "";
                    txtCostoU.Text = "";
                    txtExiste.Text = "";
                    cbxDelArt.Items.Clear();
                    LlenarCbxArt();
                    all();
                }
                catch (Exception)
                {
                    MessageBox.Show("Valor digitado no válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbxTipoInventario.SelectedIndex = -1;
                    comboBox3.SelectedIndex = -1;
                    txtDA.Text = "";
                    txtCostoU.Text = "";
                    txtExiste.Text = "";
                } 
            }
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            FrmEditarArticulo editar = new FrmEditarArticulo();
            editar.ConnectionString = this.ConnectionString;
            editar.ShowDialog();
        }
        public void viewtransaccion()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = ConnectionString;
            Conn.Open();

            SqlDataAdapter da = new SqlDataAdapter(query2, Conn);

            DataTable data = new DataTable();
            da.Fill(data);

            dataGridView2.DataSource = data;
            dataGridView2.AutoResizeColumns();
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataGridView2.Refresh();
            dataGridView2.Update();

            Conn.Close();
        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            viewtransaccion();
        }

        private void BuscarT_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = ConnectionString;
            Conn.Open();

            if (comboBox2.Text == "Transaccion ID")
            {
                SqlDataAdapter sda = new SqlDataAdapter(query2 + " WHERE t.idTransaccion = '" + txtFilterMenor.Text + "'", Conn);

                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView2.DataSource = data;
                dataGridView2.Refresh();
            }

            else if (comboBox2.Text == "Articulo")
            {
                SqlDataAdapter sda = new SqlDataAdapter(query2 + " WHERE a.descripcion_articulo like '%" + txtFilterMenor.Text + "%'", Conn);

                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView2.DataSource = data;
                dataGridView2.Refresh();
            }

            else if (comboBox2.Text == "Tipo")
            {
                SqlDataAdapter sda = new SqlDataAdapter(query2 + " WHERE t.tipo like '%" + txtFilterMenor.Text + "%'", Conn);

                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView2.DataSource = data;
                dataGridView2.Refresh();
            }

            else if (comboBox2.Text == "Costo")
            {
                SqlDataAdapter sda = new SqlDataAdapter(query2 + " WHERE t.costo like '%" + txtFilterMenor.Text + "%'", Conn);

                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView2.DataSource = data;
                dataGridView2.Refresh();
            }
            else if (comboBox2.Text.Equals("Fecha"))
            { 
                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter(query2 + " WHERE t.fecha between '" + Convert.ToDateTime(dateFilterMenor.Text) + "' and '" + Convert.ToDateTime(dateFilterMayor.Text) + "'", Conn);
                    DataTable data = new DataTable();
                    sda.Fill(data);
                    dataGridView2.DataSource = data;
                    dataGridView2.Refresh();
                }catch(Exception ex)
                {
                    MessageBox.Show(""+ex);
                }
                
            }

            Conn.Close();
            txtFilterMenor.Text = "";
        }

        private void DeleteArticle_Click(object sender, EventArgs e)
        {
            BorrarArticulo();
        }

        private void BorrarArticulo()
        {
            if (string.IsNullOrEmpty(cbxDelArt.Text))
            {
                MessageBox.Show("Debe insertar un ID de Artículo para poder eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxDelArt.Focus();
            }
            else
            {
                try
                {
                    SqlConnection Conn = new SqlConnection();
                    Conn.ConnectionString = ConnectionString;
                    Conn.Open();

                    string query = "DELETE FROM articulo WHERE descripcion_articulo = @articulo";
                    SqlCommand cmd = new SqlCommand(query, Conn);
                    cmd.Parameters.Add(new SqlParameter("@articulo", cbxDelArt.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("1 Articulo Eliminado");
                    Conn.Close();
                    cbxDelArt.SelectedIndex = -1;
                    all();
                    cbxDelArt.Items.Clear();
                    cbxDescArtT.Items.Clear();
                    LlenarCbxArt();
                }
                catch (Exception)
                {
                    MessageBox.Show("Debe eliminar todas las transacciones que tienen dicho artículo para continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbxDelArt.SelectedIndex = -1;
                }
            }
        }

        private void SaveTransaction_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cbxDescArtT.Text))
                {
                    MessageBox.Show("Debe insertar el Artículo a Transferir", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbxDescArtT.Focus();
                }
                else
                {
                    if(textBox6.Text == "")
                    {
                        MessageBox.Show("Debe Presionar enter en Cantidad para Calcular el Costo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox5.Focus();
                    }
                    else
                    {
                       
                        SqlConnection Conn = new SqlConnection();
                        Conn.ConnectionString = ConnectionString;
                        Conn.Open();

                        if (comboBox5.Text == "Ajuste Cantidad")
                        {
                            textBox6.Text = "0";
                        }
                        else if (comboBox5.Text == "Salida" || comboBox5.Text != "Entrada")
                        {
                            EnterTextBox5();
                        }
                        
                        
                        string query4 = "select idArticulo from articulo where descripcion_articulo = '" + cbxDescArtT.Text + "'";
                        SqlCommand cmd4 = new SqlCommand(query4, Conn);
                        var ida = cmd4.ExecuteScalar();
                        int IdArt = Convert.ToInt32(ida);

                        string query = "INSERT INTO transaccion VALUES(@articulo, @tipo, @fecha, @cantidad, @costo)";
                        SqlCommand cmd = new SqlCommand(query, Conn);
                        cmd.Parameters.Add(new SqlParameter("@articulo", IdArt));
                        cmd.Parameters.Add(new SqlParameter("@tipo", comboBox5.Text));
                        cmd.Parameters.Add(new SqlParameter("@fecha", Convert.ToDateTime(dateTimePicker1.Text)));
                        cmd.Parameters.Add(new SqlParameter("@cantidad", textBox5.Text));
                        cmd.Parameters.Add(new SqlParameter("@costo", textBox6.Text));

                        string query2 = "select existencia from articulo where descripcion_articulo = @a";
                        SqlCommand cmd2 = new SqlCommand(query2, Conn);
                        cmd2.Parameters.Add(new SqlParameter("@a", cbxDescArtT.Text));

                        var existe = cmd2.ExecuteScalar();
                        double existencia = Convert.ToDouble(existe);
                        double cantidad = Convert.ToDouble(textBox5.Text);

                        double total;

                        if (comboBox5.Text == "Salida")
                        {
                            total = existencia - cantidad;

                            if (total < 0 )
                            {
                                MessageBox.Show("No hay suficientes artículos requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                textBox5.Text = "" + existencia;
                            }
                            else
                            {
                                string query3 = "UPDATE articulo SET existencia = @a WHERE descripcion_articulo = @c";
                                SqlCommand cmd3 = new SqlCommand(query3, Conn);
                                cmd3.Parameters.Add(new SqlParameter("@a", total));
                                cmd3.Parameters.Add(new SqlParameter("@c", cbxDescArtT.Text));

                                MessageBox.Show(cmd.ExecuteNonQuery() + " Transaccion Guardado Correctamente");
                                MessageBox.Show(cmd3.ExecuteNonQuery() + " Articulo se ha actualizado");
                            }
                        }
                        else if (comboBox5.Text == "Entrada")
                        {
                            EnterTextBox5();
                            total = existencia + cantidad;

                            string query3 = "UPDATE articulo SET existencia = @a WHERE descripcion_articulo = @c";
                            SqlCommand cmd3 = new SqlCommand(query3, Conn);
                            cmd3.Parameters.Add(new SqlParameter("@a", total));
                            cmd3.Parameters.Add(new SqlParameter("@c", cbxDescArtT.Text));

                            MessageBox.Show(cmd.ExecuteNonQuery() + " Transaccion Guardado Correctamente");
                            MessageBox.Show(cmd3.ExecuteNonQuery() + " Articulo se ha actualizado");
                        }
                        else if(comboBox5.Text == "Ajuste Costo")
                        {
                            string query5 = "UPDATE articulo SET costoUnitario = @a WHERE descripcion_articulo = @b";
                            SqlCommand cmd5 = new SqlCommand(query5, Conn);
                            cmd5.Parameters.Add(new SqlParameter("@a", textBox6.Text));
                            cmd5.Parameters.Add(new SqlParameter("@b", cbxDescArtT.Text));
                            int x = 0;
                            string query55 = "INSERT INTO transaccion VALUES(@articulo, @tipo, @fecha, @cantidad, @costo)";
                            SqlCommand cmd55 = new SqlCommand(query55, Conn);
                            cmd55.Parameters.Add(new SqlParameter("@articulo", IdArt));
                            cmd55.Parameters.Add(new SqlParameter("@tipo", comboBox5.Text));
                            cmd55.Parameters.Add(new SqlParameter("@fecha", Convert.ToDateTime(dateTimePicker1.Text)));
                            cmd55.Parameters.Add(new SqlParameter("@cantidad", x));
                            cmd55.Parameters.Add(new SqlParameter("@costo", textBox6.Text));
                            if (Convert.ToInt32(textBox6.Text) > -1) {
                                MessageBox.Show(cmd55.ExecuteNonQuery() + " Transaccion Guardado Correctamente");
                                MessageBox.Show(cmd5.ExecuteNonQuery() + " Articulo se ha actualizado");
                            }
                            else
                            {
                                MessageBox.Show("Valor digitado no puede ser negativo", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }                           
                        }
                        else if(comboBox5.Text == "Ajuste Cantidad")
                        {
                            string query6 = "UPDATE articulo SET existencia = @a WHERE descripcion_articulo = @b";
                            SqlCommand cmd6 = new SqlCommand(query6, Conn);
                            cmd6.Parameters.Add(new SqlParameter("@a", textBox5.Text));
                            cmd6.Parameters.Add(new SqlParameter("@b", cbxDescArtT.Text));
                            int x = 0;
                            string query66 = "INSERT INTO transaccion VALUES(@articulo, @tipo, @fecha, @cantidad, @costo)";
                            SqlCommand cmd66 = new SqlCommand(query66, Conn);
                            cmd66.Parameters.Add(new SqlParameter("@articulo", IdArt));
                            cmd66.Parameters.Add(new SqlParameter("@tipo", comboBox5.Text));
                            cmd66.Parameters.Add(new SqlParameter("@fecha", Convert.ToDateTime(dateTimePicker1.Text)));
                            cmd66.Parameters.Add(new SqlParameter("@cantidad", textBox5.Text));
                            cmd66.Parameters.Add(new SqlParameter("@costo", x));

                            if(Convert.ToInt32(textBox5.Text) > 0)
                            {
                                MessageBox.Show(cmd66.ExecuteNonQuery() + " Transaccion Guardado Correctamente");
                                MessageBox.Show(cmd6.ExecuteNonQuery() + " Articulo se ha actualizado");
                            }else
                            {
                                MessageBox.Show("Valor digitado debe ser positivo", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);   
                            } 
                        }

                        Conn.Close();

                        all();
                        viewtransaccion();
                        cbxDescArtT.SelectedIndex = -1;
                        comboBox5.SelectedIndex = -1;
                        cbxDelT.Items.Clear();
                        LlenarCbxDelT();
                        textBox5.Text = "";
                        textBox6.Text = "";
                        textBox5.ReadOnly = false;
                        textBox6.ReadOnly = true;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El valor digitado debe ser un número positivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbxDescArtT.SelectedIndex = -1;
                comboBox5.SelectedIndex = -1;
                textBox5.Text = "";
                textBox5.ReadOnly = false;
                textBox6.Text = "";
                textBox6.ReadOnly = true;
            }
        }

        private void EditarTransaccion_Click(object sender, EventArgs e)
        {
            FrmEditarTransaccion editart = new FrmEditarTransaccion();
            editart.ConnectionString = this.ConnectionString;
            editart.ShowDialog();
        }

        private void EliminarTransaccion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbxDelT.Text))
            {
                MessageBox.Show("Debe insertar un Nombre de Transacción", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlConnection Conn = new SqlConnection();
                Conn.ConnectionString = ConnectionString;
                Conn.Open();

                string query = "DELETE FROM transaccion WHERE idTransaccion = @t";
                SqlCommand cmd = new SqlCommand(query, Conn);
                cmd.Parameters.Add(new SqlParameter("@t", cbxDelT.Text));
                MessageBox.Show(cmd.ExecuteNonQuery() + " Transacción Eliminada");
                Conn.Close();

                cbxDelT.Items.Clear();
                LlenarCbxDelT();
                cbxDelT.SelectedIndex = -1;
                all();
                viewtransaccion();
            }
        }

        private void EliminarTipoInventario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbxTIPO.Text))
            {
                MessageBox.Show("Debe insertar un ID de Artículo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxTIPO.Focus();
            }
            else
            {
                try
                {
                    SqlConnection Conn = new SqlConnection();
                    Conn.ConnectionString = ConnectionString;
                    Conn.Open();

                    string query = "DELETE FROM tipoinventario WHERE descripcion_inventario = @t";
                    SqlCommand cmd = new SqlCommand(query, Conn);
                    cmd.Parameters.Add(new SqlParameter("@t", cbxTIPO.Text));
                    MessageBox.Show(cmd.ExecuteNonQuery() + " Tipo de Inventario Eliminado");
                    Conn.Close();

                    cbxTIPO.SelectedIndex = -1;
                    viewti();
                    tiAct();
                }
                catch (Exception)
                {
                    MessageBox.Show("Este tipo de Inventario debe de estar vacío para que se pueda eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbxTIPO.Text = "";
                }
            }
        }

        public void tiAct()
        {
            cbxTIPO.Items.Clear();
            cbxTipoInventario.Items.Clear();
            actualizarcbxTi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox9.Text) || string.IsNullOrEmpty(textBox10.Text) || string.IsNullOrEmpty(comboBox4.Text))
            {
                MessageBox.Show("Debe insertar una Descripción (Nombre) de Tipo de Inventario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox9.Focus();
            }
            else
            {
                SqlConnection Conn = new SqlConnection();
                Conn.ConnectionString = ConnectionString;
                Conn.Open();

                string query = "INSERT INTO tipoinventario VALUES(@des, @cc, @ei)";
                SqlCommand cmd = new SqlCommand(query, Conn);
                cmd.Parameters.Add(new SqlParameter("@des", textBox9.Text));
                cmd.Parameters.Add(new SqlParameter("@cc", textBox10.Text));
                cmd.Parameters.Add(new SqlParameter("@ei", comboBox4.Text));
                MessageBox.Show(cmd.ExecuteNonQuery() + " Tipo de Inventario Agregado");

                actualizarcbxTi();
                viewti();
                Conn.Close();
            }
            textBox9.Text = "";
            textBox10.Text = "";
            comboBox4.SelectedIndex = -1;
            tiAct();
        }

        private void EditarTipoInventario_Click(object sender, EventArgs e)
        {
            FrmEditarTI editarTI = new FrmEditarTI();
            editarTI.ConnectionString = this.ConnectionString;
            editarTI.ShowDialog();
        }

        private void MostrarAlmaceen_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = ConnectionString;
            Conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM almacen", Conn);

            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView3.DataSource = data;
            dataGridView3.Refresh();

            Conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            viewti();
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                EnterTextBox5();
            }
        }

        public void EnterTextBox5()
        { 
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Debe digitar la Cantidad a Transferir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                try
                {
                    if (Convert.ToDouble(textBox5.Text) < 1 && comboBox5.Text != "Ajuste Costo")
                    {
                        MessageBox.Show("Debe digitar una Cantidad Mayor que 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        textBox5.Text = "";
                        textBox5.Focus();
                    }
                    else
                    {
                        if(comboBox5.Text != "Ajuste Costo")
                        {
                            SqlConnection Conn = new SqlConnection();
                            Conn.ConnectionString = ConnectionString;
                            Conn.Open();

                            string query = "select costoUnitario from articulo where descripcion_articulo = @a";
                            SqlCommand cmd = new SqlCommand(query, Conn);
                            cmd.Parameters.Add(new SqlParameter("@a", cbxDescArtT.Text));

                            var Costo = cmd.ExecuteScalar();
                            double dCosto = Convert.ToDouble(Costo);
                            double CantidadPedida = Convert.ToDouble(textBox5.Text);

                            textBox6.Text = Convert.ToString(dCosto * CantidadPedida);
                            Conn.Close();
                        }else
                        {
                            
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Debe digitar un número", "Valor ingresado no válido", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    textBox5.Text = "";
                    textBox5.Focus();
                }
            }  
        }

        private void cbxDescArtT_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection Conn = new SqlConnection();
                Conn.ConnectionString = ConnectionString;
                Conn.Open();

                string query = "select idTipoInventario from articulo where descripcion_articulo = '" + cbxDescArtT.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Conn);
                var idtipo = cmd.ExecuteScalar();
                int idtipoI = Convert.ToInt32(idtipo);

                string query2 = "select descripcion_inventario from tipoinventario where idTipoInventario = '" + idtipoI + "'";
                SqlCommand cmd2 = new SqlCommand(query2, Conn);
                var dInv = cmd2.ExecuteScalar();
                string DInv = dInv.ToString();
                comboBox5.Text = DInv;

                Conn.Close();
            }
            catch (Exception)
            {
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox5.Text == "Ajuste Costo")
            {
                textBox6.ReadOnly = false;
                textBox5.Text = "0";
                textBox5.ReadOnly = true;

                SqlConnection Conn = new SqlConnection();
                Conn.ConnectionString = ConnectionString;
                Conn.Open();

                string query = "select costoUnitario from articulo where descripcion_articulo = '"+cbxDescArtT.Text+"'";
                SqlCommand cmd = new SqlCommand(query, Conn);
                try
                {
                    var cost = cmd.ExecuteScalar();
                    textBox6.Text = cost.ToString();
                }
                catch(Exception) {
                    MessageBox.Show("Debe elegir el artículo que va a ajustar Costo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboBox5.SelectedIndex = -1;
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox5.ReadOnly = false;
                    textBox6.ReadOnly = true;
                }   
            }
            else if(comboBox5.Text == "Ajuste Cantidad")
            {
                textBox6.Text = "0";
                textBox6.ReadOnly = true;
                textBox5.ReadOnly = false;

                SqlConnection Conn = new SqlConnection();
                Conn.ConnectionString = ConnectionString;
                Conn.Open();

                string query = "select existencia from articulo where descripcion_articulo = '" + cbxDescArtT.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Conn);
                try
                {
                    var exist = cmd.ExecuteScalar();
                    textBox5.Text = exist.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Debe elegir el artículo a ajustar Cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboBox5.SelectedIndex = -1;
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox5.ReadOnly = false;
                    textBox6.ReadOnly = true;
                }   
            }
            else if(comboBox5.Text == "Entrada" || comboBox5.Text == "Salida")
            {
                textBox5.ReadOnly = false;
                textBox6.ReadOnly = true;
                textBox5.Text = "";
                textBox6.Text = "";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.Text)
            {
                case "Fecha":
                    txtFilterMenor.Visible = false;
                    dateFilterMenor.Visible = true;
                    dateFilterMayor.Visible = true;
                    d.Visible = true;
                    h.Visible = true;
                    break;
                default:
                    txtFilterMenor.Visible = true;
                    dateFilterMenor.Visible = false;
                    dateFilterMayor.Visible = false;
                    d.Visible = false;
                    h.Visible = false;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConnectionString;
            con.Open();

            string query = "select * from transacciones";
            query += " where 1 = 1 ";

        }

        private void button5_Click(object sender, EventArgs e)
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

        private void button7_Click(object sender, EventArgs e)
        {
            if (LbTipo.Visible == false && cbxRepTipo.Visible == false) {
                LbTipo.Visible = true;
                cbxRepTipo.Visible = true;
            }
            else
            {
                LbTipo.Visible = false;
                cbxRepTipo.Visible = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
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
    }
}
