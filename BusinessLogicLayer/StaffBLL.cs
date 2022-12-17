using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataTransferObject;
namespace BusinessLogicLayer
{
    public class StaffBLL
    {
        StaffDAL staffDAL = new StaffDAL();
        public int CheckLoginBLL(StaffDTO staffDTO)
        {
            return staffDAL.CheckLoginDAL(staffDTO);
        }
        public string GetStaffNameBLL(StaffDTO staffDTO)
        {
            return staffDAL.GetStaffNameDAL(staffDTO);
        }
        public int GetStaffNoBLL(StaffDTO staffDTO)
        {
            return staffDAL.GetStaffNoDAL(staffDTO);
        }
    }
}
