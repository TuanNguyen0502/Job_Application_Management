using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;


namespace Job_Application_Management
{
    public class EmployerDAO
    {
        private DBConnection dbConnection = new DBConnection();
        private string connStr = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Jobs_Management;Integrated Security=True";

        public EmployerDAO()
        {
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
            if (dbConnection.ExecuteWriteDataCheck(sqlStr))
            {
                MessageBox.Show("Successfully cleared interview time");
            }
        }

        public void UpdateInterview(Interview interview)
        {
            string sqlStr = string.Format($"UPDATE Interviews SET InterviewTime = '{interview.InterviewTime}', Note = N'{interview.Note}' " +
                $"WHERE ID = '{interview.Id}'");
            if (dbConnection.ExecuteWriteDataCheck(sqlStr))
            {
                MessageBox.Show("Successfully updated interview");
            }
        }

        public bool CheckCandidateInterviewTimeExists(DateTime interviewTime, string cddID)
        {
            string query = "SELECT COUNT(*) FROM Interviews WHERE InterviewTime = @InterviewTime AND CddID = @CddID";
            SqlParameter[] lstParams =
            {
                new SqlParameter("@InterviewTime", SqlDbType.DateTime) {Value = interviewTime},
                new SqlParameter("@CddID", SqlDbType.VarChar) {Value = cddID},
            };
            int count = dbConnection.ExecuteScalarGetInt(query, lstParams);
            return count > 0; // Return true if InterviewTime already exists, false otherwise
        }

        public bool CheckEmployerInterviewTimeExists(DateTime interviewTime, string empID)
        {
            string query = "SELECT COUNT(*) FROM Interviews WHERE InterviewTime = @InterviewTime AND EmpID = @EmpID";
            SqlParameter[] lstParams =
            {
                new SqlParameter("@InterviewTime", SqlDbType.DateTime) {Value = interviewTime},
                new SqlParameter("@EmpID", SqlDbType.VarChar) {Value = empID},
            };
            int count = dbConnection.ExecuteScalarGetInt(query, lstParams);
            return count > 0; // Return true if InterviewTime already exists, false otherwise
        }

        public void AddInterview(Interview interview)
        {
            string sqlStr = "INSERT INTO Interviews (EmpID, CddID, JobID, InterviewTime, Note)" +
                            " VALUES (@EmpID, @CddID, @JobID, @InterviewTime, @Note)";
            SqlParameter[] lstParams =
            {
                new SqlParameter("@EmpID", SqlDbType.VarChar) {Value = interview.EmpID},
                new SqlParameter("@CddID", SqlDbType.VarChar) {Value = interview.CddID},
                new SqlParameter("@JobID", SqlDbType.Int) {Value = interview.JobID},
                new SqlParameter("@InterviewTime", SqlDbType.DateTime) {Value = interview.InterviewTime},
                new SqlParameter("@Note", SqlDbType.NVarChar) {Value = interview.Note},
            };
            if (dbConnection.ExecuteWriteDataCheck(sqlStr, lstParams))
            {
                MessageBox.Show("Create new interview time successfully");
            }
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

        public List<UC_Employer_Coverletter> GetCandidateProfileFromDB()
        {
            string sqlQuery = $"SELECT P.CddID, C.CddName, P.Objective, P.UniversityName, P.Major, P.GPA, P.CompanyName, P.Workplace, " +
                $"P.CertificationName " +
                $"FROM CandidateProfile P INNER JOIN Candidates C ON P.CddID = C.CddID";
            List<Dictionary<string, object>> resultList = dbConnection.ExecuteReaderData(sqlQuery);
            List<UC_Employer_Coverletter> items = new List<UC_Employer_Coverletter>();
            foreach (var row in resultList)
            {
                UC_Employer_Coverletter item = new UC_Employer_Coverletter();
                item.CddID = (string)row["CddID"];
                item.Label_Objective.Text = (string)row["Objective"];
                item.Label_University.Text = (string)row["UniversityName"];
                item.Label_Major.Text = row["Major"].ToString();
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
            if (dbConnection.ExecuteWriteDataCheck(sqlStr))
            {
                MessageBox.Show("Resume approved");
            }
        }

        public List<UC_Employer_CandidateResume> GetCandidateResumeFromDB(string empID, int jobID, string status)
        {
            string sqlQuery = $"SELECT R.CddID, C.CddName, R.UniversityName, R.Major, R.GPA " +
                $"FROM Resume R INNER JOIN Candidates C ON R.CddID = C.CddID " +
                $"WHERE JobID = '{jobID}' AND Status = N'{status}'";
            List<Dictionary<string, object>> resultList = dbConnection.ExecuteReaderData(sqlQuery);
            List<UC_Employer_CandidateResume> items = new List<UC_Employer_CandidateResume>();
            foreach (var row in resultList)
            {
                UC_Employer_CandidateResume item = new UC_Employer_CandidateResume(empID, jobID);
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
                    resume.UniversityStartDate = (string)row["UniversityStartDate"];
                    resume.UniversityEndDate = (string)row["UniversityEndDate"];
                    resume.CompanyName = (string)row["CompanyName"];
                    resume.WorkPlace = (string)row["WorkPlace"];
                    resume.WorkedDetail = (string)row["Detail"];
                    resume.CompanyStartDate = (string)row["CompanyStartDate"];
                    resume.CompanyEndDate = (string)row["CompanyEndDate"];
                    resume.Certification = (string)row["CertificationName"];
                    resume.CertificationDate = (string)row["CertificationDate"];
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
            if (dbConnection.ExecuteWriteDataCheck(sqlStr))
            {
                MessageBox.Show("Successfully updated company information");
            }
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
            if (dbConnection.ExecuteWriteDataCheck(sqlStr))
            {
                MessageBox.Show("Successfully updated employer information");
            }
        }

        public void AddJob(Job job)
        {
            string sqlStr = string.Format($"INSERT INTO Jobs (Name, Salary, JobDecription, WorkDuration, Experience, ExpirationDate, " +
                $"Benefit, RequestCdd, PostTime, EmpID) VALUES (N'{job.Name}', '{job.Salary}', " +
                $"'{job.JobDescription}', '{job.WorkDuration}', '{job.Experience}', '{job.Deadline.ToString("yyyy-MM-dd")}', '{job.Benefit}', " +
                $"'{job.Request}', '{job.PostTime.ToString("yyyy-MM-dd")}', '{job.EmpID}')");

            if (dbConnection.ExecuteWriteDataCheck(sqlStr))
            {
                MessageBox.Show("Add new job successfully");
            }
        }

        public void UpdateJob(Job job)
        {
            string sqlStr = string.Format($"UPDATE Jobs SET Name = '{job.Name}', Salary = '{job.Salary}', " +
                $"JobDecription = '{job.JobDescription}', WorkDuration = '{job.WorkDuration}', " +
                $"Experience = '{job.Experience}', ExpirationDate = '{job.Deadline.ToString("yyyy-MM-dd")}', Benefit = '{job.Benefit}', RequestCdd = '{job.Request}', " +
                $"PostTime = '{job.PostTime.ToString("yyyy-MM-dd")}' WHERE ID = '{job.Id}'");

            if (dbConnection.ExecuteWriteDataCheck(sqlStr))
            {
                MessageBox.Show("Job update successful");
            }
        }

        public void DeleteJob(string jobID)
        {
            string sqlStr = string.Format($"DELETE FROM Jobs WHERE ID = '{jobID}'");

            if (dbConnection.ExecuteWriteDataCheck(sqlStr))
            {
                MessageBox.Show("Deleted job successfully");
            }
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
                        job.WorkDuration = reader.GetInt32(4).ToString();
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

        public List<UC_Employer_Job> GetJobsFromDB(string empID)
        {
            string sqlQuery = $"SELECT Name, Salary, PostTime, ExpirationDate, ID FROM Jobs WHERE EmpID = '{empID}'";

            List<Dictionary<string, object>> resultList = dbConnection.ExecuteReaderData(sqlQuery);
            List<UC_Employer_Job> items = new List<UC_Employer_Job>();

            foreach (var row in resultList)
            {
                string sqlQuery2 = $"SELECT Count(CddID) as SL " +
                    $"FROM Resume " +
                    $"WHERE JobID = '{(int)row["ID"]}' AND Status = 'Applying' " +
                    $"GROUP BY JobID";
                int numberApplied = dbConnection.ExecuteReaderCount(sqlQuery2);
                string sqlQuery3 = $"SELECT Count(CddID) as SL " +
                    $"FROM Resume " +
                    $"WHERE JobID = '{(int)row["ID"]}' AND Status = 'Approved' " +
                    $"GROUP BY JobID";
                int numberApproved = dbConnection.ExecuteReaderCount(sqlQuery3);

                UC_Employer_Job item = new UC_Employer_Job(empID);
                item.JobID = (int)row["ID"];
                item.Label_JobName.Text = (string)row["Name"];
                item.Label_Salary.Text += row["Salary"].ToString();
                DateTime postTime = (DateTime)row["PostTime"];
                string formattedPostTime = postTime.ToString("yyyy-MM-dd");
                item.Label_PostedTime.Text = formattedPostTime;
                DateTime deadline = (DateTime)row["ExpirationDate"];
                string formattedDeadline = postTime.ToString("yyyy-MM-dd");
                item.Label_Deadline.Text += formattedDeadline;
                item.Label_NumberAppliedCandidates.Text += numberApplied.ToString();
                item.Label_NumberApprovedCandidates.Text += numberApproved.ToString();
                item.NumberApplied = numberApplied;
                item.NumberApproved = numberApproved;
                items.Add(item);
            }
            return items;
        }

        public List<UC_Employer_Job> SearchJobsFromDB(string empID, string keyword)
        {
            string sqlQuery = $"SELECT Name, Salary, PostTime, ExpirationDate, ID FROM Jobs " +
                $"WHERE EmpID = '{empID}' " +
                      $"AND CONCAT(ID, Name, Salary, JobDecription, WorkDuration, Experience, Benefit, RequestCdd, PostTime, ExpirationDate) LIKE N'%' + '{keyword}' + '%'";

            List<Dictionary<string, object>> resultList = dbConnection.ExecuteReaderData(sqlQuery);
            List<UC_Employer_Job> items = new List<UC_Employer_Job>();

            foreach (var row in resultList)
            {
                string sqlQuery2 = $"SELECT Count(CddID) as SL " +
                    $"FROM Resume " +
                    $"WHERE JobID = '{(int)row["ID"]}' AND Status = 'Applying' " +
                    $"GROUP BY JobID";
                int numberApplied = dbConnection.ExecuteReaderCount(sqlQuery2);
                string sqlQuery3 = $"SELECT Count(CddID) as SL " +
                    $"FROM Resume " +
                    $"WHERE JobID = '{(int)row["ID"]}' AND Status = 'Approved' " +
                    $"GROUP BY JobID";
                int numberApproved = dbConnection.ExecuteReaderCount(sqlQuery3);

                UC_Employer_Job item = new UC_Employer_Job(empID);
                item.JobID = (int)row["ID"];
                item.Label_JobName.Text = (string)row["Name"];
                item.Label_Salary.Text += row["Salary"].ToString();
                DateTime postTime = (DateTime)row["PostTime"];
                string formattedPostTime = postTime.ToString("yyyy-MM-dd");
                item.Label_PostedTime.Text = formattedPostTime;
                DateTime deadline = (DateTime)row["ExpirationDate"];
                string formattedDeadline = postTime.ToString("yyyy-MM-dd");
                item.Label_Deadline.Text += formattedDeadline;
                item.Label_NumberAppliedCandidates.Text += numberApplied.ToString();
                item.Label_NumberApprovedCandidates.Text += numberApproved.ToString();
                item.NumberApplied = numberApplied;
                item.NumberApproved = numberApproved;
                items.Add(item);
            }
            return items;
        }

        public List<UC_Employer_Job> SortJobsFromDB(string empID, string keyword)
        {
            string sqlQuery = $"SELECT Name, Salary, PostTime, ExpirationDate, ID FROM Jobs " +
                $"WHERE EmpID = '{empID}' " +
                $"ORDER BY PostTime {keyword}";

            List<Dictionary<string, object>> resultList = dbConnection.ExecuteReaderData(sqlQuery);
            List<UC_Employer_Job> items = new List<UC_Employer_Job>();

            foreach (var row in resultList)
            {
                string sqlQuery2 = $"SELECT Count(CddID) as SL " +
                    $"FROM Resume " +
                    $"WHERE JobID = '{(int)row["ID"]}' AND Status = 'Applying' " +
                    $"GROUP BY JobID";
                int numberApplied = dbConnection.ExecuteReaderCount(sqlQuery2);
                string sqlQuery3 = $"SELECT Count(CddID) as SL " +
                    $"FROM Resume " +
                    $"WHERE JobID = '{(int)row["ID"]}' AND Status = 'Approved' " +
                    $"GROUP BY JobID";
                int numberApproved = dbConnection.ExecuteReaderCount(sqlQuery3);

                UC_Employer_Job item = new UC_Employer_Job(empID);
                item.JobID = (int)row["ID"];
                item.Label_JobName.Text = (string)row["Name"];
                item.Label_Salary.Text += row["Salary"].ToString();
                DateTime postTime = (DateTime)row["PostTime"];
                string formattedPostTime = postTime.ToString("yyyy-MM-dd");
                item.Label_PostedTime.Text = formattedPostTime;
                DateTime deadline = (DateTime)row["ExpirationDate"];
                string formattedDeadline = postTime.ToString("yyyy-MM-dd");
                item.Label_Deadline.Text += formattedDeadline;
                item.Label_NumberAppliedCandidates.Text += numberApplied.ToString();
                item.Label_NumberApprovedCandidates.Text += numberApproved.ToString();
                item.NumberApplied = numberApplied;
                item.NumberApproved = numberApproved;
                items.Add(item);
            }
            return items;
        }

        public List<UC_Employer_Candidate> GetCandidatesFromDB()
        {
            string sqlQuery = $"SELECT * " +
                $"FROM Candidates ";
            List<Dictionary<string, object>> resultList = dbConnection.ExecuteReaderData(sqlQuery);
            List<UC_Employer_Candidate> items = new List<UC_Employer_Candidate>();
            foreach (var row in resultList)
            {
                UC_Employer_Candidate item = new UC_Employer_Candidate();
                item.CddID = (string)row["CddID"];
                item.Label_Name.Text = (string)row["CddName"];
                item.Label_Phone.Text = (string)row["Phone"];
                item.Label_Email.Text = (string)row["Email"];
                item.Label_Hometown.Text = (string)row["Hometown"];
                item.Label_University.Text = (string)row["Education"];
                items.Add(item);
            }
            return items;
        }

        public List<UC_Employer_Candidate> SearchCandidatesFromDB(string keyword)
        {
            string sqlQuery = $"SELECT * " +
                $"FROM Candidates " +
                $"WHERE CONCAT(CddName, Phone, Email, CddAddress, Hometown, Sex, Education) LIKE N'%' + '{keyword}' + '%'";
            List<Dictionary<string, object>> resultList = dbConnection.ExecuteReaderData(sqlQuery);
            List<UC_Employer_Candidate> items = new List<UC_Employer_Candidate>();
            foreach (var row in resultList)
            {
                UC_Employer_Candidate item = new UC_Employer_Candidate();
                item.CddID = (string)row["CddID"];
                item.Label_Name.Text = (string)row["CddName"];
                item.Label_Phone.Text = (string)row["Phone"];
                item.Label_Email.Text = (string)row["Email"];
                item.Label_Hometown.Text = (string)row["Hometown"];
                item.Label_University.Text = (string)row["Education"];
                items.Add(item);
            }
            return items;
        }

        public Candidate GetCandidateFromDB(string cddID)
        {
            Candidate candidate = new Candidate();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string sqlQuery = $"SELECT * FROM Candidates WHERE CddID = '{cddID}'";
                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        candidate.Id = (string)reader["CddID"];
                        candidate.Name = (string)reader["CddName"];
                        candidate.Phone = (string)reader["Phone"];
                        candidate.Email = (string)reader["Email"];
                        candidate.Hometown = (string)reader["Hometown"];
                        candidate.Sex = (string)reader["Sex"];
                        candidate.Education = (string)reader["Education"];
                    }
                }
                else
                    MessageBox.Show("No rows found");

                return candidate;
            }
        }

        public List<UC_WorkHistory> GetCandidateWorkHistoryFromDB(string cddID)
        {
            string sqlQuery = $"SELECT wh.CandidateID, cdd.CddName, wh.CompanyName, wh.StartDate, wh.EndDate " +
                $"FROM WorkHistory wh JOIN Candidates cdd ON wh.CandidateID = cdd.CddID " +
                $"WHERE wh.CandidateID = '{cddID}'";
            List<UC_WorkHistory> lstWorkHistory = new List<UC_WorkHistory>();
            List<Dictionary<string, object>> keyValuePairs = dbConnection.ExecuteReaderData(sqlQuery);
            foreach (var keyValuePair in keyValuePairs)
            {
                CandidateProfile candidateProfile = new CandidateProfile();
                candidateProfile.CddID = (string)keyValuePair["CandidateID"];
                candidateProfile.CompanyName = (string)keyValuePair["CompanyName"];
                candidateProfile.CddName = (string)keyValuePair["CddName"];
                candidateProfile.CompanyStartDate = (string)keyValuePair["StartDate"];
                candidateProfile.CompanyEndDate = (string)keyValuePair["EndDate"];
                UC_WorkHistory uC_WorkHistory = new UC_WorkHistory(candidateProfile);
                lstWorkHistory.Add(uC_WorkHistory);
            }
            return lstWorkHistory;
        }

        public List<UC_Employer_CV> GetCVsFromDB(string empID)
        {
            string sqlQuery = $"SELECT CV.ID, CV.Nominee, C.CddID, C.CddName, C.Phone, C.Email, C.CddAddress " +
                $"FROM CV INNER JOIN Candidates C ON CV.CVOwner = C.CddID ";
            List<Dictionary<string, object>> resultList = dbConnection.ExecuteReaderData(sqlQuery);
            List<UC_Employer_CV> items = new List<UC_Employer_CV>();
            foreach (var row in resultList)
            {
                UC_Employer_CV item = new UC_Employer_CV(empID, (string)row["CddID"], (int)row["ID"]);
                item.Label_Name.Text = (string)row["CddName"];
                item.Label_Job.Text = (string)row["Nominee"];
                item.Label_Phone.Text = (string)row["Phone"];
                item.Label_Email.Text = (string)row["Email"];
                item.Label_Address.Text = (string)row["CddAddress"];
                items.Add(item);
            }
            return items;
        }

        public List<UC_Employer_CV> GetFavoriteCVsFromDB(string empID)
        {
            string sqlQuery = $"SELECT CV.CVOwner, CV.ID, CV.Nominee, C.CddID, C.CddName, C.Phone, C.Email, C.CddAddress " +
                $"FROM FavoriteCV F INNER JOIN CV ON F.CVID = CV.ID INNER JOIN Candidates C ON CV.CVOwner = C.CddID ";
            List<Dictionary<string, object>> resultList = dbConnection.ExecuteReaderData(sqlQuery);
            List<UC_Employer_CV> items = new List<UC_Employer_CV>();
            foreach (var row in resultList)
            {
                UC_Employer_CV item = new UC_Employer_CV(empID, (string)row["CVOwner"], (int)row["ID"]);
                item.Label_Name.Text = (string)row["CddName"];
                item.Label_Job.Text = (string)row["Nominee"];
                item.Label_Phone.Text = (string)row["Phone"];
                item.Label_Email.Text = (string)row["Email"];
                item.Label_Address.Text = (string)row["CddAddress"];
                items.Add(item);
            }
            return items;
        }

        public void AddFavoriteCV(FavoriteCV cv)
        {
            string sqlStr = string.Format($"INSERT INTO FavoriteCV (TimeSaved, CVID, EmpID) " +
                $"VALUES ('{cv.TimeSaved}', '{cv.CvID}', '{cv.EmpID}')");

            if (dbConnection.ExecuteWriteDataCheck(sqlStr))
            {
                MessageBox.Show("Add favorite CV successfully");
            }
        }

        public void DeleteFavoriteCV(FavoriteCV cv)
        {
            string sqlStr = string.Format($"DELETE FROM FavoriteCV " +
                $"WHERE CVID = '{cv.CvID}' AND EmpID = '{cv.EmpID}'");

            if (dbConnection.ExecuteWriteDataCheck(sqlStr))
            {
                MessageBox.Show("Delete favorite CV successfully");
            }
        }

        public CV GetCVFromDB(int cvid)
        {
            CV cv = new CV();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string sqlQuery = $"SELECT * " +
                    $"FROM CV INNER JOIN Candidates C ON CV.CVOwner = C.CddID " +
                    $"WHERE CV.ID = '{cvid}'";
                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cv.CvID = (int)reader["ID"];
                        cv.CddName = (string)reader["CddName"];
                        cv.CddPhone = (string)reader["Phone"];
                        cv.CddEmail = (string)reader["Email"];
                        cv.CddAddress = (string)reader["CddAddress"];
                        cv.Nominee = (string)reader["Nominee"];
                        cv.Objective = (string)reader["Objective"];
                        cv.UniversityName = (string)reader["UniversityName"];
                        cv.Major = (string)reader["Major"];
                        cv.Gpa = (string)reader["GPA"];
                        cv.UniversityStartDate = (string)reader["UniversityStartDate"];
                        cv.UniversityEndDate = (string)reader["UniversityEndDate"];
                        cv.CompanyName = (string)reader["CompanyName"];
                        cv.WorkPlace = (string)reader["Workplace"];
                        cv.WorkedDetail = (string)reader["Detail"];
                        cv.CompanyStartDate = (string)reader["CompanyStartDate"];
                        cv.CompanyEndDate = (string)reader["CompanyEndDate"];
                        cv.Certification = (string)reader["CertificationName"];
                        cv.CertificationDate = (string)reader["CertificationDate"];
                        cv.CddID = (string)reader["CVOwner"];
                    }
                }
                else
                    MessageBox.Show("No rows found");

                return cv;
            }
        }
    }
}
