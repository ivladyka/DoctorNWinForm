using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace VikkiSoft.Data
{
    public class Reminder : DBAccess
    {
        public static DataTable SelectReminderList()
        {
            return SelectRecords("sp_SelectReminderList");
        }

        public static DataRow SelectOne(int reminderID)
        {
            return SelectRecord("sp_SelectReminder",
                new SqlParameter[] { new SqlParameter("@ReminderID", reminderID) });
        }

        public static void UpdateReminder(int reminderID, int patientID, DateTime date, string notes)
        {
            SqlParameter sqlpPatientID = new SqlParameter("@PatientID", SqlDbType.Int);
            if (patientID > 0)
            {
                sqlpPatientID.Value = patientID;
            }
            else
            {
                sqlpPatientID.Value = DBNull.Value;
            }
            UpdateData("sp_UpdateReminder",
                new SqlParameter[] { new SqlParameter("@ReminderID", reminderID),
                 sqlpPatientID,
                 new SqlParameter("@Date", date),
                 new SqlParameter("@Notes", notes) });
        }

        public static void InsertReminder(int patientID, DateTime date, string notes)
        {
            SqlParameter sqlpPatientID = new SqlParameter("@PatientID", SqlDbType.Int);
            if (patientID > 0)
            {
                sqlpPatientID.Value = patientID;
            }
            else
            {
                sqlpPatientID.Value = DBNull.Value;
            }
            UpdateData("sp_InsertReminder",
                 new SqlParameter[] { sqlpPatientID,
                 new SqlParameter("@Date", date),
                 new SqlParameter("@Notes", notes) });
        }

        public static void DeleteReminder(int reminderID)
        {
            UpdateData("sp_DeleteReminder", new SqlParameter[]
			{
				 new SqlParameter("@ReminderID", reminderID)
			});
        }
    }
}
