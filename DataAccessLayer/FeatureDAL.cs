using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;

namespace DataAccessLayer
{
    public class FeatureDAL:ConnectDB
    {
        public DataTable GetListFeatureTagDAL()
        {
            Connect().Open();
            SqlDataAdapter da = new SqlDataAdapter("Get_ListFeatureTag", Connect());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Connect().Close();
            return dt;
        }
    }
}
