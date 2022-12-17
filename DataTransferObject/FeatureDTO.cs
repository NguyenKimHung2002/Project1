using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class FeatureDTO
    {
        private string _PriceDemand;
        private string _TrustDemand;
        private string _ReduceRisk;
        private string _DeepDetail;
        private string _ServiceDemand;
        private string _Convenience;
        private string _Effectiveness;
        private string _LevelOfInfluence;
        private string _FeatureTag;
        public FeatureDTO() { }
        public FeatureDTO(string priceDemand, string trustDemand, string reduceRisk, string deepDetail, string serviceDemand, string convenience, string effectiveness, string levelOfInfluence, string featureTag)
        {
            PriceDemand=priceDemand;
            TrustDemand=trustDemand;
            ReduceRisk=reduceRisk;
            DeepDetail=deepDetail;
            ServiceDemand=serviceDemand;
            Convenience=convenience;
            Effectiveness=effectiveness;
            LevelOfInfluence=levelOfInfluence;
            FeatureTag=featureTag;
        }
        public string Feature_Id { get; set; }
        public string PriceDemand { get => _PriceDemand; set => _PriceDemand = value; }
        public string TrustDemand { get => _TrustDemand; set => _TrustDemand = value; }
        public string ReduceRisk { get => _ReduceRisk; set => _ReduceRisk = value; }
        public string DeepDetail { get => _DeepDetail; set => _DeepDetail = value; }
        public string ServiceDemand { get => _ServiceDemand; set => _ServiceDemand = value; }
        public string Convenience { get => _Convenience; set => _Convenience = value; }
        public string Effectiveness { get => _Effectiveness; set => _Effectiveness = value; }
        public string LevelOfInfluence { get => _LevelOfInfluence; set => _LevelOfInfluence = value; }
        public string FeatureTag { get => _FeatureTag; set => _FeatureTag=value; }
    }
}
