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
    public partial class FormSession : Form
    {
        Admin ad = new Admin();
        public FormSession()
        {
            InitializeComponent();
        }

        private void FormSession_Load(object sender, EventArgs e)
        {
            refresh();
            comboStatus.Items.Add("Active");
            comboStatus.Items.Add("Expired");
            comboStatus.SelectedIndex = 0;
        }

        private void refresh()
        {
            // TODO: This line of code loads data into the 'dataSetSession.Session' table. You can move, or remove it, as needed.
            this.sessionTableAdapter1.Fill(this.dataSetSession.Session);
            if (dataGridViewSesStat.RowCount>0)
            {
                dataGridViewSesStat.Rows.Clear();
                ad.loadSessionCheckin(dataGridViewSesStat);
            }
            else
            {                
                ad.loadSessionCheckin(dataGridViewSesStat);
            }
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                String current = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                String ID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                if (current == "Active")
                {
                    dataGridView1.SelectedRows[0].Cells[6].Value = "Expired";
                    ad.updateStatusSession("Expired", ID);
                }
                else { dataGridView1.SelectedRows[0].Cells[6].Value = "Active"; ad.updateStatusSession("Active", ID); }
            }
            else { MessageBox.Show("No Session is selected."); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                ad.DeleteSession(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                refresh();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text != "" && txtLoc.Text != "")
                {
                    Session s = new Session();
                    String ID = Guid.NewGuid().ToString();
                    s.sessionID = ID;
                    s.name = txtName.Text;
                    s.location = txtLoc.Text;
                    s.date = dateTimeDate.Value;
                    s.startTime = dateTimeStart.Value;
                    s.endTime = dateTimeEnd.Value;
                    s.status = comboStatus.SelectedItem.ToString();
                    ad.createSession(s);
                    MessageBox.Show("Session for " + txtName.Text + " has been created.");
                    clear();
                    refresh();
                }
                else { MessageBox.Show("Enter all the input."); }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);                
            }
            
            
        }

        private void clear()
        {
            txtName.Text = "";
            txtLoc.Text = "";
            dateTimeDate.ResetText();
            dateTimeStart.ResetText();
            dateTimeEnd.ResetText();
            comboStatus.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAssignPes_Click(object sender, EventArgs e)
        {
            FormAssignPeserta f = new FormAssignPeserta(dataGridViewSesStat.SelectedRows[0].Cells[0].Value.ToString(), dataGridViewSesStat.SelectedRows[0].Cells[1].Value.ToString());
            f.ShowDialog();
            refresh();
        }
    }
}
