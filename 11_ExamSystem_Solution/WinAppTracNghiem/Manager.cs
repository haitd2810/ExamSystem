using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinAppTracNghiem.Models;

namespace WinAppTracNghiem
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        public Account acc { get; set; }

        private void btnManageExam_Click(object sender, EventArgs e)
        {

        }

        private void btnManage_Click(object sender, EventArgs e)
        {

        }

        private void btnViewResult_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewResult result = new ViewResult();
            result.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login=new Login();
            login.Show();
        }
    }
}
