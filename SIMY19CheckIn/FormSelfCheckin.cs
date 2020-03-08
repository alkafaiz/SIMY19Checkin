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
    public partial class FormSelfCheckin : Form
    {
        Session ses;
        ClientInstance clientin;
        Admin ad = new Admin();
        public FormSelfCheckin()
        {
            InitializeComponent();
        }

        public FormSelfCheckin(Session ss, ClientInstance client)
        {
            InitializeComponent();
            ses = ss;
            clientin = client;
            label1.Text = ses.name;
            this.SetStyle(
                System.Windows.Forms.ControlStyles.UserPaint |
                System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
                System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer,
                true);
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
        private void enteremail()
        {
            if (txtEmail.Text == "Enter your email here")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void checkEmailexist()
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Enter your email here";
                txtEmail.ForeColor = Color.Gray;
                label2.Focus();
            }
        }

        private void FormSelfCheckin_Load(object sender, EventArgs e)
        {
            label2.Focus();
            this.KeyPreview = true;
            InitTimer();
            InitTime();
            lblTime.Text = DateTime.Now.ToShortDateString();
            lblDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }

        private void lblplc_Click(object sender, EventArgs e)
        {
            enteremail();
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            enteremail();
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            checkEmailexist();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            checkEmailexist();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            checkEmailexist();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hidecontrol()
        {
            pictureBox1.Visible = false;
            lblDate.Visible = false;
            panel2.Visible = false;
            lblTime.Visible = false;
            label1.Visible = false;
            label3.Visible = false;
            panel3.Visible = false;
        }

        private void showcontrol()
        {
            pictureBox1.Visible = true;
            lblDate.Visible = true;
            panel2.Visible = true;
            lblTime.Visible = true;
            label1.Visible = true;
            label3.Visible = true;
            panel3.Visible = true;
            
        }


        Loading loadin = new Loading();
        private void btnCheckin_Click(object sender, EventArgs e)
        {
            try
            {
                Currentemail = txtEmail.Text;
                picLoading.Visible = true;
                btnCheckin.Enabled = false;
                txtEmail.Enabled = false;
                backgroundWorker1.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            


            //picload.Visible = false;

            //this works
            //checkin();
        }



        private void FormSelfCheckin_KeyDown(object sender, KeyEventArgs e)
        {           
            if (e.Control ==true && e.KeyCode == Keys.E)
            {
                FormExitClient f = new FormExitClient(clientin);
                f.ShowDialog();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool active = ad.isClientActive(clientin.ClientKey);
            if (active == false)
            {
                timer1.Stop();
                MessageBox.Show("This client server is no longer active.");
                Application.Exit();
            }
            Internet intern = new Internet();
            bool activein = intern.isConnected;
            if (activein == false)
            {
                timer1.Stop();
                MessageBox.Show("Not connected to internet.");
                Application.Exit();
            }
        }

        public void InitTimer()
        {
            //timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 10000; // in miliseconds
            timer1.Start();
        }

        public void InitTime()
        {
            //timer1 = new Timer();
            timer2.Tick += new EventHandler(timer2_Tick);
            timer2.Interval = 1000; // in miliseconds
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString(); 
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //loadin.Show();
            currentPes= checkin2();
            //loadin.Close();
        }

        int attemp = 0;
        private void checkin()
        {
            bool auth = ad.Checkin(txtEmail.Text, ses.sessionID);
            if (auth == true)
            {
                Peserta p = ad.getPeserta(ad.getPesertaID(txtEmail.Text));
                //MessageBox.Show("Welcome " + p.nama + " !");
                hidecontrol();
                FormParticipantCheckin s = new FormParticipantCheckin(p,ses);
                s.ShowDialog();
                if (s.DialogResult == DialogResult.OK)
                {
                    showcontrol();
                    txtEmail.Text = "Enter your email here";
                    txtEmail.ForeColor = Color.Gray;
                    label2.Focus();
                }
                
            }
            else
            {
                if(ad.CheckStatusCheckin(txtEmail.Text, ses.sessionID) == "Checkedin") { MessageBox.Show("You have done the check-in. Thank you."); }
                else
                {
                    attemp += 1;
                    if (attemp >= 3)
                    {
                        MessageBox.Show("There must be a mistake, please refer to our officers.");
                    }
                    else
                    {
                        MessageBox.Show("Sorry, you entered wrong email. Please try again.");
                    }
                }
                
                
            }
        }

        String Currentemail = "";
        bool authorizedPeserta = false;
        Peserta currentPes;

        private Peserta checkin2()
        {
            bool auth = ad.Checkin(Currentemail, ses.sessionID);
            if (auth == true)
            {
                authorizedPeserta = true;
                Peserta p = ad.getPeserta(ad.getPesertaID(Currentemail));
                return p;
            }
            else
            {
                authorizedPeserta = false;
                return null;
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            picLoading.Visible = false;
            btnCheckin.Enabled = true;
            txtEmail.Enabled = true;
            if (authorizedPeserta == true)
            {                
                hidecontrol();
                FormParticipantCheckin s = new FormParticipantCheckin(currentPes, ses);
                s.ShowDialog();
                if (s.DialogResult == DialogResult.OK)
                {
                    showcontrol();
                    txtEmail.Text = "Enter your email here";
                    txtEmail.ForeColor = Color.Gray;
                    label2.Focus();
                }
            }
            else
            {
                if (ad.CheckStatusCheckin(Currentemail, ses.sessionID) == "Checkedin") {
                    MessageBox.Show("You have done the check-in. Thank you.");
                    txtEmail.Text = "Enter your email here";
                    txtEmail.ForeColor = Color.Gray;
                    label2.Focus();
                }
                else
                {
                    attemp += 1;
                    if (attemp >= 3)
                    {
                        MessageBox.Show("There must be a mistake, please refer to our officers.");
                        txtEmail.Text = "Enter your email here";
                        txtEmail.ForeColor = Color.Gray;
                        label2.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Sorry, you entered wrong email. Please try again.");
                        txtEmail.Text = "Enter your email here";
                        txtEmail.ForeColor = Color.Gray;
                        label2.Focus();
                    }
                }
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    Currentemail = txtEmail.Text;
                    picLoading.Visible = true;
                    btnCheckin.Enabled = false;
                    txtEmail.Enabled = false;
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
}
