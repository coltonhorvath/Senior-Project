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
    public partial class Register_SocSci : Form
    {
        public Register_SocSci()
        {
            InitializeComponent();
        }

        private void Register_SocSci_Load(object sender, EventArgs e)
        {
            lblSocSci.Font = new Font(lblSocSci.Font, FontStyle.Bold);
        }

        private void Register_SocSci_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (checkIntroToEcon.Checked)
            {
                List<SqlParameter> sqlIntroToEcon = new List<SqlParameter>();
                sqlIntroToEcon.Add(new SqlParameter("Username", Globals.username));
                sqlIntroToEcon.Add(new SqlParameter("IntroToEconGrade", cboxIntroToEcon.Text));
                sqlIntroToEcon.Add(new SqlParameter("IntroToEconDescription", checkIntroToEcon.Text));

                if (cboxIntroToEcon.Text == "F")
                {
                    sqlIntroToEcon.Add(new SqlParameter("IntroToEconStatus", "Incomplete"));
                }
                else if (cboxIntroToEcon.Text == "")
                {
                    sqlIntroToEcon.Add(new SqlParameter("IntroToEconStatus", DBNull.Value));
                }
                else
                {
                    sqlIntroToEcon.Add(new SqlParameter("IntroToEconStatus", "Complete"));
                }

                DAL.ExecSP("CreateIntroToEcon", sqlIntroToEcon);
            }

            if (checkMicro.Checked)
            {
                List<SqlParameter> sqlMicro = new List<SqlParameter>();
                sqlMicro.Add(new SqlParameter("Username", Globals.username));
                sqlMicro.Add(new SqlParameter("MicroGrade", cboxMicro.Text));
                sqlMicro.Add(new SqlParameter("MicroDescription", checkMicro.Text));

                if (cboxMicro.Text == "F")
                {
                    sqlMicro.Add(new SqlParameter("MicroStatus", "Incomplete"));
                }
                else if (cboxMicro.Text == "")
                {
                    sqlMicro.Add(new SqlParameter("MicroStatus", DBNull.Value));
                }
                else
                {
                    sqlMicro.Add(new SqlParameter("MicroStatus", "Complete"));
                }

                DAL.ExecSP("CreateMicro", sqlMicro);
            }

            if (checkMacro.Checked)
            {
                List<SqlParameter> sqlMacro = new List<SqlParameter>();
                sqlMacro.Add(new SqlParameter("Username", Globals.username));
                sqlMacro.Add(new SqlParameter("MacroGrade", cboxMacro.Text));
                sqlMacro.Add(new SqlParameter("MacroDescription", checkMacro.Text));

                if (cboxMacro.Text == "F")
                {
                    sqlMacro.Add(new SqlParameter("MacroStatus", "Incomplete"));
                }
                else if (cboxMacro.Text == "")
                {
                    sqlMacro.Add(new SqlParameter("MacroStatus", DBNull.Value));
                }
                else
                {
                    sqlMacro.Add(new SqlParameter("MacroStatus", "Complete"));
                }

                DAL.ExecSP("CreateMacro", sqlMacro);
            }

            if (checkEconAnal.Checked)
            {
                List<SqlParameter> sqlEconAnal = new List<SqlParameter>();
                sqlEconAnal.Add(new SqlParameter("Username", Globals.username));
                sqlEconAnal.Add(new SqlParameter("EconAnalGrade", cboxEconAnal.Text));
                sqlEconAnal.Add(new SqlParameter("EconAnalDescription", checkEconAnal.Text));

                if (cboxEconAnal.Text == "F")
                {
                    sqlEconAnal.Add(new SqlParameter("EconAnalStatus", "Incomplete"));
                }
                else if (cboxEconAnal.Text == "")
                {
                    sqlEconAnal.Add(new SqlParameter("EconAnalStatus", DBNull.Value));
                }
                else
                {
                    sqlEconAnal.Add(new SqlParameter("EconAnalStatus", "Complete"));
                }

                DAL.ExecSP("CreateEconAnal", sqlEconAnal);
            }

            if (checkSurveyEcon.Checked)
            {
                List<SqlParameter> sqlSurveyEcon = new List<SqlParameter>();
                sqlSurveyEcon.Add(new SqlParameter("Username", Globals.username));
                sqlSurveyEcon.Add(new SqlParameter("SurveyEconGrade", cboxSurveyEcon.Text));
                sqlSurveyEcon.Add(new SqlParameter("SurveyEconDescription", checkSurveyEcon.Text));

                if (cboxSurveyEcon.Text == "F")
                {
                    sqlSurveyEcon.Add(new SqlParameter("SurveyEconStatus", "Incomplete"));
                }
                else if (cboxSurveyEcon.Text == "")
                {
                    sqlSurveyEcon.Add(new SqlParameter("SurveyEconStatus", DBNull.Value));
                }
                else
                {
                    sqlSurveyEcon.Add(new SqlParameter("SurveyEconStatus", "Complete"));
                }

                DAL.ExecSP("CreateSurveyEcon", sqlSurveyEcon);
            }

            if (checkIntroToGeography.Checked)
            {
                List<SqlParameter> sqlIntroToGeography = new List<SqlParameter>();
                sqlIntroToGeography.Add(new SqlParameter("Username", Globals.username));
                sqlIntroToGeography.Add(new SqlParameter("IntroToGeographyGrade", cboxIntroToGeography.Text));
                sqlIntroToGeography.Add(new SqlParameter("IntroToGeographyDescription", checkIntroToGeography.Text));

                if (cboxIntroToGeography.Text == "F")
                {
                    sqlIntroToGeography.Add(new SqlParameter("IntroToGeographyStatus", "Incomplete"));
                }
                else if (cboxIntroToGeography.Text == "")
                {
                    sqlIntroToGeography.Add(new SqlParameter("IntroToGeographyStatus", DBNull.Value));
                }
                else
                {
                    sqlIntroToGeography.Add(new SqlParameter("IntroToGeographyStatus", "Complete"));
                }

                DAL.ExecSP("CreateIntroToGeography", sqlIntroToGeography);
            }

            if (checkGovPoliUS.Checked)
            {
                List<SqlParameter> sqlGovPoliUS = new List<SqlParameter>();
                sqlGovPoliUS.Add(new SqlParameter("Username", Globals.username));
                sqlGovPoliUS.Add(new SqlParameter("GovPoliUSGrade", cboxGovPoliUS.Text));
                sqlGovPoliUS.Add(new SqlParameter("GovPoliUSDescription", checkGovPoliUS.Text));

                if (cboxGovPoliUS.Text == "F")
                {
                    sqlGovPoliUS.Add(new SqlParameter("GovPoliUSStatus", "Incomplete"));
                }
                else if (cboxGovPoliUS.Text == "")
                {
                    sqlGovPoliUS.Add(new SqlParameter("GovPoliUSStatus", DBNull.Value));
                }
                else
                {
                    sqlGovPoliUS.Add(new SqlParameter("GovPoliUSStatus", "Complete"));
                }

                DAL.ExecSP("CreateGovPoliUS", sqlGovPoliUS);
            }

            if (checkWorldPoli.Checked)
            {
                List<SqlParameter> sqlWorldPoli = new List<SqlParameter>();
                sqlWorldPoli.Add(new SqlParameter("Username", Globals.username));
                sqlWorldPoli.Add(new SqlParameter("WorldPoliGrade", cboxWorldPoli.Text));
                sqlWorldPoli.Add(new SqlParameter("WorldPoliDescription", checkWorldPoli.Text));

                if (cboxWorldPoli.Text == "F")
                {
                    sqlWorldPoli.Add(new SqlParameter("WorldPoliStatus", "Incomplete"));
                }
                else if (cboxWorldPoli.Text == "")
                {
                    sqlWorldPoli.Add(new SqlParameter("WorldPoliStatus", DBNull.Value));
                }
                else
                {
                    sqlWorldPoli.Add(new SqlParameter("WorldPoliStatus", "Complete"));
                }

                DAL.ExecSP("CreateWorldPoli", sqlWorldPoli);
            }

            if (checkUrbanSoc.Checked)
            {
                List<SqlParameter> sqlUrbanSoc = new List<SqlParameter>();
                sqlUrbanSoc.Add(new SqlParameter("Username", Globals.username));
                sqlUrbanSoc.Add(new SqlParameter("UrbanSocGrade", cboxUrbanSoc.Text));
                sqlUrbanSoc.Add(new SqlParameter("UrbanSocDescription", checkUrbanSoc.Text));

                if (cboxUrbanSoc.Text == "F")
                {
                    sqlUrbanSoc.Add(new SqlParameter("UrbanSocStatus", "Incomplete"));
                }
                else if (cboxUrbanSoc.Text == "")
                {
                    sqlUrbanSoc.Add(new SqlParameter("UrbanSocStatus", DBNull.Value));
                }
                else
                {
                    sqlUrbanSoc.Add(new SqlParameter("UrbanSocStatus", "Complete"));
                }

                DAL.ExecSP("CreateUrbanSoc", sqlUrbanSoc);
            }

            if (checkIntroToPsychology.Checked)
            {
                List<SqlParameter> sqlIntroToPsychology = new List<SqlParameter>();
                sqlIntroToPsychology.Add(new SqlParameter("Username", Globals.username));
                sqlIntroToPsychology.Add(new SqlParameter("IntroToPsychologyGrade", cboxIntroToPsychology.Text));
                sqlIntroToPsychology.Add(new SqlParameter("IntroToPsychologyDescription", checkIntroToPsychology.Text));

                if (cboxIntroToPsychology.Text == "F")
                {
                    sqlIntroToPsychology.Add(new SqlParameter("IntroToPsychologyStatus", "Incomplete"));
                }
                else if (cboxIntroToPsychology.Text == "")
                {
                    sqlIntroToPsychology.Add(new SqlParameter("IntroToPsychologyStatus", DBNull.Value));
                }
                else
                {
                    sqlIntroToPsychology.Add(new SqlParameter("IntroToPsychologyStatus", "Complete"));
                }

                DAL.ExecSP("CreateIntroToPsychology", sqlIntroToPsychology);
            }

            if (checkHumanRelations.Checked)
            {
                List<SqlParameter> sqlHumanRelations = new List<SqlParameter>();
                sqlHumanRelations.Add(new SqlParameter("Username", Globals.username));
                sqlHumanRelations.Add(new SqlParameter("HumanRelationsGrade", cboxHumanRelations.Text));
                sqlHumanRelations.Add(new SqlParameter("HumanRelationsDescription", checkHumanRelations.Text));

                if (cboxHumanRelations.Text == "F")
                {
                    sqlHumanRelations.Add(new SqlParameter("HumanRelationsStatus", "Incomplete"));
                }
                else if (cboxHumanRelations.Text == "")
                {
                    sqlHumanRelations.Add(new SqlParameter("HumanRelationsStatus", DBNull.Value));
                }
                else
                {
                    sqlHumanRelations.Add(new SqlParameter("HumanRelationsStatus", "Complete"));
                }

                DAL.ExecSP("CreateHumanRelations", sqlHumanRelations);
            }

            if (checkIntroToSociology.Checked)
            {
                List<SqlParameter> sqlIntroToSociology = new List<SqlParameter>();
                sqlIntroToSociology.Add(new SqlParameter("Username", Globals.username));
                sqlIntroToSociology.Add(new SqlParameter("IntroToSociologyGrade", cboxIntroToSociology.Text));
                sqlIntroToSociology.Add(new SqlParameter("IntroToSociologyDescription", checkIntroToSociology.Text));

                if (cboxIntroToSociology.Text == "F")
                {
                    sqlIntroToSociology.Add(new SqlParameter("IntroToSociologyStatus", "Incomplete"));
                }
                else if (cboxIntroToSociology.Text == "")
                {
                    sqlIntroToSociology.Add(new SqlParameter("IntroToSociologyStatus", DBNull.Value));
                }
                else
                {
                    sqlIntroToSociology.Add(new SqlParameter("IntroToSociologyStatus", "Complete"));
                }

                DAL.ExecSP("CreateIntroToSociology", sqlIntroToSociology);
            }

            if (checkHumanCultures.Checked)
            {
                List<SqlParameter> sqlHumanCultures = new List<SqlParameter>();
                sqlHumanCultures.Add(new SqlParameter("Username", Globals.username));
                sqlHumanCultures.Add(new SqlParameter("HumanCulturesGrade", cboxHumanCultures.Text));
                sqlHumanCultures.Add(new SqlParameter("HumanCulturesDescription", checkHumanCultures.Text));

                if (cboxHumanCultures.Text == "F")
                {
                    sqlHumanCultures.Add(new SqlParameter("HumanCulturesStatus", "Incomplete"));
                }
                else if (cboxHumanCultures.Text == "")
                {
                    sqlHumanCultures.Add(new SqlParameter("HumanCulturesStatus", DBNull.Value));
                }
                else
                {
                    sqlHumanCultures.Add(new SqlParameter("HumanCulturesStatus", "Complete"));
                }

                DAL.ExecSP("CreateHumanCultures", sqlHumanCultures);
            }

            if (checkDemInEd.Checked)
            {
                List<SqlParameter> sqlDemInEd = new List<SqlParameter>();
                sqlDemInEd.Add(new SqlParameter("Username", Globals.username));
                sqlDemInEd.Add(new SqlParameter("DemInEdGrade", cboxDemInEd.Text));
                sqlDemInEd.Add(new SqlParameter("DemInEdDescription", checkDemInEd.Text));

                if (cboxDemInEd.Text == "F")
                {
                    sqlDemInEd.Add(new SqlParameter("DemInEdStatus", "Incomplete"));
                }
                else if (cboxDemInEd.Text == "")
                {
                    sqlDemInEd.Add(new SqlParameter("DemInEdStatus", DBNull.Value));
                }
                else
                {
                    sqlDemInEd.Add(new SqlParameter("DemInEdStatus", "Complete"));
                }

                DAL.ExecSP("CreateDemInEd", sqlDemInEd);
            }

            if (checkDeathAndDying.Checked)
            {
                List<SqlParameter> sqlDeathAndDying = new List<SqlParameter>();
                sqlDeathAndDying.Add(new SqlParameter("Username", Globals.username));
                sqlDeathAndDying.Add(new SqlParameter("DeathAndDyingGrade", cboxDeathAndDying.Text));
                sqlDeathAndDying.Add(new SqlParameter("DeathAndDyingDescription", checkDeathAndDying.Text));

                if (cboxDeathAndDying.Text == "F")
                {
                    sqlDeathAndDying.Add(new SqlParameter("DeathAndDyingStatus", "Incomplete"));
                }
                else if (cboxDeathAndDying.Text == "")
                {
                    sqlDeathAndDying.Add(new SqlParameter("DeathAndDyingStatus", DBNull.Value));
                }
                else
                {
                    sqlDeathAndDying.Add(new SqlParameter("DeathAndDyingStatus", "Complete"));
                }

                DAL.ExecSP("CreateDeathAndDying", sqlDeathAndDying);
            }

            if (checkTo1877.Checked)
            {
                List<SqlParameter> sqlTo1877 = new List<SqlParameter>();
                sqlTo1877.Add(new SqlParameter("Username", Globals.username));
                sqlTo1877.Add(new SqlParameter("To1877Grade", cboxTo1877.Text));
                sqlTo1877.Add(new SqlParameter("To1877Description", checkTo1877.Text));

                if (cboxTo1877.Text == "F")
                {
                    sqlTo1877.Add(new SqlParameter("To1877Status", "Incomplete"));
                }
                else if (cboxTo1877.Text == "")
                {
                    sqlTo1877.Add(new SqlParameter("To1877Status", DBNull.Value));
                }
                else
                {
                    sqlTo1877.Add(new SqlParameter("To1877Status", "Complete"));
                }

                DAL.ExecSP("CreateTo1877", sqlTo1877);
            }

            if (checkSince1877.Checked)
            {
                List<SqlParameter> sqlSince1877 = new List<SqlParameter>();
                sqlSince1877.Add(new SqlParameter("Username", Globals.username));
                sqlSince1877.Add(new SqlParameter("Since1877Grade", cboxSince1877.Text));
                sqlSince1877.Add(new SqlParameter("Since1877Description", checkSince1877.Text));

                if (cboxSince1877.Text == "F")
                {
                    sqlSince1877.Add(new SqlParameter("Since1877Status", "Incomplete"));
                }
                else if (cboxSince1877.Text == "")
                {
                    sqlSince1877.Add(new SqlParameter("Since1877Status", DBNull.Value));
                }
                else
                {
                    sqlSince1877.Add(new SqlParameter("Since1877Status", "Complete"));
                }

                DAL.ExecSP("CreateSince1877", sqlSince1877);
            }

            if (checkTechHumanValues.Checked)
            {
                List<SqlParameter> sqlTechHumanValues = new List<SqlParameter>();
                sqlTechHumanValues.Add(new SqlParameter("Username", Globals.username));
                sqlTechHumanValues.Add(new SqlParameter("TechHumanValuesGrade", cboxTechHumanValues.Text));
                sqlTechHumanValues.Add(new SqlParameter("TechHumanValuesDescription", checkTechHumanValues.Text));

                if (cboxTechHumanValues.Text == "F")
                {
                    sqlTechHumanValues.Add(new SqlParameter("TechHumanValuesStatus", "Incomplete"));
                }
                else if (cboxTechHumanValues.Text == "")
                {
                    sqlTechHumanValues.Add(new SqlParameter("TechHumanValuesStatus", DBNull.Value));
                }
                else
                {
                    sqlTechHumanValues.Add(new SqlParameter("TechHumanValuesStatus", "Complete"));
                }

                DAL.ExecSP("CreateTechHumanValues", sqlTechHumanValues);
            }

            if (checkGlobalIssues.Checked)
            {
                List<SqlParameter> sqlGlobalIssues = new List<SqlParameter>();
                sqlGlobalIssues.Add(new SqlParameter("Username", Globals.username));
                sqlGlobalIssues.Add(new SqlParameter("GlobalIssuesGrade", cboxGlobalIssues.Text));
                sqlGlobalIssues.Add(new SqlParameter("GlobalIssuesDescription", checkGlobalIssues.Text));

                if (cboxGlobalIssues.Text == "F")
                {
                    sqlGlobalIssues.Add(new SqlParameter("GlobalIssuesStatus", "Incomplete"));
                }
                else if (cboxGlobalIssues.Text == "")
                {
                    sqlGlobalIssues.Add(new SqlParameter("GlobalIssuesStatus", DBNull.Value));
                }
                else
                {
                    sqlGlobalIssues.Add(new SqlParameter("GlobalIssuesStatus", "Complete"));
                }

                DAL.ExecSP("CreateGlobalIssues", sqlGlobalIssues);
            }

            if (checkIntroToArchaeology.Checked)
            {
                List<SqlParameter> sqlIntroToArchaeology = new List<SqlParameter>();
                sqlIntroToArchaeology.Add(new SqlParameter("Username", Globals.username));
                sqlIntroToArchaeology.Add(new SqlParameter("IntroToArchaeologyGrade", cboxIntroToArchaeology.Text));
                sqlIntroToArchaeology.Add(new SqlParameter("IntroToArchaeologyDescription", checkIntroToArchaeology.Text));

                if (cboxIntroToArchaeology.Text == "F")
                {
                    sqlIntroToArchaeology.Add(new SqlParameter("IntroToArchaeologyStatus", "Incomplete"));
                }
                else if (cboxIntroToArchaeology.Text == "")
                {
                    sqlIntroToArchaeology.Add(new SqlParameter("IntroToArchaeologyStatus", DBNull.Value));
                }
                else
                {
                    sqlIntroToArchaeology.Add(new SqlParameter("IntroToArchaeologyStatus", "Complete"));
                }

                DAL.ExecSP("CreateIntroToArchaeology", sqlIntroToArchaeology);
            }

            if (checkTheoryAndEvidence.Checked)
            {
                List<SqlParameter> sqlTheoryAndEvidence = new List<SqlParameter>();
                sqlTheoryAndEvidence.Add(new SqlParameter("Username", Globals.username));
                sqlTheoryAndEvidence.Add(new SqlParameter("TheoryAndEvidenceGrade", cboxTheoryAndEvidence.Text));
                sqlTheoryAndEvidence.Add(new SqlParameter("TheoryAndEvidenceDescription", checkTheoryAndEvidence.Text));

                if (cboxTheoryAndEvidence.Text == "F")
                {
                    sqlTheoryAndEvidence.Add(new SqlParameter("TheoryAndEvidenceStatus", "Incomplete"));
                }
                else if (cboxTheoryAndEvidence.Text == "")
                {
                    sqlTheoryAndEvidence.Add(new SqlParameter("TheoryAndEvidenceStatus", DBNull.Value));
                }
                else
                {
                    sqlTheoryAndEvidence.Add(new SqlParameter("TheoryAndEvidenceStatus", "Complete"));
                }

                DAL.ExecSP("CreateTheoryAndEvidence", sqlTheoryAndEvidence);
            }

            Register_PhysEd frmRegister_PhysEd = new Register_PhysEd();
            frmRegister_PhysEd.Show();
            this.Hide();
        }
    }
}
