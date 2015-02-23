using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace VikkiSoft.Data
{
    public class Document : DBAccess
    {
        public static int InsertDocument(int medicalTestID, string fileName)
        {
            System.Collections.Generic.List<SqlParameter> p = new System.Collections.Generic.List<SqlParameter>();
            SqlParameter _pRVAL = new SqlParameter("@RETURN_VALUE", SqlDbType.Int);
            _pRVAL.Direction = ParameterDirection.ReturnValue;
            p.Add(_pRVAL);
            p.Add(new SqlParameter("@MedicalTestID", medicalTestID));
            p.Add(new SqlParameter("@FileName", fileName));
            UpdateData("sp_InsertDocument", p.ToArray());
            return (int)p[0].Value;
        }

        public static DataTable SelectListByMedicalTestID(int medicalTestID)
        {
            return SelectRecords("sp_SelectDocumentListByMedicalTestID",
                new SqlParameter[] { new SqlParameter("@MedicalTestID", medicalTestID) });
        }

        public static void DeleteDocument(int documentID)
        {
            UpdateData("sp_DeleteDocument", new SqlParameter[]
			{
				 new SqlParameter("@DocumentID", documentID)
			});
        }
    }
}
