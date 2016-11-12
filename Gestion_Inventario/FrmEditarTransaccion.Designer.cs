namespace Gestion_Inventario
{
    partial class FrmEditarTransaccion
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
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cbxDA = new System.Windows.Forms.ComboBox();
            this.cbxIDT = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SaveTransaction = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cbxDA);
            this.groupBox7.Controls.Add(this.cbxIDT);
            this.groupBox7.Controls.Add(this.comboBox5);
            this.groupBox7.Controls.Add(this.label1);
            this.groupBox7.Controls.Add(this.dateTimePicker1);
            this.groupBox7.Controls.Add(this.SaveTransaction);
            this.groupBox7.Controls.Add(this.textBox6);
            this.groupBox7.Controls.Add(this.textBox5);
            this.groupBox7.Controls.Add(this.label21);
            this.groupBox7.Controls.Add(this.label20);
            this.groupBox7.Controls.Add(this.label19);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Location = new System.Drawing.Point(12, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(436, 215);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Crear/Editar Transaccion";
            // 
            // cbxDA
            // 
            this.cbxDA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDA.FormattingEnabled = true;
            this.cbxDA.Location = new System.Drawing.Point(126, 52);
            this.cbxDA.Name = "cbxDA";
            this.cbxDA.Size = new System.Drawing.Size(288, 21);
            this.cbxDA.TabIndex = 24;
            // 
            // cbxIDT
            // 
            this.cbxIDT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIDT.FormattingEnabled = true;
            this.cbxIDT.Location = new System.Drawing.Point(125, 25);
            this.cbxIDT.Name = "cbxIDT";
            this.cbxIDT.Size = new System.Drawing.Size(289, 21);
            this.cbxIDT.TabIndex = 23;
            this.cbxIDT.SelectedIndexChanged += new System.EventHandler(this.cbxIDT_SelectedIndexChanged);
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "Entrada",
            "Salida"});
            this.comboBox5.Location = new System.Drawing.Point(125, 80);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(289, 21);
            this.comboBox5.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "ID Transacción";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(125, 104);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(289, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // SaveTransaction
            // 
            this.SaveTransaction.Location = new System.Drawing.Point(164, 186);
            this.SaveTransaction.Name = "SaveTransaction";
            this.SaveTransaction.Size = new System.Drawing.Size(144, 23);
            this.SaveTransaction.TabIndex = 6;
            this.SaveTransaction.Text = "Guardar Cambios";
            this.SaveTransaction.UseVisualStyleBackColor = true;
            this.SaveTransaction.Click += new System.EventHandler(this.SaveTransaction_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(125, 156);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(289, 20);
            this.textBox6.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(125, 130);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(289, 20);
            this.textBox5.TabIndex = 4;
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(86, 160);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(34, 13);
            this.label21.TabIndex = 19;
            this.label21.Text = "Costo";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(71, 135);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 13);
            this.label20.TabIndex = 18;
            this.label20.Text = "Cantidad";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(83, 109);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(37, 13);
            this.label19.TabIndex = 17;
            this.label19.Text = "Fecha";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(91, 83);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(28, 13);
            this.label18.TabIndex = 16;
            this.label18.Text = "Tipo";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 55);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(103, 13);
            this.label17.TabIndex = 15;
            this.label17.Text = "Descripción Artículo";
            // 
            // FrmEditarTransaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 244);
            this.Controls.Add(this.groupBox7);
            this.Name = "FrmEditarTransaccion";
            this.Text = "Editar Transacción";
            this.Load += new System.EventHandler(this.FrmEditarTransaccion_Load);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button SaveTransaction;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox cbxDA;
        private System.Windows.Forms.ComboBox cbxIDT;
    }
}