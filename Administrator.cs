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
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }

        private SqlConnection conn = new SqlConnection();
        private string connString = "Server=Laptop-TBE3GK6p\\SQLEXPRESS01; " +
                            "Database=LibrarySystem; User=kaur4542; Password=JKhrt956";
        private SqlCommand cmd;
        private void Form1_Load(object sender, EventArgs e)
        {
            
           
        }
       
        private void LblAuthor_Click(object sender, EventArgs e)
        {

        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnManageUsers_Click(object sender, EventArgs e)
        {
            ManageUsers manageUsers = new ManageUsers();
            manageUsers.Show();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
