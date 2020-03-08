namespace SIMY19CheckIn
{
    partial class FormAssignPeserta
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pesertaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisPesertaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asalNegaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.universityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesertaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sImy19DataSet3 = new SIMY19CheckIn.SImy19DataSet3();
            this.sImy19DataSet = new SIMY19CheckIn.SImy19DataSet();
            this.pesertaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pesertaTableAdapter = new SIMY19CheckIn.SImy19DataSetTableAdapters.PesertaTableAdapter();
            this.sImy19DataSet2 = new SIMY19CheckIn.SImy19DataSet2();
            this.pesertaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pesertaTableAdapter1 = new SIMY19CheckIn.SImy19DataSet2TableAdapters.PesertaTableAdapter();
            this.checkBoxAll = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSession = new System.Windows.Forms.Label();
            this.lblSesiID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pesertaTableAdapter2 = new SIMY19CheckIn.SImy19DataSet3TableAdapters.PesertaTableAdapter();
            this.btnAssign = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesertaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sImy19DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sImy19DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesertaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sImy19DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesertaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pesertaIdDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.jenisPesertaDataGridViewTextBoxColumn,
            this.asalNegaraDataGridViewTextBoxColumn,
            this.universityDataGridViewTextBoxColumn,
            this.paketDataGridViewTextBoxColumn,
            this.panel1DataGridViewTextBoxColumn,
            this.panel2DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pesertaBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(885, 247);
            this.dataGridView1.TabIndex = 6;
            // 
            // pesertaIdDataGridViewTextBoxColumn
            // 
            this.pesertaIdDataGridViewTextBoxColumn.DataPropertyName = "pesertaId";
            this.pesertaIdDataGridViewTextBoxColumn.HeaderText = "pesertaId";
            this.pesertaIdDataGridViewTextBoxColumn.Name = "pesertaIdDataGridViewTextBoxColumn";
            this.pesertaIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "nama";
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            this.namaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jenisPesertaDataGridViewTextBoxColumn
            // 
            this.jenisPesertaDataGridViewTextBoxColumn.DataPropertyName = "jenisPeserta";
            this.jenisPesertaDataGridViewTextBoxColumn.HeaderText = "jenisPeserta";
            this.jenisPesertaDataGridViewTextBoxColumn.Name = "jenisPesertaDataGridViewTextBoxColumn";
            this.jenisPesertaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // asalNegaraDataGridViewTextBoxColumn
            // 
            this.asalNegaraDataGridViewTextBoxColumn.DataPropertyName = "asalNegara";
            this.asalNegaraDataGridViewTextBoxColumn.HeaderText = "asalNegara";
            this.asalNegaraDataGridViewTextBoxColumn.Name = "asalNegaraDataGridViewTextBoxColumn";
            this.asalNegaraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // universityDataGridViewTextBoxColumn
            // 
            this.universityDataGridViewTextBoxColumn.DataPropertyName = "university";
            this.universityDataGridViewTextBoxColumn.HeaderText = "university";
            this.universityDataGridViewTextBoxColumn.Name = "universityDataGridViewTextBoxColumn";
            this.universityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paketDataGridViewTextBoxColumn
            // 
            this.paketDataGridViewTextBoxColumn.DataPropertyName = "paket";
            this.paketDataGridViewTextBoxColumn.HeaderText = "paket";
            this.paketDataGridViewTextBoxColumn.Name = "paketDataGridViewTextBoxColumn";
            this.paketDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // panel1DataGridViewTextBoxColumn
            // 
            this.panel1DataGridViewTextBoxColumn.DataPropertyName = "panel1";
            this.panel1DataGridViewTextBoxColumn.HeaderText = "panel1";
            this.panel1DataGridViewTextBoxColumn.Name = "panel1DataGridViewTextBoxColumn";
            this.panel1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // panel2DataGridViewTextBoxColumn
            // 
            this.panel2DataGridViewTextBoxColumn.DataPropertyName = "panel2";
            this.panel2DataGridViewTextBoxColumn.HeaderText = "panel2";
            this.panel2DataGridViewTextBoxColumn.Name = "panel2DataGridViewTextBoxColumn";
            this.panel2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pesertaBindingSource2
            // 
            this.pesertaBindingSource2.DataMember = "Peserta";
            this.pesertaBindingSource2.DataSource = this.sImy19DataSet3;
            // 
            // sImy19DataSet3
            // 
            this.sImy19DataSet3.DataSetName = "SImy19DataSet3";
            this.sImy19DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // sImy19DataSet2
            // 
            this.sImy19DataSet2.DataSetName = "SImy19DataSet2";
            this.sImy19DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pesertaBindingSource1
            // 
            this.pesertaBindingSource1.DataMember = "Peserta";
            this.pesertaBindingSource1.DataSource = this.sImy19DataSet2;
            // 
            // pesertaTableAdapter1
            // 
            this.pesertaTableAdapter1.ClearBeforeFill = true;
            // 
            // checkBoxAll
            // 
            this.checkBoxAll.AutoSize = true;
            this.checkBoxAll.Location = new System.Drawing.Point(12, 87);
            this.checkBoxAll.Name = "checkBoxAll";
            this.checkBoxAll.Size = new System.Drawing.Size(67, 17);
            this.checkBoxAll.TabIndex = 7;
            this.checkBoxAll.Text = "select all";
            this.checkBoxAll.UseVisualStyleBackColor = true;
            this.checkBoxAll.CheckedChanged += new System.EventHandler(this.checkBoxAll_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Assign peserta pada sesi :";
            // 
            // lblSession
            // 
            this.lblSession.AutoSize = true;
            this.lblSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSession.Location = new System.Drawing.Point(191, 11);
            this.lblSession.Name = "lblSession";
            this.lblSession.Size = new System.Drawing.Size(45, 18);
            this.lblSession.TabIndex = 9;
            this.lblSession.Text = "Sessi";
            // 
            // lblSesiID
            // 
            this.lblSesiID.AutoSize = true;
            this.lblSesiID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSesiID.Location = new System.Drawing.Point(94, 29);
            this.lblSesiID.Name = "lblSesiID";
            this.lblSesiID.Size = new System.Drawing.Size(42, 16);
            this.lblSesiID.TabIndex = 11;
            this.lblSesiID.Text = "Sessi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Session ID :";
            // 
            // comboFilter
            // 
            this.comboFilter.BackColor = System.Drawing.Color.White;
            this.comboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFilter.Enabled = false;
            this.comboFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFilter.FormattingEnabled = true;
            this.comboFilter.Items.AddRange(new object[] {
            "All",
            "Panel A",
            "Panel B",
            "Panel C",
            "Panel D"});
            this.comboFilter.Location = new System.Drawing.Point(755, 55);
            this.comboFilter.Name = "comboFilter";
            this.comboFilter.Size = new System.Drawing.Size(142, 26);
            this.comboFilter.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(701, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Filter :";
            // 
            // pesertaTableAdapter2
            // 
            this.pesertaTableAdapter2.ClearBeforeFill = true;
            // 
            // btnAssign
            // 
            this.btnAssign.BackColor = System.Drawing.Color.Green;
            this.btnAssign.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnAssign.FlatAppearance.BorderSize = 0;
            this.btnAssign.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnAssign.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssign.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAssign.Location = new System.Drawing.Point(12, 363);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(131, 32);
            this.btnAssign.TabIndex = 14;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = false;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SIMY19CheckIn.Properties.Resources.magnifying_glass;
            this.pictureBox3.Location = new System.Drawing.Point(185, 55);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 161;
            this.pictureBox3.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Enabled = false;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(12, 55);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(171, 26);
            this.txtSearch.TabIndex = 160;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // FormAssignPeserta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(909, 437);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboFilter);
            this.Controls.Add(this.lblSesiID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSession);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxAll);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAssignPeserta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assign Peserta";
            this.Load += new System.EventHandler(this.FormAssignPeserta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesertaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sImy19DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sImy19DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesertaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sImy19DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesertaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SImy19DataSet sImy19DataSet;
        private System.Windows.Forms.BindingSource pesertaBindingSource;
        private SImy19DataSetTableAdapters.PesertaTableAdapter pesertaTableAdapter;
        private SImy19DataSet2 sImy19DataSet2;
        private System.Windows.Forms.BindingSource pesertaBindingSource1;
        private SImy19DataSet2TableAdapters.PesertaTableAdapter pesertaTableAdapter1;
        private System.Windows.Forms.CheckBox checkBoxAll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSession;
        private System.Windows.Forms.Label lblSesiID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboFilter;
        private System.Windows.Forms.Label label1;
        private SImy19DataSet3 sImy19DataSet3;
        private System.Windows.Forms.BindingSource pesertaBindingSource2;
        private SImy19DataSet3TableAdapters.PesertaTableAdapter pesertaTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesertaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisPesertaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asalNegaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn universityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn panel1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn panel2DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtSearch;
    }
}