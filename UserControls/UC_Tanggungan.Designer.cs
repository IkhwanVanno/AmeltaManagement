namespace AmeltaManagement.UserControls
{
    partial class UC_Tanggungan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Tanggungan));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tbCari = new System.Windows.Forms.TextBox();
            this.labelCari = new System.Windows.Forms.Label();
            this.labelJudul = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelId = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.labelNPegawai = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNamaTanggungan = new System.Windows.Forms.Label();
            this.tbNTanggungan = new System.Windows.Forms.TextBox();
            this.cbNPegawai = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.cbHubungan = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.Location = new System.Drawing.Point(589, 62);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(20, 22);
            this.btnRefresh.TabIndex = 24;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tbCari
            // 
            this.tbCari.Location = new System.Drawing.Point(68, 62);
            this.tbCari.Name = "tbCari";
            this.tbCari.Size = new System.Drawing.Size(169, 20);
            this.tbCari.TabIndex = 23;
            this.tbCari.TextChanged += new System.EventHandler(this.tbCari_TextChanged);
            // 
            // labelCari
            // 
            this.labelCari.AutoSize = true;
            this.labelCari.Location = new System.Drawing.Point(31, 69);
            this.labelCari.Name = "labelCari";
            this.labelCari.Size = new System.Drawing.Size(31, 13);
            this.labelCari.TabIndex = 22;
            this.labelCari.Text = "Cari :";
            // 
            // labelJudul
            // 
            this.labelJudul.AutoSize = true;
            this.labelJudul.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.Location = new System.Drawing.Point(30, 21);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(169, 21);
            this.labelJudul.TabIndex = 21;
            this.labelJudul.Text = "DATA TANGGUNGAN";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(575, 150);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.69565F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.21739F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.labelId, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbId, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelNPegawai, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelNamaTanggungan, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbNTanggungan, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbNPegawai, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbHubungan, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(34, 265);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(575, 73);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelId.Location = new System.Drawing.Point(290, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(51, 26);
            this.labelId.TabIndex = 10;
            this.labelId.Text = "ID :";
            this.labelId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelId.Visible = false;
            // 
            // tbId
            // 
            this.tbId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbId.Location = new System.Drawing.Point(347, 3);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(225, 20);
            this.tbId.TabIndex = 11;
            this.tbId.Visible = false;
            // 
            // labelNPegawai
            // 
            this.labelNPegawai.AutoSize = true;
            this.labelNPegawai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNPegawai.Location = new System.Drawing.Point(3, 52);
            this.labelNPegawai.Name = "labelNPegawai";
            this.labelNPegawai.Size = new System.Drawing.Size(113, 21);
            this.labelNPegawai.TabIndex = 8;
            this.labelNPegawai.Text = "Nama Pegawai :";
            this.labelNPegawai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hubungan :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNamaTanggungan
            // 
            this.labelNamaTanggungan.AutoSize = true;
            this.labelNamaTanggungan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNamaTanggungan.Location = new System.Drawing.Point(3, 0);
            this.labelNamaTanggungan.Name = "labelNamaTanggungan";
            this.labelNamaTanggungan.Size = new System.Drawing.Size(113, 26);
            this.labelNamaTanggungan.TabIndex = 0;
            this.labelNamaTanggungan.Text = "Nama Tanggungan :";
            this.labelNamaTanggungan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbNTanggungan
            // 
            this.tbNTanggungan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbNTanggungan.Location = new System.Drawing.Point(122, 3);
            this.tbNTanggungan.Name = "tbNTanggungan";
            this.tbNTanggungan.Size = new System.Drawing.Size(162, 20);
            this.tbNTanggungan.TabIndex = 1;
            // 
            // cbNPegawai
            // 
            this.cbNPegawai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbNPegawai.FormattingEnabled = true;
            this.cbNPegawai.Location = new System.Drawing.Point(122, 55);
            this.cbNPegawai.Name = "cbNPegawai";
            this.cbNPegawai.Size = new System.Drawing.Size(162, 21);
            this.cbNPegawai.TabIndex = 9;
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(34, 346);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(575, 29);
            this.tableLayoutPanel2.TabIndex = 27;
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
            // cbHubungan
            // 
            this.cbHubungan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbHubungan.FormattingEnabled = true;
            this.cbHubungan.Location = new System.Drawing.Point(122, 29);
            this.cbHubungan.Name = "cbHubungan";
            this.cbHubungan.Size = new System.Drawing.Size(162, 21);
            this.cbHubungan.TabIndex = 12;
            // 
            // UC_Tanggungan
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
            this.Name = "UC_Tanggungan";
            this.Size = new System.Drawing.Size(638, 405);
            this.Load += new System.EventHandler(this.UC_Tanggungan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox tbCari;
        private System.Windows.Forms.Label labelCari;
        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelNamaTanggungan;
        private System.Windows.Forms.Label labelNPegawai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNTanggungan;
        private System.Windows.Forms.ComboBox cbNPegawai;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.ComboBox cbHubungan;
    }
}
