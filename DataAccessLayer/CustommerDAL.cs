using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

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
            if (rows >0)
            {
                return true;
            }
            else return false;
        }
    }
}
