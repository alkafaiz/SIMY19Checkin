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
    public partial class Form1 : Form
    {
        Connection conn = new Connection();
        Admin ad = new Admin();
        public Form1()
        {
            InitializeComponent();
            //string connetionString;

            //connetionString = @"Data Source=simyjb.database.windows.net;Initial Catalog=SImy19;Integrated Security=False;User ID=adminsi19;Password=@dminsi19;Connect Timeout=15;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //cnn = new SqlConnection(connetionString);
            //cnn.Open();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }

        private void refresh()
        {
            String sesID = "";
            foreach (Session item in ad.getSession())
            {
                if (item.name == comboSession.SelectedItem.ToString())
                {
                    sesID = item.sessionID;
                    sessionID = item.sessionID;
                    break;
                }
            }
            ad.loadPesertaCheckin(dataGridView1, sesID);
        }

        private void changeSession()
        {
            foreach (Session item in ad.getSession())
            {
                if (item.name == comboSession.SelectedItem.ToString())
                {
                    lblTanggalSessi.Text = item.date.ToShortDateString(); break;
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            InitTimer();
            List<Session> ses = ad.getSession();
            foreach (Session item in ses)
            {
                comboSession.Items.Add(item.name);
            }
            comboSession.SelectedIndex = 0;
            foreach (Session item in ses)
            {
                if (item.name == comboSession.SelectedItem.ToString())
                {
                    lblTanggalSessi.Text = item.date.ToShortDateString(); break;
                }
            }
            //ad.loadPesertaCheckin(dataGridView1, ses[0].sessionID);
            pictureBoxLoading.Visible = true;
            mode = "load";
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormDataPeserta dtp = new FormDataPeserta();
            dtp.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormClientServer f = new FormClientServer();
            f.ShowDialog();
        }

        private void btnSession_Click(object sender, EventArgs e)
        {
            FormSession form = new FormSession();
            form.ShowDialog();
            int n = comboSession.Items.Count;
            
            List<Session> ses = ad.getSession();
            if(n!= ses.Count)
            {
                String select = comboSession.SelectedItem.ToString();
                comboSession.Items.Clear();
                foreach (Session item in ses)
                {
                    comboSession.Items.Add(item.name);
                    if (select == item.name) { comboSession.SelectedItem = select; }
                }
                
            }
        }

        private void comboSession_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (Session item in ad.getSession())
                {
                    if (item.name == comboSession.SelectedItem.ToString())
                    {
                        sessionID = item.sessionID;
                        lblTanggalSessi.Text = item.date.ToShortDateString();
                        break;
                    }
                }
                //changeSession();
                mode = "load";
                pictureBoxLoading.Visible = true;
                if (!backgroundWorker1.IsBusy)
                    backgroundWorker1.RunWorkerAsync();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        List<Peserta> pesertalist;
        String mode = "";
        DataTable dataPes;
        protected String sessionID = "";
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (mode == "load")
            {
                //pesertalist = ad.loadPesertaCheckin2(sessionID);
                dataPes = ad.loadPesertaCheckin4(sessionID);
                Console.WriteLine("this is load");
            }
            if (mode == "search")
            {
                dataPes = ad.SearchPesertaCheckin2(sessionID, txtSearch.Text);
            }
            
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            //if (dataGridView1.RowCount > 0) { dataGridView1.Rows.Clear(); }
            checkBoxCheckedin.Checked = true;
            checkBoxExpected.Checked = true;
            //DataTable dt = new DataTable();
            //dt.Columns.Add("Timestamp");
            //dt.Columns.Add("Status");
            //dt.Columns.Add("Name");
            //dt.Columns.Add("Email");
            //dt.Columns.Add("Jenis Peserta");
            //dt.Columns.Add("Asal Negara");
            //dt.Columns.Add("University");
            //dt.Columns.Add("Paket");
            //foreach (Peserta p in pesertalist)
            //{
            //    DataRow row = dt.NewRow();
            //    row["Timestamp"] = ad.getPesertaTimestamp(sessionID, p.pesertaID);
            //    row["Status"] = ad.getPesertaCheckinStatus(sessionID, p.pesertaID);
            //    row["Name"] = p.nama;
            //    row["Email"] = p.email;
            //    row["Jenis Peserta"] = p.jenisPeserta;
            //    row["Asal Negara"] = p.asalNegara;
            //    row["University"] = p.university;
            //    row["Paket"] = p.paket;
            //    dt.Rows.Add(row);                                                
            //}
            dataGridView1.ColumnHeadersVisible = false;
            //DataView dv = new DataView(dataPes);
            dataGridView1.DataSource = dataPes;
            dataGridView1.ColumnHeadersVisible = true;
            //int n = dataGridView1.RowCount;
            //for (int i = 0; i < n; i++)
            //{                                
            //    dataGridView1.Rows[i].Cells[1].Style.ForeColor = System.Drawing.Color.White;
            //    if (dataGridView1.Rows[i].Cells[1].Value.ToString() == "Checkedin")
            //    {
            //        dataGridView1.Rows[i].Cells[1].Style.BackColor = System.Drawing.Color.Green;
            //    }
            //    else { dataGridView1.Rows[i].Cells[1].Style.BackColor = System.Drawing.Color.Navy; }
            //}

            //backup
            //foreach (Peserta p in pesertalist)
            //{
            //    String status = ad.getPesertaCheckinStatus(sessionID, p.pesertaID);
            //    Console.WriteLine(status + "" + p.pesertaID + "" + p.nama);
            //    Console.WriteLine(sessionID);
            //    dataGridView1.Rows.Add(ad.getPesertaTimestamp(sessionID, p.pesertaID), status, p.nama, p.email, p.jenisPeserta, p.asalNegara, p.university, p.paket);
            //    int n = dataGridView1.RowCount;
            //    n -= 1;
            //    dataGridView1.Rows[n].Cells[1].Style.ForeColor = System.Drawing.Color.White;
            //    if (status == "Checkedin")
            //    {
            //        dataGridView1.Rows[n].Cells[1].Style.BackColor = System.Drawing.Color.Green;
            //    }
            //    else { dataGridView1.Rows[n].Cells[1].Style.BackColor = System.Drawing.Color.Navy; }
            //}
            foreach (DataGridViewColumn item in dataGridView1.Columns)
            {
                item.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            
            int n = dataGridView1.RowCount;
            int ex = 0;
            for (int i = 0; i < n; i++)
            {
                dataGridView1.Rows[i].Cells[1].Style.ForeColor = System.Drawing.Color.White;
                if (dataGridView1.Rows[i].Cells[1].Value.ToString() == "Expected")
                {
                    ex += 1;
                    dataGridView1.Rows[i].Cells[1].Style.BackColor = System.Drawing.Color.Navy;
                }
                else { dataGridView1.Rows[i].Cells[1].Style.BackColor = System.Drawing.Color.Green; }

            }
            int checkedin = n - ex;
            lblStatusCount.Text = checkedin.ToString() + "/" + n.ToString() + " have checked in.";
            pictureBoxLoading.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                mode = "load";
                if (!backgroundWorker1.IsBusy)
                {
                    pictureBoxLoading.Visible = true;
                    backgroundWorker1.RunWorkerAsync();
                }
            }
            //pictureBoxLoading.Visible = true;
            //if (txtSearch.Text != "")
            //{
            //    mode = "search";
            //    if (!backgroundWorker1.IsBusy)
            //        backgroundWorker1.RunWorkerAsync();
            //}
            //else
            //{
            //    mode = "load";
            //    if (!backgroundWorker1.IsBusy)
            //        backgroundWorker1.RunWorkerAsync();
            //}
            //search();
            //(dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nama LIKE '%{0}%'", txtSearch.Text);
        }

        private void search()
        {
            if (txtSearch.Text != "")
            {
                pesertalist = ad.SearchPesertaCheckin(sessionID, txtSearch.Text);
                if (dataGridView1.RowCount > 0) { dataGridView1.Rows.Clear(); }
                foreach (Peserta p in pesertalist)
                {
                    String status = ad.getPesertaCheckinStatus(sessionID, p.pesertaID);
                    Console.WriteLine(status + "" + p.pesertaID + "" + p.nama);
                    Console.WriteLine(sessionID);
                    dataGridView1.Rows.Add(ad.getPesertaTimestamp(sessionID, p.pesertaID), status, p.nama, p.email, p.jenisPeserta, p.asalNegara, p.university, p.paket);
                    int n = dataGridView1.RowCount;
                    n -= 1;
                    dataGridView1.Rows[n].Cells[1].Style.ForeColor = System.Drawing.Color.White;
                    if (status == "Checkedin")
                    {
                        dataGridView1.Rows[n].Cells[1].Style.BackColor = System.Drawing.Color.Green;
                    }
                    else { dataGridView1.Rows[n].Cells[1].Style.BackColor = System.Drawing.Color.Navy; }
                }
            }
            else
            {
                mode = "load";
                if (!backgroundWorker1.IsBusy)
                {
                    pictureBoxLoading.Visible = true;
                    backgroundWorker1.RunWorkerAsync();
                }
                    
            }
            
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pictureBoxLoading.Visible = true;
                if (txtSearch.Text != "")
                {
                    mode = "search";
                    if (!backgroundWorker1.IsBusy)
                        backgroundWorker1.RunWorkerAsync();
                }
                else
                {
                    mode = "load";
                    if (!backgroundWorker1.IsBusy)
                        backgroundWorker1.RunWorkerAsync();
                }
                //search();
            }
            
        }

        private void checkBoxExpected_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxExpected.Checked == false)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value.ToString() == "Expected")
                    {
                        CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                        currencyManager1.SuspendBinding();
                        dataGridView1.Rows[i].Visible = false;
                        currencyManager1.ResumeBinding();
                    }
                }
            }
            else
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value.ToString() == "Expected")
                    {
                        dataGridView1.Rows[i].Visible = true;
                    }
                }
            }
        }

        private void checkBoxCheckedin_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCheckedin.Checked == false)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value.ToString() == "Checkedin")
                    {
                        dataGridView1.Rows[i].Visible = false;
                    }
                }
            }
            else
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value.ToString() == "Checkedin")
                    {
                        dataGridView1.Rows[i].Visible = true;
                    }
                }
            }
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            try
            {
                Peserta pr = new Peserta();
                pr.pesertaID = ad.getIDpesByEmail(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
                foreach (Session item in ad.getSession())
                {
                    if (item.name == comboSession.SelectedItem.ToString())
                    {
                        pr.checkin(pr, item); break;
                    }
                }
                MessageBox.Show("Success!");
                dataGridView1.SelectedRows[0].Cells[0].Value = DateTime.Now.ToString("HH:mm:ss");
                dataGridView1.SelectedRows[0].Cells[1].Value = "Checkedin";
                dataGridView1.SelectedRows[0].Cells[1].Style.BackColor = System.Drawing.Color.Green;
                dataGridView1.SelectedRows[0].Cells[1].Style.ForeColor = System.Drawing.Color.White;
            }
            catch (Exception ex)
            {

                MessageBox.Show("[ERROR] "+ ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin f = new FormLogin();
            f.Show();
        }

        //Internet inter = new Internet();        

        private void timer1_Tick(object sender, EventArgs e)
        {
            Internet intern = new Internet();
            bool active = intern.isConnected;
            if (active == false)
            {
                timer1.Stop();
                MessageBox.Show("Not connected to internet.");
                Application.Exit();
            }
            Console.WriteLine(active);
        }

        public void InitTimer()
        {
            //timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 2000; // in miliseconds
            timer1.Start();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Session item in ad.getSession())
                {
                    if (item.name == comboSession.SelectedItem.ToString())
                    {
                        sessionID = item.sessionID;
                        lblTanggalSessi.Text = item.date.ToShortDateString();
                        break;
                    }
                }
                //changeSession();
                mode = "load";
                pictureBoxLoading.Visible = true;
                if (!backgroundWorker1.IsBusy)
                    backgroundWorker1.RunWorkerAsync();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
