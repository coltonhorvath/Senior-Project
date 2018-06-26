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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        /*public void getUser()
        {
            get { return txtUser.Text; }
        }*/

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("Username", txtUser.Text));
            sqlParams.Add(new SqlParameter("Password", txtPassword.Text));
            Globals.username = txtUser.Text;

            DataTable dtLoginResults = DAL.ExecSP("ValidateLogin", sqlParams);

            if (dtLoginResults.Rows.Count == 1)
            {
                //We will know the login is valid if there is only 1 row.
                string user = dtLoginResults.Rows[0]["Username"].ToString();
                Home MAIN = new Home();
                MAIN.Show();
                this.Hide();
            }
            else
            {
                //Invalid login
                MessageBox.Show("Invalid Login");
            }
        }

        private void lblRegister_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register frmRegister = new Register();
            frmRegister.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.FromArgb(222, 180, 8);
            btnLogin.ForeColor = Color.FromArgb(0, 40, 94);
            btnAdvisor.BackColor = Color.FromArgb(222, 180, 8);
            btnAdvisor.ForeColor = Color.FromArgb(0, 40, 94);
        }

        private void btnAdvisor_Click(object sender, EventArgs e)
        {
            Advisor_Login frmAdvLogin = new Advisor_Login();
            frmAdvLogin.Show();
            this.Hide();
        }
    }
}
