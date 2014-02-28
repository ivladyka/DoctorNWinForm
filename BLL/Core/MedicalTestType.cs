using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace VikkiSoft.Data
{
    public class MedicalTestType : DBAccess
    {
        public static DataTable SelectList()
        {
            return SelectRecords("sp_SelectMedicalTestTypeList");
        }

        public static DataRow SelectOne(int medicalTestTypeID)
        {
            return SelectRecord("sp_SelectMedicalTestType",
                new SqlParameter[] { new SqlParameter("@MedicalTestTypeID", medicalTestTypeID) });
        }

        public static void InsertMedicalTestType(string name)
        {
            UpdateData("sp_InsertMedicalTestType",
                new SqlParameter[] { new SqlParameter("@Name", name) });
        }

        public static void UpdateMedicalTestType(int medicalTestTypeID, string name)
        {
            UpdateData("sp_UpdateMedicalTestType",
                new SqlParameter[] { new SqlParameter("@MedicalTestTypeID", medicalTestTypeID),
                 new SqlParameter("@Name", name)});
        }

        public static void DeleteMedicalTestType(int medicalTestTypeID)
        {
            UpdateData("sp_DeleteMedicalTestType", new SqlParameter[]
			{
				 new SqlParameter("@MedicalTestTypeID", medicalTestTypeID)
			});
        }

    }
}
