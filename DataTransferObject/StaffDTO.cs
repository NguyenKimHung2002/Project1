using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class StaffDTO
    {
        private string _StaffName;
        private string _StaffPhone;
        private DateTime _StaffBirthday;
        private string _StaffGender;
        private string _StaffAddress;
        private string _StaffEmail;
        private string _StaffAccount;
        private string _StaffPassword;
        private int _StaffIDPer;

        public StaffDTO(string staffName, string staffPhone, DateTime staffBirthday, string staffGender, string staffAddress, string staffEmail, string staffAccount, string staffPassword, int staffIDPer)
        {
            StaffName=staffName;
            StaffPhone=staffPhone;
            StaffBirthday=staffBirthday;
            StaffGender=staffGender;
            StaffAddress=staffAddress;
            StaffEmail=staffEmail;
            StaffAccount=staffAccount;
            StaffPassword=staffPassword;
            StaffIDPer=staffIDPer;
        }
        public StaffDTO() { }

        public string StaffName { get => _StaffName; set => _StaffName = value; }
        public string StaffPhone { get => _StaffPhone; set => _StaffPhone = value; }
        public DateTime StaffBirthday { get => _StaffBirthday; set => _StaffBirthday = value; }
        public string StaffGender { get => _StaffGender; set => _StaffGender = value; }
        public string StaffAddress { get => _StaffAddress; set => _StaffAddress = value; }
        public string StaffEmail { get => _StaffEmail; set => _StaffEmail = value; }
        public string StaffAccount { get => _StaffAccount; set => _StaffAccount = value; }
        public string StaffPassword { get => _StaffPassword; set => _StaffPassword = value; }
        public int StaffIDPer { get => _StaffIDPer; set => _StaffIDPer=value; }
        public int StaffNo { get; set; }
    }
}
