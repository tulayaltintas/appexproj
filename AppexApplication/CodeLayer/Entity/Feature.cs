using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppexApplication.CodeLayer.Entity
{
    public class Feature : ConstantVariables
    {
        private long contentId;
        private string featureName;

        public long ContentId { get => contentId; set => contentId = value; }
        public string FeatureName { get => featureName; set => featureName = value; }
    }
}
