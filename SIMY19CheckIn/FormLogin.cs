using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMY19CheckIn
{
    public partial class FormLogin : Form
    {
        Connection conn = new Connection();
        public FormLogin()
        {
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Loading load = new Loading();
            //load.Show();
            //Application.DoEvents();
            login();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            EnterLoading enter = new EnterLoading();
            enter.ShowDialog();
            if (enter.connected == true) { }
            else { this.Close(); }
        }        

        private void login()
        {
            if (conn.getConnected.State != ConnectionState.Open) { conn.getConnected.Open(); }
            SqlDataAdapter sda = new SqlDataAdapter("Select username,password from SysUser Where username = '" + txtUsername.Text + "' and password ='" + txtPassword.Text + "' ", conn.getConnected);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {                                                
                Form1 f = new Form1();
                f.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Please ensure your username and password are correct!");
            conn.getConnected.Close();
        }

        private void linkLabelCheckin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelLogin.Visible = false;
            panelCheckin.Location = new Point(12, 12);
            panelCheckin.Visible = true;
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelLogin.Visible = true;            
            panelCheckin.Visible = false;
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            bool granted = ad.authorizeCLient(txtclientkey.Text, txtpwclient.Text);
            if(granted == true)
            {
                bool active = ad.isClientActive(txtclientkey.Text);
                if (active == true)
                {                    
                    FormSelfCheckin f = new FormSelfCheckin(ad.getSession(txtclientkey.Text),ad.getClientInstance(txtclientkey.Text));
                    f.Show();
                    this.Hide();
                }
                else { MessageBox.Show("The client is disabled."); }
                
            }
            else { MessageBox.Show("Please ensure your username and password are correct!"); }
            
        }
    }
}
