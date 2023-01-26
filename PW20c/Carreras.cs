//Carreras.cs KAREN ALEXIA GONZALEZ FLORES 19480809
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
    public partial class Carreras : Form
    {
        private string _sCadenaConexion = string.Empty;
        public Carreras()
        {
            InitializeComponent();
        }
        private void Carreras_Load(object sender, EventArgs e)
        {
            CargaGrid();
        }
        public void CargaGrid()
        {
            _sCadenaConexion = "Data Source=DESKTOP-NIUC79P\\SQLEXPRESS;Initial Catalog=Alumnos_KGF;Integrated Security=True";

            System.Data.SqlClient.SqlConnection conexionDB = new System.Data.SqlClient.SqlConnection(_sCadenaConexion);
            System.Data.SqlClient.SqlCommand comandoSQL = new SqlCommand();

            comandoSQL.Connection = conexionDB;
            comandoSQL.CommandText = "Sp_Carreras_KGF";
            comandoSQL.CommandType = CommandType.StoredProcedure;
            comandoSQL.Parameters.Add(new System.Data.SqlClient.SqlParameter("@OPERACION", 'T'));

            System.Data.SqlClient.SqlDataAdapter adaptador = new SqlDataAdapter(comandoSQL);

            DataTable resultado = new DataTable();
            adaptador.Fill(resultado);

            dgVDatosCa.DataSource = resultado;
        }

        private void TxtNoCarrera_Leave(object sender, EventArgs e)
        {
            if (this.txtNoCarrera.Text == "")
            {

            }
            else
            {
                _sCadenaConexion = "Data Source=DESKTOP-NIUC79P\\SQLEXPRESS;Initial Catalog=Alumnos_KGF;Integrated Security=True";

                System.Data.SqlClient.SqlConnection conexionBD = new
                System.Data.SqlClient.SqlConnection(_sCadenaConexion);
                System.Data.SqlClient.SqlCommand comandoSQL = new SqlCommand();

                comandoSQL.Connection = conexionBD;
                comandoSQL.CommandText = "Sp_Carreras_KGF";
                comandoSQL.CommandType = CommandType.StoredProcedure;

                comandoSQL.Parameters.Add(new SqlParameter("@OPERACION", 'L'));
                comandoSQL.Parameters.Add(new SqlParameter("@Id_Carrera", Convert.ToInt32(this.txtNoCarrera.Text)));

                System.Data.SqlClient.SqlDataAdapter adaptador = new SqlDataAdapter(comandoSQL);
                DataTable resultado = new DataTable();
                adaptador.Fill(resultado);
                if (resultado.Rows.Count == 0)
                {

                }
                else
                {
                    this.txtNombreC.Text = resultado.Rows[0]["Nom_Carrera"].ToString();
                }
            }
        }

        private void BtnAltas_Click(object sender, EventArgs e)
        {
            try
            {
                _sCadenaConexion = "Data Source=DESKTOP-NIUC79P\\SQLEXPRESS;Initial Catalog=Alumnos_KGF;Integrated Security=True";

                System.Data.SqlClient.SqlConnection conexionBD = new SqlConnection(_sCadenaConexion);
                System.Data.SqlClient.SqlCommand comandoSQL = new SqlCommand();
                comandoSQL.Connection = conexionBD;
                comandoSQL.CommandText = "Sp_Carreras_KGF";
                comandoSQL.CommandType = CommandType.StoredProcedure;
                comandoSQL.Parameters.Add(new SqlParameter("@OPERACION", 'I'));
                comandoSQL.Parameters.Add(new SqlParameter("@Id_Carrera", Convert.ToInt64(this.txtNoCarrera.Text)));
                comandoSQL.Parameters.Add(new SqlParameter("@Nom_Carrera", this.txtNombreC.Text));

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
        private void Limpiatextos()
        {
            txtNoCarrera.Text = "";
            txtNombreC.Text = "";
        }
        private void BtnCambios_Click(object sender, EventArgs e)
        {
            try
            {
                _sCadenaConexion = "Data Source=DESKTOP-NIUC79P\\SQLEXPRESS;Initial Catalog=Alumnos_KGF;Integrated Security=True";

                SqlConnection conexionBD = new SqlConnection(_sCadenaConexion);
                SqlCommand comandosql = new SqlCommand();

                comandosql.Connection = conexionBD;
                comandosql.CommandText = "Sp_Carreras_KGF";
                comandosql.CommandType = CommandType.StoredProcedure;
                comandosql.Parameters.Add(new SqlParameter("@OPERACION", 'C'));

                comandosql.Parameters.Add(new SqlParameter("@Id_Carrera", Convert.ToInt64(txtNoCarrera.Text)));
                comandosql.Parameters.Add(new SqlParameter("@Nom_Carrera", txtNombreC.Text));

                conexionBD.Open();
                comandosql.ExecuteNonQuery();
                conexionBD.Close();
                CargaGrid();

                MessageBox.Show("Cambio Efectuado");
                Limpiatextos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("El cambio ya existe" + ex);
            }
        }
        private void BtnBajas_Click(object sender, EventArgs e)
        {
            _sCadenaConexion = "Data Source=DESKTOP-NIUC79P\\SQLEXPRESS;Initial Catalog=Alumnos_KGF;Integrated Security=True";

            Int32 pinControl = pinControl = Int32.Parse(this.txtNoCarrera.Text);
            try
            {
                System.Data.SqlClient.SqlConnection conexionBD = new SqlConnection(_sCadenaConexion);
                System.Data.SqlClient.SqlCommand comandoSQL = new SqlCommand();

                comandoSQL.Connection = conexionBD;
                comandoSQL.CommandText = "Sp_Carreras_KGF";
                comandoSQL.CommandType = CommandType.StoredProcedure;
                comandoSQL.Parameters.Add(new SqlParameter("@OPERACION", 'D'));

                comandoSQL.Parameters.Add(new SqlParameter("@Id_Carrera", pinControl));
                conexionBD.Open();
                comandoSQL.ExecuteNonQuery();
                conexionBD.Close();
                CargaGrid();
                Limpiatextos();
                MessageBox.Show("Baja Efectuada");

            }
            catch (Exception)
            {
                MessageBox.Show("Error al dar de Baja los datos");
            }
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtNoCarrera_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void DgVDatosCa_DoubleClick(object sender, EventArgs e)
        {
            this.txtNoCarrera.Text = dgVDatosCa.CurrentRow.Cells["Id_Carrera"].Value.ToString();
            this.txtNombreC.Text = dgVDatosCa.CurrentRow.Cells["Nom_Carrera"].Value.ToString();
        }
    }
}
