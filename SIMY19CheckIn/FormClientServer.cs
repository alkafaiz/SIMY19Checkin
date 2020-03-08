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
    public partial class FormClientServer : Form
    {
        Admin ad = new Admin();
        public FormClientServer()
        {
            InitializeComponent();
        }

        private void FormClientServer_Load(object sender, EventArgs e)
        {

            refresh();
        }

        private void refresh()
        {
            //if (dataGridView1.RowCount >= 1)
            //{
            //    dataGridView1.Rows.Clear();
            //}
            // TODO: This line of code loads data into the 'clientServer._ClientServer' table. You can move, or remove it, as needed.
            this.clientServerTableAdapter.Fill(this.clientServer._ClientServer);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCreateClient form = new FormCreateClient();
            form.ShowDialog();
            refresh();
        }

        private void btnActDe_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                String current = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                String key = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                if (current == "Active")
                {
                    dataGridView1.SelectedRows[0].Cells[3].Value = "Disabled";
                    ad.updateStatusClient("Disabled", key);
                }
                else { dataGridView1.SelectedRows[0].Cells[3].Value = "Active"; ad.updateStatusClient("Active", key); }                                
            }
            else { MessageBox.Show("No Client is selected."); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                ad.DeleteClientInstance(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                refresh();
            }
        }
    }
}
