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
    public partial class FrmEditarTransaccion : Form
    {

        public string ConnectionString { get; set; }
        public FrmEditarTransaccion()
        {
            InitializeComponent();
        }

        private void SaveTransaction_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbxIDT.Text))
            {
                MessageBox.Show("Debe seleccionar un ID de transacción", "Error", MessageBoxButtons.OK ,MessageBoxIcon.Error);
                cbxIDT.Focus();
            }else
            {
                if(Convert.ToInt32(textBox5.Text) < 1)
                {
                    MessageBox.Show("La cantidad debe ser positiva para ser una transacción válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    string.IsNullOrEmpty(textBox5.Text);
                    textBox5.Focus();
                }
                else
                {
                    try
                    {
                        calcularPrecio();

                        SqlConnection Conn = new SqlConnection();
                        Conn.ConnectionString = ConnectionString;
                        Conn.Open();

                        string query = "select idArticulo from articulo where descripcion_articulo = '" + cbxDA.Text + "'";
                        SqlCommand cmd = new SqlCommand(query, Conn);
                        var ida = cmd.ExecuteScalar();
                        string IDA = ida.ToString();

                        string query3 = "select existencia from articulo where descripcion_articulo = '" + cbxDA.Text + "'";
                        SqlCommand cmd3 = new SqlCommand(query3, Conn);
                        var exist = cmd3.ExecuteScalar();
                        int existencia = Convert.ToInt32(exist);

                        string query4 = "select cantidad_transaccion from transaccion where idTransaccion = '" + cbxIDT.Text + "'";
                        SqlCommand cmd4 = new SqlCommand(query4, Conn);
                        var cant = cmd4.ExecuteScalar();
                        int cantidad = Convert.ToInt32(cant);

                        int CantidadNueva = Convert.ToInt32(textBox5.Text);

                        int existenciaNueva;

                        if (comboBox5.Text == "Entrada")
                        {
                            /*100 + (25-20) = 100+5 = 105*/
                            existenciaNueva = existencia + (CantidadNueva - cantidad);

                            string queryArticulo = "update articulo set existencia = '" + existenciaNueva + "' where descripcion_articulo = '" + cbxDA.Text + "'";
                            SqlCommand cmd5 = new SqlCommand(queryArticulo, Conn);

                            string queryn = "update transaccion set idArticulo = '" + IDA + "', fecha = '" + Convert.ToDateTime(dateTimePicker1.Text) + "', cantidad_transaccion = '" + CantidadNueva + "', costo = '" + textBox6.Text + "' where idTransaccion = '" + cbxIDT.Text + "'";
                            SqlCommand cmd6 = new SqlCommand(queryn, Conn);

                            MessageBox.Show(cmd6.ExecuteNonQuery() + " Transacción Editada y " + cmd5.ExecuteNonQuery() + " Artículo Actualizado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Conn.Close();

                            FrmMenu menu = (FrmMenu)Application.OpenForms["FrmMenu"];
                            menu.all();
                            menu.viewtransaccion();

                            this.Close();
                        }
                        else if (comboBox5.Text == "Salida")
                        {/*100 - (25-20) = 100-5 = 95; */
                            existenciaNueva = existencia - (CantidadNueva - cantidad);

                            string queryArticulo = "update articulo set existencia = '" + existenciaNueva + "' where descripcion_articulo = '" + cbxDA.Text + "'";
                            SqlCommand cmd5 = new SqlCommand(queryArticulo, Conn);

                            string queryn = "update transaccion set idArticulo = '" + IDA + "', fecha = '" + Convert.ToDateTime(dateTimePicker1.Text) + "', cantidad_transaccion = '" + CantidadNueva + "', costo = '" + textBox6.Text + "' where idTransaccion = '" + cbxIDT.Text + "'";
                            SqlCommand cmd6 = new SqlCommand(queryn, Conn);

                            MessageBox.Show(cmd6.ExecuteNonQuery() + " Transacción Editada y " + cmd5.ExecuteNonQuery() + " Artículo Actualizado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            FrmMenu menu = (FrmMenu)Application.OpenForms["FrmMenu"];

                            menu.all();
                            menu.viewtransaccion();
                            this.Close();
                        }
                    }
                    catch (Exception)
                    {
                    }
                }  
            }
        }

        private void calcularPrecio()
        {
            try
            {
                if (Convert.ToInt32(textBox5.Text) > 0)
                {
                    SqlConnection Conn = new SqlConnection();
                    Conn.ConnectionString = ConnectionString;
                    Conn.Open();

                    string query = "select idArticulo from transaccion where idTransaccion = '" + cbxIDT.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, Conn);
                    var ida = cmd.ExecuteScalar();
                    int idaa = Convert.ToInt32(ida);

                    string query2 = "select costoUnitario from articulo where idArticulo = '" + idaa + "'";
                    SqlCommand cmd2 = new SqlCommand(query2, Conn);
                    var costo = cmd2.ExecuteScalar();
                    int costoo = Convert.ToInt32(costo);

                    int cantidad = Convert.ToInt32(textBox5.Text);

                    textBox6.Text = Convert.ToString(cantidad * costoo);

                    Conn.Close();
                }
                else
                {
                    MessageBox.Show("La cantidad debe ser un valor positivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox5.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Valor Inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox6.Text = "";
                textBox5.Text = "";
            }
        }
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                calcularPrecio();
            }
        }

        private void cbxIDT_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox6.Text = "";
            textBox5.Text = "";
            comboBox5.Items.Clear();
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = ConnectionString;
            Conn.Open();

            string query = "select idArticulo from transaccion where idTransaccion = '" + cbxIDT.Text + "'";
            SqlCommand cmd = new SqlCommand(query, Conn);
            var ida = cmd.ExecuteScalar();
            int idArticulo = Convert.ToInt32(ida);

            string query2 = "select descripcion_articulo from articulo where idArticulo = '" + idArticulo + "'";
            SqlCommand cmd2 = new SqlCommand(query2, Conn);
            var da = cmd2.ExecuteScalar();
            cbxDA.Text = da.ToString();

            string query3 = "select tipo from transaccion where idTransaccion = '" + cbxIDT.Text + "'";
            SqlCommand cmd3 = new SqlCommand(query3, Conn);
            var type = cmd3.ExecuteScalar();
            comboBox5.Items.Add(type.ToString());
            comboBox5.Text = type.ToString();

            string query4 = "select fecha from transaccion where idTransaccion = '" + cbxIDT.Text + "'";
            SqlCommand cmd4 = new SqlCommand(query4, Conn);
            var date = cmd4.ExecuteScalar();
            dateTimePicker1.Text = date.ToString();

            string query5 = "select cantidad_transaccion from transaccion where idTransaccion = '" + cbxIDT.Text + "'";
            SqlCommand cmd5 = new SqlCommand(query5, Conn);
            var cantidad = cmd5.ExecuteScalar();
            textBox5.Text = cantidad.ToString();

            string query6 = "select costo from transaccion where idTransaccion = '" + cbxIDT.Text + "'";
            SqlCommand cmd6 = new SqlCommand(query6, Conn);
            var cost = cmd6.ExecuteScalar();
            textBox6.Text = cost.ToString();

            Conn.Close();           
        }

        private void FrmEditarTransaccion_Load(object sender, EventArgs e)
        {
            llenarCbxIDT();
            llenarCbxDA();
        }

        private void llenarCbxIDT()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = ConnectionString;
            Conn.Open();

            string query = "select * from transaccion where (tipo = 'Salida' or tipo = 'Entrada')";
            SqlCommand cmd = new SqlCommand(query, Conn);
            SqlDataReader sqlReader = cmd.ExecuteReader();

            while (sqlReader.Read())
            {
                cbxIDT.Items.Add(sqlReader["idTransaccion"].ToString());
            }
            Conn.Close();
        }
        private void llenarCbxDA()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = ConnectionString;
            Conn.Open();

            string query = "select descripcion_articulo from articulo";
            SqlCommand cmd = new SqlCommand(query, Conn);
            SqlDataReader sqlReader = cmd.ExecuteReader();

            while (sqlReader.Read())
            {
                cbxDA.Items.Add(sqlReader["descripcion_articulo"].ToString());
            }
            Conn.Close();
        }
    }
}
