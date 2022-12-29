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
    public class CustomerDAL: ConnectDB
    {
        public DataTable GetDataCustomerDAL()
        {
            DataTable dt = new DataTable();
            Connect().Open();
            SqlDataAdapter da = new SqlDataAdapter("proc_GetDataCustomer", Connect());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            Connect().Close();
            return dt;
        }
        public bool AddCustomerDAL(CustomerDTO customerDTO)
        {
            
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_AddCustomer";
            cmd.Connection = Connect();
            cmd.Parameters.AddWithValue("@CustomerName", customerDTO.CustomerName);
            cmd.Parameters.AddWithValue("@CustomerPhone", customerDTO.CustomerPhone);
            cmd.Connection.Open();
            int rows = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return rows > 0;
        }
        public bool UpdateCustomerDAL(CustomerDTO customerDTO)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_UpdateCustomer";
            cmd.Connection = Connect();
            cmd.Parameters.AddWithValue("@CustomerName", customerDTO.CustomerName);
            cmd.Parameters.AddWithValue("@CustomerPhone", customerDTO.CustomerPhone);
            cmd.Parameters.AddWithValue("@CustomerId", customerDTO.CustomerId);
            cmd.Connection.Open();
            int rows = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return rows > 0;
        }
        public bool DeleteCustomerDAL(CustomerDTO customerDTO)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_DeleteCustomer";
            cmd.Connection= Connect();
            cmd.Parameters.AddWithValue("@CustomerId", customerDTO.CustomerId);
            cmd.Connection.Open();
            int rows = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return rows > 0;
        }
        public DataTable SearchDataCustomerDAL(CustomerDTO customerDTO)
        {
            Connect().Open();
            SqlDataAdapter da = new SqlDataAdapter("proc_SearchDataCustomer", Connect());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@SearchFollowCustomerName", customerDTO.SearchFollowCustomerName);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Connect().Close();
            return dt;
        }
        public DataTable GetCustomerNameDAL(CustomerDTO customerDTO)
        {
            Connect().Open();
            SqlDataAdapter da = new SqlDataAdapter("proc_GetCustomerName", Connect());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@CustomerPhone", customerDTO.CustomerPhone);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Connect().Close();
            return dt;
        }
        public int GetCustomerIdDAL(CustomerDTO customerDTO)
        {
            Connect().Open();
            SqlDataAdapter da = new SqlDataAdapter("proc_GetCustomerId", Connect());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@CustomerPhone", customerDTO.CustomerPhone);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Connect().Close();
            return Convert.ToInt32(dt.Rows[0][0].ToString());
        }
    }
}
