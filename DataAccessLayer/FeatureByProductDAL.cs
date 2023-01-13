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
    public class FeatureByProductDAL:ConnectDB
    {
        public DataTable GetFeatureByProductDAL(FeatureByProductDTO featureByProductDTO)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.CommandText = "proc_GetDataSticker";
            da.SelectCommand.Parameters.AddWithValue("@ProductId", featureByProductDTO);
            da.SelectCommand.Connection = Connect();
            da.SelectCommand.Connection.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.SelectCommand.Connection.Close();
            return dt;
        }
        public bool AddFeatureByProductDAL(FeatureByProductDTO featureByProductDTO)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_AddSticker";
            cmd.Parameters.AddWithValue("@ProductId", featureByProductDTO.ProductId);
            cmd.Parameters.AddWithValue("@FeatureId", featureByProductDTO.FeatureId);
            cmd.Parameters.AddWithValue("@FeatureValue", featureByProductDTO.FeatureValue);
            cmd.Connection = Connect();
            cmd.Connection.Open();
            var rows = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return rows > 0;
        }
        public bool UpdateFeatureDAL(FeatureByProductDTO featureByProductDTO)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_UpdateSticker";
            cmd.Connection = Connect();
            cmd.Parameters.AddWithValue("@ProductId", featureByProductDTO.ProductId);
            cmd.Parameters.AddWithValue("@FeatureId", featureByProductDTO.FeatureId);
            cmd.Parameters.AddWithValue("@FeatureValue", featureByProductDTO.FeatureValue);
            cmd.Connection.Open();
            int rows = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return rows > 0;
        }
        public bool DeleteFeatureDAL(FeatureByProductDTO featureByProductDTO)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_DeleteSticker";
            cmd.Connection= Connect();
            cmd.Parameters.AddWithValue("@FeatureId", featureByProductDTO.FeatureId);
            cmd.Connection.Open();
            int rows = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return rows > 0;
        }
    }
}
