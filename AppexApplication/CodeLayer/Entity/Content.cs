using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppexApplication.CodeLayer.Entity
{
    public class Content
    {
        private long id;
        private string status;
        private string insertUser;
        private DateTime insertDate;
        private string updateUser;
        private Nullable<DateTime> updateDate;
        private string price;
        private double rate;
        private string description;
        private long featureId;
        private long colorId;
        private long imageId;

        public long Id { get => id; set => id = value; }
        public string Status { get => status; set => status = value; }
        public string InsertUser { get => insertUser; set => insertUser = value; }
        public DateTime InsertDate { get => insertDate; set => insertDate = value; }
        public string UpdateUser { get => updateUser; set => updateUser = value; }
        public DateTime? UpdateDate { get => updateDate; set => updateDate = value; }
        public string Price { get => price; set => price = value; }
        public double Rate { get => rate; set => rate = value; }
        public string Description { get => description; set => description = value; }
        public long FeatureId { get => featureId; set => featureId = value; }
        public long ColorId { get => colorId; set => colorId = value; }
        public long ImageId { get => imageId; set => imageId = value; }
    }
}
