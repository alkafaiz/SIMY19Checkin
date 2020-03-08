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
    public partial class FormParticipantCheckin : Form
    {
        Peserta pr;
        Session ses;
        public FormParticipantCheckin()
        {
            InitializeComponent();
        }
        public FormParticipantCheckin(Peserta per, Session ss)
        {
            InitializeComponent();
            pr = per;
            ses = ss;
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
        private void FormParticipantCheckin_Load(object sender, EventArgs e)
        {
            lblNama.Text = pr.nama;
            lblJenisPes.Text = pr.jenisPeserta;
            lblAsalNegara.Text = pr.asalNegara;
            lblUniv.Text = pr.university;
            lblSessionName.Text = ses.name;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
            pictureBox1.Visible = true;
            btnConfirm.Enabled = false;
        }

        bool success = false;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //continue from here, reconfigure the datetime into database, create welcome page after successful checkin, create checkin via admin panel, do searching function, try catch all button event
            //if condition database connection open to all functions, runtime checking internet and db connection to both panels, edit UI with sponsor, release, testing.
            try
            {
                pr.checkin(pr, ses);
                success = true;
                
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pictureBox1.Visible = false;
            btnConfirm.Enabled = true;
            if (success == true)
            {
                MessageBox.Show("You have successfully checkedin. Thank you.");
                this.DialogResult = DialogResult.OK;
                this.Close();
                
            }
            else
            {
                MessageBox.Show("An error occured, please refer to our officers.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
