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
    public partial class LibrarianLogin : Form
    {
        private SqlConnection conn = new SqlConnection();
        private string connString = "Server=DESKTOP-FJDEGFU\\SQLEXPRESS; Database=LibrarySys; User=Taran; Password=samerveer@16";
        private SqlCommand cmd;
        public LibrarianLogin()
        {
            InitializeComponent();
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
                    string query = "select * from LibrarianInfo where Username='" + username + "'and Password='" + password + "'";
                    cmd.CommandText = query;
                    conn.Open();
                    // cmd.ExecuteNonQuery();
                    LoginInfo.Username = txtUsername.Text;
                    SqlDataReader reader = cmd.ExecuteReader();


                    while (reader.Read())
                    {
                        id = reader["LibrarianId"].ToString();
                        LoginInfo.id = id;
                    }


                    Librarian lb = new Librarian();
                    lb.Show();
                    this.Hide();

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

        private void LibrarianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminLogin AdminLogin = new AdminLogin();
            AdminLogin.Show();
            this.Hide();
        }

        private void MemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberLogin mlogin = new MemberLogin();
            mlogin.Show();
            this.Hide();
        }

        private void LibrarianLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
