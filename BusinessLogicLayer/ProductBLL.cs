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
        public DataTable GetDataPaymentBLL()
        {
            return productDAL.GetDataPaymentDAL();
        }
        public DataTable SearchDataPaymentBLL(ProductDTO productDTO)
        {
            return productDAL.SearchDataPaymentDAL(productDTO);
        }
        public bool AddProductBLL(ProductDTO productDTO)
        {
            return productDAL.AddProductDAL(productDTO);
        }
        public bool UpdateProductBLL(ProductDTO productDTO)
        {
            return productDAL.UpdateProductDAL(productDTO);
        }
        public bool DeleteProductBLL(ProductDTO productDTO)
        {
            return productDAL.DeleteProductDAL(productDTO);
        }
        public int CheckExistsProductIdBLL(ProductDTO productDTO)
        {
            return productDAL.CheckExistsProductIdDAL(productDTO);
        }
        public DataTable AddInvoiceDetailBLL(ProductDTO producDTO)
        {
            return productDAL.AddInvoiceDetailDAL(producDTO);
        }
    }
}
