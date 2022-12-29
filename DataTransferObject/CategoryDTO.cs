using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class CategoryDTO
    {
        private int _CategoryId;
        private string _CategoryName;
        private string _CategoryDescription;

        public CategoryDTO() { }
        public CategoryDTO(int categoryId, string categoryName, string categoryDescription)
        {
            _CategoryId=categoryId;
            _CategoryName=categoryName;
            _CategoryDescription=categoryDescription;
        }

        public int CategoryId { get => _CategoryId; set => _CategoryId = value; }
        public string CategoryName { get => _CategoryName; set => _CategoryName = value; }
        public string CategoryDescription { get => _CategoryDescription; set => _CategoryDescription=value; }
        public string SearchFollowCategoryName { get; set; }
    }
}
