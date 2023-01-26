//19480809 BACKEND - FORM
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PW20c
{
    public partial class Form1 : Form
    {
        int I = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNoControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtApePaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtApeMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void dtpFechaIngreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void cobMesAño_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void RbEnero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void RbFebrero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void RbMarzo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void RbAbril_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void RbMayo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void ChkEnero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void ChkFebrero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void ChkMarzo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void ChkAbril_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void ChkMayo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }


        private void ChkEnero_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Enero Check ");
        }
        private void ChkFebrero_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Febrero Check ");
        }
        private void ChkMarzo_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Marzo Check ");
        }

        private void ChkAbril_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Abril Check ");
        }

        private void ChkMayo_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Mayo Check ");
        }

        private void dgvAgregar_DoubleClick(object sender, EventArgs e)
        {
            String CON = dgvAgregar.CurrentRow.Cells[0].Value.ToString();
            txtNoControl.Text = dgvAgregar.CurrentRow.Cells[1].Value.ToString();
            txtNombre.Text = dgvAgregar.CurrentRow.Cells[2].Value.ToString();
            txtApePaterno.Text = dgvAgregar.CurrentRow.Cells[3].Value.ToString();
            txtApeMaterno.Text = dgvAgregar.CurrentRow.Cells[4].Value.ToString();

            String Fecha = dgvAgregar.CurrentRow.Cells[5].Value.ToString();

            dtpFechaIngreso.Value = DateTime.Parse(Fecha);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnConsultar_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("No. Control     " + txtNoControl.Text);
            MessageBox.Show("Nombre     " + txtNombre.Text);
            MessageBox.Show("Apellido Paterno     " + txtApePaterno.Text);
            MessageBox.Show("Apellido Materno     " + txtApeMaterno.Text);
            MessageBox.Show("Fecha Ingreso     " + dtpFechaIngreso.Value);
            MessageBox.Show("Mes del Año     " + cobMesAño.Text.ToString());

            if (RbEnero.Checked == true)
            {
                MessageBox.Show("Enero");
            }
            if (RbFebrero.Checked == true)
            {
                MessageBox.Show("Febrero");
            }
            if (RbMarzo.Checked == true)
            {
                MessageBox.Show("Marzo");
            }
            if (RbAbril.Checked == true)
            {
                MessageBox.Show("Abril");
            }
            if (RbMayo.Checked == true)
            {
                MessageBox.Show("Mayo");
            }
            if (ChkEnero.Checked == true)
            {
                MessageBox.Show("Enero-Chek");
            }
            if (ChkFebrero.Checked == true)
            {
                MessageBox.Show("Febrero-Chek");
            }
            if (ChkMarzo.Checked == true)
            {
                MessageBox.Show("Marzo-Chek");
            }
            if (ChkAbril.Checked == true)
            {
                MessageBox.Show("Abril-Chek");
            }
            if (ChkMayo.Checked == true)
            {
                MessageBox.Show("Mayo-Chek");
            }
        }

        private void BtnGuardar_Click_1(object sender, EventArgs e)
        {
            if (txtNoControl.Text == "")
            {

            }
            else
                dgvAgregar.Rows.Add(I, txtNoControl.Text, txtNombre.Text,
                    txtApePaterno.Text, txtApeMaterno.Text, dtpFechaIngreso.Value,
                    cobMesAño.Text.ToString());
            I = I + 1;
            txtNoControl.Text = "";
            txtNombre.Text = "";
            txtApePaterno.Text = "";
            txtApeMaterno.Text = "";
            dtpFechaIngreso.Value = System.DateTime.Today;
            txtNoControl.Focus();
            {

            }
        }

        private void txtNoControl_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtApePaterno_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dgvAgregar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
