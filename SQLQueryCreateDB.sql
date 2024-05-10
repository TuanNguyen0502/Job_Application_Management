CREATE TABLE USERS(
	Username varchar(100) primary key,
	Password varchar(100),
	CddID varchar(10) foreign key references Candidates(CddID), 
	EmpID varchar(10) foreign key references Employers(ID)
	)
insert into USERS (Username, Password, CddID)
values ('hieu', '123', 'CDD001')
insert into USERS (Username, Password, EmpID)
values ('tuan', '123', 'E001')

insert into USERS (Username, Password, EmpID)
values ('tuan2', '123', 'E002'),
	   ('tuan3', '123', 'E003');
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
	Name nvarchar(max),
	Salary int,
	JobDecription nvarchar(max),
	WorkDuration nvarchar(max),
	Experience nvarchar(max),
	ExpirationDate date,
	Benefit nvarchar(max),
	RequestCdd nvarchar(max),
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
	Nominee nvarchar(MAX),
	Objective nvarchar(MAX),
	UniversityName nvarchar(MAX),
	Major nvarchar(MAX),
	GPA nvarchar(MAX),
	UniversityStartDate nvarchar(MAX),
	UniversityEndDate nvarchar(MAX),
	CompanyName nvarchar(MAX),
	WorkPlace nvarchar(MAX),
	Detail nvarchar(MAX),
	CompanyStartDate nvarchar(MAX),
	CompanyEndDate nvarchar(MAX),
	CertificationName nvarchar(MAX),
	CertificationDate nvarchar(MAX),
	CVOwner varchar(10) CONSTRAINT FK_CV_Cdd FOREIGN KEY REFERENCES Candidates(CddID),
)

CREATE TABLE Resume(
	CddID varchar(10) CONSTRAINT FK_Cdd_Res FOREIGN KEY REFERENCES Candidates(CddID),
	JobID int CONSTRAINT FK_Job_Res FOREIGN KEY REFERENCES Jobs(ID),
	Objective nvarchar(MAX),
	UniversityName nvarchar(MAX),
	Major nvarchar(MAX),
	GPA nvarchar(MAX),
	UniversityStartDate nvarchar(MAX),
	UniversityEndDate nvarchar(MAX),
	CompanyName nvarchar(MAX),
	WorkPlace nvarchar(MAX),
	Detail nvarchar(MAX),
	CompanyStartDate nvarchar(MAX),
	CompanyEndDate nvarchar(MAX),
	CertificationName nvarchar(MAX),
	CertificationDate nvarchar(MAX),
	Status nvarchar(100) default N'Applying',
	CONSTRAINT PK_AD_J PRIMARY KEY (CddID, JobID)
)

CREATE TABLE Interviews (
	ID int IDENTITY PRIMARY KEY,
	EmpID varchar(10) foreign key references Employers(ID),
	CddID varchar(10) foreign key references Candidates(CddID),
	JobID int foreign key references Jobs(ID),
	InterviewTime datetime,
	Note nvarchar(max)
)
CREATE TABLE InterviewsByCV (
	ID int IDENTITY PRIMARY KEY,
	EmpID varchar(10) foreign key references Employers(ID),
	CddID varchar(10) foreign key references Candidates(CddID),
	JobName nvarchar(max),
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
	JobID int FOREIGN KEY REFERENCES Jobs(ID),
	CddID varchar(10) FOREIGN KEY REFERENCES Candidates(CddID)
)
-- Tạo bảng Applied Jobs
CREATE TABLE AppliedJobs(
	ID int IDENTITY primary key,
	TimeApplied date,
	JobID int FOREIGN KEY REFERENCES Jobs(ID),
	CddID varchar(10) FOREIGN KEY REFERENCES Candidates(CddID)
)
-- Tạo bảng CV yêu thích
CREATE TABLE FavoriteCV(
	TimeSaved date,
	CVID int FOREIGN KEY REFERENCES CV(ID),
	EmpID varchar(10) FOREIGN KEY REFERENCES Employers(ID),
	Primary Key (CVID, EmpID)
)

-- Dữ liệu cho bảng Candidates
INSERT INTO Candidates (CddID, CddName, Phone, Email, CddAddress, Hometown, Sex, Education)
VALUES 
('CDD001', N'Nguyễn Văn A', '1234567890', 'nguyenvana@gmail.com', '123 ABC Street', N'Hà Nội', N'Nam', 'Bachelor of Science in Computer Science'),
('CDD002', N'Trần Thị B', '0987654321', 'tranthib@gmail.com', '456 XYZ Street', N'Hồ Chí Minh City', N'Nữ', 'Master of Business Administration'),
('CDD003', N'Phạm Văn C', '0123456789', 'phamvanc@gmail.com', '789 DEF Street', N'Đà Nẵng', N'Nam', 'Bachelor of Arts in English');

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
INSERT INTO WorkHistory(CandidateID, CompanyName, StartDate, EndDate)
VALUES ('CDD001', 'Công ty ABC', '2018-09-01', '2020-02-10');

INSERT INTO WorkHistory(CandidateID, CompanyName, StartDate, EndDate)
VALUES
	   ('CDD001', N'Công ty TNHH một mình tao', '2020-03-01', '2021-02-10'),
	   ('CDD001', N'Công ty Tâm Bình', '2021-09-01', '2022-02-10'),
	   ('CDD001', N'Công ty Nhân Tâm', '2023-09-01', '2024-02-10');

INSERT INTO Interviews(EmpID,CddID,JobID,InterviewTime,Note)
VALUES('E001','CDD001',1,'2024-05-03',N'Tác phong chuẩn bị nghiêm túc và tinh thần tốt để phỏng vấn')
GO
CREATE FUNCTION func_CheckCandidate(
	@CddID varchar(10)
)
RETURNS BIT
AS
BEGIN 
	DECLARE @Exists BIT;

	SET @Exists = CASE 
                WHEN EXISTS (SELECT 1 FROM CV WHERE CVOwner = @CddID) 
					THEN 1 
					ELSE 0 
				END;
	RETURN @Exists;
END;

SELECT * FROM CV


SELECT *
FROM CV INNER JOIN Candidates C ON CV.CVOwner = C.CddID
WHERE CV.ID = 3

SELECT * FROM Jobs