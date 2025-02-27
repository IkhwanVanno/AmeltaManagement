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
    public partial class UC_Lokasi : UserControl
    {
        private SqlCommand cmd;
        private SqlDataReader dr;
        private SqlDataAdapter da;
        private DataSet ds;
        koneksi konn = new koneksi();
        public UC_Lokasi()
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
                    Lokasi.id_lokasi AS ID_Lokasi,
                    Lokasi.nama_lokasi AS NamaLokasi,
                    Departemen.nama_departemen AS NamaDepartemen
                FROM 
                    Lokasi
                INNER JOIN 
                    Departemen ON Lokasi.id_departemen = Departemen.id_departemen";

                cmd = new SqlCommand(quey, conn);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "Lokasi");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Lokasi";
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
                cmd = new SqlCommand("SELECT * FROM Lokasi WHERE Nama LIKE '%" + tbCari.Text + "%'", conn);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "Lokasi");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Lokasi";
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
            tbNLokasi.Text = "";
            cbNDepartement.Text = "";
        }

        void tcbDepartement()
        {
            SqlConnection conn = konn.GetConn();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Departemen", conn);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Departemen");
            cbNDepartement.DataSource = ds.Tables["Departemen"];
            cbNDepartement.DisplayMember = "nama_departemen";
            cbNDepartement.ValueMember = "id_departemen";
            conn.Close();
        }

        private void UC_Lokasi_Load(object sender, EventArgs e)
        {
            TampilData();
            tcbDepartement();
            bersihData();
        }

        private void tbCari_TextChanged(object sender, EventArgs e)
        {
            CariData();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            if (tbNLokasi.Text == "" || cbNDepartement.Text == "")
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
                    tbNLokasi.Focus();
                    cbNDepartement.Focus();
                }
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (tbNLokasi.Text == "" || cbNDepartement.Text == "")
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
                        cmd = new SqlCommand("UPDATE Lokasi SET nama_lokasi = '" + tbNLokasi.Text + "', id_departemen = (SELECT id_departemen FROM Departemen WHERE nama_departemen = '" + cbNDepartement.Text + "') WHERE id_lokasi = '" + tbId.Text + "'", conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil Diubah");
                    }
                    else
                    {
                        cmd = new SqlCommand("INSERT INTO Lokasi (nama_lokasi, id_departemen) VALUES ('" + tbNLokasi.Text + "', (SELECT id_departemen FROM Departemen WHERE nama_departemen = '" + cbNDepartement.Text + "'))", conn);
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
                tbId.Text = dataGridView1.Rows[e.RowIndex].Cells["ID_Lokasi"].Value.ToString();
                tbNLokasi.Text = dataGridView1.Rows[e.RowIndex].Cells["NamaLokasi"].Value.ToString();
                cbNDepartement.Text = dataGridView1.Rows[e.RowIndex].Cells["NamaDepartemen"].Value.ToString();
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
                        cmd = new SqlCommand("DELETE FROM Lokasi WHERE id_lokasi = '" + dataGridView1.Rows[e.RowIndex].Cells["ID_Lokasi"].Value.ToString() + "'", conn);
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
