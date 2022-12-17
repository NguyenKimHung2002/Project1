using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class FeatureBLL
    {
        FeatureDAL featureDAL = new FeatureDAL();
        public DataTable GetListFeatureTagDAL()
        {
            return featureDAL.GetListFeatureTagDAL();
        }
    }
}
