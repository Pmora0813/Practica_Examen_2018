namespace Practica_Examen_2018
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnAutoStar = new System.Windows.Forms.RadioButton();
            this.RbtnPurdyMotor = new System.Windows.Forms.RadioButton();
            this.rbtnGrupoQ = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.rbtnAutomanica = new System.Windows.Forms.RadioButton();
            this.rbtnManual = new System.Windows.Forms.RadioButton();
            this.cmbCombustible = new System.Windows.Forms.ComboBox();
            this.npdPrecioBase = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkAlarma = new System.Windows.Forms.CheckBox();
            this.chkHalogeno = new System.Windows.Forms.CheckBox();
            this.chkCamara = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.mskTelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.wbbMostrar = new System.Windows.Forms.WebBrowser();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnCotizar = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.npdMeses = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npdPrecioBase)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npdMeses)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnAutoStar);
            this.groupBox1.Controls.Add(this.RbtnPurdyMotor);
            this.groupBox1.Controls.Add(this.rbtnGrupoQ);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agencia";
            // 
            // rbtnAutoStar
            // 
            this.rbtnAutoStar.AutoSize = true;
            this.rbtnAutoStar.Location = new System.Drawing.Point(256, 29);
            this.rbtnAutoStar.Name = "rbtnAutoStar";
            this.rbtnAutoStar.Size = new System.Drawing.Size(69, 17);
            this.rbtnAutoStar.TabIndex = 2;
            this.rbtnAutoStar.TabStop = true;
            this.rbtnAutoStar.Text = "Auto Star";
            this.rbtnAutoStar.UseVisualStyleBackColor = true;
            // 
            // RbtnPurdyMotor
            // 
            this.RbtnPurdyMotor.AutoSize = true;
            this.RbtnPurdyMotor.Location = new System.Drawing.Point(122, 29);
            this.RbtnPurdyMotor.Name = "RbtnPurdyMotor";
            this.RbtnPurdyMotor.Size = new System.Drawing.Size(82, 17);
            this.RbtnPurdyMotor.TabIndex = 1;
            this.RbtnPurdyMotor.TabStop = true;
            this.RbtnPurdyMotor.Text = "Purdy Motor";
            this.RbtnPurdyMotor.UseVisualStyleBackColor = true;
            // 
            // rbtnGrupoQ
            // 
            this.rbtnGrupoQ.AutoSize = true;
            this.rbtnGrupoQ.Location = new System.Drawing.Point(6, 29);
            this.rbtnGrupoQ.Name = "rbtnGrupoQ";
            this.rbtnGrupoQ.Size = new System.Drawing.Size(65, 17);
            this.rbtnGrupoQ.TabIndex = 0;
            this.rbtnGrupoQ.TabStop = true;
            this.rbtnGrupoQ.Text = "Grupo Q";
            this.rbtnGrupoQ.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbCategoria);
            this.groupBox2.Controls.Add(this.rbtnAutomanica);
            this.groupBox2.Controls.Add(this.rbtnManual);
            this.groupBox2.Controls.Add(this.cmbCombustible);
            this.groupBox2.Controls.Add(this.npdPrecioBase);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(11, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 173);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vehículo";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(94, 137);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoria.TabIndex = 6;
            // 
            // rbtnAutomanica
            // 
            this.rbtnAutomanica.AutoSize = true;
            this.rbtnAutomanica.Location = new System.Drawing.Point(220, 103);
            this.rbtnAutomanica.Name = "rbtnAutomanica";
            this.rbtnAutomanica.Size = new System.Drawing.Size(78, 17);
            this.rbtnAutomanica.TabIndex = 4;
            this.rbtnAutomanica.TabStop = true;
            this.rbtnAutomanica.Text = "Automática";
            this.rbtnAutomanica.UseVisualStyleBackColor = true;
            // 
            // rbtnManual
            // 
            this.rbtnManual.AutoSize = true;
            this.rbtnManual.Location = new System.Drawing.Point(94, 103);
            this.rbtnManual.Name = "rbtnManual";
            this.rbtnManual.Size = new System.Drawing.Size(60, 17);
            this.rbtnManual.TabIndex = 3;
            this.rbtnManual.TabStop = true;
            this.rbtnManual.Text = "Manual";
            this.rbtnManual.UseVisualStyleBackColor = true;
            // 
            // cmbCombustible
            // 
            this.cmbCombustible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCombustible.FormattingEnabled = true;
            this.cmbCombustible.Location = new System.Drawing.Point(95, 63);
            this.cmbCombustible.Name = "cmbCombustible";
            this.cmbCombustible.Size = new System.Drawing.Size(121, 21);
            this.cmbCombustible.TabIndex = 5;
            // 
            // npdPrecioBase
            // 
            this.npdPrecioBase.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.npdPrecioBase.Location = new System.Drawing.Point(95, 24);
            this.npdPrecioBase.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.npdPrecioBase.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.npdPrecioBase.Name = "npdPrecioBase";
            this.npdPrecioBase.Size = new System.Drawing.Size(120, 20);
            this.npdPrecioBase.TabIndex = 4;
            this.npdPrecioBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.npdPrecioBase.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Categoría";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Transmisión";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Combustible";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Precio Base";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkAlarma);
            this.groupBox3.Controls.Add(this.chkHalogeno);
            this.groupBox3.Controls.Add(this.chkCamara);
            this.groupBox3.Location = new System.Drawing.Point(11, 301);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(347, 73);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Extras";
            // 
            // chkAlarma
            // 
            this.chkAlarma.AutoSize = true;
            this.chkAlarma.Location = new System.Drawing.Point(176, 29);
            this.chkAlarma.Name = "chkAlarma";
            this.chkAlarma.Size = new System.Drawing.Size(58, 17);
            this.chkAlarma.TabIndex = 2;
            this.chkAlarma.Text = "Alarma";
            this.chkAlarma.UseVisualStyleBackColor = true;
            // 
            // chkHalogeno
            // 
            this.chkHalogeno.AutoSize = true;
            this.chkHalogeno.Location = new System.Drawing.Point(253, 29);
            this.chkHalogeno.Name = "chkHalogeno";
            this.chkHalogeno.Size = new System.Drawing.Size(72, 17);
            this.chkHalogeno.TabIndex = 1;
            this.chkHalogeno.Text = "Halógeno";
            this.chkHalogeno.UseVisualStyleBackColor = true;
            // 
            // chkCamara
            // 
            this.chkCamara.AutoSize = true;
            this.chkCamara.Location = new System.Drawing.Point(28, 29);
            this.chkCamara.Name = "chkCamara";
            this.chkCamara.Size = new System.Drawing.Size(129, 17);
            this.chkCamara.TabIndex = 0;
            this.chkCamara.Text = "Cámara de Retroceso";
            this.chkCamara.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.mskTelefono);
            this.groupBox4.Controls.Add(this.txtEmail);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(11, 398);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(347, 117);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cliente";
            // 
            // mskTelefono
            // 
            this.mskTelefono.Location = new System.Drawing.Point(85, 67);
            this.mskTelefono.Mask = "00000000";
            this.mskTelefono.Name = "mskTelefono";
            this.mskTelefono.Size = new System.Drawing.Size(100, 20);
            this.mskTelefono.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(86, 37);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Teléfono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Email";
            // 
            // wbbMostrar
            // 
            this.wbbMostrar.Location = new System.Drawing.Point(380, 28);
            this.wbbMostrar.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbbMostrar.Name = "wbbMostrar";
            this.wbbMostrar.Size = new System.Drawing.Size(333, 682);
            this.wbbMostrar.TabIndex = 3;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnCotizar);
            this.groupBox5.Controls.Add(this.txtTotal);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.npdMeses);
            this.groupBox5.Location = new System.Drawing.Point(11, 530);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(347, 117);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Cotización";
            // 
            // btnCotizar
            // 
            this.btnCotizar.Location = new System.Drawing.Point(238, 21);
            this.btnCotizar.Name = "btnCotizar";
            this.btnCotizar.Size = new System.Drawing.Size(92, 67);
            this.btnCotizar.TabIndex = 14;
            this.btnCotizar.Text = "Cotizar";
            this.btnCotizar.UseVisualStyleBackColor = true;
            this.btnCotizar.Click += new System.EventHandler(this.btnCotizar_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(109, 68);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(121, 20);
            this.txtTotal.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cuota Mensual";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Meses";
            // 
            // npdMeses
            // 
            this.npdMeses.Location = new System.Drawing.Point(109, 30);
            this.npdMeses.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.npdMeses.Name = "npdMeses";
            this.npdMeses.Size = new System.Drawing.Size(120, 20);
            this.npdMeses.TabIndex = 5;
            this.npdMeses.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 733);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.wbbMostrar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npdPrecioBase)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npdMeses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnAutoStar;
        private System.Windows.Forms.RadioButton RbtnPurdyMotor;
        private System.Windows.Forms.RadioButton rbtnGrupoQ;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.RadioButton rbtnAutomanica;
        private System.Windows.Forms.RadioButton rbtnManual;
        private System.Windows.Forms.ComboBox cmbCombustible;
        private System.Windows.Forms.NumericUpDown npdPrecioBase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkAlarma;
        private System.Windows.Forms.CheckBox chkHalogeno;
        private System.Windows.Forms.CheckBox chkCamara;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.MaskedTextBox mskTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.WebBrowser wbbMostrar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnCotizar;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown npdMeses;
    }
}

