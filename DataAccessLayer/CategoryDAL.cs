using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CategoryDAL:ConnectDB
    {
        public DataTable GetDataCategoryDAL()
        {
            DataTable dt = new DataTable();
            Connect().Open();
            SqlDataAdapter da = new SqlDataAdapter("proc_GetDataCategory", Connect());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            Connect().Close();
            return dt;
        }
        public DataTable GetCategoryNameDAL()
        {
            Connect().Open();
            SqlDataAdapter da = new SqlDataAdapter("proc_GetCategoryName", Connect());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Connect().Close();
            return dt;
        }
        public int GetLastestCategoryIdDAL(CategoryDTO categoryDTO)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_GetLastestCategoryId";
            cmd.Connection = Connect();
            cmd.Connection.Open();
            object res = cmd.ExecuteScalar();
            cmd.Connection.Close();
            return Convert.ToInt32(res);
        }
        public bool AddCategoryDAL(CategoryDTO categoryDTO)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_AddCategory";
            cmd.Connection = Connect();
            cmd.Parameters.AddWithValue("@CategoryName", categoryDTO.CategoryName);
            cmd.Parameters.AddWithValue("@CategoryDescription", categoryDTO.CategoryDescription);
            cmd.Connection.Open();
            int rows = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return rows > 0;
        }
        public bool UpdateCategoryDAL(CategoryDTO categoryDTO)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_UpdateCategory";
            cmd.Connection = Connect();
            cmd.Parameters.AddWithValue("@CategoryName", categoryDTO.CategoryName);
            cmd.Parameters.AddWithValue("@CategoryDescription", categoryDTO.CategoryDescription);
            cmd.Parameters.AddWithValue("@CategoryId", categoryDTO.CategoryId);
            cmd.Connection.Open();
            int rows = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return rows > 0;
        }
        public bool DeleteCategoryDAL(CategoryDTO categoryDTO)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_DeleteCategory";
            cmd.Connection= Connect();
            cmd.Parameters.AddWithValue("@CategoryId", categoryDTO.CategoryId);
            cmd.Connection.Open();
            int rows = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return rows > 0;
        }
        public DataTable SearchDataCategoryDAL(CategoryDTO categoryDTO)
        {
            Connect().Open();
            SqlDataAdapter da = new SqlDataAdapter("proc_SearchDataCategory", Connect());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@SearchFollowCategoryName", categoryDTO.SearchFollowCategoryName);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Connect().Close();
            return dt;
        }
    }
}
