namespace PW20c
{
    partial class Materias
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
            this.txtNombreM = new System.Windows.Forms.TextBox();
            this.txtNoMateria = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCambios = new System.Windows.Forms.Button();
            this.btnBajas = new System.Windows.Forms.Button();
            this.btnAltas = new System.Windows.Forms.Button();
            this.dgVDatosMa = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgVDatosMa)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreM
            // 
            this.txtNombreM.Location = new System.Drawing.Point(379, 142);
            this.txtNombreM.Name = "txtNombreM";
            this.txtNombreM.Size = new System.Drawing.Size(421, 26);
            this.txtNombreM.TabIndex = 31;
            // 
            // txtNoMateria
            // 
            this.txtNoMateria.Location = new System.Drawing.Point(379, 88);
            this.txtNoMateria.Name = "txtNoMateria";
            this.txtNoMateria.Size = new System.Drawing.Size(421, 26);
            this.txtNoMateria.TabIndex = 30;
            this.txtNoMateria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoMateria_KeyPress);
            this.txtNoMateria.Leave += new System.EventHandler(this.txtNoMateria_Leave);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Red;
            this.btnSalir.Location = new System.Drawing.Point(742, 412);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(112, 35);
            this.btnSalir.TabIndex = 29;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCambios
            // 
            this.btnCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambios.ForeColor = System.Drawing.Color.Red;
            this.btnCambios.Location = new System.Drawing.Point(586, 412);
            this.btnCambios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCambios.Name = "btnCambios";
            this.btnCambios.Size = new System.Drawing.Size(112, 35);
            this.btnCambios.TabIndex = 28;
            this.btnCambios.Text = "Cambio";
            this.btnCambios.UseVisualStyleBackColor = true;
            this.btnCambios.Click += new System.EventHandler(this.btnCambios_Click);
            // 
            // btnBajas
            // 
            this.btnBajas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajas.ForeColor = System.Drawing.Color.Red;
            this.btnBajas.Location = new System.Drawing.Point(429, 412);
            this.btnBajas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBajas.Name = "btnBajas";
            this.btnBajas.Size = new System.Drawing.Size(112, 35);
            this.btnBajas.TabIndex = 27;
            this.btnBajas.Text = "Bajas";
            this.btnBajas.UseVisualStyleBackColor = true;
            this.btnBajas.Click += new System.EventHandler(this.btnBajas_Click);
            // 
            // btnAltas
            // 
            this.btnAltas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltas.ForeColor = System.Drawing.Color.Red;
            this.btnAltas.Location = new System.Drawing.Point(264, 412);
            this.btnAltas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAltas.Name = "btnAltas";
            this.btnAltas.Size = new System.Drawing.Size(112, 35);
            this.btnAltas.TabIndex = 26;
            this.btnAltas.Text = "Altas";
            this.btnAltas.UseVisualStyleBackColor = true;
            this.btnAltas.Click += new System.EventHandler(this.btnAltas_Click);
            // 
            // dgVDatosMa
            // 
            this.dgVDatosMa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVDatosMa.Location = new System.Drawing.Point(13, 216);
            this.dgVDatosMa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgVDatosMa.Name = "dgVDatosMa";
            this.dgVDatosMa.Size = new System.Drawing.Size(894, 177);
            this.dgVDatosMa.TabIndex = 25;
            this.dgVDatosMa.DoubleClick += new System.EventHandler(this.dgVDatosMa_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 33);
            this.label3.TabIndex = 24;
            this.label3.Text = "Nombre Materia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 33);
            this.label2.TabIndex = 23;
            this.label2.Text = "No. Materias";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(302, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 37);
            this.label1.TabIndex = 22;
            this.label1.Text = "Catalogo de Materias";
            // 
            // Materias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 456);
            this.Controls.Add(this.txtNombreM);
            this.Controls.Add(this.txtNoMateria);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCambios);
            this.Controls.Add(this.btnBajas);
            this.Controls.Add(this.btnAltas);
            this.Controls.Add(this.dgVDatosMa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Materias";
            this.Text = "Materias";
            this.Load += new System.EventHandler(this.Materias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVDatosMa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreM;
        private System.Windows.Forms.TextBox txtNoMateria;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCambios;
        private System.Windows.Forms.Button btnBajas;
        private System.Windows.Forms.Button btnAltas;
        private System.Windows.Forms.DataGridView dgVDatosMa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}