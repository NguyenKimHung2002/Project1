using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class FeatureByCategoryDAL:ConnectDB
    {
        public bool AddFeatureByCategoryDAL(FeatureByCategoryDTO featureByCategoryDTO)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_AddFeatureByCategory";
            cmd.Parameters.AddWithValue("@FeatureId", featureByCategoryDTO.FeatureId);
            cmd.Parameters.AddWithValue("@CategoryId", featureByCategoryDTO.CategoryId);
            cmd.Connection = Connect();
            cmd.Connection.Open();
            var rows = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return rows > 0;
        }
    }
}
