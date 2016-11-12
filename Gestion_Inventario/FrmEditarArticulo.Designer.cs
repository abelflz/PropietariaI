namespace Gestion_Inventario
{
    partial class FrmEditarArticulo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxArt = new System.Windows.Forms.ComboBox();
            this.cbxTipoInventario = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.txtExiste = new System.Windows.Forms.TextBox();
            this.txtCostoU = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveArticle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxArt);
            this.groupBox1.Controls.Add(this.cbxTipoInventario);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.txtExiste);
            this.groupBox1.Controls.Add(this.txtCostoU);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.SaveArticle);
            this.groupBox1.Location = new System.Drawing.Point(19, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 207);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editar Artículo";
            // 
            // cbxArt
            // 
            this.cbxArt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxArt.FormattingEnabled = true;
            this.cbxArt.Location = new System.Drawing.Point(115, 23);
            this.cbxArt.Name = "cbxArt";
            this.cbxArt.Size = new System.Drawing.Size(100, 21);
            this.cbxArt.TabIndex = 1;
            this.cbxArt.SelectedIndexChanged += new System.EventHandler(this.cbxArt_SelectedIndexChanged);
            // 
            // cbxTipoInventario
            // 
            this.cbxTipoInventario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoInventario.FormattingEnabled = true;
            this.cbxTipoInventario.Location = new System.Drawing.Point(115, 50);
            this.cbxTipoInventario.Name = "cbxTipoInventario";
            this.cbxTipoInventario.Size = new System.Drawing.Size(100, 21);
            this.cbxTipoInventario.TabIndex = 9;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.comboBox3.Location = new System.Drawing.Point(115, 102);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(100, 21);
            this.comboBox3.TabIndex = 8;
            // 
            // txtExiste
            // 
            this.txtExiste.Location = new System.Drawing.Point(115, 128);
            this.txtExiste.Name = "txtExiste";
            this.txtExiste.ReadOnly = true;
            this.txtExiste.Size = new System.Drawing.Size(100, 20);
            this.txtExiste.TabIndex = 5;
            // 
            // txtCostoU
            // 
            this.txtCostoU.Location = new System.Drawing.Point(115, 76);
            this.txtCostoU.Name = "txtCostoU";
            this.txtCostoU.ReadOnly = true;
            this.txtCostoU.Size = new System.Drawing.Size(100, 20);
            this.txtCostoU.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Existencia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Estado del Articulo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Costo Unitario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo Inventario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripción Artículo";
            // 
            // SaveArticle
            // 
            this.SaveArticle.Location = new System.Drawing.Point(56, 169);
            this.SaveArticle.Name = "SaveArticle";
            this.SaveArticle.Size = new System.Drawing.Size(143, 23);
            this.SaveArticle.TabIndex = 6;
            this.SaveArticle.Text = "Guardar Cambios";
            this.SaveArticle.UseVisualStyleBackColor = true;
            this.SaveArticle.Click += new System.EventHandler(this.SaveArticle_Click);
            // 
            // FrmEditarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmEditarArticulo";
            this.Text = "Editar Artículo";
            this.Load += new System.EventHandler(this.FrmEditarArticulo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxTipoInventario;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox txtExiste;
        private System.Windows.Forms.TextBox txtCostoU;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SaveArticle;
        private System.Windows.Forms.ComboBox cbxArt;
    }
}