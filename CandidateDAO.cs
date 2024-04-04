using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Job_Application_Management
{
    // Các lớp đối tượng truy cập dữ liệu. cung cấp đối tượng tại nhiều lớp khác nhau cho phép gọi dữ liệu đã xây 
    // dựng trước đó
    public class CandidateDAO
    {
        DBConnection dbConn;
        UC_Resume resume = new UC_Resume();
        public List<Dictionary<string, object>> listCVs = new List<Dictionary<string, object>>();
        string sqlQuery;
        public CandidateDAO()
        {
            dbConn = new DBConnection();
        }
        
        public List<UC_CandidateMain> GetJobsFromDB(string cddid)
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
                item.CddID = cddid;
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
            sqlQuery = "SELECT j.Name JobName, c.Name CompanyName, j.Salary, c.Address, j.Experience, j.PostTime, j.JobDecription,                       j.WorkDuration, j.RequestCdd, j.Benefit"
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
        public List<Dictionary<string, object>> GetCompanyFromDB(string companyName)
        {
            sqlQuery = $"SELECT *"
                        +" FROM Company"
                        +" WHERE Name = @CompanyName";
            SqlParameter[] lstParam =
            {
                new SqlParameter("@CompanyName", SqlDbType.NVarChar) { Value = companyName },
            };
            return dbConn.ExecuteReaderData(sqlQuery, lstParam);
        }
        public void SaveAvailableCV(string cddid)
        {
            CV cv = resume.GetInfoResumeAtForm();
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict["CddID"] = cddid;
            dict["Objective"] = cv.Objective;
            dict["UniversityName"] = cv.UniversityName;
            dict["Major"] = cv.Major;
            dict["GPA"] = cv.Gpa;
            dict["UniversityStartDate"] = cv.UniversityStartDate;
            dict["UniversityEndDate"] = cv.UniversityEndDate;
            dict["WorkPlace"] = cv.WorkPlace;
            dict["Detail"] = cv.WorkedDetail;
            dict["CompanyStartDate"] = cv.CompanyStartDate;
            dict["CompanyEndDate"] = cv.CompanyEndDate;
            dict["CertificationName"] = cv.Certification;
            dict["CertificationDate"] = cv.CertificationDate;
            dict["Status"] = cv.Status;
            foreach (var kvp in dict)
                MessageBox.Show($"Key: {kvp.Key} Value: {kvp.Value}");
            listCVs.Add(dict);
        }

        public CV GetAvailableCVByCandidateID(string cddid)
        {
            foreach (Dictionary<string, object> item in listCVs)
                if ((string)item["CddID"] == cddid)
                {
                    CV cv = new CV();
                    cv.CddID = cddid;
                    cv.Objective = (string)item["Objective"];
                    cv.UniversityName = (string)item["UniversityName"];
                    cv.Major = (string)item["Major"];
                    cv.Gpa = (string)item["GPA"];
                    cv.UniversityStartDate = (DateTime)item["UniversityStartDate"];
                    cv.UniversityEndDate = (DateTime)item["UniversityEndDate"];
                    cv.CompanyName = (string)item["CompanyName"];
                    cv.CompanyStartDate = (DateTime)item["CompanyStartDate"];
                    cv.CompanyEndDate = (DateTime)item["CompanyEndDate"];
                    cv.WorkPlace = (string)item["WorkPlace"];
                    cv.WorkedDetail = (string)item["Detail"];
                    cv.Certification = (string)item["CertificationName"];
                    cv.CertificationDate = (DateTime)item["CertificationDate"];
                    cv.Status = (string)item["Status"];
                    foreach (var kvp in item)
                    {
                        MessageBox.Show($"Key: {kvp.Key} Value: {kvp.Value}");
                    }
                    return cv;
                }
            return null;
        }
        public void SaveResumeToDatabase(CV cv, string CddID, string JobID)
        {
            if (cv != null)
            {
                sqlQuery = "INSERT INTO Resume (CddID, JobID, Objective, UniversityName, Major, GPA, UniversityStartDate, UniversityEndDate, CompanyName, WorkPlace, Detail, CompanyStartDate, CompanyEndDate, " +
                       "CertificationName, CertificationDate)" +
                       " VALUES(@CddID, @JobID, @Objective, @UniversityName, @Major, @GPA, @UniversityStartDate, @UniversityEndDate, @CompanyName, @WorkPlace, @Detail, @CompanyStartDate, @CompanyEndDate, @CertificationName, @CertificationDate)";
                SqlParameter[] lstParams =
                {
                new SqlParameter("@CddID", SqlDbType.VarChar) {Value = CddID},
                new SqlParameter("@JobID", SqlDbType.VarChar) {Value = JobID},
                new SqlParameter("@Objective", SqlDbType.Text) {Value = cv.Objective},
                new SqlParameter("@UniversityName", SqlDbType.NVarChar) {Value = cv.UniversityName},
                new SqlParameter("@Major", SqlDbType.NVarChar) {Value = cv.Major},
                new SqlParameter("@GPA", SqlDbType.NVarChar) {Value = cv.Gpa},
                new SqlParameter("@UniversityStartDate", SqlDbType.Date) {Value = cv.UniversityStartDate},
                new SqlParameter("@UniversityEndDate", SqlDbType.Date) {Value = cv.UniversityEndDate},
                new SqlParameter("@CompanyName", SqlDbType.NVarChar) {Value = cv.CompanyName},
                new SqlParameter("@WorkPlace", SqlDbType.NVarChar) {Value = cv.WorkPlace},
                new SqlParameter("@Detail", SqlDbType.Text) {Value = cv.WorkedDetail},
                new SqlParameter("@CompanyStartDate", SqlDbType.Date) {Value = cv.CompanyStartDate},
                new SqlParameter("@CompanyEndDate", SqlDbType.Date) {Value = cv.CompanyEndDate},
                new SqlParameter("@CertificationName", SqlDbType.NVarChar) {Value = cv.Certification},
                new SqlParameter("@CertificationDate", SqlDbType.Date) {Value = cv.CertificationDate},
                };
                dbConn.ExecuteWriteData(sqlQuery, lstParams);
            }
            else
            {
                MessageBox.Show("CV be null. Check CV");
            }
        }
    }
}
