namespace PW20c
{
    partial class Alumnos
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
            this.BtnAltas = new System.Windows.Forms.Button();
            this.BtnBajas = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.OptMasculino = new System.Windows.Forms.RadioButton();
            this.Optfemenino = new System.Windows.Forms.RadioButton();
            this.BtnCambios = new System.Windows.Forms.Button();
            this.cboMaterias = new System.Windows.Forms.ComboBox();
            this.cboCarreras = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optSoltero = new System.Windows.Forms.RadioButton();
            this.optCasado = new System.Windows.Forms.RadioButton();
            this.optDivorciado = new System.Windows.Forms.RadioButton();
            this.optUnionLibre = new System.Windows.Forms.RadioButton();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.txtapmaterno = new System.Windows.Forms.TextBox();
            this.txtappaterno = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.TxtNoControl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAltas
            // 
            this.BtnAltas.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnAltas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAltas.Location = new System.Drawing.Point(355, 447);
            this.BtnAltas.Name = "BtnAltas";
            this.BtnAltas.Size = new System.Drawing.Size(106, 42);
            this.BtnAltas.TabIndex = 63;
            this.BtnAltas.Text = "Altas";
            this.BtnAltas.UseVisualStyleBackColor = false;
            this.BtnAltas.Click += new System.EventHandler(this.BtnAltas_Click);
            // 
            // BtnBajas
            // 
            this.BtnBajas.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnBajas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBajas.Location = new System.Drawing.Point(467, 447);
            this.BtnBajas.Name = "BtnBajas";
            this.BtnBajas.Size = new System.Drawing.Size(88, 42);
            this.BtnBajas.TabIndex = 62;
            this.BtnBajas.Text = "Bajas";
            this.BtnBajas.UseVisualStyleBackColor = false;
            this.BtnBajas.Click += new System.EventHandler(this.BtnBajas_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnSalir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(718, 447);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(95, 42);
            this.BtnSalir.TabIndex = 60;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Location = new System.Drawing.Point(13, 497);
            this.dgvAlumnos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.RowHeadersWidth = 62;
            this.dgvAlumnos.Size = new System.Drawing.Size(1080, 193);
            this.dgvAlumnos.TabIndex = 59;
            this.dgvAlumnos.DoubleClick += new System.EventHandler(this.DgvAlumnos_DoubleClick);
            // 
            // OptMasculino
            // 
            this.OptMasculino.AutoSize = true;
            this.OptMasculino.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.OptMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptMasculino.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OptMasculino.Location = new System.Drawing.Point(88, 20);
            this.OptMasculino.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OptMasculino.Name = "OptMasculino";
            this.OptMasculino.Size = new System.Drawing.Size(124, 26);
            this.OptMasculino.TabIndex = 17;
            this.OptMasculino.TabStop = true;
            this.OptMasculino.Text = "Masculino";
            this.OptMasculino.UseVisualStyleBackColor = false;
            this.OptMasculino.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OptMasculino_KeyPress);
            // 
            // Optfemenino
            // 
            this.Optfemenino.AutoSize = true;
            this.Optfemenino.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Optfemenino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Optfemenino.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Optfemenino.Location = new System.Drawing.Point(328, 20);
            this.Optfemenino.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Optfemenino.Name = "Optfemenino";
            this.Optfemenino.Size = new System.Drawing.Size(122, 26);
            this.Optfemenino.TabIndex = 18;
            this.Optfemenino.TabStop = true;
            this.Optfemenino.Text = "Femenino";
            this.Optfemenino.UseVisualStyleBackColor = false;
            this.Optfemenino.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OptFemenino_KeyPress);
            // 
            // BtnCambios
            // 
            this.BtnCambios.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnCambios.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCambios.Location = new System.Drawing.Point(567, 447);
            this.BtnCambios.Name = "BtnCambios";
            this.BtnCambios.Size = new System.Drawing.Size(136, 42);
            this.BtnCambios.TabIndex = 61;
            this.BtnCambios.Text = "Cambios";
            this.BtnCambios.UseVisualStyleBackColor = false;
            this.BtnCambios.Click += new System.EventHandler(this.BtnCambios_Click);
            // 
            // cboMaterias
            // 
            this.cboMaterias.FormattingEnabled = true;
            this.cboMaterias.Location = new System.Drawing.Point(369, 401);
            this.cboMaterias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboMaterias.Name = "cboMaterias";
            this.cboMaterias.Size = new System.Drawing.Size(494, 28);
            this.cboMaterias.TabIndex = 58;
            // 
            // cboCarreras
            // 
            this.cboCarreras.FormattingEnabled = true;
            this.cboCarreras.Location = new System.Drawing.Point(369, 338);
            this.cboCarreras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboCarreras.Name = "cboCarreras";
            this.cboCarreras.Size = new System.Drawing.Size(494, 28);
            this.cboCarreras.TabIndex = 57;
            //this.cboCarreras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboCarreras_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(231, 401);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 25);
            this.label8.TabIndex = 56;
            this.label8.Text = "Materias:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(231, 338);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 25);
            this.label7.TabIndex = 55;
            this.label7.Text = "Carreras:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.OptMasculino);
            this.groupBox3.Controls.Add(this.Optfemenino);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(193, 261);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(693, 58);
            this.groupBox3.TabIndex = 54;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sexo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(285, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 29);
            this.label1.TabIndex = 53;
            this.label1.Text = "INSTITUTO TECNOLOGICO DE NUEVO LEON";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.optSoltero);
            this.groupBox1.Controls.Add(this.optCasado);
            this.groupBox1.Controls.Add(this.optDivorciado);
            this.groupBox1.Controls.Add(this.optUnionLibre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(193, 177);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(693, 74);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado Civil";
            // 
            // optSoltero
            // 
            this.optSoltero.AutoSize = true;
            this.optSoltero.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.optSoltero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optSoltero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.optSoltero.Location = new System.Drawing.Point(28, 33);
            this.optSoltero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.optSoltero.Name = "optSoltero";
            this.optSoltero.Size = new System.Drawing.Size(99, 26);
            this.optSoltero.TabIndex = 12;
            this.optSoltero.TabStop = true;
            this.optSoltero.Text = "Soltero";
            this.optSoltero.UseVisualStyleBackColor = false;
            this.optSoltero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Soltero_KeyPress);
            // 
            // optCasado
            // 
            this.optCasado.AutoSize = true;
            this.optCasado.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.optCasado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optCasado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.optCasado.Location = new System.Drawing.Point(162, 33);
            this.optCasado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.optCasado.Name = "optCasado";
            this.optCasado.Size = new System.Drawing.Size(103, 26);
            this.optCasado.TabIndex = 13;
            this.optCasado.TabStop = true;
            this.optCasado.Text = "Casado";
            this.optCasado.UseVisualStyleBackColor = false;
            this.optCasado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Casado_KeyPress);
            // 
            // optDivorciado
            // 
            this.optDivorciado.AutoSize = true;
            this.optDivorciado.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.optDivorciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optDivorciado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.optDivorciado.Location = new System.Drawing.Point(292, 33);
            this.optDivorciado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.optDivorciado.Name = "optDivorciado";
            this.optDivorciado.Size = new System.Drawing.Size(130, 26);
            this.optDivorciado.TabIndex = 14;
            this.optDivorciado.TabStop = true;
            this.optDivorciado.Text = "Divorciado";
            this.optDivorciado.UseVisualStyleBackColor = false;
            this.optDivorciado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Divorciado_KeyPress);
            // 
            // optUnionLibre
            // 
            this.optUnionLibre.AutoSize = true;
            this.optUnionLibre.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.optUnionLibre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optUnionLibre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.optUnionLibre.Location = new System.Drawing.Point(463, 33);
            this.optUnionLibre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.optUnionLibre.Name = "optUnionLibre";
            this.optUnionLibre.Size = new System.Drawing.Size(138, 26);
            this.optUnionLibre.TabIndex = 15;
            this.optUnionLibre.TabStop = true;
            this.optUnionLibre.Text = "Union Libre";
            this.optUnionLibre.UseVisualStyleBackColor = false;
            this.optUnionLibre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UnionLibre_KeyPress);
            // 
            // dtpfecha
            // 
            this.dtpfecha.Location = new System.Drawing.Point(474, 141);
            this.dtpfecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(200, 26);
            this.dtpfecha.TabIndex = 51;
            this.dtpfecha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DtpFechaIngreso_KeyPress);
            // 
            // txtapmaterno
            // 
            this.txtapmaterno.Location = new System.Drawing.Point(718, 107);
            this.txtapmaterno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtapmaterno.Name = "txtapmaterno";
            this.txtapmaterno.Size = new System.Drawing.Size(200, 26);
            this.txtapmaterno.TabIndex = 50;
            this.txtapmaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApeMaterno_KeyPress);
            // 
            // txtappaterno
            // 
            this.txtappaterno.Location = new System.Drawing.Point(718, 65);
            this.txtappaterno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtappaterno.Name = "txtappaterno";
            this.txtappaterno.Size = new System.Drawing.Size(200, 26);
            this.txtappaterno.TabIndex = 49;
            this.txtappaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApePaterno_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(283, 105);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 26);
            this.txtNombre.TabIndex = 48;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // TxtNoControl
            // 
            this.TxtNoControl.Location = new System.Drawing.Point(283, 65);
            this.TxtNoControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNoControl.Name = "TxtNoControl";
            this.TxtNoControl.Size = new System.Drawing.Size(200, 26);
            this.TxtNoControl.TabIndex = 47;
            this.TxtNoControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNoControl_KeyPress);
            this.TxtNoControl.Leave += new System.EventHandler(this.TxtNoControl_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(364, 140);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 46;
            this.label6.Text = "Fecha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(508, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 25);
            this.label5.TabIndex = 45;
            this.label5.Text = "Apellido Materno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(127, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 42;
            this.label2.Text = "No. Control:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(512, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 25);
            this.label4.TabIndex = 44;
            this.label4.Text = "Apellido Paterno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(151, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 43;
            this.label3.Text = "Nombre:";
            // 
            // Alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 704);
            this.Controls.Add(this.BtnAltas);
            this.Controls.Add(this.BtnBajas);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.BtnCambios);
            this.Controls.Add(this.cboMaterias);
            this.Controls.Add(this.cboCarreras);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.txtapmaterno);
            this.Controls.Add(this.txtappaterno);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.TxtNoControl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Alumnos";
            this.Text = "Alumnos";
            this.Load += new System.EventHandler(this.Alumnos_Load);
            this.DoubleClick += new System.EventHandler(this.DgvAlumnos_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAltas;
        private System.Windows.Forms.Button BtnBajas;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.RadioButton OptMasculino;
        private System.Windows.Forms.RadioButton Optfemenino;
        private System.Windows.Forms.Button BtnCambios;
        private System.Windows.Forms.ComboBox cboMaterias;
        private System.Windows.Forms.ComboBox cboCarreras;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optSoltero;
        private System.Windows.Forms.RadioButton optCasado;
        private System.Windows.Forms.RadioButton optDivorciado;
        private System.Windows.Forms.RadioButton optUnionLibre;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.TextBox txtapmaterno;
        private System.Windows.Forms.TextBox txtappaterno;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox TxtNoControl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}