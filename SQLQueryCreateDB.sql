﻿CREATE TABLE Candidates(
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
	ID varchar(10) PRIMARY KEY,
	Name nvarchar(100),
	Address nvarchar(100),
	Manager nvarchar(100),
	TaxCode varchar(100),
	BusinessLicense varchar(100)
)
CREATE TABLE Employers(
	ID varchar(10) CONSTRAINT PK_Emp PRIMARY KEY,
	Email varchar(100),
	Name nvarchar(100),
	Sex nvarchar(10),
	Phone varchar(12),
	Workplace nvarchar(250),
	CompanyID varchar(10) FOREIGN KEY REFERENCES Company(ID),
)
CREATE TABLE Jobs(
	ID varchar(10) CONSTRAINT PK_Job PRIMARY KEY,
	Name nvarchar(250),
	Salary int,
	JobDecription text,
	WorkDuration int,
	Experience nvarchar(250),
	ExpirationDate date,
	Benefit text,
	RequestCdd text,
	PostTime datetime,
	EmpID varchar(10) CONSTRAINT FK_EmpID FOREIGN KEY REFERENCES Employers(EmpID)
)
CREATE TABLE Education(
	UniversityName nvarchar(100) PRIMARY KEY,
	Major nvarchar(100),
	GPA nvarchar(100),
	StartDate datetime,
	EndDate datetime
)
CREATE TABLE WorkExperience(
	 CompanyName nvarchar(100) PRIMARY KEY,
	 WorkPlace nvarchar(100),
	 Detail text,
	 StartDate datetime,
	 EndDate datetime
)
CREATE TABLE Certification(
	Name nvarchar(100) PRIMARY KEY,
	CertificationDate datetime
)
CREATE TABLE Resume(
	CddID varchar(10) CONSTRAINT FK_Cdd FOREIGN KEY REFERENCES Candidates(CddID),
	JobID varchar(10) CONSTRAINT FK_Job FOREIGN KEY REFERENCES Jobs(JobID),
	Objective text,
	UniversityName nvarchar(100),
	Major nvarchar(100),
	GPA nvarchar(100),
	UniversityStartDate datetime,
	UniversityEndDate datetime,
	CompanyName nvarchar(100),
	WorkPlace nvarchar(100),
	Detail text,
	CompanyStartDate datetime,
	CompanyEndDate datetime,
	CertificationName nvarchar(100),
	CertificationDate datetime,
	CONSTRAINT PK_AD PRIMARY KEY (CddID, JobID)
)
-- Dữ liệu cho bảng Candidates
INSERT INTO Candidates (CddID, CddName, Phone, Email, CddAddress, Hometown, Sex, Education)
VALUES 
('CDD001', N'Nguyễn Văn A', '1234567890', 'nguyenvana@example.com', '123 ABC Street', N'Hà Nội', N'Nam', 'Bachelor of Science in Computer Science'),
('CDD002', N'Trần Thị B', '0987654321', 'tranthib@example.com', '456 XYZ Street', N'Hồ Chí Minh City', N'Nữ', 'Master of Business Administration'),
('CDD003', N'Phạm Văn C', '0123456789', 'phamvanc@example.com', '789 DEF Street', N'Đà Nẵng', N'Nam', 'Bachelor of Arts in English');

--
INSERT INTO Company (ID, Name, Address, Manager, TaxCode, BusinessLicense)
VALUES ('C001', 'Công ty ABC', '123 Đống Đa, Hà Nội', 'Miss.An', '123456789', 'BL-001');

-- Dữ liệu cho bảng Employeers
INSERT INTO Employers (ID, Email, Name, Sex, Phone, Workplace, CompanyID)
VALUES ('E001', '22110260@student.hcmute.edu.vn', 'Tuấn', 'Nam', '0705488458', 'Giám đốc', 'C001');

-- Dữ liệu cho bảng Jobs
-- Job 1
INSERT INTO Jobs (ID, Name, Salary, JobDecription, WorkDuration, Experience, ExpirationDate, Benefit, RequestCdd, PostTime, EmpID)
VALUES ('J001', 'Software Engineer', 80000, 'Develop and maintain software applications.', 40, '3+ years in software development', '2024-05-01', 'Health insurance, 401k', 'Bachelor degree in Computer Science', '2024-03-26', 'E001');
-- Job 2
INSERT INTO Jobs (ID, Name, Salary, JobDecription, WorkDuration, Experience, ExpirationDate, Benefit, RequestCdd, PostTime, EmpID)
VALUES ('J002', 'Marketing Specialist', 60000, 'Plan and execute marketing campaigns.', 40, '2+ years in marketing field', '2024-04-15', 'Paid time off, Flexible hours', 'Bachelors degree in Marketing or related field', '2024-03-26', 'E001');
-- Job 3
INSERT INTO Jobs (ID, Name, Salary, JobDecription, WorkDuration, Experience, ExpirationDate, Benefit, RequestCdd, PostTime, EmpID)
VALUES ('J003', 'HR Manager', 70000, 'Oversee all aspects of human resources functions.', 40, '5+ years in HR management', '2024-04-30', 'Health insurance, Retirement plan', 'Bachelors degree in Human Resources or related field', '2024-03-26', 'E001');

-- Dữ liệu cho bảng Resume
INSERT INTO Resume (CddID, JobID, Objective, UniversityName, Major, GPA, UniversityStartDate, UniversityEndDate, CompanyName, WorkPlace, Detail, CompanyStartDate, CompanyEndDate, CertificationName, CertificationDate)
VALUES 
('CDD001', 'J001', 'Seeking a Software Engineer position to apply my skills in software development and contribute to the success of innovative projects at ABC Corporation.', 'Tech University', 'Computer Science', '3.7', '2018-09-01', '2022-06-01', 'Software Solutions Inc.', 'Hanoi, Vietnam', 'Developed scalable web applications using Python and Django framework.', '2022-07-01', '2023-12-31', 'AWS Certified Developer - Associate', '2024-01-15');
INSERT INTO Resume (CddID, JobID, Objective, UniversityName, Major, GPA, UniversityStartDate, UniversityEndDate, CompanyName, WorkPlace, Detail, CompanyStartDate, CompanyEndDate, CertificationName, CertificationDate)
VALUES 
('CDD001', 'J002', 'Results-driven Marketing Specialist with a passion for creating impactful campaigns. Seeking to leverage my expertise in digital marketing at ABC Corporation.', 'Marketing Academy', 'Marketing Management', '3.8', '2017-08-01', '2021-05-01', 'Digital Marketing Agency', 'Cityville, USA', 'Led successful social media campaigns resulting in a 20% increase in user engagement.', '2021-06-15', '2023-03-31', 'HubSpot Content Marketing Certification', '2023-06-20');
INSERT INTO Resume (CddID, JobID, Objective, UniversityName, Major, GPA, UniversityStartDate, UniversityEndDate, CompanyName, WorkPlace, Detail, CompanyStartDate, CompanyEndDate, CertificationName, CertificationDate)
VALUES 
('CDD001', 'J003', 'Experienced HR professional with a proven track record of managing diverse teams. Seeking a challenging role as an HR Manager at ABC Corporation.', 'University of HR Management', 'Human Resources', '3.9', '2015-09-01', '2019-06-01', 'HR Solutions Inc.', 'Hanoi, Vietnam', 'Managed recruitment processes and employee relations.', '2019-07-15', '2022-02-28', 'PHR Certification', '2023-05-10');
