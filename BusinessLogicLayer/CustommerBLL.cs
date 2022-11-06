using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataTransferObject;

namespace BusinessLogicLayer
{
    public class CustommerBLL
    {
        CustommerDAL custommerDAL = new CustommerDAL();
        public DataTable GetDataBLL()
        {
            return custommerDAL.GetDataDAL();
        }
        public bool AddCustommerBLL(CustommerDTO custommerDTO)
        {
            return custommerDAL.AddCustommerDAL(custommerDTO);
        }
    }
}
