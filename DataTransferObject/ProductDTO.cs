using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class ProductDTO
    {
        private string _ProductId;
        private string _ProductName;
        private int _ProductQuantity;
        private string _ProductUnit;
        private string _ImportPrice;
        private string _ExportPrice;
        private string _ProductDescription;

        public ProductDTO() { }
        public ProductDTO(string productId, string productName, int productQuantity, string productUnit, string importPrice, string exportPrice, string productDescription)
        {
            _ProductId=productId;
            _ProductName=productName;
            _ProductQuantity=productQuantity;
            _ProductUnit=productUnit;
            _ImportPrice=importPrice;
            _ExportPrice=exportPrice;
            _ProductDescription=productDescription;
        }

        public string ProductId { get => _ProductId; set => _ProductId = value; }
        public string ProductName { get => _ProductName; set => _ProductName = value; }
        public int ProductQuantity { get => _ProductQuantity; set => _ProductQuantity = value; }
        public string ProductUnit { get => _ProductUnit; set => _ProductUnit = value; }
        public string ImportPrice { get => _ImportPrice; set => _ImportPrice = value; }
        public string ExportPrice { get => _ExportPrice; set => _ExportPrice = value; }
        public string ProductDescription { get => _ProductDescription; set => _ProductDescription=value; }
        //Difference properties
        public string SearchDataPayment { get; set; }
        public string SearchDataProduct { get; set; }
        public int TotalRecords { get; set; }
        public int PageSize { get; set; }
        public int PageIndex { get; set; }
    }
}
