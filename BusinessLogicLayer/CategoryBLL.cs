using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class CategoryBLL
    {
        CategoryDAL categoryDAL = new CategoryDAL();
        public DataTable GetListProductTypeBLL()
        {
            return categoryDAL.GetListProductTypeDAL();
        }
    }
}
