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
        public bool UpdateCustommerBLL(CustommerDTO custommerDTO)
        {
            return custommerDAL.UpdateCustommerDAL(custommerDTO);
        }
        public bool DeleteCustommerBLL(CustommerDTO custommerDTO)
        {
            return custommerDAL.DeleteCustommerDAL(custommerDTO);
        }
        public DataTable GetCustommerName(CustommerDTO custommerDTO)
        {
            return custommerDAL.GetCustommerNameDAL(custommerDTO);
        }
        public int GetCustommerNoBLL(CustommerDTO custommerDTO)
        {
            return custommerDAL.GetCustommerNoDAL(custommerDTO);
        }
    }
}
