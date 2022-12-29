using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;

namespace DataAccessLayer
{
    public class FeatureDAL:ConnectDB
    { 
        public DataTable GetDataFeatureDAL()
        {
            Connect().Open();
            SqlDataAdapter da = new SqlDataAdapter("proc_GetDataFeature", Connect());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Connect().Close();
            return dt;
        }
        public DataTable GetFeatureNameDAL()
        {
            Connect().Open();
            SqlDataAdapter da = new SqlDataAdapter("proc_GetFeatureName", Connect());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Connect().Close();
            return dt;
        }
        public int GetFeatureIdByFeatureNameDAL(FeatureDTO featureDTO)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_GetFeatureIdByFeatureName";
            cmd.Parameters.AddWithValue("@FeatureName", featureDTO.FeatureName);
            cmd.Connection = Connect();
            cmd.Connection.Open();
            object res = cmd.ExecuteScalar();
            cmd.Connection.Close();
            return Convert.ToInt32(res);
        }
        public bool AddFeatureDAL(FeatureDTO featureDTO)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_AddFeature";
            cmd.Connection = Connect();
            cmd.Parameters.AddWithValue("@FeatureName", featureDTO.FeatureName);
            cmd.Parameters.AddWithValue("@FeatureDescription", featureDTO.FeatureDescription);
            cmd.Connection.Open();
            int rows = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return rows > 0;
        }
        public bool UpdateFeatureDAL(FeatureDTO featureDTO)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_UpdateFeature";
            cmd.Connection = Connect();
            cmd.Parameters.AddWithValue("@FeatureName", featureDTO.FeatureName);
            cmd.Parameters.AddWithValue("@FeatureDescription", featureDTO.FeatureDescription);
            cmd.Parameters.AddWithValue("@FeatureId", featureDTO.FeatureId);
            cmd.Connection.Open();
            int rows = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return rows > 0;
        }
        public bool DeleteFeatureDAL(FeatureDTO featureDTO)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_DeleteFeature";
            cmd.Connection= Connect();
            cmd.Parameters.AddWithValue("@FeatureId", featureDTO.FeatureId);
            cmd.Connection.Open();
            int rows = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return rows > 0;
        }
        public DataTable SearchDataFeatureDAL(FeatureDTO featureDTO)
        {
            Connect().Open();
            SqlDataAdapter da = new SqlDataAdapter("proc_SearchDataFeature", Connect());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@SearchFollowFeatureName", featureDTO.SearchFollowFeatureName);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Connect().Close();
            return dt;
        }
    }
}
