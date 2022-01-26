//authors ramandeep,  Kunal Khosla and harsamerveer singh

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
using System.Text.RegularExpressions;


namespace Homepage
{
    public partial class AddLibrarian : Form
    {
        //connection string
        private SqlConnection conn = new SqlConnection();
        private string connString = "Server=DESKTOP-FJDEGFU\\SQLEXPRESS; Database=LibrarySys; User=Taran; Password=samerveer@16";
        private SqlCommand cmd;

        public AddLibrarian()
        {
            InitializeComponent();
        }

        private void AddLibrarian_Load(object sender, EventArgs e)
        {
            LoadTable();
        }
        public void LoadTable()
        {
            conn.ConnectionString = connString;
            cmd = conn.CreateCommand();
            try
            {
                String query = "SELECT * FROM LibrarianInfo";
                cmd.CommandText = query;
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dr.Close();
                cmbEmployee.DataSource = dt;
                comboemployee.DataSource = dt;
                cmbEmployee.DisplayMember = "Name";
                cmbEmployee.ValueMember = "LibrarianId";
                comboemployee.DisplayMember = "Name";
                comboemployee.ValueMember = "LibrarianId";
                dataGridView1.DataSource = dt;
            }
            catch (Exception ef)
            {
                MessageBox.Show("Sql Connection cannot established !", DateTime.Now.ToLongDateString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                cmd.Dispose();
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        // If empty method
        public bool isEmpty(String text)
        {
            if (String.IsNullOrEmpty(text))
                throw new EmptyFieldException();
            else
                return false;
        }
        // Validation
        public bool isValidText(String text)
        {
            if (Regex.IsMatch(text, "^[a-zA-Z][a-zA-Z]*$"))
            {
                return true;
            }
            else
            {
                throw new ValidTextException();
            }
        }

        public bool isValidNumber(String text)
        {
            if (Regex.IsMatch(text, "[0-9]+"))
            {
                return true;
            }
            else
            {
                throw new FormatException();
            }
        }
        // Clear textbox
        public void ClearField()
        {
            txtName.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtPhone.Clear();


        }

        //clear picture 
        public void ClearPicture()
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
        }
        // Clear textbox
        public void ClearField1()
        {
            textname.Clear();
            textphonenumber.Clear();
            textusername.Clear();

        }

        private void UploadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // Add Libraraian Employee Account
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            String name = txtName.Text;
            String username = txtUsername.Text;
            String pass = txtPassword.Text;
            String phone = txtPhone.Text;



            try
            {
                if (!isEmpty(name) && !isEmpty(username) && !isEmpty(pass) && !isEmpty(phone))
                {
                    if (isValidText(name) && isValidText(username) && isValidNumber(pass) && isValidNumber(phone))
                    {

                        int phonenumber = Convert.ToInt32(phone);
                        int password = Convert.ToInt32(pass);

                        OpenFileDialog openFileDialog = new OpenFileDialog();

                        openFileDialog.Filter = "Image Files | *.JPG; *.BMP; *.PNG; *.JPEG; *.GIF ";
                        DialogResult result = openFileDialog.ShowDialog();
                        if (result == DialogResult.OK)

                        {
                            pictureBox1.ImageLocation = openFileDialog.FileName;
                            conn.ConnectionString = connString;
                            cmd = conn.CreateCommand();
                            String query = " INSERT INTO LibrarianInfo Values('" + name + "','" + username + "','" + password + "','" + pictureBox1.ImageLocation + "','" + phonenumber + "');";
                            cmd.CommandText = query;
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                            conn.Close();

                            MessageBox.Show("Employee Added Successfully");

                        }
                    }
                }
            }
            catch (EmptyFieldException ef)
            {
                MessageBox.Show("Empty Fields");


            }
            catch (ValidTextException ef)
            {
                MessageBox.Show("NOT A VALID TEXT");
            }
            catch (FormatException ef)
            {
                MessageBox.Show("Not a proper number");
            }
            catch (SqlException ef)
            {
                MessageBox.Show("SQL COULD NOT ESTABLISH CONNECTION");
            }
            finally
            {

                cmd.Dispose();
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                LoadTable();
            }
            ClearField();
            ClearPicture();
        }

        // Update Libraraian Employee Account
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            String name = textname.Text;
            String username = textusername.Text;

            String phone = textphonenumber.Text;

            int select = Convert.ToInt32(comboemployee.SelectedValue);

            try
            {
                if (!isEmpty(name) && !isEmpty(username) && !isEmpty(phone))
                {
                    if (isValidText(name) && isValidText(username) && isValidNumber(phone))
                    {

                        int phonenumber = Convert.ToInt32(phone);


                        OpenFileDialog openFileDialog = new OpenFileDialog();

                        openFileDialog.Filter = "Image Files | *.JPG; *.BMP; *.PNG; *.JPEG; *.GIF ";
                        DialogResult result = openFileDialog.ShowDialog();
                        if (result == DialogResult.OK)

                        {
                            pictureBox2.ImageLocation = openFileDialog.FileName;
                            conn.ConnectionString = connString;
                            cmd = conn.CreateCommand();
                            String query = "UPDATE LibrarianInfo SET Name='" + name + "', Username='" + username + "', ImageLoc='" + pictureBox2.ImageLocation + "', phoneNumber='" + phonenumber + "' WHERE LibrarianId=" + select;
                            cmd.CommandText = query;
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                            conn.Close();

                            MessageBox.Show("Employee Updated Successfully");

                        }
                    }
                }
            }
            catch (EmptyFieldException ef)
            {
                MessageBox.Show("Empty Fields");


            }
            catch (ValidTextException ef)
            {
                MessageBox.Show("Invalid Format Text");
            }
            catch (FormatException ef)
            {
                MessageBox.Show("Invalid Format Number");
            }
            catch (SqlException ef)
            {
                MessageBox.Show("Sorry No Connection");
            }
            finally
            {

                cmd.Dispose();
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                LoadTable();
            }
            ClearField();
            ClearPicture();
        }


        // Delete Libraraian Employee Account
        private void DeleteAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int userSelect = Convert.ToInt32(cmbEmployee.SelectedValue);
            conn.ConnectionString = connString;
            cmd = conn.CreateCommand();
            try
            {


                String query = "DELETE FROM LibrarianInfo WHERE LibrarianId=" + userSelect + ";";
                conn.Open();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Account Deleted !");


            }
            catch (EmptyFieldException ef)
            {
                MessageBox.Show("Empty Fields");


            }
            catch (ValidTextException ef)
            {
                MessageBox.Show("Invalid Format Text");
            }
            catch (FormatException ef)
            {
                MessageBox.Show("Invalid Format Number");
            }
            catch (SqlException ef)
            {
                MessageBox.Show("Sorry No Connection");
            }
            finally
            {

                cmd.Dispose();
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                LoadTable();
            }
            ClearField1();
        }

        private void AddLibrarian_Load_1(object sender, EventArgs e)
        {

        }

        private void TxtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}






