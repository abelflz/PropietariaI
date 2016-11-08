using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using Gestion_Inventario;

namespace Gestion_Inventario
{
    public partial class Form1 : Form
    {      
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            validacion();
        }

        private void validacion()
        {
            var CS = System.Configuration.ConfigurationManager.ConnectionStrings["GI"].ConnectionString;
            if (string.IsNullOrEmpty(txtUser.Text))
            {
                MessageBox.Show("Debe digitar su nombre de Usuario", "Campo Usuario Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUser.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Debe digitar su Contraseña", "Campo Contraseña Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPass.Focus();
                return;
            }
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CS.ToString();
                con.Open();
                string query = "select count(*) from User_Login where User_Name = @a and Password = @b";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@a", txtUser.Text);
                da.SelectCommand.Parameters.AddWithValue("@b", txtPass.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    try
                    {
                        MessageBox.Show("Bienvenido " + txtUser.Text, "Acceso Autorizado");
                        string query2 = "select rol from User_Login where User_Name = @a";
                        SqlCommand cmd = new SqlCommand(query2, con);
                        cmd.Parameters.Add(new SqlParameter("a", txtUser.Text));
                        var tip = cmd.ExecuteScalar();
                        string tipo = tip.ToString();
                        if (string.IsNullOrEmpty(tipo))
                        {
                            MessageBox.Show("Usuario no válido", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (tipo.Equals("Admin"))
                            {
                                this.Hide();
                                FrmMenu m = new FrmMenu();
                                m.ConnectionString = CS.ToString();
                                m.ShowDialog();
                                this.Close();
                            }
                            else if (tipo.Equals("User"))
                            {
                                this.Hide();
                                FrmMenUser mm = new FrmMenUser();
                                mm.ConnectionString = CS.ToString();
                                mm.ShowDialog();
                                this.Close();
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("DROGA "+e);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUser.Text = "";
                    txtPass.Text = "";
                    txtUser.Focus();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error" , MessageBoxButtons.OK ,  MessageBoxIcon.Error);
            }
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                validacion();
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                validacion();
            }
        }
    }
}