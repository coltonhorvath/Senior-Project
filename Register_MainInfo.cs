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
    public partial class Register_MainInfo : Form
    {
        public Register_MainInfo()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_MainInfo_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Globals.username);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("username", Globals.username));
            sqlParams.Add(new SqlParameter("firstName", txtFirstName.Text));
            sqlParams.Add(new SqlParameter("lastName", txtLastName.Text));
            sqlParams.Add(new SqlParameter("Standing", cboxStanding.Text));
            sqlParams.Add(new SqlParameter("Type", cboxType.Text));
            sqlParams.Add(new SqlParameter("Degree", cboxDegree.Text));
            sqlParams.Add(new SqlParameter("totalHours", txtTotalHours.Text));
            sqlParams.Add(new SqlParameter("currentHours", txtCurrentHours.Text));
            DAL.ExecSP("CreateMainInfo", sqlParams);
            MessageBox.Show("CreateMainInfo Executed");

            Register_OralComm frmRegister_OralComm = new Register_OralComm();
            frmRegister_OralComm.Show();
            this.Hide();
        }

        private void Register_MainInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
