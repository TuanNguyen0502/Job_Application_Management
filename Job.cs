using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job_Application_Management
{
    public class Job
    {
        private int id;
        private string name;
        private string salary;
        private string jobDescription;
        private string workDuration;
        private string experience;
        private DateTime deadline;
        private string benefit;
        private string request;
        private DateTime postTime;
        private string empID;
        private string companyName;
        public string address;
        public Job() { }
        public Job(string name, string salary, string jobDescription, string workDuration, string experience, DateTime deadline, string benefit, string request, string empID)
        {
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
        public Job(int id, string name, string salary, string jobDescription, string workDuration, string experience, DateTime deadline, string benefit, string request, string empID)
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

        public Job (int id, string name, string salary, string jobDescription, string workDuration, string experience, DateTime deadline, string benefit, string request, string empID, string companyName, string address)
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
            CompanyName=companyName;
            Address = address;
        }

        public bool CheckAllCondition()
        {
            if (CheckName() && CheckSalary() && CheckJobDescription() && CheckWorkDuration() && CheckExperience() && CheckDeadline()
                && CheckBenefit() && CheckRequest())
            {
                return true;
            }
            return false;
        }

        public bool CheckRequest()
        {
            if (Request == null || Request == "")
            {
                MessageBox.Show("Request cannot be null !");
                return false;
            }
            return true;
        }

        public bool CheckBenefit()
        {
            if (Benefit == null || Benefit == "")
            {
                MessageBox.Show("Benefit cannot be null !");
                return false;
            }
            return true;
        }

        public bool CheckDeadline()
        {
            if (Deadline == null)
            {
                MessageBox.Show("Deadline cannot be null !");
                return false;
            }
            if (Deadline.CompareTo(DateTime.Now) < 0)
            {
                MessageBox.Show("Deadline cannot be in the past or today !");
            }
            return true;
        }

        public bool CheckExperience()
        {
            if (Experience == null || Experience == "")
            {
                MessageBox.Show("Experience cannot be null !");
                return false;
            }
            return true;
        }

        public bool CheckWorkDuration()
        {
            if (WorkDuration == null || WorkDuration == "")
            {
                MessageBox.Show("Work Duration cannot be number 0 !");
                return false;
            }
            return true;
        }

        public bool CheckJobDescription()
        {
            if (JobDescription == null || JobDescription == "")
            {
                MessageBox.Show("Job description cannot be null !");
                return false;
            }
            return true;
        }

        public bool CheckSalary()
        {
            if (Salary == null || Salary == "")
            {
                MessageBox.Show("Salary cannot be number 0 !");
                return false;
            }
            return true;
        }

        public bool CheckName()
        {
            if (Name == null || Name == "")
            {
                MessageBox.Show("Name cannot be null !");
                return false;
            }
            return true;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Salary { get => salary; set => salary = value; }
        public string JobDescription { get => jobDescription; set => jobDescription = value; }
        public string WorkDuration { get => workDuration; set => workDuration = value; }
        public string Experience { get => experience; set => experience = value; }
        public DateTime Deadline { get => deadline; set => deadline = value; }
        public string Benefit { get => benefit; set => benefit = value; }
        public string Request { get => request; set => request = value; }
        public string EmpID { get => empID; set => empID = value; }
        public DateTime PostTime { get => postTime; set => postTime = value; }
        public string CompanyName { get => companyName; set => companyName = value; }
        public string Address { get => address; set => address = value; }


    }
}
