using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class CustommerDTO
    {
        private string _CustommerName;
        private string _CustommerPhone;

        public CustommerDTO(string custommerName, string custommerPhone)
        {
            CustommerName=custommerName;
            CustommerPhone=custommerPhone;
        }
        public CustommerDTO()
        {
        }

        public string CustommerName { get => _CustommerName; set => _CustommerName = value; }
        public string CustommerPhone { get => _CustommerPhone; set => _CustommerPhone=value; }
        public int CustommerNo { get; set; }
    }
}
