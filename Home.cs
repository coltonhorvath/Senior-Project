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
using System.Windows.Controls;

namespace DARS
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

            dgvOralComm.BorderStyle = BorderStyle.None;
            dgvEnglish1.BorderStyle = BorderStyle.None;
            dgvEnglish2.BorderStyle = BorderStyle.None;
            dgvMath.BorderStyle = BorderStyle.None;
            dgvGeology.BorderStyle = BorderStyle.None;
            dgvBiology.BorderStyle = BorderStyle.None;
            dgvChemistry.BorderStyle = BorderStyle.None;
            dgvPhysics.BorderStyle = BorderStyle.None;
            dgvAnthro.BorderStyle = BorderStyle.None;
            dgvEnviSci.BorderStyle = BorderStyle.None;
            dgvEcon.BorderStyle = BorderStyle.None;
            dgvGeography.BorderStyle = BorderStyle.None;
            dgvUSGovPoli.BorderStyle = BorderStyle.None;
            dgvPsychology.BorderStyle = BorderStyle.None;
            dgvSocAnthEd.BorderStyle = BorderStyle.None;
            dgvUSHist.BorderStyle = BorderStyle.None;
            dgvSciTechSoc.BorderStyle = BorderStyle.None;
            dgvPhysEd.BorderStyle = BorderStyle.None;
            dgvHumanities.BorderStyle = BorderStyle.None;
            dgvFineArts.BorderStyle = BorderStyle.None;
            dgvPhilClass.BorderStyle = BorderStyle.None;
            dgvLit.BorderStyle = BorderStyle.None;
            dgvAreaStudies.BorderStyle = BorderStyle.None;

            string strConnect = "Server=DESKTOP-2Q73COU\\SQLEXPRESS;Database=LoginApp;Trusted_Connection=True;";
            SqlConnection conn = new SqlConnection(strConnect);
            conn.Open();

            using (SqlConnection OralCommunication = new SqlConnection(strConnect))
            {
                SqlCommand command =
                    new SqlCommand("SELECT * FROM MasterUserCourses WHERE Username = @Username AND (" +
                    "Course = 7600105 OR " +
                    "Course = 2420263 OR " +
                    "Course = 7600106)", OralCommunication);

                command.Parameters.Add(new SqlParameter("@Username", Globals.username));

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                adapter.Fill(dt);
                dgvOralComm.DataSource = dt;
            }

            using (SqlConnection English1 = new SqlConnection(strConnect))
            {
                SqlCommand command =
                    new SqlCommand("SELECT * FROM MasterUserCourses WHERE Username = @Username AND (" +
                    "Course = 3300110 OR " +
                    "Course = 3300111 OR " +
                    "Course = 2020121 OR " +
                    "Course = 3300113)", English1);

                command.Parameters.Add(new SqlParameter("@Username", Globals.username));

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                adapter.Fill(dt);
                dgvEnglish1.DataSource = dt;
            }
            
            using (SqlConnection English2 = new SqlConnection(strConnect))
            {
                SqlCommand command =
                    new SqlCommand("SELECT * FROM MasterUserCourses WHERE Username = @Username AND (" +
                    "Course = 3300112 OR " +
                    "Course = 3300114 OR " +
                    "Course = 2020222)", English2);

                command.Parameters.Add(new SqlParameter("@Username", Globals.username));

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                adapter.Fill(dt);
                dgvEnglish2.DataSource = dt;
            }
            
            using (SqlConnection Math = new SqlConnection(strConnect))
            {
                SqlCommand command =
                    new SqlCommand("SELECT * FROM MasterUserCourses WHERE Username = @Username AND (" +
                    "Course = 3450100 OR " +
                    "Course = 3450135 OR " +
                    "Course = 3450145)", Math);

                command.Parameters.Add(new SqlParameter("@Username", Globals.username));

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                adapter.Fill(dt);
                dgvMath.DataSource = dt;
            }
            
            using (SqlConnection Geology = new SqlConnection(strConnect))
            {
                SqlCommand command =
                    new SqlCommand("SELECT * FROM MasterUserCourses WHERE Username = @Username AND (" +
                    "Course = 3370100 OR " +
                    "Course = 3370101 OR " +
                    "Course = 3370103 OR " +
                    "Course = 3370121 OR " +
                    "Course = 3370171 OR " +
                    "Course = 3370200 OR " +
                    "Course = 3370201 OR " +
                    "Course = 3370203)", Geology);

                command.Parameters.Add(new SqlParameter("@Username", Globals.username));

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                adapter.Fill(dt);
                dgvGeology.DataSource = dt;
            }
            
            using (SqlConnection Biology = new SqlConnection(strConnect))
            {
                SqlCommand command =
                    new SqlCommand("SELECT * FROM MasterUserCourses WHERE Username = @Username AND (" +
                    "Course = 2780106 OR " +
                    "Course = 2780107 OR " +
                    "Course = 3100100 OR " +
                    "Course = 3100103 OR " +
                    "Course = 3100108)", Biology);

                command.Parameters.Add(new SqlParameter("@Username", Globals.username));

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                adapter.Fill(dt);
                dgvBiology.DataSource = dt;
            }
            
            using (SqlConnection Chemistry = new SqlConnection(strConnect))
            {
                SqlCommand command =
                    new SqlCommand("SELECT * FROM MasterUserCourses WHERE Username = @Username AND (" +
                    "Course = 3150100 OR " +
                    "Course = 3150101 OR " +
                    "Course = 2820105 OR " +
                    "Course = 2820111 OR " +
                    "Course = 2820112)", Chemistry);

                command.Parameters.Add(new SqlParameter("@Username", Globals.username));

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                adapter.Fill(dt);
                dgvChemistry.DataSource = dt;
            }
            
            using (SqlConnection Physics = new SqlConnection(strConnect))
            {
                SqlCommand command =
                    new SqlCommand("SELECT * FROM MasterUserCourses WHERE Username = @Username AND (" +
                    "Course = 3650130 OR " +
                    "Course = 3650133 OR " +
                    "Course = 3650137 OR " +
                    "Course = 2820161 OR " +
                    "Course = 2820162 OR " +
                    "Course = 2820163 OR " +
                    "Course = 2820164)", Physics);

                command.Parameters.Add(new SqlParameter("@Username", Globals.username));

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                adapter.Fill(dt);
                dgvPhysics.DataSource = dt;
            }
            
            using (SqlConnection Anthropology = new SqlConnection(strConnect))
            {
                SqlCommand command =
                    new SqlCommand("SELECT * FROM MasterUserCourses WHERE Username = @Username AND Course = 3230151", Anthropology);

                command.Parameters.Add(new SqlParameter("@Username", Globals.username));

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                adapter.Fill(dt);
                dgvAnthro.DataSource = dt;
            }
            
            using (SqlConnection EnviSci = new SqlConnection(strConnect))
            {
                SqlCommand command =
                    new SqlCommand("SELECT * FROM MasterUserCourses WHERE Username = @Username AND Course = 3370211", EnviSci);

                command.Parameters.Add(new SqlParameter("@Username", Globals.username));

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                adapter.Fill(dt);
                dgvEnviSci.DataSource = dt;
            }
            
            using (SqlConnection Economics = new SqlConnection(strConnect))
            {
                SqlCommand command =
                    new SqlCommand("SELECT * FROM MasterUserCourses WHERE Username = @Username AND (" +
                    "Course = 3250100 OR " +
                    "Course = 3250200 OR " +
                    "Course = 3250201 OR " +
                    "Course = 3250244 OR " +
                    "Course = 2040247)", Economics);

                command.Parameters.Add(new SqlParameter("@Username", Globals.username));

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                adapter.Fill(dt);
                dgvEcon.DataSource = dt;
            }
            
            using (SqlConnection Geography = new SqlConnection(strConnect))
            {
                SqlCommand command =
                    new SqlCommand("SELECT * FROM MasterUserCourses WHERE Username = @Username AND Course = 3350100", Geography);

                command.Parameters.Add(new SqlParameter("@Username", Globals.username));

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                adapter.Fill(dt);
                dgvGeography.DataSource = dt;
            }
            
            using (SqlConnection USGovPoli = new SqlConnection(strConnect))
            {
                SqlCommand command =
                    new SqlCommand("SELECT * FROM MasterUserCourses WHERE Username = @Username AND (" +
                    "Course = 3700100 OR " +
                    "Course = 3700150 OR " +
                    "Course = 2040242)", USGovPoli);

                command.Parameters.Add(new SqlParameter("@Username", Globals.username));

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                adapter.Fill(dt);
                dgvUSGovPoli.DataSource = dt;
            }
            
            using (SqlConnection Psychology = new SqlConnection(strConnect))
            {
                SqlCommand command =
                    new SqlCommand("SELECT * FROM MasterUserCourses WHERE Username = @Username AND (" +
                    "Course = 3750100 OR " +
                    "Course = 2040240)", Psychology);

                command.Parameters.Add(new SqlParameter("@Username", Globals.username));

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                adapter.Fill(dt);
                dgvPsychology.DataSource = dt;
            }
            
            using (SqlConnection SocAnthEd = new SqlConnection(strConnect))
            {
                SqlCommand command =
                    new SqlCommand("SELECT * FROM MasterUserCourses WHERE Username = @Username AND (" +
                    "Course = 3850100 OR " +
                    "Course = 3230150 OR " +
                    "Course = 5100150 OR " +
                    "Course = 2040244)", SocAnthEd);

                command.Parameters.Add(new SqlParameter("@Username", Globals.username));

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                adapter.Fill(dt);
                dgvSocAnthEd.DataSource = dt;
            }
            
            using (SqlConnection USHist = new SqlConnection(strConnect))
            {
                SqlCommand command =
                    new SqlCommand("SELECT * FROM MasterUserCourses WHERE Username = @Username AND (" +
                    "Course = 3400250 OR " +
                    "Course = 3400251)", USHist);

                command.Parameters.Add(new SqlParameter("@Username", Globals.username));

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                adapter.Fill(dt);
                dgvUSHist.DataSource = dt;
            }
            
            using (SqlConnection SciTechSoc = new SqlConnection(strConnect))
            {
                SqlCommand command =
                    new SqlCommand("SELECT * FROM MasterUserCourses WHERE Username = @Username AND (" +
                    "Course = 2040241 OR " +
                    "Course = 2040243 OR " +
                    "Course = 3240100 OR " +
                    "Course = 3600125)", SciTechSoc);

                command.Parameters.Add(new SqlParameter("@Username", Globals.username));

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                adapter.Fill(dt);
                dgvSciTechSoc.DataSource = dt;
            }
            
            using (SqlConnection PhysicalEducation = new SqlConnection(strConnect))
            {
                SqlCommand command =
                    new SqlCommand("SELECT * FROM MasterUserCourses WHERE Username = @Username AND (" +
                    "Course = 2740122 OR " +
                    "Course = 5540120 OR " +
                    "Course = 5550100 OR " +
                    "Course = 5550150 OR " +
                    "Course = 5550194 OR " +
                    "Course = 5550211 OR " +
                    "Course = 5570101 OR " +
                    "Course = 7760133 OR " +
                    "Course = 7510126 OR " +
                    "Course = 7900119 OR " +
                    "Course = 7900120 OR " +
                    "Course = 7900124 OR " +
                    "Course = 7900125 OR " +
                    "Course = 7900130 OR " +
                    "Course = 7900230 OR " +
                    "Course = 7900144)", PhysicalEducation);

                command.Parameters.Add(new SqlParameter("@Username", Globals.username));

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                adapter.Fill(dt);
                dgvPhysEd.DataSource = dt;
            }

            using (SqlConnection Humanities = new SqlConnection(strConnect))
            {
                SqlCommand command =
                    new SqlCommand("SELECT * FROM MasterUserCourses WHERE Username = @Username AND (" +
                    "Course = 3400210 OR " +
                    "Course = 3400221)", Humanities);

                command.Parameters.Add(new SqlParameter("@Username", Globals.username));

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                adapter.Fill(dt);
                dgvHumanities.DataSource = dt;
            }
            
            using (SqlConnection FineArts = new SqlConnection(strConnect))
            {
                SqlCommand command =
                    new SqlCommand("SELECT * FROM MasterUserCourses WHERE Username = @Username AND (" +
                    "Course = 7100210 OR " +
                    "Course = 7500201 OR " +
                    "Course = 7800301 OR " +
                    "Course = 7900200)", FineArts);

                command.Parameters.Add(new SqlParameter("@Username", Globals.username));

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                adapter.Fill(dt);
                dgvFineArts.DataSource = dt;
            }
            
            using (SqlConnection PhilClass = new SqlConnection(strConnect))
            {
                SqlCommand command =
                    new SqlCommand("SELECT * FROM MasterUserCourses WHERE Username = @Username AND (" +
                    "Course = 3200220 OR " +
                    "Course = 3200230 OR " +
                    "Course = 3200289 OR " +
                    "Course = 3600101 OR " +
                    "Course = 3600120 OR " +
                    "Course = 3600170)", PhilClass);

                command.Parameters.Add(new SqlParameter("@Username", Globals.username));

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                adapter.Fill(dt);
                dgvPhilClass.DataSource = dt;
            }

            using (SqlConnection Literature = new SqlConnection(strConnect))
            {
                SqlCommand command =
                    new SqlCommand("SELECT * FROM MasterUserCourses WHERE Username = @Username AND (" +
                    "Course = 3300250 OR " +
                    "Course = 3300252 OR " +
                    "Course = 3300281 OR " +
                    "Course = 3200361 OR " +
                    "Course = 3580350)", Literature);

                command.Parameters.Add(new SqlParameter("@Username", Globals.username));

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                adapter.Fill(dt);
                dgvLit.DataSource = dt;
            }

            using (SqlConnection AreaStudies = new SqlConnection(strConnect))
            {
                SqlCommand command =
                    new SqlCommand("SELECT * FROM MasterUserCourses WHERE Username = @Username AND ( " +
                    "Course = 2040254 OR " +
                    "Course = 2040257 OR " +
                    "Course = 2040258 OR " +
                    "Course = 2040256 OR " +
                    "Course = 3001201 OR " +
                    "Course = 3001200 OR " +
                    "Course = 3230251 OR " +
                    "Course = 7600325 OR " +
                    "Course = 3350275 OR " +
                    "Course = 3560210 OR " +
                    "Course = 3501210 OR " +
                    "Course = 3502210 OR " +
                    "Course = 3400285 OR " +
                    "Course = 3400286 OR " +
                    "Course = 3400287 OR " +
                    "Course = 3400288 OR " +
                    "Course = 3400289 OR " +
                    "Course = 3400290 OR " +
                    "Course = 3400291)", AreaStudies);

                command.Parameters.Add(new SqlParameter("@Username", Globals.username));

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                adapter.Fill(dt);
                dgvAreaStudies.DataSource = dt;
            }

            using (SqlConnection info = new SqlConnection(strConnect))
            {
                info.Open();
                SqlCommand loadMainInfo =
                    new SqlCommand("SELECT * FROM Main_Information WHERE Username = @Username", info);
                loadMainInfo.Parameters.Add(new SqlParameter("@Username", Globals.username));
                SqlDataReader dr = loadMainInfo.ExecuteReader();
                while (dr.Read())
                {
                    lblStanding.Text = (dr["Standing"].ToString()) + " Standing";
                    lblName.Text = (dr["First Name"].ToString()) + " " + (dr["Last Name"].ToString());
                    lblTotalHours.Text = (dr["Total_hours"].ToString());
                    lblType.Text = (dr["Degree_type"].ToString());
                    lblDegree.Text = (dr["Degree"].ToString());
                    lblCurrentHours.Text = (dr["Current_hours"].ToString());
                }
            }
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lblOralCommNav_Click(object sender, EventArgs e)
        {
            pnlGenEd.ScrollControlIntoView(lblOralComm);
        }

        private void lblEnglishNav_Click(object sender, EventArgs e)
        {
            pnlGenEd.ScrollControlIntoView(lblNatSci);
        }

        private void lblAreaStudiesNav_Click(object sender, EventArgs e)
        {
            pnlGenEd.ScrollControlIntoView(dgvAreaStudies);
        }

        private void lblMathNav_Click(object sender, EventArgs e)
        {
            pnlGenEd.ScrollControlIntoView(dgvBiology);
        }

        private void lblNatSciNav_Click(object sender, EventArgs e)
        {
            pnlGenEd.ScrollControlIntoView(dgvPhysics);
        }

        private void lblSocSciNav_Click(object sender, EventArgs e)
        {
            pnlGenEd.ScrollControlIntoView(dgvPsychology);
        }

        private void lblPhysEdNav_Click(object sender, EventArgs e)
        {
            pnlGenEd.ScrollControlIntoView(lblPhilClass);
        }

        private void lblHumanitiesNav_Click(object sender, EventArgs e)
        {
            pnlGenEd.ScrollControlIntoView(dgvLit);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.uakron.edu/advising/docs/General_Education_Guide.pdf");
        }
    }
}
