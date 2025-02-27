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
    public partial class UC_Login : UserControl
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        koneksi konn = new koneksi();
        private FormStart formStart;

        public UC_Login(FormStart formStart)
        {
            InitializeComponent();
            this.formStart = formStart;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM Akun WHERE username = '" + username + "' AND password = '" + password + "'", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    FormHome fh = new FormHome();
                    fh.Show();
                    formStart.Hide();
                }
                else
                {
                    MessageBox.Show("Login Gagal");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
