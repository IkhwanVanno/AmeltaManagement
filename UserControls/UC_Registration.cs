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
    public partial class UC_Registration : UserControl
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataReader dr;
        private SqlDataAdapter da;
        koneksi konn = new koneksi();
        public UC_Registration()
        {
            InitializeComponent();
        }

        private void UC_Registration_Load(object sender, EventArgs e)
        {

        }

        private void btnRegristation_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            string role = tbRole.Text;
            SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("INSERT INTO Akun VALUES ('" + username + "','" + password + "','" + role + "')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registrasi Berhasil");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Regristasi Gagal" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
