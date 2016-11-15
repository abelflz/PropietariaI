namespace Gestion_Inventario
{
    partial class FrmMenUser
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.All = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Buscar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.FindType = new System.Windows.Forms.Button();
            this.FindDate = new System.Windows.Forms.Button();
            this.BuscarT = new System.Windows.Forms.Button();
            this.FindArticleName = new System.Windows.Forms.Button();
            this.cbxRepArt = new System.Windows.Forms.ComboBox();
            this.cbxRepTipo = new System.Windows.Forms.ComboBox();
            this.LbTipo = new System.Windows.Forms.Label();
            this.LbArticulo = new System.Windows.Forms.Label();
            this.GenReport = new System.Windows.Forms.Button();
            this.gbFecha = new System.Windows.Forms.GroupBox();
            this.DateHastaRep = new System.Windows.Forms.DateTimePicker();
            this.DateDesdeRep = new System.Windows.Forms.DateTimePicker();
            this.LbHasta = new System.Windows.Forms.Label();
            this.LbDesde = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ShowAll = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Logout = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbFecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(965, 543);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.All);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(957, 517);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Artículos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 38);
            this.label2.TabIndex = 14;
            this.label2.Text = "Consulta de Artículos";
            // 
            // All
            // 
            this.All.Location = new System.Drawing.Point(254, 410);
            this.All.Name = "All";
            this.All.Size = new System.Drawing.Size(134, 23);
            this.All.TabIndex = 13;
            this.All.Text = "Ver Todos/Actualizar";
            this.All.UseVisualStyleBackColor = true;
            this.All.Click += new System.EventHandler(this.All_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(111, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(436, 330);
            this.dataGridView1.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxEstado);
            this.groupBox1.Controls.Add(this.txtFilter);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.Buscar);
            this.groupBox1.Location = new System.Drawing.Point(612, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 239);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda";
            // 
            // cbxEstado
            // 
            this.cbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbxEstado.Location = new System.Drawing.Point(11, 114);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(178, 21);
            this.cbxEstado.TabIndex = 14;
            this.cbxEstado.Visible = false;
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(11, 114);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(178, 20);
            this.txtFilter.TabIndex = 11;
            this.txtFilter.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Criterio";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ID",
            "Nombre Articulo",
            "Costo Unitario",
            "Estado",
            "Existencia"});
            this.comboBox1.Location = new System.Drawing.Point(11, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(66, 193);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 10;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.ShowAll);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(957, 517);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Transacción";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.FindType);
            this.groupBox4.Controls.Add(this.FindDate);
            this.groupBox4.Controls.Add(this.BuscarT);
            this.groupBox4.Controls.Add(this.FindArticleName);
            this.groupBox4.Controls.Add(this.cbxRepArt);
            this.groupBox4.Controls.Add(this.cbxRepTipo);
            this.groupBox4.Controls.Add(this.LbTipo);
            this.groupBox4.Controls.Add(this.LbArticulo);
            this.groupBox4.Controls.Add(this.GenReport);
            this.groupBox4.Controls.Add(this.gbFecha);
            this.groupBox4.Location = new System.Drawing.Point(622, 52);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(262, 403);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Reportes de Transacción";
            // 
            // FindType
            // 
            this.FindType.Location = new System.Drawing.Point(54, 78);
            this.FindType.Name = "FindType";
            this.FindType.Size = new System.Drawing.Size(165, 23);
            this.FindType.TabIndex = 16;
            this.FindType.Text = "Buscar por Tipo Transacción";
            this.FindType.UseVisualStyleBackColor = true;
            this.FindType.Click += new System.EventHandler(this.FindType_Click);
            // 
            // FindDate
            // 
            this.FindDate.Location = new System.Drawing.Point(74, 144);
            this.FindDate.Name = "FindDate";
            this.FindDate.Size = new System.Drawing.Size(111, 23);
            this.FindDate.TabIndex = 15;
            this.FindDate.Text = "Buscar por Fecha";
            this.FindDate.UseVisualStyleBackColor = true;
            this.FindDate.Click += new System.EventHandler(this.FindDate_Click);
            // 
            // BuscarT
            // 
            this.BuscarT.Location = new System.Drawing.Point(27, 364);
            this.BuscarT.Name = "BuscarT";
            this.BuscarT.Size = new System.Drawing.Size(200, 23);
            this.BuscarT.TabIndex = 1;
            this.BuscarT.Text = "Buscar Transacciones";
            this.BuscarT.UseVisualStyleBackColor = true;
            this.BuscarT.Click += new System.EventHandler(this.BuscarT_Click);
            // 
            // FindArticleName
            // 
            this.FindArticleName.Location = new System.Drawing.Point(74, 12);
            this.FindArticleName.Name = "FindArticleName";
            this.FindArticleName.Size = new System.Drawing.Size(128, 23);
            this.FindArticleName.TabIndex = 14;
            this.FindArticleName.Text = "Buscar por Artículo";
            this.FindArticleName.UseVisualStyleBackColor = true;
            this.FindArticleName.Click += new System.EventHandler(this.FindArticleName_Click);
            // 
            // cbxRepArt
            // 
            this.cbxRepArt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRepArt.FormattingEnabled = true;
            this.cbxRepArt.Location = new System.Drawing.Point(74, 41);
            this.cbxRepArt.Name = "cbxRepArt";
            this.cbxRepArt.Size = new System.Drawing.Size(153, 21);
            this.cbxRepArt.TabIndex = 13;
            this.cbxRepArt.Visible = false;
            // 
            // cbxRepTipo
            // 
            this.cbxRepTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRepTipo.FormattingEnabled = true;
            this.cbxRepTipo.Items.AddRange(new object[] {
            "Entrada",
            "Salida",
            "Ajuste Costo",
            "Ajuste Cantidad"});
            this.cbxRepTipo.Location = new System.Drawing.Point(74, 107);
            this.cbxRepTipo.Name = "cbxRepTipo";
            this.cbxRepTipo.Size = new System.Drawing.Size(153, 21);
            this.cbxRepTipo.TabIndex = 12;
            this.cbxRepTipo.Visible = false;
            // 
            // LbTipo
            // 
            this.LbTipo.AutoSize = true;
            this.LbTipo.Location = new System.Drawing.Point(40, 110);
            this.LbTipo.Name = "LbTipo";
            this.LbTipo.Size = new System.Drawing.Size(28, 13);
            this.LbTipo.TabIndex = 5;
            this.LbTipo.Text = "Tipo";
            this.LbTipo.Visible = false;
            // 
            // LbArticulo
            // 
            this.LbArticulo.AutoSize = true;
            this.LbArticulo.Location = new System.Drawing.Point(24, 44);
            this.LbArticulo.Name = "LbArticulo";
            this.LbArticulo.Size = new System.Drawing.Size(44, 13);
            this.LbArticulo.TabIndex = 4;
            this.LbArticulo.Text = "Artículo";
            this.LbArticulo.Visible = false;
            // 
            // GenReport
            // 
            this.GenReport.Location = new System.Drawing.Point(90, 309);
            this.GenReport.Name = "GenReport";
            this.GenReport.Size = new System.Drawing.Size(75, 23);
            this.GenReport.TabIndex = 0;
            this.GenReport.Text = "Generar";
            this.GenReport.UseVisualStyleBackColor = true;
            this.GenReport.Click += new System.EventHandler(this.GenReport_Click);
            // 
            // gbFecha
            // 
            this.gbFecha.Controls.Add(this.DateHastaRep);
            this.gbFecha.Controls.Add(this.DateDesdeRep);
            this.gbFecha.Controls.Add(this.LbHasta);
            this.gbFecha.Controls.Add(this.LbDesde);
            this.gbFecha.Location = new System.Drawing.Point(27, 173);
            this.gbFecha.Name = "gbFecha";
            this.gbFecha.Size = new System.Drawing.Size(200, 117);
            this.gbFecha.TabIndex = 11;
            this.gbFecha.TabStop = false;
            this.gbFecha.Text = "Fecha";
            this.gbFecha.Visible = false;
            // 
            // DateHastaRep
            // 
            this.DateHastaRep.Location = new System.Drawing.Point(11, 86);
            this.DateHastaRep.Name = "DateHastaRep";
            this.DateHastaRep.Size = new System.Drawing.Size(181, 20);
            this.DateHastaRep.TabIndex = 14;
            this.DateHastaRep.Visible = false;
            // 
            // DateDesdeRep
            // 
            this.DateDesdeRep.Location = new System.Drawing.Point(11, 37);
            this.DateDesdeRep.Name = "DateDesdeRep";
            this.DateDesdeRep.Size = new System.Drawing.Size(181, 20);
            this.DateDesdeRep.TabIndex = 13;
            this.DateDesdeRep.Visible = false;
            // 
            // LbHasta
            // 
            this.LbHasta.AutoSize = true;
            this.LbHasta.Location = new System.Drawing.Point(11, 70);
            this.LbHasta.Name = "LbHasta";
            this.LbHasta.Size = new System.Drawing.Size(35, 13);
            this.LbHasta.TabIndex = 12;
            this.LbHasta.Text = "Hasta";
            this.LbHasta.Visible = false;
            // 
            // LbDesde
            // 
            this.LbDesde.AutoSize = true;
            this.LbDesde.Location = new System.Drawing.Point(8, 21);
            this.LbDesde.Name = "LbDesde";
            this.LbDesde.Size = new System.Drawing.Size(38, 13);
            this.LbDesde.TabIndex = 11;
            this.LbDesde.Text = "Desde";
            this.LbDesde.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(151, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(307, 38);
            this.label3.TabIndex = 15;
            this.label3.Text = "Consulta Transacciones";
            // 
            // ShowAll
            // 
            this.ShowAll.Location = new System.Drawing.Point(235, 447);
            this.ShowAll.Name = "ShowAll";
            this.ShowAll.Size = new System.Drawing.Size(172, 23);
            this.ShowAll.TabIndex = 7;
            this.ShowAll.Text = "Mostrar Todos/Actualizar";
            this.ShowAll.UseVisualStyleBackColor = true;
            this.ShowAll.Click += new System.EventHandler(this.ShowAll_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView2.Location = new System.Drawing.Point(18, 61);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(584, 358);
            this.dataGridView2.TabIndex = 5;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Logout);
            this.tabPage3.Controls.Add(this.label22);
            this.tabPage3.Controls.Add(this.dataGridView4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(957, 517);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tipo Inventario y Deslogueo";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(408, 362);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(75, 23);
            this.Logout.TabIndex = 12;
            this.Logout.Text = "Desloguear";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(322, 55);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(314, 38);
            this.label22.TabIndex = 11;
            this.label22.Text = "Consulta de Inventarios";
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.EnableHeadersVisualStyles = false;
            this.dataGridView4.Location = new System.Drawing.Point(266, 96);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.Size = new System.Drawing.Size(405, 190);
            this.dataGridView4.TabIndex = 10;
            // 
            // FrmMenUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 542);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmMenUser";
            this.Text = "Visualización Inventario";
            this.Load += new System.EventHandler(this.FrmMenUser_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gbFecha.ResumeLayout(false);
            this.gbFecha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button All;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button ShowAll;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label22;
        public System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button FindType;
        private System.Windows.Forms.Button FindDate;
        private System.Windows.Forms.Button BuscarT;
        private System.Windows.Forms.Button FindArticleName;
        private System.Windows.Forms.ComboBox cbxRepArt;
        private System.Windows.Forms.ComboBox cbxRepTipo;
        private System.Windows.Forms.Label LbTipo;
        private System.Windows.Forms.Label LbArticulo;
        private System.Windows.Forms.GroupBox gbFecha;
        private System.Windows.Forms.DateTimePicker DateHastaRep;
        private System.Windows.Forms.DateTimePicker DateDesdeRep;
        private System.Windows.Forms.Label LbHasta;
        private System.Windows.Forms.Label LbDesde;
        private System.Windows.Forms.Button GenReport;
    }
}