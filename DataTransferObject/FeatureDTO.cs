using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class FeatureDTO
    {
        private int _FeatureId;
        private string _FeatureName;
        private string _FeatureDescription;

        public FeatureDTO() { }
        public FeatureDTO(int featureId, string featureName, string featureDescription)
        {
            _FeatureId=featureId;
            _FeatureName=featureName;
            _FeatureDescription=featureDescription;
        }

        public int FeatureId { get => _FeatureId; set => _FeatureId = value; }
        public string FeatureName { get => _FeatureName; set => _FeatureName = value; }
        public string FeatureDescription { get => _FeatureDescription; set => _FeatureDescription=value; }
        public string SearchFollowFeatureName { get; set; }
    }
}
