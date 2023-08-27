using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Form_Project
{
    public partial class Quat_Months_SelectChange : Form
    {
        public Quat_Months_SelectChange()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Quat_Months_SelectChange_Load(object sender, EventArgs e)
        {
            string[] Quarter = { "Quarter1", "Quarter2", "Quarter3", "Quarter4" };
            cbQuarter.Items.AddRange(Quarter);
            //string[] Months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Aug", "Sep", "Oct", "Nov", "Dec" };
            //cbMonths.Items.AddRange(Months);

        }

        private void cbQuarter_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMonths.Items.Clear();
            int index = cbQuarter.SelectedIndex;
            cbMonths.Text = "";

            switch (index) {
                case 0:
                    cbMonths.Items.AddRange(new string[] { "Janevary", "Februvary", "March" });
                    break;
                case 1:
                    cbMonths.Items.AddRange(new string[] { "April", "May", "June" });
                    break;
                case 2:
                    cbMonths.Items.AddRange(new string[] { "July", "August", "September" });
                    break;
                case 3:
                    cbMonths.Items.AddRange(new string[] { "Octomber", "Nvember", "December" });
                    break;
            }
        }
    }
}
