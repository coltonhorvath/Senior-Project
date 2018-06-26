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
    public partial class Register_OralComm : Form
    {
        public Register_OralComm()
        {
            InitializeComponent();
        }

        //view Register "using"
        /*public string username
        {
            get { return txtUser.Text; }
        }*/

        private void Register_OralComm_Load(object sender, EventArgs e)
        {
            lblOralComm.Font = new Font(lblOralComm.Font, FontStyle.Bold);
        }

        private void Register_OralComm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (checkIntrotoPublicSpeaking.Checked)
            {
                List<SqlParameter> sqlIntrotoPublicSpeaking = new List<SqlParameter>();
                sqlIntrotoPublicSpeaking.Add(new SqlParameter("Username", Globals.username));
                sqlIntrotoPublicSpeaking.Add(new SqlParameter("IntrotoPublicSpeakingGrade", cboxIntrotoPublicSpeaking.Text));
                sqlIntrotoPublicSpeaking.Add(new SqlParameter("IntrotoPublicSpeakingDescription", checkIntrotoPublicSpeaking.Text));

                if (cboxIntrotoPublicSpeaking.Text == "F")
                {
                    sqlIntrotoPublicSpeaking.Add(new SqlParameter("IntrotoPublicSpeakingStatus", "Incomplete"));
                }
                else if (cboxIntrotoPublicSpeaking.Text == "")
                {
                    sqlIntrotoPublicSpeaking.Add(new SqlParameter("IntrotoPublicSpeakingStatus", DBNull.Value));
                }
                else
                {
                    sqlIntrotoPublicSpeaking.Add(new SqlParameter("IntrotoPublicSpeakingStatus", "Complete"));
                }

                DAL.ExecSP("CreateIntrotoPublicSpeaking", sqlIntrotoPublicSpeaking);
            }

            if (checkEffectiveOralCommunication.Checked)
            {
                List<SqlParameter> sqlEffectiveOralCommunication = new List<SqlParameter>();
                sqlEffectiveOralCommunication.Add(new SqlParameter("Username", Globals.username));
                sqlEffectiveOralCommunication.Add(new SqlParameter("EffectiveOralCommunicationGrade", cboxEffectiveOralCommunication.Text));
                sqlEffectiveOralCommunication.Add(new SqlParameter("EffectiveOralCommunicationDescription", checkEffectiveOralCommunication.Text));

                if (cboxEffectiveOralCommunication.Text == "F")
                {
                    sqlEffectiveOralCommunication.Add(new SqlParameter("EffectiveOralCommunicationStatus", "Incomplete"));
                }
                else if (cboxEffectiveOralCommunication.Text == "")
                {
                    sqlEffectiveOralCommunication.Add(new SqlParameter("EffectiveOralCommunicationStatus", DBNull.Value));
                }
                else
                {
                    sqlEffectiveOralCommunication.Add(new SqlParameter("EffectiveOralCommunicationStatus", "Complete"));
                }

                DAL.ExecSP("CreateEffectiveOralCommunication", sqlEffectiveOralCommunication);
            }

            if (checkProfComm.Checked)
            {
                List<SqlParameter> sqlProfComm = new List<SqlParameter>();
                sqlProfComm.Add(new SqlParameter("Username", Globals.username));
                sqlProfComm.Add(new SqlParameter("ProfCommGrade", cboxProfComm.Text));
                sqlProfComm.Add(new SqlParameter("ProfCommDescription", checkProfComm.Text));

                if (cboxProfComm.Text == "F")
                {
                    sqlProfComm.Add(new SqlParameter("ProfCommStatus", "Incomplete"));
                }
                else if (cboxProfComm.Text == "")
                {
                    sqlProfComm.Add(new SqlParameter("ProfCommStatus", DBNull.Value));
                }
                else
                {
                    sqlProfComm.Add(new SqlParameter("ProfCommStatus", "Complete"));
                }

                DAL.ExecSP("CreateProfComm", sqlProfComm);
            }

            Register_English frmRegister_English = new Register_English();
            frmRegister_English.Show();
            this.Hide();
        }
    }
}
