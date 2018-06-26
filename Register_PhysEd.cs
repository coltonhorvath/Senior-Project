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
    public partial class Register_PhysEd : Form
    {
        public Register_PhysEd()
        {
            InitializeComponent();
        }

        private void Register_PhysEd_Load(object sender, EventArgs e)
        {
            lblPhysEd.Font = new Font(lblPhysEd.Font, FontStyle.Bold);
        }

        private void Register_PhysEd_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (checkEmergencyResponder1.Checked)
            {
                List<SqlParameter> sqlEmergencyResponder1 = new List<SqlParameter>();
                sqlEmergencyResponder1.Add(new SqlParameter("Username", Globals.username));
                sqlEmergencyResponder1.Add(new SqlParameter("EmergencyResponder1Grade", cboxEmergencyResponder1.Text));
                sqlEmergencyResponder1.Add(new SqlParameter("EmergencyResponder1Description", checkEmergencyResponder1.Text));

                if (cboxEmergencyResponder1.Text == "F")
                {
                    sqlEmergencyResponder1.Add(new SqlParameter("EmergencyResponder1Status", "Incomplete"));
                }
                else if (cboxEmergencyResponder1.Text == "")
                {
                    sqlEmergencyResponder1.Add(new SqlParameter("EmergencyResponder1Status", DBNull.Value));
                }
                else
                {
                    sqlEmergencyResponder1.Add(new SqlParameter("EmergencyResponder1Status", "Complete"));
                }

                DAL.ExecSP("CreateEmergencyResponder1", sqlEmergencyResponder1);
            }

            if (checkPhysicalEducation.Checked)
            {
                List<SqlParameter> sqlPhysicalEducation = new List<SqlParameter>();
                sqlPhysicalEducation.Add(new SqlParameter("Username", Globals.username));
                sqlPhysicalEducation.Add(new SqlParameter("PhysicalEducationGrade", cboxPhysicalEducation.Text));
                sqlPhysicalEducation.Add(new SqlParameter("PhysicalEducationDescription", checkPhysicalEducation.Text));

                if (cboxPhysicalEducation.Text == "F")
                {
                    sqlPhysicalEducation.Add(new SqlParameter("PhysicalEducationStatus", "Incomplete"));
                }
                else if (cboxPhysicalEducation.Text == "")
                {
                    sqlPhysicalEducation.Add(new SqlParameter("PhysicalEducationStatus", DBNull.Value));
                }
                else
                {
                    sqlPhysicalEducation.Add(new SqlParameter("PhysicalEducationStatus", "Complete"));
                }

                DAL.ExecSP("CreatePhysicalEducation", sqlPhysicalEducation);
            }

            if (checkIntroductionToSportsStudies.Checked)
            {
                List<SqlParameter> sqlIntroductionToSportsStudies = new List<SqlParameter>();
                sqlIntroductionToSportsStudies.Add(new SqlParameter("Username", Globals.username));
                sqlIntroductionToSportsStudies.Add(new SqlParameter("IntroductionToSportsStudiesGrade", cboxIntroductionToSportsStudies.Text));
                sqlIntroductionToSportsStudies.Add(new SqlParameter("IntroductionToSportsStudiesDescription", checkIntroductionToSportsStudies.Text));

                if (cboxIntroductionToSportsStudies.Text == "F")
                {
                    sqlIntroductionToSportsStudies.Add(new SqlParameter("IntroductionToSportsStudiesStatus", "Incomplete"));
                }
                else if (cboxIntroductionToSportsStudies.Text == "")
                {
                    sqlIntroductionToSportsStudies.Add(new SqlParameter("IntroductionToSportsStudiesStatus", DBNull.Value));
                }
                else
                {
                    sqlIntroductionToSportsStudies.Add(new SqlParameter("IntroductionToSportsStudiesStatus", "Complete"));
                }

                DAL.ExecSP("CreateIntroductionToSportsStudies", sqlIntroductionToSportsStudies);
            }

            if (checkConceptsOfHealthAndFitness.Checked)
            {
                List<SqlParameter> sqlConceptsOfHealthAndFitness = new List<SqlParameter>();
                sqlConceptsOfHealthAndFitness.Add(new SqlParameter("Username", Globals.username));
                sqlConceptsOfHealthAndFitness.Add(new SqlParameter("ConceptsOfHealthAndFitnessGrade", cboxConceptsOfHealthAndFitness.Text));
                sqlConceptsOfHealthAndFitness.Add(new SqlParameter("ConceptsOfHealthAndFitnessDescription", checkConceptsOfHealthAndFitness.Text));

                if (cboxConceptsOfHealthAndFitness.Text == "F")
                {
                    sqlConceptsOfHealthAndFitness.Add(new SqlParameter("ConceptsOfHealthAndFitnessStatus", "Incomplete"));
                }
                else if (cboxConceptsOfHealthAndFitness.Text == "")
                {
                    sqlConceptsOfHealthAndFitness.Add(new SqlParameter("ConceptsOfHealthAndFitnessStatus", DBNull.Value));
                }
                else
                {
                    sqlConceptsOfHealthAndFitness.Add(new SqlParameter("ConceptsOfHealthAndFitnessStatus", "Complete"));
                }

                DAL.ExecSP("CreateConceptsOfHealthAndFitness", sqlConceptsOfHealthAndFitness);
            }

            if (checkSportsOfficiating.Checked)
            {
                List<SqlParameter> sqlSportsOfficiating = new List<SqlParameter>();
                sqlSportsOfficiating.Add(new SqlParameter("Username", Globals.username));
                sqlSportsOfficiating.Add(new SqlParameter("SportsOfficiatingGrade", cboxSportsOfficiating.Text));
                sqlSportsOfficiating.Add(new SqlParameter("SportsOfficiatingDescription", checkSportsOfficiating.Text));

                if (cboxSportsOfficiating.Text == "F")
                {
                    sqlSportsOfficiating.Add(new SqlParameter("SportsOfficiatingStatus", "Incomplete"));
                }
                else if (cboxSportsOfficiating.Text == "")
                {
                    sqlSportsOfficiating.Add(new SqlParameter("SportsOfficiatingStatus", DBNull.Value));
                }
                else
                {
                    sqlSportsOfficiating.Add(new SqlParameter("SportsOfficiatingStatus", "Complete"));
                }

                DAL.ExecSP("CreateSportsOfficiating", sqlSportsOfficiating);
            }

            if (checkFirstAidAndCardRes.Checked)
            {
                List<SqlParameter> sqlFirstAidAndCardRes = new List<SqlParameter>();
                sqlFirstAidAndCardRes.Add(new SqlParameter("Username", Globals.username));
                sqlFirstAidAndCardRes.Add(new SqlParameter("FirstAidAndCardResGrade", cboxFirstAidAndCardRes.Text));
                sqlFirstAidAndCardRes.Add(new SqlParameter("FirstAidAndCardResDescription", checkFirstAidAndCardRes.Text));

                if (cboxFirstAidAndCardRes.Text == "F")
                {
                    sqlFirstAidAndCardRes.Add(new SqlParameter("FirstAidAndCardResStatus", "Incomplete"));
                }
                else if (cboxFirstAidAndCardRes.Text == "")
                {
                    sqlFirstAidAndCardRes.Add(new SqlParameter("FirstAidAndCardResStatus", DBNull.Value));
                }
                else
                {
                    sqlFirstAidAndCardRes.Add(new SqlParameter("FirstAidAndCardResStatus", "Complete"));
                }

                DAL.ExecSP("CreateFirstAidAndCardRes", sqlFirstAidAndCardRes);
            }

            if (checkPersonalHealth.Checked)
            {
                List<SqlParameter> sqlPersonalHealth = new List<SqlParameter>();
                sqlPersonalHealth.Add(new SqlParameter("Username", Globals.username));
                sqlPersonalHealth.Add(new SqlParameter("PersonalHealthGrade", cboxPersonalHealth.Text));
                sqlPersonalHealth.Add(new SqlParameter("PersonalHealthDescription", checkPersonalHealth.Text));

                if (cboxPersonalHealth.Text == "F")
                {
                    sqlPersonalHealth.Add(new SqlParameter("PersonalHealthStatus", "Incomplete"));
                }
                else if (cboxPersonalHealth.Text == "")
                {
                    sqlPersonalHealth.Add(new SqlParameter("PersonalHealthStatus", DBNull.Value));
                }
                else
                {
                    sqlPersonalHealth.Add(new SqlParameter("PersonalHealthStatus", "Complete"));
                }

                DAL.ExecSP("CreatePersonalHealth", sqlPersonalHealth);
            }

            if (checkNutritionFundamentals.Checked)
            {
                List<SqlParameter> sqlNutritionFundamentals = new List<SqlParameter>();
                sqlNutritionFundamentals.Add(new SqlParameter("Username", Globals.username));
                sqlNutritionFundamentals.Add(new SqlParameter("NutritionFundamentalsGrade", cboxNutritionFundamentals.Text));
                sqlNutritionFundamentals.Add(new SqlParameter("NutritionFundamentalsDescription", checkNutritionFundamentals.Text));

                if (cboxNutritionFundamentals.Text == "F")
                {
                    sqlNutritionFundamentals.Add(new SqlParameter("NutritionFundamentalsStatus", "Incomplete"));
                }
                else if (cboxNutritionFundamentals.Text == "")
                {
                    sqlNutritionFundamentals.Add(new SqlParameter("NutritionFundamentalsStatus", DBNull.Value));
                }
                else
                {
                    sqlNutritionFundamentals.Add(new SqlParameter("NutritionFundamentalsStatus", "Complete"));
                }

                DAL.ExecSP("CreateNutritionFundamentals", sqlNutritionFundamentals);
            }

            if (checkMarchingBand.Checked)
            {
                List<SqlParameter> sqlMarchingBand = new List<SqlParameter>();
                sqlMarchingBand.Add(new SqlParameter("Username", Globals.username));
                sqlMarchingBand.Add(new SqlParameter("MarchingBandGrade", cboxMarchingBand.Text));
                sqlMarchingBand.Add(new SqlParameter("MarchingBandDescription", checkMarchingBand.Text));

                if (cboxMarchingBand.Text == "F")
                {
                    sqlMarchingBand.Add(new SqlParameter("MarchingBandStatus", "Incomplete"));
                }
                else if (cboxMarchingBand.Text == "")
                {
                    sqlMarchingBand.Add(new SqlParameter("MarchingBandStatus", DBNull.Value));
                }
                else
                {
                    sqlMarchingBand.Add(new SqlParameter("MarchingBandStatus", "Complete"));
                }

                DAL.ExecSP("CreateMarchingBand", sqlMarchingBand);
            }

            if (checkIntroToModernDance1.Checked)
            {
                List<SqlParameter> sqlIntroToModernDance1 = new List<SqlParameter>();
                sqlIntroToModernDance1.Add(new SqlParameter("Username", Globals.username));
                sqlIntroToModernDance1.Add(new SqlParameter("IntroToModernDance1Grade", cboxIntroToModernDance1.Text));
                sqlIntroToModernDance1.Add(new SqlParameter("IntroToModernDance1Description", checkIntroToModernDance1.Text));

                if (cboxIntroToModernDance1.Text == "F")
                {
                    sqlIntroToModernDance1.Add(new SqlParameter("IntroToModernDance1Status", "Incomplete"));
                }
                else if (cboxIntroToModernDance1.Text == "")
                {
                    sqlIntroToModernDance1.Add(new SqlParameter("IntroToModernDance1Status", DBNull.Value));
                }
                else
                {
                    sqlIntroToModernDance1.Add(new SqlParameter("IntroToModernDance1Status", "Complete"));
                }

                DAL.ExecSP("CreateIntroToModernDance1", sqlIntroToModernDance1);
            }

            if (checkIntroToModernDance2.Checked)
            {
                List<SqlParameter> sqlIntroToModernDance2 = new List<SqlParameter>();
                sqlIntroToModernDance2.Add(new SqlParameter("Username", Globals.username));
                sqlIntroToModernDance2.Add(new SqlParameter("IntroToModernDance2Grade", cboxIntroToModernDance2.Text));
                sqlIntroToModernDance2.Add(new SqlParameter("IntroToModernDance2Description", checkIntroToModernDance2.Text));

                if (cboxIntroToModernDance2.Text == "F")
                {
                    sqlIntroToModernDance2.Add(new SqlParameter("IntroToModernDance2Status", "Incomplete"));
                }
                else if (cboxIntroToModernDance2.Text == "")
                {
                    sqlIntroToModernDance2.Add(new SqlParameter("IntroToModernDance2Status", DBNull.Value));
                }
                else
                {
                    sqlIntroToModernDance2.Add(new SqlParameter("IntroToModernDance2Status", "Complete"));
                }

                DAL.ExecSP("CreateIntroToModernDance2", sqlIntroToModernDance2);
            }

            if (checkIntroToBallet1.Checked)
            {
                List<SqlParameter> sqlIntroToBallet1 = new List<SqlParameter>();
                sqlIntroToBallet1.Add(new SqlParameter("Username", Globals.username));
                sqlIntroToBallet1.Add(new SqlParameter("IntroToBallet1Grade", cboxIntroToBallet1.Text));
                sqlIntroToBallet1.Add(new SqlParameter("IntroToBallet1Description", checkIntroToBallet1.Text));

                if (cboxIntroToBallet1.Text == "F")
                {
                    sqlIntroToBallet1.Add(new SqlParameter("IntroToBallet1Status", "Incomplete"));
                }
                else if (cboxIntroToBallet1.Text == "")
                {
                    sqlIntroToBallet1.Add(new SqlParameter("IntroToBallet1Status", DBNull.Value));
                }
                else
                {
                    sqlIntroToBallet1.Add(new SqlParameter("IntroToBallet1Status", "Complete"));
                }

                DAL.ExecSP("CreateIntroToBallet1", sqlIntroToBallet1);
            }

            if (checkIntroToBallet2.Checked)
            {
                List<SqlParameter> sqlIntroToBallet2 = new List<SqlParameter>();
                sqlIntroToBallet2.Add(new SqlParameter("Username", Globals.username));
                sqlIntroToBallet2.Add(new SqlParameter("IntroToBallet2Grade", cboxIntroToBallet2.Text));
                sqlIntroToBallet2.Add(new SqlParameter("IntroToBallet2Description", checkIntroToBallet2.Text));

                if (cboxIntroToBallet2.Text == "F")
                {
                    sqlIntroToBallet2.Add(new SqlParameter("IntroToBallet2Status", "Incomplete"));
                }
                else if (cboxIntroToBallet2.Text == "")
                {
                    sqlIntroToBallet2.Add(new SqlParameter("IntroToBallet2Status", DBNull.Value));
                }
                else
                {
                    sqlIntroToBallet2.Add(new SqlParameter("IntroToBallet2Status", "Complete"));
                }

                DAL.ExecSP("CreateIntroToBallet2", sqlIntroToBallet2);
            }

            if (checkIntroToJazzDance1.Checked)
            {
                List<SqlParameter> sqlIntroToJazzDance1 = new List<SqlParameter>();
                sqlIntroToJazzDance1.Add(new SqlParameter("Username", Globals.username));
                sqlIntroToJazzDance1.Add(new SqlParameter("IntroToJazzDance1Grade", cboxIntroToJazzDance1.Text));
                sqlIntroToJazzDance1.Add(new SqlParameter("IntroToJazzDance1Description", checkIntroToJazzDance1.Text));

                if (cboxIntroToJazzDance1.Text == "F")
                {
                    sqlIntroToJazzDance1.Add(new SqlParameter("IntroToJazzDance1Status", "Incomplete"));
                }
                else if (cboxIntroToJazzDance1.Text == "")
                {
                    sqlIntroToJazzDance1.Add(new SqlParameter("IntroToJazzDance1Status", DBNull.Value));
                }
                else
                {
                    sqlIntroToJazzDance1.Add(new SqlParameter("IntroToJazzDance1Status", "Complete"));
                }

                DAL.ExecSP("CreateIntroToJazzDance1", sqlIntroToJazzDance1);
            }

            if (checkIntroToJazzDance2.Checked)
            {
                List<SqlParameter> sqlIntroToJazzDance2 = new List<SqlParameter>();
                sqlIntroToJazzDance2.Add(new SqlParameter("Username", Globals.username));
                sqlIntroToJazzDance2.Add(new SqlParameter("IntroToJazzDance2Grade", cboxIntroToJazzDance2.Text));
                sqlIntroToJazzDance2.Add(new SqlParameter("IntroToJazzDance2Description", checkIntroToJazzDance2.Text));

                if (cboxIntroToJazzDance2.Text == "F")
                {
                    sqlIntroToJazzDance2.Add(new SqlParameter("IntroToJazzDance2Status", "Incomplete"));
                }
                else if (cboxIntroToJazzDance2.Text == "")
                {
                    sqlIntroToJazzDance2.Add(new SqlParameter("IntroToJazzDance2Status", DBNull.Value));
                }
                else
                {
                    sqlIntroToJazzDance2.Add(new SqlParameter("IntroToJazzDance2Status", "Complete"));
                }

                DAL.ExecSP("CreateIntroToJazzDance2", sqlIntroToJazzDance2);
            }

            if (checkTapDance1.Checked)
            {
                List<SqlParameter> sqlTapDance1 = new List<SqlParameter>();
                sqlTapDance1.Add(new SqlParameter("Username", Globals.username));
                sqlTapDance1.Add(new SqlParameter("TapDance1Grade", cboxTapDance1.Text));
                sqlTapDance1.Add(new SqlParameter("TapDance1Description", checkTapDance1.Text));

                if (cboxTapDance1.Text == "F")
                {
                    sqlTapDance1.Add(new SqlParameter("TapDance1Status", "Incomplete"));
                }
                else if (cboxTapDance1.Text == "")
                {
                    sqlTapDance1.Add(new SqlParameter("TapDance1Status", DBNull.Value));
                }
                else
                {
                    sqlTapDance1.Add(new SqlParameter("TapDance1Status", "Complete"));
                }

                DAL.ExecSP("CreateTapDance1", sqlTapDance1);
            }

            Register_Humanities frmRegister_Humanities = new Register_Humanities();
            frmRegister_Humanities.Show();
            this.Hide();
        }
    }
}
