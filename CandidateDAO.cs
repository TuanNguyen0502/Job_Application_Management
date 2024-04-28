using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Job_Application_Management
{
    // Các lớp đối tượng truy cập dữ liệu. cung cấp đối tượng tại nhiều lớp khác nhau cho phép gọi dữ liệu đã xây 
    // dựng trước đó
    public class CandidateDAO
    {
        DBConnection dbConn;
        string sqlQuery;
        #region Function of CandidateDAO
        public CandidateDAO()
        {
            dbConn = new DBConnection();
        }
        public string GetNameByCddID(string cddId)
        {
            sqlQuery = "SELECT CddName FROM Candidates WHERE CddID = @CddID";
            SqlParameter[] lstParams =
            {
                new SqlParameter("@CddID", SqlDbType.VarChar) {Value = cddId}
            };
            string res = dbConn.ExecuteScalar(sqlQuery, lstParams);
            return res;
        }
        public List<UC_CandidateMain> GetJobsFromDB(string cddid)
        {
            sqlQuery = "SELECT j.ID JobID, j.Name JobName, c.Name CompanyName, j.Salary, c.Address"
                        +" FROM Jobs j"
                        +" JOIN Employers e ON j.EmpID = e.ID"
                        +" JOIN Company c ON e.CompanyName = c.Name";
            List<Dictionary<string, object>> resultList = dbConn.ExecuteReaderData(sqlQuery);
            List<UC_CandidateMain> items = new List<UC_CandidateMain>();
            foreach (var row in resultList)
            {
                Candidate candidate = new Candidate();
                Job job = new Job();
                Company company = new Company();
                candidate.Id = cddid;
                job.Id = (int)row["JobID"];
                job.Name = (string)row["JobName"];
                job.Salary = (int)row["Salary"];
                company.Name = (string)row["Address"];
                company.Address = (string)row["Address"];

                UC_CandidateMain item = new UC_CandidateMain(candidate,job,company);
                /*item.JobName = (string)row["JobName"];
                item.CompanyName1 = (string)row["CompanyName"];
                item.Salary = (int)row["Salary"];
                item.Address = (string)row["Address"];
                item.JobID = (int)row["JobID"];
                item.CddID = cddid;*/
                items.Add(item);
            }
            return items;
        }
        public List<UC_CandidateMain> GetJobsByAddress(string address)
        {
            sqlQuery = "SELECT j.ID JobID, j.Name JobName, c.Name CompanyName, j.Salary, c.Address"
                        +" FROM Jobs j"
                        +" JOIN Employers e ON j.EmpID = e.ID"
                        +" JOIN Company c ON e.CompanyName = c.Name"
                        +" WHERE c.Address LIKE N'%"+ address +"%'";
            List<Dictionary<string, object>> resultList = dbConn.ExecuteReaderData(sqlQuery);
            List<UC_CandidateMain> items = new List<UC_CandidateMain>();
            foreach (var row in resultList)
            {
                Candidate candidate = new Candidate();
                Job job = new Job();
                Company company = new Company();
                job.Id = (int)row["JobID"];
                job.Name = (string)row["JobName"];
                job.Salary = (int)row["Salary"];
                company.Name = (string)row["Address"];
                company.Address = (string)row["Address"];

                UC_CandidateMain item = new UC_CandidateMain(candidate, job, company);
                items.Add(item);
            }
            return items;
        }
        public List<UC_CandidateMain> GetJobsByKeywords(string keyword)
        {
            sqlQuery = "SELECT j.ID JobID, j.Name JobName, c.Name CompanyName, j.Salary, c.Address"
                        +" FROM Jobs j"
                        +" JOIN Employers e ON j.EmpID = e.ID"
                        +" JOIN Company c ON e.CompanyName = c.Name"
                        +" WHERE c.Address LIKE N'%"+ keyword +"%'"
                        +" OR j.Name LIKE N'%"+ keyword +"%'"
                        +" OR c.Name LIKE N'%"+ keyword +"%'"
                        +" OR j.ID LIKE N'%"+ keyword +"%'";
            List<Dictionary<string, object>> resultList = dbConn.ExecuteReaderData(sqlQuery);
            List<UC_CandidateMain> items = new List<UC_CandidateMain>();
            foreach (var row in resultList)
            {
                Candidate candidate = new Candidate();
                Job job = new Job();
                Company company = new Company();
                job.Id = (int)row["JobID"];
                job.Name = (string)row["JobName"];
                job.Salary = (int)row["Salary"];
                company.Name = (string)row["Address"];
                company.Address = (string)row["Address"];

                UC_CandidateMain item = new UC_CandidateMain(candidate, job, company);
                items.Add(item);
            }
            return items;
        }
        public List<UC_JobsSaved> GetSavedJobsFromDB()
        {
            sqlQuery = "SELECT sj.ID SJID, j.Name, j.JobDecription, c.Name as CompanyName, sj.TimeSaved, c.Address, j.Salary, sj.JobID, j.PostTime"
                       +" FROM SavedJobs sj"
                       +" JOIN Jobs j ON sj.JobID = j.ID"
                       +" JOIN Employers e ON j.EmpID = e.ID"
                       +" JOIN Company c ON c.Name = e.CompanyName";
            List<Dictionary<string, object>> keyValueSavedJobs = dbConn.ExecuteReaderData(sqlQuery);
            List<UC_JobsSaved> saveds = new List<UC_JobsSaved>();
            foreach (var row in keyValueSavedJobs)
            {
                SavedJobs savedJob = new SavedJobs();
                savedJob.JobDescription = (string)row["Name"] + " [" + (string)row["JobDecription"] + "]";
                savedJob.CompanyName = (string)row["CompanyName"];
                savedJob.PostTime = (DateTime)row["PostTime"];
                savedJob.TimeSaved = (DateTime)row["TimeSaved"];
                savedJob.Address = (string)row["Address"];
                savedJob.Salary = (int)row["Salary"];
                savedJob.SavedJobID = (int)row["SJID"];
                savedJob.Id= (int)row["JobID"];
                UC_JobsSaved item = new UC_JobsSaved(savedJob);
                saveds.Add(item);
            }
            return saveds;
        }
        public void RemoveSavedJobsFromDB(string ID)
        {
            sqlQuery = "DELETE SavedJobs"
                      +" WHERE ID = @ID";
            SqlParameter[] lstParams =
            {
                new SqlParameter("@ID", SqlDbType.Int) {Value = ID}
            };
            if (dbConn.ExecuteDeleteDataCheck(sqlQuery, lstParams))
            {
                MessageBox.Show("Xóa công việc đã lưu thành công");
            }
            else
            {
                MessageBox.Show("Xóa công việc đã lưu thất bại");
            }
        }
        public List<UC_AppliedJobs> GetAppliedJobsFromDB()
        {
            sqlQuery = "SELECT aj.ID, j.Name, j.JobDecription, c.Name as CompanyName, aj.TimeApplied, c.Address, j.Salary, aj.JobID, j.PostTime"
                       +" FROM AppliedJobs aj"
                       +" JOIN Jobs j ON aj.JobID = j.ID"
                       +" JOIN Employers e ON j.EmpID = e.ID"
                       +" JOIN Company c ON c.Name = e.CompanyName";
            List<Dictionary<string, object>> keyValueSavedJobs = dbConn.ExecuteReaderData(sqlQuery);
            List<UC_AppliedJobs> applieds = new List<UC_AppliedJobs>();
            foreach (var row in keyValueSavedJobs)
            {
                AppliedJobs applied = new AppliedJobs();
                applied.JobDescription = (string)row["Name"] + " [" + (string)row["JobDecription"] + "]";
                applied.CompanyName = (string)row["CompanyName"];
                applied.PostTime = (DateTime)row["PostTime"];
                applied.TimeApplied = (DateTime)row["TimeApplied"];
                applied.Address = (string)row["Address"];
                applied.Salary = (int)row["Salary"];
                applied.AppliedJobID = (int)row["ID"];
                applied.Id= (int)row["JobID"];
                UC_AppliedJobs item = new UC_AppliedJobs(applied);
                applieds.Add(item);
            }
            return applieds;
        }
        public void RemoveAppliedJobsFromDB(string ID)
        {
            sqlQuery = "DELETE AppliedJobs"
                      +" WHERE ID = @ID";
            SqlParameter[] lstParams =
            {
                new SqlParameter("@ID", SqlDbType.Int) {Value = ID}
            };
            if (dbConn.ExecuteDeleteDataCheck(sqlQuery, lstParams))
            {
                MessageBox.Show("Xóa công việc đã ứng tuyển thành công");
            }
            else
            {
                MessageBox.Show("Xóa công việc đã ứng tuyển thất bại");
            }
        }
        public List<Dictionary<string, object>> GetSelectedJobDetails(int jobid)
        {
            sqlQuery = "SELECT j.Name JobName, c.Name CompanyName, j.Salary, c.Address, j.Experience, j.PostTime, j.JobDecription,                       j.WorkDuration, j.RequestCdd, j.Benefit"
                        +" FROM Jobs j"
                        +" JOIN Employers e ON j.EmpID = e.ID"
                        +" JOIN Company c ON e.CompanyName = c.Name"
                        +" WHERE j.ID = @jobId";
            SqlParameter[] lstParam =
            {
                new SqlParameter("@jobId", SqlDbType.Int) {Value = jobid},
            };
            List<Dictionary<string, object>> keyValueJobDetails = dbConn.ExecuteReaderData(sqlQuery, lstParam);
            return keyValueJobDetails;
        }
        public void AddSavedJob(int jobid)
        {
            sqlQuery = "INSERT INTO SavedJobs(TimeSaved, JobID)" +
                            " VALUES(@times,@jId)";
            SqlParameter[] lstParam =
            {
                    new SqlParameter("@times", SqlDbType.Date) {Value = DateTime.Now},
                    new SqlParameter("@jId", SqlDbType.Int) { Value = jobid },
            };
            if (dbConn.ExecuteWriteDataCheck(sqlQuery, lstParam))
            {
                MessageBox.Show("Lưu công việc thành công");
            }
            else
            {
                MessageBox.Show("Lưu công việc thất bại");
            }
        }
        public void AddAppliedJob(int jobid)
        {
            sqlQuery = "INSERT INTO AppliedJobs(TimeApplied, JobID)" +
                            " VALUES(@times,@jId)";
            SqlParameter[] lstParam =
            {
                    new SqlParameter("@times", SqlDbType.Date) {Value = DateTime.Now},
                    new SqlParameter("@jId", SqlDbType.Int) { Value = jobid },
                };
            if (dbConn.ExecuteWriteDataCheck(sqlQuery, lstParam))
            {
                MessageBox.Show("Ứng tuyển công việc thành công");
            }
            else
            {
                MessageBox.Show("Ứng tuyển công việc thất bại");
            }
        }
        public List<Dictionary<string, object>> GetCompanyFromDB(string companyName)
        {
            sqlQuery = $"SELECT *"
                        +" FROM Company"
                        +" WHERE Name = @CompanyName";
            SqlParameter[] lstParam =
            {
                new SqlParameter("@CompanyName", SqlDbType.NVarChar) { Value = companyName },
            };
            return dbConn.ExecuteReaderData(sqlQuery, lstParam);
        }
        public void SaveAvailableCV(CV cv,string cddid)
        {
            if (cv != null)
            {
                sqlQuery = "INSERT INTO CV(Objective, UniversityName, Major, GPA, UniversityStartDate"+
                       ", UniversityEndDate, CompanyName, WorkPlace, Detail, CompanyStartDate, CompanyEndDate, CertificationName,"+ "CertificationDate,CVOwner)"+
                       "VALUES(@Objective, @UniversityName, @Major, @GPA, @UniversityStartDate, @UniversityEndDate, @CompanyName, @WorkPlace, @Detail, @CompanyStartDate, @CompanyEndDate, @CertificationName, @CertificationDate, @CVOwner)";
                SqlParameter[] lstParams =
                    {
                new SqlParameter("@Objective", SqlDbType.Text) {Value = cv.Objective},
                new SqlParameter("@UniversityName", SqlDbType.NVarChar) {Value = cv.UniversityName},
                new SqlParameter("@Major", SqlDbType.NVarChar) {Value = cv.Major},
                new SqlParameter("@GPA", SqlDbType.NVarChar) {Value = cv.Gpa},
                new SqlParameter("@UniversityStartDate", SqlDbType.Date) {Value = cv.UniversityStartDate},
                new SqlParameter("@UniversityEndDate", SqlDbType.Date) {Value = cv.UniversityEndDate},
                new SqlParameter("@CompanyName", SqlDbType.NVarChar) {Value = cv.CompanyName},
                new SqlParameter("@WorkPlace", SqlDbType.NVarChar) {Value = cv.WorkPlace},
                new SqlParameter("@Detail", SqlDbType.Text) {Value = cv.WorkedDetail},
                new SqlParameter("@CompanyStartDate", SqlDbType.Date) {Value = cv.CompanyStartDate},
                new SqlParameter("@CompanyEndDate", SqlDbType.Date) {Value = cv.CompanyEndDate},
                new SqlParameter("@CertificationName", SqlDbType.NVarChar) {Value = cv.Certification},
                new SqlParameter("@CertificationDate", SqlDbType.Date) {Value = cv.CertificationDate},
                new SqlParameter("@CVOwner", SqlDbType.VarChar) {Value = cddid},
                };
                if(dbConn.ExecuteWriteDataCheck(sqlQuery, lstParams))
                {
                    MessageBox.Show("Lưu hồ sơ có hiệu lực thành công");
                }
                else
                {
                    MessageBox.Show("Lưu hồ sơ có hiệu lực thất bại");
                }
            }
            else
            {
                MessageBox.Show("CV be bull");
            }
        }

        public CV GetAvailableCVByCandidateID(string cddid)
        {
            CV cv = new CV();
            sqlQuery = "SELECT *"+
                       " FROM CV"+
                       " WHERE CVOwner = @CddID";
            SqlParameter[] lstParam =
            {
                new SqlParameter("@CddID", SqlDbType.VarChar) {Value = cddid},
            };
            List<Dictionary<string,object>> keyValues = dbConn.ExecuteReaderData(sqlQuery, lstParam);
            foreach(var item in keyValues)
            {
                cv.CddID = cddid;
                cv.Objective = (string)item["Objective"];
                cv.UniversityName = (string)item["UniversityName"];
                cv.Major = (string)item["Major"];
                cv.Gpa = (string)item["GPA"];
                cv.UniversityStartDate = (DateTime)item["UniversityStartDate"];
                cv.UniversityEndDate = (DateTime)item["UniversityEndDate"];
                cv.CompanyName = (string)item["CompanyName"];
                cv.CompanyStartDate = (DateTime)item["CompanyStartDate"];
                cv.CompanyEndDate = (DateTime)item["CompanyEndDate"];
                cv.WorkPlace = (string)item["WorkPlace"];
                cv.WorkedDetail = (string)item["Detail"];
                cv.Certification = (string)item["CertificationName"];
                cv.CertificationDate = (DateTime)item["CertificationDate"];

                return cv;
            }
            return null;
        }
        public void SaveResumeToDatabase(CV cv, int JobID)
        {
            if (cv != null)
            {
                sqlQuery = "INSERT INTO Resume (CddID, JobID, Objective, UniversityName, Major, GPA, UniversityStartDate, UniversityEndDate, CompanyName, WorkPlace, Detail, CompanyStartDate, CompanyEndDate, " +
                       "CertificationName, CertificationDate)" +
                       " VALUES(@CddID, @JobID, @Objective, @UniversityName, @Major, @GPA, @UniversityStartDate, @UniversityEndDate, @CompanyName, @WorkPlace, @Detail, @CompanyStartDate, @CompanyEndDate, @CertificationName, @CertificationDate)";
                SqlParameter[] lstParams =
                {
                new SqlParameter("@CddID", SqlDbType.VarChar) {Value = cv.CddID},
                new SqlParameter("@JobID", SqlDbType.Int) {Value = JobID},
                new SqlParameter("@Objective", SqlDbType.Text) {Value = cv.Objective},
                new SqlParameter("@UniversityName", SqlDbType.NVarChar) {Value = cv.UniversityName},
                new SqlParameter("@Major", SqlDbType.NVarChar) {Value = cv.Major},
                new SqlParameter("@GPA", SqlDbType.NVarChar) {Value = cv.Gpa},
                new SqlParameter("@UniversityStartDate", SqlDbType.Date) {Value = cv.UniversityStartDate},
                new SqlParameter("@UniversityEndDate", SqlDbType.Date) {Value = cv.UniversityEndDate},
                new SqlParameter("@CompanyName", SqlDbType.NVarChar) {Value = cv.CompanyName},
                new SqlParameter("@WorkPlace", SqlDbType.NVarChar) {Value = cv.WorkPlace},
                new SqlParameter("@Detail", SqlDbType.Text) {Value = cv.WorkedDetail},
                new SqlParameter("@CompanyStartDate", SqlDbType.Date) {Value = cv.CompanyStartDate},
                new SqlParameter("@CompanyEndDate", SqlDbType.Date) {Value = cv.CompanyEndDate},
                new SqlParameter("@CertificationName", SqlDbType.NVarChar) {Value = cv.Certification},
                new SqlParameter("@CertificationDate", SqlDbType.Date) {Value = cv.CertificationDate},
                };
                if (dbConn.ExecuteWriteDataCheck(sqlQuery, lstParams))
                {
                    MessageBox.Show("Lưu hồ sơ ứng tuyển của ứng viên thành công");
                }
                else
                {
                    MessageBox.Show("Lưu hồ sơ ứng viên thất bại");
                }
            }
            else
            {
                MessageBox.Show("CV be null. Check CV");
            }
        }
        public bool CheckCandidateExistsInResume(string Owner)
        {
            sqlQuery = "IF EXISTS (SELECT * FROM CV WHERE CVOwner = @CVOwner)" +
                       " SELECT 1" +
                       " ELSE SELECT 0";
            SqlParameter[] lstParam =
            {
                new SqlParameter("@CVOwner", SqlDbType.VarChar) {Value = Owner},
            };
            if (dbConn.ExecuteScalarGetInt(sqlQuery, lstParam) == 1)
            {
                return true;
            }
            return false;
        }
        public int GetJobIDByCddID(string CddID)
        {
            sqlQuery = "SELECT JobID"+
                       " FROM Resume"+
                       " WHERE CddID = @CddID";
            SqlParameter[] lstParam =
            {
                new SqlParameter("@CddID", SqlDbType.VarChar) {Value =CddID},   
            };
            int id = dbConn.ExecuteScalarGetInt(sqlQuery, lstParam);
            return id;
        }
        public void RemoveCVValid(string CddID, int JobID)
        {
            sqlQuery = "DELETE FROM Resume"+
                       " WHERE CddID = @CddID AND JobID = @JobID";
            SqlParameter[] lstParams =
            {
                new SqlParameter("@CddID", SqlDbType.VarChar) {Value = CddID},
                new SqlParameter("@JobID", SqlDbType.Int) {Value = JobID},
            };
            if (dbConn.ExecuteDeleteDataCheck(sqlQuery, lstParams))
            {
                MessageBox.Show($"Đã xóa Resume với mã ứng viên {CddID} và mã công việc {JobID}");
            }
            else
            {
                MessageBox.Show("Xóa Resume không thành công");
            }
        }
        // Đăng tuyển bài viết tìm việc
        public void AddJobPosting(CandidateProfile canProfile, string cddid)
        {

            if (canProfile != null && cddid != null)
            {
                sqlQuery = "INSERT INTO CandidateProfile(CddID, WorkPlace, Objective, UniversityName, Major, GPA, " +
                       "CompanyName,CertificationName)"+
                       " VALUES(@CddID, @WorkPlace, @Objective, @UniversityName, @Major, @GPA, @CompanyName,  @CertificationName)";
                SqlParameter[] lstParams =
                    {
                new SqlParameter("@CddID", SqlDbType.VarChar) {Value = cddid},
                new SqlParameter("@Objective", SqlDbType.Text) {Value = canProfile.Objective},
                new SqlParameter("@UniversityName", SqlDbType.NVarChar) {Value = canProfile.UniversityName},
                new SqlParameter("@Major", SqlDbType.NVarChar) {Value = canProfile.Major},
                new SqlParameter("@GPA", SqlDbType.NVarChar) {Value = canProfile.Gpa},
                new SqlParameter("@CompanyName", SqlDbType.NVarChar) {Value = canProfile.CompanyName},
                new SqlParameter("@WorkPlace", SqlDbType.NVarChar) {Value = canProfile.WorkPlace},
                new SqlParameter("@CertificationName", SqlDbType.NVarChar) {Value = canProfile.Certification},
                };
                if (dbConn.ExecuteWriteDataCheck(sqlQuery, lstParams))
                {
                    MessageBox.Show("Thêm bài đăng tìm việc thành công");
                }
                else
                {
                    MessageBox.Show("Thêm bài đăng tìm việc thất bại");
                }
            }
            else
            {
                MessageBox.Show("Candidate Profile be null");
            }
        }
        // Sửa bài viết tìm việc
        public void EditJobPosting(CandidateProfile canProfile, string cddid)
        {
            sqlQuery = "UPDATE CandidateProfile"
                      +" SET Objective = @Objective, UniversityName = @UniversityName, Major = @Major, GPA = @GPA, CompanyName = @CompanyName, CertificationName = @CertificationName, PostTime = @PostTime"
                      +" WHERE CddID = @CddID AND WorkPlace = @WorkPlace";
            SqlParameter[] lstParams =
                    {
                new SqlParameter("@CddID", SqlDbType.VarChar) {Value = cddid},
                new SqlParameter("@Objective", SqlDbType.Text) {Value = canProfile.Objective},
                new SqlParameter("@UniversityName", SqlDbType.NVarChar) {Value = canProfile.UniversityName},
                new SqlParameter("@Major", SqlDbType.NVarChar) {Value = canProfile.Major},
                new SqlParameter("@GPA", SqlDbType.NVarChar) {Value = canProfile.Gpa},
                new SqlParameter("@CompanyName", SqlDbType.NVarChar) {Value = canProfile.CompanyName},
                new SqlParameter("@WorkPlace", SqlDbType.NVarChar) {Value = canProfile.WorkPlace},
                new SqlParameter("@CertificationName", SqlDbType.NVarChar) {Value = canProfile.Certification},
                new SqlParameter("PostTime", SqlDbType.Date) {Value = DateTime.Now},
                };
            if (dbConn.ExecuteWriteDataCheck(sqlQuery, lstParams))
            {
                MessageBox.Show("Sửa bài đăng tìm việc thành công");
            }
            else
            {
                MessageBox.Show("Sửa bài đăng tìm việc thất bại");
            }
        }
        // Xóa bài viết tìm việc
        public void RemoveJobPosting(string WorkPlace, string CddID)
        {
            sqlQuery = "DELETE CandidatePrpfile WHERE CddID = @CddID AND WorkPlace = @WorkPlace";
            SqlParameter[] lstParams =
            {
                new SqlParameter("@CddID", SqlDbType.VarChar) {Value = CddID},
                new SqlParameter("@WorkPlace", SqlDbType.NVarChar) {Value = WorkPlace},
            };
            if (dbConn.ExecuteDeleteDataCheck(sqlQuery, lstParams))
            {
                MessageBox.Show("Xóa bài đăng tìm việc thành công");
            }
            else
            {
                MessageBox.Show("Xóa bài đăng tìm việc thất bại");
            }
        }
        public List<UC_WorkHistory> GetWorkHistory()
        {
            sqlQuery = "SELECT wh.CandidateID, cdd.CddName, wh.CompanyName, wh.StartDate, wh.EndDate"
                      +" FROM WorkHistory wh"
                      + " JOIN Candidates cdd ON wh.CandidateID = cdd.CddID";
            List<UC_WorkHistory> lstWorkHistory = new List<UC_WorkHistory>();
            List<Dictionary<string, object>> keyValuePairs = dbConn.ExecuteReaderData(sqlQuery);
            foreach (var keyValuePair in keyValuePairs)
            {
                CandidateProfile candidateProfile = new CandidateProfile();
                candidateProfile.CddID = (string)keyValuePair["CandidateID"];
                candidateProfile.CompanyName = (string)keyValuePair["CompanyName"];
                candidateProfile.CddName = (string)keyValuePair["CddName"];
                candidateProfile.CompanyStartDate = (DateTime)keyValuePair["StartDate"];
                candidateProfile.CompanyEndDate = (DateTime)keyValuePair["EndDate"];
                UC_WorkHistory uC_WorkHistory = new UC_WorkHistory(candidateProfile);
                lstWorkHistory.Add(uC_WorkHistory);
            }
            return lstWorkHistory;
        }
        public void AddWorkHistory(string cddid, string comname, DateTime sdate, DateTime ddate)
        {
            sqlQuery = "INSERT INTO WorkHistory(CandidateID, CompanyName, StartDate, EndDate)"
                      +" VALUES (@CandidateID, @CompanyName, @StartDate, @EndDate)";
            SqlParameter[] lstParams =
            {
                new SqlParameter("@CandidateID", SqlDbType.VarChar) {Value = cddid},
                new SqlParameter("@CompanyName", SqlDbType.NVarChar) {Value = comname},
                new SqlParameter("@StartDate", SqlDbType.Date) {Value = sdate},
                new SqlParameter("@EndDate", SqlDbType.Date) {Value = ddate},
            };
            if (dbConn.ExecuteWriteDataCheck(sqlQuery, lstParams))
            {
                MessageBox.Show("Thêm lịch sử làm việc thành công");
            }
            else
            {
                MessageBox.Show("Thêm chưa thành công");
            }
        }
        public void RemoveWorkHistory(string CddID, string CompanyName)
        {
            sqlQuery = "DELETE WorkHistory WHERE CandidateID = @CandidateID AND CompanyName = @CompanyName";
            SqlParameter[] lstParams =
            {
                new SqlParameter("@CandidateID", SqlDbType.VarChar) {Value = CddID},
                new SqlParameter("@CompanyName", SqlDbType.NVarChar) {Value = CompanyName},
            };
            if (dbConn.ExecuteDeleteDataCheck(sqlQuery, lstParams))
            {
                MessageBox.Show("Xóa lịch sử thành công");
            }
            else
            {
                MessageBox.Show("Xóa lịch sử thành công");
            }
        }
        // Tăng số lượng người theo dõi
        public void IncrementFlower()
        {
            sqlQuery = "UPDATE Company SET NumberOfFollower = NumberOfFollower + 1";
            if (dbConn.ExecuteWriteDataCheck(sqlQuery))
            {
                MessageBox.Show("Tăng follower thành công");
            }
            else
            {
                MessageBox.Show("Tăng follower thất bại");
            }
        }
        #endregion
        public List<UC_Candidate_Interview> GetListInterviewsToDB()
        {
            sqlQuery = "SELECT j.Name, emp.CompanyName, itv.InterviewTime, itv.Note, can.CddName"
                       +" FROM Interviews itv"
                       +" JOIN Employers emp ON itv.EmpID = emp.ID"
                       +" JOIN Candidates can ON itv.CddID = can.CddID"
                       +" JOIN Jobs j ON itv.JobID = j.ID"
                       +" WHERE can.CddID = 'CDD001'";
            List<Dictionary<string, object>> keyValuePairs = dbConn.ExecuteReaderData(sqlQuery);
            List<UC_Candidate_Interview> result = new List<UC_Candidate_Interview>();
            foreach (var reader in keyValuePairs)
            {
                Job job = new Job();
                Interview interview = new Interview();
                Candidate candidate = new Candidate();
                job.Name = (string)reader["Name"];
                job.CompanyName = (string)reader["CompanyName"];
                interview.InterviewTime = (DateTime)reader["InterviewTime"];
                interview.Note = (string)reader["Note"];
                candidate.Name = (string)reader["CddName"];
                UC_Candidate_Interview uc_interview = new UC_Candidate_Interview(job,interview, candidate);
                result.Add(uc_interview);
            }
            return result;
        }
        public int CountRowsInInterviews()
        {
            sqlQuery = "SELECT COUNT(*) FROM Interviews";
            int rows = dbConn.ExecuteScalarGetInt(sqlQuery);
            return rows;
        }
        public List<UC_Candidate_Interview> GetListInterviewByKey(string keyword)
        {
            sqlQuery = " SELECT j.Name, emp.CompanyName, itv.InterviewTime, itv.Note, can.CddName"
                       +" FROM Interviews itv"
                       +" JOIN Employers emp ON itv.EmpID = emp.ID"
                       +" JOIN Candidates can ON itv.CddID = can.CddID"
                       +" JOIN Jobs j ON itv.JobID = j.ID"
                       +" WHERE CONCAT(j.Name,emp.CompanyName) LIKE '%'+ @keyword +'%'";
            SqlParameter[] lstParams =
            {
                new SqlParameter("@keyword", SqlDbType.NVarChar) {Value = keyword},
            };
            List<Dictionary<string, object>> keyValuePairs = dbConn.ExecuteReaderData(sqlQuery, lstParams);
            List<UC_Candidate_Interview> result = new List<UC_Candidate_Interview>();
            foreach (var reader in keyValuePairs)
            {
                Job job = new Job();
                Interview interview = new Interview();
                Candidate candidate = new Candidate();
                job.Name = (string)reader["Name"];
                job.CompanyName = (string)reader["CompanyName"];
                interview.InterviewTime = (DateTime)reader["InterviewTime"];
                interview.Note = (string)reader["Note"];
                candidate.Name = (string)reader["CddName"];
                UC_Candidate_Interview uc_interview = new UC_Candidate_Interview(job, interview, candidate);
                result.Add(uc_interview);
            }
            return result;
        }
    }
}
