using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET.Models
{
    public class Product
    {
        public int productID { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public int CategoryID { get; set; }
        public int onSale { get; set; }
        public int stockLevel { get; set; }
    }
}
