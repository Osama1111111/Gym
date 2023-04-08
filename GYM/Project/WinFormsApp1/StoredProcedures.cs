using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   //OD

namespace DBapplication
{
    public class StoredProcedures
    {   //No para
        public static string viewAllHolidays = "viewAllHolidaysProc";
        public static string SelectAllPrograms = "SelectAllProgramsProc";
        public static string SelectAllLockers = "SelectAllLockersProc";

        //para
        public static string Attended = "AttendedProc";
        public static string AssignTrainer = "AssignTrainerProc";
        public static string ViewProgram = "ViewProgramProc";
        public static string UpdateProgram = "UpdateProgramProc";
        public static string AssignLocker = "AssignLockerProc";
        public static string SearchTrainer = "SearchTrainerProc";
        public static string RequestHoliday = "RequestHolidayProc;";
        public static string CancelMembership = "CancelMembershipProc;";

    }
}
