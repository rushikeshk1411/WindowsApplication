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
    public partial class SlideShow : Form
    {
        public SlideShow()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Ofbd1 = new FolderBrowserDialog();
            DialogResult dr = Ofbd1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string path = Ofbd1.SelectedPath;
                string[] file = Directory.GetFiles(path, "*.jpg");
                lbImage.Tag = path;
                foreach (string str in file)
                {
                    int lastIndex = str.LastIndexOf('\\');
                    string Filename = str.Substring(lastIndex + 1);
                    lbImage.Items.Add(Filename);
                }
                if (file.Length > 0)
                    pictureBox1.ImageLocation = file[0];
                btnprev.Enabled = false;
                btnStart.Enabled = true;

            }
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            if (lbImage.SelectedIndex > 0)
            {
                lbImage.SelectedIndex -= 1;
            }
        }

        private void lbImage_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = lbImage.Tag + "\\" + lbImage.SelectedItem.ToString();
            if (lbImage.SelectedIndex <= lbImage.Items.Count) btnNext.Enabled = true;
            if (lbImage.SelectedIndex > 0) btnprev.Enabled = true;
            if (lbImage.SelectedIndex == 0) btnprev.Enabled = false;
            if (lbImage.SelectedIndex + 1 == lbImage.Items.Count) btnNext.Enabled = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (lbImage.SelectedIndex < lbImage.Items.Count - 1)
            {
                lbImage.SelectedIndex += 1;
            }
            else
            {
                btnNext.Enabled = false;
            }
        }
        object[] obj = new object[3];
        private void btnStart_Click(object sender, EventArgs e)
        {
            obj[0] = this.WindowState;
            obj[1] = panel1.Width;
            obj[2] = pictureBox1.BorderStyle;
            pictureBox1.BorderStyle = BorderStyle.None;
            panel1.Width = 0;
            this.WindowState = FormWindowState.Maximized;
            timer1.Start();
            btnStop.Enabled = true;
            btnStop.Visible = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btnStop.Visible = false;
            this.WindowState = (FormWindowState)obj[0];
            panel1.Width = (int)obj[1];
            pictureBox1.BorderStyle = (BorderStyle)obj[2];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lbImage.SelectedIndex < lbImage.Items.Count - 1)
            {
                lbImage.SelectedIndex += 1;
            }
            else
            {
                btnStop.PerformClick();
            }

        }

        private void SlideShow_Load(object sender, EventArgs e)
        {
            btnStop.Visible = false;
        }
    }
}
