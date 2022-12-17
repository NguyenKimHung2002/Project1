using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices.WindowsRuntime;

namespace DataAccessLayer
{
    public class CustommerDAL: ConnectDB
    {
        public DataTable GetDataDAL()
        {
            DataTable dt = new DataTable();
            Connect().Open();
            SqlDataAdapter da = new SqlDataAdapter("Show_Custommer", Connect());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            Connect().Close();
            return dt;
        }
        public bool AddCustommerDAL(CustommerDTO custommerDTO)
        {
            
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Add_Custommer";
            cmd.Connection = Connect();
            cmd.Parameters.AddWithValue("@CustommerName", custommerDTO.CustommerName);
            cmd.Parameters.AddWithValue("@CustommerPhone", custommerDTO.CustommerPhone);
            cmd.Connection.Open();
            int rows = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return rows > 0;
        }
        public bool UpdateCustommerDAL(CustommerDTO custommerDTO)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Update_Custommer";
            cmd.Connection = Connect();
            cmd.Parameters.AddWithValue("@CustommerName", custommerDTO.CustommerName);
            cmd.Parameters.AddWithValue("@CustommerPhone", custommerDTO.CustommerPhone);
            cmd.Parameters.AddWithValue("@CustommerNo", custommerDTO.CustommerNo);
            cmd.Connection.Open();
            int rows = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return rows > 0;
        }
        public bool DeleteCustommerDAL(CustommerDTO custommerDTO)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Delete_Custommer";
            cmd.Connection= Connect();
            cmd.Parameters.AddWithValue("@CustommerNo", custommerDTO.CustommerNo);
            cmd.Connection.Open();
            int rows = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return rows > 0;
        }
        public DataTable GetCustommerNameDAL(CustommerDTO custommerDTO)
        {
            Connect().Open();
            SqlDataAdapter da = new SqlDataAdapter("Get_CustommerName", Connect());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@CustommerPhone", custommerDTO.CustommerPhone);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Connect().Close();
            return dt;
        }
        public int GetCustommerNoDAL(CustommerDTO custommerDTO)
        {
            Connect().Open();
            SqlDataAdapter da = new SqlDataAdapter("Get_CustommerNo", Connect());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@CustommerPhone", custommerDTO.CustommerPhone);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Connect().Close();
            return Convert.ToInt32(dt.Rows[0][0].ToString());
        }
    }
}
