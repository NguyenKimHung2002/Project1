using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DataTransferObject;

namespace DataAccessLayer
{
    public class ProductDAL:ConnectDB
    {
        public DataTable GetDataProductDAL()
        {
            DataTable dt = new DataTable();
            Connect().Open();
            SqlDataAdapter da = new SqlDataAdapter("Show_Product", Connect());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            Connect().Close();
            return dt;
        }
        public DataTable AddInvoiceDetailDAL(ProductDTO productDTO)
        {
            DataTable dt = new DataTable();
            Connect().Open();
            SqlDataAdapter da = new SqlDataAdapter("proc_AddProductIntoInvoice", Connect());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@ProductId", productDTO.ProductId);
            da.Fill(dt);
            Connect().Close();
            return dt;
        }
    }
}
