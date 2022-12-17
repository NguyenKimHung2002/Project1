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
        public DataTable GetListProductTypeDAL()
        {
            Connect().Open();
            SqlDataAdapter da = new SqlDataAdapter("Get_ListProductType", Connect());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Connect().Close();
            return dt;
        }
    }
}
