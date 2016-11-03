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
    public partial class FrmEditarTI : Form
    {
        public string ConnectionString { get; set; }
        
        public FrmEditarTI()
        {
            InitializeComponent();
        }

        private void GuardarTipoInventario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbxDI.Text))
            {
                MessageBox.Show("Debe insertar una Descripción (Nombre) de Inventario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxDI.SelectedIndex = -1;
            }
            else
            {
                try
                {
                    SqlConnection Conn = new SqlConnection();
                    Conn.ConnectionString = ConnectionString;
                    Conn.Open();

                    string query = "UPDATE tipoinventario SET cuentacontable_inventario = @cc, estado_inventario = @ei WHERE descripcion_inventario = @des";
                    SqlCommand cmd = new SqlCommand(query, Conn);
                    cmd.Parameters.Add(new SqlParameter("@des", cbxDI.Text));
                    cmd.Parameters.Add(new SqlParameter("@cc", textBox10.Text));
                    cmd.Parameters.Add(new SqlParameter("@ei", comboBox4.Text));
                    MessageBox.Show(cmd.ExecuteNonQuery() + " Tipo de Inventario Editado");
                    
                    Conn.Close();


                    FrmMenu menu = (FrmMenu)Application.OpenForms["FrmMenu"];

                    menu.ConnectionString = this.ConnectionString;
                    menu.viewti();
                    menu.tiAct();

                    menu.dataGridView4.Refresh();

                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Debe insertar una Descripción (Nombre) de Inventario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }   
            }
        }

        private void FrmEditarTI_Load(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = ConnectionString;
            Conn.Open();

            string query = "select descripcion_inventario from tipoinventario";
            SqlCommand cmd = new SqlCommand(query, Conn);
            SqlDataReader sqlReader = cmd.ExecuteReader();

            while (sqlReader.Read())
            {
                cbxDI.Items.Add(sqlReader["descripcion_inventario"].ToString());
            }
        }

        private void cbxDI_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbxDI.Text))
            {
                MessageBox.Show("Debe digitar la Descripción (Nombre) del Inventario");
                cbxDI.SelectedIndex = -1;
            }
            else
            {
                try
                {
                    SqlConnection Conn = new SqlConnection();
                    Conn.ConnectionString = ConnectionString;
                    Conn.Open();

                    string query = "select cuentacontable_inventario from tipoinventario where descripcion_inventario = '" + cbxDI.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, Conn);
                    var CuentaC = cmd.ExecuteScalar();
                    string SCuentaC = CuentaC.ToString();
                    textBox10.Text = SCuentaC;

                    string query2 = "select estado_inventario from tipoinventario where descripcion_inventario = '" + cbxDI.Text + "'";
                    SqlCommand cmd2 = new SqlCommand(query2, Conn);
                    var estado = cmd2.ExecuteScalar();
                    string Sestado = estado.ToString();
                    comboBox4.Text = Sestado;

                    Conn.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Valor digitado no válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
