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
    public partial class Register_Humanities : Form
    {
        public Register_Humanities()
        {
            InitializeComponent();
        }

        private void tabPagePhilClass_Click(object sender, EventArgs e)
        {

        }

        private void Register_Humanities_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Register_Humanities_Load(object sender, EventArgs e)
        {
            lblHumanities.Font = new Font(lblHumanities.Font, FontStyle.Bold);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (checkHumanitiesBefore.Checked)
            {
                List<SqlParameter> sqlHumanitiesBefore = new List<SqlParameter>();
                sqlHumanitiesBefore.Add(new SqlParameter("Username", Globals.username));
                sqlHumanitiesBefore.Add(new SqlParameter("HumanitiesBeforeGrade", cboxHumanitiesBefore.Text));
                sqlHumanitiesBefore.Add(new SqlParameter("HumanitiesBeforeDescription", checkHumanitiesBefore.Text));

                if (cboxHumanitiesBefore.Text == "F")
                {
                    sqlHumanitiesBefore.Add(new SqlParameter("HumanitiesBeforeStatus", "Incomplete"));
                }
                else if (cboxHumanitiesBefore.Text == "")
                {
                    sqlHumanitiesBefore.Add(new SqlParameter("HumanitiesBeforeStatus", DBNull.Value));
                }
                else
                {
                    sqlHumanitiesBefore.Add(new SqlParameter("HumanitiesBeforeStatus", "Complete"));
                }

                DAL.ExecSP("CreateHumanitiesBefore", sqlHumanitiesBefore);
            }

            if (checkHumanitiesAfter.Checked)
            {
                List<SqlParameter> sqlHumanitiesAfter = new List<SqlParameter>();
                sqlHumanitiesAfter.Add(new SqlParameter("Username", Globals.username));
                sqlHumanitiesAfter.Add(new SqlParameter("HumanitiesAfterGrade", cboxHumanitiesAfter.Text));
                sqlHumanitiesAfter.Add(new SqlParameter("HumanitiesAfterDescription", checkHumanitiesAfter.Text));

                if (cboxHumanitiesAfter.Text == "F")
                {
                    sqlHumanitiesAfter.Add(new SqlParameter("HumanitiesAfterStatus", "Incomplete"));
                }
                else if (cboxHumanitiesAfter.Text == "")
                {
                    sqlHumanitiesAfter.Add(new SqlParameter("HumanitiesAfterStatus", DBNull.Value));
                }
                else
                {
                    sqlHumanitiesAfter.Add(new SqlParameter("HumanitiesAfterStatus", "Complete"));
                }

                DAL.ExecSP("CreateHumanitiesAfter", sqlHumanitiesAfter);
            }

            if (checkVisualArts.Checked)
            {
                List<SqlParameter> sqlVisualArts = new List<SqlParameter>();
                sqlVisualArts.Add(new SqlParameter("Username", Globals.username));
                sqlVisualArts.Add(new SqlParameter("VisualArtsGrade", cboxVisualArts.Text));
                sqlVisualArts.Add(new SqlParameter("VisualArtsDescription", checkVisualArts.Text));

                if (cboxVisualArts.Text == "F")
                {
                    sqlVisualArts.Add(new SqlParameter("VisualArtsStatus", "Incomplete"));
                }
                else if (cboxVisualArts.Text == "")
                {
                    sqlVisualArts.Add(new SqlParameter("VisualArtsStatus", DBNull.Value));
                }
                else
                {
                    sqlVisualArts.Add(new SqlParameter("VisualArtsStatus", "Complete"));
                }

                DAL.ExecSP("CreateVisualArts", sqlVisualArts);
            }

            if (checkExploringMusic.Checked)
            {
                List<SqlParameter> sqlExploringMusic = new List<SqlParameter>();
                sqlExploringMusic.Add(new SqlParameter("Username", Globals.username));
                sqlExploringMusic.Add(new SqlParameter("ExploringMusicGrade", cboxExploringMusic.Text));
                sqlExploringMusic.Add(new SqlParameter("ExploringMusicDescription", checkExploringMusic.Text));

                if (cboxExploringMusic.Text == "F")
                {
                    sqlExploringMusic.Add(new SqlParameter("ExploringMusicStatus", "Incomplete"));
                }
                else if (cboxExploringMusic.Text == "")
                {
                    sqlExploringMusic.Add(new SqlParameter("ExploringMusicStatus", DBNull.Value));
                }
                else
                {
                    sqlExploringMusic.Add(new SqlParameter("ExploringMusicStatus", "Complete"));
                }

                DAL.ExecSP("CreateExploringMusic", sqlExploringMusic);
            }

            if (checkIntroToTheatre.Checked)
            {
                List<SqlParameter> sqlIntroToTheatre = new List<SqlParameter>();
                sqlIntroToTheatre.Add(new SqlParameter("Username", Globals.username));
                sqlIntroToTheatre.Add(new SqlParameter("IntroToTheatreGrade", cboxIntroToTheatre.Text));
                sqlIntroToTheatre.Add(new SqlParameter("IntroToTheatreDescription", checkIntroToTheatre.Text));

                if (cboxIntroToTheatre.Text == "F")
                {
                    sqlIntroToTheatre.Add(new SqlParameter("IntroToTheatreStatus", "Incomplete"));
                }
                else if (cboxIntroToTheatre.Text == "")
                {
                    sqlIntroToTheatre.Add(new SqlParameter("IntroToTheatreStatus", DBNull.Value));
                }
                else
                {
                    sqlIntroToTheatre.Add(new SqlParameter("IntroToTheatreStatus", "Complete"));
                }

                DAL.ExecSP("CreateIntroToTheatre", sqlIntroToTheatre);
            }

            if (checkViewingDance.Checked)
            {
                List<SqlParameter> sqlViewingDance = new List<SqlParameter>();
                sqlViewingDance.Add(new SqlParameter("Username", Globals.username));
                sqlViewingDance.Add(new SqlParameter("ViewingDanceGrade", cboxViewingDance.Text));
                sqlViewingDance.Add(new SqlParameter("ViewingDanceDescription", checkViewingDance.Text));

                if (cboxViewingDance.Text == "F")
                {
                    sqlViewingDance.Add(new SqlParameter("ViewingDanceStatus", "Incomplete"));
                }
                else if (cboxViewingDance.Text == "")
                {
                    sqlViewingDance.Add(new SqlParameter("ViewingDanceStatus", DBNull.Value));
                }
                else
                {
                    sqlViewingDance.Add(new SqlParameter("ViewingDanceStatus", "Complete"));
                }

                DAL.ExecSP("CreateViewingDance", sqlViewingDance);
            }

            if (checkIntroToAncientWorld.Checked)
            {
                List<SqlParameter> sqlIntroToAncientWorld = new List<SqlParameter>();
                sqlIntroToAncientWorld.Add(new SqlParameter("Username", Globals.username));
                sqlIntroToAncientWorld.Add(new SqlParameter("IntroToAncientWorldGrade", cboxIntroToAncientWorld.Text));
                sqlIntroToAncientWorld.Add(new SqlParameter("IntroToAncientWorldDescription", checkIntroToAncientWorld.Text));

                if (cboxIntroToAncientWorld.Text == "F")
                {
                    sqlIntroToAncientWorld.Add(new SqlParameter("IntroToAncientWorldStatus", "Incomplete"));
                }
                else if (cboxIntroToAncientWorld.Text == "")
                {
                    sqlIntroToAncientWorld.Add(new SqlParameter("IntroToAncientWorldStatus", DBNull.Value));
                }
                else
                {
                    sqlIntroToAncientWorld.Add(new SqlParameter("IntroToAncientWorldStatus", "Complete"));
                }

                DAL.ExecSP("CreateIntroToAncientWorld", sqlIntroToAncientWorld);
            }

            if (checkSportsAndSocInAncGreece.Checked)
            {
                List<SqlParameter> sqlSportsAndSocInAncGreece = new List<SqlParameter>();
                sqlSportsAndSocInAncGreece.Add(new SqlParameter("Username", Globals.username));
                sqlSportsAndSocInAncGreece.Add(new SqlParameter("SportsAndSocInAncGreeceGrade", cboxSportsAndSocInAncGreece.Text));
                sqlSportsAndSocInAncGreece.Add(new SqlParameter("SportsAndSocInAncGreeceDescription", checkSportsAndSocInAncGreece.Text));

                if (cboxSportsAndSocInAncGreece.Text == "F")
                {
                    sqlSportsAndSocInAncGreece.Add(new SqlParameter("SportsAndSocInAncGreeceStatus", "Incomplete"));
                }
                else if (cboxSportsAndSocInAncGreece.Text == "")
                {
                    sqlSportsAndSocInAncGreece.Add(new SqlParameter("SportsAndSocInAncGreeceStatus", DBNull.Value));
                }
                else
                {
                    sqlSportsAndSocInAncGreece.Add(new SqlParameter("SportsAndSocInAncGreeceStatus", "Complete"));
                }

                DAL.ExecSP("CreateSportsAndSocInAncGreece", sqlSportsAndSocInAncGreece);
            }

            if (checkMythologyOfAncientGreece.Checked)
            {
                List<SqlParameter> sqlMythologyOfAncientGreece = new List<SqlParameter>();
                sqlMythologyOfAncientGreece.Add(new SqlParameter("Username", Globals.username));
                sqlMythologyOfAncientGreece.Add(new SqlParameter("MythologyOfAncientGreeceGrade", cboxMythologyOfAncientGreece.Text));
                sqlMythologyOfAncientGreece.Add(new SqlParameter("MythologyOfAncientGreeceDescription", checkMythologyOfAncientGreece.Text));

                if (cboxMythologyOfAncientGreece.Text == "F")
                {
                    sqlMythologyOfAncientGreece.Add(new SqlParameter("MythologyOfAncientGreeceStatus", "Incomplete"));
                }
                else if (cboxMythologyOfAncientGreece.Text == "")
                {
                    sqlMythologyOfAncientGreece.Add(new SqlParameter("MythologyOfAncientGreeceStatus", DBNull.Value));
                }
                else
                {
                    sqlMythologyOfAncientGreece.Add(new SqlParameter("MythologyOfAncientGreeceStatus", "Complete"));
                }

                DAL.ExecSP("CreateMythologyOfAncientGreece", sqlMythologyOfAncientGreece);
            }

            if (checkIntroductionToPhilosophy.Checked)
            {
                List<SqlParameter> sqlIntroductionToPhilosophy = new List<SqlParameter>();
                sqlIntroductionToPhilosophy.Add(new SqlParameter("Username", Globals.username));
                sqlIntroductionToPhilosophy.Add(new SqlParameter("IntroductionToPhilosophyGrade", cboxIntroductionToPhilosophy.Text));
                sqlIntroductionToPhilosophy.Add(new SqlParameter("IntroductionToPhilosophyDescription", checkIntroductionToPhilosophy.Text));

                if (cboxIntroductionToPhilosophy.Text == "F")
                {
                    sqlIntroductionToPhilosophy.Add(new SqlParameter("IntroductionToPhilosophyStatus", "Incomplete"));
                }
                else if (cboxIntroductionToPhilosophy.Text == "")
                {
                    sqlIntroductionToPhilosophy.Add(new SqlParameter("IntroductionToPhilosophyStatus", DBNull.Value));
                }
                else
                {
                    sqlIntroductionToPhilosophy.Add(new SqlParameter("IntroductionToPhilosophyStatus", "Complete"));
                }

                DAL.ExecSP("CreateIntroductionToPhilosophy", sqlIntroductionToPhilosophy);
            }

            if (checkIntroductionToEthics.Checked)
            {
                List<SqlParameter> sqlIntroductionToEthics = new List<SqlParameter>();
                sqlIntroductionToEthics.Add(new SqlParameter("Username", Globals.username));
                sqlIntroductionToEthics.Add(new SqlParameter("IntroductionToEthicsGrade", cboxIntroductionToEthics.Text));
                sqlIntroductionToEthics.Add(new SqlParameter("IntroductionToEthicsDescription", checkIntroductionToEthics.Text));

                if (cboxIntroductionToEthics.Text == "F")
                {
                    sqlIntroductionToEthics.Add(new SqlParameter("IntroductionToEthicsStatus", "Incomplete"));
                }
                else if (cboxIntroductionToEthics.Text == "")
                {
                    sqlIntroductionToEthics.Add(new SqlParameter("IntroductionToEthicsStatus", DBNull.Value));
                }
                else
                {
                    sqlIntroductionToEthics.Add(new SqlParameter("IntroductionToEthicsStatus", "Complete"));
                }

                DAL.ExecSP("CreateIntroductionToEthics", sqlIntroductionToEthics);
            }

            if (checkIntroductionToLogic.Checked)
            {
                List<SqlParameter> sqlIntroductionToLogic = new List<SqlParameter>();
                sqlIntroductionToLogic.Add(new SqlParameter("Username", Globals.username));
                sqlIntroductionToLogic.Add(new SqlParameter("IntroductionToLogicGrade", cboxIntroductionToLogic.Text));
                sqlIntroductionToLogic.Add(new SqlParameter("IntroductionToLogicDescription", checkIntroductionToLogic.Text));

                if (cboxIntroductionToLogic.Text == "F")
                {
                    sqlIntroductionToLogic.Add(new SqlParameter("IntroductionToLogicStatus", "Incomplete"));
                }
                else if (cboxIntroductionToLogic.Text == "")
                {
                    sqlIntroductionToLogic.Add(new SqlParameter("IntroductionToLogicStatus", DBNull.Value));
                }
                else
                {
                    sqlIntroductionToLogic.Add(new SqlParameter("IntroductionToLogicStatus", "Complete"));
                }

                DAL.ExecSP("CreateIntroductionToLogic", sqlIntroductionToLogic);
            }

            if (checkClassAndContLit.Checked)
            {
                List<SqlParameter> sqlClassAndContLit = new List<SqlParameter>();
                sqlClassAndContLit.Add(new SqlParameter("Username", Globals.username));
                sqlClassAndContLit.Add(new SqlParameter("ClassAndContLitGrade", cboxClassAndContLit.Text));
                sqlClassAndContLit.Add(new SqlParameter("ClassAndContLitDescription", checkClassAndContLit.Text));

                if (cboxClassAndContLit.Text == "F")
                {
                    sqlClassAndContLit.Add(new SqlParameter("ClassAndContLitStatus", "Incomplete"));
                }
                else if (cboxClassAndContLit.Text == "")
                {
                    sqlClassAndContLit.Add(new SqlParameter("ClassAndContLitStatus", DBNull.Value));
                }
                else
                {
                    sqlClassAndContLit.Add(new SqlParameter("ClassAndContLitStatus", "Complete"));
                }

                DAL.ExecSP("CreateClassAndContLit", sqlClassAndContLit);
            }

            if (checkShakespeare.Checked)
            {
                List<SqlParameter> sqlShakespeare = new List<SqlParameter>();
                sqlShakespeare.Add(new SqlParameter("Username", Globals.username));
                sqlShakespeare.Add(new SqlParameter("ShakespeareGrade", cboxShakespeare.Text));
                sqlShakespeare.Add(new SqlParameter("ShakespeareDescription", checkShakespeare.Text));

                if (cboxShakespeare.Text == "F")
                {
                    sqlShakespeare.Add(new SqlParameter("ShakespeareStatus", "Incomplete"));
                }
                else if (cboxShakespeare.Text == "")
                {
                    sqlShakespeare.Add(new SqlParameter("ShakespeareStatus", DBNull.Value));
                }
                else
                {
                    sqlShakespeare.Add(new SqlParameter("ShakespeareStatus", "Complete"));
                }

                DAL.ExecSP("CreateShakespeare", sqlShakespeare);
            }

            if (checkFictionAppreciation.Checked)
            {
                List<SqlParameter> sqlFictionAppreciation = new List<SqlParameter>();
                sqlFictionAppreciation.Add(new SqlParameter("Username", Globals.username));
                sqlFictionAppreciation.Add(new SqlParameter("FictionAppreciationGrade", cboxFictionAppreciation.Text));
                sqlFictionAppreciation.Add(new SqlParameter("FictionAppreciationDescription", checkFictionAppreciation.Text));

                if (cboxFictionAppreciation.Text == "F")
                {
                    sqlFictionAppreciation.Add(new SqlParameter("FictionAppreciationStatus", "Incomplete"));
                }
                else if (cboxFictionAppreciation.Text == "")
                {
                    sqlFictionAppreciation.Add(new SqlParameter("FictionAppreciationStatus", DBNull.Value));
                }
                else
                {
                    sqlFictionAppreciation.Add(new SqlParameter("FictionAppreciationStatus", "Complete"));
                }

                DAL.ExecSP("CreateFictionAppreciation", sqlFictionAppreciation);
            }

            if (checkLiteratureOfGreece.Checked)
            {
                List<SqlParameter> sqlLiteratureOfGreece = new List<SqlParameter>();
                sqlLiteratureOfGreece.Add(new SqlParameter("Username", Globals.username));
                sqlLiteratureOfGreece.Add(new SqlParameter("LiteratureOfGreeceGrade", cboxLiteratureOfGreece.Text));
                sqlLiteratureOfGreece.Add(new SqlParameter("LiteratureOfGreeceDescription", checkLiteratureOfGreece.Text));

                if (cboxLiteratureOfGreece.Text == "F")
                {
                    sqlLiteratureOfGreece.Add(new SqlParameter("LiteratureOfGreeceStatus", "Incomplete"));
                }
                else if (cboxLiteratureOfGreece.Text == "")
                {
                    sqlLiteratureOfGreece.Add(new SqlParameter("LiteratureOfGreeceStatus", DBNull.Value));
                }
                else
                {
                    sqlLiteratureOfGreece.Add(new SqlParameter("LiteratureOfGreeceStatus", "Complete"));
                }

                DAL.ExecSP("CreateLiteratureOfGreece", sqlLiteratureOfGreece);
            }

            if (checkLitOfSpanAmer.Checked)
            {
                List<SqlParameter> sqlLitOfSpanAmer = new List<SqlParameter>();
                sqlLitOfSpanAmer.Add(new SqlParameter("Username", Globals.username));
                sqlLitOfSpanAmer.Add(new SqlParameter("LitOfSpanAmerGrade", cboxLitOfSpanAmer.Text));
                sqlLitOfSpanAmer.Add(new SqlParameter("LitOfSpanAmerDescription", checkLitOfSpanAmer.Text));

                if (cboxLitOfSpanAmer.Text == "F")
                {
                    sqlLitOfSpanAmer.Add(new SqlParameter("LitOfSpanAmerStatus", "Incomplete"));
                }
                else if (cboxLitOfSpanAmer.Text == "")
                {
                    sqlLitOfSpanAmer.Add(new SqlParameter("LitOfSpanAmerStatus", DBNull.Value));
                }
                else
                {
                    sqlLitOfSpanAmer.Add(new SqlParameter("LitOfSpanAmerStatus", "Complete"));
                }

                DAL.ExecSP("CreateLitOfSpanAmer", sqlLitOfSpanAmer);
            }

            Register_AreaStudies frmRegister_AreaStudies = new Register_AreaStudies();
            frmRegister_AreaStudies.Show();
            this.Hide();
        }
    }
}
