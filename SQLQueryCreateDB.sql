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
	EprID varchar(10) CONSTRAINT PK_Epr PRIMARY KEY,
	EprName nvarchar(100),
	Phone varchar(12),
	Workplace nvarchar(250),
	WorkLocation nvarchar(250),
	District nvarchar(100)
)

CREATE TABLE Jobs(
	JobID varchar(10) CONSTRAINT PK_Job PRIMARY KEY,
	JobName nvarchar(250),
	CompanyName nvarchar(250),
	WorkAddress nvarchar(250),
	JobDecription text,
	WorkDuration int,
	Experience nvarchar(250),
	ExpirationDate date,
	Benefit text,
	RequestCdd text,
	EprID varchar(10) CONSTRAINT FK_EprID FOREIGN KEY REFERENCES Employeers(EprID)
)

CREATE TABLE ApplicationDetails(
	CddID varchar(10) CONSTRAINT FK_Cdd FOREIGN KEY REFERENCES Candidates(CddID),
	JobID varchar(10) CONSTRAINT FK_Job FOREIGN KEY REFERENCES Jobs(JobID),
	DateApply date,
	StateApp nvarchar(100)
	CONSTRAINT PK_AD PRIMARY KEY (CddID, JobID)
)
ALTER TABLE Jobs
ADD Salary float(10)
ALTER TABLE Jobs
DROP CONSTRAINT FK_EprID
ALTER TABLE Jobs
ADD CONSTRAINT FK_EprID FOREIGN KEY (EprID) REFERENCES Employeers(EprID)
ALTER TABLE ApplicationDetails
add CONSTRAINT FK_Job  FOREIGN KEY (JobID)REFERENCES Jobs(JobID)

TRUNCATE TABLE Candidates
TRUNCATE TABLE ApplicationDetails
-- Dữ liệu cho bảng Candidates
INSERT INTO Candidates (CddID, CddName, Phone, Email, CddAddress, Hometown, Sex, Education)
VALUES 
('CDD001', N'Nguyễn Văn A', '1234567890', 'nguyenvana@example.com', '123 ABC Street', N'Hà Nội', N'Nam', 'Bachelor of Science in Computer Science'),
('CDD002', N'Trần Thị B', '0987654321', 'tranthib@example.com', '456 XYZ Street', N'Hồ Chí Minh City', N'Nữ', 'Master of Business Administration'),
('CDD003', N'Phạm Văn C', '0123456789', 'phamvanc@example.com', '789 DEF Street', N'Đà Nẵng', N'Nam', 'Bachelor of Arts in English');

-- Dữ liệu cho bảng Employeers
TRUNCATE TABLE Employeers
INSERT INTO Employeers (EprID, EprName, Phone, Workplace, WorkLocation, District)
VALUES 
('EPR001', 'Công ty ABC', '9876543210', '123 PQR Road', N'Hà Nội', N'Ba Đình'),
('EPR002', 'Công ty XYZ', '0123456789', '456 STU Road', N'Hồ Chí Minh City', N'Quận 1'),
('EPR003', 'Công ty DEF', '0901234567', '789 MNO Road', N'Đà Nẵng', N'Hải Châu');

-- Dữ liệu cho bảng Jobs
TRUNCATE TABLE Jobs
INSERT INTO Jobs (JobID, JobName, CompanyName, WorkAddress, JobDecription, WorkDuration, Experience, ExpirationDate, Salary, Benefit, RequestCdd, EprID)
VALUES 
('JOB001', 'Software Engineer', 'Công ty ABC', '123 PQR Road, Hanoi', 'Develop and maintain software applications.', 12, '3+ years', '2024-04-30', 2000.5, 'Health insurance, bonus', 'Bachelor of Science in Computer Science, experience with Python and JavaScript preferred', 'EPR001'),
('JOB002', 'Marketing Manager', 'Công ty XYZ', '456 STU Road, Ho Chi Minh City', 'Plan and execute marketing campaigns.', 24, '5+ years', '2024-05-15', 3000.9, 'Travel allowance, performance bonus', 'Bachelor’s degree in Marketing or related field, strong leadership skills', 'EPR002'),
('JOB003', 'English Teacher', 'Công ty DEF', '789 MNO Road, Da Nang', 'Teach English language courses.', 12, '2+ years', '2024-06-01', 1500.5, 'Professional development opportunities', 'Bachelor of Arts in English, TEFL certification preferred', 'EPR003');

-- Dữ liệu cho bảng ApplicationDetails
INSERT INTO ApplicationDetails (CddID, JobID, DateApply, StateApp)
VALUES 
('CDD001', 'JOB001', '2024-03-10', 'Pending'),
('CDD001', 'JOB002', '2024-03-11', 'Rejected'),
('CDD002', 'JOB002', '2024-03-12', 'Pending'),
('CDD003', 'JOB003', '2024-03-13', 'Accepted'),
('CDD003', 'JOB001', '2024-03-14', 'Pending');

SELECT * FROM Candidates
SELECT * FROM Employeers
SELECT * FROM Jobs
SELECT * FROM ApplicationDetails