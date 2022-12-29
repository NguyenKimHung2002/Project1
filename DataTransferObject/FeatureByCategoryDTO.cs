using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class FeatureByCategoryDTO
    {
        private int _FeatureId;
        private int _CategoryId;
        public FeatureByCategoryDTO() { }
        public int FeatureId { get => _FeatureId; set => _FeatureId = value; }
        public int CategoryId { get => _CategoryId; set => _CategoryId=value; }
    }
}
