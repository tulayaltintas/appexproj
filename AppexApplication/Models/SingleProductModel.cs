using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppexApplication.Models
{
    public class SingleProductModel
    {
        private string name;

        //public string Name { get => name; set => name = value; }

        public string Name { get; set; }

        public bool ShowName => !string.IsNullOrEmpty(Name);
    }
}
