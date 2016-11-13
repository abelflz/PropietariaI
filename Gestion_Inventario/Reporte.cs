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
using Microsoft.Reporting.WinForms;

namespace Gestion_Inventario
{
    public partial class Reporte : Form
    {
        public string ConnectionString { get; set; }
        public string Darticulo { get; set; }
        public string tipo { get; set; }
        public string FechaDesde { get; set; }
        public string FechaHasta { get; set; }
        public string estadoFecha { get; set; }

        public Reporte()
        {
            InitializeComponent();
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConnectionString;
            con.Open();
            string q = "";
            string query = "SELECT idTransaccion as 'ID',"+
                " a.descripcion_articulo as 'Articulo', t.tipo as 'Tipo',"+ 
                " t.fecha as 'Fecha', t.cantidad_transaccion as 'Cantidad', costo as 'Costo'"+
                " FROM transaccion t INNER JOIN articulo a ON t.idArticulo = a.idArticulo ";
            query += " where 1 = 1 ";

            if (!(string.IsNullOrEmpty(Darticulo)))
            {
                q = "select idArticulo from articulo where descripcion_articulo = '" +Darticulo + "' ";
                SqlCommand cmdq = new SqlCommand(q, con);
                var i = cmdq.ExecuteScalar();
                int ArticuloID = Convert.ToInt32(i);
                query += " and a.idArticulo = '" + ArticuloID + "' ";
            }
            if (!(string.IsNullOrEmpty(tipo)))
            {
                query += " and t.tipo = '" + tipo + "' ";
            }
            if (estadoFecha == "si")
            {
                if (Convert.ToDateTime(FechaDesde).Date < Convert.ToDateTime(FechaHasta).Date)
                {
                    query += " and t.fecha between '" + Convert.ToDateTime(FechaDesde) + "' and '" + Convert.ToDateTime(FechaHasta) + "' ";
                }
                else
                {
                    if (Convert.ToDateTime(FechaDesde).Date == Convert.ToDateTime(FechaHasta).Date)
                    {
                        MessageBox.Show("Las fechas son iguales", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        query += " and t.fecha = '" + Convert.ToDateTime(FechaDesde) + "' ";
                    }
                    else
                    {
                        MessageBox.Show("Las fechas son inversas", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        query += " and t.fecha between '" + Convert.ToDateTime(FechaHasta) + "' and '" + Convert.ToDateTime(FechaDesde) + "' ";
                    }
                }
            }
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            
            ReportDataSource rds = new ReportDataSource();
            rds.Value = dt;
            rds.Name = "DataSet1";
            rpvReporte.LocalReport.DataSources.Clear();
            rpvReporte.LocalReport.DataSources.Add(rds);
            rpvReporte.LocalReport.ReportEmbeddedResource = "Report1.rdlc";
            rpvReporte.LocalReport.ReportPath = @"Report1.rdlc";
            rpvReporte.LocalReport.Refresh();
            rpvReporte.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.ConnectionString = ConnectionString;
            menu.ShowDialog();
            this.Close();
        }
    }
}
