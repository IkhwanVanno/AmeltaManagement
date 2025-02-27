namespace AmeltaManagement.UserControls
{
    partial class UC_Proyek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Proyek));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tbCari = new System.Windows.Forms.TextBox();
            this.labelCari = new System.Windows.Forms.Label();
            this.labelJudul = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTglLahir = new System.Windows.Forms.Label();
            this.labelNamaPegawai = new System.Windows.Forms.Label();
            this.tbNProyek = new System.Windows.Forms.TextBox();
            this.cbNDepartement = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.Location = new System.Drawing.Point(589, 62);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(20, 22);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tbCari
            // 
            this.tbCari.Location = new System.Drawing.Point(68, 62);
            this.tbCari.Name = "tbCari";
            this.tbCari.Size = new System.Drawing.Size(169, 20);
            this.tbCari.TabIndex = 11;
            this.tbCari.TextChanged += new System.EventHandler(this.tbCari_TextChanged);
            // 
            // labelCari
            // 
            this.labelCari.AutoSize = true;
            this.labelCari.Location = new System.Drawing.Point(31, 69);
            this.labelCari.Name = "labelCari";
            this.labelCari.Size = new System.Drawing.Size(31, 13);
            this.labelCari.TabIndex = 10;
            this.labelCari.Text = "Cari :";
            // 
            // labelJudul
            // 
            this.labelJudul.AutoSize = true;
            this.labelJudul.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.Location = new System.Drawing.Point(30, 21);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(116, 21);
            this.labelJudul.TabIndex = 9;
            this.labelJudul.Text = "DATA PROYEK";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(575, 150);
            this.dataGridView1.TabIndex = 13;
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(34, 314);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(575, 29);
            this.tableLayoutPanel2.TabIndex = 33;
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
            this.tableLayoutPanel1.Controls.Add(this.tbId, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelTglLahir, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelNamaPegawai, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbNProyek, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbNDepartement, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(34, 256);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(575, 52);
            this.tableLayoutPanel1.TabIndex = 32;
            // 
            // tbId
            // 
            this.tbId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbId.Location = new System.Drawing.Point(370, 3);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(202, 20);
            this.tbId.TabIndex = 22;
            this.tbId.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(288, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 26);
            this.label4.TabIndex = 21;
            this.label4.Text = "ID :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Visible = false;
            // 
            // labelTglLahir
            // 
            this.labelTglLahir.AutoSize = true;
            this.labelTglLahir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTglLahir.Location = new System.Drawing.Point(3, 26);
            this.labelTglLahir.Name = "labelTglLahir";
            this.labelTglLahir.Size = new System.Drawing.Size(112, 26);
            this.labelTglLahir.TabIndex = 4;
            this.labelTglLahir.Text = "Nama Departement :";
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
            this.labelNamaPegawai.Text = "Nama Proyek :";
            this.labelNamaPegawai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbNProyek
            // 
            this.tbNProyek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbNProyek.Location = new System.Drawing.Point(121, 3);
            this.tbNProyek.Name = "tbNProyek";
            this.tbNProyek.Size = new System.Drawing.Size(161, 20);
            this.tbNProyek.TabIndex = 1;
            // 
            // cbNDepartement
            // 
            this.cbNDepartement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbNDepartement.FormattingEnabled = true;
            this.cbNDepartement.Location = new System.Drawing.Point(121, 29);
            this.cbNDepartement.Name = "cbNDepartement";
            this.cbNDepartement.Size = new System.Drawing.Size(161, 21);
            this.cbNDepartement.TabIndex = 20;
            // 
            // UC_Proyek
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
            this.Name = "UC_Proyek";
            this.Size = new System.Drawing.Size(638, 405);
            this.Load += new System.EventHandler(this.UC_Proyek_Load);
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
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTglLahir;
        private System.Windows.Forms.Label labelNamaPegawai;
        private System.Windows.Forms.TextBox tbNProyek;
        private System.Windows.Forms.ComboBox cbNDepartement;
    }
}
