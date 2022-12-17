using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class ProductDTO
    {
        private string _ProductNo;
        private string _ProductName;
        private int _QuantityNo;
        private int _UnitPriceImport;
        private int _UnitPriceExport;
        public ProductDTO() { }
        public ProductDTO(string productNo, string productName, int quantityNo, int unitPriceImport, int unitPriceExport)
        {
            _ProductNo=productNo;
            _ProductName=productName;
            _QuantityNo=quantityNo;
            _UnitPriceImport=unitPriceImport;
            _UnitPriceExport=unitPriceExport;
        }
        public string ProductNo { get => _ProductNo; set => _ProductNo = value; }
        public string ProductName { get => _ProductName; set => _ProductName = value; }
        public int QuantityNo { get => _QuantityNo; set => _QuantityNo = value; }
        public int UnitPriceImport { get => _UnitPriceImport; set => _UnitPriceImport = value; }
        public int UnitPriceExport { get => _UnitPriceExport; set => _UnitPriceExport=value; }
        public int Category_Id { get; set; }
    }
}
