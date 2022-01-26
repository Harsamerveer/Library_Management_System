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
    public partial class Member : Form
    {
        public Member()
        {
            InitializeComponent();
        }

        private SqlConnection conn = new SqlConnection();
        private string connString = "Server=Laptop-TBE3GK6p\\SQLEXPRESS01; " +
                            "Database=Library; User=kaur4542; Password=JKhrt956";
        private SqlCommand cmd;

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SearchABookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
        }

        private void RequestABookToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditAccount editAccount = new EditAccount();
            editAccount.Show();
        }

        private void Member_Load(object sender, EventArgs e)
        {
            try
            {
                conn.ConnectionString = connString;
                cmd = conn.CreateCommand();
                

                string query = "select * from Members ";
                cmd.CommandText = query;
                conn.Open();
                cmd.ExecuteNonQuery();
                lblUser.Text = LoginInfo.Username;
                string id = LoginInfo.id;
                string query2 = "select * from Members_Book where UserId="+id;
                cmd.CommandText = query2;
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;
                
                reader.Close();

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

        private void BooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
        }
    }
}
