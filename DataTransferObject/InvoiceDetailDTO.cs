using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class InvoiceDetailDTO
    {
        private int _InvoiceDetailId;
        private int _InvoiceId;
        private string _ProductId;
        private int _SequenceNo;
        private float _QuantityNo;
        private float _UnitPrice;
        private float _Discount;

        public InvoiceDetailDTO() { }
        public InvoiceDetailDTO(int invoiceDetailId, int invoiceId, string productId, int sequenceNo, float quantityNo, float unitPrice, float discount)
        {
            _InvoiceDetailId=invoiceDetailId;
            _InvoiceId=invoiceId;
            _ProductId=productId;
            _SequenceNo=sequenceNo;
            _QuantityNo=quantityNo;
            _UnitPrice=unitPrice;
            _Discount=discount;
        }

        public int InvoiceDetailId { get => _InvoiceDetailId; set => _InvoiceDetailId = value; }
        public int InvoiceId { get => _InvoiceId; set => _InvoiceId = value; }
        public string ProductId { get => _ProductId; set => _ProductId = value; }
        public int SequenceNo { get => _SequenceNo; set => _SequenceNo = value; }
        public float QuantityNo { get => _QuantityNo; set => _QuantityNo = value; }
        public float UnitPrice { get => _UnitPrice; set => _UnitPrice = value; }
        public float Discount { get => _Discount; set => _Discount=value; }
    }
}
