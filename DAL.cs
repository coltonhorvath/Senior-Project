using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DARS
{
    //This data access layer allows the program to run a stored procedure from SSMS
    public static class DAL
    {

        public static DataTable ExecSP(string spName, List<SqlParameter> sqlParams = null)
        {
            string strConnect = "Server=DESKTOP-2Q73COU\\SQLEXPRESS;Database=LoginApp;Trusted_Connection=True;";

            //New Connection
            SqlConnection conn = new SqlConnection();

            //Creates a table to work with and check itself with SSMS
            DataTable dt = new DataTable();

            try
            {
                //Connect to the database
                conn = new SqlConnection(strConnect);
                conn.Open();

                //Build an sql command/query
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(sqlParams.ToArray());

                //Execute the command
                SqlCommand command = conn.CreateCommand();
                //Sqldata reader reads the return from the command
                SqlDataReader dr = cmd.ExecuteReader();

                //Need to fill the data table with the results
                dt.Load(dr);


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                //No matter what happens, this will run.
                conn.Close();
            }

            //Returns the data table with all the data in it.
            return dt;
        }
    }
}
