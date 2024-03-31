using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Job_Application_Management
{
    // Các lớp đối tượng truy cập dữ liệu. cung cấp đối tượng tại nhiều lớp khác nhau cho phép gọi dữ liệu đã xây 
    // dựng trước đó
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
            sqlQuery = "SELECT j.ID JobID, j.Name JobName, c.Name CompanyName, j.Salary, c.Address"
                        +" FROM Jobs j"
                        +" JOIN Employers e ON j.EmpID = e.ID"
                        +" JOIN Company c ON e.CompanyName = c.Name";
            List<Dictionary<string, object>> resultList = dbConn.ExecuteReaderData(sqlQuery);
            List<UC_CandidateMain> items = new List<UC_CandidateMain>();
            foreach (var row in resultList)
            {
                UC_CandidateMain item = new UC_CandidateMain();
                item.JobName = (string)row["JobName"];
                item.CompanyName1 = (string)row["CompanyName"];
                item.Salary = (int)row["Salary"];
                item.Address = (string)row["Address"];
                item.JobID = (string)row["JobID"];
                items.Add(item);
            }
            return items;
        }
        public List<UC_CandidateMain> GetJobsByAddress(string address)
        {
            sqlQuery = "SELECT j.ID JobID, j.Name JobName, c.Name CompanyName, j.Salary, c.Address"
                        +" FROM Jobs j"
                        +" JOIN Employers e ON j.EmpID = e.ID"
                        +" JOIN Company c ON e.CompanyName = c.Name"
                        +" WHERE c.Address LIKE N'%"+ address +"%'";
            List<Dictionary<string, object>> resultList = dbConn.ExecuteReaderData(sqlQuery);
            List<UC_CandidateMain> items = new List<UC_CandidateMain>();
            foreach (var row in resultList)
            {
                UC_CandidateMain item = new UC_CandidateMain();
                item.JobName = (string)row["JobName"];
                item.CompanyName1 = (string)row["CompanyName"];
                item.Salary = (int)row["Salary"];
                item.Address = (string)row["Address"];
                item.JobID = (string)row["JobID"];
                items.Add(item);
            }
            return items;
        }
        public List<UC_CandidateMain> GetJobsByKeywords(string keyword)
        {
            sqlQuery = "SELECT j.ID JobID, j.Name JobName, c.Name CompanyName, j.Salary, c.Address"
                        +" FROM Jobs j"
                        +" JOIN Employers e ON j.EmpID = e.ID"
                        +" JOIN Company c ON e.CompanyName = c.Name"
                        +" WHERE c.Address LIKE N'%"+ keyword +"%'"
                        +" OR j.Name LIKE N'%"+ keyword +"%'"
                        +" OR c.Name LIKE N'%"+ keyword +"%'"
                        +" OR j.ID LIKE N'%"+ keyword +"%'";
            List<Dictionary<string, object>> resultList = dbConn.ExecuteReaderData(sqlQuery);
            List<UC_CandidateMain> items = new List<UC_CandidateMain>();
            foreach (var row in resultList)
            {
                UC_CandidateMain item = new UC_CandidateMain();
                item.JobName = (string)row["JobName"];
                item.CompanyName1 = (string)row["CompanyName"];
                item.Salary = (int)row["Salary"];
                item.Address = (string)row["Address"];
                item.JobID = (string)row["JobID"];
                items.Add(item);
            }
            return items;
        }
        public List<UC_JobsSaved> GetSavedJobsFromDB()
        {
            sqlQuery = "SELECT j.Name, j.JobDecription, c.Name as CompanyName, sj.TimeSaved, c.Address, j.Salary"
                       +" FROM SavedJobs sj"
                       +" JOIN Jobs j ON sj.JobID = j.ID"
                       +" JOIN Employers e ON j.EmpID = e.ID"
                       +" JOIN Company c ON c.Name = e.CompanyName";
            List<Dictionary<string, object>> keyValueSavedJobs = dbConn.ExecuteReaderData(sqlQuery);
            List<UC_JobsSaved> saveds = new List<UC_JobsSaved>();
            foreach (var row in keyValueSavedJobs)
            {
                UC_JobsSaved item = new UC_JobsSaved();
                item.DescriptionJob = (string)row["Name"] + " [" + (string)row["JobDecription"] + "]";
                item.ComName = (string)row["CompanyName"];
                item.TimeSaved = (DateTime)row["TimeSaved"];
                item.Address = (string)row["Address"];
                item.Salary = (int)row["Salary"];
                saveds.Add(item);
            }
            return saveds;
        }
        public List<UC_JobsSaved> GetAppliedJobsFromDB()
        {
            sqlQuery = "SELECT j.Name, j.JobDecription, c.Name as CompanyName, aj.TimeApplied, c.Address, j.Salary"
                       +" FROM AppliedJobs aj"
                       +" JOIN Jobs j ON aj.JobID = j.ID"
                       +" JOIN Employers e ON j.EmpID = e.ID"
                       +" JOIN Company c ON c.Name = e.CompanyName";
            List<Dictionary<string, object>> keyValueSavedJobs = dbConn.ExecuteReaderData(sqlQuery);
            List<UC_JobsSaved> saveds = new List<UC_JobsSaved>();
            foreach (var row in keyValueSavedJobs)
            {
                UC_JobsSaved item = new UC_JobsSaved();
                item.DescriptionJob = (string)row["Name"] + " [" + (string)row["JobDecription"] + "]";
                item.ComName = (string)row["CompanyName"];
                item.TimeSaved = (DateTime)row["TimeApplied"];
                item.Address = (string)row["Address"];
                item.Salary = (int)row["Salary"];
                saveds.Add(item);
            }
            return saveds;
        }
        public List<Dictionary<string, object>> GetSelectedJobDetails(string jobid)
        {
            sqlQuery = "SELECT j.Name JobName, c.Name CompanyName, j.Salary, c.Address, j.Experience, j.PostTime"
                        +" FROM Jobs j"
                        +" JOIN Employers e ON j.EmpID = e.ID"
                        +" JOIN Company c ON e.CompanyName = c.Name"
                        +" WHERE j.ID = @jobId";
            SqlParameter[] lstParam =
            {
                new SqlParameter("@jobId", SqlDbType.VarChar) {Value = jobid},
            };
            List<Dictionary<string, object>> keyValueJobDetails = dbConn.ExecuteReaderData(sqlQuery, lstParam);
            return keyValueJobDetails;
        }
        public void SaveSavedJob(string jobid)
        {
            sqlQuery = "INSERT INTO SavedJobs(TimeSaved, JobID)" +
                            " VALUES(@times,@jId)";
            SqlParameter[] lstParam =
            {
                    new SqlParameter("@times", SqlDbType.Date) {Value = DateTime.Today},
                    new SqlParameter("@jId", SqlDbType.VarChar) { Value = jobid },
                };
            dbConn.ExecuteWriteData(sqlQuery, lstParam);
        }
        public void SaveAppliedJob(string jobid)
        {
            sqlQuery = "INSERT INTO AppliedJobs(TimeApplied, JobID)" +
                            " VALUES(@times,@jId)";
            SqlParameter[] lstParam =
            {
                    new SqlParameter("@times", SqlDbType.Date) {Value = DateTime.Today},
                    new SqlParameter("@jId", SqlDbType.VarChar) { Value = jobid },
                };
            dbConn.ExecuteWriteData(sqlQuery, lstParam);
        }
        public void SaveCVToDatabase(CV cv)
        {
            sqlQuery = "INSERT INTO Resume                              (CddID,JobID,Objective,UniversityName,Major,UniversityStartDate," 
                + "UniversityEndDate,CompanyName,WorkPlace,"
                + "CertificationName,CertificationDate)"
              +" VALUE(@cddId,@jobId,@obj,@un,@major,@usd,@ued,@company,@workplace,@cername,@cerdate)";
            SqlParameter[] lstParams =
            {
                new SqlParameter("@cddId", SqlDbType.VarChar) {Value = cv.CddID},
                new SqlParameter("@jobId", SqlDbType.VarChar) {Value = cv.JobID},
                new SqlParameter("@obj", SqlDbType.Text) {Value = cv.CareerGoal},
                new SqlParameter("@un", SqlDbType.NVarChar) {Value = cv.USchool},
                new SqlParameter("@major", SqlDbType.NVarChar) {Value = cv.Major},
                new SqlParameter("@usd", SqlDbType.DateTime) {Value = cv.StartDate},
                new SqlParameter("@ued", SqlDbType.DateTime) {Value = cv.EndDate},
                new SqlParameter("@company", SqlDbType.NVarChar) {Value = cv.WorkedCompanyName},
                new SqlParameter("@workplace", SqlDbType.NVarChar) {Value = cv.WorkedWorkPlace},
                new SqlParameter("@cername", SqlDbType.NVarChar) {Value = cv.Certificate},
                new SqlParameter("@cerdate", SqlDbType.DateTime) {Value = cv.TimeCertificate},
            };
            dbConn.ExecuteWriteData(sqlQuery, lstParams);
        }
    }
}
