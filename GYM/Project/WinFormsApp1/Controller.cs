using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using System.Reflection;
using WinFormsApp1;
using System.Xml.Linq;
using Microsoft.VisualBasic;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Runtime.Intrinsics.X86;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using DBapplication;
using System.Security.Cryptography;
using Microsoft.VisualBasic.Devices;
using static System.Windows.Forms.AxHost;

namespace WinFormsApp1
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }


        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }


        public DataTable mostPopularMembership(string d_name)
        {
            string query = "SELECT * FROM Devices WHERE device_name like '%" + d_name + "%';";
            return dbMan.ExecuteReader(query);
        }

        public int viewcountOfMales()
        {
            string query = "SELECT COUNT (gender) FROM people WHERE gender = 'Male'; ";
            return Convert.ToInt16(dbMan.ExecuteScalar(query));
        }

        public int viewcountOfFemales()
        {
            string query = "SELECT COUNT (gender) FROM people WHERE gender = 'Female'; ";
            return Convert.ToInt16(dbMan.ExecuteScalar(query));
        }

        public int calcWithdraw()
        {
            string query = "SELECT SUM(amount) FROM Transactions WHERE type = 'Withdraw';";
            return Convert.ToInt16(dbMan.ExecuteScalar(query));
        }

        public int calcDeposit()
        {
            string query = "SELECT SUM(amount) FROM Transactions WHERE type = 'Deposit';";
            return Convert.ToInt16(dbMan.ExecuteScalar(query));
        }

        //--------------------------------------------------- Devices -----------------------------------------------------//
        public int addDevices(int id, string d_name, string m_name, string muscle_g, string d_of_p)
        {
            string query = "INSERT INTO Devices VALUES(" + id + ",'" + d_name + "','" + m_name + "','" + muscle_g + "','" + d_of_p + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int addSpecializedInTrainers(int device_id, string trainer_ssn)
        {
            string query = "INSERT INTO specialize_in VALUES(" + device_id + ",'" + trainer_ssn + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int updateDevices(int id, string d_name, string m_name, string muscle_g, string d_of_p)
        {
            string query = "UPDATE Devices SET device_name = '" + d_name + "', manufacturer_name = '" + m_name + "', muscle_group = '" + muscle_g + "', date_of_purchase = '" + d_of_p + "' WHERE id = " + id + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable searchForDevices(string d_name)
        {
            string query = "SELECT * FROM Devices WHERE device_name like '%" + d_name + "%';";
            return dbMan.ExecuteReader(query);
        }

        public int deleteDevices(string d_name)
        {
            string query = "DELETE FROM Devices WHERE device_name='" + d_name + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int deleteAllSpecializedInTrainers(int id)
        {
            string query = "DELETE FROM specialize_in WHERE device_id = " + id + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        //To return the names in the comboBox
        public DataTable SelectDevicesNamesAndIds()
        {
            string query = "SELECT device_name,id FROM Devices;";
            return dbMan.ExecuteReader(query);
        }

        //--------------------------------------------------- Salaries -----------------------------------------------------//
        public int addSalary(string employee_ssn, string salary_date, int gross_salary, int taxes_percentage, int bonus, int penality)
        {
            string query = "INSERT INTO Salary VALUES('" + employee_ssn + "','" + salary_date + "' ," + gross_salary + " ," + taxes_percentage + " ," + bonus + " , " + penality + ");";
            return dbMan.ExecuteNonQuery(query);
        }

        public int updateSalary(string employee_ssn, string salary_date, int gross_salary, int taxes_percentage, int bonus, int penality)
        {
            string query = "UPDATE Salary SET gross_salary = " + gross_salary + ", taxes_percentage = " + taxes_percentage + ", bonus = " + bonus + ", penality = " + penality + " WHERE employee_ssn = '" + employee_ssn + "' AND salary_date = '" + salary_date + "';";
            return dbMan.ExecuteNonQuery(query);
        }


        public DataTable searchForAnEmployeeSalaryInCertainMonth(string employee_ssn, string salary_date)
        {
            string query = "SELECT* FROM Salary WHERE employee_ssn='" + employee_ssn + "' AND salary_date = '" + salary_date + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable searchForAnEmployeeSalaries(string employee_ssn)
        {
            string query = "SELECT* FROM Salary WHERE employee_ssn='" + employee_ssn + "';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable searchForAllEmployeesSalariesInCertainMonth(string salary_date)
        {
            string query = "SELECT* FROM Salary WHERE salary_date = '" + salary_date + "';";
            return dbMan.ExecuteReader(query);
        }


        //--------------------------------------------------- Trainers -----------------------------------------------------//

        public DataTable getAllTrainers()
        {
            string query = "SELECT * FROM People P, Employees E, Trainers T WHERE P.ssn= T.ssn AND E.ssn= T.ssn;";
            return dbMan.ExecuteReader(query);
        }

        public int addTrainers(string ssn, string person_name, string person_address, string gender, string phone_number, string birth_date, string manager_ssn)
        {
            string query = "BEGIN TRANSACTION;" +
                "INSERT INTO People VALUES('" + ssn + "','" + person_name + "' ,'" + person_address + "' ,'" + gender + "' ,'" + phone_number + "' ,'" + birth_date + "'); " +
                "INSERT INTO Employees VALUES('" + ssn + "','" + manager_ssn + "'); " +
                "INSERT INTO Trainers VALUES('" + ssn + "'); " +
                "COMMIT;";
            return dbMan.ExecuteNonQuery(query);
        }

        public int addCertificates(string ssn, string certificate)
        {
            string query = "INSERT INTO trainers_certificates VALUES('" + ssn + "','" + certificate + "'); ";
            return dbMan.ExecuteNonQuery(query);
        }

        public int updateTrainers(string ssn, string person_name, string person_address, string gender, string phone_number, string birth_date, string manager_ssn)
        {
            string query = "BEGIN TRANSACTION;" +
                "UPDATE People SET People.person_name = '" + person_name + "' , People.person_address = '" + person_address + "', People.gender = '" + gender + "', People.phone_number = '" + phone_number + "', People.birth_date = '" + birth_date + "' FROM People P, Employees E, Trainers T WHERE T.ssn= '" + ssn + "' AND P.ssn= T.ssn AND E.ssn= T.ssn;" +
                "UPDATE Employees SET Employees.manager_ssn = '" + manager_ssn + "' FROM People P, Employees E, Trainers T WHERE T.ssn= '" + ssn + "' AND P.ssn= T.ssn AND E.ssn= T.ssn;" +
                "COMMIT;";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable searchForTrainers(string p_name)
        {
            string query = "SELECT * FROM People P, Employees E, Trainers T WHERE p.person_name like '%" + p_name + "%'AND P.ssn= T.ssn AND E.ssn= T.ssn;";
            return dbMan.ExecuteReader(query);
        }

        public int deleteTrainers(string ssn)
        {
            string query = "BEGIN TRANSACTION;" +
                "DELETE FROM Trainers WHERE ssn='" + ssn + "';" +
                "DELETE FROM Employees WHERE ssn='" + ssn + "';" +
                "DELETE FROM People WHERE ssn='" + ssn + "';" +
                "COMMIT;";
            return dbMan.ExecuteNonQuery(query);
        }

        public int deleteAllCertificatesForTrainer(string SSN)
        {
            string query = "DELETE FROM trainers_certificates WHERE ssn = '" + SSN + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        //--------------------------------------------------- Receptionists -----------------------------------------------------//

        public DataTable loginReceptionist(string email, string password)
        {
            string query = "SELECT * FROM Receptionists R WHERE email = '" + email + "' AND password='" + password + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable getAllReceptionists()
        {
            string query = "SELECT * FROM People P, Employees E, Receptionists R WHERE P.ssn= R.ssn AND E.ssn= R.ssn;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable getReceptionistsEmailAndPassword(string ssn)
        {
            string query = "SELECT email, password FROM Receptionists WHERE ssn = '" + ssn + "';";
            return dbMan.ExecuteReader(query);
        }

        public int updateReceptionistPassword(string ssn, string password)
        {
            string query = "UPDATE Receptionists SET Receptionists.password = '" + password + "' FROM Receptionists R  WHERE R.ssn= '" + ssn + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int addReceptionists(string ssn, string person_name, string person_address, string gender, string phone_number, string birth_date, string manager_ssn, string email, string password)
        {
            string query = "BEGIN TRANSACTION;" +
                "INSERT INTO People VALUES('" + ssn + "','" + person_name + "' ,'" + person_address + "' ,'" + gender + "' ,'" + phone_number + "' ,'" + birth_date + "');" +
                "INSERT INTO Employees VALUES('" + ssn + "','" + manager_ssn + "');" +
                "INSERT INTO Receptionists VALUES('" + ssn + "','" + email + "' ,'" + password + "');" +
                "COMMIT;";
            return dbMan.ExecuteNonQuery(query);
        }

        public int addSkills(string ssn, string skill)
        {
            string query = "INSERT INTO receptionists_skills VALUES('" + ssn + "','" + skill + "'); ";
            return dbMan.ExecuteNonQuery(query);
        }

        public int updateReceptionists(string ssn, string person_name, string person_address, string gender, string phone_number, string birth_date, string manager_ssn, string email, string password)
        {
            string query = "BEGIN TRANSACTION; " +
                "UPDATE Receptionists SET Receptionists.email = '" + email + "', Receptionists.password = '" + password + "' FROM People P, Employees E, Receptionists R WHERE R.ssn= '" + ssn + "';" +
                "UPDATE Employees SET Employees.manager_ssn = '" + manager_ssn + "' FROM Employees E WHERE E.ssn= '" + ssn + "';" +
                "UPDATE People SET People.person_name = '" + person_name + "' , People.person_address = '" + person_address + "', People.gender = '" + gender + "', People.phone_number = '" + phone_number + "', People.birth_date = '" + birth_date + "' FROM People P WHERE P.ssn= '" + ssn + "';" +
                "COMMIT;";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable searchForReceptionistsByName(string p_name)
        {
            string query = "SELECT * FROM People P, Employees E, Receptionists R WHERE p.person_name LIKE '%" + p_name + "%' AND P.ssn= R.ssn AND E.ssn= R.ssn;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable searchForReceptionists(string ssn)
        {
            string query = "SELECT * FROM People P, Receptionists R WHERE P.ssn = '" + ssn + "'AND P.ssn=R.ssn;";
            return dbMan.ExecuteReader(query);
        }

        public int deleteReceptionists(string ssn)
        {
            string query = "BEGIN TRANSACTION;" +
                "DELETE FROM Receptionists WHERE ssn='" + ssn + "';" +
                "DELETE FROM Employees WHERE ssn='" + ssn + "';" +
                "DELETE FROM People WHERE ssn='" + ssn + "';" +
                "COMMIT;";
            return dbMan.ExecuteNonQuery(query);
        }

        public int deleteAllSkillsForReceptionist(string SSN)
        {
            string query = "DELETE FROM receptionists_skills WHERE ssn = '" + SSN + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        //--------------------------------------------------- Managers -----------------------------------------------------//

        public DataTable getAllManagers()
        {
            string query = "SELECT * FROM People P,Managers M WHERE P.ssn= M.ssn;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable loginManager(string email, string password)
        {
            string query = "SELECT * FROM Managers WHERE email = '" + email + "' AND password='" + password + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable getManagerEmailAndPassword(string ssn)
        {
            string query = "SELECT email, password FROM Managers WHERE ssn = '" + ssn + "';";
            return dbMan.ExecuteReader(query);
        }

        public int updateManagerPassword(string ssn, string password)
        {
            string query = "UPDATE Managers SET Managers.password = '" + password + "' FROM Managers M  WHERE M.ssn= '" + ssn + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int addManagers(string ssn, string person_name, string person_address, string gender, string phone_number, string birth_date, string email, string password)
        {
            string query = "BEGIN TRANSACTION;" +
                "INSERT INTO People VALUES('" + ssn + "','" + person_name + "' ,'" + person_address + "' ,'" + gender + "' ,'" + phone_number + "' ,'" + birth_date + "');" +
                "INSERT INTO Managers VALUES('" + ssn + "','" + email + "' ,'" + password + "');" +
                "COMMIT;";
            return dbMan.ExecuteNonQuery(query);
        }

        public int updateManagers(string ssn, string person_name, string person_address, string gender, string phone_number, string birth_date, string email, string password)
        {
            string query = "BEGIN TRANSACTION;" +
                "UPDATE People SET People.person_name = '" + person_name + "' , People.person_address = '" + person_address + "', People.gender = '" + gender + "', People.phone_number = '" + phone_number + "', People.birth_date = '" + birth_date + "' FROM People P, Managers M WHERE M.ssn= '" + ssn + "' AND P.ssn= M.ssn;" +
                "UPDATE Managers SET Managers.email = '" + email + "', Managers.password = '" + password + "' FROM People P, Managers M  WHERE M.ssn= '" + ssn + "' AND P.ssn= M.ssn;" +
                "COMMIT;";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable searchForManagers(string ssn)
        {
            string query = "SELECT * FROM People P, Managers M WHERE p.ssn = '" + ssn + "'AND P.ssn=M.ssn;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable searchForManagersWithName(string p_name)
        {
            string query = "SELECT * FROM People P, Managers M WHERE p.person_name LIKE '%" + p_name + "%' AND P.ssn=M.ssn;";
            return dbMan.ExecuteReader(query);
        }

        public int deleteManagers(string ssn)
        {
            string query = "BEGIN TRANSACTION;" +
                "DELETE FROM Managers WHERE ssn='" + ssn + "';" +
                "DELETE FROM People WHERE ssn='" + ssn + "';" +
                "COMMIT;";
            return dbMan.ExecuteNonQuery(query);
        }

        //--------------------------------------------------- Attendance -----------------------------------------------------//
        public DataTable viewAttendance(string ssn, string attendance_date)
        {
            string query = "SELECT * FROM Attendance WHERE employee_ssn='" + ssn + "' AND attendance_date='" + attendance_date + "';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable viewAttendanceByName(string name, string attendance_date)
        {
            string query = "SELECT P.ssn, person_name, attendance_type, attendance_date FROM Attendance A, People P WHERE P.person_name LIKE '%" + name + "%' AND attendance_date='" + attendance_date + "' AND P.ssn=A.employee_ssn;";
            return dbMan.ExecuteReader(query);
        }

        //--------------------------------------------------- Holidays -----------------------------------------------------//
        public DataTable viewPendingHolidays()
        {
            string query = "SELECT employee_ssn, person_name, start_date, end_date, request_status FROM Holidays H, People P WHERE P.ssn=H.employee_ssn AND request_status LIKE 'pending';";
            return dbMan.ExecuteReader(query);
        }


        //      PROC
        public DataTable viewAllHolidays()
        {
            //string query = "SELECT* FROM Holidays;";
            //return dbMan.ExecuteReader(query);

            string StoredProcedure1 = StoredProcedures.viewAllHolidays;
            return dbMan.ExecuteReader(StoredProcedure1, null);

        }

        public int acceptHoliday(string ssn, string startDate, string endDate)
        {
            string query = "BEGIN TRANSACTION;" +
                "UPDATE Holidays SET request_status= 'Accepted' WHERE employee_ssn='" + ssn + "' AND start_date='" + startDate + "' AND end_date='" + endDate + "';" +
                "COMMIT;";
            return dbMan.ExecuteNonQuery(query);
        }

        public int rejectHoliday(string ssn, string startDate, string endDate)
        {
            string query = "BEGIN TRANSACTION;" +
                "UPDATE Holidays SET request_status= 'Rejected' WHERE employee_ssn='" + ssn + "' AND start_date='" + startDate + "' AND end_date='" + endDate + "';" +
                "COMMIT;";
            return dbMan.ExecuteNonQuery(query);
        }

        //--------------------------------------------------- Transactions -----------------------------------------------------//
        public int addTransaction(string person_ssn, string t_date, int amount, string type, string describtion)
        {
            string query = "insert into Transactions values ('" + person_ssn + "' ,'" + t_date + "' ," + amount + " ,'" + type + "' ,'" + describtion + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        //--------------------------------------------------- Statistics -----------------------------------------------------//


        public int AddMembership(int id, string name, int price, int duration)
        {
            string query = "INSERT INTO Memberships Values(" + id + ",'" + name + "'," + price + "," + duration + ");";
            return dbMan.ExecuteNonQuery(query);
        }
        //--------------------------------------------------------------------------//
        public int UpdateMembership(int id, string name, int price, int duration)
        {
            string query = "UPDATE Memberships SET Name='" + name + "', Price=" + price + ", Duration=" + duration + " WHERE ID=" + id + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        //--------------------------------------------------------------------------//
        public int CancelMembership(int id)
        {
            string query = "DELETE FROM Memberships WHERE ID=" + id + ";";
            return dbMan.ExecuteNonQuery(query);

            string StoredProcedure1 = StoredProcedures.CancelMembership;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            return dbMan.ExecuteNonQuery(StoredProcedure1, Parameters);

        }
        //--------------------------------------------------------------------------//
        public int AddInvitation(string name, string mobile, string ssn, string date)
        {
            string query = "INSERT INTO Invitations Values('" + name + "','" + mobile + "'," + ssn + ",'" + date + "');";
            return dbMan.ExecuteNonQuery(query);
        }
        //--------------------------------------------------------------------------//
        public int RequestHoliday(string ssn, string sdate, string edate)
        {
            //string query = "INSERT INTO Holidays Values(" + ssn + ",'" + sdate + "','" + edate + "','Pending');";
            //return dbMan.ExecuteNonQuery(query);

            string StoredProcedure1 = StoredProcedures.RequestHoliday;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ssn", ssn);
            Parameters.Add("@sdate", sdate);
            Parameters.Add("@edate", edate);
            return dbMan.ExecuteNonQuery(StoredProcedure1, Parameters);

        }
        //--------------------------------------------------------------------------//
        //public int AddTransaction(int id, string ssn, string date, string type, string amount, string description)
        //{
        //    string query = "INSERT INTO Transactions Values(" + id + "," + ssn + ",'" + date + "','" + type + "'," + amount + ",'" + description + "');";
        //    return dbMan.ExecuteNonQuery(query);
        //}

        public DataTable SelectTrainers()
        {
            string query = "SELECT * FROM Trainers;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectTrainees()
        {
            string query = "SELECT * FROM Trainees;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SearchTrainee(string keyword)
        {
            string query = "SELECT Trainees.[ssn], person_name FROM People JOIN Trainees ON Trainees.[ssn]=People.[ssn] WHERE person_name LIKE '%" + keyword + "%'";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SearchTrainer(string keyword)
        {
            //string query = "SELECT Trainers.[ssn], person_name FROM People JOIN Trainers ON Trainers.[ssn]=People.[ssn] WHERE person_name LIKE '%" + keyword + "%'";
            //return dbMan.ExecuteReader(query);

            string StoredProcedure1 = StoredProcedures.SearchTrainer;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@keyword", keyword);
            return dbMan.ExecuteReader(StoredProcedure1, Parameters);

        }

        public DataTable SelectAllLockers()
        {
            //string query = "SELECT * FROM Lockers;";
            //return dbMan.ExecuteReader(query);

            string StoredProcedure1 = StoredProcedures.SelectAllLockers;
            return dbMan.ExecuteReader(StoredProcedure1, null);

        }

        public DataTable SelectAllPrograms()
        {
            //string query = "SELECT * FROM Programs;";
            //return dbMan.ExecuteReader(query);

            string StoredProcedure1 = StoredProcedures.SelectAllPrograms;
            return dbMan.ExecuteReader(StoredProcedure1, null);

        }

        public int AssignLocker(string ssn, int locker)
        {
            //string query = "UPDATE Lockers SET trainee_ssn ='" + ssn + "' WHERE number = '" + locker + "';";
            //return dbMan.ExecuteNonQuery(query);

            string StoredProcedure1 = StoredProcedures.AssignLocker;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ssn", ssn);
            Parameters.Add("@locker", locker);
            return dbMan.ExecuteNonQuery(StoredProcedure1, Parameters);

        }

        //added
        public int UpdateProgram(string ssn, int pid)
        {
            //string query = "UPDATE Trainees SET program_id = " + pid + " WHERE ssn = '" + ssn + "';";
            //return dbMan.ExecuteNonQuery(query);

            string StoredProcedure1 = StoredProcedures.UpdateProgram;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ssn", ssn);
            Parameters.Add("@pid", pid);
            return dbMan.ExecuteNonQuery(StoredProcedure1, Parameters);

        }

        public DataTable ViewProgram(string prog)
        {
            //string query = "SELECT description FROM Programs WHERE name = '" + prog + "';";
            //return dbMan.ExecuteReader(query);

            string StoredProcedure1 = StoredProcedures.ViewProgram;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@prog", prog);
            return dbMan.ExecuteReader(StoredProcedure1, Parameters);

        }

        public int AssignTrainer(string ssn, string tssn)
        {
            //string query = "UPDATE Trainees SET trainer_ssn = '" + tssn + "' WHERE ssn ='" + ssn + "';";
            //return dbMan.ExecuteNonQuery(query);

            string StoredProcedure1 = StoredProcedures.AssignTrainer;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ssn", ssn);
            Parameters.Add("@tssn", tssn);
            return dbMan.ExecuteNonQuery(StoredProcedure1, Parameters);

        }

        public int Attended(string ssn, string date, string type)
        {
            //string query = "INSERT INTO Attendance VALUES('" + ssn + "','" + date + "','" + type + "');";
            //return dbMan.ExecuteNonQuery(query);

            string StoredProcedure1 = StoredProcedures.Attended;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ssn", ssn);
            Parameters.Add("@date", date);
            Parameters.Add("@type", type);
            return dbMan.ExecuteNonQuery(StoredProcedure1, Parameters);

        }

    }
}