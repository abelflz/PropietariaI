namespace Gestion_Inventario
{
    partial class Reporte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rpvReporte = new Microsoft.Reporting.WinForms.ReportViewer();
            
            this.SuspendLayout();
            // 
            // rpvReporte
            // 
            this.rpvReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvReporte.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvReporte.LocalReport.ReportEmbeddedResource = "Gestion_Inventario.Report1.rdlc";
            this.rpvReporte.Location = new System.Drawing.Point(0, 0);
            this.rpvReporte.Name = "rpvReporte";
            this.rpvReporte.Size = new System.Drawing.Size(540, 465);
            this.rpvReporte.TabIndex = 0;
            
            
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 465);
            this.Controls.Add(this.rpvReporte);
            this.Name = "Reporte";
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.Reporte_Load);
            

            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvReporte;
        private System.Windows.Forms.BindingSource TransaccionArticuloBindingSource;
    }
}