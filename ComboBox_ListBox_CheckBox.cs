using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Windows.Forms;

namespace Windows_Form_Project
{
    public partial class ComboBox_ListBox_CheckBox : Form
    {
        public ComboBox_ListBox_CheckBox()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox_ListBox_CheckBox_Load(object sender, EventArgs e)
        {
            CityName.Items.Add("Nashik");
            CityName.Items.Add("Mumbai");
            CityName.Items.Add("Pune");
            CityName.Items.Add("Ahemednagar");
            CityName.Items.Add("Aurangabad");

            string[] str = { "MH", "KA", "GJ", "MP", "JK", "PB", "PJ" };
            StateList.Items.AddRange(str);

            string[] country = { "INDIA", "Pakistan", "Bangladesh", "China", "America", "UK", "Australia" };
            CountryList.Items.AddRange(country);



        }

        private void btnListBox_Click(object sender, EventArgs e)
        {
            /*
            foreach (object obj in StateList.SelectedItems)
            {
                MessageBox.Show(obj.ToString());
            } */
            string str = "";
            foreach (object obj in StateList.SelectedItems)
            {
                str += obj + ", ";
            }
            if (str.LastIndexOf(',') != -1)
                str = str.Remove(str.LastIndexOf(','));
            int lastIndex = str.LastIndexOf(',');
            if (lastIndex > 0)
            {
                str = str.Remove(lastIndex, 1);
                str = str.Insert(lastIndex, " and");
            }

            MessageBox.Show(str);
        }

        private void btnComboBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CityName.Text);
        }

        private void StateList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CityName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // MessageBox.Show(Convert.ToInt32(e.KeyChar).ToString());
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                if (CityName.FindStringExact(CityName.Text) == -1)
                {
                    CityName.Items.Add(CityName.Text);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = "";
            foreach (object obj in CountryList.CheckedItems)
            {
                str += obj + ", ";
            }
            if (str.LastIndexOf(',') != -1)
                str = str.Remove(str.LastIndexOf(','));
            int lastIndex = str.LastIndexOf(',');
            if (lastIndex > 0)
            {
                str = str.Remove(lastIndex, 1);
                str = str.Insert(lastIndex, " and");
            }

            MessageBox.Show(str);
        }
    }
 
}

