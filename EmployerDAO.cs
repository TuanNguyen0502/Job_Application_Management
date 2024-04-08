using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job_Application_Management
{
    public class EmployerDAO
    {
        private DBConnection dbConnection;
        private string connStr = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Jobs_Management;Integrated Security=True";

        public EmployerDAO()
        {
            this.dbConnection = new DBConnection();
        }

        public void Execute(string sqlStr)
        {
            dbConnection.ExecuteWriteData(sqlStr);
        }
        public List<UC_CandidateProfile> GetCandidateProfileFromDB()
        {
            string sqlQuery = $"SELECT P.CddID, C.CddName, P.Objective, P.UniversityName, P.Major, P.GPA, P.CompanyName, P.Workplace, " +
                $"P.CertificationName " +
                $"FROM CandidateProfile P INNER JOIN Candidates C ON P.CddID = C.CddID";
            List<Dictionary<string, object>> resultList = dbConnection.ExecuteReaderData(sqlQuery);
            List<UC_CandidateProfile> items = new List<UC_CandidateProfile>();
            foreach (var row in resultList)
            {
                UC_CandidateProfile item = new UC_CandidateProfile();
                item.CddID = (string)row["CddID"];
                item.Label_Name.Text = (string)row["CddName"];
                item.Label_University.Text = (string)row["UniversityName"];
                item.Label_Major.Text += row["Major"].ToString();
                item.Label_GPA.Text = row["GPA"].ToString();
                item.Label_Company.Text = (string)row["CompanyName"];
                item.Label_Workplace.Text = (string)row["Workplace"];
                item.Label_Certification.Text = (string)row["CertificationName"];
                items.Add(item);
            }
            return items;
        }

        public void UpdateResume(CV resume)
        {
            string sqlStr = string.Format($"UPDATE Resume SET Status = N'{resume.Status}' WHERE CddID = '{resume.CddID}' " +
                $"AND JobID = '{resume.JobID}'");
            Execute(sqlStr);
        }

        public List<UC_CandidateCV> GetCandidateResumeFromDB(int jobID, string status)
        {
            string sqlQuery = $"SELECT R.CddID, C.CddName, R.UniversityName, R.Major, R.GPA " +
                $"FROM Resume R INNER JOIN Candidates C ON R.CddID = C.CddID " +
                $"WHERE JobID = '{jobID}' AND Status = N'{status}'";
            List<Dictionary<string, object>> resultList = dbConnection.ExecuteReaderData(sqlQuery);
            List<UC_CandidateCV> items = new List<UC_CandidateCV>();
            foreach (var row in resultList)
            {
                UC_CandidateCV item = new UC_CandidateCV(jobID);
                item.CddID = (string)row["CddID"];
                item.Label_Name.Text = (string)row["CddName"];
                item.Label_University.Text = (string)row["UniversityName"];
                item.Label_Major.Text += (string)row["Major"];
                item.Label_GPA.Text += (string)row["GPA"];
                items.Add(item);
            }
            return items;
        }

        public CV GetResumeFromDB(int jobID, string cddID)
        {
            CV resume = new CV();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string sqlQuery = $"SELECT R.CddID, R.JobID, R.Objective, R.UniversityName, R.Major, R.GPA, R.UniversityStartDate, R.UniversityEndDate, " +
                    $"R.CompanyName, R.WorkPlace, R.Detail, R.CompanyStartDate, R.CompanyEndDate, R.CertificationName, R.CertificationDate, " +
                    $"R.Status, " +
                    $"C.CddName, C.Phone, C.Email, C.CddAddress, " +
                    $"J.Name " +
                    $"FROM Resume R INNER JOIN Candidates C ON R.CddID = C.CddID " +
                    $"INNER JOIN Jobs J ON R.JobID = J.ID " +
                    $"WHERE R.CddID = '{cddID}' AND R.JobID = '{jobID}'";
                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        resume.CddID = reader.GetString(0);
                        resume.JobID = reader.GetInt32(1);
                        resume.Objective = reader.GetString(2);
                        resume.UniversityName = reader.GetString(3);
                        resume.Major = reader.GetString(4);
                        resume.Gpa = reader.GetString(5);
                        resume.UniversityStartDate = reader.GetDateTime(6);
                        resume.UniversityEndDate = reader.GetDateTime(7);
                        resume.CompanyName = reader.GetString(8);
                        resume.WorkPlace = reader.GetString(9);
                        resume.WorkedDetail = reader.GetString(10);
                        resume.CompanyStartDate = reader.GetDateTime(11);
                        resume.CompanyEndDate = reader.GetDateTime(12);
                        resume.Certification = reader.GetString(13);
                        resume.TimeCertificate = reader.GetDateTime(14);
                        resume.Status = reader.GetString(15);
                        resume.CddName = reader.GetString(16);
                        resume.CddPhone = reader.GetString(17);
                        resume.CddEmail = reader.GetString(18);
                        resume.CddAddress = reader.GetString(19);
                        resume.JobName = reader.GetString(20);
                    }
                }
                else
                    MessageBox.Show("No rows found");
            }
            return resume;
        }

        public Company GetCompanyFromDB(string companyName)
        {
            Company company = new Company();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string sqlQuery = $"SELECT Name, Address, Manager, TaxCode, BusinessLicense FROM Company WHERE Name = '{companyName}'";
                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        company.Name = reader.GetString(0);
                        company.Address = reader.GetString(1);
                        company.Manager = reader.GetString(2);
                        company.TaxCode = reader.GetString(3);
                        company.BusinessLicense = reader.GetString(4);
                    }
                }
                else
                    MessageBox.Show("No rows found");
            }
            return company;
        }

        public Employer GetEmployerFromDB(string empID)
        {
            Employer employer = new Employer();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string sqlQuery = $"SELECT ID, Email, Name, Sex, Phone, Workplace, CompanyName FROM Employers WHERE ID = '{empID}'";
                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        employer.Id = reader.GetString(0);
                        employer.Email = reader.GetString(1);
                        employer.Name = reader.GetString(2);
                        employer.Sex = reader.GetString(3);
                        employer.Phone = reader.GetString(4);
                        employer.Workplace = reader.GetString(5);
                        employer.CompanyName = reader.GetString(6);
                    }
                }
                else
                    MessageBox.Show("No rows found");
            }
            return employer;
        }

        public void UpdateCompanyInfor(Company company)
        {
            string sqlStr = string.Format($"UPDATE Company SET Address = N'{company.Address}', " +
                $"Manager = N'{company.Manager}', TaxCode = '{company.TaxCode}', BusinessLicense = '{company.BusinessLicense}' " +
                $"WHERE Name = '{company.Name}'");
            Execute(sqlStr);
        }

        public void UpdateEmployerInfor(Employer employer)
        {
            string sqlStr = string.Format($"UPDATE Employers SET Email = '{employer.Email}', Name = N'{employer.Name}', Sex = N'{employer.Sex}', " +
                $"Phone = '{employer.Phone}', Workplace = N'{employer.Workplace}' WHERE ID = '{employer.Id}'");
            Execute(sqlStr);
        }

        public void AddJob(Job job)
        {
            string sqlStr = string.Format($"INSERT INTO Jobs (Name, Salary, JobDecription, WorkDuration, Experience, ExpirationDate, " +
                $"Benefit, RequestCdd, PostTime, EmpID) VALUES (N'{job.Name}', '{job.Salary}', " +
                $"'{job.JobDescription}', '{job.WorkDuration}', '{job.Experience}', '{job.Deadline.ToString("yyyy-MM-dd")}', '{job.Benefit}', " +
                $"'{job.Request}', '{job.PostTime.ToString("yyyy-MM-dd")}', '{job.EmpID}')");

            Execute(sqlStr);
        }

        public void UpdateJob(Job job)
        {
            string sqlStr = string.Format($"UPDATE Jobs SET Name = '{job.Name}', Salary = '{job.Salary}', " +
                $"JobDecription = '{job.JobDescription}', WorkDuration = '{job.WorkDuration}', " +
                $"Experience = '{job.Experience}', ExpirationDate = '{job.Deadline.ToString("yyyy-MM-dd")}', Benefit = '{job.Benefit}', RequestCdd = '{job.Request}', " +
                $"PostTime = '{job.PostTime.ToString("yyyy-MM-dd")}' WHERE ID = '{job.Id}'");

            Execute(sqlStr);
        }

        public void DeleteJob(string jobID)
        {
            string sqlStr = string.Format($"DELETE FROM Jobs WHERE ID = '{jobID}'");

            Execute(sqlStr);
        }

        public List<UC_EmployerJob> GetJobsFromDB(string empID)
        {
            string sqlQuery = $"SELECT Name, Salary, PostTime, ExpirationDate, ID FROM Jobs WHERE EmpID = '{empID}'";
            List<Dictionary<string, object>> resultList = dbConnection.ExecuteReaderData(sqlQuery);
            List<UC_EmployerJob> items = new List<UC_EmployerJob>();
            foreach (var row in resultList)
            {
                UC_EmployerJob item = new UC_EmployerJob(empID);
                item.Label_JobName.Text = (string)row["Name"];
                item.Label_Salary.Text += row["Salary"].ToString();
                DateTime postTime = (DateTime)row["PostTime"];
                string formattedPostTime = postTime.ToString("yyyy-MM-dd");
                item.Label_PostedTime.Text = formattedPostTime;
                DateTime deadline = (DateTime)row["ExpirationDate"];
                string formattedDeadline = postTime.ToString("yyyy-MM-dd");
                item.Label_Deadline.Text += formattedDeadline;
                item.JobID = (int)row["ID"];
                items.Add(item);
            }
            return items;
        }

    }
}
