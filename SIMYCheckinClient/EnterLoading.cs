using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SIMY19CheckIn
{
    public partial class EnterLoading : Form
    {
        public bool connected = false;
        public EnterLoading()
        {
            InitializeComponent();
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Internet inter = new Internet();
            
            if (inter.isConnected == true)
            {
                backgroundWorker1.ReportProgress(11);
                Thread.Sleep(300);
                backgroundWorker1.ReportProgress(26);
                Thread.Sleep(100);
                Connection conn = new Connection();
                backgroundWorker1.ReportProgress(41);
                Thread.Sleep(200);
                try
                {
                    Thread.Sleep(100);
                    conn.getConnected.Open();
                    backgroundWorker1.ReportProgress(61);
                    if (conn.getConnected.State == ConnectionState.Open)
                    {
                        connected = true;
                        Thread.Sleep(200);
                        backgroundWorker1.ReportProgress(100);
                        conn.getConnected.Close();
                        Thread.Sleep(2000);
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
            
            
            
            
            
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(connected == true)
            {
                this.Close();
            }
            else { MessageBox.Show("Cannot connect to the database, check your internet connection."); Application.Exit(); }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            if (progressBar1.Value >= 10) { label1.Text = "Internet connection established.."; }
            if (progressBar1.Value >= 25) { label1.Text = "Connecting to database.."; }
            if (progressBar1.Value >= 40) { label1.Text = "Waiting for server.."; }
            if (progressBar1.Value >= 60) { label1.Text = "Establishing secure connection to server.."; }
            if (progressBar1.Value >= 90) { label1.Text = "Database server has been connected.."; }
        }
    }
}
