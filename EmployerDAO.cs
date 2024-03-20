using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Application_Management
{
    public class EmployerDAO
    {
        private DBConnection dbConnection;

        public EmployerDAO()
        {
            this.dbConnection = new DBConnection();
        }

        public void Execute(string sqlStr)
        {
            dbConnection.ExecuteWriteData(sqlStr);
        }

        public void SaveInfor(Employer employer)
        {
            string sqlStr = string.Format($"UPDATE Employers SET EmpEmail = '{employer.Email}', EmpName = N'{employer.Name}', Sex = N'{employer.Sex}', " +
                $"Phone = '{employer.Phone}', Workplace = N'{employer.Workplace}', Company = N'{employer.Company}', CompanyAddress = N'{employer.Address}' " +
                $"WHERE EmpID = '{employer.Id}'");
            Execute(sqlStr);
        }

        public void AddJob(Job job)
        {
            string sqlStr = string.Format($"INSERT INTO Jobs (JobID, JobName, Salary, CompanyName, WorkAddress, JobDecription, WorkDuration, " +
                $"Experience, ExpirationDate, Benefit, RequestCdd, EmpID) VALUES ('{job.Id}', N'{job.Name}', '{job.Salary}', N'{job.Company}', " +
                $"'{job.Address}', '{job.JobDescription}', '{job.WorkDuration}', '{job.Experience}', '{job.Deadline}', '{job.Benefit}', " +
                $"'{job.Request}', '{job.EmpID}')");

            Execute(sqlStr);
        }

        public void UpdateJob(Job job)
        {
            string sqlStr = string.Format($"UPDATE Jobs SET JobName = '{job.Name}', Salary = '{job.Salary}', CompanyName = '{job.Company}', " +
                $"WorkAddress = '{job.Address}', JobDecription = '{job.JobDescription}', WorkDuration = '{job.WorkDuration}', " +
                $"Experience = '{job.Experience}', ExpirationDate = '{job.Deadline}', Benefit = '{job.Benefit}', RequestCdd = '{job.Request}'" +
                $"WHERE JobID = '{job.Id}'");

            Execute(sqlStr);
        }

        public void DeleteJob(Job job)
        {
            string sqlStr = string.Format($"DELETE FROM Jobs WHERE JobID = '{job.Id}'");

            Execute(sqlStr);
        }
    }
}
