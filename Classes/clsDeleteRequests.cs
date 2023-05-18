using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Classes
{
    public class clsDeleteRequests
    {
        //private static string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        //clsDataConnection db = new clsDataConnection();
        //string connectionString = db.connectionString;
        private static clsDataConnection db = new clsDataConnection();
        // Make connectionString static
        private static string connectionString = db.connectionString;

        public static DataTable GetPendingAccountDeletionRequests()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sproc_GetPendingAccountDeletionRequests", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public static void ProcessAccountDeletionRequest(int requestId, int staffId, bool isApproved)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sproc_ProcessAccountDeletionRequest", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@RequestID", requestId);
                    cmd.Parameters.AddWithValue("@StaffMemberID", staffId);
                    cmd.Parameters.AddWithValue("@IsApproved", isApproved);
                    cmd.Parameters.AddWithValue("@ProcessedDate", DateTime.Now);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
