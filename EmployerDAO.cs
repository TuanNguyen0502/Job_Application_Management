﻿using System;
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
            string sqlQuery = $"SELECT I.ID , I.CddID, I.JobID, J.Name, C.CddName, I.InterviewTime, I.Note " +
                $"FROM Interviews I INNER JOIN Candidates C ON I.CddID = C.CddID " +
                                  $"INNER JOIN Jobs J ON I.JobID = J.ID " +
                $"WHERE CONCAT(I.CddID, C.CddName, C.Phone, C.Email, C.CddAddress, C.Hometown, C.Sex, C.Education, " +
                             $"I.JobID, J.Name, J.Salary, J.ExpirationDate, J.PostTime, I.InterviewTime, I.Note) LIKE N'%' + '{keyword}' + '%' " +
                      $"AND I.EmpID = '{empID}'";
            List<Dictionary<string, object>> resultList = dbConnection.ExecuteReaderData(sqlQuery);
            List<UC_Employer_Interview> items = new List<UC_Employer_Interview>();
            foreach (var row in resultList)
            {
                UC_Employer_Interview item = new UC_Employer_Interview((int)row["ID"], empID, (string)row["CddID"], (int)row["JobID"]);
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
            string sqlQuery = $"SELECT I.ID , I.JobID, J.Name, C.CddName, C.CddID, I.InterviewTime, I.Note " +
                $"FROM Interviews I INNER JOIN Candidates C ON I.CddID = C.CddID " +
                $"INNER JOIN Jobs J ON I.JobID = J.ID " +
                $"WHERE I.EmpID = '{empID}'";
            List<Dictionary<string, object>> resultList = dbConnection.ExecuteReaderData(sqlQuery);
            List<UC_Employer_Interview> items = new List<UC_Employer_Interview>();
            foreach (var row in resultList)
            {
                UC_Employer_Interview item = new UC_Employer_Interview((int)row["ID"], empID, (string)row["CddID"], (int)row["JobID"]);
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
            string sqlStr = "DELETE FROM Interviews WHERE ID = @ID";
            SqlParameter[] lstParams =
            {
                new SqlParameter("@ID", SqlDbType.Int) {Value = interview.Id},
            };
            if (dbConnection.ExecuteWriteDataCheck(sqlStr, lstParams))
            {
                MessageBox.Show("Successfully Delete interview time");
            }
        }

        public void UpdateInterview(Interview interview)
        {
            string sqlStr = "UPDATE Interviews SET InterviewTime = @InterviewTime, Note = @Note " +
                            "WHERE ID = @ID";
            SqlParameter[] lstParams =
            {
                new SqlParameter("@ID", SqlDbType.Int) {Value = interview.Id},
                new SqlParameter("@InterviewTime", SqlDbType.DateTime) {Value = interview.InterviewTime},
                new SqlParameter("@Note", SqlDbType.NVarChar) {Value = interview.Note},
            };
            if (dbConnection.ExecuteWriteDataCheck(sqlStr, lstParams))
            {
                MessageBox.Show("Update interview time successfully");
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

        public bool CheckCandidateInterviewByCVTimeExists(DateTime interviewTime, string cddID)
        {
            string query = "SELECT COUNT(*) FROM InterviewsByCV WHERE InterviewTime = @InterviewTime AND CddID = @CddID";
            SqlParameter[] lstParams =
            {
                new SqlParameter("@InterviewTime", SqlDbType.DateTime) {Value = interviewTime},
                new SqlParameter("@CddID", SqlDbType.VarChar) {Value = cddID},
            };
            int count = dbConnection.ExecuteScalarGetInt(query, lstParams);
            return count > 0; // Return true if InterviewTime already exists, false otherwise
        }

        public bool CheckEmployerInterviewByCVTimeExists(DateTime interviewTime, string empID)
        {
            string query = "SELECT COUNT(*) FROM InterviewsByCV WHERE InterviewTime = @InterviewTime AND EmpID = @EmpID";
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
            string sqlQuery = $"SELECT I.ID, I.EmpID, I.CddID, I.JobID, I.InterviewTime, I.Note, J.Name " +
                $"FROM Interviews I INNER JOIN Jobs J ON I.JobID = J.ID " +
                $"WHERE I.EmpID = '{empID}' AND I.CddID = '{cddID}' AND I.JobID = '{jobID}'";
            List<Dictionary<string, object>> results = dbConnection.ExecuteReaderData(sqlQuery);
            foreach (var row in results)
            {
                interview.Id = (int)row["ID"];
                interview.EmpID = (string)row["EmpID"];
                interview.CddID = (string)row["CddID"];
                interview.JobID = (int)row["JobID"];
                interview.InterviewTime = (DateTime)row["InterviewTime"];
                interview.Note = (string)row["Note"];
                interview.JobName = (string)row["Name"];
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
            string sqlQuery = $"SELECT R.CddID, R.JobID, R.Objective, R.UniversityName, R.Major, R.GPA, R.UniversityStartDate, R.UniversityEndDate, " +
                    $"R.CompanyName, R.WorkPlace, R.Detail, R.CompanyStartDate, R.CompanyEndDate, R.CertificationName, R.CertificationDate, " +
                    $"R.Status, " +
                    $"C.CddName, C.Phone, C.Email, C.CddAddress, " +
                    $"J.Name " +
                    $"FROM Resume R INNER JOIN Candidates C ON R.CddID = C.CddID " +
                    $"INNER JOIN Jobs J ON R.JobID = J.ID " +
                    $"WHERE R.CddID = '{cddID}' AND R.JobID = '{jobID}'";
            List<Dictionary<string, object>> results = dbConnection.ExecuteReaderData(sqlQuery);
            foreach (var row in results)
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
            return resume;
        }

        public Company GetCompanyFromDB(string companyName)
        {
            Company company = new Company();
            string sqlQuery = $"SELECT Name, Address, Manager, TaxCode, BusinessLicense, NumberOfEmployee, NumberOfFollower, Introduction " +
                    $"FROM Company WHERE Name = '{companyName}'";
            List<Dictionary<string, object>> results = dbConnection.ExecuteReaderData(sqlQuery);
            foreach (var row in results)
            {
                company.Name = (string)row["Name"];
                company.Address = (string)row["Address"];
                company.Manager = (string)row["Manager"];
                company.TaxCode = (string)row["TaxCode"];
                company.BusinessLicense = (string)row["BusinessLicense"];
                company.NumberOfEmployee = (int)row["NumberOfEmployee"];
                company.NumberOfFollower = (int)row["NumberOfFollower"];
                company.Introduction = (string)row["Introduction"];
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
            string sqlQuery = $"SELECT ID, Email, Name, Sex, Phone, Workplace, CompanyName FROM Employers " +
                $"WHERE ID = '{empID}'";
            List<Dictionary<string, object>> results = dbConnection.ExecuteReaderData(sqlQuery);
            foreach (var row in results)
            {
                employer.Id = (string)row["ID"];
                employer.Email = (string)row["Email"];
                employer.Name = (string)row["Name"];
                employer.Sex = (string)row["Sex"];
                employer.Phone = (string)row["Phone"];
                employer.Workplace = (string)row["Workplace"];
                employer.CompanyName = (string)row["CompanyName"];
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
            string sqlStr = string.Format($"INSERT INTO Jobs (Name, Salary, JobDecription, WorkDuration, Experience, ExpirationDate, Benefit, RequestCdd, PostTime, EmpID) " +
                $"VALUES (N'{job.Name}', '{job.Salary}', N'{job.JobDescription}', '{job.WorkDuration}', N'{job.Experience}', '{job.Deadline.ToString("yyyy-MM-dd")}', N'{job.Benefit}', N'{job.Request}', '{job.PostTime.ToString("yyyy-MM-dd")}', '{job.EmpID}')");

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
            string sqlQuery = $"SELECT ID, Name, Salary, JobDecription, Workduration, Experience, ExpirationDate, Benefit, RequestCdd, " +
                    $"PostTime FROM Jobs WHERE ID = '{jobID}'";
            List<Dictionary<string, object>> results = dbConnection.ExecuteReaderData(sqlQuery);
            foreach (var row in results)
            {
                job.Id = (int)row["ID"];
                job.Name = (string)row["Name"];
                job.Salary = (int)row["Salary"];
                job.JobDescription = (string)row["JobDecription"];
                job.WorkDuration = (string)row["Workduration"];
                job.Experience = (string)row["Experience"];
                job.Deadline = (DateTime)row["ExpirationDate"];
                job.Benefit = (string)row["Benefit"];
                job.Request = (string)row["RequestCdd"];
                job.PostTime = (DateTime)row["PostTime"];
            }
            return job;
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
            string sqlQuery = $"SELECT * FROM Candidates WHERE CddID = '{cddID}'";
            List<Dictionary<string, object>> results = dbConnection.ExecuteReaderData(sqlQuery);
            foreach (var row in results)
            {
                candidate.Id = (string)row["CddID"];
                candidate.Name = (string)row["CddName"];
                candidate.Phone = (string)row["Phone"];
                candidate.Email = (string)row["Email"];
                candidate.Hometown = (string)row["Hometown"];
                candidate.Sex = (string)row["Sex"];
                candidate.Education = (string)row["Education"];
            }
            return candidate;
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
                DateTime startDate = (DateTime)keyValuePair["StartDate"];
                candidateProfile.CompanyStartDate = startDate.ToShortDateString();
                DateTime endDate = (DateTime)keyValuePair["EndDate"];
                candidateProfile.CompanyEndDate = endDate.ToShortDateString();
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
                $"VALUES (@TimeSaved, @CVID, @EmpID)");
            SqlParameter[] lstParams =
            {
                new SqlParameter("@TimeSaved", SqlDbType.DateTime) {Value = cv.TimeSaved},
                new SqlParameter("@CVID", SqlDbType.VarChar) {Value = cv.CvID},
                new SqlParameter("@EmpID", SqlDbType.VarChar) {Value = cv.EmpID},
            };
            if (dbConnection.ExecuteWriteDataCheck(sqlStr, lstParams))
            {
                MessageBox.Show("Create new interview time successfully");
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
            string sqlQuery = $"SELECT * " +
                    $"FROM CV INNER JOIN Candidates C ON CV.CVOwner = C.CddID " +
                    $"WHERE CV.ID = '{cvid}'";
            List<Dictionary<string, object>> results = dbConnection.ExecuteReaderData(sqlQuery);
            foreach (var row in results)
            {
                cv.CvID = (int)row["ID"];
                cv.CddName = (string)row["CddName"];
                cv.CddPhone = (string)row["Phone"];
                cv.CddEmail = (string)row["Email"];
                cv.CddAddress = (string)row["CddAddress"];
                cv.Nominee = (string)row["Nominee"];
                cv.Objective = (string)row["Objective"];
                cv.UniversityName = (string)row["UniversityName"];
                cv.Major = (string)row["Major"];
                cv.Gpa = (string)row["GPA"];
                cv.UniversityStartDate = (string)row["UniversityStartDate"];
                cv.UniversityEndDate = (string)row["UniversityEndDate"];
                cv.CompanyName = (string)row["CompanyName"];
                cv.WorkPlace = (string)row["WorkPlace"];
                cv.WorkedDetail = (string)row["Detail"];
                cv.CompanyStartDate = (string)row["CompanyStartDate"];
                cv.CompanyEndDate = (string)row["CompanyEndDate"];
                cv.Certification = (string)row["CertificationName"];
                cv.CertificationDate = (string)row["CertificationDate"];
                cv.CddID = (string)row["CVOwner"];
            }
            return cv;
        }

        public List<UC_Employer_InterviewByCv> GetInterviewsByCVFromDB(string empID)
        {
            string sqlQuery = $"SELECT I.ID, I.CddID, I.JobName, C.CddName, C.CddID, I.InterviewTime, I.Note " +
                $"FROM InterviewsByCV I INNER JOIN Candidates C ON I.CddID = C.CddID " +
                $"WHERE I.EmpID = '{empID}'";
            List<UC_Employer_InterviewByCv> items = new List<UC_Employer_InterviewByCv>();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UC_Employer_InterviewByCv item = new UC_Employer_InterviewByCv((int)reader["ID"], empID, (string)reader["CddID"]);
                            item.Label_JobName.Text = (string)reader["JobName"];
                            item.Label_CandidateName.Text = (string)reader["CddName"];
                            item.Label_InterviewTime.Text = reader["InterviewTime"].ToString();
                            item.Label_Note.Text = reader["Note"].ToString();
                            items.Add(item);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Read error\n" + ex.Message);
                }
            }
            return items;
        }

        public void AddInterviewByCV(Interview interview)
        {
            string sqlStr = "INSERT INTO InterviewsByCV (EmpID, CddID, JobName, InterviewTime, Note)" +
                            " VALUES (@EmpID, @CddID, @JobName, @InterviewTime, @Note)";
            SqlParameter[] lstParams =
            {
                new SqlParameter("@EmpID", SqlDbType.VarChar) {Value = interview.EmpID},
                new SqlParameter("@CddID", SqlDbType.VarChar) {Value = interview.CddID},
                new SqlParameter("@JobName", SqlDbType.NVarChar) {Value = interview.JobName},
                new SqlParameter("@InterviewTime", SqlDbType.DateTime) {Value = interview.InterviewTime},
                new SqlParameter("@Note", SqlDbType.NVarChar) {Value = interview.Note},
            };
            if (dbConnection.ExecuteWriteDataCheck(sqlStr, lstParams))
            {
                MessageBox.Show("Create new interview time successfully");
            }
        }

        public Interview GetInterviewByCVFromDB(int id, string empID, string cddID)
        {
            Interview interview = new Interview();
            string sqlQuery = $"SELECT I.ID, I.EmpID, I.CddID, I.JobName, I.InterviewTime, I.Note " +
                    $"FROM InterviewsByCV I " +
                    $"WHERE I.ID = '{id}' ";
            List<Dictionary<string, object>> results = dbConnection.ExecuteReaderData(sqlQuery);
            foreach (var row in results)
            {
                interview.Id = (int)row["ID"];
                interview.EmpID = (string)row["EmpID"];
                interview.CddID = (string)row["CddID"];
                interview.JobName = (string)row["JobName"];
                interview.InterviewTime = (DateTime)row["InterviewTime"];
                interview.Note = (string)row["Note"];
            }

            return interview;
        }

        public void UpdateInterviewByCV(Interview interview)
        {
            string sqlStr = "UPDATE InterviewsByCV SET InterviewTime = @InterviewTime, Note = @Note WHERE ID = @ID ";
            SqlParameter[] lstParams =
            {
                new SqlParameter("@ID", SqlDbType.VarChar) {Value = interview.Id},
                new SqlParameter("@InterviewTime", SqlDbType.DateTime) {Value = interview.InterviewTime},
                new SqlParameter("@Note", SqlDbType.NVarChar) {Value = interview.Note},
            };
            if (dbConnection.ExecuteWriteDataCheck(sqlStr, lstParams))
            {
                MessageBox.Show("Update interview time successfully");
            }
        }

        public void DeleteInterviewByCV(Interview interview)
        {
            string sqlStr = "DELETE FROM InterviewsByCV WHERE ID = @ID";
            SqlParameter[] lstParams =
            {
                new SqlParameter("@ID", SqlDbType.Int) {Value = interview.Id},
            };
            if (dbConnection.ExecuteWriteDataCheck(sqlStr, lstParams))
            {
                MessageBox.Show("Successfully Delete interview time");
            }
        }
    }
}
