using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
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

        public List<UC_Employer_Interview> SearchInterviewsFromDB(string empID, string keyword)
        {
            string sqlQuery = $"SELECT * " +
                $"FROM Interviews I INNER JOIN Candidates C ON I.CddID = C.CddID " +
                                  $"INNER JOIN Jobs J ON I.JobID = J.ID " +
                $"WHERE CONCAT(I.CddID, C.CddName, C.Phone, C.Email, C.CddAddress, C.Hometown, C.Sex, C.Education, " +
                             $"I.JobID, J.Name, J.Salary, J.ExpirationDate, J.PostTime, I.InterviewTime, I.Note) LIKE N'%' + '{keyword}' + '%' " +
                      $"AND I.EmpID = '{empID}'";
            List<Dictionary<string, object>> resultList = dbConnection.ExecuteReaderData(sqlQuery);
            List<UC_Employer_Interview> items = new List<UC_Employer_Interview>();
            foreach (var row in resultList)
            {
                UC_Employer_Interview item = new UC_Employer_Interview(empID, (string)row["CddID"], (int)row["ID"]);
                item.Label_JobName.Text = (string)row["Name"];
                item.Label_CandidateName.Text = (string)row["CddName"];
                item.Label_InterviewTime.Text = row["InterviewTime"].ToString();
                item.Label_Note.Text = row["Note"].ToString();
                items.Add(item);
            }
            return items;
        }

        public List<UC_Employer_Interview> GetInterviewsFromDB(string empID)
        {
            string sqlQuery = $"SELECT J.ID, J.Name, C.CddName, C.CddID, I.InterviewTime, I.Note " +
                $"FROM Interviews I INNER JOIN Candidates C ON I.CddID = C.CddID " +
                $"INNER JOIN Jobs J ON I.JobID = J.ID " +
                $"WHERE I.EmpID = '{empID}'";
            List<Dictionary<string, object>> resultList = dbConnection.ExecuteReaderData(sqlQuery);
            List<UC_Employer_Interview> items = new List<UC_Employer_Interview>();
            foreach (var row in resultList)
            {
                UC_Employer_Interview item = new UC_Employer_Interview(empID, (string)row["CddID"], (int)row["ID"]);
                item.Label_JobName.Text = (string)row["Name"];
                item.Label_CandidateName.Text = (string)row["CddName"];
                item.Label_InterviewTime.Text = row["InterviewTime"].ToString();
                item.Label_Note.Text = row["Note"].ToString();
                items.Add(item);
            }
            return items;
        }

        public void DeleteInterview(Interview interview)
        {
            string sqlStr = string.Format($"DELETE FROM Interviews WHERE ID = '{interview.Id}'");
            Execute(sqlStr);
        }

        public void UpdateInterview(Interview interview)
        {
            string sqlStr = string.Format($"UPDATE Interviews SET InterviewTime = '{interview.InterviewTime}', Note = N'{interview.Note}' " +
                $"WHERE ID = '{interview.Id}'");
            Execute(sqlStr);
        }

        public void AddInterview(Interview interview)
        {
            string sqlStr = string.Format($"INSERT INTO Interviews (EmpID, CddID, JobID, InterviewTime, Note) " +
                $"VALUES ('{interview.EmpID}', '{interview.CddID}', '{interview.JobID}', '{interview.InterviewTime}', N'{interview.Note}')");
            Execute(sqlStr);
        }

        public Interview GetInterviewFormDB(string empID, string cddID, int jobID)
        {
            Interview interview = new Interview();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string sqlQuery = $"SELECT ID, EmpID, CddID, JobID, InterviewTime, Note " +
                    $"FROM Interviews " +
                    $"WHERE EmpID = '{empID}' AND CddID = '{cddID}' AND JobID = '{jobID}'";
                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        interview.Id = reader.GetInt32(0);
                        interview.EmpID = reader.GetString(1);
                        interview.CddID = reader.GetString(2);
                        interview.JobID = reader.GetInt32(3);
                        interview.InterviewTime = reader.GetDateTime(4);
                        interview.Note = reader.GetString(5);
                    }
                }
                else
                    MessageBox.Show("No rows found");
                conn.Close();
            }
            return interview;
        }

        public List<UC_CoverLetter> GetCandidateProfileFromDB()
        {
            string sqlQuery = $"SELECT P.CddID, C.CddName, P.Objective, P.UniversityName, P.Major, P.GPA, P.CompanyName, P.Workplace, " +
                $"P.CertificationName " +
                $"FROM CandidateProfile P INNER JOIN Candidates C ON P.CddID = C.CddID";
            List<Dictionary<string, object>> resultList = dbConnection.ExecuteReaderData(sqlQuery);
            List<UC_CoverLetter> items = new List<UC_CoverLetter>();
            foreach (var row in resultList)
            {
                UC_CoverLetter item = new UC_CoverLetter();
                item.CddID = (string)row["CddID"];
                item.textBox_Name.Text = (string)row["CddName"];
                item.textBox_University.Text = (string)row["UniversityName"];
                item.textBox_Major.Text += row["Major"].ToString();
                item.textBox_GPA.Text = row["GPA"].ToString();
                item.textBox_Company.Text = (string)row["CompanyName"];
                item.textBox_Workplace.Text = (string)row["Workplace"];
                item.textBox_Certification.Text = (string)row["CertificationName"];
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

        public List<UC_CandidateCV> GetCandidateResumeFromDB(string empID, int jobID, string status)
        {
            string sqlQuery = $"SELECT R.CddID, C.CddName, R.UniversityName, R.Major, R.GPA " +
                $"FROM Resume R INNER JOIN Candidates C ON R.CddID = C.CddID " +
                $"WHERE JobID = '{jobID}' AND Status = N'{status}'";
            List<Dictionary<string, object>> resultList = dbConnection.ExecuteReaderData(sqlQuery);
            List<UC_CandidateCV> items = new List<UC_CandidateCV>();
            foreach (var row in resultList)
            {
                UC_CandidateCV item = new UC_CandidateCV(empID, jobID);
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
                List<Dictionary<string, object>> resultList = dbConnection.ExecuteReaderData(sqlQuery);
                foreach (var row in resultList)
                {
                    resume.CddID = (string)row["CddID"];
                    resume.JobID = Int32.Parse(row["JobID"].ToString());
                    resume.Objective = (string)row["Objective"];
                    resume.UniversityName = (string)row["UniversityName"];
                    resume.Major = (string)row["Major"];
                    resume.Gpa = (string)row["GPA"];
                    resume.UniversityStartDate = (DateTime)row["UniversityStartDate"];
                    resume.UniversityEndDate = (DateTime)row["UniversityEndDate"];
                    resume.CompanyName = (string)row["CompanyName"];
                    resume.WorkPlace = (string)row["WorkPlace"];
                    resume.WorkedDetail = (string)row["Detail"];
                    resume.CompanyStartDate = (DateTime)row["CompanyStartDate"];
                    resume.CompanyEndDate = (DateTime)row["CompanyEndDate"];
                    resume.Certification = (string)row["CertificationName"];
                    resume.CertificationDate = (DateTime)row["CertificationDate"];
                    resume.Status = (string)row["Status"];
                    resume.CddName = (string)row["CddName"];
                    resume.CddPhone = (string)row["Phone"];
                    resume.CddEmail = (string)row["Email"];
                    resume.CddAddress = (string)row["CddAddress"];
                    resume.JobName = (string)row["Name"];
                }
            }
            return resume;
        }

        public Company GetCompanyFromDB(string companyName)
        {
            Company company = new Company();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string sqlQuery = $"SELECT Name, Address, Manager, TaxCode, BusinessLicense, NumberOfEmployee, NumberOfFollower, Introduction " +
                    $"FROM Company WHERE Name = '{companyName}'";
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
                        company.NumberOfEmployee = reader.GetInt32(5);
                        company.NumberOfFollower = reader.GetInt32(6);
                        company.Introduction = reader.GetString(7);
                    }
                }
                else
                    MessageBox.Show("No rows found");
            }
            return company;
        }

        public void UpdateCompanyInfor(Company company)
        {
            string sqlStr = string.Format($"UPDATE Company SET Address = N'{company.Address}', " +
                $"Manager = N'{company.Manager}', TaxCode = '{company.TaxCode}', BusinessLicense = '{company.BusinessLicense}', " +
                $"NumberOfEmployee = '{company.NumberOfEmployee}', NumberOfFollower = '{company.NumberOfFollower}', Introduction = N'{company.Introduction}' " +
                $"WHERE Name = '{company.Name}'");
            Execute(sqlStr);
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

        public Job GetJobFromDB(int jobID)
        {
            Job job = new Job();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string sqlQuery = $"SELECT ID, Name, Salary, JobDecription, Workduration, Experience, ExpirationDate, Benefit, RequestCdd, " +
                    $"PostTime FROM Jobs WHERE ID = '{jobID}'";
                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        job.Id = Convert.ToInt32(reader["ID"]);
                        job.Name = reader.GetString(1);
                        job.Salary = reader.GetInt32(2);
                        job.JobDescription = reader.GetString(3);
                        job.WorkDuration = reader.GetString(4);
                        job.Experience = reader.GetString(5);
                        job.Deadline = reader.GetDateTime(6);
                        job.Benefit = reader.GetString(7);
                        job.Request = reader.GetString(8);
                        job.PostTime = reader.GetDateTime(9);
                    }
                }
                else
                    MessageBox.Show("No rows found");

                return job;
            }
        }

        public List<UC_EmployerJob> GetJobsFromDB(string empID)
        {
            string sqlQuery = $"SELECT Name, Salary, PostTime, ExpirationDate, ID FROM Jobs WHERE EmpID = '{empID}'";

            List<Dictionary<string, object>> resultList = dbConnection.ExecuteReaderData(sqlQuery);
            List<UC_EmployerJob> items = new List<UC_EmployerJob>();

            foreach (var row in resultList)
            {
                string sqlQuery2 = $"SELECT Count(CddID) as SL " +
                    $"FROM Resume " +
                    $"WHERE JobID = '{(int)row["ID"]}' " +
                    $"GROUP BY JobID";
                string number = dbConnection.ExecuteReaderCount(sqlQuery2);

                UC_EmployerJob item = new UC_EmployerJob(empID);
                item.JobID = (int)row["ID"];
                item.Label_JobName.Text = (string)row["Name"];
                item.Label_Salary.Text += row["Salary"].ToString();
                DateTime postTime = (DateTime)row["PostTime"];
                string formattedPostTime = postTime.ToString("yyyy-MM-dd");
                item.Label_PostedTime.Text = formattedPostTime;
                DateTime deadline = (DateTime)row["ExpirationDate"];
                string formattedDeadline = postTime.ToString("yyyy-MM-dd");
                item.Label_Deadline.Text += formattedDeadline;
                item.Label_NumberCandidates.Text += number;
                items.Add(item);
            }
            return items;
        }

    }
}
