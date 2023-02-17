using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class FeatureByProductDTO
    {
        private string _ProductId;
        private int _FeatureId;
        private string _FeatureValue;
        public FeatureByProductDTO() { }

        public string ProductId { get => _ProductId; set => _ProductId = value; }
        public int FeatureIdChange { get; set; }
        public int FeatureId { get => _FeatureId; set => _FeatureId = value; }
        public string FeatureValue { get => _FeatureValue; set => _FeatureValue=value; }
    }
}
