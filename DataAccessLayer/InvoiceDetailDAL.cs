using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.InteropServices.WindowsRuntime;

namespace DataAccessLayer
{
    public class InvoiceDetailDAL:ConnectDB
    {
        public bool CreateInvoiceDetailDAL(InvoiceDetailDTO invoiceDetailDTO)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "CreateInvoiceDetail";
            cmd.Connection = Connect();
            cmd.Parameters.AddWithValue("@InvoiceNo", invoiceDetailDTO.InvoiceNo);
            cmd.Parameters.AddWithValue("@ProductNo", invoiceDetailDTO.ProductNo);
            cmd.Parameters.AddWithValue("@UnitPrice", invoiceDetailDTO.UnitPrice);
            cmd.Parameters.AddWithValue("@ProductNumber", invoiceDetailDTO.ProductNumber);
            cmd.Connection.Open();
            int rows = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }        
    }
}
