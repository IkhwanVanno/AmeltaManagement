﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AmeltaManagement.UserControls
{
    public partial class UC_PindahProyek : UserControl
    {
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        private DataSet ds;
        koneksi konn = new koneksi();
        public UC_PindahProyek()
        {
            InitializeComponent();
        }
        void TambahTombol()
        {
            if (dataGridView1.Columns["btnUbah"] == null)
            {
                DataGridViewButtonColumn btnUbah = new DataGridViewButtonColumn();
                btnUbah.HeaderText = "Ubah";
                btnUbah.Name = "btnUbah";
                btnUbah.Text = "Ubah";
                btnUbah.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btnUbah);
            }
            if (dataGridView1.Columns["btnHapus"] == null)
            {
                DataGridViewButtonColumn btnHapus = new DataGridViewButtonColumn();
                btnHapus.HeaderText = "Hapus";
                btnHapus.Name = "btnHapus";
                btnHapus.Text = "Hapus";
                btnHapus.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btnHapus);
            }
        }
        void TampilData()
        {
            SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                string quey = @"
                SELECT 
                    Pegawai_Proyek.id_pegawai AS ID_Pegawai,
                    Pegawai.nama AS NamaPegawai,
                    Pegawai_Proyek.id_proyek AS ID_Proyek,
                    Proyek.nama_proyek AS NamaProyek
                FROM 
                    Pegawai_Proyek
                INNER JOIN 
                    Pegawai ON Pegawai_Proyek.id_pegawai = Pegawai.id_pegawai
                INNER JOIN 
                    Proyek ON Pegawai_Proyek.id_proyek = Proyek.id_proyek";

                cmd = new SqlCommand(quey, conn);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "Pegawai_Proyek");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Pegawai_Proyek";
                dataGridView1.ReadOnly = true;
                TambahTombol();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        void CariData()
        {
            SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM Pegawai_Proyek WHERE Nama LIKE '%" + tbCari.Text + "%'", conn);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "Pegawai_Proyek");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Pegawai_Proyek";
                dataGridView1.ReadOnly = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        void bersihData()
        {
            cbNPegawai.Text = "";
            cbNProyek.Text = "";
        }

        void tcbPegawai()
        {
            SqlConnection conn = konn.GetConn();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Pegawai", conn);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Pegawai");
            cbNPegawai.DataSource = ds.Tables["Pegawai"];
            cbNPegawai.DisplayMember = "nama";
            cbNPegawai.ValueMember = "id_pegawai";
            conn.Close();
        }

        void tcbProyek()
        {
            SqlConnection conn = konn.GetConn();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Proyek", conn);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Proyek");
            cbNProyek.DataSource = ds.Tables["Proyek"];
            cbNProyek.DisplayMember = "nama_Proyek";
            cbNProyek.ValueMember = "id_Proyek";
            conn.Close();
        }

        private void UC_PindahProyek_Load(object sender, EventArgs e)
        {
            TampilData();
            tcbPegawai();
            tcbProyek();
            bersihData();
        }

        private void tbCari_TextChanged(object sender, EventArgs e)
        {
            CariData();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            if (cbNPegawai.Text == "" || cbNProyek.Text == "")
            {
                MessageBox.Show("Data belum diisi");
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Yakin Ingin Membatalkan?", "Batal", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    bersihData();
                }
                else
                {
                    cbNPegawai.Focus();
                    cbNProyek.Focus();
                }
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (cbNPegawai.Text == "" || cbNProyek.Text == "")
            {
                MessageBox.Show("Data belum diisi");
            }
            else
            {
                SqlConnection conn = konn.GetConn();
                try
                {
                    conn.Open();
                    if (tbId.Text != "")
                    {
                        cmd = new SqlCommand("UPDATE Pegawai_Proyek SET id_proyek = (SELECT id_proyek FROM Proyek WHERE nama_proyek = '" + cbNProyek.Text + "') WHERE id_pegawai = (SELECT id_pegawai FROM Pegawai WHERE nama = '" + cbNPegawai.Text + "') AND id_proyek = '" + tbId.Text + "'", conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil Diubah");
                    }
                    else
                    {
                        cmd = new SqlCommand("INSERT INTO Pegawai_Proyek (id_pegawai, id_proyek) VALUES ((SELECT id_pegawai FROM Pegawai WHERE nama = '" + cbNPegawai.Text + "'), (SELECT id_proyek FROM Proyek WHERE nama_proyek = '" + cbNProyek.Text + "'))", conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil Disimpan");
                    }
                    TampilData();
                    bersihData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data Gagal Disimpan" + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["btnUbah"].Index)
            {
                tbId.Text = dataGridView1.Rows[e.RowIndex].Cells["ID_Pegawai"].Value.ToString();
                cbNPegawai.Text = dataGridView1.Rows[e.RowIndex].Cells["NamaPegawai"].Value.ToString();
                cbNProyek.Text = dataGridView1.Rows[e.RowIndex].Cells["NamaProyek"].Value.ToString();
            }
            else if (e.ColumnIndex == dataGridView1.Columns["btnHapus"].Index)
            {
                DialogResult dialog = MessageBox.Show("Yakin Ingin Menghapus?", "Hapus", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    SqlConnection conn = konn.GetConn();
                    try
                    {
                        conn.Open();
                        cmd = new SqlCommand("DELETE FROM Pegawai_Proyek WHERE id_pegawai = '" + dataGridView1.Rows[e.RowIndex].Cells["ID_Pegawai"].Value.ToString() + "' AND id_proyek = '" + dataGridView1.Rows[e.RowIndex].Cells["ID_Proyek"].Value.ToString() + "'", conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil Dihapus");
                        TampilData();
                        bersihData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Data Gagal Dihapus" + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            TampilData();
            bersihData();
        }
    }
}
