using AmeltaManagement.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmeltaManagement
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
            UC_Login loginControl = new UC_Login(this);
            AddUserControl(loginControl);
        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UC_Login uc = new UC_Login(this);
            AddUserControl(uc);
        }

        private void btnLoginPage_Click(object sender, EventArgs e)
        {
            UC_Login uc = new UC_Login(this);
            AddUserControl(uc);
        }

        private void btnRegisterPage_Click(object sender, EventArgs e)
        {
            UC_Registration uc = new UC_Registration();
            AddUserControl(uc);
        }
    }
}
