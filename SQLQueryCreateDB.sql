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
CREATE TABLE Employeers(
	EmpID varchar(10) CONSTRAINT PK_Epr PRIMARY KEY,
	EmpEmail varchar(100),
	EmpName nvarchar(100),
	Sex nvarchar(10),
	Phone varchar(12),
	Workplace nvarchar(250),
	Company nvarchar(250),
	CompanyAddress nvarchar(250)
)
CREATE TABLE Jobs(
	JobID varchar(10) CONSTRAINT PK_Job PRIMARY KEY,
	JobName nvarchar(250),
	Salary int,
	CompanyName nvarchar(250),
	WorkAddress nvarchar(250),
	JobDecription text,
	WorkDuration int,
	Experience nvarchar(250),
	ExpirationDate date,
	Benefit text,
	RequestCdd text,
	EmpID varchar(10) CONSTRAINT FK_EmpID FOREIGN KEY REFERENCES Employeers(EmpID)
)
CREATE TABLE ApplicationDetails(
	CddID varchar(10) CONSTRAINT FK_Cdd FOREIGN KEY REFERENCES Candidates(CddID),
	JobID varchar(10) CONSTRAINT FK_Job FOREIGN KEY REFERENCES Jobs(JobID),
	DateApply date,
	StateApp nvarchar(100)
	CONSTRAINT PK_AD PRIMARY KEY (CddID, JobID)
)
-- Dữ liệu cho bảng Candidates
INSERT INTO Candidates (CddID, CddName, Phone, Email, CddAddress, Hometown, Sex, Education)
VALUES 
('CDD001', N'Nguyễn Văn A', '1234567890', 'nguyenvana@example.com', '123 ABC Street', N'Hà Nội', N'Nam', 'Bachelor of Science in Computer Science'),
('CDD002', N'Trần Thị B', '0987654321', 'tranthib@example.com', '456 XYZ Street', N'Hồ Chí Minh City', N'Nữ', 'Master of Business Administration'),
('CDD003', N'Phạm Văn C', '0123456789', 'phamvanc@example.com', '789 DEF Street', N'Đà Nẵng', N'Nam', 'Bachelor of Arts in English');
-- Dữ liệu cho bảng Employeers
INSERT INTO Employeers (EmpID, EmpEmail, EmpName, Sex, Phone, Workplace, Company, CompanyAddress)
VALUES
('EMP001', 'hongtuan@gmail.com', N'Hồng Tuấn', N'Nam', '0123456789', N'Giám đốc', N'Công ty ABC', N'123 PQR Road, Ba Đình, Hà Nội')
-- Dữ liệu cho bảng Jobs
INSERT INTO Jobs (JobID, JobName, CompanyName, WorkAddress, JobDecription, WorkDuration, Experience, ExpirationDate, Salary, Benefit, RequestCdd, EmpID)
VALUES 
('JOB001', 'Software Engineer', 'Công ty ABC', N'Hà Nội', 'Develop and maintain software applications.', 8, '3+ years', '2024-04-30', 20000000, 'Health insurance, bonus', 'Bachelor of Science in Computer Science, experience with Python and JavaScript preferred', 'EMP001'),
('JOB002', 'Marketing Manager', 'Công ty XYZ', N'Hồ Chí Minh City', 'Plan and execute marketing campaigns.', 6, '5+ years', '2024-05-15', 30000000, 'Travel allowance, performance bonus', 'Bachelor’s degree in Marketing or related field, strong leadership skills', 'EMP001'),
('JOB003', 'English Teacher', 'Công ty DEF', N'Đà Nẵng', 'Teach English language courses.', 10, '2+ years', '2024-06-01', 15000000, 'Professional development opportunities', 'Bachelor of Arts in English, TEFL certification preferred', 'EMP001');
-- Dữ liệu cho bảng ApplicationDetails
INSERT INTO ApplicationDetails (CddID, JobID, DateApply, StateApp)
VALUES 
('CDD001', 'JOB001', '2024-03-10', 'Pending'),
('CDD001', 'JOB002', '2024-03-11', 'Rejected'),
('CDD002', 'JOB002', '2024-03-12', 'Pending'),
('CDD003', 'JOB003', '2024-03-13', 'Accepted'),
('CDD003', 'JOB001', '2024-03-14', 'Pending');
SELECT * FROM Jobs
SELECT * FROM Candidates
SELECT * FROM Employeers
SELECT * FROM ApplicationDetails