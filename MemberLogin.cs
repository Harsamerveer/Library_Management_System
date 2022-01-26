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
    public partial class MemberLogin : Form
    {
        private SqlConnection conn = new SqlConnection();
        private string connString = "Server=DESKTOP-FJDEGFU\\SQLEXPRESS; Database=LibrarySys; User=Taran; Password=samerveer@16";
        private SqlCommand cmd;

        public MemberLogin()
        {
            InitializeComponent();
        }

        private void MemberLogin_Load(object sender, EventArgs e)
        {

        }

        private void LblSignin_Click(object sender, EventArgs e)
        {


            string username = txtUsername.Text;
            string password = txtPassword.Text;


            if ((username == "") || (password == ""))
            {
                MessageBox.Show("Fileds cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    conn.ConnectionString = connString;
                    cmd = conn.CreateCommand();
                    string id;
                    string query = "select * from Members where Username='" + username + "'and Password='" + password + "'";
                    cmd.CommandText = query;
                    conn.Open();
                    // cmd.ExecuteNonQuery();
                    LoginInfo.Username = txtUsername.Text;
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {


                        reader.Read();
                        id = reader["UserId"].ToString();
                        LoginInfo.id = id;
                        txtUsername.Clear();
                        txtPassword.Clear();
                        Member member = new Member();
                        member.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or password", DateTime.Now.ToLongDateString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }




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
            LibrarianLogin librarianlogin = new LibrarianLogin();
            librarianlogin.Show();
            this.Hide();
        }

        private void MemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminLogin AdminLogin = new AdminLogin();
            AdminLogin.Show();
            this.Hide();
        }
    }
}
