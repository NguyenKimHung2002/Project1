using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class StaffDTO
    {
        private string _StaffId;
        private string _StaffAccount;
        private string _StaffPassword;
        private string _StaffName;
        private int _StaffIDPer;
        private string _StaffGender;
        private string _StaffAddress;
        private string _StaffPhone;
        private DateTime _StaffBirthday;

        public StaffDTO() { }
        public StaffDTO(string staffId, string staffAccount, string staffPassword, string staffName, int staffIDPer, string staffGender, string staffAddress, string staffPhone, DateTime staffBirthday)
        {
            _StaffId=staffId;
            _StaffAccount=staffAccount;
            _StaffPassword=staffPassword;
            _StaffName=staffName;
            _StaffIDPer=staffIDPer;
            _StaffGender=staffGender;
            _StaffAddress=staffAddress;
            _StaffPhone=staffPhone;
            _StaffBirthday=staffBirthday;
        }

        public string StaffId { get => _StaffId; set => _StaffId = value; }
        public string StaffAccount { get => _StaffAccount; set => _StaffAccount = value; }
        public string StaffPassword { get => _StaffPassword; set => _StaffPassword = value; }
        public string StaffName { get => _StaffName; set => _StaffName = value; }
        public int StaffIDPer { get => _StaffIDPer; set => _StaffIDPer = value; }
        public string StaffGender { get => _StaffGender; set => _StaffGender = value; }
        public string StaffAddress { get => _StaffAddress; set => _StaffAddress = value; }
        public string StaffPhone { get => _StaffPhone; set => _StaffPhone = value; }
        public DateTime StaffBirthday { get => _StaffBirthday; set => _StaffBirthday=value; }
    }
}
