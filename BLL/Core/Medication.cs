using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace VikkiSoft.Data
{
    public class Medication : DBAccess
    {
        public static DataTable SelectList(string name)
        {
            return SelectRecords("sp_SelectMedicationList",
                new SqlParameter[] { new SqlParameter("@Name", name) });
        }

        public static DataTable SelectListWithOffset(int offset, int countRows)
        {
            return SelectRecords("sp_SelectMedicationListWithOffset",
                new SqlParameter[] { new SqlParameter("@Offset", offset),
                    new SqlParameter("@CountRows", countRows)});
        }

        public static DataTable SelectMedicationWarehouseList()
        {
            return SelectRecords("sp_SelectMedicationWarehouseList");
        }

        public static void DeleteMedication(int medicationID)
        {
            UpdateData("sp_DeleteMedication", new SqlParameter[]
			{
				 new SqlParameter("@MedicationID", medicationID)
			});
        }

        public static DataRow SelectOne(int medicationID)
        {
            return SelectRecord("sp_SelectMedication",
                new SqlParameter[] { new SqlParameter("@MedicationID", medicationID) });
        }

        public static void UpdateMedication(int medicationID, string name, int medicationFormID)
        {
            UpdateData("sp_UpdateMedication",
                new SqlParameter[] { new SqlParameter("@MedicationID", medicationID),
                 new SqlParameter("@Name", name),
                 new SqlParameter("@MedicationFormID", medicationFormID)});
        }

        public static void InsertMedication(string name, int medicationFormID)
        {
            UpdateData("sp_InsertMedication",
                new SqlParameter[] { new SqlParameter("@Name", name),
                 new SqlParameter("@MedicationFormID", medicationFormID) });
        }

        public static int GetMedicationCount()
        {
            System.Collections.Generic.List<SqlParameter> p = new System.Collections.Generic.List<SqlParameter>();
            SqlParameter _pRVAL = new SqlParameter("@RETURN_VALUE", SqlDbType.Int);
            _pRVAL.Direction = ParameterDirection.ReturnValue;
            p.Add(_pRVAL);
            UpdateData("sp_SelectMedicationCount", p.ToArray());
            return (int)p[0].Value;
        }
    }
}
