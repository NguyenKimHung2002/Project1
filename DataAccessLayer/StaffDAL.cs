using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class StaffDAL:ConnectDB
    {
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
    }
}
