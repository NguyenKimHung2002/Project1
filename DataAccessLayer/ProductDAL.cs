using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class ProductDAL:ConnectDB
    {
        public DataTable GetDataProductDAL()
        {
            DataTable dt = new DataTable();
            Connect().Open();
            SqlDataAdapter da = new SqlDataAdapter("proc_GetDataProduct", Connect());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            Connect().Close();
            return dt;
        }
        public DataTable GetDataPaymentDAL()
        {
            DataTable dt = new DataTable();
            Connect().Open();
            SqlDataAdapter da = new SqlDataAdapter("proc_GetDataPayment", Connect());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            Connect().Close();
            return dt;
        }
        public DataTable SearchDataPaymentDAL(ProductDTO productDTO)
        {
            DataTable dt = new DataTable();
            Connect().Open();
            SqlDataAdapter da = new SqlDataAdapter("proc_SearchDataPayment", Connect());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@SearchDataPayment", productDTO.SearchDataPayment);
            da.Fill(dt);
            Connect().Close();
            return dt;
        }
        public bool AddProductDAL(ProductDTO ProductDTO)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_AddProduct";
            cmd.Parameters.AddWithValue("@ProductId", ProductDTO.ProductId);
            cmd.Parameters.AddWithValue("@ProductName", ProductDTO.ProductName);
            cmd.Parameters.AddWithValue("@ProductQuantity", ProductDTO.ProductQuantity);
            cmd.Parameters.AddWithValue("@ProductUnit", ProductDTO.ProductUnit);
            cmd.Parameters.AddWithValue("@ImportPrice", ProductDTO.ImportPrice);
            cmd.Parameters.AddWithValue("@ExportPrice", ProductDTO.ExportPrice);
            cmd.Parameters.AddWithValue("@ProductDesciption", ProductDTO.ProductDescription);
            cmd.Connection = Connect();
            cmd.Connection.Open();
            var rows = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return rows > 0;
        }
        public bool UpdateProductDAL(ProductDTO ProductDTO)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_UpdateProduct";
            cmd.Connection = Connect();
            cmd.Parameters.AddWithValue("@ProductId", ProductDTO.ProductId);
            cmd.Parameters.AddWithValue("@ProductName", ProductDTO.ProductName);
            cmd.Parameters.AddWithValue("@ProductQuantity", ProductDTO.ProductQuantity);
            cmd.Parameters.AddWithValue("@ProductUnit", ProductDTO.ProductUnit);
            cmd.Parameters.AddWithValue("@ImportPrice", ProductDTO.ImportPrice);
            cmd.Parameters.AddWithValue("@ExportPrice", ProductDTO.ExportPrice);
            cmd.Parameters.AddWithValue("@ProductDesciption", ProductDTO.ProductDescription);
            cmd.Connection.Open();
            int rows = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return rows > 0;
        }
        public bool DeleteProductDAL(ProductDTO ProductDTO)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_DeleteProduct";
            cmd.Parameters.AddWithValue("@ProductId", ProductDTO.ProductId);
            cmd.Connection = Connect();
            cmd.Connection.Open();
            int rows = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return rows > 0;
        }
        public int CheckExistsProductIdDAL(ProductDTO productDTO)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "proc_CheckExistsProductId";
            cmd.Parameters.AddWithValue("@ProductId", productDTO.ProductId);
            cmd.Connection = Connect();
            cmd.Connection.Open();
            object code = cmd.ExecuteScalar();
            cmd.Connection.Close();
            return Convert.ToInt32(code);
        }
        public DataTable AddInvoiceDetailDAL(ProductDTO productDTO)
        {
            DataTable dt = new DataTable();
            Connect().Open();
            SqlDataAdapter da = new SqlDataAdapter("proc_GetProductInformationForInvoice", Connect());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@ProductId", productDTO.ProductId);
            da.Fill(dt);
            Connect().Close();
            return dt;
        }
    }
}
