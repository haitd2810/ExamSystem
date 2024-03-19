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
    public partial class Login : Form
    {
        WinAppTracNghiemContext context = new WinAppTracNghiemContext();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsername.Text) || String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please enter username or password");
                return;
            }
            Account acc = context.Accounts.Where(a => a.Username == txtUsername.Text && a.Password == txtPassword.Text).FirstOrDefault();
            if (acc.Role == 1)
            {

            }
            else
            {
                if (String.IsNullOrEmpty(txtCode.Text))
                {
                    MessageBox.Show("Please enter Exam Code");
                    return;
                }
                ExamCode code = context.ExamCodes.Where(c => c.Code == txtCode.Text).FirstOrDefault();
                if (code == null)
                {
                    MessageBox.Show("Exam Code not exist");
                    return;
                }
                if(code.Status.Equals("Not Active"))
                {
                    MessageBox.Show("Exam Code not active");
                    return;
                }

                Enroll enroll=context.Enrolls.Where(e => e.Username==acc.Username
                                && e.Semester==code.Semester && e.Course==code.Course).FirstOrDefault();
                if(enroll == null)
                {
                    MessageBox.Show("You not enroll this exam code");
                    return;
                }

                Practice practice = context.Practices.Where(p => p.Username == acc.Username && p.ExamCode == code.Code).FirstOrDefault();
                if(practice != null)
                {
                    MessageBox.Show("You have assigned this code");
                    return;
                }
                MessageBox.Show("Login SuccessFull");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
