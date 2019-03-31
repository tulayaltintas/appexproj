using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppexApplication.CodeLayer.Entity
{
    public class Color : ConstantVariables
    {
        private long contentId;
        private string colorName;

        public long ContentId { get => contentId; set => contentId = value; }
        public string ColorName { get => colorName; set => colorName = value; }
    }
}
