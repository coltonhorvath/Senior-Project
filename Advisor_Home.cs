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
    public partial class Advisor_Home : Form
    {
        public Advisor_Home()
        {
            InitializeComponent();
        }

        private void Advisor_Home_Load(object sender, EventArgs e)
        {
            string strConnect = "Server=DESKTOP-2Q73COU\\SQLEXPRESS;Database=LoginApp;Trusted_Connection=True;";
            SqlConnection conn = new SqlConnection(strConnect);
            conn.Open();
            using (SqlConnection Advisor_Load = new SqlConnection(strConnect))
            {
                SqlCommand command =
                    new SqlCommand("SELECT * FROM Main_Information", Advisor_Load);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                adapter.Fill(dt);
                dgvAdvisor.DataSource = dt;

                btnStudentLookup.BackColor = Color.FromArgb(222, 180, 8);
                btnStudentLookup.ForeColor = Color.FromArgb(0, 40, 94);
                btnCourseLookup.BackColor = Color.FromArgb(222, 180, 8);
                btnCourseLookup.ForeColor = Color.FromArgb(0, 40, 94);
            }
            using (SqlConnection load_info = new SqlConnection(strConnect))
            {
                load_info.Open();
                SqlCommand loadMainInfo =
                    new SqlCommand("SELECT * FROM Advisors WHERE Username = @Username", load_info);
                loadMainInfo.Parameters.Add(new SqlParameter("@Username", Globals.username));
                SqlDataReader dr = loadMainInfo.ExecuteReader();
                while (dr.Read())
                {
                    lblAdvisorName.Text = (dr["First Name"].ToString()) + " " + (dr["Last Name"].ToString());
                    lblCollegeName.Text = (dr["College"].ToString());
                }
            }
        }

        private void btnStudentLookup_Click(object sender, EventArgs e)
        {
            string strConnect = "Server=DESKTOP-2Q73COU\\SQLEXPRESS;Database=LoginApp;Trusted_Connection=True;";
            SqlConnection conn = new SqlConnection(strConnect);
            conn.Open();
            using (SqlConnection studentLookup = new SqlConnection(strConnect))
            {
                SqlCommand command =
                    new SqlCommand("SELECT * FROM Main_Information WHERE [First Name] like '%" + txtFirstName.Text + "%' " +
                    "AND [Last Name] like '%" + txtLastName.Text + "%' " +
                    "AND [Username] like '%" + txtUsername.Text + "%' " +
                    "AND [Standing] like '%" + txtStanding.Text + "%' " +
                    "AND [Degree] like '%" + txtDegree.Text + "%'" +
                    "AND [Degree_type] like '%" + txtDegreeType.Text + "%';", studentLookup);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvAdvisor.DataSource = dt;
            }
        }

        private void Advisor_Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSubmit_2_Click(object sender, EventArgs e)
        {
            string strConnect = "Server=DESKTOP-2Q73COU\\SQLEXPRESS;Database=LoginApp;Trusted_Connection=True;";
            SqlConnection conn = new SqlConnection(strConnect);
            conn.Open();
            using (SqlConnection courseLookup = new SqlConnection(strConnect))
            {
                SqlCommand command2 =
                    new SqlCommand("SELECT * FROM MasterUserCourses WHERE [Username] like '%" + txtUsername2.Text + "%' " +
                    "AND [Course] like '%" + txtCourse.Text + "%' " +
                    "AND [Description] like '%" + txtDescription.Text + "%' " +
                    "AND [Grade] like '%" + txtGrade.Text + "%';", courseLookup);

                SqlDataAdapter adapter2 = new SqlDataAdapter(command2);
                DataTable dt2 = new DataTable();
                adapter2.Fill(dt2);
                dgvAdvisor.DataSource = dt2;
            }
        }
    }
}
