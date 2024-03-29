﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Application_Management
{
    public class Job
    {
        private string id;
        private string name;
        private int salary;
        private string jobDescription;
        private int workDuration;
        private string experience;
        private DateTime deadline;
        private string benefit;
        private string request;
        private DateTime postTime;
        private string empID;

        public Job (string id, string name, int salary, string jobDescription, int workDuration, string experience, DateTime deadline, string benefit, string request, string empID)
        {
            Id = id;
            Name = name;
            Salary = salary;
            JobDescription = jobDescription;
            WorkDuration = workDuration;
            Experience = experience;
            Deadline = deadline;
            Benefit = benefit;
            Request = request;
            postTime = DateTime.Now;
            EmpID = empID;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Salary { get => salary; set => salary = value; }
        public string JobDescription { get => jobDescription; set => jobDescription = value; }
        public int WorkDuration { get => workDuration; set => workDuration = value; }
        public string Experience { get => experience; set => experience = value; }
        public DateTime Deadline { get => deadline; set => deadline = value; }
        public string Benefit { get => benefit; set => benefit = value; }
        public string Request { get => request; set => request = value; }
        public string EmpID { get => empID; set => empID = value; }
        public DateTime PostTime { get => postTime; set => postTime = value; }
    }
}
