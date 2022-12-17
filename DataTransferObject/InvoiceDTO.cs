using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class InvoiceDTO
    {
        private int _InvoiceNo;
        private DateTime _InvoiceDateTime;
        private int _CustommerNo;
        private int _StaffNo;
        public InvoiceDTO() { }
        public InvoiceDTO(int invoiceNo, DateTime invoiceDateTime, int custommerNo, int staffNo)
        {
            InvoiceNo=invoiceNo;
            InvoiceDateTime=invoiceDateTime;
            CustommerNo=custommerNo;
            StaffNo=staffNo;
        }

        public int InvoiceNo { get => _InvoiceNo; set => _InvoiceNo = value; }
        public DateTime InvoiceDateTime { get => _InvoiceDateTime; set => _InvoiceDateTime = value; }
        public int CustommerNo { get => _CustommerNo; set => _CustommerNo = value; }
        public int StaffNo { get => _StaffNo; set => _StaffNo=value; }
    }
}
