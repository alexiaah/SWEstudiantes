//Materias.cs KAREN ALEXIA GONZALEZ FLORES 19480809
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
    public partial class Materias : Form
    {
        private string _sCadenaConexion = string.Empty;
        public Materias()
        {
            InitializeComponent();
        }

        private void Materias_Load(object sender, EventArgs e)
        {
            CargaGrid();
        }
        public void CargaGrid()
        {
            _sCadenaConexion = "Data Source=DESKTOP-NIUC79P\\SQLEXPRESS;Initial Catalog=Alumnos_KGF;Integrated Security=True";

            System.Data.SqlClient.SqlConnection conexionDB = new System.Data.SqlClient.SqlConnection(_sCadenaConexion);
            System.Data.SqlClient.SqlCommand comandoSQL = new SqlCommand();

            comandoSQL.Connection = conexionDB;
            comandoSQL.CommandText = "Sp_Materias_KGF";
            comandoSQL.CommandType = CommandType.StoredProcedure;
            comandoSQL.Parameters.Add(new System.Data.SqlClient.SqlParameter("@OPERACION", 'T'));

            System.Data.SqlClient.SqlDataAdapter adaptador = new SqlDataAdapter(comandoSQL);

            DataTable resultado = new DataTable();
            adaptador.Fill(resultado);

            dgVDatosMa.DataSource = resultado;
        }
        private void txtNoMateria_Leave(object sender, EventArgs e)
        {
            if (this.txtNoMateria.Text == "")
            {

            }
            else
            {
                _sCadenaConexion = "Data Source=DESKTOP-NIUC79P\\SQLEXPRESS;Initial Catalog=Alumnos_KGF;Integrated Security=True";

                System.Data.SqlClient.SqlConnection conexionBD = new
                System.Data.SqlClient.SqlConnection(_sCadenaConexion);
                System.Data.SqlClient.SqlCommand comandoSQL = new SqlCommand();

                comandoSQL.Connection = conexionBD;
                comandoSQL.CommandText = "Sp_Materias_KGF";
                comandoSQL.CommandType = CommandType.StoredProcedure;

                comandoSQL.Parameters.Add(new SqlParameter("@OPERACION", 'L'));
                comandoSQL.Parameters.Add(new SqlParameter("@Id_Materia", Convert.ToInt32(this.txtNoMateria.Text)));

                System.Data.SqlClient.SqlDataAdapter adaptador = new SqlDataAdapter(comandoSQL);
                DataTable resultado = new DataTable();
                adaptador.Fill(resultado);
                if (resultado.Rows.Count == 0)
                {

                }
                else
                {
                    this.txtNombreM.Text = resultado.Rows[0]["Nom_Materia"].ToString();
                }
            }
        }
        private void Limpiatextos()
        {
            txtNoMateria.Text = "";
            txtNombreM.Text = "";
        }
        private void btnAltas_Click(object sender, EventArgs e)
        {
            try
            {
                _sCadenaConexion = "Data Source=DESKTOP-NIUC79P\\SQLEXPRESS;Initial Catalog=Alumnos_KGF;Integrated Security=True";

                System.Data.SqlClient.SqlConnection conexionBD = new SqlConnection(_sCadenaConexion);
                System.Data.SqlClient.SqlCommand comandoSQL = new SqlCommand();
                comandoSQL.Connection = conexionBD;
                comandoSQL.CommandText = "Sp_Materias_KGF";
                comandoSQL.CommandType = CommandType.StoredProcedure;
                comandoSQL.Parameters.Add(new SqlParameter("@OPERACION", 'I'));
                comandoSQL.Parameters.Add(new SqlParameter("@Id_Materia", Convert.ToInt64(this.txtNoMateria.Text)));
                comandoSQL.Parameters.Add(new SqlParameter("@Nom_Materia", this.txtNombreM.Text));

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

        private void btnBajas_Click(object sender, EventArgs e)
        {
            _sCadenaConexion = "Data Source=DESKTOP-NIUC79P\\SQLEXPRESS;Initial Catalog=Alumnos_KGF;Integrated Security=True";

            Int32 pinControl = pinControl = Int32.Parse(this.txtNoMateria.Text);
            try
            {
                System.Data.SqlClient.SqlConnection conexionBD = new SqlConnection(_sCadenaConexion);
                System.Data.SqlClient.SqlCommand comandoSQL = new SqlCommand();

                comandoSQL.Connection = conexionBD;
                comandoSQL.CommandText = "Sp_Materias_KGF";
                comandoSQL.CommandType = CommandType.StoredProcedure;
                comandoSQL.Parameters.Add(new SqlParameter("@OPERACION", 'D'));

                comandoSQL.Parameters.Add(new SqlParameter("@Id_Materia", pinControl));
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

        private void btnCambios_Click(object sender, EventArgs e)
        {
            try
            {
                _sCadenaConexion = "Data Source=DESKTOP-NIUC79P\\SQLEXPRESS;Initial Catalog=Alumnos_KGF;Integrated Security=True";

                SqlConnection conexionBD = new SqlConnection(_sCadenaConexion);
                SqlCommand comandosql = new SqlCommand();

                comandosql.Connection = conexionBD;
                comandosql.CommandText = "Sp_Materias_KGF";
                comandosql.CommandType = CommandType.StoredProcedure;
                comandosql.Parameters.Add(new SqlParameter("@OPERACION", 'C'));

                comandosql.Parameters.Add(new SqlParameter("@Id_Materia", Convert.ToInt64(txtNoMateria.Text)));
                comandosql.Parameters.Add(new SqlParameter("@Nom_Materia", txtNombreM.Text));

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
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNoMateria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }

        }

        private void dgVDatosMa_DoubleClick(object sender, EventArgs e)
        {
            this.txtNoMateria.Text = dgVDatosMa.CurrentRow.Cells["Id_Materia"].Value.ToString();
            this.txtNombreM.Text = dgVDatosMa.CurrentRow.Cells["Nom_Materia"].Value.ToString();
        }
    }
}
