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

namespace DARS
{
    public partial class Advisor_Login : Form
    {
        public Advisor_Login()
        {
            InitializeComponent();
        }

        private void Advisor_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("Username", txtUser.Text));
            sqlParams.Add(new SqlParameter("Password", txtPassword.Text));
            Globals.username = txtUser.Text;

            DataTable dtLoginResults = DAL.ExecSP("ValidateAdvisorLogin", sqlParams);

            if (dtLoginResults.Rows.Count == 1)
            {
                //We will know the login is valid if there is only 1 row.
                string user = dtLoginResults.Rows[0]["Username"].ToString();
                MessageBox.Show("You are logged in as " + user);
                Advisor_Home MAIN_ADVISOR = new Advisor_Home();
                MAIN_ADVISOR.Show();
                this.Hide();
            }
            else
            {
                //Invalid login
                MessageBox.Show("Invalid Login");
            }
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            Login new_Login = new Login();
            new_Login.Show();
            this.Hide();
        }

        private void Advisor_Login_Load(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.FromArgb(222, 180, 8);
            btnLogin.ForeColor = Color.FromArgb(0, 40, 94);
            btnStudent.BackColor = Color.FromArgb(222, 180, 8);
            btnStudent.ForeColor = Color.FromArgb(0, 40, 94);
        }
    }
}
