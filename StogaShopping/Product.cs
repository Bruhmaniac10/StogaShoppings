using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StogaShopping
{
    public class Product
    {
        
        public int ProductId {  get; set; }

        public string Name { get; set; }

        public string Seller { get; set; }

        public double Stars { get; set; }

        public string Review { get; set; }

        public string Description { get; set; }

        public int Price {  get; set; }

        public bool Availability { get; set; }

    }
}
