using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace VikkiSoft.Data
{
    public class MedicalTest : DBAccess
    {
        public static DataRow SelectOne(int medicalTestID)
        {
            return SelectRecord("sp_SelectMedicalTest",
                new SqlParameter[] { new SqlParameter("@MedicalTestID", medicalTestID) });
        }

        public static DataTable SelectList(int visitID)
        {
            return SelectRecords("sp_SelectMedicalTestList",
                new SqlParameter[] { new SqlParameter("@VisitID", visitID) });
        }

        public static int InsertMedicalTest(DateTime date, int medicalTestTypeID, string fileName, int visitID)
        {
            System.Collections.Generic.List<SqlParameter> p = new System.Collections.Generic.List<SqlParameter>();
            SqlParameter _pRVAL = new SqlParameter("@RETURN_VALUE", SqlDbType.Int);
            _pRVAL.Direction = ParameterDirection.ReturnValue;
            p.Add(_pRVAL);
            p.Add(new SqlParameter("@MedicalTestTypeID", medicalTestTypeID));
            p.Add(new SqlParameter("@Date", date));
            p.Add(new SqlParameter("@FileName", fileName));
            p.Add(new SqlParameter("@VisitID", visitID));
            UpdateData("sp_InsertMedicalTest", p.ToArray());
            return (int)p[0].Value;
        }

        public static void UpdateMedicalTest(int medicalTestID, DateTime date, int medicalTestTypeID)
        {
            UpdateData("sp_UpdateMedicalTest",
                new SqlParameter[] { new SqlParameter("@MedicalTestID", medicalTestID),
                new SqlParameter("@MedicalTestTypeID", medicalTestTypeID),
                new SqlParameter("@Date", date)});
        }

        public static void DeleteMedical(int medicalTestID)
        {
            UpdateData("sp_DeleteMedicalTest", new SqlParameter[]
			{
				 new SqlParameter("@MedicalTestID", medicalTestID)
			});
        }
    }
}
