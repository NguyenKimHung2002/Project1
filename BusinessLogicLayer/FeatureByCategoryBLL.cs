using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataTransferObject;

namespace BusinessLogicLayer
{
    public class FeatureByCategoryBLL
    {
        FeatureByCategoryDAL featureByCategoryDAL = new FeatureByCategoryDAL();
        public bool AddFeatureByCategoryBLL(FeatureByCategoryDTO featureByCategoryDTO)
        {
            return featureByCategoryDAL.AddFeatureByCategoryDAL(featureByCategoryDTO);
        }
    }
}