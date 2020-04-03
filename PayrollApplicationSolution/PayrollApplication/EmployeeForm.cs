using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollApplication
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private bool isControlsDataValid()
        {
            if (txtEmployeeID.Text.Length < 0)
            {
                //Employee ID Validation
                MessageBox.Show("Please, Enter Employee ID", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmployeeID.Focus();
                txtEmployeeID.BackColor = Color.Silver;
                return false;
            }
            else
            {
                txtEmployeeID.BackColor = Color.White;
            }
            return true;
        }

        private void grpEmployeeInformation_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblFirstName_Click(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtNationalInsID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void lblNotes_Click(object sender, EventArgs e)
        {

        }

        private void txtNotes_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Employee Updated");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Employee Added");
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Employee Deleted");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Control Reset");
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Employee Preview");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region //Keypress Event Validation  
        bool IsNumberOrBackspace;
        private void txtEmployeeID_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsNumberOrBackspace = false;
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                IsNumberOrBackspace = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsNumberOrBackspace = false;
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                IsNumberOrBackspace = true;
            }
            else
            {
                e.Handled = true;

            }

        }
        #endregion 
    }
}
