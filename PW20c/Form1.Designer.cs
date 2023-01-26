namespace PW20c
{
    partial class Form1
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
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.RbFebrero = new System.Windows.Forms.RadioButton();
            this.RbEnero = new System.Windows.Forms.RadioButton();
            this.ChkMayo = new System.Windows.Forms.CheckBox();
            this.ChkEnero = new System.Windows.Forms.CheckBox();
            this.MES_DEL_AÑO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_INGRESO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAgregar = new System.Windows.Forms.DataGridView();
            this.CON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No_Control = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDO_PATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDO_MATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ChkAbril = new System.Windows.Forms.CheckBox();
            this.ChkMarzo = new System.Windows.Forms.CheckBox();
            this.ChkFebrero = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RbMayo = new System.Windows.Forms.RadioButton();
            this.RbAbril = new System.Windows.Forms.RadioButton();
            this.RbMarzo = new System.Windows.Forms.RadioButton();
            this.cobMesAño = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtApeMaterno = new System.Windows.Forms.TextBox();
            this.txtApePaterno = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNoControl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(415, 466);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(112, 35);
            this.BtnGuardar.TabIndex = 60;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click_1);
            // 
            // RbFebrero
            // 
            this.RbFebrero.AutoSize = true;
            this.RbFebrero.BackColor = System.Drawing.Color.Yellow;
            this.RbFebrero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbFebrero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RbFebrero.Location = new System.Drawing.Point(169, 33);
            this.RbFebrero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RbFebrero.Name = "RbFebrero";
            this.RbFebrero.Size = new System.Drawing.Size(112, 29);
            this.RbFebrero.TabIndex = 1;
            this.RbFebrero.TabStop = true;
            this.RbFebrero.Text = "Febrero";
            this.RbFebrero.UseVisualStyleBackColor = false;
            this.RbFebrero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RbFebrero_KeyPress);
            // 
            // RbEnero
            // 
            this.RbEnero.AutoSize = true;
            this.RbEnero.BackColor = System.Drawing.Color.Yellow;
            this.RbEnero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbEnero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RbEnero.Location = new System.Drawing.Point(9, 33);
            this.RbEnero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RbEnero.Name = "RbEnero";
            this.RbEnero.Size = new System.Drawing.Size(94, 29);
            this.RbEnero.TabIndex = 0;
            this.RbEnero.TabStop = true;
            this.RbEnero.Text = "Enero";
            this.RbEnero.UseVisualStyleBackColor = false;
            this.RbEnero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RbEnero_KeyPress);
            // 
            // ChkMayo
            // 
            this.ChkMayo.AutoSize = true;
            this.ChkMayo.BackColor = System.Drawing.Color.Yellow;
            this.ChkMayo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkMayo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ChkMayo.Location = new System.Drawing.Point(602, 29);
            this.ChkMayo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChkMayo.Name = "ChkMayo";
            this.ChkMayo.Size = new System.Drawing.Size(91, 29);
            this.ChkMayo.TabIndex = 4;
            this.ChkMayo.Text = "Mayo";
            this.ChkMayo.UseVisualStyleBackColor = false;
            this.ChkMayo.CheckedChanged += new System.EventHandler(this.ChkMayo_CheckedChanged);
            this.ChkMayo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ChkMayo_KeyPress);
            // 
            // ChkEnero
            // 
            this.ChkEnero.AutoSize = true;
            this.ChkEnero.BackColor = System.Drawing.Color.Yellow;
            this.ChkEnero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkEnero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ChkEnero.Location = new System.Drawing.Point(8, 29);
            this.ChkEnero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChkEnero.Name = "ChkEnero";
            this.ChkEnero.Size = new System.Drawing.Size(95, 29);
            this.ChkEnero.TabIndex = 0;
            this.ChkEnero.Text = "Enero";
            this.ChkEnero.UseVisualStyleBackColor = false;
            this.ChkEnero.CheckedChanged += new System.EventHandler(this.ChkEnero_CheckedChanged);
            this.ChkEnero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ChkEnero_KeyPress);
            // 
            // MES_DEL_AÑO
            // 
            this.MES_DEL_AÑO.HeaderText = "MES_DEL_AÑO";
            this.MES_DEL_AÑO.MinimumWidth = 8;
            this.MES_DEL_AÑO.Name = "MES_DEL_AÑO";
            this.MES_DEL_AÑO.Width = 150;
            // 
            // FECHA_INGRESO
            // 
            this.FECHA_INGRESO.HeaderText = "FECHA_INGRESO";
            this.FECHA_INGRESO.MinimumWidth = 8;
            this.FECHA_INGRESO.Name = "FECHA_INGRESO";
            this.FECHA_INGRESO.Width = 150;
            // 
            // dgvAgregar
            // 
            this.dgvAgregar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgregar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CON,
            this.No_Control,
            this.NOMBRE,
            this.APELLIDO_PATERNO,
            this.APELLIDO_MATERNO,
            this.FECHA_INGRESO,
            this.MES_DEL_AÑO});
            this.dgvAgregar.Location = new System.Drawing.Point(10, 529);
            this.dgvAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAgregar.Name = "dgvAgregar";
            this.dgvAgregar.RowHeadersWidth = 62;
            this.dgvAgregar.Size = new System.Drawing.Size(931, 138);
            this.dgvAgregar.TabIndex = 59;
            this.dgvAgregar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgregar_CellContentClick);
            this.dgvAgregar.DoubleClick += new System.EventHandler(this.dgvAgregar_DoubleClick);
            // 
            // CON
            // 
            this.CON.HeaderText = "CON";
            this.CON.MinimumWidth = 8;
            this.CON.Name = "CON";
            this.CON.Width = 150;
            // 
            // No_Control
            // 
            this.No_Control.HeaderText = "No_Control";
            this.No_Control.MinimumWidth = 8;
            this.No_Control.Name = "No_Control";
            this.No_Control.Width = 150;
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.MinimumWidth = 8;
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.Width = 150;
            // 
            // APELLIDO_PATERNO
            // 
            this.APELLIDO_PATERNO.HeaderText = "APELLIDO_PATERNO";
            this.APELLIDO_PATERNO.MinimumWidth = 8;
            this.APELLIDO_PATERNO.Name = "APELLIDO_PATERNO";
            this.APELLIDO_PATERNO.Width = 150;
            // 
            // APELLIDO_MATERNO
            // 
            this.APELLIDO_MATERNO.HeaderText = "APELLIDO_MATERNO";
            this.APELLIDO_MATERNO.MinimumWidth = 8;
            this.APELLIDO_MATERNO.Name = "APELLIDO_MATERNO";
            this.APELLIDO_MATERNO.Width = 150;
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(235, 466);
            this.BtnConsultar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(112, 35);
            this.BtnConsultar.TabIndex = 58;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.groupBox2.Controls.Add(this.ChkMayo);
            this.groupBox2.Controls.Add(this.ChkAbril);
            this.groupBox2.Controls.Add(this.ChkMarzo);
            this.groupBox2.Controls.Add(this.ChkFebrero);
            this.groupBox2.Controls.Add(this.ChkEnero);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(10, 383);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(720, 73);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Meses del Año";
            // 
            // ChkAbril
            // 
            this.ChkAbril.AutoSize = true;
            this.ChkAbril.BackColor = System.Drawing.Color.Yellow;
            this.ChkAbril.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkAbril.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ChkAbril.Location = new System.Drawing.Point(472, 29);
            this.ChkAbril.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChkAbril.Name = "ChkAbril";
            this.ChkAbril.Size = new System.Drawing.Size(82, 29);
            this.ChkAbril.TabIndex = 3;
            this.ChkAbril.Text = "Abril";
            this.ChkAbril.UseVisualStyleBackColor = false;
            this.ChkAbril.CheckedChanged += new System.EventHandler(this.ChkAbril_CheckedChanged);
            this.ChkAbril.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ChkAbril_KeyPress);
            // 
            // ChkMarzo
            // 
            this.ChkMarzo.AutoSize = true;
            this.ChkMarzo.BackColor = System.Drawing.Color.Yellow;
            this.ChkMarzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkMarzo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ChkMarzo.Location = new System.Drawing.Point(324, 29);
            this.ChkMarzo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChkMarzo.Name = "ChkMarzo";
            this.ChkMarzo.Size = new System.Drawing.Size(98, 29);
            this.ChkMarzo.TabIndex = 2;
            this.ChkMarzo.Text = "Marzo";
            this.ChkMarzo.UseVisualStyleBackColor = false;
            this.ChkMarzo.CheckedChanged += new System.EventHandler(this.ChkMarzo_CheckedChanged);
            this.ChkMarzo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ChkMarzo_KeyPress);
            // 
            // ChkFebrero
            // 
            this.ChkFebrero.AutoSize = true;
            this.ChkFebrero.BackColor = System.Drawing.Color.Yellow;
            this.ChkFebrero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkFebrero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ChkFebrero.Location = new System.Drawing.Point(158, 29);
            this.ChkFebrero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChkFebrero.Name = "ChkFebrero";
            this.ChkFebrero.Size = new System.Drawing.Size(113, 29);
            this.ChkFebrero.TabIndex = 1;
            this.ChkFebrero.Text = "Febrero";
            this.ChkFebrero.UseVisualStyleBackColor = false;
            this.ChkFebrero.CheckedChanged += new System.EventHandler(this.ChkFebrero_CheckedChanged);
            this.ChkFebrero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ChkFebrero_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.groupBox1.Controls.Add(this.RbMayo);
            this.groupBox1.Controls.Add(this.RbAbril);
            this.groupBox1.Controls.Add(this.RbMarzo);
            this.groupBox1.Controls.Add(this.RbFebrero);
            this.groupBox1.Controls.Add(this.RbEnero);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(10, 290);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(720, 83);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mes del Año";
            // 
            // RbMayo
            // 
            this.RbMayo.AutoSize = true;
            this.RbMayo.BackColor = System.Drawing.Color.Yellow;
            this.RbMayo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbMayo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RbMayo.Location = new System.Drawing.Point(609, 33);
            this.RbMayo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RbMayo.Name = "RbMayo";
            this.RbMayo.Size = new System.Drawing.Size(90, 29);
            this.RbMayo.TabIndex = 4;
            this.RbMayo.TabStop = true;
            this.RbMayo.Text = "Mayo";
            this.RbMayo.UseVisualStyleBackColor = false;
            this.RbMayo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RbMayo_KeyPress);
            // 
            // RbAbril
            // 
            this.RbAbril.AutoSize = true;
            this.RbAbril.BackColor = System.Drawing.Color.Yellow;
            this.RbAbril.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbAbril.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RbAbril.Location = new System.Drawing.Point(479, 33);
            this.RbAbril.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RbAbril.Name = "RbAbril";
            this.RbAbril.Size = new System.Drawing.Size(81, 29);
            this.RbAbril.TabIndex = 3;
            this.RbAbril.TabStop = true;
            this.RbAbril.Text = "Abril";
            this.RbAbril.UseVisualStyleBackColor = false;
            this.RbAbril.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RbAbril_KeyPress);
            // 
            // RbMarzo
            // 
            this.RbMarzo.AutoSize = true;
            this.RbMarzo.BackColor = System.Drawing.Color.Yellow;
            this.RbMarzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbMarzo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RbMarzo.Location = new System.Drawing.Point(335, 33);
            this.RbMarzo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RbMarzo.Name = "RbMarzo";
            this.RbMarzo.Size = new System.Drawing.Size(97, 29);
            this.RbMarzo.TabIndex = 2;
            this.RbMarzo.TabStop = true;
            this.RbMarzo.Text = "Marzo";
            this.RbMarzo.UseVisualStyleBackColor = false;
            this.RbMarzo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RbMarzo_KeyPress);
            // 
            // cobMesAño
            // 
            this.cobMesAño.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cobMesAño.FormattingEnabled = true;
            this.cobMesAño.Items.AddRange(new object[] {
            "ENERO",
            "FEBRERO",
            "MARZO",
            "ABRIL",
            "MAYO",
            "JUNIO",
            "JULIO",
            "AGOSTO",
            "SEPTIEMBRE",
            "OCTUBRE",
            "NOVIEMBRE",
            "DICIEMBRE"});
            this.cobMesAño.Location = new System.Drawing.Point(306, 252);
            this.cobMesAño.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cobMesAño.Name = "cobMesAño";
            this.cobMesAño.Size = new System.Drawing.Size(267, 28);
            this.cobMesAño.TabIndex = 55;
            this.cobMesAño.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cobMesAño_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(165, 255);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 20);
            this.label8.TabIndex = 54;
            this.label8.Text = "Mes del Año:";
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(306, 219);
            this.dtpFechaIngreso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(267, 26);
            this.dtpFechaIngreso.TabIndex = 53;
            this.dtpFechaIngreso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFechaIngreso_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(128, 219);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 20);
            this.label7.TabIndex = 52;
            this.label7.Text = "Fecha de Ingreso:";
            // 
            // txtApeMaterno
            // 
            this.txtApeMaterno.Location = new System.Drawing.Point(307, 187);
            this.txtApeMaterno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtApeMaterno.Name = "txtApeMaterno";
            this.txtApeMaterno.Size = new System.Drawing.Size(267, 26);
            this.txtApeMaterno.TabIndex = 51;
            this.txtApeMaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApeMaterno_KeyPress);
            // 
            // txtApePaterno
            // 
            this.txtApePaterno.Location = new System.Drawing.Point(306, 153);
            this.txtApePaterno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtApePaterno.Name = "txtApePaterno";
            this.txtApePaterno.Size = new System.Drawing.Size(267, 26);
            this.txtApePaterno.TabIndex = 50;
            this.txtApePaterno.TextChanged += new System.EventHandler(this.txtApePaterno_TextChanged_1);
            this.txtApePaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApePaterno_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(307, 123);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(266, 26);
            this.txtNombre.TabIndex = 49;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtNoControl
            // 
            this.txtNoControl.Location = new System.Drawing.Point(307, 94);
            this.txtNoControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNoControl.Name = "txtNoControl";
            this.txtNoControl.Size = new System.Drawing.Size(266, 26);
            this.txtNoControl.TabIndex = 48;
            this.txtNoControl.TextChanged += new System.EventHandler(this.txtNoControl_TextChanged_1);
            this.txtNoControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoControl_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(134, 190);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 20);
            this.label6.TabIndex = 47;
            this.label6.Text = "Apellido Materno:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 46;
            this.label5.Text = "Apellido Paterno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "No. Control:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(272, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 29);
            this.label2.TabIndex = 43;
            this.label2.Text = "Programacion Web";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(99, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(571, 37);
            this.label1.TabIndex = 42;
            this.label1.Text = "Instituto Tecnologico de Nuevo Leon";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 644);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.dgvAgregar);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cobMesAño);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtApeMaterno);
            this.Controls.Add(this.txtApePaterno);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtNoControl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.RadioButton RbFebrero;
        private System.Windows.Forms.RadioButton RbEnero;
        private System.Windows.Forms.CheckBox ChkMayo;
        private System.Windows.Forms.CheckBox ChkEnero;
        private System.Windows.Forms.DataGridViewTextBoxColumn MES_DEL_AÑO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_INGRESO;
        private System.Windows.Forms.DataGridView dgvAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CON;
        private System.Windows.Forms.DataGridViewTextBoxColumn No_Control;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDO_PATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDO_MATERNO;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ChkAbril;
        private System.Windows.Forms.CheckBox ChkMarzo;
        private System.Windows.Forms.CheckBox ChkFebrero;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RbMayo;
        private System.Windows.Forms.RadioButton RbAbril;
        private System.Windows.Forms.RadioButton RbMarzo;
        private System.Windows.Forms.ComboBox cobMesAño;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtApeMaterno;
        private System.Windows.Forms.TextBox txtApePaterno;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNoControl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

