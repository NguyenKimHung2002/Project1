using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataTransferObject;
using System.Data;

namespace BusinessLogicLayer
{
    public class ProductBLL
    {
        ProductDAL productDAL = new ProductDAL();
        public DataTable GetDataProductBLL()
        {
            return productDAL.GetDataProductDAL();
        }
        public DataTable AddInvoiceDetailBLL(ProductDTO producDTO)
        {
            return productDAL.AddInvoiceDetailDAL(producDTO);
        }
    }
}
