using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeerShop_Jagdeep.Models
{
    public class Price
    {
        public int ID { get; set; }
        public string Rate { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
