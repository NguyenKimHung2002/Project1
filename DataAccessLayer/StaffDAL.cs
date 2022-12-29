using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;

namespace DataAccessLayer
{
    public class StaffDAL:ConnectDB
    {
        StaffDTO staffDTO = new StaffDTO();
        public int CheckLoginDAL(StaffDTO staffDTO)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AuthoLogin";
            cmd.Parameters.AddWithValue("@Username", staffDTO.StaffAccount);
            cmd.Parameters.AddWithValue("@Password", staffDTO.StaffPassword);
            cmd.Connection = Connect();
            cmd.Connection.Open();
            object res = cmd.ExecuteScalar();
            cmd.Connection.Close();
            return Convert.ToInt32(res);
        }
        public int GetStaffNoDAL(StaffDTO staffDTO)
        {
            SqlDataAdapter da = new SqlDataAdapter("proc_GetStaffId", Connect());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@Username", staffDTO.StaffAccount);
            da.SelectCommand.Parameters.AddWithValue("@Password", staffDTO.StaffPassword);
            DataTable dt = new DataTable();
            Connect().Open();
            da.Fill(dt);
            Connect().Close();
            return Convert.ToInt32(dt.Rows[0][0]);
        }
        public string GetStaffNameDAL(StaffDTO staffDTO)
        {
            SqlDataAdapter da = new SqlDataAdapter("proc_GetStaffName", Connect());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@Username", staffDTO.StaffAccount);
            da.SelectCommand.Parameters.AddWithValue("@Password", staffDTO.StaffPassword);
            DataTable dt = new DataTable();
            Connect().Open();
            da.Fill(dt);
            Connect().Close();
            return dt.Rows[0][0].ToString();
        }
    }
}
