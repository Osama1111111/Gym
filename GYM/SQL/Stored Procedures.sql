use Gym
--CREATE PROCEDURE viewAllHolidaysProc
--AS
--BEGIN
--SELECT* FROM Holidays
--END
--GO

--GO
--CREATE PROCEDURE AttendedProc @ssn Varchar(50), @type varchar(50), @date date
--AS
--BEGIN
--INSERT INTO Attendance VALUES(@ssn, @date, @type)
--END
--GO

--GO
--CREATE PROCEDURE AssignTrainerProc @ssn Varchar(50), @tssn varchar(50)
--AS
--BEGIN
--UPDATE Trainees SET trainer_ssn = @tssn WHERE ssn = @ssn;
--END
--GO

--GO
--CREATE PROCEDURE ViewProgramProc @prog Varchar(50)
--AS
--BEGIN
--SELECT description FROM Programs WHERE name = @prog;
--END
--GO

--GO
--CREATE PROCEDURE UpdateProgramProc @ssn Varchar(50), @pid int
--AS
--BEGIN
--UPDATE Trainees SET program_id = @pid WHERE ssn = @ssn;
--END
--GO

--GO
--CREATE PROCEDURE AssignLockerProc @ssn Varchar(50), @locker int
--AS
--BEGIN
--UPDATE Lockers SET trainee_ssn = @locker WHERE number = @locker;
--END
--GO

--GO
--CREATE PROCEDURE SearchTrainerProc @keyword Varchar(50)
--AS
--BEGIN
--SELECT Trainers.[ssn], person_name FROM People JOIN Trainers ON Trainers.[ssn]=People.[ssn] WHERE person_name LIKE @keyword;
--END
--GO

--GO
--CREATE PROCEDURE SelectAllLockersProc 
--AS
--BEGIN
--SELECT * FROM Lockers;
--END
--GO

--GO
--CREATE PROCEDURE RequestHolidayProc @ssn Varchar(50), @sdate date, @edate date
--AS
--BEGIN
--INSERT INTO Holidays Values(@ssn, @sdate,@edate,'Pending');
--END
--GO

--GO
--CREATE PROCEDURE CancelMembershipProc @id int
--AS
--BEGIN
--DELETE FROM Memberships WHERE ID=@id;
--END
--GO
