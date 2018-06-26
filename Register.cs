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

namespace DARS
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("Username", txtUser.Text));
            sqlParams.Add(new SqlParameter("Password", txtPassword.Text));
            DAL.ExecSP("CreateUser", sqlParams);
            MessageBox.Show("CreateUser Executed");

            Globals.username = txtUser.Text;
            //Do not turn the below code on. Table in SSMS no longer exists.
            /*List<SqlParameter> sqlNewTable = new List<SqlParameter>();
            sqlNewTable.Add(new SqlParameter("Username", txtUser.Text));
            DAL.ExecSP("CreateUserCourses", sqlNewTable);
            MessageBox.Show("CreateUserCourses Executed");

            //Code not needed
            using(Register_OralComm frmRegister_OralComm = new Register_OralComm())
            {
                string username = txtUser.Text;
            }*/

            Register_MainInfo frmRegister_MainInfo = new Register_MainInfo();
            frmRegister_MainInfo.Show();
            this.Hide();

        }

        private void lblLogin_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login frmLogin = new Login();
            frmLogin.Show();
            this.Hide();
        }

        private void Register_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}