using DataAccessLayer;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class CategoryBLL
    {
        CategoryDAL categoryDAL = new CategoryDAL();
        public DataTable GetDataCategoryBLL()
        {
            return categoryDAL.GetDataCategoryDAL();
        }
        public DataTable GetCategoryNameBLL()
        {
            return categoryDAL.GetCategoryNameDAL();
        }
        public int GetLastestCategoryId(CategoryDTO categoryDTO)
        {
            return categoryDAL.GetLastestCategoryIdDAL(categoryDTO);
        }
        public bool AddCategoryBLL(CategoryDTO categoryDTO)
        {
            return categoryDAL.AddCategoryDAL(categoryDTO);
        }
        public bool UpdateCategoryBLL(CategoryDTO categoryDTO)
        {
            return categoryDAL.UpdateCategoryDAL(categoryDTO);
        }
        public bool DeleteCategoryBLL(CategoryDTO categoryDTO)
        {
            return categoryDAL.DeleteCategoryDAL(categoryDTO);
        }
        public DataTable SearchDataCategoryBLL(CategoryDTO categoryDTO)
        {
            return categoryDAL.SearchDataCategoryDAL(categoryDTO);
        }
    }
}
