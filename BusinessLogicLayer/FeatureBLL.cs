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
    public class FeatureBLL
    {
        FeatureDAL featureDAL = new FeatureDAL();
        public DataTable GetFeatureNameBLL()
        {
            return featureDAL.GetFeatureNameDAL();
        }
        public DataTable GetDataFeatureBLL()
        {
            return featureDAL.GetDataFeatureDAL();
        }
        public int GetFeatureIdByFeatureNameBLL(FeatureDTO featureDTO)
        {
            return featureDAL.GetFeatureIdByFeatureNameDAL(featureDTO);
        }
        public bool AddFeatureBLL(FeatureDTO featureDTO)
        {
            return featureDAL.AddFeatureDAL(featureDTO);
        }
        public bool UpdateFeatureBLL(FeatureDTO featureDTO)
        {
            return featureDAL.UpdateFeatureDAL(featureDTO);
        }
        public bool DeleteFeatureBLL(FeatureDTO featureDTO)
        {
            return featureDAL.DeleteFeatureDAL(featureDTO);
        }
        public DataTable SearchDataFeatureBLL(FeatureDTO featureDTO)
        {
            return featureDAL.SearchDataFeatureDAL(featureDTO);
        }
    }
}
