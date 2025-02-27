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
using AmeltaManagement.UserControls;

namespace AmeltaManagement
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void FormHome_Load(object sender, EventArgs e)
        {
            UC_Pegawai uc = new UC_Pegawai();
            addUserControl(uc);
        }

        private void btnPegawai_Click(object sender, EventArgs e)
        {
            UC_Pegawai uc = new UC_Pegawai();
            addUserControl(uc);
        }

        private void btnDepartement_Click(object sender, EventArgs e)
        {
            UC_Departement uc = new UC_Departement();
            addUserControl(uc);
        }

        private void btnProyek_Click(object sender, EventArgs e)
        {
            UC_Proyek uc = new UC_Proyek();
            addUserControl(uc);
        }

        private void btnLokasi_Click(object sender, EventArgs e)
        {
            UC_Lokasi uc = new UC_Lokasi();
            addUserControl(uc);
        }

        private void btnPindahProyek_Click(object sender, EventArgs e)
        {
            UC_PindahProyek uc = new UC_PindahProyek();
            addUserControl(uc);
        }

        private void btnTanggungan_Click(object sender, EventArgs e)
        {
            UC_Tanggungan uc = new UC_Tanggungan();
            addUserControl(uc);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Yakin ingin logout?", "Logout", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Close();

            }
        }
    }
}
