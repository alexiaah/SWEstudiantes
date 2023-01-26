namespace PW20c
{
    partial class Carreras
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCambios = new System.Windows.Forms.Button();
            this.btnBajas = new System.Windows.Forms.Button();
            this.btnAltas = new System.Windows.Forms.Button();
            this.dgVDatosCa = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNoCarrera = new System.Windows.Forms.TextBox();
            this.txtNombreC = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgVDatosCa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Red;
            this.btnSalir.Location = new System.Drawing.Point(823, 433);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(112, 35);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // btnCambios
            // 
            this.btnCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambios.ForeColor = System.Drawing.Color.Red;
            this.btnCambios.Location = new System.Drawing.Point(667, 433);
            this.btnCambios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCambios.Name = "btnCambios";
            this.btnCambios.Size = new System.Drawing.Size(112, 35);
            this.btnCambios.TabIndex = 18;
            this.btnCambios.Text = "Cambio";
            this.btnCambios.UseVisualStyleBackColor = true;
            this.btnCambios.Click += new System.EventHandler(this.BtnCambios_Click);
            // 
            // btnBajas
            // 
            this.btnBajas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajas.ForeColor = System.Drawing.Color.Red;
            this.btnBajas.Location = new System.Drawing.Point(510, 433);
            this.btnBajas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBajas.Name = "btnBajas";
            this.btnBajas.Size = new System.Drawing.Size(112, 35);
            this.btnBajas.TabIndex = 17;
            this.btnBajas.Text = "Bajas";
            this.btnBajas.UseVisualStyleBackColor = true;
            this.btnBajas.Click += new System.EventHandler(this.BtnBajas_Click);
            // 
            // btnAltas
            // 
            this.btnAltas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltas.ForeColor = System.Drawing.Color.Red;
            this.btnAltas.Location = new System.Drawing.Point(345, 433);
            this.btnAltas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAltas.Name = "btnAltas";
            this.btnAltas.Size = new System.Drawing.Size(112, 35);
            this.btnAltas.TabIndex = 16;
            this.btnAltas.Text = "Altas";
            this.btnAltas.UseVisualStyleBackColor = true;
            this.btnAltas.Click += new System.EventHandler(this.BtnAltas_Click);
            // 
            // dgVDatosCa
            // 
            this.dgVDatosCa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVDatosCa.Location = new System.Drawing.Point(28, 224);
            this.dgVDatosCa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgVDatosCa.Name = "dgVDatosCa";
            this.dgVDatosCa.Size = new System.Drawing.Size(907, 182);
            this.dgVDatosCa.TabIndex = 15;
            this.dgVDatosCa.DoubleClick += new System.EventHandler(this.DgVDatosCa_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 33);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nombre Carrera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 33);
            this.label2.TabIndex = 11;
            this.label2.Text = "No. Carrera";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(287, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Catalogo de carreras";
            // 
            // txtNoCarrera
            // 
            this.txtNoCarrera.Location = new System.Drawing.Point(390, 84);
            this.txtNoCarrera.Name = "txtNoCarrera";
            this.txtNoCarrera.Size = new System.Drawing.Size(421, 26);
            this.txtNoCarrera.TabIndex = 20;
            this.txtNoCarrera.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNoCarrera_KeyPress);
            this.txtNoCarrera.Leave += new System.EventHandler(this.TxtNoCarrera_Leave);
            // 
            // txtNombreC
            // 
            this.txtNombreC.Location = new System.Drawing.Point(390, 182);
            this.txtNombreC.Name = "txtNombreC";
            this.txtNombreC.Size = new System.Drawing.Size(421, 26);
            this.txtNombreC.TabIndex = 21;
            // 
            // Carreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 501);
            this.Controls.Add(this.txtNombreC);
            this.Controls.Add(this.txtNoCarrera);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCambios);
            this.Controls.Add(this.btnBajas);
            this.Controls.Add(this.btnAltas);
            this.Controls.Add(this.dgVDatosCa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Carreras";
            this.Text = "Carreras";
            this.Load += new System.EventHandler(this.Carreras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVDatosCa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCambios;
        private System.Windows.Forms.Button btnBajas;
        private System.Windows.Forms.Button btnAltas;
        private System.Windows.Forms.DataGridView dgVDatosCa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNoCarrera;
        private System.Windows.Forms.TextBox txtNombreC;
    }
}