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
    public partial class FormCreateClient : Form
    {
        Admin ad = new Admin();
        List<Session> ses;
        public FormCreateClient()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtClientKey.Text!=""&& txtPw.Text != "")
            {
                String id = "";
                foreach (Session item in ses)
                {
                    if(item.name== comboSession.SelectedItem.ToString())
                    {
                        id = item.sessionID;
                        break;
                    }
                }                
                ad.createClientInstance(txtClientKey.Text, txtPw.Text, id, comboStatus.SelectedItem.ToString());
                MessageBox.Show("New Instance created.");
                this.Close();
            }
            else { MessageBox.Show("Please ensure all the entries are correct."); }
            
        }

        private void FormCreateClient_Load(object sender, EventArgs e)
        {
            ses = ad.getSession();
            foreach (Session item in ses)
            {
                comboSession.Items.Add(item.name);
            }
            comboSession.SelectedIndex = 0;
            comboStatus.Items.Add("Active");
            comboStatus.Items.Add("Disabled");
            comboStatus.SelectedIndex = 0;
        }
    }
}
