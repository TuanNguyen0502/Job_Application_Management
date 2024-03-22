using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
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
        public List<UC_CandidateMain> GetJobsFromDB()
        {
            sqlQuery = "SELECT JobName, CompanyName, Salary, WorkAddress, JobID FROM Jobs";
            List<Dictionary<string,object>> resultList = dbConn.ExecuteReaderData(sqlQuery);
            List<UC_CandidateMain> items = new List<UC_CandidateMain>();
            foreach(var row in resultList)
            {
                UC_CandidateMain item = new UC_CandidateMain();
                item.JobName = (string)row["JobName"];
                item.CompanyName1 = (string)row["CompanyName"];
                item.Salary = (int)row["Salary"];
                item.Address = (string)row["WorkAddress"];
                item.JobID = (string)row["JobID"];
                items.Add(item);
            }
            return items;
        }
        public List<UC_CandidateMain> GetJobsByAddress(string address)
        {
            sqlQuery = "SELECT JobName, CompanyName, Salary, WorkAddress, JobID FROM Jobs" +
                " WHERE WorkAddress LIKE N'%"+ address +"%'";
            List<Dictionary<string, object>> resultList = dbConn.ExecuteReaderData(sqlQuery);
            List<UC_CandidateMain> items = new List<UC_CandidateMain>();
            foreach (var row in resultList)
            {
                UC_CandidateMain item = new UC_CandidateMain();
                item.JobName = (string)row["JobName"];
                item.CompanyName1 = (string)row["CompanyName"];
                item.Salary = (int)row["Salary"];
                item.Address = (string)row["WorkAddress"];
                item.JobID = (string)row["JobID"];
                items.Add(item);
            }
            return items;
        }
        public List<UC_CandidateMain> GetJobsByKeywords(string keyword)
        {
            sqlQuery = "SELECT JobName, CompanyName, Salary, WorkAddress, JobID FROM Jobs " +
                        "WHERE WorkAddress LIKE N'%"+ keyword +"%'"+ "OR JobName LIKE N'%"+ keyword +"%'" +
                        "OR CompanyName LIKE N'%"+ keyword +"%'" +
                        "OR JobID LIKE N'%"+ keyword +"%'";
            List<Dictionary<string, object>> resultList = dbConn.ExecuteReaderData(sqlQuery);
            List<UC_CandidateMain> items = new List<UC_CandidateMain>();
            foreach (var row in resultList)
            {
                UC_CandidateMain item = new UC_CandidateMain();
                item.JobName = (string)row["JobName"];
                item.CompanyName1 = (string)row["CompanyName"];
                item.Salary = (int)row["Salary"];
                item.Address = (string)row["WorkAddress"];
                item.JobID = (string)row["JobID"];
                items.Add(item);
            }
            return items;
        }
        public List<UC_JobsSaved> GetSavedJobsFromDB()
        {
            sqlQuery = "SELECT j.JobDecription, j.CompanyName, js.TimeSaved, j.WorkAddress, j.Salary FROM JobsSaved js JOIN Jobs j ON js.JobID = j.JobID";
            List<Dictionary<string, object>> keyValueSavedJobs = dbConn.ExecuteReaderData(sqlQuery);
            List<UC_JobsSaved> saveds = new List<UC_JobsSaved>();
            foreach (var row in keyValueSavedJobs)
            {
                UC_JobsSaved item = new UC_JobsSaved();
                item.DescriptionJob = (string)row["JobDecription"];
                item.ComName = (string)row["CompanyName"];
                item.TimeSaved = (DateTime)row["TimeSaved"];
                item.Address = (string)row["WorkAddress"];
                item.Salary = (int)row["Salary"];
                saveds.Add(item);
            }
            return saveds;
        }
        public List<Dictionary<string, object>> GetSelectedJobDetails(string jobid)
        {
            sqlQuery = "SELECT JobName, WorkAddress, Salary, Experience, CompanyName FROM Jobs WHERE JobID = @jobId";
            SqlParameter[] lstParam =
            {
                new SqlParameter("@jobId", SqlDbType.VarChar) {Value = jobid},
            };
            List<Dictionary<string, object>> keyValueJobDetails = dbConn.ExecuteReaderData(sqlQuery, lstParam);
            return keyValueJobDetails;
        }
    }
}
