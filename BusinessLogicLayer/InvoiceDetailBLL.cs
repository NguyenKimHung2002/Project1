using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataTransferObject;

namespace BusinessLogicLayer
{
    public class InvoiceDetailBLL
    {
        InvoiceDetailDAL invoiceDetailDAL = new InvoiceDetailDAL();
        public bool CreateInvoiceDetailBLL(InvoiceDetailDTO invoiceDetailDTO)
        {
            return invoiceDetailDAL.CreateInvoiceDetailDAL(invoiceDetailDTO);
        }
    }
}
