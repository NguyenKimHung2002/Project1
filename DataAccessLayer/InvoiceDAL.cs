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
    public class InvoiceDAL:ConnectDB
    {
        public bool CreateInvoiceDAL(InvoiceDTO invoiceDTO)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "CreateInvoice";
            cmd.Connection = Connect();
            cmd.Parameters.AddWithValue("@InvoiceDateTime", invoiceDTO.InvoiceDateTime);
            cmd.Parameters.AddWithValue("@CustommerNo", invoiceDTO.CustommerNo);
            cmd.Parameters.AddWithValue("@StaffNo", invoiceDTO.StaffNo);
            cmd.Connection.Open();
            int rows = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            if(rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int GetInvoiceNoDAL(InvoiceDTO invoiceDTO)
        {
            SqlDataAdapter da = new SqlDataAdapter("Get_InvoiceNo", Connect());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Connection = Connect();
            DataTable dt = new DataTable();
            da.SelectCommand.Connection.Open();
            da.Fill(dt);
            da.SelectCommand.Connection.Close();
            return Convert.ToInt32(dt.Rows[dt.Rows.Count-1][0].ToString());
        }
    }
}
