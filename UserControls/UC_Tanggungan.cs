using System;
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
    public partial class UC_Tanggungan : UserControl
    {
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private DataSet ds;
        koneksi konn = new koneksi();
        public UC_Tanggungan()
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
                btnHapus .UseColumnTextForButtonValue = true;
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
                    Tanggungan.id_tanggungan AS 'ID',
                    Tanggungan.nama_tanggungan AS 'Nama',
                    Tanggungan.hubungan AS 'Hubungan',
                    Pegawai.nama AS 'Nama Pegawai'
                FROM
                    Tanggungan
                INNER JOIN
                    Pegawai ON Tanggungan.id_pegawai = Pegawai.id_pegawai";
                cmd = new SqlCommand(quey,conn);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "Tanggungan");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Tanggungan";
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
                cmd = new SqlCommand("SELECT * FROM Tanggungan WHERE Nama LIKE '%" + tbCari.Text + "%'", conn);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "Tanggungan");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Tanggungan";
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
            tbCari.Text = "";
            tbNTanggungan.Text = "";
            cbHubungan.Text = "";
            cbNPegawai.Text = "";
        }

        void cbPegawai()
        {
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM Pegawai", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Pegawai");
            cbNPegawai.DataSource = ds.Tables["Pegawai"];
            cbNPegawai.DisplayMember = "nama";
            cbNPegawai.ValueMember = "id_pegawai";
        }

        void cbHubungann()
        {
            cbHubungan.Items.Add("Istri");
            cbHubungan.Items.Add("Suami");
            cbHubungan.Items.Add("Anak");
            cbHubungan.Items.Add("OrangTua");
        }
        private void UC_Tanggungan_Load(object sender, EventArgs e)
        {
            TampilData();
            cbPegawai();
            cbHubungann();
            bersihData();
        }

        private void tbCari_TextChanged(object sender, EventArgs e)
        {
            CariData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            TampilData();
            bersihData();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            if (tbNTanggungan.Text == "" || cbHubungan.Text == "" ||  cbNPegawai.Text == "")
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
                    tbNTanggungan.Focus();
                    cbHubungan.Focus();
                    cbNPegawai.Focus();
                }
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if(tbNTanggungan.Text == "" || cbHubungan.Text == "" || cbNPegawai.Text == "")
            {
                MessageBox.Show("Data belum diisi");
            }
            else
            {
                SqlConnection conn = konn.GetConn();
                try
                {
                    if (tbId.Text != "")
                    {
                        conn.Open();
                        cmd = new SqlCommand("UPDATE Tanggungan SET nama_tanggungan = '" + tbNTanggungan.Text + "', hubungan = '" + cbHubungan.Text + "', id_pegawai = '" + cbNPegawai.SelectedValue + "' WHERE id_tanggungan = '" + tbId.Text + "'", conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil Diubah");
                        TampilData();
                        bersihData();
                    }
                    else
                    {
                        conn.Open();
                        cmd = new SqlCommand("INSERT INTO Tanggungan VALUES ('" + tbNTanggungan.Text + "','" + cbHubungan.Text + "','" + cbNPegawai.SelectedValue + "')", conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil Disimpan");
                        TampilData();
                        bersihData();
                    }
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
            if(e.ColumnIndex == dataGridView1.Columns["btnUbah"].Index)
            {
                tbId.Text = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                tbNTanggungan.Text = dataGridView1.Rows[e.RowIndex].Cells["Nama"].Value.ToString();
                cbHubungan.Text = dataGridView1.Rows[e.RowIndex].Cells["Hubungan"].Value.ToString();
                cbNPegawai.Text = dataGridView1.Rows[e.RowIndex].Cells["Nama Pegawai"].Value.ToString();
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
                        cmd = new SqlCommand("DELETE FROM Tanggungan WHERE Id = '" + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", conn);
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
    }
}
