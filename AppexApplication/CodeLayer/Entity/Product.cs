using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppexApplication.CodeLayer.Entity
{
    public class Product
    {
        private long id;
        private string status;
        private string insertUser;
        private DateTime insertDate;
        private string updateUser;
        private DateTime updateDate;
        private string name;

        public long Id { get => id; set => id = value; }
        public string Status { get => status; set => status = value; }
        public string InsertUser { get => insertUser; set => insertUser = value; }
        public DateTime InsertDate { get => insertDate; set => insertDate = value; }
        public string UpdateUser { get => updateUser; set => updateUser = value; }
        public DateTime UpdateDate { get => updateDate; set => updateDate = value; }
        public string Name { get => name; set => name = value; }
    }
}
