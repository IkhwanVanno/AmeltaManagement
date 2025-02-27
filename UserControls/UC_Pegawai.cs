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
    public partial class UC_Pegawai : UserControl
    {
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private DataSet ds;
        koneksi konn = new koneksi();
        public UC_Pegawai()
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
                    Pegawai.id_pegawai AS ID_Pegawai,
                    Pegawai.nama AS NamaPegawai,
                    Pegawai.tanggal_lahir AS TanggalLahir,
                    Pegawai.jabatan AS Jabatan,
                    Pengawas.nama AS NamaPengawas,
                    Departemen.nama_departemen AS NamaDepartemen
                FROM 
                    Pegawai
                INNER JOIN 
                    Pegawai AS Pengawas ON Pegawai.id_pengawas = Pengawas.id_pegawai
                INNER JOIN 
                    Departemen ON Pegawai.id_departemen = Departemen.id_departemen";
;
                cmd = new SqlCommand(quey, conn);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "Pegawai");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Pegawai";
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
                cmd = new SqlCommand("SELECT * FROM Pegawai WHERE Nama LIKE '%" + tbCari.Text + "%'", conn);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "Pegawai");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Pegawai";
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
            tbNPegawai.Text = "";
            tbJabatan.Text = "";
            dtpTgl.Text = "";
            cbPengawas.Text = "";
            cbDepartement.Text = "";
        }

        void tcbPengawas()
        {
            SqlConnection conn = konn.GetConn();
            conn.Open();
            string query = @"
            SELECT 
                Pengawas.id_pengawas, 
                Pegawai.nama 
            FROM 
                Pengawas
            INNER JOIN 
                Pegawai ON Pengawas.id_pegawai = Pegawai.id_pegawai";

            SqlCommand cmd = new SqlCommand(query, conn);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Pengawas");

            cbPengawas.DataSource = ds.Tables["Pengawas"];
            cbPengawas.DisplayMember = "nama";      
            cbPengawas.ValueMember = "id_pengawas";
            conn.Close();

        }
        
        void tcbDepartement()
        {
            SqlConnection conn = konn.GetConn();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Departemen", conn);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Departemen");
            cbDepartement.DataSource = ds.Tables["Departemen"];
            cbDepartement.DisplayMember = "nama_departemen";
            cbDepartement.ValueMember = "id_departemen";
            conn.Close();
        }

        private void UC_Pegawai_Load(object sender, EventArgs e)
        {
            TampilData();
            tcbPengawas();
            tcbDepartement();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["btnUbah"].Index)
            {

                tbId.Text = dataGridView1.Rows[e.RowIndex].Cells["ID_pegawai"].Value.ToString();
                tbNPegawai.Text = dataGridView1.Rows[e.RowIndex].Cells["NamaPegawai"].Value.ToString();
                tbJabatan.Text = dataGridView1.Rows[e.RowIndex].Cells["Jabatan"].Value.ToString();
                dtpTgl.Text = dataGridView1.Rows[e.RowIndex].Cells["TanggalLahir"].Value.ToString();
                cbPengawas.Text = dataGridView1.Rows[e.RowIndex].Cells["NamaPengawas"].Value.ToString();
                cbDepartement.Text = dataGridView1.Rows[e.RowIndex].Cells["NamaDepartemen"].Value.ToString();
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
                        cmd = new SqlCommand("DELETE FROM Pegawai WHERE Id = '" + dataGridView1.Rows[e.RowIndex].Cells["ID_pegawai"].Value.ToString() + "'", conn);
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

        private void tbCari_TextChanged(object sender, EventArgs e)
        {
            CariData();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            if (tbNPegawai.Text == "" || dtpTgl.Text == "" || tbJabatan.Text == "" || cbDepartement.Text == "")
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
                    tbId.Focus();
                    tbNPegawai.Focus();
                    dtpTgl.Focus();
                    tbJabatan.Focus();
                    cbPengawas.Focus();
                    cbDepartement.Focus();

                }
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (tbNPegawai.Text == "" || tbJabatan.Text == "")
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
                        cmd = new SqlCommand("UPDATE Pegawai SET nama = @nama, tanggal_lahir = @tanggal_lahir, jabatan = @jabatan, id_pengawas = @id_pengawas, id_departemen = @id_departemen WHERE id_pegawai = @id_pegawai", conn);
                        cmd.Parameters.AddWithValue("@nama", tbNPegawai.Text);
                        cmd.Parameters.AddWithValue("@tanggal_lahir", dtpTgl.Value);
                        cmd.Parameters.AddWithValue("@jabatan", tbJabatan.Text);
                        cmd.Parameters.AddWithValue("@id_pengawas", cbPengawas.SelectedValue);
                        cmd.Parameters.AddWithValue("@id_departemen", cbDepartement.SelectedValue);
                        cmd.Parameters.AddWithValue("@id_pegawai", tbId.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil Diubah");
                        TampilData();
                        bersihData();
                    }
                    else
                    {
                        conn.Open();
                        cmd = new SqlCommand("INSERT INTO Pegawai VALUES ('" + tbNPegawai.Text + "','" + dtpTgl.Value + "','" + tbJabatan.Text + "','" + cbPengawas.SelectedValue + "','" + cbDepartement.SelectedValue + "')", conn);
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
    }
}

