using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AmeltaManagement.UserControls
{
    public partial class UC_Departement : UserControl
    {
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private DataSet ds;
        koneksi konn = new koneksi();
        public UC_Departement()
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
                    Departemen.id_departemen AS ID_Departemen,
                    Departemen.nama_departemen AS NamaDepartemen,
                    Pegawai.nama AS NamaKepalaDepartemen,
                    Departemen.tanggal_mulai AS TanggalMulai
                FROM 
                    Departemen
                INNER JOIN 
                    Pegawai ON Departemen.kepala_departemen = Pegawai.id_pegawai";
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
                cmd = new SqlCommand("SELECT * FROM Departement WHERE Nama LIKE '%" + tbCari.Text + "%'", conn);
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
            tbId.Text = "";
            tbNDepartement.Text = "";
            dtpTgl.Text = "";
            cbKDepartement.Text = "";
        }

        void tcbKepalaDepartemen()
        {
            SqlConnection conn = konn.GetConn();
            conn.Open();

            string query = @"
            SELECT 
                Kepala_Departemen.id_kepala_departemen, 
                Pegawai.nama AS NamaKepalaDepartemen, 
                Departemen.nama_departemen 
            FROM 
                Kepala_Departemen
            INNER JOIN 
                Pegawai ON Kepala_Departemen.id_pegawai = Pegawai.id_pegawai
            INNER JOIN 
                Departemen ON Kepala_Departemen.id_departemen = Departemen.id_departemen";

            SqlCommand cmd = new SqlCommand(query, conn);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Kepala_Departemen");
            cbKDepartement.DataSource = ds.Tables["Kepala_Departemen"];
            cbKDepartement.DisplayMember = "NamaKepalaDepartemen"; 
            cbKDepartement.ValueMember = "id_kepala_departemen";  
            conn.Close();

        }

        private void UC_Departement_Load(object sender, EventArgs e)
        {
            TampilData();
            tcbKepalaDepartemen();
            bersihData();
        }

        private void tbCari_TextChanged(object sender, EventArgs e)
        {
            CariData();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            if (tbNDepartement.Text == "" || dtpTgl.Text == "" || cbKDepartement.Text == "")
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
                    tbNDepartement.Focus();
                    dtpTgl.Focus();
                    cbKDepartement.Focus();
                }
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (tbNDepartement.Text == "" || cbKDepartement.Text == "")
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
                        cmd = new SqlCommand("UPDATE Departemen SET nama_departemen = '" + tbNDepartement.Text + "', kepala_departemen = '" + cbKDepartement.SelectedValue + "', tanggal_mulai = '" + dtpTgl.Value.ToString("yyyy-MM-dd") + "' WHERE id_departemen = '" + tbId.Text + "'", conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil Diubah");
                        TampilData();
                        bersihData();
                    }
                    else
                    {
                        conn.Open();
                        cmd = new SqlCommand("INSERT INTO Departemen VALUES ('" + tbNDepartement.Text + "','" + cbKDepartement.SelectedValue + "', '" + dtpTgl.Value.ToString("yyyy-MM-dd") + "')", conn);
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            TampilData();
            bersihData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["btnUbah"].Index)
            {
                tbId.Text = dataGridView1.Rows[e.RowIndex].Cells["ID_Departemen"].Value.ToString();
                tbNDepartement.Text = dataGridView1.Rows[e.RowIndex].Cells["NamaDepartemen"].Value.ToString();
                cbKDepartement.Text = dataGridView1.Rows[e.RowIndex].Cells["NamaKepalaDepartemen"].Value.ToString();
                dtpTgl.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["TanggalMulai"].Value);
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
                        cmd = new SqlCommand("DELETE FROM Departemen WHERE id_departemen = '" + dataGridView1.Rows[e.RowIndex].Cells["ID_Departemen"].Value.ToString() + "'", conn);
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
