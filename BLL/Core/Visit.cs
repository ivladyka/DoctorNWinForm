using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace VikkiSoft.Data
{
    public class Visit : DBAccess
    {
        public static DataTable SelectList(int patientID)
        {
            return SelectRecords("sp_SelectVisitList",
                new SqlParameter[] { new SqlParameter("@PatientID", patientID)});
        }

        public static int InsertVisit(DateTime date, int patientID, string anamnesis, string prescriptions)
        {
            System.Collections.Generic.List<SqlParameter> p = new System.Collections.Generic.List<SqlParameter>();
            SqlParameter _pRVAL = new SqlParameter("@RETURN_VALUE", SqlDbType.Int);
            _pRVAL.Direction = ParameterDirection.ReturnValue;
            p.Add(_pRVAL);
            p.Add(new SqlParameter("@PatientID", patientID));
            p.Add(new SqlParameter("@Date", date));
            p.Add(new SqlParameter("@Anamnesis", anamnesis));
            p.Add(new SqlParameter("@Prescription", prescriptions));
            UpdateData("sp_InsertVisit", p.ToArray());
            return (int)p[0].Value;
        }

        public static void UpdateVisit(int visitID, DateTime date, string anamnesis, string prescriptions)
        {
            UpdateData("sp_UpdateVisit",
                new SqlParameter[] { new SqlParameter("@VisitID", visitID),
                new SqlParameter("@Date", date),
                new SqlParameter("@Anamnesis", anamnesis),
                new SqlParameter("@Prescription", prescriptions)});
        }

        public static void DeleteVisit(int visitID)
        {
            UpdateData("sp_DeleteVisit", new SqlParameter[]
			{
				 new SqlParameter("@VisitID", visitID)
			});
        }

        public static DataRow SelectOne(int visitID)
        {
            return SelectRecord("sp_SelectVisit",
                new SqlParameter[] { new SqlParameter("@VisitID", visitID) });
        }
    }
}
