using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Form_Project
{
    public partial class Registration_Form : Form
    {
        public Registration_Form()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Button btn1 = sender as Button;
            if (btn1.Name == "btnReset")
            {
                foreach (Control c1 in this.Controls)
                {
                    if (c1 is TextBoxBase)
                    {
                        TextBoxBase t1 = c1 as TextBoxBase;
                        t1.Clear();
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registration Succesfull", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void tbUName_Validating(object sender, CancelEventArgs e)
        { 

            if (sender is TextBox)
            {
                TextBox tb1 = sender as TextBox;

                if (tb1.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Field can not be Empty");
                    e.Cancel = true;
                    return;
                }
                if (tb1.Name != "tbUName" && tb1.Text.Trim().Length < 8)
                {
                    Regex PassProtection = new Regex(@"[a-zA-Z0-9]{7-100}");
                    if (!PassProtection.IsMatch(tb1.Text))
                    {
                        MessageBox.Show("Message should contains Alphanumeric value");
                    }
                    MessageBox.Show("The Password Should be at least 8 character");
                    e.Cancel = true;
                    return;
                }
                if (tb1.Name == "tbCPass")
                {
                    if (tbPass.Text != tbCPass.Text)
                    {
                        DialogResult dr = MessageBox.Show("Confirm Password is not matched with Password \n \n Do you remember the password ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dr == DialogResult.Yes)
                        {
                            tbCPass.Clear();
                            tbCPass.Focus();
                        }
                        else
                        {
                            tbPass.Clear();
                            tbCPass.Clear();
                            tbPass.Focus();
                        }
                    }
                    else
                    {
                        tbPass.Enabled = false;
                        tbCPass.Enabled = false;
                    }
                }
            } 
            if (sender is MaskedTextBox)
            {
                MaskedTextBox maskedTextBox = sender as MaskedTextBox;
                if (maskedTextBox.Text.Replace("-", "").Trim().Length > 0)
                {
                    DateTime dt;
                    bool status = DateTime.TryParseExact(maskedTextBox.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dt);
                    if (status)
                    {
                        if (DateTime.Now.Year - dt.Year < 18)
                        {
                            MessageBox.Show("You should attain at least 18 years", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            e.Cancel = true;
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter valid date ! \n the date in DD/MM/YYYY");
                        e.Cancel = true;
                        return;

                    }

                }
                else
                {
                    MessageBox.Show("Please Enter Your Birth date");
                    maskedTextBox.Focus();
                    return;
                }
            }
        }


        private void maskedTextBox1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void tbMobile_Validating(object sender, CancelEventArgs e)
        {

            TextBox tm = sender as TextBox;
            if (tm.Text.Trim().Length > 0)
            {
                Regex mobileValidation = new Regex(@"^[6-9]\d{9}$");
                if (!mobileValidation.IsMatch(tm.Text))
                {
                    MessageBox.Show($"{tm.Text}");
                    MessageBox.Show("Enter valid Mobile no", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tbMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            // MessageBox.Show(Convert.ToInt32(e.KeyChar).ToString());
            TextBox ct = sender as TextBox;
            if (ct.Name == "tbMobile")
            {
                if (Convert.ToInt32(e.KeyChar) != 8 && !char.IsDigit(e.KeyChar))
                {
                    MessageBox.Show("Enter Only numeric value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Handled = true;
                }
            }
            if (ct.Name == "tbUName")
            {
                if (Convert.ToInt32(e.KeyChar) != 8 && !char.IsLetter(e.KeyChar))
                {
                    MessageBox.Show("NUmeric Value is Not allowed in user Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Handled = true;
                }
            }
        }
    }
}
