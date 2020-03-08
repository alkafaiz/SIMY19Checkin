using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMY19CheckIn
{
    public partial class FormExitClient : Form
    {
        ClientInstance Client;
        public FormExitClient()
        {
            InitializeComponent();
            
        }

        public FormExitClient(ClientInstance cl)
        {
            InitializeComponent();
            Client = cl;
            check();
            label1.Focus();
        }

        private void enter()
        {
            if (txtClientKey.Text == "Enter client key")
            {
                txtClientKey.Text = "";
                txtClientKey.ForeColor = Color.Black;
            }
        }

        private void check()
        {
            if (txtClientKey.Text == "")
            {
                txtClientKey.Text = "Enter client key";
                txtClientKey.ForeColor = Color.Gray;
                label1.Focus();
            }
        }

        private void txtClientKey_Enter(object sender, EventArgs e)
        {
            enter();
        }

        private void txtClientKey_Leave(object sender, EventArgs e)
        {
            check();
        }

        private void FormExitClient_Click(object sender, EventArgs e)
        {
            check();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (txtClientKey.Text == Client.ClientKey)
            {                
                Application.Exit();
            }
            else { MessageBox.Show("Client key is incorrect"); }
        }

        private void FormExitClient_Load(object sender, EventArgs e)
        {   
                     
            label1.Focus();
        }
    }
}
