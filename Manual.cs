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
    public partial class Manual : Form
    {
        public Manual()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //return button functionality

            Form1 returntomainapplication = new Form1();
            returntomainapplication.Show();
            this.Hide();

        }

        private void Contact_Information_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
