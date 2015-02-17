using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace VikkiSoft.Data
{
    public class MedicationForm : DBAccess
    {
        public static DataTable SelectList()
        {
            return SelectRecords("sp_SelectMedicationFormList");
        }

        public static DataRow SelectOne(int medicationFormID)
        {
            return SelectRecord("sp_SelectMedicationForm",
                new SqlParameter[] { new SqlParameter("@MedicationFormID", medicationFormID) });
        }

        public static void DeleteMedicationForm(int medicationFormID)
        {
            UpdateData("sp_DeleteMedicationForm", new SqlParameter[]
			{
				 new SqlParameter("@MedicationFormID", medicationFormID)
			});
        }

        public static void UpdateMedicationForm(int medicationFormID, string name)
        {
            UpdateData("sp_UpdateMedicationForm",
                new SqlParameter[] { new SqlParameter("@MedicationFormID", medicationFormID),
                 new SqlParameter("@Name", name)});
        }

        public static void InsertMedicationForm(string name)
        {
            UpdateData("sp_InsertMedicationForm",
                new SqlParameter[] { new SqlParameter("@Name", name) });
        }
    }
}
