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
    public partial class PictureBox : Form
    {
        public PictureBox()
        {
            InitializeComponent();
        }

        private void BtbChangeColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();
            colorDialog1.Color = BtbChangeColor.BackColor;
            DialogResult dr = colorDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                BtbChangeColor.BackColor = colorDialog1.Color;
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog1 = new FontDialog();
            fontDialog1.Font = btnFont.Font;
            DialogResult dr = fontDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                btnFont.Font = fontDialog1.Font;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Jpeg images|*.jpg|Icon Images|*.ico|All File|*.*";
            openFileDialog1.ShowDialog();
            string Path = openFileDialog1.FileName;
            //MessageBox.Show(openFileDialog1.FileName);
            pictureBox1.ImageLocation = Path;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string path = "";
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.Filter = "Jpeg File|*.jpg|Icon Image|*.con|png File|*.png";
            DialogResult dr = saveFile.ShowDialog();
            if (dr == DialogResult.OK)
            {
                saveFile.FileName = "*.jpg";
                path = saveFile.FileName;
                pictureBox1.Image.Save(path);
            }
        }
    }
}
