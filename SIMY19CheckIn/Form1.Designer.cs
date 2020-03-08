namespace SIMY19CheckIn
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.btnSession = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblTanggalSessi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.checkBoxCheckedin = new System.Windows.Forms.CheckBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.checkBoxExpected = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.comboSession = new System.Windows.Forms.ComboBox();
            this.btnCheckin = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pesertaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sImy19DataSet2 = new SIMY19CheckIn.SImy19DataSet2();
            this.panel9 = new System.Windows.Forms.Panel();
            this.sImy19DataSet = new SIMY19CheckIn.SImy19DataSet();
            this.pesertaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pesertaTableAdapter = new SIMY19CheckIn.SImy19DataSetTableAdapters.PesertaTableAdapter();
            this.pesertaTableAdapter1 = new SIMY19CheckIn.SImy19DataSet2TableAdapters.PesertaTableAdapter();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxLoading = new System.Windows.Forms.PictureBox();
            this.lblStatusCount = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesertaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sImy19DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sImy19DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesertaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1003, 78);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SIMY19CheckIn.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(22, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(254, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.btnSession);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(63, 570);
            this.panel2.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(0, 147);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(63, 48);
            this.button4.TabIndex = 6;
            this.button4.Text = "Client Server";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnSession
            // 
            this.btnSession.FlatAppearance.BorderSize = 0;
            this.btnSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSession.Location = new System.Drawing.Point(0, 93);
            this.btnSession.Name = "btnSession";
            this.btnSession.Size = new System.Drawing.Size(63, 48);
            this.btnSession.TabIndex = 6;
            this.btnSession.Text = "Session";
            this.btnSession.UseVisualStyleBackColor = true;
            this.btnSession.Click += new System.EventHandler(this.btnSession_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(0, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 48);
            this.button2.TabIndex = 5;
            this.button2.Text = "Data Peserta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.BackgroundImage = global::SIMY19CheckIn.Properties.Resources.logout;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(9, 520);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 35);
            this.btnExit.TabIndex = 4;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblStatusCount);
            this.panel3.Controls.Add(this.btnRefresh);
            this.panel3.Controls.Add(this.lblTanggalSessi);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.checkBoxCheckedin);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.checkBoxExpected);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.comboSession);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(63, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(940, 110);
            this.panel3.TabIndex = 4;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BackgroundImage = global::SIMY19CheckIn.Properties.Resources.reload;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefresh.Location = new System.Drawing.Point(548, 76);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(31, 26);
            this.btnRefresh.TabIndex = 167;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblTanggalSessi
            // 
            this.lblTanggalSessi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTanggalSessi.AutoSize = true;
            this.lblTanggalSessi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTanggalSessi.Location = new System.Drawing.Point(699, 82);
            this.lblTanggalSessi.Name = "lblTanggalSessi";
            this.lblTanggalSessi.Size = new System.Drawing.Size(51, 16);
            this.lblTanggalSessi.TabIndex = 168;
            this.lblTanggalSessi.Text = "12/2/19";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(603, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 167;
            this.label2.Text = "Tanggal sesi :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(603, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 16);
            this.label1.TabIndex = 166;
            this.label1.Text = "Showing peserta assigned for :";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel8.Location = new System.Drawing.Point(292, 68);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1, 42);
            this.panel8.TabIndex = 162;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Green;
            this.panel7.Location = new System.Drawing.Point(147, 68);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(145, 5);
            this.panel7.TabIndex = 164;
            // 
            // checkBoxCheckedin
            // 
            this.checkBoxCheckedin.AutoSize = true;
            this.checkBoxCheckedin.BackColor = System.Drawing.Color.White;
            this.checkBoxCheckedin.Checked = true;
            this.checkBoxCheckedin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCheckedin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCheckedin.Location = new System.Drawing.Point(173, 78);
            this.checkBoxCheckedin.Name = "checkBoxCheckedin";
            this.checkBoxCheckedin.Size = new System.Drawing.Size(100, 24);
            this.checkBoxCheckedin.TabIndex = 163;
            this.checkBoxCheckedin.Text = "checkedin";
            this.checkBoxCheckedin.UseVisualStyleBackColor = false;
            this.checkBoxCheckedin.CheckedChanged += new System.EventHandler(this.checkBoxCheckedin_CheckedChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel6.Location = new System.Drawing.Point(145, 68);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1, 42);
            this.panel6.TabIndex = 161;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Navy;
            this.panel5.Location = new System.Drawing.Point(0, 68);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(145, 5);
            this.panel5.TabIndex = 162;
            // 
            // checkBoxExpected
            // 
            this.checkBoxExpected.AutoSize = true;
            this.checkBoxExpected.BackColor = System.Drawing.Color.White;
            this.checkBoxExpected.Checked = true;
            this.checkBoxExpected.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxExpected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxExpected.Location = new System.Drawing.Point(27, 78);
            this.checkBoxExpected.Name = "checkBoxExpected";
            this.checkBoxExpected.Size = new System.Drawing.Size(93, 24);
            this.checkBoxExpected.TabIndex = 161;
            this.checkBoxExpected.Text = "expected";
            this.checkBoxExpected.UseVisualStyleBackColor = false;
            this.checkBoxExpected.CheckedChanged += new System.EventHandler(this.checkBoxExpected_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Location = new System.Drawing.Point(0, 68);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(950, 1);
            this.panel4.TabIndex = 160;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SIMY19CheckIn.Properties.Resources.magnifying_glass;
            this.pictureBox3.Location = new System.Drawing.Point(197, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 159;
            this.pictureBox3.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(24, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(171, 26);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // comboSession
            // 
            this.comboSession.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboSession.BackColor = System.Drawing.Color.White;
            this.comboSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSession.FormattingEnabled = true;
            this.comboSession.Location = new System.Drawing.Point(606, 34);
            this.comboSession.Name = "comboSession";
            this.comboSession.Size = new System.Drawing.Size(322, 28);
            this.comboSession.TabIndex = 2;
            this.comboSession.SelectedIndexChanged += new System.EventHandler(this.comboSession_SelectedIndexChanged);
            // 
            // btnCheckin
            // 
            this.btnCheckin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckin.BackColor = System.Drawing.Color.Green;
            this.btnCheckin.FlatAppearance.BorderSize = 0;
            this.btnCheckin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCheckin.Location = new System.Drawing.Point(866, 603);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Size = new System.Drawing.Size(115, 33);
            this.btnCheckin.TabIndex = 165;
            this.btnCheckin.Text = "Checkin";
            this.btnCheckin.UseVisualStyleBackColor = false;
            this.btnCheckin.Click += new System.EventHandler(this.btnCheckin_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(83, 195);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(898, 387);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.VirtualMode = true;
            // 
            // pesertaBindingSource1
            // 
            this.pesertaBindingSource1.DataMember = "Peserta";
            this.pesertaBindingSource1.DataSource = this.sImy19DataSet2;
            // 
            // sImy19DataSet2
            // 
            this.sImy19DataSet2.DataSetName = "SImy19DataSet2";
            this.sImy19DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel9.Location = new System.Drawing.Point(63, 596);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(950, 1);
            this.panel9.TabIndex = 161;
            // 
            // sImy19DataSet
            // 
            this.sImy19DataSet.DataSetName = "SImy19DataSet";
            this.sImy19DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pesertaBindingSource
            // 
            this.pesertaBindingSource.DataMember = "Peserta";
            this.pesertaBindingSource.DataSource = this.sImy19DataSet;
            // 
            // pesertaTableAdapter
            // 
            this.pesertaTableAdapter.ClearBeforeFill = true;
            // 
            // pesertaTableAdapter1
            // 
            this.pesertaTableAdapter1.ClearBeforeFill = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBoxLoading
            // 
            this.pictureBoxLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLoading.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBoxLoading.Image = global::SIMY19CheckIn.Properties.Resources.fancy_loading;
            this.pictureBoxLoading.Location = new System.Drawing.Point(130, 240);
            this.pictureBoxLoading.Name = "pictureBoxLoading";
            this.pictureBoxLoading.Size = new System.Drawing.Size(146, 139);
            this.pictureBoxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLoading.TabIndex = 166;
            this.pictureBoxLoading.TabStop = false;
            this.pictureBoxLoading.Visible = false;
            // 
            // lblStatusCount
            // 
            this.lblStatusCount.AutoSize = true;
            this.lblStatusCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusCount.Location = new System.Drawing.Point(312, 82);
            this.lblStatusCount.Name = "lblStatusCount";
            this.lblStatusCount.Size = new System.Drawing.Size(141, 16);
            this.lblStatusCount.TabIndex = 169;
            this.lblStatusCount.Text = "0/200 have checked in";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1003, 648);
            this.Controls.Add(this.pictureBoxLoading);
            this.Controls.Add(this.btnCheckin);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIMY";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesertaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sImy19DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sImy19DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesertaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboSession;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.CheckBox checkBoxCheckedin;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.CheckBox checkBoxExpected;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCheckin;
        private SImy19DataSet sImy19DataSet;
        private System.Windows.Forms.BindingSource pesertaBindingSource;
        private SImy19DataSetTableAdapters.PesertaTableAdapter pesertaTableAdapter;
        private SImy19DataSet2 sImy19DataSet2;
        private System.Windows.Forms.BindingSource pesertaBindingSource1;
        private SImy19DataSet2TableAdapters.PesertaTableAdapter pesertaTableAdapter1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnSession;
        private System.Windows.Forms.PictureBox pictureBoxLoading;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTanggalSessi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblStatusCount;
    }
}

