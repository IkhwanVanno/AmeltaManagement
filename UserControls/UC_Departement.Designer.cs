namespace AmeltaManagement.UserControls
{
    partial class UC_Departement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Departement));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tbCari = new System.Windows.Forms.TextBox();
            this.labelCari = new System.Windows.Forms.Label();
            this.labelJudul = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.labelJabatan = new System.Windows.Forms.Label();
            this.labelTglLahir = new System.Windows.Forms.Label();
            this.labelNamaPegawai = new System.Windows.Forms.Label();
            this.tbNDepartement = new System.Windows.Forms.TextBox();
            this.dtpTgl = new System.Windows.Forms.DateTimePicker();
            this.cbKDepartement = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.Location = new System.Drawing.Point(582, 57);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(20, 22);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tbCari
            // 
            this.tbCari.Location = new System.Drawing.Point(61, 57);
            this.tbCari.Name = "tbCari";
            this.tbCari.Size = new System.Drawing.Size(169, 20);
            this.tbCari.TabIndex = 7;
            this.tbCari.TextChanged += new System.EventHandler(this.tbCari_TextChanged);
            // 
            // labelCari
            // 
            this.labelCari.AutoSize = true;
            this.labelCari.Location = new System.Drawing.Point(24, 64);
            this.labelCari.Name = "labelCari";
            this.labelCari.Size = new System.Drawing.Size(31, 13);
            this.labelCari.TabIndex = 6;
            this.labelCari.Text = "Cari :";
            // 
            // labelJudul
            // 
            this.labelJudul.AutoSize = true;
            this.labelJudul.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.Location = new System.Drawing.Point(23, 16);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(170, 21);
            this.labelJudul.TabIndex = 5;
            this.labelJudul.Text = "DATA DEPARTEMENT";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(575, 150);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.btnSimpan, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnBatal, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(27, 322);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(575, 29);
            this.tableLayoutPanel2.TabIndex = 31;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSimpan.Location = new System.Drawing.Point(146, 3);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(137, 23);
            this.btnSimpan.TabIndex = 1;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBatal.Location = new System.Drawing.Point(3, 3);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(137, 23);
            this.btnBatal.TabIndex = 0;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.69565F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.21739F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.43478F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbId, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelJabatan, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelTglLahir, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelNamaPegawai, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbNDepartement, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpTgl, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbKDepartement, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(27, 241);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(575, 73);
            this.tableLayoutPanel1.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(288, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "ID :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Visible = false;
            // 
            // tbId
            // 
            this.tbId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbId.Location = new System.Drawing.Point(370, 55);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(202, 20);
            this.tbId.TabIndex = 15;
            this.tbId.Visible = false;
            // 
            // labelJabatan
            // 
            this.labelJabatan.AutoSize = true;
            this.labelJabatan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelJabatan.Location = new System.Drawing.Point(3, 52);
            this.labelJabatan.Name = "labelJabatan";
            this.labelJabatan.Size = new System.Drawing.Size(112, 21);
            this.labelJabatan.TabIndex = 8;
            this.labelJabatan.Text = "Tanggal :";
            this.labelJabatan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTglLahir
            // 
            this.labelTglLahir.AutoSize = true;
            this.labelTglLahir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTglLahir.Location = new System.Drawing.Point(3, 26);
            this.labelTglLahir.Name = "labelTglLahir";
            this.labelTglLahir.Size = new System.Drawing.Size(112, 26);
            this.labelTglLahir.TabIndex = 4;
            this.labelTglLahir.Text = "Kepala Departement :";
            this.labelTglLahir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNamaPegawai
            // 
            this.labelNamaPegawai.AutoSize = true;
            this.labelNamaPegawai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNamaPegawai.Location = new System.Drawing.Point(3, 0);
            this.labelNamaPegawai.Name = "labelNamaPegawai";
            this.labelNamaPegawai.Size = new System.Drawing.Size(112, 26);
            this.labelNamaPegawai.TabIndex = 0;
            this.labelNamaPegawai.Text = "Nama Departement :";
            this.labelNamaPegawai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbNDepartement
            // 
            this.tbNDepartement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbNDepartement.Location = new System.Drawing.Point(121, 3);
            this.tbNDepartement.Name = "tbNDepartement";
            this.tbNDepartement.Size = new System.Drawing.Size(161, 20);
            this.tbNDepartement.TabIndex = 1;
            // 
            // dtpTgl
            // 
            this.dtpTgl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpTgl.Location = new System.Drawing.Point(121, 55);
            this.dtpTgl.Name = "dtpTgl";
            this.dtpTgl.Size = new System.Drawing.Size(161, 20);
            this.dtpTgl.TabIndex = 19;
            // 
            // cbKDepartement
            // 
            this.cbKDepartement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbKDepartement.FormattingEnabled = true;
            this.cbKDepartement.Location = new System.Drawing.Point(121, 29);
            this.cbKDepartement.Name = "cbKDepartement";
            this.cbKDepartement.Size = new System.Drawing.Size(161, 21);
            this.cbKDepartement.TabIndex = 20;
            // 
            // UC_Departement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.tbCari);
            this.Controls.Add(this.labelCari);
            this.Controls.Add(this.labelJudul);
            this.Name = "UC_Departement";
            this.Size = new System.Drawing.Size(638, 405);
            this.Load += new System.EventHandler(this.UC_Departement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox tbCari;
        private System.Windows.Forms.Label labelCari;
        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label labelJabatan;
        private System.Windows.Forms.Label labelTglLahir;
        private System.Windows.Forms.Label labelNamaPegawai;
        private System.Windows.Forms.TextBox tbNDepartement;
        private System.Windows.Forms.DateTimePicker dtpTgl;
        private System.Windows.Forms.ComboBox cbKDepartement;
    }
}
