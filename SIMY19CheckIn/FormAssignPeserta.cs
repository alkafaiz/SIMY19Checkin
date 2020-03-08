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
    public partial class FormAssignPeserta : Form
    {
        Admin ad = new Admin();
        
        public FormAssignPeserta()
        {
            InitializeComponent();
        }

        public FormAssignPeserta(String sesID, String name)
        {
            InitializeComponent();
            lblSesiID.Text = sesID;
            lblSession.Text = name;
        }

        private void FormAssignPeserta_Load(object sender, EventArgs e)
        {
            refresh();

        }

        private void refresh()
        {
            List<Peserta> pe = ad.getPesertaAssign(lblSesiID.Text);
            var source = new BindingSource();
            source.DataSource = pe;
            dataGridView1.DataSource = source;
        }

        private void search()
        {
            // Create Binding source Object and map it with Datagrid
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;

            // Add your filter as per your requirement
            bs.Filter = dataGridView1.Columns[1].HeaderText.ToString() + " LIKE '%" + txtSearch.Text + "%'";
            //bs.Filter = "Age < 21";

            dataGridView1.DataSource = bs;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("nama LIKE '%{0}%'", txtSearch.Text);
            //if (txtSearch.Text != "")
            //{
            //    search();
            //}
            //else { refresh(); }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            try
            {
                if (ad.getSessionStatus(lblSesiID.Text)=="Active")
                {
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        int n = dataGridView1.SelectedRows.Count;
                        List<String> pesertaID = new List<string>();
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine(dataGridView1.SelectedRows[i].Cells[0].Value.ToString());
                            pesertaID.Add(dataGridView1.SelectedRows[i].Cells[0].Value.ToString());
                        }
                        ad.AssignPeserta(lblSesiID.Text, pesertaID, "Expected");
                        MessageBox.Show(n + " peserta has been assigned to the session");
                        refresh();
                    }
                    else { MessageBox.Show("Please select peserta."); }
                }
                else { MessageBox.Show("Sorry, this session is no longer accepting peserta."); }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void checkBoxAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAll.Checked == true)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Selected = true;

                }
            }
            if (checkBoxAll.Checked == false)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Selected = false;

                }
            }
        }
    }
}
