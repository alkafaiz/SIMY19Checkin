using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace SIMY19CheckIn
{
    public partial class FormDataPeserta : Form
    {
        Connection conn = new Connection();
        public FormDataPeserta()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Document|*.xlsx", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {                    
                    textBox1.Text = ofd.FileName;                                        
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if(textBox2.Text!=""&&textBox1.Text != "")
            {
                string pathconn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + textBox1.Text + ";Extended Properties='Excel 12.0 XML;HDR=YES;';";
                OleDbConnection conn = new OleDbConnection(pathconn);
                OleDbDataAdapter da = new OleDbDataAdapter("Select * from [" + textBox2.Text + "$]", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                lblmess.Visible = true;
                lblmess.Text = "Please wait for the importing process..";
                Importing();
                lblmess.Text = "Data has been imported to database.";
            }
            catch (Exception)
            {
                lblmess.Text = "error";
            }
            
        }

        private async void startImporting()
        {
            
            await Task.Run(() => Importing());
            MessageBox.Show("Done.");
            lblmess.Text = "Data has been imported to database.";
        }

        private void Importing()
        {
            conn.getConnected.Open();
            int n = dataGridView1.RowCount;
            for (int i = 0; i < n; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].ToString() != "")
                {
                    Guid ID = Guid.NewGuid();
                    string IDs = ID.ToString();

                    SqlCommand cmd = new SqlCommand(@"INSERT INTO Peserta (pesertaId, nama, gender, email, phone, jenisPeserta, asalNegara, university, paket,panel1,panel2) 
                VALUES('" + IDs +
                    "', '" + dataGridView1.Rows[i].Cells[0].Value.ToString() +
                    "','" + dataGridView1.Rows[i].Cells[1].Value.ToString() +
                    "','" + dataGridView1.Rows[i].Cells[2].Value.ToString() +
                    "','" + dataGridView1.Rows[i].Cells[3].Value.ToString() +
                    "','" + dataGridView1.Rows[i].Cells[4].Value.ToString() +
                    "','" + dataGridView1.Rows[i].Cells[5].Value.ToString() +
                    "','" + dataGridView1.Rows[i].Cells[6].Value.ToString() +
                    "','" + dataGridView1.Rows[i].Cells[7].Value.ToString() +
                    "','" + dataGridView1.Rows[i].Cells[8].Value.ToString() +
                    "','" + dataGridView1.Rows[i].Cells[9].Value.ToString() +
                    "')", conn.getConnected);
                    cmd.ExecuteNonQuery();                   
                }
                
                
            }
            conn.getConnected.Close();
        }
    }
}
