using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace VikkiSoft.Data
{
    public class MedicationFlow : DBAccess
    {
        public static DataRow SelectOne(int medicationFlowID)
        {
            return SelectRecord("sp_SelectMedicationFlow",
                new SqlParameter[] { new SqlParameter("@MedicationFlowID", medicationFlowID) });
        }

        public static void UpdateMedicationFlow(int medicationFlowID, int medicationFlowTypeID, int medicationID, int count, DateTime date, string note)
        {
            UpdateData("sp_UpdateMedicationFlow",
                new SqlParameter[] { new SqlParameter("@MedicationFlowID", medicationFlowID),
                 new SqlParameter("@MedicationFlowTypeID", medicationFlowTypeID),
                 new SqlParameter("@MedicationID", medicationID),
                 new SqlParameter("@Count", count),
                 new SqlParameter("@Date", date),
                 new SqlParameter("@Note", note) });
        }

        public static void InsertMedicationFlow(int medicationFlowTypeID, int medicationID, int count, DateTime date, string note)
        {
            UpdateData("sp_InsertMedicationFlow",
                new SqlParameter[] { new SqlParameter("@MedicationFlowTypeID", medicationFlowTypeID),
                 new SqlParameter("@MedicationID", medicationID),
                 new SqlParameter("@Count", count),
                 new SqlParameter("@Date", date),
                 new SqlParameter("@Note", note) });
        }

        public static DataTable SelectListByMedicationIDWithOffset(int medicationID, int offset, int countRows)
        {
            return SelectRecords("sp_SelectMedicationFlowListByMedicationIDWithOffset",
                new SqlParameter[] { new SqlParameter("@MedicationID", medicationID), 
                    new SqlParameter("@Offset", offset),
                    new SqlParameter("@CountRows", countRows)});
        }

        public static int GetMedicationFlowCount(int medicationID)
        {
            System.Collections.Generic.List<SqlParameter> p = new System.Collections.Generic.List<SqlParameter>();
            SqlParameter _pRVAL = new SqlParameter("@RETURN_VALUE", SqlDbType.Int);
            _pRVAL.Direction = ParameterDirection.ReturnValue;
            p.Add(_pRVAL);
            p.Add(new SqlParameter("@MedicationID", medicationID));
            UpdateData("sp_SelectMedicationFlowCountByMedicationID", p.ToArray());
            return (int)p[0].Value;
        }

        public static void DeleteMedicationFlow(int medicationFlowID)
        {
            UpdateData("sp_DeleteMedicationFlow", new SqlParameter[]
			{
				 new SqlParameter("@MedicationFlowID", medicationFlowID)
			});
        }
    }
}
