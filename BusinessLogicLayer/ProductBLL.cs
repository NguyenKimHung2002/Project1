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
        public int GetTotalDataProductBLL()
        {
            return productDAL.GetTotalDataProductDAL();
        }
        public int GetTotalSearchProductBLL(ProductDTO productDTO)
        {
            return productDAL.GetTotalSearchProductDAL(productDTO);
        }
        public DataTable GetDataProductBLL()
        {
            return productDAL.GetDataProductDAL();
        }
        public DataTable GetDataPaymentBLL(ProductDTO productDTO)
        {
            return productDAL.GetDataPaymentDAL(productDTO);
        }
        public DataTable GetSortedDataPaymentBLL(ProductDTO productDTO, CustomerDTO customerDTO)
        {
            return productDAL.GetSortedDataPaymentDAL(productDTO, customerDTO);
        }
        public DataTable SearchDataPaymentBLL(ProductDTO productDTO)
        {
            return productDAL.SearchDataPaymentDAL(productDTO);
        }
        public DataTable SearchDataProductBLL(ProductDTO productDTO)
        {
            return productDAL.SearchDataProductDAL(productDTO);
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
        public DataTable AddInvoiceDetailBLL(ProductDTO producDTO)
        {
            return productDAL.AddInvoiceDetailDAL(producDTO);
        }
        public DataTable GetSuggestionsBLL(ProductDTO producDTO)
        {
            return productDAL.GetSuggestionsDAL(producDTO);
        }
    }
}
