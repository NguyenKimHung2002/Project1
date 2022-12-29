using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class InvoiceDTO
    {
        private int _InvoiceId;
        private DateTime _InvoiceDateTime;
        private string _PaymentMethod;
        private int _CustomerId;
        private int _StaffId;
        public InvoiceDTO() { }
        public InvoiceDTO(int invoiceId, DateTime invoiceDateTime, string paymentMethod, int customerId, int staffId)
        {
            _InvoiceId=invoiceId;
            _InvoiceDateTime=invoiceDateTime;
            _PaymentMethod=paymentMethod;
            _CustomerId=customerId;
            _StaffId=staffId;
        }

        public int InvoiceId { get => _InvoiceId; set => _InvoiceId = value; }
        public DateTime InvoiceDateTime { get => _InvoiceDateTime; set => _InvoiceDateTime = value; }
        public string PaymentMethod { get => _PaymentMethod; set => _PaymentMethod = value; }
        public int CustomerId { get => _CustomerId; set => _CustomerId = value; }
        public int StaffId { get => _StaffId; set => _StaffId=value; }
    }
}
