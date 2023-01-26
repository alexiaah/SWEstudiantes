//Alumnos.cs KAREN ALEXIA GONZALEZ FLORES 19480809
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PW20c
{
    public partial class Alumnos : Form
    {
        int pEstadocivil = 0;
        int pCveSexo = 0;
        private string _sCadenaConexion = string.Empty;

        public Alumnos()
        {
            InitializeComponent();
        }
        private void Alumnos_Load(object sender, EventArgs e)
        {
            CargaGrid();
            CargaComboCarreras();
            CargaComboMaterias();
        }

        private void CargaGrid()
        {
            _sCadenaConexion = "Data Source=DESKTOP-NIUC79P\\SQLEXPRESS;Initial Catalog=Alumnos_KGF;Integrated Security=True";
            SqlConnection conexionBD = new SqlConnection(_sCadenaConexion);
            SqlCommand comandoSQL = new SqlCommand();

            comandoSQL.Connection = conexionBD;
            comandoSQL.CommandText = "sp_Alumnos_KGF";
            comandoSQL.CommandType = CommandType.StoredProcedure;
            comandoSQL.Parameters.Add(new SqlParameter("@OPERACION", 'T'));

            SqlDataAdapter adaptador = new System.Data.SqlClient.SqlDataAdapter(comandoSQL);

            DataTable resultado = new DataTable();
            adaptador.Fill(resultado);

            dgvAlumnos.DataSource = resultado;

        }
        private void CargaComboCarreras()
        {
            _sCadenaConexion = "Data Source=DESKTOP-NIUC79P\\SQLEXPRESS;Initial Catalog=Alumnos_KGF;Integrated Security=True";
            SqlConnection conexionBD = new SqlConnection(_sCadenaConexion);
            SqlCommand comandoSQL = new SqlCommand();

            comandoSQL.Connection = conexionBD;
            comandoSQL.CommandText = "sp_Carreras_KGF";
            comandoSQL.CommandType = CommandType.StoredProcedure;

            comandoSQL.Parameters.Add(new SqlParameter("@OPERACION", 'T'));

            SqlDataAdapter adaptador = new System.Data.SqlClient.SqlDataAdapter(comandoSQL);
            DataTable resultado = new DataTable();
            adaptador.Fill(resultado);
            cboCarreras.DisplayMember = "Nom_Carrera";
            cboCarreras.ValueMember = "Id_Carrera";
            cboCarreras.DataSource = resultado;


        }
        private void CargaComboMaterias()
        {
            _sCadenaConexion = "Data Source=DESKTOP-NIUC79P\\SQLEXPRESS;Initial Catalog=Alumnos_KGF;Integrated Security=True";
            SqlConnection conexionBD = new SqlConnection(_sCadenaConexion);
            SqlCommand comandoSQL = new SqlCommand();

            comandoSQL.Connection = conexionBD;
            comandoSQL.CommandText = "sp_Materias_KGF";
            comandoSQL.CommandType = CommandType.StoredProcedure;

            comandoSQL.Parameters.Add(new SqlParameter("@OPERACION", 'T'));

            SqlDataAdapter adaptador = new System.Data.SqlClient.SqlDataAdapter(comandoSQL);

            DataTable resultado = new DataTable();
            adaptador.Fill(resultado);
            cboMaterias.DisplayMember = "Nom_Materia";
            cboMaterias.ValueMember = "Id_Materia";
            cboMaterias.DataSource = resultado;
        }

        private void TxtNoControl_Leave(object sender, EventArgs e)
        {
            if (this.TxtNoControl.Text == "")
            {

            }
            else
            {
                _sCadenaConexion = "Data Source=DESKTOP-NIUC79P\\SQLEXPRESS;Initial Catalog=Alumnos_KGF;Integrated Security=True";
                SqlConnection conexionBD = new
                SqlConnection(_sCadenaConexion);
                SqlCommand comandoSQL = new SqlCommand();

                comandoSQL.Connection = conexionBD;
                comandoSQL.CommandText = "sp_Alumnos_KGF";
                comandoSQL.CommandType = CommandType.StoredProcedure;

                comandoSQL.Parameters.Add(new SqlParameter("@OPERACION", 'L'));
                comandoSQL.Parameters.Add(new SqlParameter("@Id_Control", Convert.ToInt32(this.TxtNoControl.Text)));

                SqlDataAdapter adaptador = new System.Data.SqlClient.SqlDataAdapter(comandoSQL);
                DataTable resultado = new DataTable();
                adaptador.Fill(resultado);
                if (resultado.Rows.Count == 0)
                {

                }
                else
                {
                    this.txtNombre.Text = resultado.Rows[0]["Nombre"].ToString();
                    this.txtappaterno.Text = resultado.Rows[0]["Ape_Paterno"].ToString();
                    this.txtapmaterno.Text = resultado.Rows[0]["Ape_Materno"].ToString();
                    this.dtpfecha.Value = Convert.ToDateTime(resultado.Rows[0]["Fecha_ing"].ToString());
                    pEstadocivil = 0;
                    pEstadocivil = Convert.ToInt32(resultado.Rows[0]["Estado_Civil"].ToString());
                    if (pEstadocivil == 1)
                    {
                        this.optSoltero.Checked = true;
                    }
                    if (pEstadocivil == 2)
                    {
                        this.optCasado.Checked = true;
                    }
                    if (pEstadocivil == 3)
                    {
                        this.optDivorciado.Checked = true;
                    }
                    if (pEstadocivil == 4)
                    {
                        this.optUnionLibre.Checked = true;
                    }
                    pCveSexo = 0;
                    pCveSexo = Convert.ToInt32(dgvAlumnos.CurrentRow.Cells["Cve_Sexo_Alu"].Value.ToString());
                    if (pCveSexo == 1)
                    {
                        this.OptMasculino.Checked = true;
                    }
                    if (pCveSexo == 2)
                    {
                        this.Optfemenino.Checked = true;
                    }
                    cboCarreras.SelectedValue = Convert.ToInt32(dgvAlumnos.CurrentRow.Cells["Id_Carrera"].Value.ToString());
                    cboMaterias.SelectedValue = Convert.ToInt32(dgvAlumnos.CurrentRow.Cells["Id_Materia"].Value.ToString());
                }

            }
        }

        private void Limpiatextos()
        {
            TxtNoControl.Text = "";
            txtNombre.Text = "";
            txtappaterno.Text = "";
            txtapmaterno.Text = "";
            dtpfecha.Value = DateTime.Today;
            this.optSoltero.Checked = false;
            this.optCasado.Checked = false;
            this.optDivorciado.Checked = false;
            this.optUnionLibre.Checked = false;
            this.OptMasculino.Checked = false;
            this.Optfemenino.Checked = false;

            CargaComboCarreras();
            CargaComboMaterias();
        }
        private void BtnAltas_Click(object sender, EventArgs e)
        {
            try
            {
                _sCadenaConexion = "Data Source=DESKTOP-NIUC79P\\SQLEXPRESS;Initial Catalog=Alumnos_KGF;Integrated Security=True";
                SqlConnection conexionBD = new SqlConnection(_sCadenaConexion);
                SqlCommand comandoSQL = new SqlCommand();
                comandoSQL.Connection = conexionBD;
                comandoSQL.CommandText = "Sp_Alumnos_KGF";
                comandoSQL.CommandType = CommandType.StoredProcedure;
                pEstadocivil = 0;
                if (this.optSoltero.Checked == true)
                {
                    pEstadocivil = 1;
                }
                if (this.optCasado.Checked == true)
                {
                    pEstadocivil = 2;
                }
                if (this.optDivorciado.Checked == true)
                {
                    pEstadocivil = 3;
                }
                if (this.optUnionLibre.Checked == true)
                {
                    pEstadocivil = 4;
                }
                pCveSexo = 0;
                if (this.OptMasculino.Checked == true)
                {
                    pCveSexo = 1;
                }
                if (this.Optfemenino.Checked == true)
                {
                    pCveSexo = 2;
                }
                comandoSQL.Parameters.Add(new SqlParameter("@OPERACION", 'I'));
                comandoSQL.Parameters.Add(new SqlParameter("@Id_Control", Convert.ToInt64(this.TxtNoControl.Text)));
                comandoSQL.Parameters.Add(new SqlParameter("@Nombre", (this.txtNombre.Text)));
                comandoSQL.Parameters.Add(new SqlParameter("@Ape_Paterno", (this.txtappaterno.Text)));
                comandoSQL.Parameters.Add(new SqlParameter("@Ape_Materno", (this.txtapmaterno.Text)));
                comandoSQL.Parameters.Add(new SqlParameter("@Fecha_Ing", (this.dtpfecha.Value)));
                comandoSQL.Parameters.Add(new SqlParameter("@Estado_Civil", pEstadocivil));
                comandoSQL.Parameters.Add(new SqlParameter("@Cve_Sexo_Alu", pCveSexo));
                comandoSQL.Parameters.Add(new SqlParameter("@Id_Carrera", Convert.ToInt64(cboCarreras.SelectedValue)));
                comandoSQL.Parameters.Add(new SqlParameter("@Id_Materia", Convert.ToInt64(cboMaterias.SelectedValue)));

                conexionBD.Open();
                comandoSQL.ExecuteNonQuery();
                conexionBD.Close();
                CargaGrid();
                MessageBox.Show("Alta Efectuada");
                Limpiatextos();
            }
            catch (Exception)
            {
                MessageBox.Show("Alta ya existe");
            }
        }       
        private void BtnBajas_Click(object sender, EventArgs e)
        {
            try
            {
                _sCadenaConexion = "Data Source=DESKTOP-NIUC79P\\SQLEXPRESS;Initial Catalog=Alumnos_KGF;Integrated Security=True";
                SqlConnection conexionBD = new SqlConnection(_sCadenaConexion);
                SqlCommand comandoSQL = new SqlCommand();
                comandoSQL.Connection = conexionBD;
                comandoSQL.CommandText = "sp_Alumnos_KGF";
                comandoSQL.CommandType = CommandType.StoredProcedure;

                comandoSQL.Parameters.Add(new SqlParameter("@OPERACION", 'D'));
                comandoSQL.Parameters.Add(new SqlParameter("@Id_Control", Convert.ToInt64(this.TxtNoControl.Text)));
                conexionBD.Open();
                comandoSQL.ExecuteNonQuery();
                conexionBD.Close();
                CargaGrid();
                MessageBox.Show("Baja Efectuada");
                //this.close();
                Limpiatextos();
            }
            catch (Exception)
            {
                MessageBox.Show("Baja ya existe");
            }
        }
        private void BtnCambios_Click(object sender, EventArgs e)
        {
            try
            {
                _sCadenaConexion = "Data Source=DESKTOP-NIUC79P\\SQLEXPRESS;Initial Catalog=Alumnos_KGF;Integrated Security=True";
                SqlConnection conexionBD = new SqlConnection(_sCadenaConexion);
                SqlCommand comandoSQL = new SqlCommand();
                comandoSQL.Connection = conexionBD;
                comandoSQL.CommandText = "sp_Alumnos_KGF";
                comandoSQL.CommandType = CommandType.StoredProcedure;
                pEstadocivil = 0;
                if (this.optSoltero.Checked == true)
                {
                    pEstadocivil = 1;
                }
                if (this.optCasado.Checked == true)
                {
                    pEstadocivil = 2;
                }
                if (this.optDivorciado.Checked == true)
                {
                    pEstadocivil = 3;
                }
                if (this.optUnionLibre.Checked == true)
                {
                    pEstadocivil = 4;
                }
                pCveSexo = 0;
                if (this.OptMasculino.Checked == true)
                {
                    pCveSexo = 1;
                }
                if (this.Optfemenino.Checked == true)
                {
                    pCveSexo = 2;
                }

                comandoSQL.Parameters.Add(new SqlParameter("@OPERACION", 'C'));
                comandoSQL.Parameters.Add(new SqlParameter("@Id_Control", Convert.ToInt64(this.TxtNoControl.Text)));
                comandoSQL.Parameters.Add(new SqlParameter("@Nombre", this.txtNombre.Text));
                comandoSQL.Parameters.Add(new SqlParameter("@Ape_Paterno", this.txtappaterno.Text));
                comandoSQL.Parameters.Add(new SqlParameter("@Ape_Materno", this.txtapmaterno.Text));
                comandoSQL.Parameters.Add(new SqlParameter("@Fecha_Ing", Convert.ToDateTime(dtpfecha.Value)));
                comandoSQL.Parameters.Add(new SqlParameter("@Estado_Civil", pEstadocivil));
                comandoSQL.Parameters.Add(new SqlParameter("@Cve_Sexo_Alu", pCveSexo));
                comandoSQL.Parameters.Add(new SqlParameter("@Id_Carrera", Convert.ToInt64(cboCarreras.SelectedValue)));
                comandoSQL.Parameters.Add(new SqlParameter("@Id_Materia", Convert.ToInt64(cboMaterias.SelectedValue)));

                conexionBD.Open();
                comandoSQL.ExecuteNonQuery();
                conexionBD.Close();
                CargaGrid();
                MessageBox.Show("Cambio Efectuado");
                Limpiatextos();
            }
            catch (Exception)
            {
                MessageBox.Show("Cambio ya existe");
            }
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtNoControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
        private void TxtApePaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
        private void TxtApeMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
        private void DtpFechaIngreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
        private void Soltero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
        private void Casado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
        private void Divorciado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
        private void UnionLibre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
        private void OptMasculino_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
        private void OptFemenino_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void DgvAlumnos_DoubleClick(object sender, EventArgs e)
        {
            this.TxtNoControl.Text = dgvAlumnos.CurrentRow.Cells["Id_Control"].Value.ToString();
            this.txtNombre.Text = dgvAlumnos.CurrentRow.Cells["Nombre"].Value.ToString();
            this.txtappaterno.Text = dgvAlumnos.CurrentRow.Cells["Ape_Paterno"].Value.ToString();
            this.txtapmaterno.Text = dgvAlumnos.CurrentRow.Cells["Ape_Materno"].Value.ToString();
            this.dtpfecha.Value = Convert.ToDateTime(dgvAlumnos.CurrentRow.Cells["Fecha_ing"].Value.ToString());
            pEstadocivil = 0;
            pEstadocivil = Convert.ToInt32(dgvAlumnos.CurrentRow.Cells["Estado_Civil"].Value.ToString());

            if (pEstadocivil == 1)
            {
                this.optSoltero.Checked = true;
            }
            if (pEstadocivil == 2)
            {
                this.optCasado.Checked = true;
            }
            if (pEstadocivil == 3)
            {
                this.optDivorciado.Checked = true;
            }
            if (pEstadocivil == 4)
            {
                this.optUnionLibre.Checked = true;
            }
            pCveSexo = 0;
            pCveSexo = Convert.ToInt32(dgvAlumnos.CurrentRow.Cells["Cve_Sexo_Alu"].Value.ToString());
            if (pCveSexo == 1)
            {
                this.OptMasculino.Checked = true;
            }
            if (pCveSexo == 2)
            {
                this.Optfemenino.Checked = true;
            }
            cboCarreras.SelectedValue = Convert.ToInt32(dgvAlumnos.CurrentRow.Cells["Id_Carrera"].Value.ToString());
            cboMaterias.SelectedValue = Convert.ToInt32(dgvAlumnos.CurrentRow.Cells["Id_Materia"].Value.ToString());
        }       
    }
}
