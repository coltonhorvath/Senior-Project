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
    public partial class Register_English : Form
    {
        public Register_English()
        {
            InitializeComponent();
        }

        private void Register_English_Load(object sender, EventArgs e)
        {
            lblEnglish.Font = new Font(lblEnglish.Font, FontStyle.Bold);
        }

        private void Register_English_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (checkEnglishCompandWorkshop.Checked)
            {
                List<SqlParameter> sqlEnglishCompandWorkshop = new List<SqlParameter>();
                sqlEnglishCompandWorkshop.Add(new SqlParameter("Username", Globals.username));
                sqlEnglishCompandWorkshop.Add(new SqlParameter("EnglishCompandWorkshopGrade", cboxEnglishCompandWorkshop.Text));
                sqlEnglishCompandWorkshop.Add(new SqlParameter("EnglishCompandWorkshopDescription", checkEnglishCompandWorkshop.Text));

                if (cboxEnglishCompandWorkshop.Text == "F")
                {
                    sqlEnglishCompandWorkshop.Add(new SqlParameter("EnglishCompandWorkshopStatus", "Incomplete"));
                }
                else if (cboxEnglishCompandWorkshop.Text == "")
                {
                    sqlEnglishCompandWorkshop.Add(new SqlParameter("EnglishCompandWorkshopStatus", DBNull.Value));
                }
                else
                {
                    sqlEnglishCompandWorkshop.Add(new SqlParameter("EnglishCompandWorkshopStatus", "Complete"));
                }

                DAL.ExecSP("CreateEnglishCompandWorkshop", sqlEnglishCompandWorkshop);
            }

            if (checkEnglishComposition1.Checked)
            {
                List<SqlParameter> sqlEnglishComposition1 = new List<SqlParameter>();
                sqlEnglishComposition1.Add(new SqlParameter("Username", Globals.username));
                sqlEnglishComposition1.Add(new SqlParameter("EnglishComposition1Grade", cboxEnglishComposition1.Text));
                sqlEnglishComposition1.Add(new SqlParameter("EnglishComposition1Description", checkEnglishComposition1.Text));

                if (cboxEnglishComposition1.Text == "F")
                {
                    sqlEnglishComposition1.Add(new SqlParameter("EnglishComposition1Status", "Incomplete"));
                }
                else if (cboxEnglishComposition1.Text == "")
                {
                    sqlEnglishComposition1.Add(new SqlParameter("EnglishComposition1Status", DBNull.Value));
                }
                else
                {
                    sqlEnglishComposition1.Add(new SqlParameter("EnglishComposition1Status", "Complete"));
                }

                DAL.ExecSP("CreateEnglishComposition1", sqlEnglishComposition1);
            }

            if (checkAfricanAmericanLang.Checked)
            {
                List<SqlParameter> sqlAfricanAmericanLang = new List<SqlParameter>();
                sqlAfricanAmericanLang.Add(new SqlParameter("Username", Globals.username));
                sqlAfricanAmericanLang.Add(new SqlParameter("AfricanAmericanLangGrade", cboxAfricanAmericanLang.Text));
                sqlAfricanAmericanLang.Add(new SqlParameter("AfricanAmericanLangDescription", checkAfricanAmericanLang.Text));

                if (cboxAfricanAmericanLang.Text == "F")
                {
                    sqlAfricanAmericanLang.Add(new SqlParameter("AfricanAmericanLangStatus", "Incomplete"));
                }
                else if (cboxAfricanAmericanLang.Text == "")
                {
                    sqlAfricanAmericanLang.Add(new SqlParameter("AfricanAmericanLangStatus", DBNull.Value));
                }
                else
                {
                    sqlAfricanAmericanLang.Add(new SqlParameter("AfricanAmericanLangStatus", "Complete"));
                }

                DAL.ExecSP("CreateAfricanAmericanLang", sqlAfricanAmericanLang);
            }

            if (checkEnglish.Checked)
            {
                List<SqlParameter> sqlEnglish = new List<SqlParameter>();
                sqlEnglish.Add(new SqlParameter("Username", Globals.username));
                sqlEnglish.Add(new SqlParameter("EnglishGrade", cboxEnglish.Text));
                sqlEnglish.Add(new SqlParameter("EnglishDescription", checkEnglish.Text));

                if (cboxEnglish.Text == "F")
                {
                    sqlEnglish.Add(new SqlParameter("EnglishStatus", "Incomplete"));
                }
                else if (cboxEnglish.Text == "")
                {
                    sqlEnglish.Add(new SqlParameter("EnglishStatus", DBNull.Value));
                }
                else
                {
                    sqlEnglish.Add(new SqlParameter("EnglishStatus", "Complete"));
                }

                DAL.ExecSP("CreateEnglish", sqlEnglish);
            }

            if (checkEnglishComposition2.Checked)
            {
                List<SqlParameter> sqlEnglishComposition2 = new List<SqlParameter>();
                sqlEnglishComposition2.Add(new SqlParameter("Username", Globals.username));
                sqlEnglishComposition2.Add(new SqlParameter("EnglishComposition2Grade", cboxEnglishComposition2.Text));
                sqlEnglishComposition2.Add(new SqlParameter("EnglishComposition2Description", checkEnglishComposition2.Text));

                if (cboxEnglishComposition2.Text == "F")
                {
                    sqlEnglishComposition2.Add(new SqlParameter("EnglishComposition2Status", "Incomplete"));
                }
                else if (cboxEnglishComposition2.Text == "")
                {
                    sqlEnglishComposition2.Add(new SqlParameter("EnglishComposition2Status", DBNull.Value));
                }
                else
                {
                    sqlEnglishComposition2.Add(new SqlParameter("EnglishComposition2Status", "Complete"));
                }

                DAL.ExecSP("CreateEnglishComposition2", sqlEnglishComposition2);
            }

            if (checkAfricanAmericanLang2.Checked)
            {
                List<SqlParameter> sqlAfricanAmericanLang2 = new List<SqlParameter>();
                sqlAfricanAmericanLang2.Add(new SqlParameter("Username", Globals.username));
                sqlAfricanAmericanLang2.Add(new SqlParameter("AfricanAmericanLang2Grade", cboxAfricanAmericanLang2.Text));
                sqlAfricanAmericanLang2.Add(new SqlParameter("AfricanAmericanLang2Description", checkAfricanAmericanLang2.Text));

                if (cboxAfricanAmericanLang2.Text == "F")
                {
                    sqlAfricanAmericanLang2.Add(new SqlParameter("AfricanAmericanLang2Status", "Incomplete"));
                }
                else if (cboxAfricanAmericanLang2.Text == "")
                {
                    sqlAfricanAmericanLang2.Add(new SqlParameter("AfricanAmericanLang2Status", DBNull.Value));
                }
                else
                {
                    sqlAfricanAmericanLang2.Add(new SqlParameter("AfricanAmericanLang2Status", "Complete"));
                }

                DAL.ExecSP("CreateAfricanAmericanLang2", sqlAfricanAmericanLang2);
            }
            if (checkTechReportWriting.Checked)
            {
                List<SqlParameter> sqlTechReportWriting = new List<SqlParameter>();
                sqlTechReportWriting.Add(new SqlParameter("Username", Globals.username));
                sqlTechReportWriting.Add(new SqlParameter("TechReportWritingGrade", cboxTechReportWriting.Text));
                sqlTechReportWriting.Add(new SqlParameter("TechReportWritingDescription", checkTechReportWriting.Text));

                if (cboxTechReportWriting.Text == "F")
                {
                    sqlTechReportWriting.Add(new SqlParameter("TechReportWritingStatus", "Incomplete"));
                }
                else if (cboxTechReportWriting.Text == "")
                {
                    sqlTechReportWriting.Add(new SqlParameter("TechReportWritingStatus", DBNull.Value));
                }
                else
                {
                    sqlTechReportWriting.Add(new SqlParameter("TechReportWritingStatus", "Complete"));
                }

                DAL.ExecSP("CreateTechReportWriting", sqlTechReportWriting);
            }

            Register_Mathmatics frmRegister_Mathmatics = new Register_Mathmatics();
            frmRegister_Mathmatics.Show();
            this.Hide();
        }
    }
}
