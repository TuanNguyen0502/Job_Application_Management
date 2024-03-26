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

        public void SaveInfor(Employer employer)
        {
            string sqlStr = string.Format($"UPDATE Employers SET Email = '{employer.Email}', Name = N'{employer.Name}', Sex = N'{employer.Sex}', " +
                $"Phone = '{employer.Phone}', Workplace = N'{employer.Workplace}' WHERE ID = '{employer.Id}'");
            Execute(sqlStr);
        }

        public void AddJob(Job job)
        {
            string sqlStr = string.Format($"INSERT INTO Jobs (ID, Name, Salary, JobDecription, WorkDuration, Experience, ExpirationDate, " +
                $"Benefit, RequestCdd, PostTime, EmpID) VALUES ('{job.Id}', N'{job.Name}', '{job.Salary}', " +
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

        public void DeleteJob(Job job)
        {
            string sqlStr = string.Format($"DELETE FROM Jobs WHERE ID = '{job.Id}'");

            Execute(sqlStr);
        }

        public List<UC_EmployerJob> GetJobsFromDB(string empID)
        {
            string sqlQuery = $"SELECT Name, Salary, PostTime, ID FROM Jobs WHERE EmpID = '{empID}'";
            List<Dictionary<string, object>> resultList = dbConnection.ExecuteReaderData(sqlQuery);
            List<UC_EmployerJob> items = new List<UC_EmployerJob>();
            foreach (var row in resultList)
            {
                UC_EmployerJob item = new UC_EmployerJob(empID);
                item.Label_JobName.Text = (string)row["Name"];
                item.Label_Salary.Text = row["Salary"].ToString();
                //item.Label_PostedTime.Text = (string)row["PostTime"].ToString();
                DateTime postTime = (DateTime)row["PostTime"];
                string formattedPostTime = postTime.ToString("yyyy-MM-dd");
                item.Label_PostedTime.Text = formattedPostTime;
                item.JobID = (string)row["ID"];
                items.Add(item);
            }
            return items;
        }

        public List<UC_CandidateCV> GetCandidateResumeFromDB(string jobID)
        {
            string sqlQuery = $"SELECT R.CddID, C.CddName, R.UniversityName, R.Major, R.GPA FROM Resume R " +
                $"INNER JOIN Candidates C ON R.CddID = C.CddID WHERE JobID = '{jobID}'";
            List<Dictionary<string, object>> resultList = dbConnection.ExecuteReaderData(sqlQuery);
            List<UC_CandidateCV> items = new List<UC_CandidateCV>();
            foreach (var row in resultList)
            {
                UC_CandidateCV item = new UC_CandidateCV(jobID);
                item.CddID = (string)row["CddID"];
                item.Label_Name.Text = (string)row["CddName"];
                item.Label_University.Text = (string)row["UniversityName"];
                item.Label_Major.Text += (string)row["Major"].ToString();
                item.Label_GPA.Text = (string)row["GPA"].ToString();
                items.Add(item);
            }
            return items;
        }
    }
}
