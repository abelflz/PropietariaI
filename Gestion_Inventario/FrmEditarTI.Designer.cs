namespace Gestion_Inventario
{
    partial class FrmEditarTI
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.GuardarTipoInventario = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbxDI = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxDI);
            this.groupBox2.Controls.Add(this.comboBox4);
            this.groupBox2.Controls.Add(this.GuardarTipoInventario);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.textBox10);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 169);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Editar Tipo de Inventario";
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.comboBox4.Location = new System.Drawing.Point(124, 80);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(122, 21);
            this.comboBox4.TabIndex = 9;
            // 
            // GuardarTipoInventario
            // 
            this.GuardarTipoInventario.Location = new System.Drawing.Point(61, 130);
            this.GuardarTipoInventario.Name = "GuardarTipoInventario";
            this.GuardarTipoInventario.Size = new System.Drawing.Size(120, 23);
            this.GuardarTipoInventario.TabIndex = 4;
            this.GuardarTipoInventario.Text = "Guardar Cambios";
            this.GuardarTipoInventario.UseVisualStyleBackColor = true;
            this.GuardarTipoInventario.Click += new System.EventHandler(this.GuardarTipoInventario_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(78, 83);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Estado";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(124, 49);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(122, 20);
            this.textBox10.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Cuenta Contable";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Descripción Inventario";
            // 
            // cbxDI
            // 
            this.cbxDI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDI.FormattingEnabled = true;
            this.cbxDI.Location = new System.Drawing.Point(125, 23);
            this.cbxDI.Name = "cbxDI";
            this.cbxDI.Size = new System.Drawing.Size(121, 21);
            this.cbxDI.TabIndex = 10;
            this.cbxDI.SelectedIndexChanged += new System.EventHandler(this.cbxDI_SelectedIndexChanged);
            // 
            // FrmEditarTI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 193);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmEditarTI";
            this.Text = "FrmEditarTI";
            this.Load += new System.EventHandler(this.FrmEditarTI_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button GuardarTipoInventario;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbxDI;
    }
}