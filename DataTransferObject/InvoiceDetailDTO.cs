using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class InvoiceDetailDTO
    {
        private int _InvoiceDetailNo;
        private int _InvoiceNo;
        private string _ProductNo;
        private int _UnitPrice;
        private int _ProductNumber;
        public InvoiceDetailDTO() { }
        public InvoiceDetailDTO(int invoiceDetailNo, int invoiceNo, string productNo, int unitPrice, int productNumber)
        {
            InvoiceDetailNo=invoiceDetailNo;
            InvoiceNo=invoiceNo;
            ProductNo=productNo;
            UnitPrice=unitPrice;
            ProductNumber=productNumber;
        }

        public int InvoiceDetailNo { get => _InvoiceDetailNo; set => _InvoiceDetailNo = value; }
        public int InvoiceNo { get => _InvoiceNo; set => _InvoiceNo = value; }
        public string ProductNo { get => _ProductNo; set => _ProductNo = value; }
        public int UnitPrice { get => _UnitPrice; set => _UnitPrice = value; }
        public int ProductNumber { get => _ProductNumber; set => _ProductNumber=value; }
    }
}
