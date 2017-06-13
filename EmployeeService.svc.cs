using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace EmplyeeServiceProject
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in code, svc and config file together.
    public class EmployeeService : IEmployeeService
    {

        static private string sqlConString
        {
            get { return ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString; }
        }
        SqlConnection conn = new SqlConnection(sqlConString);

       
        public List<ArchieveData> GetArchieveLogsList()
        {

            List<ArchieveData> archieveLogs = new List<ArchieveData>();

            using (SqlConnection con = new SqlConnection("Database Connection String"))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT [logs],[fromDate],[toDate] FROM [dbo].[Logs]", con))
                {
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        ArchieveData logs = new ArchieveData();
                        logs.Logs = dr[0].ToString();
                        logs.FromDate = Convert.ToDateTime(dr[1].ToString());
                        logs.ToDate = Convert.ToDateTime(dr[2].ToString());
                        archieveLogs.Add(logs);
                    }
                }
            }

            return archieveLogs;
        }
    }
}
  
            
           


