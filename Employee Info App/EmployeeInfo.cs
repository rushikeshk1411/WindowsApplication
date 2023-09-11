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
using System.Configuration;
using System.Data.SqlTypes;
using System.IO;
using static Microsoft.VisualBasic.Interaction;
using System.Linq.Expressions;

namespace Configure
{
    public partial class EmployeeInfo : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader dr;
        string imgpath = "";
        byte[] imgData = null;
        public EmployeeInfo()
        {
            InitializeComponent();
        }

        private void EmployeeInfo_Load(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString;
            con = new SqlConnection(str);
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                string TEno = InputBox("Enter the Eno for search");
                if (int.TryParse(TEno, out int Eno))
                {
                    try
                    {
                        cmd.CommandText = "NEMployee_Select";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("Eno", Eno);
                        cmd.Parameters.AddWithValue("Status", true);

                        con.Open();
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            tbEno.Text = dr["Eno"].ToString();
                            tbEname.Text = dr["Ename"].ToString();
                            tbJob.Text = dr["Job"].ToString();
                            tbSalary.Text = dr["Salary"].ToString();

                            if (dr["Photo"] != DBNull.Value)
                            {
                                imgData = (byte[])dr["Photo"];
                                MemoryStream ms = new MemoryStream(imgData);
                                pictureBox1.Image = Image.FromStream(ms);
                            }
                            else
                            {
                                imgData = null;
                                imgpath = "";
                                pictureBox1.Image = null;
                            }
                        }
                        else
                        {
                            MessageBox.Show("You are at last row of the table", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Enter the interger Number");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbEno.Text = tbEname.Text = tbJob.Text = tbSalary.Text = "";
            pictureBox1.Image = null;
            tbEname.Focus();
            imgpath = "";
            imgData = null;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {   
            if (btnInsert.Text == "New")
            {
                btnClear.PerformClick();
                btnInsert.Text = "Insert";
            }
            else
            {
                try
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = "NEmployee_Insert";
                    con.Open();
                    //dr.Close();
                    //cmd.Parameters.AddWithValue("@Eno", tbEno.Text);
                    cmd.Parameters.Add("Eno", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("Ename", tbEname.Text);
                    cmd.Parameters.AddWithValue("Job", tbJob.Text);
                    cmd.Parameters.AddWithValue("Salary", tbSalary.Text);

                    if (imgpath.Trim().Length > 0)
                    {
                        imgData = File.ReadAllBytes(imgpath);
                        cmd.Parameters.AddWithValue("Photo", imgData);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("Photo", DBNull.Value);
                        cmd.Parameters["Photo"].SqlDbType = SqlDbType.VarBinary;
                    }
                    cmd.ExecuteNonQuery();
                    tbEno.Text = cmd.Parameters["Eno"].Value.ToString();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    btnInsert.Text = "New";
                    imgData = null;
                    imgpath = "";
                    con.Close();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "NEmployee_Update";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("Eno", tbEno.Text);
            cmd.Parameters.AddWithValue("Ename", tbEname.Text);
            cmd.Parameters.AddWithValue("Job", tbJob.Text);
            cmd.Parameters.AddWithValue("Salary", tbSalary.Text);

            if(imgData == null && imgpath.Trim().Length == 0)
            {
                cmd.Parameters.AddWithValue("Photo", DBNull.Value);
                cmd.Parameters["Photo"].SqlDbType = SqlDbType.VarBinary;
            }
            else if(imgpath.Trim().Length > 0)
            {
                imgData= File.ReadAllBytes(imgpath);
                cmd.Parameters.AddWithValue("Photo", imgData);
                //MessageBox.Show(imgData.ToString());
            }
            else if(imgpath.Trim().Length == 0 && imgpath != null)
            {
                cmd.Parameters.AddWithValue("Photo", imgData);
            }
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Updation is succesful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you want to Sure to Deleting ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dr == DialogResult.Yes)
            {
                cmd.Parameters.Clear();
                con.Open();
                cmd.CommandText = "NEmployee_Delete";
                cmd.Parameters.AddWithValue("Eno", tbEno.Text);
                cmd.ExecuteNonQuery();
                btnClear.PerformClick();
                con.Close();
                MessageBox.Show("Record is successful deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
            this.Close();
        }

        private void btnClearImage_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            imgpath = "";
            imgData = null;
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Jpg Images|*.jpg|Jpeg Images|*.jpeg|ALL|*.*";
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                imgpath = openFileDialog1.FileName;
                pictureBox1.ImageLocation = imgpath;
            }
        }
    }
}
