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

namespace Homepage
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void PlayWithBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administrator Administrator = new Administrator();
            Administrator.Show();
           
        }

        private void PlayWithMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageUsers manageUsers = new ManageUsers();
            manageUsers.Show();
            this.Hide();

        }

        private void Admin1_Load(object sender, EventArgs e)
        {

        }

        private void PlayWithLibrarianEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddLibrarian AddLibrarian = new AddLibrarian();
            AddLibrarian.Show();
            this.Hide();

        }
    }
}
