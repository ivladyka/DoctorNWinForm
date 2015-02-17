using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace VikkiSoft.Data
{
    public class MedicationFlowType : DBAccess
    {
        public static DataTable SelectList()
        {
            return SelectRecords("sp_SelectMedicationFlowTypeList");
        }
    }
}
