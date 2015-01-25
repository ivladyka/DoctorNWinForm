using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace VikkiSoft.Data
{
    public class Patient : DBAccess
    {
        public static int InsertPatient(string firstName, string lastName, string middleName, DateTime birthday, string notes,
            string education, string workPosition, string phone, string financialNotes)
        {
            SqlParameter sqlpBirthday = new SqlParameter("@Birthday", SqlDbType.DateTime);
            if (birthday > new DateTime(1900, 1, 1))
            {
                sqlpBirthday.Value = birthday;
            }
            else
            {
                sqlpBirthday.Value = DBNull.Value;
            }
            System.Collections.Generic.List<SqlParameter> p = new System.Collections.Generic.List<SqlParameter>();
            SqlParameter _pRVAL = new SqlParameter("@RETURN_VALUE", SqlDbType.Int);
            _pRVAL.Direction = ParameterDirection.ReturnValue;
            p.Add(_pRVAL);
            p.Add(new SqlParameter("@FirstName", firstName));
            p.Add(new SqlParameter("@LastName", lastName));
            p.Add(new SqlParameter("@MiddleName", middleName));
            p.Add(sqlpBirthday);
            p.Add(new SqlParameter("@Notes", notes));
            p.Add(new SqlParameter("@Education", education));
            p.Add(new SqlParameter("@WorkPosition", workPosition));
            p.Add(new SqlParameter("@Phone", phone));
            p.Add(new SqlParameter("@FinancialNotes", financialNotes));
            UpdateData("sp_InsertPatient", p.ToArray());
            return (int)p[0].Value;
        }

        public static void UpdatePatient(int patientID, string firstName, string lastName, string middleName, DateTime birthday, string notes,
            string education, string workPosition, string phone, string financialNotes)
        {
            SqlParameter sqlpBirthday = new SqlParameter("@Birthday", SqlDbType.DateTime);
            if (birthday > new DateTime(1900, 1, 1))
            {
                sqlpBirthday.Value = birthday;
            }
            else
            {
                sqlpBirthday.Value = DBNull.Value;
            }

            UpdateData("sp_UpdatePatient",
                new SqlParameter[] { new SqlParameter("@PatientID", patientID),
                new SqlParameter("@FirstName", firstName),
                new SqlParameter("@LastName", lastName),
                new SqlParameter("@MiddleName", middleName),
                sqlpBirthday,
                new SqlParameter("@Notes", notes),
                new SqlParameter("@Education", education),
                new SqlParameter("@WorkPosition", workPosition),
                new SqlParameter("@Phone", phone),
                new SqlParameter("@FinancialNotes", financialNotes)
                });
        }

        public static DataTable SelectList(string firstName, string lastName)
        {
            return SelectRecords("sp_SelectPatientList",
                new SqlParameter[] { new SqlParameter("@FirstName", firstName),
                new SqlParameter("@LastName", lastName)});
        }

        public static void DeletePatient(int patientID)
        {
            UpdateData("sp_DeletePatient", new SqlParameter[]
			{
				 new SqlParameter("@PatientID", patientID)
			});
        }

        public static DataRow SelectOne(int patientID)
        {
            return SelectRecord("sp_SelectPatient",
                new SqlParameter[] { new SqlParameter("@PatientID", patientID) });
        }
    }
}
