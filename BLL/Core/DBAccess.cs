using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Web;

namespace VikkiSoft.Data
{
    /// <summary>
    /// Summary description for DBAccess.
    /// </summary>
    [Serializable()]
    public class DBAccess
    {
        private static SqlConnection GetDbConnection(System.Guid OrgID)
        {
            return new SqlConnection(GetConnectionString(OrgID));
        }

        public static string GetConnectionString(Guid OrgID)
        {
            return ConfigurationManager.ConnectionStrings["Vikkisoft.ConnectionString"].ConnectionString;
        }

        protected static DataTable SelectRecords(string StoredProcName)
        {
            return SelectRecords(StoredProcName, Guid.Empty);
        }


        protected static DataTable SelectRecords(string StoredProcName, Guid OrgID)
        {
            using (SqlConnection connection = GetDbConnection(OrgID))
            {
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = StoredProcName;
                    var tb = new DataTable();
                    using (var da=new SqlDataAdapter(cmd))
                        da.Fill(tb);
                    if (cmd.Connection.State==ConnectionState.Open) cmd.Connection.Close();
                    return tb;
                }
            }
        }

        public static DataTable SelectRecords(string StoredProcName, SqlParameter[] param)
        {
            return SelectRecords(StoredProcName, param, Guid.Empty);
        }

        protected static DataTable SelectRecords(string StoredProcName, SqlParameter[] param, Guid OrgID)
        {
            using (SqlConnection connection = GetDbConnection(OrgID))
            {
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = StoredProcName;
                    cmd.Parameters.AddRange(param);
                    var tb = new DataTable();
                    using (var da = new SqlDataAdapter(cmd))
                        da.Fill(tb);
                    cmd.Parameters.Clear();
                    if (cmd.Connection.State==ConnectionState.Open) cmd.Connection.Close();
                    return tb;
                }
            }
        }

        protected static DataRow SelectRecord(string StoredProcName, SqlParameter param)
        {
            return SelectRecord(StoredProcName, new SqlParameter[] { param });
        }

        protected static DataRow SelectRecord(string StoredProcName, SqlParameter[] param)
        {
            return SelectRecord(StoredProcName, param, Guid.Empty);
        }

        protected static DataRow SelectRecord(string StoredProcName, SqlParameter[] param, Guid OrgID)
        {
            using (SqlConnection connection = GetDbConnection(OrgID))
            {
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = StoredProcName;
                    cmd.Parameters.AddRange(param);
                    var tb = new DataTable();
                    using (var da = new SqlDataAdapter(cmd))
                        da.Fill(tb);
                    cmd.Parameters.Clear();
                    if (cmd.Connection.State==ConnectionState.Open) cmd.Connection.Close();
                    if (tb.Rows.Count > 0) return tb.Rows[0];
                    else return null;
                }
            }
        }

        public static DataTable SelectByQuery(string Query)
        {
            return SelectByQuery(Query, Guid.Empty);
        }

        public static DataTable SelectByQuery(string Query, Guid OrgID)
        {
            using (SqlConnection connection = GetDbConnection(OrgID))
            {
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = Query;
                    var tb = new DataTable();
                    using (var da = new SqlDataAdapter(cmd))
                        da.Fill(tb);
                    if (cmd.Connection.State==ConnectionState.Open) cmd.Connection.Close();
                    return tb;
                }
            }
        }

        public static int UpdateByQuery(string Query)
        {
            return UpdateByQuery(Query, null, Guid.Empty);
        }

        public static int UpdateByQuery(string Query, SqlParameter[] param)
        {
            return UpdateByQuery(Query, param, Guid.Empty);
        }

        protected static int UpdateByQuery(string Query, Guid OrgID)
        {
            return UpdateByQuery(Query, null, OrgID);
        }


        protected static int UpdateByQuery(string Query, SqlParameter[] param, Guid OrgID)
        {
            using (SqlConnection connection = GetDbConnection(OrgID))
            {
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = Query;
                    if (param != null && param.Length > 0) cmd.Parameters.AddRange(param);
                    cmd.Connection.Open();
                    int _res = cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    cmd.Connection.Close();
                    return _res;
                }
            }
        }

        public static int UpdateData(string StoredProcName, SqlParameter param)
        {
            return UpdateData(StoredProcName, param, Guid.Empty);
        }

        public static int UpdateData(string StoredProcName, SqlParameter param, Guid OrgId)
        {
            return UpdateData(StoredProcName, new SqlParameter[] { param }, OrgId);
        }

        public static int UpdateData(string StoredProcName, SqlParameter[] param)
        {
            return UpdateData(StoredProcName, param, Guid.Empty);
        }

        protected static int UpdateData(string StoredProcName, SqlParameter[] param, Guid OrgID)
        {
            using (SqlConnection connection = GetDbConnection(OrgID))
            {
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = StoredProcName;
                    cmd.Parameters.AddRange(param);
                    cmd.Connection.Open();
                    int _res = cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    cmd.Connection.Close();
                    return _res;
                }
            }
        }
    }
}
