using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Job_Application_Management
{
    public class CandidateDAO
    {
        DBConnection dbConn;
        string sqlQuery;
        public CandidateDAO()
        {
            dbConn = new DBConnection();
        }
        public void GetJobsFromDB(FCandidate cdd)
        {
            sqlQuery = "SELECT JobName, CompanyName, Salary, WorkAddress, JobID FROM Jobs";
            SqlDataReader reader = dbConn.ExecuteReaderData(sqlQuery);
            if (reader != null)
            {
                while (reader.Read())
                {
                    UC_CandidateMain item = new UC_CandidateMain();
                    item = new UC_CandidateMain();
                    item.JobName = reader.GetString(0);
                    item.CompanyName1 = reader.GetString(1);
                    item.Salary = reader.GetInt32(2);
                    item.Address = reader.GetString(3);
                    item.JobID = reader.GetString(4);
                    //lstItems[i].Icon = 
                    if (cdd.FlpScrollPane.Controls.Count < 0)
                    {
                        cdd.FlpScrollPane.Controls.Clear();
                    }
                    else
                        cdd.FlpScrollPane.Controls.Add(item);
                }
            }
        }
        public void GetSavedJobsFromDB(FCandidate_SavedJobs saved)
        {
            sqlQuery = "SELECT j.JobDecription, j.CompanyName, js.TimeSaved, j.WorkAddress, j.Salary FROM JobsSaved js JOIN Jobs j ON js.JobID = j.JobID";
            SqlDataReader reader = dbConn.ExecuteReaderData (sqlQuery);
            if (reader != null)
            {
                while (reader.Read())
                {
                    UC_JobsSaved item = new UC_JobsSaved();
                    item.DescriptionJob = reader.GetString(0);
                    item.ComName = reader.GetString(1);
                    item.TimeSaved = reader.GetDateTime(2);
                    item.Address = reader.GetString(3);
                    item.Salary = reader.GetInt32(4);
                    if (saved.FlpMain.Controls.Count < 0)
                    {
                        saved.FlpMain.Controls.Clear();
                    }
                    else
                    {
                        saved.FlpMain.Controls.Add(item);
                    }
                }
            }
        }
    }
}
