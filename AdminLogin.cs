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

namespace Homepage
{
    public partial class AdminLogin : Form
    {
        private SqlConnection conn = new SqlConnection();
        private string connString = "Server=DESKTOP-FJDEGFU\\SQLEXPRESS; Database=LibrarySys; User=Taran; Password=samerveer@16";
        private SqlCommand cmd;
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void LblSignin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            //check for empty fields
            if ((username == "") || (password == ""))
            {
                MessageBox.Show("Fields cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((username != "demo") || (password != "demo"))
            {
                MessageBox.Show("Incorrect Login Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    conn.ConnectionString = connString;
                    cmd = conn.CreateCommand();
                    string id;
                    string query = "select * from AdminInfo where Username='" + username + "'and Password='" + password + "'";
                    cmd.CommandText = query;
                    conn.Open();
                    // cmd.ExecuteNonQuery();
                    LoginInfo.Username = txtUsername.Text;
                    SqlDataReader reader = cmd.ExecuteReader();


                    while (reader.Read())
                    {
                        id = reader["AdminId"].ToString();
                        LoginInfo.id = id;
                    }


                    Admin Admin1 = new Admin();
                    Admin1.Show();

                }
                catch (Exception ex)
                {
                    string msg = ex.Message;
                    string caption = "error";
                    MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

        private void LibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void LibrarianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LibrarianLogin LibrarianLogin = new LibrarianLogin();
            LibrarianLogin.Show();
            this.Hide();

        }

        private void MemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberLogin memberlogin = new MemberLogin();
            memberlogin.Show();
            this.Hide();
        }
    }
}
