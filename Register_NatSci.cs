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
    public partial class Register_NatSci : Form
    {
        public Register_NatSci()
        {
            InitializeComponent();
        }

        private void Register_NatSci_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Register_NatSci_Load(object sender, EventArgs e)
        {
            lblNatSci.Font = new Font(lblNatSci.Font, FontStyle.Bold);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (checkEarthScience.Checked)
            {
                List<SqlParameter> sqlEarthScience = new List<SqlParameter>();
                sqlEarthScience.Add(new SqlParameter("Username", Globals.username));
                sqlEarthScience.Add(new SqlParameter("EarthScienceGrade", cboxEarthScience.Text));
                sqlEarthScience.Add(new SqlParameter("EarthScienceDescription", checkEarthScience.Text));

                if (cboxEarthScience.Text == "F")
                {
                    sqlEarthScience.Add(new SqlParameter("EarthScienceStatus", "Incomplete"));
                }
                else if (cboxEarthScience.Text == "")
                {
                    sqlEarthScience.Add(new SqlParameter("EarthScienceStatus", DBNull.Value));
                }
                else
                {
                    sqlEarthScience.Add(new SqlParameter("EarthScienceStatus", "Complete"));
                }

                DAL.ExecSP("CreateEarthScience", sqlEarthScience);
            }

            if (checkPhysicalGeology.Checked)
            {
                List<SqlParameter> sqlPhysicalGeology = new List<SqlParameter>();
                sqlPhysicalGeology.Add(new SqlParameter("Username", Globals.username));
                sqlPhysicalGeology.Add(new SqlParameter("PhysicalGeologyGrade", cboxPhysicalGeology.Text));
                sqlPhysicalGeology.Add(new SqlParameter("PhysicalGeologyDescription", checkPhysicalGeology.Text));

                if (cboxPhysicalGeology.Text == "F")
                {
                    sqlPhysicalGeology.Add(new SqlParameter("PhysicalGeologyStatus", "Incomplete"));
                }
                else if (cboxPhysicalGeology.Text == "")
                {
                    sqlPhysicalGeology.Add(new SqlParameter("PhysicalGeologyStatus", DBNull.Value));
                }
                else
                {
                    sqlPhysicalGeology.Add(new SqlParameter("PhysicalGeologyStatus", "Complete"));
                }

                DAL.ExecSP("CreatePhysicalGeology", sqlPhysicalGeology);
            }

            if (checkGeology.Checked)
            {
                List<SqlParameter> sqlGeology = new List<SqlParameter>();
                sqlGeology.Add(new SqlParameter("Username", Globals.username));
                sqlGeology.Add(new SqlParameter("GeologyGrade", cboxGeology.Text));
                sqlGeology.Add(new SqlParameter("GeologyDescription", checkGeology.Text));

                if (cboxGeology.Text == "F")
                {
                    sqlGeology.Add(new SqlParameter("GeologyStatus", "Incomplete"));
                }
                else if (cboxGeology.Text == "")
                {
                    sqlGeology.Add(new SqlParameter("GeologyStatus", DBNull.Value));
                }
                else
                {
                    sqlGeology.Add(new SqlParameter("GeologyStatus", "Complete"));
                }

                DAL.ExecSP("CreateGeology", sqlGeology);
            }

            if (checkConceptsInGeology.Checked)
            {
                List<SqlParameter> sqlConceptsInGeology = new List<SqlParameter>();
                sqlConceptsInGeology.Add(new SqlParameter("Username", Globals.username));
                sqlConceptsInGeology.Add(new SqlParameter("ConceptsInGeologyGrade", cboxConceptsInGeology.Text));
                sqlConceptsInGeology.Add(new SqlParameter("ConceptsInGeologyDescription", checkConceptsInGeology.Text));

                if (cboxConceptsInGeology.Text == "F")
                {
                    sqlConceptsInGeology.Add(new SqlParameter("ConceptsInGeologyStatus", "Incomplete"));
                }
                else if (cboxConceptsInGeology.Text == "")
                {
                    sqlConceptsInGeology.Add(new SqlParameter("ConceptsInGeologyStatus", DBNull.Value));
                }
                else
                {
                    sqlConceptsInGeology.Add(new SqlParameter("ConceptsInGeologyStatus", "Complete"));
                }

                DAL.ExecSP("CreateConceptsInGeology", sqlConceptsInGeology);
            }

            if (checkOceans.Checked)
            {
                List<SqlParameter> sqlOceans = new List<SqlParameter>();
                sqlOceans.Add(new SqlParameter("Username", Globals.username));
                sqlOceans.Add(new SqlParameter("OceansGrade", cboxOceans.Text));
                sqlOceans.Add(new SqlParameter("OceansDescription", checkOceans.Text));

                if (cboxOceans.Text == "F")
                {
                    sqlOceans.Add(new SqlParameter("OceansStatus", "Incomplete"));
                }
                else if (cboxOceans.Text == "")
                {
                    sqlOceans.Add(new SqlParameter("OceansStatus", DBNull.Value));
                }
                else
                {
                    sqlOceans.Add(new SqlParameter("OceansStatus", "Complete"));
                }

                DAL.ExecSP("CreateOceans", sqlOceans);
            }

            if (checkEnviromentalGeology.Checked)
            {
                List<SqlParameter> sqlEnviromentalGeology = new List<SqlParameter>();
                sqlEnviromentalGeology.Add(new SqlParameter("Username", Globals.username));
                sqlEnviromentalGeology.Add(new SqlParameter("EnviromentalGeologyGrade", cboxEnviromentalGeology.Text));
                sqlEnviromentalGeology.Add(new SqlParameter("EnviromentalGeologyDescription", checkEnviromentalGeology.Text));

                if (cboxEnviromentalGeology.Text == "F")
                {
                    sqlEnviromentalGeology.Add(new SqlParameter("EnviromentalGeologyStatus", "Incomplete"));
                }
                else if (cboxEnviromentalGeology.Text == "")
                {
                    sqlEnviromentalGeology.Add(new SqlParameter("EnviromentalGeologyStatus", DBNull.Value));
                }
                else
                {
                    sqlEnviromentalGeology.Add(new SqlParameter("EnviromentalGeologyStatus", "Complete"));
                }

                DAL.ExecSP("CreateEnviromentalGeology", sqlEnviromentalGeology);
            }

            if (checkExerciseGeology1.Checked)
            {
                List<SqlParameter> sqlExerciseGeology1 = new List<SqlParameter>();
                sqlExerciseGeology1.Add(new SqlParameter("Username", Globals.username));
                sqlExerciseGeology1.Add(new SqlParameter("ExerciseGeology1Grade", cboxExerciseGeology1.Text));
                sqlExerciseGeology1.Add(new SqlParameter("ExerciseGeology1Description", checkExerciseGeology1.Text));

                if (cboxExerciseGeology1.Text == "F")
                {
                    sqlExerciseGeology1.Add(new SqlParameter("ExerciseGeology1Status", "Incomplete"));
                }
                else if (cboxExerciseGeology1.Text == "")
                {
                    sqlExerciseGeology1.Add(new SqlParameter("ExerciseGeology1Status", DBNull.Value));
                }
                else
                {
                    sqlExerciseGeology1.Add(new SqlParameter("ExerciseGeology1Status", "Complete"));
                }

                DAL.ExecSP("CreateExerciseGeology1", sqlExerciseGeology1);
            }

            if (checkExerciseGeology2.Checked)
            {
                List<SqlParameter> sqlExerciseGeology2 = new List<SqlParameter>();
                sqlExerciseGeology2.Add(new SqlParameter("Username", Globals.username));
                sqlExerciseGeology2.Add(new SqlParameter("ExerciseGeology2Grade", cboxExerciseGeology2.Text));
                sqlExerciseGeology2.Add(new SqlParameter("ExerciseGeology2Description", checkExerciseGeology2.Text));

                if (cboxExerciseGeology2.Text == "F")
                {
                    sqlExerciseGeology2.Add(new SqlParameter("ExerciseGeology2Status", "Incomplete"));
                }
                else if (cboxExerciseGeology2.Text == "")
                {
                    sqlExerciseGeology2.Add(new SqlParameter("ExerciseGeology2Status", DBNull.Value));
                }
                else
                {
                    sqlExerciseGeology2.Add(new SqlParameter("ExerciseGeology2Status", "Complete"));
                }

                DAL.ExecSP("CreateExerciseGeology2", sqlExerciseGeology2);
            }

            if (checkAnatHealth1.Checked)
            {
                List<SqlParameter> sqlAnatHealth1 = new List<SqlParameter>();
                sqlAnatHealth1.Add(new SqlParameter("Username", Globals.username));
                sqlAnatHealth1.Add(new SqlParameter("AnatHealth1Grade", cboxAnatHealth1.Text));
                sqlAnatHealth1.Add(new SqlParameter("AnatHealth1Description", checkAnatHealth1.Text));

                if (cboxAnatHealth1.Text == "F")
                {
                    sqlAnatHealth1.Add(new SqlParameter("AnatHealth1Status", "Incomplete"));
                }
                else if (cboxAnatHealth1.Text == "")
                {
                    sqlAnatHealth1.Add(new SqlParameter("AnatHealth1Status", DBNull.Value));
                }
                else
                {
                    sqlAnatHealth1.Add(new SqlParameter("AnatHealth1Status", "Complete"));
                }

                DAL.ExecSP("CreateAnatHealth1", sqlAnatHealth1);
            }

            if (checkAnatHealth2.Checked)
            {
                List<SqlParameter> sqlAnatHealth2 = new List<SqlParameter>();
                sqlAnatHealth2.Add(new SqlParameter("Username", Globals.username));
                sqlAnatHealth2.Add(new SqlParameter("AnatHealth2Grade", cboxAnatHealth2.Text));
                sqlAnatHealth2.Add(new SqlParameter("AnatHealth2Description", checkAnatHealth2.Text));

                if (cboxAnatHealth2.Text == "F")
                {
                    sqlAnatHealth2.Add(new SqlParameter("AnatHealth2Status", "Incomplete"));
                }
                else if (cboxAnatHealth2.Text == "")
                {
                    sqlAnatHealth2.Add(new SqlParameter("AnatHealth2Status", DBNull.Value));
                }
                else
                {
                    sqlAnatHealth2.Add(new SqlParameter("AnatHealth2Status", "Complete"));
                }

                DAL.ExecSP("CreateAnatHealth2", sqlAnatHealth2);
            }

            if (checkBotany.Checked)
            {
                List<SqlParameter> sqlBotany = new List<SqlParameter>();
                sqlBotany.Add(new SqlParameter("Username", Globals.username));
                sqlBotany.Add(new SqlParameter("BotanyGrade", cboxBotany.Text));
                sqlBotany.Add(new SqlParameter("BotanyDescription", checkBotany.Text));

                if (cboxBotany.Text == "F")
                {
                    sqlBotany.Add(new SqlParameter("BotanyStatus", "Incomplete"));
                }
                else if (cboxBotany.Text == "")
                {
                    sqlBotany.Add(new SqlParameter("BotanyStatus", DBNull.Value));
                }
                else
                {
                    sqlBotany.Add(new SqlParameter("BotanyStatus", "Complete"));
                }

                DAL.ExecSP("CreateBotany", sqlBotany);
            }

            if (checkBiology.Checked)
            {
                List<SqlParameter> sqlBiology = new List<SqlParameter>();
                sqlBiology.Add(new SqlParameter("Username", Globals.username));
                sqlBiology.Add(new SqlParameter("BiologyGrade", cboxBiology.Text));
                sqlBiology.Add(new SqlParameter("BiologyDescription", checkBiology.Text));

                if (cboxBiology.Text == "F")
                {
                    sqlBiology.Add(new SqlParameter("BiologyStatus", "Incomplete"));
                }
                else if (cboxBiology.Text == "")
                {
                    sqlBiology.Add(new SqlParameter("BiologyStatus", DBNull.Value));
                }
                else
                {
                    sqlBiology.Add(new SqlParameter("BiologyStatus", "Complete"));
                }

                DAL.ExecSP("CreateBiology", sqlBiology);
            }

            if (checkAging.Checked)
            {
                List<SqlParameter> sqlAging = new List<SqlParameter>();
                sqlAging.Add(new SqlParameter("Username", Globals.username));
                sqlAging.Add(new SqlParameter("AgingGrade", cboxAging.Text));
                sqlAging.Add(new SqlParameter("AgingDescription", checkAging.Text));

                if (cboxAging.Text == "F")
                {
                    sqlAging.Add(new SqlParameter("AgingStatus", "Incomplete"));
                }
                else if (cboxAging.Text == "")
                {
                    sqlAging.Add(new SqlParameter("AgingStatus", DBNull.Value));
                }
                else
                {
                    sqlAging.Add(new SqlParameter("AgingStatus", "Complete"));
                }

                DAL.ExecSP("CreateAging", sqlAging);
            }

            if (checkHumanEvolution.Checked)
            {
                List<SqlParameter> sqlHumanEvolution = new List<SqlParameter>();
                sqlHumanEvolution.Add(new SqlParameter("Username", Globals.username));
                sqlHumanEvolution.Add(new SqlParameter("HumanEvolutionGrade", cboxHumanEvolution.Text));
                sqlHumanEvolution.Add(new SqlParameter("HumanEvolutionDescription", checkHumanEvolution.Text));

                if (cboxHumanEvolution.Text == "F")
                {
                    sqlHumanEvolution.Add(new SqlParameter("HumanEvolutionStatus", "Incomplete"));
                }
                else if (cboxHumanEvolution.Text == "")
                {
                    sqlHumanEvolution.Add(new SqlParameter("HumanEvolutionStatus", DBNull.Value));
                }
                else
                {
                    sqlHumanEvolution.Add(new SqlParameter("HumanEvolutionStatus", "Complete"));
                }

                DAL.ExecSP("CreateHumanEvolution", sqlHumanEvolution);
            }

            if (checkChemSociety.Checked)
            {
                List<SqlParameter> sqlChemSociety = new List<SqlParameter>();
                sqlChemSociety.Add(new SqlParameter("Username", Globals.username));
                sqlChemSociety.Add(new SqlParameter("ChemSocietyGrade", cboxChemSociety.Text));
                sqlChemSociety.Add(new SqlParameter("ChemSocietyDescription", checkChemSociety.Text));

                if (cboxChemSociety.Text == "F")
                {
                    sqlChemSociety.Add(new SqlParameter("ChemSocietyStatus", "Incomplete"));
                }
                else if (cboxChemSociety.Text == "")
                {
                    sqlChemSociety.Add(new SqlParameter("ChemSocietyStatus", DBNull.Value));
                }
                else
                {
                    sqlChemSociety.Add(new SqlParameter("ChemSocietyStatus", "Complete"));
                }

                DAL.ExecSP("CreateChemSociety", sqlChemSociety);
            }

            if (checkChemEveryone.Checked)
            {
                List<SqlParameter> sqlChemEveryone = new List<SqlParameter>();
                sqlChemEveryone.Add(new SqlParameter("Username", Globals.username));
                sqlChemEveryone.Add(new SqlParameter("ChemEveryoneGrade", cboxChemEveryone.Text));
                sqlChemEveryone.Add(new SqlParameter("ChemEveryoneDescription", checkChemEveryone.Text));

                if (cboxChemEveryone.Text == "F")
                {
                    sqlChemEveryone.Add(new SqlParameter("ChemEveryoneStatus", "Incomplete"));
                }
                else if (cboxChemEveryone.Text == "")
                {
                    sqlChemEveryone.Add(new SqlParameter("ChemEveryoneStatus", DBNull.Value));
                }
                else
                {
                    sqlChemEveryone.Add(new SqlParameter("ChemEveryoneStatus", "Complete"));
                }

                DAL.ExecSP("CreateChemEveryone", sqlChemEveryone);
            }

            if (checkBasicChem.Checked)
            {
                List<SqlParameter> sqlBasicChem = new List<SqlParameter>();
                sqlBasicChem.Add(new SqlParameter("Username", Globals.username));
                sqlBasicChem.Add(new SqlParameter("BasicChemGrade", cboxBasicChem.Text));
                sqlBasicChem.Add(new SqlParameter("BasicChemDescription", checkBasicChem.Text));

                if (cboxBasicChem.Text == "F")
                {
                    sqlBasicChem.Add(new SqlParameter("BasicChemStatus", "Incomplete"));
                }
                else if (cboxBasicChem.Text == "")
                {
                    sqlBasicChem.Add(new SqlParameter("BasicChemStatus", DBNull.Value));
                }
                else
                {
                    sqlBasicChem.Add(new SqlParameter("BasicChemStatus", "Complete"));
                }

                DAL.ExecSP("CreateBasicChem", sqlBasicChem);
            }

            if (checkIntroChem.Checked)
            {
                List<SqlParameter> sqlIntroChem = new List<SqlParameter>();
                sqlIntroChem.Add(new SqlParameter("Username", Globals.username));
                sqlIntroChem.Add(new SqlParameter("IntroChemGrade", cboxIntroChem.Text));
                sqlIntroChem.Add(new SqlParameter("IntroChemDescription", checkIntroChem.Text));

                if (cboxIntroChem.Text == "F")
                {
                    sqlIntroChem.Add(new SqlParameter("IntroChemStatus", "Incomplete"));
                }
                else if (cboxIntroChem.Text == "")
                {
                    sqlIntroChem.Add(new SqlParameter("IntroChemStatus", DBNull.Value));
                }
                else
                {
                    sqlIntroChem.Add(new SqlParameter("IntroChemStatus", "Complete"));
                }

                DAL.ExecSP("CreateIntroChem", sqlIntroChem);
            }

            if (checkIntroAnalChem.Checked)
            {
                List<SqlParameter> sqlIntroAnalChem = new List<SqlParameter>();
                sqlIntroAnalChem.Add(new SqlParameter("Username", Globals.username));
                sqlIntroAnalChem.Add(new SqlParameter("IntroAnalChemGrade", cboxIntroAnalChem.Text));
                sqlIntroAnalChem.Add(new SqlParameter("IntroAnalChemDescription", checkIntroAnalChem.Text));

                if (cboxIntroAnalChem.Text == "F")
                {
                    sqlIntroAnalChem.Add(new SqlParameter("IntroAnalChemStatus", "Incomplete"));
                }
                else if (cboxIntroAnalChem.Text == "")
                {
                    sqlIntroAnalChem.Add(new SqlParameter("IntroAnalChemStatus", DBNull.Value));
                }
                else
                {
                    sqlIntroAnalChem.Add(new SqlParameter("IntroAnalChemStatus", "Complete"));
                }

                DAL.ExecSP("CreateIntroAnalChem", sqlIntroAnalChem);
            }

            if (checkDescAstronomy.Checked)
            {
                List<SqlParameter> sqlDescAstronomy = new List<SqlParameter>();
                sqlDescAstronomy.Add(new SqlParameter("Username", Globals.username));
                sqlDescAstronomy.Add(new SqlParameter("DescAstronomyGrade", cboxDescAstronomy.Text));
                sqlDescAstronomy.Add(new SqlParameter("DescAstronomyDescription", checkDescAstronomy.Text));

                if (cboxDescAstronomy.Text == "F")
                {
                    sqlDescAstronomy.Add(new SqlParameter("DescAstronomyStatus", "Incomplete"));
                }
                else if (cboxDescAstronomy.Text == "")
                {
                    sqlDescAstronomy.Add(new SqlParameter("DescAstronomyStatus", DBNull.Value));
                }
                else
                {
                    sqlDescAstronomy.Add(new SqlParameter("DescAstronomyStatus", "Complete"));
                }

                DAL.ExecSP("CreateDescAstronomy", sqlDescAstronomy);
            }

            if (checkMusicSoundPhysics.Checked)
            {
                List<SqlParameter> sqlMusicSoundPhysics = new List<SqlParameter>();
                sqlMusicSoundPhysics.Add(new SqlParameter("Username", Globals.username));
                sqlMusicSoundPhysics.Add(new SqlParameter("MusicSoundPhysicsGrade", cboxMusicSoundPhysics.Text));
                sqlMusicSoundPhysics.Add(new SqlParameter("MusicSoundPhysicsDescription", checkMusicSoundPhysics.Text));

                if (cboxMusicSoundPhysics.Text == "F")
                {
                    sqlMusicSoundPhysics.Add(new SqlParameter("MusicSoundPhysicsStatus", "Incomplete"));
                }
                else if (cboxMusicSoundPhysics.Text == "")
                {
                    sqlMusicSoundPhysics.Add(new SqlParameter("MusicSoundPhysicsStatus", DBNull.Value));
                }
                else
                {
                    sqlMusicSoundPhysics.Add(new SqlParameter("MusicSoundPhysicsStatus", "Complete"));
                }

                DAL.ExecSP("CreateMusicSoundPhysics", sqlMusicSoundPhysics);
            }

            if (checkLight.Checked)
            {
                List<SqlParameter> sqlLight = new List<SqlParameter>();
                sqlLight.Add(new SqlParameter("Username", Globals.username));
                sqlLight.Add(new SqlParameter("LightGrade", cboxLight.Text));
                sqlLight.Add(new SqlParameter("LightDescription", checkLight.Text));

                if (cboxLight.Text == "F")
                {
                    sqlLight.Add(new SqlParameter("LightStatus", "Incomplete"));
                }
                else if (cboxLight.Text == "")
                {
                    sqlLight.Add(new SqlParameter("LightStatus", DBNull.Value));
                }
                else
                {
                    sqlLight.Add(new SqlParameter("LightStatus", "Complete"));
                }

                DAL.ExecSP("CreateLight", sqlLight);
            }

            if (checkTechPhysicsMech1.Checked)
            {
                List<SqlParameter> sqlTechPhysicsMech1 = new List<SqlParameter>();
                sqlTechPhysicsMech1.Add(new SqlParameter("Username", Globals.username));
                sqlTechPhysicsMech1.Add(new SqlParameter("TechPhysicsMech1Grade", cboxTechPhysicsMech1.Text));
                sqlTechPhysicsMech1.Add(new SqlParameter("TechPhysicsMech1Description", checkTechPhysicsMech1.Text));

                if (cboxTechPhysicsMech1.Text == "F")
                {
                    sqlTechPhysicsMech1.Add(new SqlParameter("TechPhysicsMech1Status", "Incomplete"));
                }
                else if (cboxTechPhysicsMech1.Text == "")
                {
                    sqlTechPhysicsMech1.Add(new SqlParameter("TechPhysicsMech1Status", DBNull.Value));
                }
                else
                {
                    sqlTechPhysicsMech1.Add(new SqlParameter("TechPhysicsMech1Status", "Complete"));
                }

                DAL.ExecSP("CreateTechPhysicsMech1", sqlTechPhysicsMech1);
            }

            if (checkTechPhysicsMech2.Checked)
            {
                List<SqlParameter> sqlTechPhysicsMech2 = new List<SqlParameter>();
                sqlTechPhysicsMech2.Add(new SqlParameter("Username", Globals.username));
                sqlTechPhysicsMech2.Add(new SqlParameter("TechPhysicsMech2Grade", cboxTechPhysicsMech2.Text));
                sqlTechPhysicsMech2.Add(new SqlParameter("TechPhysicsMech2Description", checkTechPhysicsMech2.Text));

                if (cboxTechPhysicsMech2.Text == "F")
                {
                    sqlTechPhysicsMech2.Add(new SqlParameter("TechPhysicsMech2Status", "Incomplete"));
                }
                else if (cboxTechPhysicsMech2.Text == "")
                {
                    sqlTechPhysicsMech2.Add(new SqlParameter("TechPhysicsMech2Status", DBNull.Value));
                }
                else
                {
                    sqlTechPhysicsMech2.Add(new SqlParameter("TechPhysicsMech2Status", "Complete"));
                }

                DAL.ExecSP("CreateTechPhysicsMech2", sqlTechPhysicsMech2);
            }

            if (checkTechPhysicsElect.Checked)
            {
                List<SqlParameter> sqlTechPhysicsElect = new List<SqlParameter>();
                sqlTechPhysicsElect.Add(new SqlParameter("Username", Globals.username));
                sqlTechPhysicsElect.Add(new SqlParameter("TechPhysicsElectGrade", cboxTechPhysicsElect.Text));
                sqlTechPhysicsElect.Add(new SqlParameter("TechPhysicsElectDescription", checkTechPhysicsElect.Text));

                if (cboxTechPhysicsElect.Text == "F")
                {
                    sqlTechPhysicsElect.Add(new SqlParameter("TechPhysicsElectStatus", "Incomplete"));
                }
                else if (cboxTechPhysicsElect.Text == "")
                {
                    sqlTechPhysicsElect.Add(new SqlParameter("TechPhysicsElectStatus", DBNull.Value));
                }
                else
                {
                    sqlTechPhysicsElect.Add(new SqlParameter("TechPhysicsElectStatus", "Complete"));
                }

                DAL.ExecSP("CreateTechPhysicsElect", sqlTechPhysicsElect);
            }

            if (checkTechPhysicsHeat.Checked)
            {
                List<SqlParameter> sqlTechPhysicsHeat = new List<SqlParameter>();
                sqlTechPhysicsHeat.Add(new SqlParameter("Username", Globals.username));
                sqlTechPhysicsHeat.Add(new SqlParameter("TechPhysicsHeatGrade", cboxTechPhysicsHeat.Text));
                sqlTechPhysicsHeat.Add(new SqlParameter("TechPhysicsHeatDescription", checkTechPhysicsHeat.Text));

                if (cboxTechPhysicsHeat.Text == "F")
                {
                    sqlTechPhysicsHeat.Add(new SqlParameter("TechPhysicsHeatStatus", "Incomplete"));
                }
                else if (cboxTechPhysicsHeat.Text == "")
                {
                    sqlTechPhysicsHeat.Add(new SqlParameter("TechPhysicsHeatStatus", DBNull.Value));
                }
                else
                {
                    sqlTechPhysicsHeat.Add(new SqlParameter("TechPhysicsHeatStatus", "Complete"));
                }

                DAL.ExecSP("CreateTechPhysicsHeat", sqlTechPhysicsHeat);
            }

            if (checkIntroEnviSci.Checked)
            {
                List<SqlParameter> sqlIntroEnviSci = new List<SqlParameter>();
                sqlIntroEnviSci.Add(new SqlParameter("Username", Globals.username));
                sqlIntroEnviSci.Add(new SqlParameter("IntroEnviSciGrade", cboxIntroEnviSci.Text));
                sqlIntroEnviSci.Add(new SqlParameter("IntroEnviSciDescription", checkIntroEnviSci.Text));

                if (cboxIntroEnviSci.Text == "F")
                {
                    sqlIntroEnviSci.Add(new SqlParameter("IntroEnviSciStatus", "Incomplete"));
                }
                else if (cboxIntroEnviSci.Text == "")
                {
                    sqlIntroEnviSci.Add(new SqlParameter("IntroEnviSciStatus", DBNull.Value));
                }
                else
                {
                    sqlIntroEnviSci.Add(new SqlParameter("IntroEnviSciStatus", "Complete"));
                }

                DAL.ExecSP("CreateIntroEnviSci", sqlIntroEnviSci);
            }

            Register_SocSci frmRegister_SocSci = new Register_SocSci();
            frmRegister_SocSci.Show();
            this.Hide();
        }
    }
}
