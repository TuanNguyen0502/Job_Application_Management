﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
