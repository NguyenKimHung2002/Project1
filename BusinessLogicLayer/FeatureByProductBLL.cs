using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataTransferObject;

namespace BusinessLogicLayer
{
    public class FeatureByProductBLL
    {
        FeatureByProductDAL featureByProductDAL = new FeatureByProductDAL();
        public DataTable GetFeatureByProductBLL(FeatureByProductDTO featureByProductDTO)
        {
            return featureByProductDAL.GetFeatureByProductDAL(featureByProductDTO);
        }
        public int CheckExistsFeatureByProductBLL(FeatureByProductDTO featureByProductDTO, FeatureDTO featureDTO)
        {
            return featureByProductDAL.CheckExistsFeatureByProductDAL(featureByProductDTO, featureDTO);
        }
        public bool AddFeatureByProductBLL(FeatureByProductDTO featureByProductDTO)
        {
            return featureByProductDAL.AddFeatureByProductDAL(featureByProductDTO);
        }
        public bool UpdateFeatureByProductBLL(FeatureByProductDTO featureByProductDTO)
        {
            return featureByProductDAL.UpdateFeatureDAL(featureByProductDTO);
        }
        public bool DeleteFeatureByProductBLL(FeatureByProductDTO featureByProductDTO)
        {
            return featureByProductDAL.DeleteFeatureDAL(featureByProductDTO);
        }
    }
}
