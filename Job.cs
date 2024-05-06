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
        private int salary;
        private string jobDescription;
        private string workDuration;
        private string experience;
        private DateTime deadline;
        private string benefit;
        private string request;
        private DateTime postTime;
        private string empID;
        private string companyName;
        private string address;
        private string status;
        public Job() { }
        public Job(string name, int salary, string jobDescription, string workDuration, string experience, DateTime deadline, string benefit, string request, string empID)
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
        public Job(int id, string name, int salary, string jobDescription, string workDuration, string experience, DateTime deadline, string benefit, string request, string empID)
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

        public Job (int id, string name, int salary, string jobDescription, string workDuration, string experience, DateTime deadline, string benefit, string request, string empID, string companyName, string address)
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
            CompanyName = companyName;
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
            if (string.IsNullOrEmpty(Request))
            {
                MessageBox.Show("Request cannot be null !", "Empty request", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool CheckBenefit()
        {
            if (string.IsNullOrEmpty(Benefit))
            {
                MessageBox.Show("Benefit cannot be null !", "Empty benefit", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Deadline cannot be in the past or today !", "Unaccepted deadline", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool CheckExperience()
        {
            if (string.IsNullOrEmpty(Experience))
            {
                MessageBox.Show("Experience cannot be null !", "Empty experience", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool CheckWorkDuration()
        {
            if (string.IsNullOrEmpty(WorkDuration))
            {
                MessageBox.Show("Work Duration cannot be number 0 !", "Empty work duration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool CheckJobDescription()
        {
            if (string.IsNullOrEmpty(JobDescription))
            {
                MessageBox.Show("Job description cannot be null !", "Empty description", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool CheckSalary()
        {
            if (Salary <= 0)
            {
                MessageBox.Show("Salary cannot be number 0 !", "Empty salary", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool CheckName()
        {
            if (string.IsNullOrEmpty(Name))
            {
                MessageBox.Show("Name cannot be null !", "Empty name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Salary { get => salary; set => salary = value; }
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
        public string Status { get => status; set => status = value; }
    }
}
