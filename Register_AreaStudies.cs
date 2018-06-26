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
    public partial class Register_AreaStudies : Form
    {
        public Register_AreaStudies()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (checkBlackExp1619To1877.Checked)
            {
                List<SqlParameter> sqlBlackExp1619To1877 = new List<SqlParameter>();
                sqlBlackExp1619To1877.Add(new SqlParameter("Username", Globals.username));
                sqlBlackExp1619To1877.Add(new SqlParameter("BlackExp1619To1877Grade", cboxBlackExp1619To1877.Text));
                sqlBlackExp1619To1877.Add(new SqlParameter("BlackExp1619To1877Description", checkBlackExp1619To1877.Text));

                if (cboxBlackExp1619To1877.Text == "F")
                {
                    sqlBlackExp1619To1877.Add(new SqlParameter("BlackExp1619To1877Status", "Incomplete"));
                }
                else if (cboxBlackExp1619To1877.Text == "")
                {
                    sqlBlackExp1619To1877.Add(new SqlParameter("BlackExp1619To1877Status", DBNull.Value));
                }
                else
                {
                    sqlBlackExp1619To1877.Add(new SqlParameter("BlackExp1619To1877Status", "Complete"));
                }

                DAL.ExecSP("CreateBlackExp1619To1877", sqlBlackExp1619To1877);
            }

            if (checkBlackExp1877To1954.Checked)
            {
                List<SqlParameter> sqlBlackExp1877To1954 = new List<SqlParameter>();
                sqlBlackExp1877To1954.Add(new SqlParameter("Username", Globals.username));
                sqlBlackExp1877To1954.Add(new SqlParameter("BlackExp1877To1954Grade", cboxBlackExp1877To1954.Text));
                sqlBlackExp1877To1954.Add(new SqlParameter("BlackExp1877To1954Description", checkBlackExp1877To1954.Text));

                if (cboxBlackExp1877To1954.Text == "F")
                {
                    sqlBlackExp1877To1954.Add(new SqlParameter("BlackExp1877To1954Status", "Incomplete"));
                }
                else if (cboxBlackExp1877To1954.Text == "")
                {
                    sqlBlackExp1877To1954.Add(new SqlParameter("BlackExp1877To1954Status", DBNull.Value));
                }
                else
                {
                    sqlBlackExp1877To1954.Add(new SqlParameter("BlackExp1877To1954Status", "Complete"));
                }

                DAL.ExecSP("CreateBlackExp1877To1954", sqlBlackExp1877To1954);
            }

            if (checkBlackExp1954ToPresent.Checked)
            {
                List<SqlParameter> sqlBlackExp1954ToPresent = new List<SqlParameter>();
                sqlBlackExp1954ToPresent.Add(new SqlParameter("Username", Globals.username));
                sqlBlackExp1954ToPresent.Add(new SqlParameter("BlackExp1954ToPresentGrade", cboxBlackExp1954ToPresent.Text));
                sqlBlackExp1954ToPresent.Add(new SqlParameter("BlackExp1954ToPresentDescription", checkBlackExp1954ToPresent.Text));

                if (cboxBlackExp1954ToPresent.Text == "F")
                {
                    sqlBlackExp1954ToPresent.Add(new SqlParameter("BlackExp1954ToPresentStatus", "Incomplete"));
                }
                else if (cboxBlackExp1954ToPresent.Text == "")
                {
                    sqlBlackExp1954ToPresent.Add(new SqlParameter("BlackExp1954ToPresentStatus", DBNull.Value));
                }
                else
                {
                    sqlBlackExp1954ToPresent.Add(new SqlParameter("BlackExp1954ToPresentStatus", "Complete"));
                }

                DAL.ExecSP("CreateBlackExp1954ToPresent", sqlBlackExp1954ToPresent);
            }

            if (checkDiversityInAmericanSociety.Checked)
            {
                List<SqlParameter> sqlDiversityInAmericanSociety = new List<SqlParameter>();
                sqlDiversityInAmericanSociety.Add(new SqlParameter("Username", Globals.username));
                sqlDiversityInAmericanSociety.Add(new SqlParameter("DiversityInAmericanSocietyGrade", cboxDiversityInAmericanSociety.Text));
                sqlDiversityInAmericanSociety.Add(new SqlParameter("DiversityInAmericanSocietyDescription", checkDiversityInAmericanSociety.Text));

                if (cboxDiversityInAmericanSociety.Text == "F")
                {
                    sqlDiversityInAmericanSociety.Add(new SqlParameter("DiversityInAmericanSocietyStatus", "Incomplete"));
                }
                else if (cboxDiversityInAmericanSociety.Text == "")
                {
                    sqlDiversityInAmericanSociety.Add(new SqlParameter("DiversityInAmericanSocietyStatus", DBNull.Value));
                }
                else
                {
                    sqlDiversityInAmericanSociety.Add(new SqlParameter("DiversityInAmericanSocietyStatus", "Complete"));
                }

                DAL.ExecSP("CreateDiversityInAmericanSociety", sqlDiversityInAmericanSociety);
            }

            if (checkIntroPanAfricanStudies.Checked)
            {
                List<SqlParameter> sqlIntroPanAfricanStudies = new List<SqlParameter>();
                sqlIntroPanAfricanStudies.Add(new SqlParameter("Username", Globals.username));
                sqlIntroPanAfricanStudies.Add(new SqlParameter("IntroPanAfricanStudiesGrade", cboxIntroPanAfricanStudies.Text));
                sqlIntroPanAfricanStudies.Add(new SqlParameter("IntroPanAfricanStudiesDescription", checkIntroPanAfricanStudies.Text));

                if (cboxIntroPanAfricanStudies.Text == "F")
                {
                    sqlIntroPanAfricanStudies.Add(new SqlParameter("IntroPanAfricanStudiesStatus", "Incomplete"));
                }
                else if (cboxIntroPanAfricanStudies.Text == "")
                {
                    sqlIntroPanAfricanStudies.Add(new SqlParameter("IntroPanAfricanStudiesStatus", DBNull.Value));
                }
                else
                {
                    sqlIntroPanAfricanStudies.Add(new SqlParameter("IntroPanAfricanStudiesStatus", "Complete"));
                }

                DAL.ExecSP("CreateIntroPanAfricanStudies", sqlIntroPanAfricanStudies);
            }

            if (checkIntroToWomensStudies.Checked)
            {
                List<SqlParameter> sqlIntroToWomensStudies = new List<SqlParameter>();
                sqlIntroToWomensStudies.Add(new SqlParameter("Username", Globals.username));
                sqlIntroToWomensStudies.Add(new SqlParameter("IntroToWomensStudiesGrade", cboxIntroToWomensStudies.Text));
                sqlIntroToWomensStudies.Add(new SqlParameter("IntroToWomensStudiesDescription", checkIntroToWomensStudies.Text));

                if (cboxIntroToWomensStudies.Text == "F")
                {
                    sqlIntroToWomensStudies.Add(new SqlParameter("IntroToWomensStudiesStatus", "Incomplete"));
                }
                else if (cboxIntroToWomensStudies.Text == "")
                {
                    sqlIntroToWomensStudies.Add(new SqlParameter("IntroToWomensStudiesStatus", DBNull.Value));
                }
                else
                {
                    sqlIntroToWomensStudies.Add(new SqlParameter("IntroToWomensStudiesStatus", "Complete"));
                }

                DAL.ExecSP("CreateIntroToWomensStudies", sqlIntroToWomensStudies);
            }

            if (checkHumanDiversity.Checked)
            {
                List<SqlParameter> sqlHumanDiversity = new List<SqlParameter>();
                sqlHumanDiversity.Add(new SqlParameter("Username", Globals.username));
                sqlHumanDiversity.Add(new SqlParameter("HumanDiversityGrade", cboxHumanDiversity.Text));
                sqlHumanDiversity.Add(new SqlParameter("HumanDiversityDescription", checkHumanDiversity.Text));

                if (cboxHumanDiversity.Text == "F")
                {
                    sqlHumanDiversity.Add(new SqlParameter("HumanDiversityStatus", "Incomplete"));
                }
                else if (cboxHumanDiversity.Text == "")
                {
                    sqlHumanDiversity.Add(new SqlParameter("HumanDiversityStatus", DBNull.Value));
                }
                else
                {
                    sqlHumanDiversity.Add(new SqlParameter("HumanDiversityStatus", "Complete"));
                }

                DAL.ExecSP("CreateHumanDiversity", sqlHumanDiversity);
            }

            if (checkInterComm.Checked)
            {
                List<SqlParameter> sqlInterComm = new List<SqlParameter>();
                sqlInterComm.Add(new SqlParameter("Username", Globals.username));
                sqlInterComm.Add(new SqlParameter("InterCommGrade", cboxInterComm.Text));
                sqlInterComm.Add(new SqlParameter("InterCommDescription", checkInterComm.Text));

                if (cboxInterComm.Text == "F")
                {
                    sqlInterComm.Add(new SqlParameter("InterCommStatus", "Incomplete"));
                }
                else if (cboxInterComm.Text == "")
                {
                    sqlInterComm.Add(new SqlParameter("InterCommStatus", DBNull.Value));
                }
                else
                {
                    sqlInterComm.Add(new SqlParameter("InterCommStatus", "Complete"));
                }

                DAL.ExecSP("CreateInterComm", sqlInterComm);
            }

            if (checkGeographyOfCulturalDiversity.Checked)
            {
                List<SqlParameter> sqlGeographyOfCulturalDiversity = new List<SqlParameter>();
                sqlGeographyOfCulturalDiversity.Add(new SqlParameter("Username", Globals.username));
                sqlGeographyOfCulturalDiversity.Add(new SqlParameter("GeographyOfCulturalDiversityGrade", cboxGeographyOfCulturalDiversity.Text));
                sqlGeographyOfCulturalDiversity.Add(new SqlParameter("GeographyOfCulturalDiversityDescription", checkGeographyOfCulturalDiversity.Text));

                if (cboxGeographyOfCulturalDiversity.Text == "F")
                {
                    sqlGeographyOfCulturalDiversity.Add(new SqlParameter("GeographyOfCulturalDiversityStatus", "Incomplete"));
                }
                else if (cboxGeographyOfCulturalDiversity.Text == "")
                {
                    sqlGeographyOfCulturalDiversity.Add(new SqlParameter("GeographyOfCulturalDiversityStatus", DBNull.Value));
                }
                else
                {
                    sqlGeographyOfCulturalDiversity.Add(new SqlParameter("GeographyOfCulturalDiversityStatus", "Complete"));
                }

                DAL.ExecSP("CreateGeographyOfCulturalDiversity", sqlGeographyOfCulturalDiversity);
            }

            if (checkJapCultThroughFilm.Checked)
            {
                List<SqlParameter> sqlJapCultThroughFilm = new List<SqlParameter>();
                sqlJapCultThroughFilm.Add(new SqlParameter("Username", Globals.username));
                sqlJapCultThroughFilm.Add(new SqlParameter("JapCultThroughFilmGrade", cboxJapCultThroughFilm.Text));
                sqlJapCultThroughFilm.Add(new SqlParameter("JapCultThroughFilmDescription", checkJapCultThroughFilm.Text));

                if (cboxJapCultThroughFilm.Text == "F")
                {
                    sqlJapCultThroughFilm.Add(new SqlParameter("JapCultThroughFilmStatus", "Incomplete"));
                }
                else if (cboxJapCultThroughFilm.Text == "")
                {
                    sqlJapCultThroughFilm.Add(new SqlParameter("JapCultThroughFilmStatus", DBNull.Value));
                }
                else
                {
                    sqlJapCultThroughFilm.Add(new SqlParameter("JapCultThroughFilmStatus", "Complete"));
                }

                DAL.ExecSP("CreateJapCultThroughFilm", sqlJapCultThroughFilm);
            }

            if (checkArabCultThroughFilm.Checked)
            {
                List<SqlParameter> sqlArabCultThroughFilm = new List<SqlParameter>();
                sqlArabCultThroughFilm.Add(new SqlParameter("Username", Globals.username));
                sqlArabCultThroughFilm.Add(new SqlParameter("ArabCultThroughFilmGrade", cboxArabCultThroughFilm.Text));
                sqlArabCultThroughFilm.Add(new SqlParameter("ArabCultThroughFilmDescription", checkArabCultThroughFilm.Text));

                if (cboxArabCultThroughFilm.Text == "F")
                {
                    sqlArabCultThroughFilm.Add(new SqlParameter("ArabCultThroughFilmStatus", "Incomplete"));
                }
                else if (cboxArabCultThroughFilm.Text == "")
                {
                    sqlArabCultThroughFilm.Add(new SqlParameter("ArabCultThroughFilmStatus", DBNull.Value));
                }
                else
                {
                    sqlArabCultThroughFilm.Add(new SqlParameter("ArabCultThroughFilmStatus", "Complete"));
                }

                DAL.ExecSP("CreateArabCultThroughFilm", sqlArabCultThroughFilm);
            }

            if (checkChinCultThroughFilm.Checked)
            {
                List<SqlParameter> sqlChinCultThroughFilm = new List<SqlParameter>();
                sqlChinCultThroughFilm.Add(new SqlParameter("Username", Globals.username));
                sqlChinCultThroughFilm.Add(new SqlParameter("ChinCultThroughFilmGrade", cboxChinCultThroughFilm.Text));
                sqlChinCultThroughFilm.Add(new SqlParameter("ChinCultThroughFilmDescription", checkChinCultThroughFilm.Text));

                if (cboxChinCultThroughFilm.Text == "F")
                {
                    sqlChinCultThroughFilm.Add(new SqlParameter("ChinCultThroughFilmStatus", "Incomplete"));
                }
                else if (cboxChinCultThroughFilm.Text == "")
                {
                    sqlChinCultThroughFilm.Add(new SqlParameter("ChinCultThroughFilmStatus", DBNull.Value));
                }
                else
                {
                    sqlChinCultThroughFilm.Add(new SqlParameter("ChinCultThroughFilmStatus", "Complete"));
                }

                DAL.ExecSP("CreateChinCultThroughFilm", sqlChinCultThroughFilm);
            }

            if (checkWorldCivChina.Checked)
            {
                List<SqlParameter> sqlWorldCivChina = new List<SqlParameter>();
                sqlWorldCivChina.Add(new SqlParameter("Username", Globals.username));
                sqlWorldCivChina.Add(new SqlParameter("WorldCivChinaGrade", cboxWorldCivChina.Text));
                sqlWorldCivChina.Add(new SqlParameter("WorldCivChinaDescription", checkWorldCivChina.Text));

                if (cboxWorldCivChina.Text == "F")
                {
                    sqlWorldCivChina.Add(new SqlParameter("WorldCivChinaStatus", "Incomplete"));
                }
                else if (cboxWorldCivChina.Text == "")
                {
                    sqlWorldCivChina.Add(new SqlParameter("WorldCivChinaStatus", DBNull.Value));
                }
                else
                {
                    sqlWorldCivChina.Add(new SqlParameter("WorldCivChinaStatus", "Complete"));
                }

                DAL.ExecSP("CreateWorldCivChina", sqlWorldCivChina);
            }

            if (checkWorldCivSEAsia.Checked)
            {
                List<SqlParameter> sqlWorldCivSEAsia = new List<SqlParameter>();
                sqlWorldCivSEAsia.Add(new SqlParameter("Username", Globals.username));
                sqlWorldCivSEAsia.Add(new SqlParameter("WorldCivSEAsiaGrade", cboxWorldCivSEAsia.Text));
                sqlWorldCivSEAsia.Add(new SqlParameter("WorldCivSEAsiaDescription", checkWorldCivSEAsia.Text));

                if (cboxWorldCivSEAsia.Text == "F")
                {
                    sqlWorldCivSEAsia.Add(new SqlParameter("WorldCivSEAsiaStatus", "Incomplete"));
                }
                else if (cboxWorldCivSEAsia.Text == "")
                {
                    sqlWorldCivSEAsia.Add(new SqlParameter("WorldCivSEAsiaStatus", DBNull.Value));
                }
                else
                {
                    sqlWorldCivSEAsia.Add(new SqlParameter("WorldCivSEAsiaStatus", "Complete"));
                }

                DAL.ExecSP("CreateWorldCivSEAsia", sqlWorldCivSEAsia);
            }

            if (checkWorldCivIndia.Checked)
            {
                List<SqlParameter> sqlWorldCivIndia = new List<SqlParameter>();
                sqlWorldCivIndia.Add(new SqlParameter("Username", Globals.username));
                sqlWorldCivIndia.Add(new SqlParameter("WorldCivIndiaGrade", cboxWorldCivIndia.Text));
                sqlWorldCivIndia.Add(new SqlParameter("WorldCivIndiaDescription", checkWorldCivIndia.Text));

                if (cboxWorldCivIndia.Text == "F")
                {
                    sqlWorldCivIndia.Add(new SqlParameter("WorldCivIndiaStatus", "Incomplete"));
                }
                else if (cboxWorldCivIndia.Text == "")
                {
                    sqlWorldCivIndia.Add(new SqlParameter("WorldCivIndiaStatus", DBNull.Value));
                }
                else
                {
                    sqlWorldCivIndia.Add(new SqlParameter("WorldCivIndiaStatus", "Complete"));
                }

                DAL.ExecSP("CreateWorldCivIndia", sqlWorldCivIndia);
            }

            if (checkWorldCivJapan.Checked)
            {
                List<SqlParameter> sqlWorldCivJapan = new List<SqlParameter>();
                sqlWorldCivJapan.Add(new SqlParameter("Username", Globals.username));
                sqlWorldCivJapan.Add(new SqlParameter("WorldCivJapanGrade", cboxWorldCivJapan.Text));
                sqlWorldCivJapan.Add(new SqlParameter("WorldCivJapanDescription", checkWorldCivJapan.Text));

                if (cboxWorldCivJapan.Text == "F")
                {
                    sqlWorldCivJapan.Add(new SqlParameter("WorldCivJapanStatus", "Incomplete"));
                }
                else if (cboxWorldCivJapan.Text == "")
                {
                    sqlWorldCivJapan.Add(new SqlParameter("WorldCivJapanStatus", DBNull.Value));
                }
                else
                {
                    sqlWorldCivJapan.Add(new SqlParameter("WorldCivJapanStatus", "Complete"));
                }

                DAL.ExecSP("CreateWorldCivJapan", sqlWorldCivJapan);
            }

            if (checkWorldCivMiddleEast.Checked)
            {
                List<SqlParameter> sqlWorldCivMiddleEast = new List<SqlParameter>();
                sqlWorldCivMiddleEast.Add(new SqlParameter("Username", Globals.username));
                sqlWorldCivMiddleEast.Add(new SqlParameter("WorldCivMiddleEastGrade", cboxWorldCivMiddleEast.Text));
                sqlWorldCivMiddleEast.Add(new SqlParameter("WorldCivMiddleEastDescription", checkWorldCivMiddleEast.Text));

                if (cboxWorldCivMiddleEast.Text == "F")
                {
                    sqlWorldCivMiddleEast.Add(new SqlParameter("WorldCivMiddleEastStatus", "Incomplete"));
                }
                else if (cboxWorldCivMiddleEast.Text == "")
                {
                    sqlWorldCivMiddleEast.Add(new SqlParameter("WorldCivMiddleEastStatus", DBNull.Value));
                }
                else
                {
                    sqlWorldCivMiddleEast.Add(new SqlParameter("WorldCivMiddleEastStatus", "Complete"));
                }

                DAL.ExecSP("CreateWorldCivMiddleEast", sqlWorldCivMiddleEast);
            }

            if (checkWorldCivAfrica.Checked)
            {
                List<SqlParameter> sqlWorldCivAfrica = new List<SqlParameter>();
                sqlWorldCivAfrica.Add(new SqlParameter("Username", Globals.username));
                sqlWorldCivAfrica.Add(new SqlParameter("WorldCivAfricaGrade", cboxWorldCivAfrica.Text));
                sqlWorldCivAfrica.Add(new SqlParameter("WorldCivAfricaDescription", checkWorldCivAfrica.Text));

                if (cboxWorldCivAfrica.Text == "F")
                {
                    sqlWorldCivAfrica.Add(new SqlParameter("WorldCivAfricaStatus", "Incomplete"));
                }
                else if (cboxWorldCivAfrica.Text == "")
                {
                    sqlWorldCivAfrica.Add(new SqlParameter("WorldCivAfricaStatus", DBNull.Value));
                }
                else
                {
                    sqlWorldCivAfrica.Add(new SqlParameter("WorldCivAfricaStatus", "Complete"));
                }

                DAL.ExecSP("CreateWorldCivAfrica", sqlWorldCivAfrica);
            }

            if (checkWorldCivLatinAmerica.Checked)
            {
                List<SqlParameter> sqlWorldCivLatinAmerica = new List<SqlParameter>();
                sqlWorldCivLatinAmerica.Add(new SqlParameter("Username", Globals.username));
                sqlWorldCivLatinAmerica.Add(new SqlParameter("WorldCivLatinAmericaGrade", cboxWorldCivLatinAmerica.Text));
                sqlWorldCivLatinAmerica.Add(new SqlParameter("WorldCivLatinAmericaDescription", checkWorldCivLatinAmerica.Text));

                if (cboxWorldCivLatinAmerica.Text == "F")
                {
                    sqlWorldCivLatinAmerica.Add(new SqlParameter("WorldCivLatinAmericaStatus", "Incomplete"));
                }
                else if (cboxWorldCivLatinAmerica.Text == "")
                {
                    sqlWorldCivLatinAmerica.Add(new SqlParameter("WorldCivLatinAmericaStatus", DBNull.Value));
                }
                else
                {
                    sqlWorldCivLatinAmerica.Add(new SqlParameter("WorldCivLatinAmericaStatus", "Complete"));
                }

                DAL.ExecSP("CreateWorldCivLatinAmerica", sqlWorldCivLatinAmerica);
            }

            MessageBox.Show("Thank you for registering your information.\n You will be taken back to the login screen.");
            Login newLogin = new Login();
            newLogin.Show();
            this.Hide();
        }
    }
}
