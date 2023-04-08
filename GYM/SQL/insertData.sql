USE Gym

---------------Inserting values into tables----------------
insert into People
values
('11112222333311', 'Ahmed Tarek', 'Ismail Al Habarok', 'Male', '01202708815', '2002-01-18'),
('11112222333322', 'Osama Youssef', 'Mathaf Al Manial', 'Male', '01004855118', '2002-01-18'),
('11112222333333', 'Zeyad Mohammed', 'Gamaa Street', 'Male', '01017516450', '2002-01-18'),
('11112222333344', 'Mahmoud Hassan', 'Mathaf Al Manial tany', 'Male', '01141993539', '2002-01-18'),
('11112222333355', 'Omar Madbouly', 'Hadaye Al Ahram', 'Male', '01289667510', '2002-01-18'),
('11112222333366', 'Omar Ibrahim', 'Haram Street', 'Male', '01068703112', '2002-01-18'),
('11112222333377', 'Omar Desoky', 'Beverly', 'Male', '01019763052', '2002-01-18'),
('11112222333388', 'Mostafa Metwaly', 'Mohi Al Din', 'Male', '01111326303', '2002-01-18'),
('11112222333399', 'Eng Ali', 'Cairo University', 'Male', '01234567891', '2002-01-18'),
('11112222334400', 'Mostafa Mohamed', 'Kit-Kat', 'Male', '01027456728', '2000-07-08'),
('11112222334411', 'Marwan Osama', 'Ibrahim Al Basi', 'Male', '01149008602', '2002-04-02'),
('11112222334412', 'Ahmed Fathy', 'Darb el barabra', 'Male', '01149008688', '1998-03-02'),
('11112222334414', 'Mostafa Mohamed', 'El Sheikh Zayed', 'Male', '01149008088', '1999-04-01'),
('11112222334415', 'Manar Ayman', 'Mohanessein', 'Female', '01250008088', '2001-04-25'),
('11112222334416', 'Malak Gobara', 'Imbaba', 'Female', '01255004040', '2003-05-15')

insert into Managers
values
('11112222333311', 'ahmedtarekabd2002@gmail.com', '+bxn3XW72zLwDS8mQigQdA=='),
('11112222333322', 'osama.elhattab@yahoo.com', 'Ot7nOdfMTwE7TubTCV0SFg=='),
('11112222333333', 'zyad.mohamed@gmail.com', 'cX1IV9JGJEiczfT/wKOf0g=='),
('11112222333344', 'mahmoud.hassan@gmail.com', 'OhhvSNxSn6vh+WaybjKiKQ==')

insert into Programs
values
(1, 'zomba', 'Fun, Fun and Fun!', 2500, 4),
(2, 'tabata', 'Fast Results!', 3000, 6),
(3, 'HIIT', 'Cardiovascular', 4500, 8)

insert into Memberships
values
(1, '1 month', 1000, 1),
(2, '3 month', 2000, 3),
(3, '6 month', 3500, 6),
(4, '1 year', 4500, 12)

insert into Employees
values
('11112222333355', '11112222333311'),
('11112222333366', '11112222333322'),
('11112222333377', '11112222333322'),
('11112222333388', '11112222333333')

insert into Trainers
values
('11112222333355'),
('11112222333366'),
('11112222334414'),
('11112222334415')

insert into trainers_certificates
values
('11112222333355', 'The American Council of Exercise'),
('11112222333355', 'The American College of Sports Medicine'),
('11112222333366', 'The National Academy of Sports Medicine')

insert into Receptionists
values
('11112222333377', 'omar.desoky@gmail.com', 'RAv0DyUqCLwVnTMaZqA0Ew=='),
('11112222333388', 'mostafa.metwaly@gmail.com', 'g5/7lN6RNQGUdwgKRV1oAg==')

insert into receptionists_skills
values
('11112222333377', 'Technical Writting'),
('11112222333377', 'Communication skills'),
('11112222333388', 'Soft skills')

insert into Trainees
values
('11112222333399', '2022-01-01', '2023-01-01', 1, 4, '11112222333355'),
('11112222334400', '2022-01-18', '2022-04-18', 2, 2, NULL),
('11112222334411', '2022-01-9', '2023-01-09', NULL, 4, '11112222333366'),
('11112222334412', '2022-05-10', '2022-06-10', 2, 1, '11112222334414'),
('11112222334416', '2022-08-15', '2023-02-15', NULL, 3, '11112222334415')

insert into Devices
values
(1, 'Chest Press', 'Cybex', 'Chest', '2022-01-01'),
(2, 'Lat Pulldown', 'Cybex', 'Back', '2022-01-01'),
(3, 'Shoulder Press', 'Cybex', 'Shoulder', '2022-01-01'),
(4, 'Biceps Curl', 'Cybex', 'Biceps', '2022-01-01'),
(5, 'Triceps Press', 'Cybex', 'Triceps', '2022-01-01'),
(6, 'Leg Press', 'Cybex', 'Leg', '2022-01-01'),
(7, 'Leg extension', 'Cybex', 'Leg', '2022-01-01'),
(8, 'Leg Curl', 'Cybex', 'Leg', '2022-01-01')

insert into Lockers
values
(1, 50, '11112222333399'),
(2, 50, '11112222334400'),
(3, 50, '11112222334411'),
(4, 50, NULL),
(5, 50, NULL),
(6, 50, NULL),
(7, 50, NULL),
(8, 50, NULL),
(9, 50, NULL),
(10,50, NULL)


insert into Salary
values
('11112222333355', '2022-02-01', 3000, 2, 10, 5),
('11112222333366', '2022-02-01', 3000, 2, 0, 0),
('11112222333377', '2022-02-01', 4000, 4, 10, 0),
('11112222333388', '2022-02-01', 4000, 4, 0, 5)

--	employee_ssn		VARCHAR(14),
--	attendance_date		DATE NOT NULL,
--	attendance_type		VARCHAR(50) NOT NULL,  -- Attended, Absent, Early, Late
insert into Attendance
values
('11112222333355', '2022-01-01', 'Attended'),
('11112222333366', '2022-01-01', 'Attended'),
('11112222333377', '2022-01-01', 'Attended'),
('11112222333388', '2022-01-01', 'Attended')

--	employee_ssn		VARCHAR(14),
--	start_date			DATE,
--	end_date			DATE,
--	request_status		VARCHAR(50) NOT NULL, -- Accepted, Rejected, Pending
insert into Holidays
values
('11112222333355', '2022-02-01', '2022-02-05', 'Pending'),
('11112222333366', '2022-03-01', '2022-03-02', 'Accepted'),
('11112222333377', '2022-04-01', '2022-04-10', 'Rejected'),
('11112222333388', '2022-04-01', '2022-04-10', 'Rejected')

insert into Invitations
values
('11112222333399', 'Ahmed Helmy', '01120519519'),
('11112222334400', 'Omar Zeiny', '01202228483'),
('11112222334400', 'Khaled Gad', '01091234918'),
('11112222334411', 'Omar Asfour', '01091638318')


	--id				INT,
	--person_ssn		VARCHAR(14),
	--t_date			DATE NOT NULL,
	--amount			INT NOT NULL,
	--type			VARCHAR(50) NOT NULL,	-- Withdraw/deposit
	--description		VARCHAR(50) NOT NULL,	-- Salary, Subscription, Locker, Managers withdraw
insert into Transactions
values
('11112222333311', '2022-01-01', 10000, 'deposit', 'Manager Capital'),
('11112222333355', '2022-02-01', 3000, 'withdraw', 'Salary'),
('11112222333366', '2022-02-01', 3000, 'withdraw', 'Salary'),
('11112222333377', '2022-02-01', 4000, 'withdraw', 'Salary'),
('11112222333388', '2022-02-01', 4000, 'withdraw', 'Salary')


insert into specialize_in
values
(1, '11112222333355'),
(2, '11112222333355'),
(3, '11112222333355'),
(3, '11112222333366'),
(4, '11112222333366'),
(5, '11112222333366')
