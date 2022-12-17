using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataTransferObject;

namespace BusinessLogicLayer
{
    public class InvoiceBLL
    {
        InvoiceDAL invoiceDAL = new InvoiceDAL();
        public bool CreateInvoiceBLL(InvoiceDTO invoiceDTO)
        {
            return invoiceDAL.CreateInvoiceDAL(invoiceDTO);
        }
        public int GetInvoiceNoBLL(InvoiceDTO invoiceDTO)
        {
            return invoiceDAL.GetInvoiceNoDAL(invoiceDTO);
        }
    }
}
