using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class CategoryDTO
    {
        private string _CategoryName;
        private int _FeatureId;
        public CategoryDTO() { }
        public CategoryDTO(string categoryName, int featureId)
        {
            CategoryName=categoryName;
            FeatureId=featureId;
        }
        public int CategoryId { get; set; }
        public string CategoryName { get => _CategoryName; set => _CategoryName = value; }
        public int FeatureId { get => _FeatureId; set => _FeatureId=value; }
    }
}
