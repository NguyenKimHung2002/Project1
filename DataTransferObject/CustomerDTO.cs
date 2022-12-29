using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class CustomerDTO
    {
        private int _CustomerId;
        private string _CustomerName;
        private string _CustomerPhone;

        public CustomerDTO() { }
        public CustomerDTO(int customerId, string customerName, string customerPhone)
        {
            _CustomerId=customerId;
            _CustomerName=customerName;
            _CustomerPhone=customerPhone;
        }

        public int CustomerId { get => _CustomerId; set => _CustomerId = value; }
        public string CustomerName { get => _CustomerName; set => _CustomerName = value; }
        public string CustomerPhone { get => _CustomerPhone; set => _CustomerPhone=value; }
        public string SearchFollowCustomerName { get; set; }
    }
}
