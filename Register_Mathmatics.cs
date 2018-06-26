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
    public partial class Register_Mathmatics : Form
    {
        public Register_Mathmatics()
        {
            InitializeComponent();
        }

        private void Register_Mathmatics_Load(object sender, EventArgs e)
        {
            lblMath.Font = new Font(lblMath.Font, FontStyle.Bold);
        }

        private void Register_Mathmatics_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (checkIntermediateAlgebra.Checked)
            {
                List<SqlParameter> sqlIntermediateAlgebra = new List<SqlParameter>();
                sqlIntermediateAlgebra.Add(new SqlParameter("Username", Globals.username));
                sqlIntermediateAlgebra.Add(new SqlParameter("IntermediateAlgebraGrade", cboxIntermediateAlgebra.Text));
                sqlIntermediateAlgebra.Add(new SqlParameter("IntermediateAlgebraDescription", checkIntermediateAlgebra.Text));

                if (cboxIntermediateAlgebra.Text == "F")
                {
                    sqlIntermediateAlgebra.Add(new SqlParameter("IntermediateAlgebraStatus", "Incomplete"));
                }
                else if (cboxIntermediateAlgebra.Text == "")
                {
                    sqlIntermediateAlgebra.Add(new SqlParameter("IntermediateAlgebraStatus", DBNull.Value));
                }
                else
                {
                    sqlIntermediateAlgebra.Add(new SqlParameter("IntermediateAlgebraStatus", "Complete"));
                }

                DAL.ExecSP("CreateIntermediateAlgebra", sqlIntermediateAlgebra);
            }

            if (checkExcursionsinMathmatics.Checked)
            {
                List<SqlParameter> sqlExcursionsinMathmatics = new List<SqlParameter>();
                sqlExcursionsinMathmatics.Add(new SqlParameter("Username", Globals.username));
                sqlExcursionsinMathmatics.Add(new SqlParameter("ExcursionsinMathmaticsGrade", cboxExcursionsinMathmatics.Text));
                sqlExcursionsinMathmatics.Add(new SqlParameter("ExcursionsinMathmaticsDescription", checkExcursionsinMathmatics.Text));

                if (cboxExcursionsinMathmatics.Text == "F")
                {
                    sqlExcursionsinMathmatics.Add(new SqlParameter("ExcursionsinMathmaticsStatus", "Incomplete"));
                }
                else if (cboxExcursionsinMathmatics.Text == "")
                {
                    sqlExcursionsinMathmatics.Add(new SqlParameter("ExcursionsinMathmaticsStatus", DBNull.Value));
                }
                else
                {
                    sqlExcursionsinMathmatics.Add(new SqlParameter("ExcursionsinMathmaticsStatus", "Complete"));
                }

                DAL.ExecSP("CreateExcursionsinMathmatics", sqlExcursionsinMathmatics);
            }

            if (checkCollegeAlgebra.Checked)
            {
                List<SqlParameter> sqlCollegeAlgebra = new List<SqlParameter>();
                sqlCollegeAlgebra.Add(new SqlParameter("Username", Globals.username));
                sqlCollegeAlgebra.Add(new SqlParameter("CollegeAlgebraGrade", cboxCollegeAlgebra.Text));
                sqlCollegeAlgebra.Add(new SqlParameter("CollegeAlgebraDescription", checkCollegeAlgebra.Text));

                if (cboxCollegeAlgebra.Text == "F")
                {
                    sqlCollegeAlgebra.Add(new SqlParameter("CollegeAlgebraStatus", "Incomplete"));
                }
                else if (cboxCollegeAlgebra.Text == "")
                {
                    sqlCollegeAlgebra.Add(new SqlParameter("CollegeAlgebraStatus", DBNull.Value));
                }
                else
                {
                    sqlCollegeAlgebra.Add(new SqlParameter("CollegeAlgebraStatus", "Complete"));
                }

                DAL.ExecSP("CreateCollegeAlgebra", sqlCollegeAlgebra);
            }

            Register_NatSci frmRegister_NatSci = new Register_NatSci();
            frmRegister_NatSci.Show();
            this.Hide();
        }
    }
}
