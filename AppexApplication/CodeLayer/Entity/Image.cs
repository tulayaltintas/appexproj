using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppexApplication.CodeLayer.Entity
{
    public class Image
    {
        private long contentId;
        private string imagePath;

        public long ContentId { get => contentId; set => contentId = value; }
        public string ImagePath { get => imagePath; set => imagePath = value; }
    }
}
