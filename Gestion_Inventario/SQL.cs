using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Gestion_Inventario
{
    class SQL
    {
        public string ConnectionString { get; set; }
        public string Escalar(string query)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConnectionString;
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            var Valor = cmd.ExecuteScalar();
            string valor = Valor.ToString();
            con.Close();

            return valor;
        }

        public int InsertUpdate(string query)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConnectionString;
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            int row = cmd.ExecuteNonQuery();
            con.Close();
            return row;
        }
    }
}
