CREATE TABLE USERS(
	Username varchar(100) primary key,
	Password varchar(100),
	CddID varchar(10) foreign key references Candidates(CddID), 
	EmpID varchar(10) foreign key references Employers(ID)
	)
insert into USERS (Username, Password, CddID)
values ('hieu', 'hieu123456', 'CDD001')
insert into USERS (Username, Password, EmpID)
values ('tuan', 'tuan123456', 'E001')
	
CREATE TABLE Candidates(
	CddID varchar(10) CONSTRAINT PK_Cdd PRIMARY KEY,
	CddName nvarchar(100),
	Phone varchar(12),
	Email varchar(100),
	CddAddress nvarchar(250),
	Hometown nvarchar(250),
	Sex nvarchar(3),
	Education nvarchar(250)
)
CREATE TABLE Company (
	Name nvarchar(100) PRIMARY KEY,
	Address nvarchar(100),
	Manager nvarchar(100),
	TaxCode varchar(100),
	BusinessLicense varchar(100),
	NumberOfEmployee int,
	NumberOfFollower int,
	Introduction nvarchar(max)
)
CREATE TABLE WorkHistory(
	CandidateID varchar(10) FOREIGN KEY REFERENCES Candidates(CddID),
	CompanyName nvarchar(100) FOREIGN KEY REFERENCES Company(Name),
	CONSTRAINT PK_WorkHistory PRIMARY KEY (CandidateID, CompanyName),
	StartDate date,
	EndDate date
)

CREATE TABLE Employers(
	ID varchar(10) CONSTRAINT PK_Emp PRIMARY KEY,
	Email varchar(100),
	Name nvarchar(100),
	Sex nvarchar(10),
	Phone varchar(12),
	Workplace nvarchar(250),
	CompanyName nvarchar(100) FOREIGN KEY REFERENCES Company(Name),
)
CREATE TABLE Jobs(
	ID int IDENTITY(1, 1) CONSTRAINT PK_Job PRIMARY KEY,
	Name nvarchar(250),
	Salary int,
	JobDecription text,
	WorkDuration int,
	Experience nvarchar(250),
	ExpirationDate date,
	Benefit text,
	RequestCdd text,
	PostTime datetime,
	EmpID varchar(10) CONSTRAINT FK_EmpID FOREIGN KEY REFERENCES Employers(ID)
)
CREATE TABLE Education(
	UniversityName nvarchar(100) PRIMARY KEY,
	Major nvarchar(100),
	GPA nvarchar(100),
	StartDate date,
	EndDate date
)
CREATE TABLE WorkExperience(
	 CompanyName nvarchar(100) PRIMARY KEY,
	 WorkPlace nvarchar(100),
	 Detail text,
	 StartDate date,
	 EndDate date
)
CREATE TABLE Certification(
	Name nvarchar(100) PRIMARY KEY,
	CertificationDate date
)
CREATE TABLE CV(
	ID int IDENTITY PRIMARY KEY,
	Objective text,
	UniversityName nvarchar(100),
	Major nvarchar(100),
	GPA nvarchar(100),
	UniversityStartDate date,
	UniversityEndDate date,
	CompanyName nvarchar(100),
	WorkPlace nvarchar(100),
	Detail text,
	CompanyStartDate date,
	CompanyEndDate date,
	CertificationName nvarchar(100),
	CertificationDate date,
	CVOwner varchar(10) CONSTRAINT FK_CV_Cdd FOREIGN KEY REFERENCES Candidates(CddID),
)
CREATE TABLE Resume(
	CddID varchar(10) CONSTRAINT FK_Cdd FOREIGN KEY REFERENCES Candidates(CddID),
	JobID int CONSTRAINT FK_Job FOREIGN KEY REFERENCES Jobs(ID),
	Objective text,
	UniversityName nvarchar(100),
	Major nvarchar(100),
	GPA nvarchar(100),
	UniversityStartDate date,
	UniversityEndDate date,
	CompanyName nvarchar(100),
	WorkPlace nvarchar(100),
	Detail text,
	CompanyStartDate date,
	CompanyEndDate date,
	CertificationName nvarchar(100),
	CertificationDate date,
	Status nvarchar(100) default N'Applying',
	Interview datetime default null,
	CONSTRAINT PK_AD PRIMARY KEY (CddID, JobID)
)
CREATE TABLE Interviews (
	ID int IDENTITY PRIMARY KEY,
	EmpID varchar(10) foreign key references Employers(ID),
	CddID varchar(10) foreign key references Candidates(CddID),
	JobID int foreign key references Jobs(ID),
	InterviewTime datetime,
	Note nvarchar(max)
)
CREATE TABLE CandidateProfile(
	CddID varchar(10) CONSTRAINT FK_Profile_Cdd FOREIGN KEY REFERENCES Candidates(CddID),
	WorkPlace nvarchar(100),
	Objective text,
	UniversityName nvarchar(100),
	Major nvarchar(100),
	GPA nvarchar(100),
	CompanyName nvarchar(100),
	CertificationName nvarchar(100),
	PostTime date,
	CONSTRAINT PK_Profile PRIMARY KEY (CddID, WorkPlace)
)
	 
-- Tạo bảng Saved Jobs
CREATE TABLE SavedJobs(
	ID int IDENTITY primary key,
	TimeSaved date,
	JobID int FOREIGN KEY REFERENCES Jobs(ID) 
)
-- Tạo bảng Applied Jobs
CREATE TABLE AppliedJobs(
	ID int IDENTITY primary key,
	TimeApplied date,
	JobID int FOREIGN KEY REFERENCES Jobs(ID) 
)
SELECT * FROM AppliedJobs


-- Dữ liệu cho bảng Candidates
INSERT INTO Candidates (CddID, CddName, Phone, Email, CddAddress, Hometown, Sex, Education)
VALUES 
('CDD001', N'Nguyễn Văn A', '1234567890', 'nguyenvana@example.com', '123 ABC Street', N'Hà Nội', N'Nam', 'Bachelor of Science in Computer Science'),
('CDD002', N'Trần Thị B', '0987654321', 'tranthib@example.com', '456 XYZ Street', N'Hồ Chí Minh City', N'Nữ', 'Master of Business Administration'),
('CDD003', N'Phạm Văn C', '0123456789', 'phamvanc@example.com', '789 DEF Street', N'Đà Nẵng', N'Nam', 'Bachelor of Arts in English');

SELECT * FROM Company
INSERT INTO Company (Name, Address, Manager, TaxCode, BusinessLicense, NumberOfEmployee, NumberOfFollower, Introduction)
VALUES (N'Công ty ABC', N'123 Đống Đa, Hà Nội', N'Miss.An', '123456789', 'BL-001', 100, 500, N'Công ty TNHH Grande Media chuyên cung cấp dịch vụ quảng cáo trực tuyến hàng đầu Việt Nam');
INSERT INTO Company (Name, Address, Manager, TaxCode, BusinessLicense, NumberOfEmployee, NumberOfFollower, Introduction)
VALUES (N'Công ty TNHH một mình tao', N'Gò Vấp, TP Hồ Chí Minh', N'Miss.An', '123456789', 'BL-002', 100, 500, N'Công ty TNHH Grande Media chuyên cung cấp dịch vụ quảng cáo trực tuyến hàng đầu Việt Nam'),
	   (N'Công ty Tâm Bình', N'Quận 9, TP Hồ Chí Minh', N'Miss.An', '123456789', 'BL-003', 90, 100, N'Công ty TNHH Grande Media chuyên cung cấp dịch vụ IT trực tuyến hàng đầu Việt Nam'),
	   (N'Công ty Nhân Tâm', N'Đà Nẵng', N'Miss.An', '123456789', 'BL-004', 250, 1200, N'Công ty TNHH Grande Media chuyên cung cấp dịch vụ Marketing trực tuyến hàng đầu Việt Nam');

-- Dữ liệu cho bảng Employeers
INSERT INTO Employers (ID, Email, Name, Sex, Phone, Workplace, CompanyName)
VALUES ('E001', '22110260@student.hcmute.edu.vn', N'Tuấn', N'Nam', '0705488458', N'Giám đốc', N'Công ty ABC');
INSERT INTO Employers (ID, Email, Name, Sex, Phone, Workplace, CompanyName)
VALUES ('E002', '22110139@student.hcmute.edu.vn', N'Hiếu', N'Nam', '0705488458', N'Chủ tịch', N'Công ty TNHH một mình tao'),
	   ('E003', '22110260@student.hcmute.edu.vn', N'Tuấn', N'Nam', '0705488458', N'Giám đốc', N'Công ty Nhân Tâm');

-- Dữ liệu cho bảng Jobs
-- Job 1
INSERT INTO Jobs (Name, Salary, JobDecription, WorkDuration, Experience, ExpirationDate, Benefit, RequestCdd, PostTime, EmpID)
VALUES ('Software Engineer', 80000, 'Develop and maintain software applications.', 40, '3+ years in software development', '2024-05-01', 'Health insurance, 401k', 'Bachelor degree in Computer Science', '2024-03-26', 'E001');
-- Job 2
INSERT INTO Jobs (Name, Salary, JobDecription, WorkDuration, Experience, ExpirationDate, Benefit, RequestCdd, PostTime, EmpID)
VALUES ('Marketing Specialist', 60000, 'Plan and execute marketing campaigns.', 40, '2+ years in marketing field', '2024-04-15', 'Paid time off, Flexible hours', 'Bachelors degree in Marketing or related field', '2024-03-26', 'E001');
-- Job 3
INSERT INTO Jobs (Name, Salary, JobDecription, WorkDuration, Experience, ExpirationDate, Benefit, RequestCdd, PostTime, EmpID)
VALUES ('HR Manager', 70000, 'Oversee all aspects of human resources functions.', 40, '5+ years in HR management', '2024-04-30', 'Health insurance, Retirement plan', 'Bachelors degree in Human Resources or related field', '2024-03-26', 'E001');
INSERT INTO Jobs (Name, Salary, JobDecription, WorkDuration, Experience, ExpirationDate, Benefit, RequestCdd, PostTime, EmpID)
VALUES ('Sale', 50000, 'Sale all products', 40, '1+ years in HR management', '2024-04-30', 'Health insurance, Retirement plan', 'Bachelors degree in Human Resources or related field', '2024-03-26', 'E002');
INSERT INTO Jobs (Name, Salary, JobDecription, WorkDuration, Experience, ExpirationDate, Benefit, RequestCdd, PostTime, EmpID)
VALUES ('Digital Marketing', 100000, 'Do something.', 40, '3+ years in HR management', '2024-04-30', 'Health insurance, Retirement plan', 'Bachelors degree in Human Resources or related field', '2024-03-26', 'E003');

-- Dữ liệu cho bảng Resume
INSERT INTO Resume (CddID, JobID, Objective, UniversityName, Major, GPA, UniversityStartDate, UniversityEndDate, CompanyName, WorkPlace, Detail, CompanyStartDate, CompanyEndDate, CertificationName, CertificationDate, Status)
VALUES 
('CDD001', '1', N'Seeking a Software Engineer position to apply my skills in software development and contribute to the success of innovative projects at ABC Corporation.', N'Tech University', N'Computer Science', '3.7', '2018-09-01', '2022-06-01', N'Software Solutions Inc.', N'Hanoi, Vietnam', N'Developed scalable web applications using Python and Django framework.', '2022-07-01', '2023-12-31', N'AWS Certified Developer - Associate', '2024-01-15', 'Đang ứng tuyển');
INSERT INTO Resume (CddID, JobID, Objective, UniversityName, Major, GPA, UniversityStartDate, UniversityEndDate, CompanyName, WorkPlace, Detail, CompanyStartDate, CompanyEndDate, CertificationName, CertificationDate, Status)
VALUES 
('CDD001', '2', N'Results-driven Marketing Specialist with a passion for creating impactful campaigns. Seeking to leverage my expertise in digital marketing at ABC Corporation.', N'Marketing Academy', N'Marketing Management', '3.8', '2017-08-01', '2021-05-01', N'Digital Marketing Agency', N'Cityville, USA', N'Led successful social media campaigns resulting in a 20% increase in user engagement.', '2021-06-15', '2023-03-31', N'HubSpot Content Marketing Certification', '2023-06-20', 'Đang ứng tuyển');
INSERT INTO Resume (CddID, JobID, Objective, UniversityName, Major, GPA, UniversityStartDate, UniversityEndDate, CompanyName, WorkPlace, Detail, CompanyStartDate, CompanyEndDate, CertificationName, CertificationDate, Status)
VALUES 
('CDD001', '3', 'Experienced HR professional with a proven track record of managing diverse teams. Seeking a challenging role as an HR Manager at ABC Corporation.', 'University of HR Management', 'Human Resources', '3.9', '2015-09-01', '2019-06-01', 'HR Solutions Inc.', 'Hanoi, Vietnam', 'Managed recruitment processes and employee relations.', '2019-07-15', '2022-02-28', 'PHR Certification', '2023-05-10', 'Đang ứng tuyển');
SELECT * FROM WorkHistory
INSERT INTO WorkHistory(CandidateID, CompanyName, StartDate, EndDate)
VALUES ('CDD001', 'Công ty ABC', '2018-09-01', '2020-02-10');

INSERT INTO WorkHistory(CandidateID, CompanyName, StartDate, EndDate)
VALUES
	   ('CDD001', N'Công ty TNHH một mình tao', '2020-03-01', '2021-02-10'),
	   ('CDD001', N'Công ty Tâm Bình', '2021-09-01', '2022-02-10'),
	   ('CDD001', N'Công ty Nhân Tâm', '2023-09-01', '2024-02-10');

SELECT * FROM Jobs
SELECT * FROM Interviews
Declare @keyword nvarchar(MAX)
Set @keyword = 'Soft'
SELECT j.Name, emp.CompanyName, itv.InterviewTime, itv.Note, can.CddName
FROM Interviews itv
JOIN Employers emp ON itv.EmpID = emp.ID
JOIN Candidates can ON itv.CddID = can.CddID
JOIN Jobs j ON itv.JobID = j.ID 
WHERE CONCAT(j.Name,emp.CompanyName) LIKE '%'+ @keyword +'%'

INSERT INTO Interviews(EmpID,CddID,JobID,InterviewTime,Note)
VALUES('E001','CDD001',1,'2024-05-03',N'Tác phong chuẩn bị nghiêm túc và tinh thần tốt để phỏng vấn')
SELECT COUNT(*) FROM Interviews

DELETE FROM Resume
WHERE CddID = @CddID AND JobID = @JobID

SELECT JobID
FROM Resume
WHERE CddID = 'CDD001'