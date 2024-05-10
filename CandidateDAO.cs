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
        public List<UC_JobsSaved> GetSavedJobsFromDB(string cddid)
        {
            sqlQuery = "SELECT sj.ID SJID, j.Name, j.JobDecription, c.Name as CompanyName, sj.TimeSaved, c.Address, j.Salary, sj.JobID, j.PostTime"
                       +" FROM SavedJobs sj"
                       +" JOIN Jobs j ON sj.JobID = j.ID"
                       +" JOIN Employers e ON j.EmpID = e.ID"
                       +" JOIN Company c ON c.Name = e.CompanyName" +
                       " WHERE sj.CddID = @CddID";
            SqlParameter[] lstParams =
            {
                new SqlParameter("@CddID", SqlDbType.VarChar) {Value = cddid}
            };
            List<Dictionary<string, object>> keyValueSavedJobs = dbConn.ExecuteReaderData(sqlQuery, lstParams);
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
                savedJob.CddID = cddid;
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
        public string GetStatus(string cddid, int jobid)
        {
            sqlQuery = "SELECT Status" +
                       " FROM Resume" +
                       " WHERE CddID = @CddID AND JobID = @JobID";
            SqlParameter[] lstParams =
            {
                new SqlParameter("@CddID", SqlDbType.VarChar) {Value = cddid},
                new SqlParameter("@JobID", SqlDbType.Int) {Value = jobid},
            };
            string status = dbConn.ExecuteScalar(sqlQuery, lstParams);
            return status;
        }
        public List<UC_AppliedJobs> GetAppliedJobsFromDB(string cddid)
        {
            sqlQuery = "SELECT aj.ID, j.Name, j.JobDecription, c.Name as CompanyName, aj.TimeApplied, c.Address, j.Salary, aj.JobID, j.PostTime"
                       +" FROM AppliedJobs aj"
                       +" JOIN Jobs j ON aj.JobID = j.ID"
                       +" JOIN Employers e ON j.EmpID = e.ID"
                       +" JOIN Company c ON c.Name = e.CompanyName" +
                       " WHERE aj.CddID = @CddID";
            SqlParameter[] lstParams =
            {
                new SqlParameter("@CddID", SqlDbType.VarChar) {Value = cddid}
            };
            List<Dictionary<string, object>> keyValueSavedJobs = dbConn.ExecuteReaderData(sqlQuery, lstParams);
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
                applied.Status = GetStatus(cddid, (int)row["JobID"]);
                applied.CddID = cddid;
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
            sqlQuery = "SELECT j.Name JobName, c.Name CompanyName, j.Salary, c.Address, j.Experience, j.PostTime, j.JobDecription, j.WorkDuration, j.RequestCdd, j.Benefit"
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
        public void AddSavedJob(int jobid, string cddid)
        {
            sqlQuery = "INSERT INTO SavedJobs(TimeSaved, JobID, CddID)" +
                            " VALUES(@times,@jId,@CddID)";
            SqlParameter[] lstParam =
            {
                    new SqlParameter("@times", SqlDbType.Date) {Value = DateTime.Now},
                    new SqlParameter("@jId", SqlDbType.Int) { Value = jobid },
                    new SqlParameter("@CddId", SqlDbType.VarChar) {Value = cddid}
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
        public void AddAppliedJob(int jobid, string cddid)
        {
            sqlQuery = "INSERT INTO AppliedJobs(TimeApplied, JobID, CddID)" +
                            " VALUES(@times,@jId, @CddID)";
            SqlParameter[] lstParam =
            {
                    new SqlParameter("@times", SqlDbType.Date) {Value = DateTime.Now},
                    new SqlParameter("@jId", SqlDbType.Int) { Value = jobid },
                    new SqlParameter("@CddId", SqlDbType.VarChar) {Value = cddid}
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
        #region Functions CV
        public void SaveAvailableCV(CV cv,string cddid)
        {
            if (cv != null)
            {
                sqlQuery = "INSERT INTO CV(Objective, Nominee, UniversityName, Major, GPA, UniversityStartDate"+
                       ", UniversityEndDate, CompanyName, WorkPlace, Detail, CompanyStartDate, CompanyEndDate, CertificationName,"+ "CertificationDate,CVOwner)"+
                       " VALUES(@Objective, @Nominee, @UniversityName, @Major, @GPA, @UniversityStartDate, @UniversityEndDate, @CompanyName, @WorkPlace, @Detail, @CompanyStartDate, @CompanyEndDate, @CertificationName, @CertificationDate, @CVOwner)";
                SqlParameter[] lstParams =
                {
                    new SqlParameter("@Objective", SqlDbType.NVarChar) {Value = cv.Objective ?? string.Empty},
                    new SqlParameter("@Nominee", SqlDbType.NVarChar) {Value = cv.Nominee ?? string.Empty},
                    new SqlParameter("@UniversityName", SqlDbType.NVarChar) {Value = cv.UniversityName ?? string.Empty},
                    new SqlParameter("@Major", SqlDbType.NVarChar) {Value = cv.Major ?? string.Empty},
                    new SqlParameter("@GPA", SqlDbType.NVarChar) {Value = cv.Gpa ?? string.Empty},
                    new SqlParameter("@UniversityStartDate", SqlDbType.NVarChar) {Value = cv.UniversityStartDate ?? string.Empty},
                    new SqlParameter("@UniversityEndDate", SqlDbType.NVarChar) {Value = cv.UniversityEndDate ?? string.Empty},
                    new SqlParameter("@CompanyName", SqlDbType.NVarChar) {Value = cv.CompanyName ?? string.Empty},
                    new SqlParameter("@WorkPlace", SqlDbType.NVarChar) {Value = cv.WorkPlace ?? string.Empty},
                    new SqlParameter("@Detail", SqlDbType.NVarChar) {Value = cv.WorkedDetail ?? string.Empty},
                    new SqlParameter("@CompanyStartDate", SqlDbType.NVarChar) {Value = cv.CompanyStartDate ?? string.Empty},
                    new SqlParameter("@CompanyEndDate", SqlDbType.NVarChar) {Value = cv.CompanyEndDate ?? string.Empty},
                    new SqlParameter("@CertificationName", SqlDbType.NVarChar) {Value = cv.Certification ?? string.Empty},
                    new SqlParameter("@CertificationDate", SqlDbType.NVarChar) {Value = cv.CertificationDate ?? string.Empty},
                    new SqlParameter("@CVOwner", SqlDbType.VarChar) {Value = cddid}
                };
                if (dbConn.ExecuteWriteDataCheck(sqlQuery, lstParams))
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
                MessageBox.Show("CV be null");
            }
        }

        public CV GetAvailableCVByCandidateID(int cvID, string cddid)
        {
            CV cv = new CV();
            sqlQuery = "SELECT *"+
                       " FROM CV"+
                       " WHERE ID = @ID";
            SqlParameter[] lstParam =
            {
                new SqlParameter("@ID", SqlDbType.VarChar) {Value = cvID},
            };
            List<Dictionary<string,object>> keyValues = dbConn.ExecuteReaderData(sqlQuery, lstParam);
            foreach(var item in keyValues)
            {
                cv.ID = cvID;
                cv.CddID = cddid;
                cv.Nominee = (string)item["Nominee"];
                cv.Objective = (string)item["Objective"];
                cv.UniversityName = (string)item["UniversityName"];
                cv.Major = (string)item["Major"];
                cv.Gpa = (string)item["GPA"];
                cv.UniversityStartDate = (string)item["UniversityStartDate"];
                cv.UniversityEndDate = (string)item["UniversityEndDate"];
                cv.CompanyName = (string)item["CompanyName"];
                cv.CompanyStartDate = (string)item["CompanyStartDate"];
                cv.CompanyEndDate = (string)item["CompanyEndDate"];
                cv.WorkPlace = (string)item["WorkPlace"];
                cv.WorkedDetail = (string)item["Detail"];
                cv.Certification = (string)item["CertificationName"];
                cv.CertificationDate = (string)item["CertificationDate"];

                return cv;
            }
            return null;
        }
        public bool SaveResumeToDatabase(CV cv, int JobID)
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
                new SqlParameter("@Objective", SqlDbType.NVarChar) {Value = cv.Objective},
                new SqlParameter("@UniversityName", SqlDbType.NVarChar) {Value = cv.UniversityName},
                new SqlParameter("@Major", SqlDbType.NVarChar) {Value = cv.Major},
                new SqlParameter("@GPA", SqlDbType.NVarChar) {Value = cv.Gpa},
                new SqlParameter("@UniversityStartDate", SqlDbType.NVarChar) {Value = cv.UniversityStartDate},
                new SqlParameter("@UniversityEndDate", SqlDbType.NVarChar) {Value = cv.UniversityEndDate},
                new SqlParameter("@CompanyName", SqlDbType.NVarChar) {Value = cv.CompanyName},
                new SqlParameter("@WorkPlace", SqlDbType.NVarChar) {Value = cv.WorkPlace},
                new SqlParameter("@Detail", SqlDbType.NVarChar) {Value = cv.WorkedDetail},
                new SqlParameter("@CompanyStartDate", SqlDbType.NVarChar) {Value = cv.CompanyStartDate},
                new SqlParameter("@CompanyEndDate", SqlDbType.NVarChar) {Value = cv.CompanyEndDate},
                new SqlParameter("@CertificationName", SqlDbType.NVarChar) {Value = cv.Certification},
                new SqlParameter("@CertificationDate", SqlDbType.NVarChar) {Value = cv.CertificationDate},
                };
                if (dbConn.ExecuteWriteDataCheck(sqlQuery, lstParams))
                {
                    MessageBox.Show("Lưu hồ sơ ứng tuyển của ứng viên thành công");
                    return true;
                }
                else
                {
                    MessageBox.Show("Lưu hồ sơ ứng viên thất bại");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("CV be null. Check CV");
                return false;
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
        public void RemoveCVValid(int id)
        {
            sqlQuery = "DELETE FROM CV"+
                       " WHERE ID = @ID";
            SqlParameter[] lstParams =
            {
                new SqlParameter("@ID", SqlDbType.Int) {Value = id},
            };
            if (dbConn.ExecuteDeleteDataCheck(sqlQuery, lstParams))
            {
                MessageBox.Show($"Đã xóa CV thành công");
            }
            else
            {
                MessageBox.Show("Xóa CV không thành công");
            }
        }
        #endregion
        #region Functions đăng tải công việc
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
        #endregion
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
                DateTime startDate = (DateTime)keyValuePair["StartDate"];
                candidateProfile.CompanyStartDate = startDate.ToLongDateString();
                DateTime endDate = (DateTime)keyValuePair["EndDate"];
                candidateProfile.CompanyEndDate = endDate.ToLongDateString();
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
        #region Functions cho interview
        public List<UC_Candidate_Interview> GetListInterviewsToDB(string cddid)
        {
            sqlQuery = "SELECT j.Name, emp.CompanyName, itv.InterviewTime, itv.Note, can.CddName"
                       +" FROM Interviews itv"
                       +" JOIN Employers emp ON itv.EmpID = emp.ID"
                       +" JOIN Candidates can ON itv.CddID = can.CddID"
                       +" JOIN Jobs j ON itv.JobID = j.ID"
                       +" WHERE can.CddID = @CddID";
            SqlParameter[] lstParams =
            {
                new SqlParameter("@CddID", SqlDbType.VarChar) {Value = cddid}
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
                UC_Candidate_Interview uc_interview = new UC_Candidate_Interview(job,interview, candidate, "Interview");
                result.Add(uc_interview);
            }
            return result;
        }
        public List<UC_Candidate_Interview> GetListInterviewsByCVToDB(string cddid)
        {
            sqlQuery = "SELECT j.Name, emp.CompanyName, itv.InterviewTime, itv.Note, can.CddName, cv.Nominee"
                       +" FROM InterviewsByCV itv"
                       +" JOIN Employers emp ON itv.EmpID = emp.ID"
                       +" JOIN Candidates can ON itv.CddID = can.CddID" +
                       " JOIN CV cv ON can.CddID = cv.CVOwner"
                       +" WHERE can.CddID = @CddID";
            SqlParameter[] lstParams =
            {
                new SqlParameter("@CddID", SqlDbType.VarChar) {Value = cddid}
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
                candidate.Nominee = (string)reader["Nominee"];
                UC_Candidate_Interview uc_interview = new UC_Candidate_Interview(job, interview, candidate, "InterviewByCV");
                result.Add(uc_interview);
            }
            return result;
        }
        public int CountRowsInInterviews(string cddid)
        {
            sqlQuery = "SELECT COUNT(*) FROM Interviews WHERE CddID = @CddID";
            SqlParameter[] lstParams =
            {
                new SqlParameter("@CddID", SqlDbType.VarChar) {Value = cddid}
            };
            int rows = dbConn.ExecuteScalarGetInt(sqlQuery, lstParams);
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
                UC_Candidate_Interview uc_interview = new UC_Candidate_Interview(job, interview, candidate, "Interview");
                result.Add(uc_interview);
            }
            return result;
        }
        #endregion
        #region Functions cho kiểm tra số lượng công việc đã lưu với công việc đã ứng tuyển
        public int CountJobSaved(string cddid)
        {
            sqlQuery = "SELECT COUNT(*) FROM SavedJobs WHERE CddID = @CddID";
            SqlParameter[] lstParam =
            {
                new SqlParameter("@CddID", SqlDbType.VarChar) {Value = cddid}
            };
            int res = dbConn.ExecuteScalarGetInt(sqlQuery, lstParam);
            return res;
        }
        public int CountJobApplied(string cddid)
        {
            sqlQuery = "SELECT COUNT(*) FROM AppliedJobs WHERE CddID = @CddID";
            SqlParameter[] lstParam =
            {
                new SqlParameter("@CddID", SqlDbType.VarChar) {Value = cddid}
            };
            int res = dbConn.ExecuteScalarGetInt(sqlQuery, lstParam);
            return res;
        }
        #endregion
        #region Update Candidate Information
        public Candidate GetCandidateInfor(string cddid)
        {
            sqlQuery = $"SELECT * FROM Candidates WHERE CddID = '{cddid}'";
            Candidate candidate = new Candidate();
            List<Dictionary<string,object>> results = dbConn.ExecuteReaderData(sqlQuery);
            foreach (var row in results)
            {
                candidate.Id = (string)row["CddID"];
                candidate.Name = (string)row["CddName"];
                candidate.Phone = (string)row["Phone"];
                candidate.Email = (string)row["Email"];
                candidate.Address = (string)row["CddAddress"];
                candidate.Hometown = (string)row["Hometown"];
                candidate.Sex = (string)row["Sex"];
                candidate.Education = (string)row["Education"];
            }
            return candidate;
        }
        public void UpdateCandidateInfor(Candidate candidate)
        {
            sqlQuery = "UPDATE Candidates"+
                       " SET CddName = @CddName, Phone = @Phone, Email = @Email, CddAddress = @CddAddress, Hometown = @Hometown, Sex = @Sex" +
                       ", Education = @Education" +
                       " WHERE CddID = @CddID";
            SqlParameter[] lstParams =
            {
                new SqlParameter("@CddName", SqlDbType.NVarChar) {Value = candidate.Name},
                new SqlParameter("@Phone", SqlDbType.NVarChar) {Value = candidate.Phone},
                new SqlParameter("@Email", SqlDbType.NVarChar) {Value = candidate.Email},
                new SqlParameter("@CddAddress", SqlDbType.NVarChar) {Value = candidate.Address},
                new SqlParameter("@Hometown", SqlDbType.NVarChar) {Value = candidate.Hometown},
                new SqlParameter("@Sex", SqlDbType.NVarChar) {Value = candidate.Sex},
                new SqlParameter("@Education", SqlDbType.NVarChar) {Value = candidate.Education},
                new SqlParameter("@CddID", SqlDbType.NVarChar) {Value = candidate.Id},
            };
            if (dbConn.ExecuteWriteDataCheck(sqlQuery, lstParams))
            {
                MessageBox.Show("Cập nhật thông tin thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin thất bại. Xem lại đã điền đúng thông tin hay chưa !");
            }
        }
        #endregion
        #region Đăng ký thông tin ứng viên
        public bool RegisterCandidateInfo(Candidate candidate)
        {
            sqlQuery = "INSERT INTO Candidates(CddID, CddName,Phone,Email,CddAddress,Hometown,Sex,Education)" +
                       " VALUES(@CddID, @CddName, @Phone, @Email, @CddAddress, @Hometown, @Sex, @Education)";
            SqlParameter[] lstParams =
            {
                new SqlParameter("@CddID", SqlDbType.NVarChar) {Value = candidate.Id},
                new SqlParameter("@CddName", SqlDbType.NVarChar) {Value = candidate.Name},
                new SqlParameter("@Phone", SqlDbType.NVarChar) {Value = candidate.Phone},
                new SqlParameter("@Email", SqlDbType.NVarChar) {Value = candidate.Email},
                new SqlParameter("@CddAddress", SqlDbType.NVarChar) {Value = candidate.Address},
                new SqlParameter("@Hometown", SqlDbType.NVarChar) {Value = candidate.Hometown},
                new SqlParameter("@Sex", SqlDbType.NVarChar) {Value = candidate.Sex},
                new SqlParameter("@Education", SqlDbType.NVarChar) {Value = candidate.Education},
            };
            if (dbConn.ExecuteWriteDataCheck(sqlQuery, lstParams))
            {
                return true;
            }
            return false;
        }
        public void RegisterUser(string username, string password, string cddid)
        {
            sqlQuery = "INSERT INTO USERS(Username,Password, CddID)" +
                       " VALUES(@Username, @Password, @CddID)";
            SqlParameter[] lstParams =
            {
                new SqlParameter("@Username", SqlDbType.VarChar) {Value = username},
                new SqlParameter("@Password", SqlDbType.VarChar) {Value = password},
                new SqlParameter("@CddID", SqlDbType.VarChar) {Value = cddid},
            };
            if (dbConn.ExecuteWriteDataCheck(sqlQuery, lstParams))
            {
                MessageBox.Show("Đăng ký tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Đăng ký tài khoản thất bại");
            }
        }
        public bool CheckCandidateExistsInDatabase(string cddid)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Jobs_Management;Integrated Security=True"))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT dbo.func_CheckCandidate(@CddID)", conn))
                    {
                        cmd.Parameters.AddWithValue("@CddID", cddid);

                        // Since the function returns BIT, we expect a boolean value
                        bool exists = (bool)cmd.ExecuteScalar();

                        return exists;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public string GetCddID()
        {
            sqlQuery = "SELECT TOP 1 CddID FROM Candidates ORDER BY CddID DESC";
            string cddid = dbConn.ExecuteScalar(sqlQuery);
            return cddid;
        }
        public int ConvertCddToNumber(string input)
        {
            // Giả định tiền tố có độ dài cố định là 3 ký tự
            string numberPart = input.Substring(3);

            // Chuyển đổi chuỗi thành số
            if (int.TryParse(numberPart, out int result))
            {
                return result + 1;
            }
            else
            {
                throw new ArgumentException("Chuỗi không chứa một số hợp lệ.");
            }
        }
        #endregion

        #region Tối ưu CV
        public List<UC_DescribesCV> GetListDescribesCV(string cddid)
        {
            sqlQuery = "SELECT ID, Nominee, UniversityName, Major, GPA, CertificationName" +
                       " FROM CV" +
                       " WHERE CVOwner = @CddID";
            SqlParameter[] lstParams =
            {
                new SqlParameter("@CddID", SqlDbType.VarChar) {Value = cddid}
            };
            List<Dictionary<string, object>> keyValuePairs = dbConn.ExecuteReaderData(sqlQuery, lstParams);
            List<UC_DescribesCV> lstItems = new List<UC_DescribesCV>();
            foreach (var key in keyValuePairs)
            {
                CV cv = new CV();
                cv.ID = (int)key["ID"];
                cv.Nominee = (string)key["Nominee"];
                cv.UniversityName = (string)key["UniversityName"];
                cv.Major = (string)key["Major"];
                cv.Gpa = (string)key["GPA"];
                cv.Certification = (string)key["CertificationName"];
                UC_DescribesCV item = new UC_DescribesCV(cv);
                lstItems.Add(item);
            }
            return lstItems;
        }
        public string GetCVOwnerByCVID(int cvID)
        {
            sqlQuery = "SELECT CVOwner FROM CV WHERE ID = @cvID";
            SqlParameter[] lstParam =
            {
                new SqlParameter("@cvID", SqlDbType.Int) {Value = cvID }
            };
            string cddid = dbConn.ExecuteScalar(sqlQuery, lstParam);
            return cddid;
        }
        #endregion
    }
}
